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
	public partial class T_ASS_TEMREPAIR_PLAN
	{
		public T_ASS_TEMREPAIR_PLAN ToPOCO(bool isPOCO = true){
			return new T_ASS_TEMREPAIR_PLAN(){
				PKID = this.PKID,
				C_JOB_NO = this.C_JOB_NO,
				C_EFF_FLAG = this.C_EFF_FLAG,
				T_PLANREAPIR_DATE = this.T_PLANREAPIR_DATE,
				C_GWD_CODE = this.C_GWD_CODE,
				C_DEP_CODE = this.C_DEP_CODE,
				C_DEP_NAME = this.C_DEP_NAME,
				C_DEP_PROP = this.C_DEP_PROP,
				C_PRO_FKID = this.C_PRO_FKID,
				C_RESERVE = this.C_RESERVE,
				C_MEMO = this.C_MEMO,
				T_CRT_TM = this.T_CRT_TM,
				C_CRT_NAME = this.C_CRT_NAME,
				C_REPAIR_DATE = this.C_REPAIR_DATE,
				C_REPAIR_RES = this.C_REPAIR_RES,
				C_APPROVER = this.C_APPROVER,
				C_RECIEW_RESU = this.C_RECIEW_RESU,
				C_REPAIR_LEADER = this.C_REPAIR_LEADER,
				C_SAMP_RES = this.C_SAMP_RES,
			};
		}
	} 
}
