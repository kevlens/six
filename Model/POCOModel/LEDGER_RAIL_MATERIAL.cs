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
	public partial class LEDGER_RAIL_MATERIAL
	{
		public LEDGER_RAIL_MATERIAL ToPOCO(bool isPOCO = true){
			return new LEDGER_RAIL_MATERIAL(){
				PKID = this.PKID,
				MATERIAL_NAME = this.MATERIAL_NAME,
				MATERIAL_TYPE = this.MATERIAL_TYPE,
				DRAW_NUM = this.DRAW_NUM,
				TRACK_TYPE = this.TRACK_TYPE,
				UNIT = this.UNIT,
				EARLY_NUM = this.EARLY_NUM,
				REVENUE_MONTH = this.REVENUE_MONTH,
				CONSUMPTION_MONTH = this.CONSUMPTION_MONTH,
				END_NUMBER = this.END_NUMBER,
				STORAGE_LOCATION = this.STORAGE_LOCATION,
				MILEAGE = this.MILEAGE,
				DEPT_NAME = this.DEPT_NAME,
				UNIT_LEADER = this.UNIT_LEADER,
				CHIEF = this.CHIEF,
				AUTHOR = this.AUTHOR,
				CHIEF_TIME = this.CHIEF_TIME,
				DEMO = this.DEMO,
				DEPT_CODE = this.DEPT_CODE,
				INPUT_DATE = this.INPUT_DATE,
				INPUT_USER = this.INPUT_USER,
			};
		}
	} 
}