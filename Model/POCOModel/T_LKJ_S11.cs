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
	public partial class T_LKJ_S11
	{
		public T_LKJ_S11 ToPOCO(bool isPOCO = true){
			return new T_LKJ_S11(){
				GID = this.GID,
				RWBNAME = this.RWBNAME,
				RWBCODE = this.RWBCODE,
				LINENAME = this.LINENAME,
				LINECODE = this.LINECODE,
				LINEDIRECTION = this.LINEDIRECTION,
				BROKENCHAINTYPE = this.BROKENCHAINTYPE,
				KMSTART = this.KMSTART,
				KMEND = this.KMEND,
				LONGCHAINLENGTH = this.LONGCHAINLENGTH,
				SHORTCHAINLENGTH = this.SHORTCHAINLENGTH,
				MARK = this.MARK,
				REMARK = this.REMARK,
				MARKID = this.MARKID,
				LASTDATE = this.LASTDATE,
				CREATE_TIME = this.CREATE_TIME,
				USER_NAME = this.USER_NAME,
				DEPT_CODE = this.DEPT_CODE,
			};
		}
	} 
}