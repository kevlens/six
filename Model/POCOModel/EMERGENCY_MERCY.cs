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
	public partial class EMERGENCY_MERCY
	{
		public EMERGENCY_MERCY ToPOCO(bool isPOCO = true){
			return new EMERGENCY_MERCY(){
				PKID = this.PKID,
				FILEURL = this.FILEURL,
				PDFURL = this.PDFURL,
				SWFURL = this.SWFURL,
				FILE_NAME = this.FILE_NAME,
				FILE_TYPE = this.FILE_TYPE,
				DEPT_CODE = this.DEPT_CODE,
			};
		}
	} 
}