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
	public partial class T_ASS_PARA_DYN_SCORE
	{
		public T_ASS_PARA_DYN_SCORE ToPOCO(bool isPOCO = true){
			return new T_ASS_PARA_DYN_SCORE(){
				PKID = this.PKID,
				C_CHECK_TYPE = this.C_CHECK_TYPE,
				C_ITEM = this.C_ITEM,
				N_LEVEL = this.N_LEVEL,
				N_REPEAT = this.N_REPEAT,
				N_SCORE = this.N_SCORE,
				C_JOINTLESS = this.C_JOINTLESS,
				N_MAX_SPEED = this.N_MAX_SPEED,
				N_MIN_SPEED = this.N_MIN_SPEED,
				N_ORDER = this.N_ORDER,
				C_MEMO = this.C_MEMO,
				N_SPEED_LEVEL = this.N_SPEED_LEVEL,
				C_EFF_FLAG = this.C_EFF_FLAG,
			};
		}
	} 
}
