//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Model
{
	public partial class RULE_PARSE_MARKUP
	{
		public RULE_PARSE_MARKUP ToPOCO(bool isPOCO = true){
			return new RULE_PARSE_MARKUP(){
				QUERY_ID = this.QUERY_ID,
				DOCUMENT = this.DOCUMENT,
				DOCCODE = this.DOCCODE,
				DOCNAME = this.DOCNAME,
				PROBLEMID = this.PROBLEMID,
				PROBLEM = this.PROBLEM,
				PROBLEMKEYS = this.PROBLEMKEYS,
				HITNUM = this.HITNUM,
				MATCHNUM = this.MATCHNUM,
				SCORE = this.SCORE,
				MEMO = this.MEMO,
				CREATOR = this.CREATOR,
				CREATETIME = this.CREATETIME,
				DEPTCODE = this.DEPTCODE,
			};
		}
	} 
}