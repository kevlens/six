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
	public partial class T_LKJ_S12
	{
		public T_LKJ_S12 ToPOCO(bool isPOCO = true){
			return new T_LKJ_S12(){
				GID = this.GID,
				SNO = this.SNO,
				LINENAME = this.LINENAME,
				LINECODE = this.LINECODE,
				LINEDIRECTION = this.LINEDIRECTION,
				STARTSTATION = this.STARTSTATION,
				STARTPOSITION = this.STARTPOSITION,
				STARTKM = this.STARTKM,
				ENDSTATION = this.ENDSTATION,
				ENDPOSITION = this.ENDPOSITION,
				ENDKM = this.ENDKM,
				EXTENDEDLENGTH = this.EXTENDEDLENGTH,
				MARK = this.MARK,
				REMARK = this.REMARK,
				LASTDATE = this.LASTDATE,
				MARKID = this.MARKID,
				CREATE_TIME = this.CREATE_TIME,
				USER_NAME = this.USER_NAME,
				DEPT_CODE = this.DEPT_CODE,
			};
		}
	} 
}