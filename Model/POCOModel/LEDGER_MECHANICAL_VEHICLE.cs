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
	public partial class LEDGER_MECHANICAL_VEHICLE
	{
		public LEDGER_MECHANICAL_VEHICLE ToPOCO(bool isPOCO = true){
			return new LEDGER_MECHANICAL_VEHICLE(){
				PKID = this.PKID,
				USE_DEPT = this.USE_DEPT,
				EQUIPMENT_NUM = this.EQUIPMENT_NUM,
				EQUIPMENT_NAME = this.EQUIPMENT_NAME,
				VEHICLE_MODEL = this.VEHICLE_MODEL,
				MONITORING_MODEL = this.MONITORING_MODEL,
				COLUMNADJUST_MODEL = this.COLUMNADJUST_MODEL,
				VEHICLE_FACTORY = this.VEHICLE_FACTORY,
				MONITORING_FACTORY = this.MONITORING_FACTORY,
				COLUMNADJUST_FACTORY = this.COLUMNADJUST_FACTORY,
				VEHICLE_DATE = this.VEHICLE_DATE,
				MONITORING_DATE = this.MONITORING_DATE,
				COLUMNADJUST_DATE = this.COLUMNADJUST_DATE,
				LASTOVERHAUL_DATE = this.LASTOVERHAUL_DATE,
				LASTOVERHAUL_UNIT = this.LASTOVERHAUL_UNIT,
				TECHNOLOGY_STATE = this.TECHNOLOGY_STATE,
				MONITORING_STATE = this.MONITORING_STATE,
				COLUMNADJUST_STATE = this.COLUMNADJUST_STATE,
				ORIGINAL_VALUE = this.ORIGINAL_VALUE,
				SHAPE_SIZE = this.SHAPE_SIZE,
				SETUP_PLACE = this.SETUP_PLACE,
				DEMO = this.DEMO,
				DEPT_CODE = this.DEPT_CODE,
				INPUT_DATE = this.INPUT_DATE,
				INPUT_USER = this.INPUT_USER,
				SETUP_TEAM = this.SETUP_TEAM,
				DRIVER = this.DRIVER,
				DEPUTY_DRIVER = this.DEPUTY_DRIVER,
				LARGE_CLASS = this.LARGE_CLASS,
			};
		}
	} 
}
