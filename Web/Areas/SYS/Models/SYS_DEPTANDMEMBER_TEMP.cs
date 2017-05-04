using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Areas.Models
{
    public class SYS_DEPTANDMEMBER_TEMP
    {
        public string ORGRY_CODE { set; get; }
        public string PARENT_CODE { get; set; }
        public string ORGRY_NAME { get; set; }
        public string RYMOBILE { get; set; }
        public string ICO { get; set; }
        public string STATE { get; set; }

        public string PHONE { get; set; }
        public Nullable<decimal> ORDER { get; set; }

        #region cwb 将权限菜单转为ZTree
        private ZTreeNode TransformZTreeNode(bool isCheckAll)
        {
            string mytext = this.ORGRY_NAME;
            if (!string.IsNullOrEmpty(RYMOBILE))
            {
                mytext += "-" + RYMOBILE;
            }
            //string orgOpenState=ConfigurationSettings.AppSettings["OrgOpenState"];
            ZTreeNode zTreeNode = new ZTreeNode()
            {
                id = this.ORGRY_CODE,
                name = mytext,
                open = this.STATE.Equals("1") ? "true" : "false",//只有存在下级才可设为closed，否则会循环查询
                iconSkin = this.ICO,
                Checked = isCheckAll,
                attributes = new { mobile = RYMOBILE, ico = ICO, phone = PHONE },
                children = new List<ZTreeNode>()
            };
            return zTreeNode;
        }
        #endregion


        #region    把权限菜单转为符合ZTree的带有递归关系的集合
        public static List<ZTreeNode> ConvertZTreeNodes(List<SYS_DEPTANDMEMBER_TEMP> listMenus, string pid, string id, bool isCheckAll)
        {
            List<ZTreeNode> listTreeNodes = new List<ZTreeNode>();
            LoadZTreeNode(listMenus, listTreeNodes, pid, isCheckAll);
            DelZtreeClosed(listTreeNodes, id);
            return listTreeNodes;
        }
        /// <summary>
        /// 根据是否有下级来更改打开关闭状态,这是解决同步加载的问题，如果是异步加载？
        /// </summary>
        /// <param name="listTreeNodes"></param>
        private static void DelZtreeClosed(List<ZTreeNode> listTreeNodes, string id)
        {
            foreach (ZTreeNode uinode in listTreeNodes)
            {
                //只有存在下级才可设为closed，否则会循环查询
                if (uinode.children.Count == 0 && uinode.open == "false")
                {
                    uinode.open = "true";
                }
                else
                {
                    if (uinode.id == id)//默认将根结点设为打开
                    {
                        uinode.open = "true";
                    }
                    DelZtreeClosed(uinode.children, id);
                }
            }
        }
        private static void LoadZTreeNode(List<SYS_DEPTANDMEMBER_TEMP> listMenus, List<ZTreeNode> listTreeNodes, string pid, bool isCheckAll)
        {
            foreach (SYS_DEPTANDMEMBER_TEMP menu in listMenus)
            {
                if (menu.PARENT_CODE == pid)
                {
                    ZTreeNode node = menu.TransformZTreeNode(isCheckAll);
                    listTreeNodes.Add(node);
                    LoadZTreeNode(listMenus, node.children, node.id, isCheckAll);
                }

            }
        }
        #endregion
    }
}