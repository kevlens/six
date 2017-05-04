using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EasyUIDEPTTree
    {
        public string DEPT_CODE { set; get; }
        public string deptname { set; get; }
        public string state { set; get; }
        public string iconCls { set; get; }
        public bool Checked { set; get; }
        public string deptnote { set; get; }
        public List<EasyUIDEPTTree> children { set; get; }
    }
}
