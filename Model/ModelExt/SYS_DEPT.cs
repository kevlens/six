using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class SYS_DEPT
    {
        #region 将权限菜单转为EASYUI树
        private EasyUIDEPTTree TransformTreeNode()
        {
            //string orgOpenState = ConfigurationSettings.AppSettings["OrgOpenState"];
            EasyUIDEPTTree easyUITreeNode = new EasyUIDEPTTree()
            {
                DEPT_CODE = this.DEPT_CODE,
                deptname = this.DEPT_NAME,
                state = this.STATUS_FLAG.Equals("1") ? "open" : "closed",//只有存在下级才可设为closed，否则会循环查询
                iconCls = this.C_ICO,
                Checked = true,//this.STATE == 1 ? true : false,
                deptnote = this.NOTE,
                children = new List<EasyUIDEPTTree>()
            };
            return easyUITreeNode;
        }
        #endregion


        #region 把权限菜单转为符合EASYUI的带有递归关系的集合
        public static List<EasyUIDEPTTree> ConvertTreeNodes(List<SYS_DEPT> listMenus, string pid, string id)
        {
            List<EasyUIDEPTTree> listTreeNodes = new List<EasyUIDEPTTree>();
            LoadTreeNode(listMenus, listTreeNodes, pid);
            DelClosed(listTreeNodes, id);
            return listTreeNodes;
        }
        /// <summary>
        /// 根据是否有下级来更改打开关闭状态,这是解决同步加载的问题，如果是异步加载？
        /// </summary>
        /// <param name="listTreeNodes"></param>
        private static void DelClosed(List<EasyUIDEPTTree> listTreeNodes, string id)
        {
            foreach (EasyUIDEPTTree uinode in listTreeNodes)
            {
                //只有存在下级才可设为closed，否则会循环查询
                if (uinode.children.Count == 0 && uinode.state == "closed")
                {
                    uinode.state = "open";
                }
                else
                {
                    if (uinode.DEPT_CODE == id)//默认将根结点设为打开
                    {
                        uinode.state = "open";
                    }
                    DelClosed(uinode.children, id);
                }
            }
        }
        private static void LoadTreeNode(List<SYS_DEPT> listMenus, List<EasyUIDEPTTree> listTreeNodes, string pid)
        {
            foreach (SYS_DEPT menu in listMenus)
            {
                if (menu.PARENT_CODE == pid)
                {
                    EasyUIDEPTTree node = menu.TransformTreeNode();
                    listTreeNodes.Add(node);
                    LoadTreeNode(listMenus, node.children, node.DEPT_CODE);
                }

            }
        }
        #endregion
    }
}
