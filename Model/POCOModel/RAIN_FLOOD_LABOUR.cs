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
	public partial class RAIN_FLOOD_LABOUR
	{
		public RAIN_FLOOD_LABOUR ToPOCO(bool isPOCO = true){
			return new RAIN_FLOOD_LABOUR(){
				FLOODLABOUR_ID = this.FLOODLABOUR_ID,
				LABOUR_MAJOR = this.LABOUR_MAJOR,
				PLACE = this.PLACE,
				CONTACTS = this.CONTACTS,
				PHONE = this.PHONE,
				WORKER_NUM = this.WORKER_NUM,
				MAGRANT_NUM = this.MAGRANT_NUM,
				BIG_MECHANICS = this.BIG_MECHANICS,
				DEMO = this.DEMO,
				GWD_CODE = this.GWD_CODE,
				DEP_CODE = this.DEP_CODE,
				GQ_CODE = this.GQ_CODE,
			};
		}
	} 
}
