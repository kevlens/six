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
	public partial class JOB_PLANCONTROL_COMMAND
	{
		public JOB_PLANCONTROL_COMMAND ToPOCO(bool isPOCO = true){
			return new JOB_PLANCONTROL_COMMAND(){
				DEPT_CODE_CJ = this.DEPT_CODE_CJ,
				DEPT_NAME_CJ = this.DEPT_NAME_CJ,
				ON_STATION_PRE = this.ON_STATION_PRE,
				DOWN_STATION_PRE = this.DOWN_STATION_PRE,
				LAST_ONGET_TIME = this.LAST_ONGET_TIME,
				LASTON_STATION_ORDER = this.LASTON_STATION_ORDER,
				LASTDOWN_STATION_ORDER = this.LASTDOWN_STATION_ORDER,
				LAST_DOWNGET_TIME = this.LAST_DOWNGET_TIME,
			};
		}
	} 
}
