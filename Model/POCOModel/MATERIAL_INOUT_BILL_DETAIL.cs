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
	public partial class MATERIAL_INOUT_BILL_DETAIL
	{
		public MATERIAL_INOUT_BILL_DETAIL ToPOCO(bool isPOCO = true){
			return new MATERIAL_INOUT_BILL_DETAIL(){
				PKID = this.PKID,
				BILL_NUM = this.BILL_NUM,
				TYPE = this.TYPE,
				NAME = this.NAME,
				MODEL = this.MODEL,
				MATERIAL_NO = this.MATERIAL_NO,
				LABEL = this.LABEL,
				SINGLE_NUM = this.SINGLE_NUM,
				SINGLE_UNIT = this.SINGLE_UNIT,
				NUM = this.NUM,
				UNIT = this.UNIT,
				SUB_TOTAL = this.SUB_TOTAL,
				NOTE = this.NOTE,
				DEPID = this.DEPID,
			};
		}
	} 
}