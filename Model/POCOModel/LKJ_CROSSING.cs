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
	public partial class LKJ_CROSSING
	{
		public LKJ_CROSSING ToPOCO(bool isPOCO = true){
			return new LKJ_CROSSING(){
				PKID = this.PKID,
				BUREAU_NAME = this.BUREAU_NAME,
				BUREAU_NUM = this.BUREAU_NUM,
				LINE_NAME = this.LINE_NAME,
				LINE_NUM = this.LINE_NUM,
				LINE_DIR = this.LINE_DIR,
				CROSSING_NUM = this.CROSSING_NUM,
				CROSSING_NAME = this.CROSSING_NAME,
				CENTER_MILEAGE = this.CENTER_MILEAGE,
				ROAD_CATEGORY = this.ROAD_CATEGORY,
				INTERVAL_OR_STATION = this.INTERVAL_OR_STATION,
				CONTROL_ROAD_MACHINE = this.CONTROL_ROAD_MACHINE,
				CONTROL_ROAD_MACHINE_UP = this.CONTROL_ROAD_MACHINE_UP,
				CONTROL_ROAD_MACHINE_DOWN = this.CONTROL_ROAD_MACHINE_DOWN,
				CALL_NAME_DIR = this.CALL_NAME_DIR,
				MODIFY_TAG = this.MODIFY_TAG,
				CREATE_TIME = this.CREATE_TIME,
				USER_NAME = this.USER_NAME,
				DEPT_CODE = this.DEPT_CODE,
			};
		}
	} 
}