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
	public partial class HEART_DG_WAVE
	{
		public HEART_DG_WAVE ToPOCO(bool isPOCO = true){
			return new HEART_DG_WAVE(){
				LINE = this.LINE,
				DIRE = this.DIRE,
				POS = this.POS,
				GB = this.GB,
				DT = this.DT,
				VAL = this.VAL,
				QJID = this.QJID,
			};
		}
	} 
}
