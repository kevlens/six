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
	public partial class LEDGER_LEVELCROSS_PIPE_LINE
	{
		public LEDGER_LEVELCROSS_PIPE_LINE ToPOCO(bool isPOCO = true){
			return new LEDGER_LEVELCROSS_PIPE_LINE(){
				PKID = this.PKID,
				LINE_CODE = this.LINE_CODE,
				LINE_NAME = this.LINE_NAME,
				LINEDIR_CODE = this.LINEDIR_CODE,
				LINEDIR_NAME = this.LINEDIR_NAME,
				OPERATE_STATU = this.OPERATE_STATU,
				LEVELCROSS_KM = this.LEVELCROSS_KM,
				PAVING_MATERIAL = this.PAVING_MATERIAL,
				PAVEMENT_WIDTH = this.PAVEMENT_WIDTH,
				RAIL_TYPE = this.RAIL_TYPE,
				ALARM_DEVICE = this.ALARM_DEVICE,
				VIDEO_INSTALLATE = this.VIDEO_INSTALLATE,
				CROSSE_NATURE = this.CROSSE_NATURE,
				PROPERTY_UNIT = this.PROPERTY_UNIT,
				ROADJOINT_CONTROL = this.ROADJOINT_CONTROL,
				ACROSS_TRACKS = this.ACROSS_TRACKS,
				ROAD_TYPE = this.ROAD_TYPE,
				ROAD_NAME = this.ROAD_NAME,
				IF_PASS = this.IF_PASS,
				ROAD_FLAG = this.ROAD_FLAG,
				RETAIN_FENCES = this.RETAIN_FENCES,
				DOOR_FLAG = this.DOOR_FLAG,
				BOUNDARY_FRAME = this.BOUNDARY_FRAME,
				DEMO = this.DEMO,
				DEPT_CODE = this.DEPT_CODE,
				INPUT_DATE = this.INPUT_DATE,
				INPUT_USER = this.INPUT_USER,
			};
		}
	} 
}