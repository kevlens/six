/**
 * Created by fwy-tech on 14-4-11.
 */
ko.bindingHandlers.etreegrid = {
    editing: false,  //自定义属性，用于判断是否正在进行编辑中...
    editIndex: 0,    //当前正在修改的索引行
    init: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
        var self = ko.bindingHandlers.etreegrid;//获取自身的引用
        /*this.tree = {
         url: "resources/data/treegrid_data2.json",
         treeField: "Name",
         idField: "ID",
         saveUrl: "resources/data/save.json",
         deleteUrl: "resources/data/delete.json"
         };*/
        var opts = valueAccessor();  //获取用来绑定的数据， data-bind="etreegrid: tree"
        $(element).treegrid({  //easyUI的treegrid绑定
            url: opts.url,
            treeField: opts.treeField,
            idField: opts.idField,
            onDblClickRow: function (node) {
                if (viewModel.add) //viewModel — 传递给ko.applyBindings使用的 view model参数，如果是模板内部的话，
                    editRow(node); // 那这个参数就是传递给该模板的数据
            },
            onClickCell: function () {
                if (viewModel.add) {
                    saveRow();
                }
            }
        });

        viewModel.add = function () {
            addRow(getSelectedRow());
        };

        viewModel.edit = function () {
            editRow(getSelectedRow());
        };

        viewModel.remove = function () {
            removeRow(getSelectedRow());
        };

        viewModel.cancel = function () {
            var node = getSelectedRow();
            if (viewModel.onCancel) {
                viewModel.onCancel(node);
            }
            $(element).treegrid("unselectAll");
            try {
                if (self.editing) {
                    $(element).treegrid("cancelEdit", self.editIndex);
                    $(element).treegrid("refresh", self.editIndex);
                    self.editing = false;
                }
            } catch (ex) {
                self.editing = false;
                self.editIndex = 0;
            }
        };

        function getSelectedRow() {
            return $(element).treegrid("getSelected");
        }

        function saveRow() {
            var rowIndex = self.editIndex;
            if (rowIndex == 0) {
                return;
            }
            self.editIndex = 0;
            self.editing = false;

            $(element).treegrid("endEdit", rowIndex);
            $.ajax({
                async: false,
                url: opts.saveUrl,
                method: "POST",
                data: $(element).treegrid("find", rowIndex),
                success: function (data) {
                    $(element).treegrid("refresh", rowIndex);
                    if (viewModel.onSaved) {
                        viewModel.onSaved(data, rowIndex);
                    }
                },
                error: function () {
                }
            });
        }

        function editRow(node) {
            if (!node || node[opts.idField] == self.editIndex) return;
            saveRow();
            self.editing = true;
            self.editIndex = node[opts.idField];//获取主键ID的值
            console.log(self.editIndex);

            $(element).treegrid('select', self.editIndex);
            $(element).treegrid("beginEdit", self.editIndex);
            if (viewModel.onEditing) {//如果设置了回调，则执行此回调
                viewModel.onEditing(node);
            }
        }

        function addRow(parentNode) {
            if (self.editing) return;
            var parentId = parentNode ? parentNode[opts.idField] : 0;
            var newNode = viewModel.newNode(parentId);
            $(element).treegrid("append", { parent: parentId, data: [newNode] });
            editRow(newNode);
        }

        function removeRow(node) {
            if (!node) return;
            if (viewModel.onRemoving ) {
                var result =viewModel.onRemoving(node);
                if (!result){
                    return false;
                }
            }
            $.messager.confirm('确认', '你确定要删除吗？', function (r) {
                if (!r) return;
                $.post(opts.deleteUrl + "?id=" + node[opts.idField], function (data, statusText) {
                    if (viewModel.onRemoved) {
                        viewModel.onRemoved(data);
                    }
                    else {
                        if (statusText == "success") {

                            $(element).treegrid("remove", node[opts.idField]);
                        }
                        else {
                            $.messager.alert('警告', "删除失败", 'warning');
                        }
                    }

                });

            });
        }
    }
};