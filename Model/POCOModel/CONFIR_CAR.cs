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
	public partial class CONFIR_CAR
	{
		public CONFIR_CAR ToPOCO(bool isPOCO = true){
			return new CONFIR_CAR(){
				PKID = this.PKID,
				TRAIN_NUM = this.TRAIN_NUM,
				DEPARTURE_STARTTIME = this.DEPARTURE_STARTTIME,
				LINE_NAME = this.LINE_NAME,
				DIRECTION = this.DIRECTION,
				PLAN_SECTION = this.PLAN_SECTION,
				STATION_START = this.STATION_START,
				CHANNEL_START = this.CHANNEL_START,
				STATION_END = this.STATION_END,
				CHANNEL_END = this.CHANNEL_END,
				DEPARTURE_ENDTIME = this.DEPARTURE_ENDTIME,
				DEPT_CJNAME = this.DEPT_CJNAME,
				CONTENT = this.CONTENT,
				MARS_LONGITUDE = this.MARS_LONGITUDE,
				MARS_LATITUDE = this.MARS_LATITUDE,
				DEPT_CODE = this.DEPT_CODE,
				TRIP_TIME = this.TRIP_TIME,
			};
		}
	} 
}
