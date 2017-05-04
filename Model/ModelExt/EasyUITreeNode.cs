using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelExt
{
    public class EasyUITreeNode
    {
        public string id { set; get; }
        public string text { set; get; }
        public string state { set; get; }
        public string iconCls { set; get; }
        public string haspermission { set; get; }
        public string isdefu { set; get; }
        public string isdefuopen { set; get; }
        public string area { set; get; }
        public string gisorder { set; get; }
        public bool Checked { set; get; }
        public object attributes { set; get; }
        public List<EasyUITreeNode> children { set; get; }
    }
}
