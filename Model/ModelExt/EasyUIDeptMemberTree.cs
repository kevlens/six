using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelExt
{
    public class EasyUIDeptMemberTree
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string DEPT_CODE { get; set; }
        public string MOBILE { get; set; }
        public string JOB { get; set; }
        public string PHONE { get; set; }
        public string NOTE { get; set; }
        public string LOCATION_FLAG { get; set; }
        public string INTELLIGENCE { get; set; }
        public string POS_LEVEL { get; set; }
        public string MOBILE_STATE { get; set; }
        public string state { set; get; }
        public string iconCls { set; get; }
        public bool Checked { set; get; }
        public List<EasyUIDeptMemberTree> children { set; get; }
    }
}
