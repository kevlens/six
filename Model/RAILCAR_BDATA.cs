//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class RAILCAR_BDATA
    {
        public RAILCAR_BDATA()
        {
            this.RAILCAR_FILE = new HashSet<RAILCAR_FILE>();
        }
    
        public string PHONE { get; set; }
        public string VIDEO_PATH { get; set; }
        public string COMMENTS { get; set; }
        public string DEPT_CODE { get; set; }
        public string PKID { get; set; }
        public string NAME { get; set; }
        public string DEVICE_CODE { get; set; }
    
        public virtual SYS_DEPT SYS_DEPT { get; set; }
        public virtual ICollection<RAILCAR_FILE> RAILCAR_FILE { get; set; }
    }
}
