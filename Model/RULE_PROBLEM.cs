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
    
    public partial class RULE_PROBLEM
    {
        public RULE_PROBLEM()
        {
            this.RULE_PARSE_RESULT = new HashSet<RULE_PARSE_RESULT>();
            this.RULE_PROBLEM_BLAME = new HashSet<RULE_PROBLEM_BLAME>();
            this.RULE_PROBLEM_KEYWORD = new HashSet<RULE_PROBLEM_KEYWORD>();
            this.RULE_PROBLEM_PUNISH = new HashSet<RULE_PROBLEM_PUNISH>();
        }
    
        public string PKID { get; set; }
        public string DEPT_CODE { get; set; }
        public string INSPECTOR { get; set; }
        public string INSPECT_DEPT_CODE { get; set; }
        public string INSPECT_POST { get; set; }
        public Nullable<System.DateTime> INSPECT_TIME { get; set; }
        public string PROBLEM { get; set; }
        public string PROFESSION_CAT { get; set; }
        public string PROBLEM_NATURE { get; set; }
        public string PROBLEM_LEVEL { get; set; }
        public Nullable<decimal> SCORE { get; set; }
        public string RECTIFICATION_DEADLINE { get; set; }
        public string RECTIFICATION_STATUS { get; set; }
        public string RECTIFICATION_DESC { get; set; }
        public string BULLETIN_NO { get; set; }
        public string CHIEF_INSTR { get; set; }
        public string DIRECTOR_INSTR { get; set; }
        public string ORTHER { get; set; }
        public string ANALYSIS_FLAG { get; set; }
        public string DOC_FLAG { get; set; }
        public string MEMO { get; set; }
        public string CREATOR { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string JOB { get; set; }
        public string INSPECT_OFFICE { get; set; }
        public string CREATOR_OFFICE { get; set; }
    
        public virtual RULE_BDATE_DIC RULE_BDATE_DIC { get; set; }
        public virtual RULE_BDATE_DIC RULE_BDATE_DIC1 { get; set; }
        public virtual RULE_BDATE_DIC RULE_BDATE_DIC2 { get; set; }
        public virtual RULE_BDATE_DIC RULE_BDATE_DIC3 { get; set; }
        public virtual ICollection<RULE_PARSE_RESULT> RULE_PARSE_RESULT { get; set; }
        public virtual ICollection<RULE_PROBLEM_BLAME> RULE_PROBLEM_BLAME { get; set; }
        public virtual SYS_DEPT SYS_DEPT { get; set; }
        public virtual SYS_DEPT SYS_DEPT1 { get; set; }
        public virtual ICollection<RULE_PROBLEM_KEYWORD> RULE_PROBLEM_KEYWORD { get; set; }
        public virtual ICollection<RULE_PROBLEM_PUNISH> RULE_PROBLEM_PUNISH { get; set; }
    }
}
