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
	public partial class T_ASS_BROKENCHAIN
	{
		public T_ASS_BROKENCHAIN ToPOCO(bool isPOCO = true){
			return new T_ASS_BROKENCHAIN(){
				BROKENCHAIN_ID = this.BROKENCHAIN_ID,
				DEP_CODE = this.DEP_CODE,
				LINE_CDOE = this.LINE_CDOE,
				LINE_DIR = this.LINE_DIR,
				BROKENCHAIN_TYPE = this.BROKENCHAIN_TYPE,
				START_MILE = this.START_MILE,
				END_MILE = this.END_MILE,
				BROKENCHAIN_LEN = this.BROKENCHAIN_LEN,
				MEMO = this.MEMO,
			};
		}
	} 
}