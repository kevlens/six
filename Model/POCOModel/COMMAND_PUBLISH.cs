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
	public partial class COMMAND_PUBLISH
	{
		public COMMAND_PUBLISH ToPOCO(bool isPOCO = true){
			return new COMMAND_PUBLISH(){
				COMMAND_ID = this.COMMAND_ID,
				COMMAND_NUM = this.COMMAND_NUM,
				COMMAND_TITLE = this.COMMAND_TITLE,
				COMMAND_CONTENT = this.COMMAND_CONTENT,
				COMMAND_STATIME = this.COMMAND_STATIME,
				COMMAND_ENDTIME = this.COMMAND_ENDTIME,
				PUBLISH_MEMBER = this.PUBLISH_MEMBER,
				PUBLISH_DEPT = this.PUBLISH_DEPT,
				SIGN_MEMBER = this.SIGN_MEMBER,
				SIGN_DEPT = this.SIGN_DEPT,
				SIGN_TIME = this.SIGN_TIME,
				SIGN_MARK = this.SIGN_MARK,
				COMMAND_CREATER = this.COMMAND_CREATER,
				COMMAND_CREDEPT = this.COMMAND_CREDEPT,
				COMMAND_MEMO = this.COMMAND_MEMO,
				COMMAND_TIME = this.COMMAND_TIME,
				SIGN_USER = this.SIGN_USER,
			};
		}
	} 
}
