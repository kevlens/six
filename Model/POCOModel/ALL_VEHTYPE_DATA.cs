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
	public partial class ALL_VEHTYPE_DATA
	{
		public ALL_VEHTYPE_DATA ToPOCO(bool isPOCO = true){
			return new ALL_VEHTYPE_DATA(){
				PKID = this.PKID,
				VEHTYPE_NUM = this.VEHTYPE_NUM,
				VEHTYPE_ENGDESC = this.VEHTYPE_ENGDESC,
				VEHTYPE_CHIDESC = this.VEHTYPE_CHIDESC,
			};
		}
	} 
}
