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
	public partial class FIVET_INFO_FILE
	{
		public FIVET_INFO_FILE ToPOCO(bool isPOCO = true){
			return new FIVET_INFO_FILE(){
				FILE_ID = this.FILE_ID,
				FIVET_ID = this.FIVET_ID,
				FILEURL = this.FILEURL,
				PDFURL = this.PDFURL,
				SWFURL = this.SWFURL,
				FILE_NAME = this.FILE_NAME,
			};
		}
	} 
}