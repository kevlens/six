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
	public partial class HRAIL_BALLAST
	{
		public HRAIL_BALLAST ToPOCO(bool isPOCO = true){
			return new HRAIL_BALLAST(){
				BALLAST_ID = this.BALLAST_ID,
				GWD_CODE = this.GWD_CODE,
				CJ_CODE = this.CJ_CODE,
				GQ_CODE = this.GQ_CODE,
				LINE_CODE = this.LINE_CODE,
				LINE_DIR = this.LINE_DIR,
				RUN_STATUS = this.RUN_STATUS,
				BALLAST_FLAG = this.BALLAST_FLAG,
				STATION_NAME = this.STATION_NAME,
				STATION_CODE = this.STATION_CODE,
				LINE_CAT = this.LINE_CAT,
				LINE_TYPE = this.LINE_TYPE,
				TRACK_CODE = this.TRACK_CODE,
				OVERALL_LENGTH = this.OVERALL_LENGTH,
				START_MILE = this.START_MILE,
				END_MILE = this.END_MILE,
				LONGCHAIN_MARKER = this.LONGCHAIN_MARKER,
				BALLAST_TYPE = this.BALLAST_TYPE,
				BALLAST_MATERAIL = this.BALLAST_MATERAIL,
				GAUGE_TYPE = this.GAUGE_TYPE,
				BALLAST_LEVEL = this.BALLAST_LEVEL,
				BALLAST_TOPWIDTH = this.BALLAST_TOPWIDTH,
				PILLOW_THICKNESS = this.PILLOW_THICKNESS,
				CUSSION_MATERAIL = this.CUSSION_MATERAIL,
				CUSSION_THICKNESS = this.CUSSION_THICKNESS,
				SIDE_SLOPE = this.SIDE_SLOPE,
				DIRTY_PROGRM = this.DIRTY_PROGRM,
				SCREEN_YEAR = this.SCREEN_YEAR,
				MEMO = this.MEMO,
			};
		}
	} 
}
