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
	public partial class SCRIPTS_SECTION_TYPEFLOOD
	{
		public SCRIPTS_SECTION_TYPEFLOOD ToPOCO(bool isPOCO = true){
			return new SCRIPTS_SECTION_TYPEFLOOD(){
				TYPEFLOOD_ID = this.TYPEFLOOD_ID,
				TYPEFLOOD_NAME = this.TYPEFLOOD_NAME,
				ICON = this.ICON,
				DEPT_CODE = this.DEPT_CODE,
				DEPT_NAME = this.DEPT_NAME,
				TYPEFLOOD_LEVEL = this.TYPEFLOOD_LEVEL,
				LINE_NAME = this.LINE_NAME,
				LINE_DIR = this.LINE_DIR,
				MILEAGE_CENTER = this.MILEAGE_CENTER,
				MILEAGE_BEGIN = this.MILEAGE_BEGIN,
				MILEAGE_END = this.MILEAGE_END,
				MARSLONGITUDE = this.MARSLONGITUDE,
				MARSLATITUDE = this.MARSLATITUDE,
				TYPEFLOOD_NOTE = this.TYPEFLOOD_NOTE,
				FLOOD_TYPE = this.FLOOD_TYPE,
				ESTIMATE_SITUATION = this.ESTIMATE_SITUATION,
				RESCUE_FACILITY = this.RESCUE_FACILITY,
				RESCUE_NUMBER = this.RESCUE_NUMBER,
				OBSERVATION_SYSTEM = this.OBSERVATION_SYSTEM,
				RESCUE_WAY = this.RESCUE_WAY,
				EXECUTIVE_ID = this.EXECUTIVE_ID,
				EXECUTIVE = this.EXECUTIVE,
				EXECUTIVE_LEADER_ID = this.EXECUTIVE_LEADER_ID,
				EXECUTIVE_LEADER = this.EXECUTIVE_LEADER,
				LINE_SIDE = this.LINE_SIDE,
				DISEASE_SITUATION = this.DISEASE_SITUATION,
				DUTY_DEPT = this.DUTY_DEPT,
				DUTY_DEPTCODE = this.DUTY_DEPTCODE,
			};
		}
	} 
}