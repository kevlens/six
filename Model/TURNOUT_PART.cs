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
    
    public partial class TURNOUT_PART
    {
        public string PART_ID { get; set; }
        public string TURNOUT_ID { get; set; }
        public string PART_NAME { get; set; }
        public Nullable<System.DateTime> PART_DATE { get; set; }
        public string PART_UNIT { get; set; }
        public string PART_FAC { get; set; }
        public string PART_CHARGER { get; set; }
        public string PART_NOTE { get; set; }
        public string PART_MODEL { get; set; }
    
        public virtual TURNOUT_BASE TURNOUT_BASE { get; set; }
    }
}