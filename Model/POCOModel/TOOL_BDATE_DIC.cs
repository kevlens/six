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
	public partial class TOOL_BDATE_DIC
	{
		public TOOL_BDATE_DIC ToPOCO(bool isPOCO = true){
			return new TOOL_BDATE_DIC(){
				ID = this.ID,
				CATEGORY_ID = this.CATEGORY_ID,
				CATEGORY_NAME = this.CATEGORY_NAME,
				NAME = this.NAME,
				NOTE = this.NOTE,
				DICORDER = this.DICORDER,
			};
		}
	} 
}
