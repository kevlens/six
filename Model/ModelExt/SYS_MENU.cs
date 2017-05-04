using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ModelExt;

namespace Model
{
    public partial class SYS_MENU
    {
        #region 将权限菜单转为EASYUI树
        public EasyUITreeNode TransformTreeNode()
        {
            //int menuCloseState =Convert.ToInt32(ConfigurationSettings.AppSettings["MenuCloseState"]);
            EasyUITreeNode easyUITreeNode = new EasyUITreeNode()
            {
                id = this.MENU_ID,
                text = this.MENU_NAME,
                state = this.MENU_LEVEL == 3 ? "closed" : "open",//只有存在下级才可设为closed，否则会循环查询
                iconCls = this.C_ICO,
                Checked = true,//是否选中,
                area = this.AREA, 
                haspermission=string.Empty,//用于平台子系统权限判断
                isdefu = string.Empty,//用于平台获取默认子系统
                isdefuopen=string.Empty,//用于打开默认二，三级菜单
                gisorder=this.GIS_ORDER==null?string.Empty:this.GIS_ORDER,//用于加载二三级菜单
                attributes = new { url = GetUrl(), menulevel = this.MENU_LEVEL },
                children = new List<EasyUITreeNode>()
            };
            return easyUITreeNode;
        }
        private string GetUrl()
        {
            return FormatUrl(this.AREA)
                  + FormatUrl(this.CONTROLLER)
                  + FormatUrl(this.ACTION);
        }
        private string FormatUrl(string name)
        {
            return string.IsNullOrEmpty(name) ? "" : "/" + name;
        }
        #endregion

        #region 把权限菜单转为符合EASYUI的带有递归关系的集合
        public static List<EasyUITreeNode> ConvertTreeNodes(List<SYS_MENU> listMenus, string pid)
        {
            List<EasyUITreeNode> listTreeNodes = new List<EasyUITreeNode>();
            LoadTreeNode(listMenus, listTreeNodes, pid);
            DelClosed(listTreeNodes);
            return listTreeNodes;
        }
        /// <summary>
        /// 根据是否有下级来更改打开关闭状态,这是解决同步加载的问题，如果是异步加载？
        /// </summary>
        /// <param name="listTreeNodes"></param>
        private static void DelClosed(List<EasyUITreeNode> listTreeNodes)
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
                    DelClosed(uinode.children);
                }
            }
        }
        private static void LoadTreeNode(List<SYS_MENU> listMenus, List<EasyUITreeNode> listTreeNodes, string pid)
        {
            foreach (SYS_MENU menu in listMenus)
            {
                if (menu.PARENT_ID.ToString() == pid)
                {
                    EasyUITreeNode node = menu.TransformTreeNode();
                    //if (!string.IsNullOrEmpty(node.gisorder)) {
                    //    node.text = "GIS监控";
                    //}
                    listTreeNodes.Add(node);
                    LoadTreeNode(listMenus, node.children, node.id);
                }

            }
        }
        #endregion
    }
}
