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
	public partial class TASK_UNLOAD_TIE
	{
		public TASK_UNLOAD_TIE ToPOCO(bool isPOCO = true){
			return new TASK_UNLOAD_TIE(){
				PKID = this.PKID,
				DEPTID = this.DEPTID,
				IS_SUBMIT = this.IS_SUBMIT,
				CREATE_TIME = this.CREATE_TIME,
				CREATE_USER = this.CREATE_USER,
				GWD_CODE = this.GWD_CODE,
				DEPT_CODE = this.DEPT_CODE,
				GQ_CODE = this.GQ_CODE,
				YEAR = this.YEAR,
				MONTH = this.MONTH,
				DAILY = this.DAILY,
				FOUND_DATE = this.FOUND_DATE,
				GOODS_NAME = this.GOODS_NAME,
				RECOVER_SECTION = this.RECOVER_SECTION,
				MILE = this.MILE,
				PLAN_TIME = this.PLAN_TIME,
				REAL_TIME = this.REAL_TIME,
				PROLONG = this.PROLONG,
				UNLOAD_NUMB = this.UNLOAD_NUMB,
				UNLOAD_NUMG = this.UNLOAD_NUMG,
				BUSNO = this.BUSNO,
				SENDS_FACTORY = this.SENDS_FACTORY,
				MEMO = this.MEMO,
				REPLACE_FLAG = this.REPLACE_FLAG,
				REPLACE_DATE = this.REPLACE_DATE,
			};
		}
	} 
}
