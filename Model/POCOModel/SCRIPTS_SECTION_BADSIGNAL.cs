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
	public partial class SCRIPTS_SECTION_BADSIGNAL
	{
		public SCRIPTS_SECTION_BADSIGNAL ToPOCO(bool isPOCO = true){
			return new SCRIPTS_SECTION_BADSIGNAL(){
				PKID = this.PKID,
				LINE_NAME = this.LINE_NAME,
				LINE_DIR = this.LINE_DIR,
				DEPT_CODE = this.DEPT_CODE,
				POSITION = this.POSITION,
				MILEAGE_START = this.MILEAGE_START,
				MILEAGE_END = this.MILEAGE_END,
				NOTE = this.NOTE,
				TYPE = this.TYPE,
			};
		}
	} 
}
