using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ModelExt;

namespace Model
{
    public partial class SYS_DEPTANDMEMBER
    {
        public string ORGRY_CODE { set; get; }
        public string PARENT_CODE { get; set; }
        public string ORGRY_NAME { get; set; }
        public string RYMOBILE { get; set; }
        public string ICO { get; set; }
        public string STATE { get; set; }

        public string PHONE { get; set; }
        public Nullable<decimal> ORDER { get; set; }


        #region 将权限菜单转为EASYUI树
        private EasyUITreeNode TransformTreeNode(bool isCheckAll)
        {
            string mytext = this.ORGRY_NAME;
            if (!string.IsNullOrEmpty(RYMOBILE))
            {
                mytext += "-" + RYMOBILE;
            }
            //string orgOpenState=ConfigurationSettings.AppSettings["OrgOpenState"];
            EasyUITreeNode easyUITreeNode = new EasyUITreeNode()
            {
                id = this.ORGRY_CODE,
                text = mytext,
                state = this.STATE.Equals("1") ? "open" : "closed",//只有存在下级才可设为closed，否则会循环查询
                iconCls = this.ICO,
                Checked = isCheckAll?true:(this.STATE.Equals("C")?true:false),
                attributes = new { mobile = RYMOBILE, ico = ICO, phone = PHONE },
                children = new List<EasyUITreeNode>()
            };
            return easyUITreeNode;
        }
        #endregion


        #region 把权限菜单转为符合EASYUI的带有递归关系的集合
        public static List<EasyUITreeNode> ConvertTreeNodes(List<SYS_DEPTANDMEMBER> listMenus, string pid, string id,bool isCheckAll)
        {
            List<EasyUITreeNode> listTreeNodes = new List<EasyUITreeNode>();
            LoadTreeNode(listMenus, listTreeNodes, pid,isCheckAll);
            DelClosed(listTreeNodes, id);
            return listTreeNodes;
        }
        /// <summary>
        /// 根据是否有下级来更改打开关闭状态,这是解决同步加载的问题，如果是异步加载？
        /// </summary>
        /// <param name="listTreeNodes"></param>
        private static void DelClosed(List<EasyUITreeNode> listTreeNodes, string id)
        {
            foreach (EasyUITreeNode uinode in listTreeNodes)
            {
                //只有存在下级才可设为closed，否则会循环查询
                if (uinode.children.Count == 0 && uinode.state == "closed")
                {
                    uinode.state = "open";
                }
                else
                {
                    if (uinode.id == id)//默认将根结点设为打开
                    {
                        uinode.state = "open";
                    }
                    DelClosed(uinode.children, id);
                }
            }
        }
        private static void LoadTreeNode(List<SYS_DEPTANDMEMBER> listMenus, List<EasyUITreeNode> listTreeNodes, string pid, bool isCheckAll)
        {
            foreach (SYS_DEPTANDMEMBER menu in listMenus)
            {
                if (menu.PARENT_CODE == pid)
                {
                    EasyUITreeNode node = menu.TransformTreeNode(isCheckAll);
                    listTreeNodes.Add(node);
                    LoadTreeNode(listMenus, node.children, node.id,isCheckAll);
                }

            }
        }
        #endregion
    }
}
