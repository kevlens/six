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
	public partial class SYS_MENUOPT
	{
		public SYS_MENUOPT ToPOCO(bool isPOCO = true){
			return new SYS_MENUOPT(){
				MENUOPT_ID = this.MENUOPT_ID,
				MENUOPT_NAME = this.MENUOPT_NAME,
				MENU_ID = this.MENU_ID,
				C_ICO = this.C_ICO,
				AREA = this.AREA,
				CONTROLLER = this.CONTROLLER,
				ACTION = this.ACTION,
				NOTE = this.NOTE,
			};
		}
	} 
}
