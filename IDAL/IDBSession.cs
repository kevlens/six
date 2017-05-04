
       
                     
using System;    
using System.Collections.Generic;    
using System.Linq;   
using System.Text;     
using IDAL;    
namespace IDAL       
{    
	public partial interface IDBSession   
    { 
 
		IALL_LINE_DATARepository IALL_LINE_DATARepository{get;set;}
 
		IALL_STATION_DATARepository IALL_STATION_DATARepository{get;set;}
 
		IALL_VEHTYPE_DATARepository IALL_VEHTYPE_DATARepository{get;set;}
 
		IALL_VIDEOFILE_DATARepository IALL_VIDEOFILE_DATARepository{get;set;}
 
		IASSET_BASE_ACCOUNTRepository IASSET_BASE_ACCOUNTRepository{get;set;}
 
		IASSET_BASE_CATALOGRepository IASSET_BASE_CATALOGRepository{get;set;}
 
		IASSET_BASE_MATERIAL_DICRepository IASSET_BASE_MATERIAL_DICRepository{get;set;}
 
		IASSET_BASE_RATERepository IASSET_BASE_RATERepository{get;set;}
 
		IASSET_BASE_RELATION_UNITRepository IASSET_BASE_RELATION_UNITRepository{get;set;}
 
		IASSET_BASE_SUPPLIERRepository IASSET_BASE_SUPPLIERRepository{get;set;}
 
		IASSET_BASE_SUPPLIER_MATERIALRepository IASSET_BASE_SUPPLIER_MATERIALRepository{get;set;}
 
		IASSET_INVENTORYRepository IASSET_INVENTORYRepository{get;set;}
 
		IASSET_MOBILERepository IASSET_MOBILERepository{get;set;}
 
		IASSET_MRPRepository IASSET_MRPRepository{get;set;}
 
		IASSET_MRP_BOMRepository IASSET_MRP_BOMRepository{get;set;}
 
		IASSET_WAREHOUSERepository IASSET_WAREHOUSERepository{get;set;}
 
		IBASE_BOUNDARYRepository IBASE_BOUNDARYRepository{get;set;}
 
		IBASE_DICTRepository IBASE_DICTRepository{get;set;}
 
		IBASE_LINERepository IBASE_LINERepository{get;set;}
 
		IBASE_STATIONRepository IBASE_STATIONRepository{get;set;}
 
		IBOOT_BASERepository IBOOT_BASERepository{get;set;}
 
		IBOOT_RECORDRepository IBOOT_RECORDRepository{get;set;}
 
		IBRIDGE_BOUNDRepository IBRIDGE_BOUNDRepository{get;set;}
 
		IBRIDGE_BRIDGERepository IBRIDGE_BRIDGERepository{get;set;}
 
		IBRIDGE_CULVERTRepository IBRIDGE_CULVERTRepository{get;set;}
 
		IBRIDGE_EQU_CLEARANCERepository IBRIDGE_EQU_CLEARANCERepository{get;set;}
 
		IBRIDGE_EQU_CLEARANCE_FILERepository IBRIDGE_EQU_CLEARANCE_FILERepository{get;set;}
 
		IBRIDGE_EQU_DATA_TEMPRepository IBRIDGE_EQU_DATA_TEMPRepository{get;set;}
 
		IBRIDGE_EQU_FILERepository IBRIDGE_EQU_FILERepository{get;set;}
 
		IBRIDGE_LIMITOVERHEADRepository IBRIDGE_LIMITOVERHEADRepository{get;set;}
 
		IBRIDGE_LRONRepository IBRIDGE_LRONRepository{get;set;}
 
		IBRIDGE_LRON_OVERPASSRepository IBRIDGE_LRON_OVERPASSRepository{get;set;}
 
		IBRIDGE_MAINTENAN_EVALUATERepository IBRIDGE_MAINTENAN_EVALUATERepository{get;set;}
 
		IBRIDGE_MAINTENAN_NOTICERepository IBRIDGE_MAINTENAN_NOTICERepository{get;set;}
 
		IBRIDGE_MAINTENAN_NOTICE_PRORepository IBRIDGE_MAINTENAN_NOTICE_PRORepository{get;set;}
 
		IBRIDGE_MAINTENAN_PRORepository IBRIDGE_MAINTENAN_PRORepository{get;set;}
 
		IBRIDGE_MAINTENAN_PRO_HISRepository IBRIDGE_MAINTENAN_PRO_HISRepository{get;set;}
 
		IBRIDGE_MAINTENAN_REPORTRepository IBRIDGE_MAINTENAN_REPORTRepository{get;set;}
 
		IBRIDGE_MSGRepository IBRIDGE_MSGRepository{get;set;}
 
		IBRIDGE_OTHER_DEVICERepository IBRIDGE_OTHER_DEVICERepository{get;set;}
 
		IBRIDGE_OVERPASSRepository IBRIDGE_OVERPASSRepository{get;set;}
 
		IBRIDGE_OVERPASS_WATERRepository IBRIDGE_OVERPASS_WATERRepository{get;set;}
 
		IBRIDGE_PARA_MAINTENANRepository IBRIDGE_PARA_MAINTENANRepository{get;set;}
 
		IBRIDGE_PARA_STATUSRepository IBRIDGE_PARA_STATUSRepository{get;set;}
 
		IBRIDGE_SHALLOW_FOUNDATIONRepository IBRIDGE_SHALLOW_FOUNDATIONRepository{get;set;}
 
		IBRIDGE_STATE_PRORepository IBRIDGE_STATE_PRORepository{get;set;}
 
		IBRIDGE_STATE_PRO_FILERepository IBRIDGE_STATE_PRO_FILERepository{get;set;}
 
		IBRIDGE_STATE_PRO_HISRepository IBRIDGE_STATE_PRO_HISRepository{get;set;}
 
		IBRIDGE_STATE_REPORTRepository IBRIDGE_STATE_REPORTRepository{get;set;}
 
		IBRIDGE_TUNNELRepository IBRIDGE_TUNNELRepository{get;set;}
 
		IBROKENRAIL_BDATA_BOUNDARYRepository IBROKENRAIL_BDATA_BOUNDARYRepository{get;set;}
 
		IBROKENRAIL_BDATA_DEVICERepository IBROKENRAIL_BDATA_DEVICERepository{get;set;}
 
		IBROKENRAIL_BDATA_DEVICE_STATUSRepository IBROKENRAIL_BDATA_DEVICE_STATUSRepository{get;set;}
 
		IBROKENRAIL_BDATA_SECTIONRepository IBROKENRAIL_BDATA_SECTIONRepository{get;set;}
 
		IBROKENRAIL_DEVICE_STATUSRepository IBROKENRAIL_DEVICE_STATUSRepository{get;set;}
 
		IBROKENRAIL_DEVICE_STATUSHISRepository IBROKENRAIL_DEVICE_STATUSHISRepository{get;set;}
 
		IBROKENRAIL_NEEDSENDRepository IBROKENRAIL_NEEDSENDRepository{get;set;}
 
		IBROKENRAIL_SECTION_LINERepository IBROKENRAIL_SECTION_LINERepository{get;set;}
 
		IBROKENRAIL_SECTION_STATUSRepository IBROKENRAIL_SECTION_STATUSRepository{get;set;}
 
		IBROKENRAIL_SECTION_STATUSHISRepository IBROKENRAIL_SECTION_STATUSHISRepository{get;set;}
 
		IBROKENRAIL_SOUND_SENDPHONERepository IBROKENRAIL_SOUND_SENDPHONERepository{get;set;}
 
		IBROKENRAIL_VOLTAGE_SMSRepository IBROKENRAIL_VOLTAGE_SMSRepository{get;set;}
 
		IBROKENRAIL_VOLTAGE_STATUSRepository IBROKENRAIL_VOLTAGE_STATUSRepository{get;set;}
 
		IBROKENRAIL_VOLTAGE_STATUSHISRepository IBROKENRAIL_VOLTAGE_STATUSHISRepository{get;set;}
 
		IBROKENRAIL_WARN_CONTROLRepository IBROKENRAIL_WARN_CONTROLRepository{get;set;}
 
		IBROKENRAIL_WARN_DEVICERepository IBROKENRAIL_WARN_DEVICERepository{get;set;}
 
		IBROKENRAIL_WARN_FLAGRepository IBROKENRAIL_WARN_FLAGRepository{get;set;}
 
		ICAR_BDATA_CARRepository ICAR_BDATA_CARRepository{get;set;}
 
		ICAR_LAST_LONLATRepository ICAR_LAST_LONLATRepository{get;set;}
 
		ICAR_OVER_SPEEDRepository ICAR_OVER_SPEEDRepository{get;set;}
 
		ICAR_OVERSPEED_WARNRepository ICAR_OVERSPEED_WARNRepository{get;set;}
 
		ICAR_PHONE_INFORepository ICAR_PHONE_INFORepository{get;set;}
 
		ICHARTRepository ICHARTRepository{get;set;}
 
		ICHK_BDATA_DEVICERepository ICHK_BDATA_DEVICERepository{get;set;}
 
		ICOMMAND_PUBLISHRepository ICOMMAND_PUBLISHRepository{get;set;}
 
		ICOMMAND_PUBLISH_HISRepository ICOMMAND_PUBLISH_HISRepository{get;set;}
 
		ICONFIR_CARRepository ICONFIR_CARRepository{get;set;}
 
		ICONFIR_CAR_PLANRepository ICONFIR_CAR_PLANRepository{get;set;}
 
		ICONFIR_CAR_WARNRepository ICONFIR_CAR_WARNRepository{get;set;}
 
		ICONTROL_FOUR_DICRepository ICONTROL_FOUR_DICRepository{get;set;}
 
		ICONTROL_FOUR_PLANRepository ICONTROL_FOUR_PLANRepository{get;set;}
 
		ICURVE_BASERepository ICURVE_BASERepository{get;set;}
 
		ICURVE_BASE_EXTRepository ICURVE_BASE_EXTRepository{get;set;}
 
		ICURVE_CWRRepository ICURVE_CWRRepository{get;set;}
 
		ICURVE_PICRepository ICURVE_PICRepository{get;set;}
 
		ICURVE_PSNRepository ICURVE_PSNRepository{get;set;}
 
		ICURVE_RAILRepository ICURVE_RAILRepository{get;set;}
 
		ICURVE_RAILWEARRepository ICURVE_RAILWEARRepository{get;set;}
 
		IDR_IDX_DOC_CONTENT_IRepository IDR_IDX_DOC_CONTENT_IRepository{get;set;}
 
		IDR_IDX_DOC_CONTENT_KRepository IDR_IDX_DOC_CONTENT_KRepository{get;set;}
 
		IDR_IDX_DOC_CONTENT_NRepository IDR_IDX_DOC_CONTENT_NRepository{get;set;}
 
		IDR_IDX_DOC_CONTENT_RRepository IDR_IDX_DOC_CONTENT_RRepository{get;set;}
 
		IEMERGENCY_MERCYRepository IEMERGENCY_MERCYRepository{get;set;}
 
		IEMERGENCY_RECRepository IEMERGENCY_RECRepository{get;set;}
 
		IEMERGENCY_REC_FILERepository IEMERGENCY_REC_FILERepository{get;set;}
 
		IEMERGENCY_REC_PHOTORepository IEMERGENCY_REC_PHOTORepository{get;set;}
 
		IEMERGENCY_RESCUERepository IEMERGENCY_RESCUERepository{get;set;}
 
		IEMERGENCY_RESCUE_TOOLRepository IEMERGENCY_RESCUE_TOOLRepository{get;set;}
 
		IEMERGENCY_RULESRepository IEMERGENCY_RULESRepository{get;set;}
 
		IEMERGENCY_TALENT_POOLRepository IEMERGENCY_TALENT_POOLRepository{get;set;}
 
		IEMERGENCY_VIECHLERepository IEMERGENCY_VIECHLERepository{get;set;}
 
		IENFORCEMENT_BDATARepository IENFORCEMENT_BDATARepository{get;set;}
 
		IENFORCEMENT_BDATA_ONLINERepository IENFORCEMENT_BDATA_ONLINERepository{get;set;}
 
		IENFORCEMENT_FILERepository IENFORCEMENT_FILERepository{get;set;}
 
		IFIVET_INFORepository IFIVET_INFORepository{get;set;}
 
		IFIVET_INFO_FILERepository IFIVET_INFO_FILERepository{get;set;}
 
		IFIVET_INFO_PHOTORepository IFIVET_INFO_PHOTORepository{get;set;}
 
		IFIVET_INFO_TYPERepository IFIVET_INFO_TYPERepository{get;set;}
 
		IFIVET_INFO_VIDEORepository IFIVET_INFO_VIDEORepository{get;set;}
 
		IFLOODPOINTRepository IFLOODPOINTRepository{get;set;}
 
		IFLOW_BASERepository IFLOW_BASERepository{get;set;}
 
		IFLOW_JOBRepository IFLOW_JOBRepository{get;set;}
 
		IFLOW_STEPRepository IFLOW_STEPRepository{get;set;}
 
		IGATE_BDATA_CARDRepository IGATE_BDATA_CARDRepository{get;set;}
 
		IGATE_BDATA_CLIENTRepository IGATE_BDATA_CLIENTRepository{get;set;}
 
		IGATE_BDATA_DICRepository IGATE_BDATA_DICRepository{get;set;}
 
		IGATE_BDATA_GATERepository IGATE_BDATA_GATERepository{get;set;}
 
		IGATE_BDATA_LIMITRepository IGATE_BDATA_LIMITRepository{get;set;}
 
		IGATE_BDATA_SKYLIGHTRepository IGATE_BDATA_SKYLIGHTRepository{get;set;}
 
		IGATE_BDATA_TOOLRepository IGATE_BDATA_TOOLRepository{get;set;}
 
		IGATE_DEPT_MAPRepository IGATE_DEPT_MAPRepository{get;set;}
 
		IGATE_GATEMNG_AUTHHISTORYRepository IGATE_GATEMNG_AUTHHISTORYRepository{get;set;}
 
		IGATE_GATEMNG_AUTHORIZATIONRepository IGATE_GATEMNG_AUTHORIZATIONRepository{get;set;}
 
		IGATE_GATEMNG_CARDLISTRepository IGATE_GATEMNG_CARDLISTRepository{get;set;}
 
		IGATE_GATEMNG_INGATERepository IGATE_GATEMNG_INGATERepository{get;set;}
 
		IGATE_GATEMNG_INOUTRepository IGATE_GATEMNG_INOUTRepository{get;set;}
 
		IGATE_GATEMNG_INOUTHISRepository IGATE_GATEMNG_INOUTHISRepository{get;set;}
 
		IGATE_GATEMNG_LASTCARDLISTRepository IGATE_GATEMNG_LASTCARDLISTRepository{get;set;}
 
		IGATE_GATEMNG_LASTSTATERepository IGATE_GATEMNG_LASTSTATERepository{get;set;}
 
		IGATE_GATEMNG_LONGDISHISTORYRepository IGATE_GATEMNG_LONGDISHISTORYRepository{get;set;}
 
		IGATE_GATEMNG_STATERepository IGATE_GATEMNG_STATERepository{get;set;}
 
		IGATE_GATEMNG_WARNINGRepository IGATE_GATEMNG_WARNINGRepository{get;set;}
 
		IGATE_JOB_PLANRepository IGATE_JOB_PLANRepository{get;set;}
 
		IGATE_SEND_MSGRepository IGATE_SEND_MSGRepository{get;set;}
 
		IGATE_SEND_PHONENORepository IGATE_SEND_PHONENORepository{get;set;}
 
		IHEART_BROADCASTRepository IHEART_BROADCASTRepository{get;set;}
 
		IHEART_BROADCAST_HISRepository IHEART_BROADCAST_HISRepository{get;set;}
 
		IHEART_DG_DIS_PHONERepository IHEART_DG_DIS_PHONERepository{get;set;}
 
		IHEART_DG_VOLTAGE_SENDRepository IHEART_DG_VOLTAGE_SENDRepository{get;set;}
 
		IHEART_DG_WAVERepository IHEART_DG_WAVERepository{get;set;}
 
		IHEART_DG_WAVE_HEADRepository IHEART_DG_WAVE_HEADRepository{get;set;}
 
		IHEART_DG_WEBRepository IHEART_DG_WEBRepository{get;set;}
 
		IHEART_MESSAGERepository IHEART_MESSAGERepository{get;set;}
 
		IHEART_RECENT_SARepository IHEART_RECENT_SARepository{get;set;}
 
		IHIK_PIC_INFORepository IHIK_PIC_INFORepository{get;set;}
 
		IHRAIL_BALLASTRepository IHRAIL_BALLASTRepository{get;set;}
 
		IHRAIL_CROSSINGRepository IHRAIL_CROSSINGRepository{get;set;}
 
		IHRAIL_CURVERepository IHRAIL_CURVERepository{get;set;}
 
		IHRAIL_DEPT_STATIONRepository IHRAIL_DEPT_STATIONRepository{get;set;}
 
		IHRAIL_LINEUNITRepository IHRAIL_LINEUNITRepository{get;set;}
 
		IHRAIL_PARA_JOBITEMRepository IHRAIL_PARA_JOBITEMRepository{get;set;}
 
		IHRAIL_PARA_PROITEMRepository IHRAIL_PARA_PROITEMRepository{get;set;}
 
		IHRAIL_PARA_PROITEM_SCORERepository IHRAIL_PARA_PROITEM_SCORERepository{get;set;}
 
		IHRAIL_PLANRepository IHRAIL_PLANRepository{get;set;}
 
		IHRAIL_PLAN_EMPRepository IHRAIL_PLAN_EMPRepository{get;set;}
 
		IHRAIL_PLAN_FILERepository IHRAIL_PLAN_FILERepository{get;set;}
 
		IHRAIL_PLAN_FLOWRepository IHRAIL_PLAN_FLOWRepository{get;set;}
 
		IHRAIL_PLAN_ITEMRepository IHRAIL_PLAN_ITEMRepository{get;set;}
 
		IHRAIL_PLAN_LOCRepository IHRAIL_PLAN_LOCRepository{get;set;}
 
		IHRAIL_PLAN_MATERIALRepository IHRAIL_PLAN_MATERIALRepository{get;set;}
 
		IHRAIL_PLAN_PROBLEMRepository IHRAIL_PLAN_PROBLEMRepository{get;set;}
 
		IHRAIL_PLAN_TOOLRepository IHRAIL_PLAN_TOOLRepository{get;set;}
 
		IHRAIL_PLAN_YEARRepository IHRAIL_PLAN_YEARRepository{get;set;}
 
		IHRAIL_PROBLEMRepository IHRAIL_PROBLEMRepository{get;set;}
 
		IHRAIL_PROBLEM_DNYRepository IHRAIL_PROBLEM_DNYRepository{get;set;}
 
		IHRAIL_PROBLEM_FILERepository IHRAIL_PROBLEM_FILERepository{get;set;}
 
		IHRAIL_RAILRepository IHRAIL_RAILRepository{get;set;}
 
		IHRAIL_SLOPERepository IHRAIL_SLOPERepository{get;set;}
 
		IHRAIL_STARTMILERepository IHRAIL_STARTMILERepository{get;set;}
 
		IHRAIL_STATIONRepository IHRAIL_STATIONRepository{get;set;}
 
		IHRAIL_TQIRepository IHRAIL_TQIRepository{get;set;}
 
		IHRAIL_TRACKRepository IHRAIL_TRACKRepository{get;set;}
 
		IHRAIL_TURNOUTRepository IHRAIL_TURNOUTRepository{get;set;}
 
		IHRAIL_UNIT_VALRepository IHRAIL_UNIT_VALRepository{get;set;}
 
		IHRAIL_UNIT_VAL_DETAILRepository IHRAIL_UNIT_VAL_DETAILRepository{get;set;}
 
		IJOB_JOB_PLANRepository IJOB_JOB_PLANRepository{get;set;}
 
		IJOB_MSG_BATCHREPLYRepository IJOB_MSG_BATCHREPLYRepository{get;set;}
 
		IJOB_MSG_BATCHSENDRepository IJOB_MSG_BATCHSENDRepository{get;set;}
 
		IJOB_MSG_BATCHSENDPHOTORepository IJOB_MSG_BATCHSENDPHOTORepository{get;set;}
 
		IJOB_PLANRepository IJOB_PLANRepository{get;set;}
 
		IJOB_PLAN_ADDPASSENGER_TESTRepository IJOB_PLAN_ADDPASSENGER_TESTRepository{get;set;}
 
		IJOB_PLAN_APPROVALRepository IJOB_PLAN_APPROVALRepository{get;set;}
 
		IJOB_PLAN_BYTIMRepository IJOB_PLAN_BYTIMRepository{get;set;}
 
		IJOB_PLAN_CONTROLRepository IJOB_PLAN_CONTROLRepository{get;set;}
 
		IJOB_PLAN_DELINGHA_FILLRepository IJOB_PLAN_DELINGHA_FILLRepository{get;set;}
 
		IJOB_PLAN_DELINGHA_FILL_DETAILRepository IJOB_PLAN_DELINGHA_FILL_DETAILRepository{get;set;}
 
		IJOB_PLAN_DELINGHA_MONTHRepository IJOB_PLAN_DELINGHA_MONTHRepository{get;set;}
 
		IJOB_PLAN_DELINGHA_WEEKRepository IJOB_PLAN_DELINGHA_WEEKRepository{get;set;}
 
		IJOB_PLAN_EQUIPMENTRepository IJOB_PLAN_EQUIPMENTRepository{get;set;}
 
		IJOB_PLAN_LINERepository IJOB_PLAN_LINERepository{get;set;}
 
		IJOB_PLAN_LINE_EQUIANDTIMRepository IJOB_PLAN_LINE_EQUIANDTIMRepository{get;set;}
 
		IJOB_PLAN_LOOKOUTRepository IJOB_PLAN_LOOKOUTRepository{get;set;}
 
		IJOB_PLAN_MEMBERPHONE_MAPRepository IJOB_PLAN_MEMBERPHONE_MAPRepository{get;set;}
 
		IJOB_PLAN_OLDRepository IJOB_PLAN_OLDRepository{get;set;}
 
		IJOB_PLAN_PHONE_USERRepository IJOB_PLAN_PHONE_USERRepository{get;set;}
 
		IJOB_PLAN_SAFERepository IJOB_PLAN_SAFERepository{get;set;}
 
		IJOB_PLAN_TRAINRepository IJOB_PLAN_TRAINRepository{get;set;}
 
		IJOB_PLAN_TYPERepository IJOB_PLAN_TYPERepository{get;set;}
 
		IJOB_PLAN_UPDOWNRepository IJOB_PLAN_UPDOWNRepository{get;set;}
 
		IJOB_PLAN_UPDOWNHISRepository IJOB_PLAN_UPDOWNHISRepository{get;set;}
 
		IJOB_PLAN_WARNPHONESETRepository IJOB_PLAN_WARNPHONESETRepository{get;set;}
 
		IJOB_PLAN_WARNPOSSETRepository IJOB_PLAN_WARNPOSSETRepository{get;set;}
 
		IJOB_PLANCONTROL_COMMANDRepository IJOB_PLANCONTROL_COMMANDRepository{get;set;}
 
		IJOB_WARNRepository IJOB_WARNRepository{get;set;}
 
		ILEDGER_BIGEQUI_TECHPARAMRepository ILEDGER_BIGEQUI_TECHPARAMRepository{get;set;}
 
		ILEDGER_DICT_INTERPHONERepository ILEDGER_DICT_INTERPHONERepository{get;set;}
 
		ILEDGER_DICT_LARGEMACHINERYRepository ILEDGER_DICT_LARGEMACHINERYRepository{get;set;}
 
		ILEDGER_DICT_MACHINETOOLRepository ILEDGER_DICT_MACHINETOOLRepository{get;set;}
 
		ILEDGER_DICT_MECHANICALVEHICLERepository ILEDGER_DICT_MECHANICALVEHICLERepository{get;set;}
 
		ILEDGER_DICT_ROADVEHICLERepository ILEDGER_DICT_ROADVEHICLERepository{get;set;}
 
		ILEDGER_DICT_TRAFFICVEHICLERepository ILEDGER_DICT_TRAFFICVEHICLERepository{get;set;}
 
		ILEDGER_INTERPHONERepository ILEDGER_INTERPHONERepository{get;set;}
 
		ILEDGER_LARGE_MACHINERYRepository ILEDGER_LARGE_MACHINERYRepository{get;set;}
 
		ILEDGER_LEVELCROSS_INFORepository ILEDGER_LEVELCROSS_INFORepository{get;set;}
 
		ILEDGER_LEVELCROSS_PIPE_LINERepository ILEDGER_LEVELCROSS_PIPE_LINERepository{get;set;}
 
		ILEDGER_LEVELCROSS_REPAIR_LINERepository ILEDGER_LEVELCROSS_REPAIR_LINERepository{get;set;}
 
		ILEDGER_MACHINE_TOOLRepository ILEDGER_MACHINE_TOOLRepository{get;set;}
 
		ILEDGER_MECHANICAL_VEHICLERepository ILEDGER_MECHANICAL_VEHICLERepository{get;set;}
 
		ILEDGER_RAIL_MATERIALRepository ILEDGER_RAIL_MATERIALRepository{get;set;}
 
		ILEDGER_RAILCAR_TECHPARAMRepository ILEDGER_RAILCAR_TECHPARAMRepository{get;set;}
 
		ILEDGER_ROAD_VEHICLERepository ILEDGER_ROAD_VEHICLERepository{get;set;}
 
		ILEDGER_SMALLEQUI_TECHPARAMRepository ILEDGER_SMALLEQUI_TECHPARAMRepository{get;set;}
 
		ILEDGER_TRAFFIC_VEHICLESRepository ILEDGER_TRAFFIC_VEHICLESRepository{get;set;}
 
		ILKJ_ALLOW_SPEEDRepository ILKJ_ALLOW_SPEEDRepository{get;set;}
 
		ILKJ_BRIDGERepository ILKJ_BRIDGERepository{get;set;}
 
		ILKJ_BROKEN_CHAINRepository ILKJ_BROKEN_CHAINRepository{get;set;}
 
		ILKJ_CROSSINGRepository ILKJ_CROSSINGRepository{get;set;}
 
		ILKJ_CURVERepository ILKJ_CURVERepository{get;set;}
 
		ILKJ_LINE_NAMERepository ILKJ_LINE_NAMERepository{get;set;}
 
		ILKJ_MAIN_TRACK_MILEAGERepository ILKJ_MAIN_TRACK_MILEAGERepository{get;set;}
 
		ILKJ_ROAD_FORKRepository ILKJ_ROAD_FORKRepository{get;set;}
 
		ILKJ_SLOPERepository ILKJ_SLOPERepository{get;set;}
 
		ILKJ_STATIONRepository ILKJ_STATIONRepository{get;set;}
 
		ILKJ_TRACKRepository ILKJ_TRACKRepository{get;set;}
 
		ILKJ_TUNNELRepository ILKJ_TUNNELRepository{get;set;}
 
		IMATERIAL_BDATE_DICRepository IMATERIAL_BDATE_DICRepository{get;set;}
 
		IMATERIAL_BDATE_MATERIALNAMERepository IMATERIAL_BDATE_MATERIALNAMERepository{get;set;}
 
		IMATERIAL_INOUT_BILLRepository IMATERIAL_INOUT_BILLRepository{get;set;}
 
		IMATERIAL_INOUT_BILL_DETAILRepository IMATERIAL_INOUT_BILL_DETAILRepository{get;set;}
 
		IMATERIAL_MATERIALMNGRepository IMATERIAL_MATERIALMNGRepository{get;set;}
 
		IMATERIAL_MONSURPRUSRepository IMATERIAL_MONSURPRUSRepository{get;set;}
 
		IOIL_BDATA_CURVERepository IOIL_BDATA_CURVERepository{get;set;}
 
		IOIL_BDATA_DEVICERepository IOIL_BDATA_DEVICERepository{get;set;}
 
		IOIL_BDATA_OPRepository IOIL_BDATA_OPRepository{get;set;}
 
		IOIL_RECORD_CHECKRepository IOIL_RECORD_CHECKRepository{get;set;}
 
		IOIL_RECORD_OILRepository IOIL_RECORD_OILRepository{get;set;}
 
		IPHONEDICRepository IPHONEDICRepository{get;set;}
 
		IPROTECTEDNET_BDATA_DEVICERepository IPROTECTEDNET_BDATA_DEVICERepository{get;set;}
 
		IPROTECTEDNET_RECORD_CHECKRepository IPROTECTEDNET_RECORD_CHECKRepository{get;set;}
 
		IPROTECTEDNET_RECORD_WARNRepository IPROTECTEDNET_RECORD_WARNRepository{get;set;}
 
		IPROTECTEDNET_VIDEO_FILERepository IPROTECTEDNET_VIDEO_FILERepository{get;set;}
 
		IRAIL_BDATA_HOSTRepository IRAIL_BDATA_HOSTRepository{get;set;}
 
		IRAIL_BDATA_POINTRepository IRAIL_BDATA_POINTRepository{get;set;}
 
		IRAIL_BDATA_SENDPHONENORepository IRAIL_BDATA_SENDPHONENORepository{get;set;}
 
		IRAIL_CARRIERBDATA_POINTRepository IRAIL_CARRIERBDATA_POINTRepository{get;set;}
 
		IRAIL_CARRIERBDATA_SECTIONRepository IRAIL_CARRIERBDATA_SECTIONRepository{get;set;}
 
		IRAIL_CARRIERDEVICE_STATUSRepository IRAIL_CARRIERDEVICE_STATUSRepository{get;set;}
 
		IRAIL_CARRIERDEVICE_WARNRepository IRAIL_CARRIERDEVICE_WARNRepository{get;set;}
 
		IRAIL_CARRIERRECORD_POINTRepository IRAIL_CARRIERRECORD_POINTRepository{get;set;}
 
		IRAIL_CARRIERRECORD_WARNRepository IRAIL_CARRIERRECORD_WARNRepository{get;set;}
 
		IRAIL_CARRIERRECORD_WARN_FINALRepository IRAIL_CARRIERRECORD_WARN_FINALRepository{get;set;}
 
		IRAIL_CARRIERSECTION_LASTWARNRepository IRAIL_CARRIERSECTION_LASTWARNRepository{get;set;}
 
		IRAIL_CARRIERSECTION_WARNRepository IRAIL_CARRIERSECTION_WARNRepository{get;set;}
 
		IRAIL_CARRIERWAVE_LOGRepository IRAIL_CARRIERWAVE_LOGRepository{get;set;}
 
		IRAIL_CARRIERWAVE_POINTRepository IRAIL_CARRIERWAVE_POINTRepository{get;set;}
 
		IRAIL_COMMRepository IRAIL_COMMRepository{get;set;}
 
		IRAIL_DEVICE_RECORDRepository IRAIL_DEVICE_RECORDRepository{get;set;}
 
		IRAIL_RECORD_HOSTRepository IRAIL_RECORD_HOSTRepository{get;set;}
 
		IRAIL_RECORD_POINTRepository IRAIL_RECORD_POINTRepository{get;set;}
 
		IRAIL_RECORD_SAMPWARNRepository IRAIL_RECORD_SAMPWARNRepository{get;set;}
 
		IRAIL_RECORD_WARNRepository IRAIL_RECORD_WARNRepository{get;set;}
 
		IRAIL_SECTION_LINERepository IRAIL_SECTION_LINERepository{get;set;}
 
		IRAIL_SOUNDBDATA_POINTRepository IRAIL_SOUNDBDATA_POINTRepository{get;set;}
 
		IRAIL_SOUNDBDATA_SECTIONRepository IRAIL_SOUNDBDATA_SECTIONRepository{get;set;}
 
		IRAIL_SOUNDDEVICE_LASTWARNRepository IRAIL_SOUNDDEVICE_LASTWARNRepository{get;set;}
 
		IRAIL_SOUNDDEVICE_WARNRepository IRAIL_SOUNDDEVICE_WARNRepository{get;set;}
 
		IRAIL_SOUNDRECEIVE_ORIDATARepository IRAIL_SOUNDRECEIVE_ORIDATARepository{get;set;}
 
		IRAIL_SOUNDRECORD_LASTWARNRepository IRAIL_SOUNDRECORD_LASTWARNRepository{get;set;}
 
		IRAIL_SOUNDRECORD_POINTRepository IRAIL_SOUNDRECORD_POINTRepository{get;set;}
 
		IRAIL_SOUNDRECORD_WARNRepository IRAIL_SOUNDRECORD_WARNRepository{get;set;}
 
		IRAIL_SOUNDRECORD_WARN_FINALRepository IRAIL_SOUNDRECORD_WARN_FINALRepository{get;set;}
 
		IRAIL_SOUNDSECTION_LASTWARNRepository IRAIL_SOUNDSECTION_LASTWARNRepository{get;set;}
 
		IRAIL_SOUNDSECTION_WARNRepository IRAIL_SOUNDSECTION_WARNRepository{get;set;}
 
		IRAIL_SOUNDWAVE_LOGRepository IRAIL_SOUNDWAVE_LOGRepository{get;set;}
 
		IRAILCAR_BDATARepository IRAILCAR_BDATARepository{get;set;}
 
		IRAILCAR_BDATA_ONLINERepository IRAILCAR_BDATA_ONLINERepository{get;set;}
 
		IRAILCAR_FILERepository IRAILCAR_FILERepository{get;set;}
 
		IRAIN_DEVICERepository IRAIN_DEVICERepository{get;set;}
 
		IRAIN_DEVICE_PLANLOGRepository IRAIN_DEVICE_PLANLOGRepository{get;set;}
 
		IRAIN_FLOOD_LABOURRepository IRAIN_FLOOD_LABOURRepository{get;set;}
 
		IRAIN_FLOOD_RESERVE_PLANRepository IRAIN_FLOOD_RESERVE_PLANRepository{get;set;}
 
		IRAIN_FLOOD_STOCKRepository IRAIN_FLOOD_STOCKRepository{get;set;}
 
		IRAIN_FLOOD_STOCK_PHOTORepository IRAIN_FLOOD_STOCK_PHOTORepository{get;set;}
 
		IRAIN_PLANRepository IRAIN_PLANRepository{get;set;}
 
		IRAIN_PLAN_WARNRepository IRAIN_PLAN_WARNRepository{get;set;}
 
		IRAIN_SECTION_LINERepository IRAIN_SECTION_LINERepository{get;set;}
 
		IREPAIR_ACCOUNTRepository IREPAIR_ACCOUNTRepository{get;set;}
 
		IREPAIR_OVERRUNRepository IREPAIR_OVERRUNRepository{get;set;}
 
		IRESCUE_LINERepository IRESCUE_LINERepository{get;set;}
 
		IRESCUE_LINE_INFORepository IRESCUE_LINE_INFORepository{get;set;}
 
		IRESCUE_LINE_PHOTORepository IRESCUE_LINE_PHOTORepository{get;set;}
 
		IRESCUE_LINE_PORTRepository IRESCUE_LINE_PORTRepository{get;set;}
 
		IROADBED_ITEM_PARARepository IROADBED_ITEM_PARARepository{get;set;}
 
		IROADBED_KEYDISEASE_EVALUATERepository IROADBED_KEYDISEASE_EVALUATERepository{get;set;}
 
		IROADBED_KEYDISEASE_PRORepository IROADBED_KEYDISEASE_PRORepository{get;set;}
 
		IROADBED_KEYDISEASE_PRO_HISRepository IROADBED_KEYDISEASE_PRO_HISRepository{get;set;}
 
		IROADBED_KEYDISEASE_REPORTRepository IROADBED_KEYDISEASE_REPORTRepository{get;set;}
 
		IRULE_BASE_DEPTRepository IRULE_BASE_DEPTRepository{get;set;}
 
		IRULE_BDATE_DICRepository IRULE_BDATE_DICRepository{get;set;}
 
		IRULE_DOCRepository IRULE_DOCRepository{get;set;}
 
		IRULE_DOC_ITEMRepository IRULE_DOC_ITEMRepository{get;set;}
 
		IRULE_DOC_KEYWORDRepository IRULE_DOC_KEYWORDRepository{get;set;}
 
		IRULE_KEYWORDRepository IRULE_KEYWORDRepository{get;set;}
 
		IRULE_PARA_SCORERepository IRULE_PARA_SCORERepository{get;set;}
 
		IRULE_PARSE_MARKUPRepository IRULE_PARSE_MARKUPRepository{get;set;}
 
		IRULE_PARSE_MARKUP_MATCHRepository IRULE_PARSE_MARKUP_MATCHRepository{get;set;}
 
		IRULE_PARSE_RESULTRepository IRULE_PARSE_RESULTRepository{get;set;}
 
		IRULE_PARSE_RESULT_REPORTRepository IRULE_PARSE_RESULT_REPORTRepository{get;set;}
 
		IRULE_PROBLEMRepository IRULE_PROBLEMRepository{get;set;}
 
		IRULE_PROBLEM_BLAMERepository IRULE_PROBLEM_BLAMERepository{get;set;}
 
		IRULE_PROBLEM_KEYWORDRepository IRULE_PROBLEM_KEYWORDRepository{get;set;}
 
		IRULE_PROBLEM_POSTRepository IRULE_PROBLEM_POSTRepository{get;set;}
 
		IRULE_PROBLEM_PUBLISH_CONFIGERRepository IRULE_PROBLEM_PUBLISH_CONFIGERRepository{get;set;}
 
		IRULE_PROBLEM_PUNISHRepository IRULE_PROBLEM_PUNISHRepository{get;set;}
 
		IRULE_RESULT_CENSUSRepository IRULE_RESULT_CENSUSRepository{get;set;}
 
		IRULE_RESULT_PROTREND_TMPRepository IRULE_RESULT_PROTREND_TMPRepository{get;set;}
 
		ISCRIPT_SECTION_BRIDGETUNNELRepository ISCRIPT_SECTION_BRIDGETUNNELRepository{get;set;}
 
		ISCRIPTS_LEADER_MONITORERepository ISCRIPTS_LEADER_MONITORERepository{get;set;}
 
		ISCRIPTS_MEMBER_ONLINERepository ISCRIPTS_MEMBER_ONLINERepository{get;set;}
 
		ISCRIPTS_SECTION_BADSIGNALRepository ISCRIPTS_SECTION_BADSIGNALRepository{get;set;}
 
		ISCRIPTS_SECTION_FLOOD_PHOTORepository ISCRIPTS_SECTION_FLOOD_PHOTORepository{get;set;}
 
		ISCRIPTS_SECTION_FLOOD_PIC_TESTRepository ISCRIPTS_SECTION_FLOOD_PIC_TESTRepository{get;set;}
 
		ISCRIPTS_SECTION_LINERepository ISCRIPTS_SECTION_LINERepository{get;set;}
 
		ISCRIPTS_SECTION_OTHER_PHOTORepository ISCRIPTS_SECTION_OTHER_PHOTORepository{get;set;}
 
		ISCRIPTS_SECTION_ROAD_LINERepository ISCRIPTS_SECTION_ROAD_LINERepository{get;set;}
 
		ISCRIPTS_SECTION_ROADMOTORRepository ISCRIPTS_SECTION_ROADMOTORRepository{get;set;}
 
		ISCRIPTS_SECTION_TRACKRepository ISCRIPTS_SECTION_TRACKRepository{get;set;}
 
		ISCRIPTS_SECTION_TRACK_INFORepository ISCRIPTS_SECTION_TRACK_INFORepository{get;set;}
 
		ISCRIPTS_SECTION_TYPECROSSRepository ISCRIPTS_SECTION_TYPECROSSRepository{get;set;}
 
		ISCRIPTS_SECTION_TYPEFLOODRepository ISCRIPTS_SECTION_TYPEFLOODRepository{get;set;}
 
		ISCRIPTS_SECTION_TYPEOTHERRepository ISCRIPTS_SECTION_TYPEOTHERRepository{get;set;}
 
		ISCRIPTS_SECTION_TYPEOTHERINFORepository ISCRIPTS_SECTION_TYPEOTHERINFORepository{get;set;}
 
		ISCRIPTS_SPECIAL_FLAGRepository ISCRIPTS_SPECIAL_FLAGRepository{get;set;}
 
		ISCRIPTS_STATION_CHECKRepository ISCRIPTS_STATION_CHECKRepository{get;set;}
 
		ISNOW_BDATA_DEVICERepository ISNOW_BDATA_DEVICERepository{get;set;}
 
		ISNOW_BDATA_WARNSTANDARDRepository ISNOW_BDATA_WARNSTANDARDRepository{get;set;}
 
		ISNOW_RECORD_HISRepository ISNOW_RECORD_HISRepository{get;set;}
 
		ISNOW_SECTION_LINERepository ISNOW_SECTION_LINERepository{get;set;}
 
		ISNOW_VIDEO_FILERepository ISNOW_VIDEO_FILERepository{get;set;}
 
		ISYS_DEPTRepository ISYS_DEPTRepository{get;set;}
 
		ISYS_INTELLIGENCE_DICRepository ISYS_INTELLIGENCE_DICRepository{get;set;}
 
		ISYS_MEMBERRepository ISYS_MEMBERRepository{get;set;}
 
		ISYS_MENURepository ISYS_MENURepository{get;set;}
 
		ISYS_MENU_HELPCONTENTRepository ISYS_MENU_HELPCONTENTRepository{get;set;}
 
		ISYS_MENUOPTRepository ISYS_MENUOPTRepository{get;set;}
 
		ISYS_POSLEVEL_DICRepository ISYS_POSLEVEL_DICRepository{get;set;}
 
		ISYS_ROLERepository ISYS_ROLERepository{get;set;}
 
		ISYS_ROLE_MENU_MAPRepository ISYS_ROLE_MENU_MAPRepository{get;set;}
 
		ISYS_ROLE_MENUOPT_MAPRepository ISYS_ROLE_MENUOPT_MAPRepository{get;set;}
 
		ISYS_STATIONMEMBER_NORepository ISYS_STATIONMEMBER_NORepository{get;set;}
 
		ISYS_USERRepository ISYS_USERRepository{get;set;}
 
		ISYS_USER_DEFAULTMENURepository ISYS_USER_DEFAULTMENURepository{get;set;}
 
		ISYS_USER_PHONE_DICRepository ISYS_USER_PHONE_DICRepository{get;set;}
 
		ISYS_USER_ROLE_MAPRepository ISYS_USER_ROLE_MAPRepository{get;set;}
 
		ISYS_USERLOGINRepository ISYS_USERLOGINRepository{get;set;}
 
		IT_ASS_BOUNDRepository IT_ASS_BOUNDRepository{get;set;}
 
		IT_ASS_BRIDGERepository IT_ASS_BRIDGERepository{get;set;}
 
		IT_ASS_BROKENCHAINRepository IT_ASS_BROKENCHAINRepository{get;set;}
 
		IT_ASS_COMBINEDRAWRepository IT_ASS_COMBINEDRAWRepository{get;set;}
 
		IT_ASS_COMPMAINT_PLANRepository IT_ASS_COMPMAINT_PLANRepository{get;set;}
 
		IT_ASS_COMPMAINT_PLAN_DETAILRepository IT_ASS_COMPMAINT_PLAN_DETAILRepository{get;set;}
 
		IT_ASS_CURVERepository IT_ASS_CURVERepository{get;set;}
 
		IT_ASS_EMPRepository IT_ASS_EMPRepository{get;set;}
 
		IT_ASS_EQU_DATA_TEMPRepository IT_ASS_EQU_DATA_TEMPRepository{get;set;}
 
		IT_ASS_FLOWRepository IT_ASS_FLOWRepository{get;set;}
 
		IT_ASS_FLOW_INSTANCERepository IT_ASS_FLOW_INSTANCERepository{get;set;}
 
		IT_ASS_FLOW_PROCESSRepository IT_ASS_FLOW_PROCESSRepository{get;set;}
 
		IT_ASS_FLOW_ROLERepository IT_ASS_FLOW_ROLERepository{get;set;}
 
		IT_ASS_FLOW_STEPRepository IT_ASS_FLOW_STEPRepository{get;set;}
 
		IT_ASS_FLOW_USER_ROLERepository IT_ASS_FLOW_USER_ROLERepository{get;set;}
 
		IT_ASS_GJC_AVESCORERepository IT_ASS_GJC_AVESCORERepository{get;set;}
 
		IT_ASS_LINEDRAWRepository IT_ASS_LINEDRAWRepository{get;set;}
 
		IT_ASS_MATERIALRepository IT_ASS_MATERIALRepository{get;set;}
 
		IT_ASS_PARA_DYN_SCORERepository IT_ASS_PARA_DYN_SCORERepository{get;set;}
 
		IT_ASS_PARA_LEVEL_SCORERepository IT_ASS_PARA_LEVEL_SCORERepository{get;set;}
 
		IT_ASS_PARA_PLACERepository IT_ASS_PARA_PLACERepository{get;set;}
 
		IT_ASS_PARA_PRO_CTRLRepository IT_ASS_PARA_PRO_CTRLRepository{get;set;}
 
		IT_ASS_PARA_PRO_TYPERepository IT_ASS_PARA_PRO_TYPERepository{get;set;}
 
		IT_ASS_PARA_SCORERepository IT_ASS_PARA_SCORERepository{get;set;}
 
		IT_ASS_PARAREPORT_TEMPRepository IT_ASS_PARAREPORT_TEMPRepository{get;set;}
 
		IT_ASS_PLAN_CONSTRUCTIONRepository IT_ASS_PLAN_CONSTRUCTIONRepository{get;set;}
 
		IT_ASS_PLAN_DAILYRepository IT_ASS_PLAN_DAILYRepository{get;set;}
 
		IT_ASS_PLAN_DATA_TEMPRepository IT_ASS_PLAN_DATA_TEMPRepository{get;set;}
 
		IT_ASS_PLAN_FLOWRepository IT_ASS_PLAN_FLOWRepository{get;set;}
 
		IT_ASS_PLAN_LOCATERepository IT_ASS_PLAN_LOCATERepository{get;set;}
 
		IT_ASS_PLAN_MATERIALRepository IT_ASS_PLAN_MATERIALRepository{get;set;}
 
		IT_ASS_PLAN_MEMBERRepository IT_ASS_PLAN_MEMBERRepository{get;set;}
 
		IT_ASS_PLAN_MONTHRepository IT_ASS_PLAN_MONTHRepository{get;set;}
 
		IT_ASS_PLAN_PROBLEMRepository IT_ASS_PLAN_PROBLEMRepository{get;set;}
 
		IT_ASS_PLAN_PROJECTRepository IT_ASS_PLAN_PROJECTRepository{get;set;}
 
		IT_ASS_PLAN_REPAIRRepository IT_ASS_PLAN_REPAIRRepository{get;set;}
 
		IT_ASS_PLAN_TOOLRepository IT_ASS_PLAN_TOOLRepository{get;set;}
 
		IT_ASS_PLAN_UNIT_PRO_STATRepository IT_ASS_PLAN_UNIT_PRO_STATRepository{get;set;}
 
		IT_ASS_PLAN_WEEKRepository IT_ASS_PLAN_WEEKRepository{get;set;}
 
		IT_ASS_PROBLEMRepository IT_ASS_PROBLEMRepository{get;set;}
 
		IT_ASS_PROBLEM_HISRepository IT_ASS_PROBLEM_HISRepository{get;set;}
 
		IT_ASS_PROBLEM_LJRepository IT_ASS_PROBLEM_LJRepository{get;set;}
 
		IT_ASS_PROBLEM_ORIRepository IT_ASS_PROBLEM_ORIRepository{get;set;}
 
		IT_ASS_PROBLEM_TEMPRepository IT_ASS_PROBLEM_TEMPRepository{get;set;}
 
		IT_ASS_PROJECTRepository IT_ASS_PROJECTRepository{get;set;}
 
		IT_ASS_REPEAT_PROBLEMRepository IT_ASS_REPEAT_PROBLEMRepository{get;set;}
 
		IT_ASS_REPEAT_PRODETAILRepository IT_ASS_REPEAT_PRODETAILRepository{get;set;}
 
		IT_ASS_SECURITY_OFFERRepository IT_ASS_SECURITY_OFFERRepository{get;set;}
 
		IT_ASS_STATIONRepository IT_ASS_STATIONRepository{get;set;}
 
		IT_ASS_STATIONSTAIRSRepository IT_ASS_STATIONSTAIRSRepository{get;set;}
 
		IT_ASS_TEMREPAIR_PLANRepository IT_ASS_TEMREPAIR_PLANRepository{get;set;}
 
		IT_ASS_TEMREPAIR_PLAN_DETAILRepository IT_ASS_TEMREPAIR_PLAN_DETAILRepository{get;set;}
 
		IT_ASS_TOOLINFORepository IT_ASS_TOOLINFORepository{get;set;}
 
		IT_ASS_TQIRepository IT_ASS_TQIRepository{get;set;}
 
		IT_ASS_TQI_AVESCORERepository IT_ASS_TQI_AVESCORERepository{get;set;}
 
		IT_ASS_TQI_DETAILRepository IT_ASS_TQI_DETAILRepository{get;set;}
 
		IT_ASS_TQI_PARARepository IT_ASS_TQI_PARARepository{get;set;}
 
		IT_ASS_TQI_PARA2Repository IT_ASS_TQI_PARA2Repository{get;set;}
 
		IT_ASS_TRACKRepository IT_ASS_TRACKRepository{get;set;}
 
		IT_ASS_TRACK_VALRepository IT_ASS_TRACK_VALRepository{get;set;}
 
		IT_ASS_TRACK_VAL_DETAILRepository IT_ASS_TRACK_VAL_DETAILRepository{get;set;}
 
		IT_ASS_TUNNELRepository IT_ASS_TUNNELRepository{get;set;}
 
		IT_ASS_TURNOUTRepository IT_ASS_TURNOUTRepository{get;set;}
 
		IT_ASS_TURNOUT_VALRepository IT_ASS_TURNOUT_VALRepository{get;set;}
 
		IT_ASS_TURNOUT_VAL_DETAILRepository IT_ASS_TURNOUT_VAL_DETAILRepository{get;set;}
 
		IT_ASS_UNITRepository IT_ASS_UNITRepository{get;set;}
 
		IT_ASS_UNIT_TQIRepository IT_ASS_UNIT_TQIRepository{get;set;}
 
		IT_ASS_UNIT_VALRepository IT_ASS_UNIT_VALRepository{get;set;}
 
		IT_ASS_UNIT_VAL_DETAILRepository IT_ASS_UNIT_VAL_DETAILRepository{get;set;}
 
		IT_ASS_UNIT625Repository IT_ASS_UNIT625Repository{get;set;}
 
		IT_ASS_UNIT625_VALRepository IT_ASS_UNIT625_VALRepository{get;set;}
 
		IT_ASS_UNIT625_VAL_DETAILRepository IT_ASS_UNIT625_VAL_DETAILRepository{get;set;}
 
		IT_BOOTRECINFORepository IT_BOOTRECINFORepository{get;set;}
 
		IT_CARLASTOBDRepository IT_CARLASTOBDRepository{get;set;}
 
		IT_CAROBDRepository IT_CAROBDRepository{get;set;}
 
		IT_CHK_CURVERepository IT_CHK_CURVERepository{get;set;}
 
		IT_CHK_CURVE_ITEMSRepository IT_CHK_CURVE_ITEMSRepository{get;set;}
 
		IT_CHK_DICRepository IT_CHK_DICRepository{get;set;}
 
		IT_CHK_DISEASE_ITEMSRepository IT_CHK_DISEASE_ITEMSRepository{get;set;}
 
		IT_CHK_DISEASE_STANDARDRepository IT_CHK_DISEASE_STANDARDRepository{get;set;}
 
		IT_CHK_LINERepository IT_CHK_LINERepository{get;set;}
 
		IT_CHK_LINE_ITEMSRepository IT_CHK_LINE_ITEMSRepository{get;set;}
 
		IT_CHK_MEDIA_ITEMSRepository IT_CHK_MEDIA_ITEMSRepository{get;set;}
 
		IT_CHK_TURNOUTRepository IT_CHK_TURNOUTRepository{get;set;}
 
		IT_CHK_TURNOUT_DIAMOND_ITEMSRepository IT_CHK_TURNOUT_DIAMOND_ITEMSRepository{get;set;}
 
		IT_CHK_TURNOUT_DOUBLE_ITEMSRepository IT_CHK_TURNOUT_DOUBLE_ITEMSRepository{get;set;}
 
		IT_CHK_TURNOUT_ITEMSRepository IT_CHK_TURNOUT_ITEMSRepository{get;set;}
 
		IT_CHK_TURNOUT_MOVPOINT_ITEMSRepository IT_CHK_TURNOUT_MOVPOINT_ITEMSRepository{get;set;}
 
		IT_CHK_TURNOUT_SLIP_ITEMSRepository IT_CHK_TURNOUT_SLIP_ITEMSRepository{get;set;}
 
		IT_CHK_VISCHECK_ITEMSRepository IT_CHK_VISCHECK_ITEMSRepository{get;set;}
 
		IT_CHK_VISUAL_ITEMSRepository IT_CHK_VISUAL_ITEMSRepository{get;set;}
 
		IT_CHK_WIDENING_VALUERepository IT_CHK_WIDENING_VALUERepository{get;set;}
 
		IT_CHKPOSRepository IT_CHKPOSRepository{get;set;}
 
		IT_CUSTOM_STATIONRepository IT_CUSTOM_STATIONRepository{get;set;}
 
		IT_CZ_CCRepository IT_CZ_CCRepository{get;set;}
 
		IT_CZ_FREQ_TEMPRepository IT_CZ_FREQ_TEMPRepository{get;set;}
 
		IT_CZ_GJRepository IT_CZ_GJRepository{get;set;}
 
		IT_CZ_JCHRepository IT_CZ_JCHRepository{get;set;}
 
		IT_CZ_NLINENORepository IT_CZ_NLINENORepository{get;set;}
 
		IT_CZ_PHONERepository IT_CZ_PHONERepository{get;set;}
 
		IT_CZ_TBLRepository IT_CZ_TBLRepository{get;set;}
 
		IT_CZ_TDWID_TEMPRepository IT_CZ_TDWID_TEMPRepository{get;set;}
 
		IT_CZ_TJ_TEMPRepository IT_CZ_TJ_TEMPRepository{get;set;}
 
		IT_CZ_WARPRepository IT_CZ_WARPRepository{get;set;}
 
		IT_CZ_WARP_TEMPRepository IT_CZ_WARP_TEMPRepository{get;set;}
 
		IT_GIS_LINERepository IT_GIS_LINERepository{get;set;}
 
		IT_GIS_LINE_TESTRepository IT_GIS_LINE_TESTRepository{get;set;}
 
		IT_GIS_LINE_TEST_NOPWDRepository IT_GIS_LINE_TEST_NOPWDRepository{get;set;}
 
		IT_GIS_STATIONRepository IT_GIS_STATIONRepository{get;set;}
 
		IT_GIS_STATION_TESTRepository IT_GIS_STATION_TESTRepository{get;set;}
 
		IT_GWBASERepository IT_GWBASERepository{get;set;}
 
		IT_GWBASE_SECTION_LINERepository IT_GWBASE_SECTION_LINERepository{get;set;}
 
		IT_GWBASE_TESTRepository IT_GWBASE_TESTRepository{get;set;}
 
		IT_GWDETAILRepository IT_GWDETAILRepository{get;set;}
 
		IT_GWTRANSETRepository IT_GWTRANSETRepository{get;set;}
 
		IT_JOB_LINERepository IT_JOB_LINERepository{get;set;}
 
		IT_LKJ_FLOW_ATTACHRepository IT_LKJ_FLOW_ATTACHRepository{get;set;}
 
		IT_LKJ_FLOW_DOCRepository IT_LKJ_FLOW_DOCRepository{get;set;}
 
		IT_LKJ_FLOW_FEEDBACKRepository IT_LKJ_FLOW_FEEDBACKRepository{get;set;}
 
		IT_LKJ_FLOW_INFORepository IT_LKJ_FLOW_INFORepository{get;set;}
 
		IT_LKJ_FLOW_MESSAGERepository IT_LKJ_FLOW_MESSAGERepository{get;set;}
 
		IT_LKJ_FLOW_REFERENCERepository IT_LKJ_FLOW_REFERENCERepository{get;set;}
 
		IT_LKJ_FLOW_ROLERepository IT_LKJ_FLOW_ROLERepository{get;set;}
 
		IT_LKJ_FLOW_STEPINFORepository IT_LKJ_FLOW_STEPINFORepository{get;set;}
 
		IT_LKJ_FLOW_USERROLERepository IT_LKJ_FLOW_USERROLERepository{get;set;}
 
		IT_LKJ_LINESTATIONRepository IT_LKJ_LINESTATIONRepository{get;set;}
 
		IT_LKJ_ROLEFLOWRepository IT_LKJ_ROLEFLOWRepository{get;set;}
 
		IT_LKJ_S1Repository IT_LKJ_S1Repository{get;set;}
 
		IT_LKJ_S1_HISRepository IT_LKJ_S1_HISRepository{get;set;}
 
		IT_LKJ_S10Repository IT_LKJ_S10Repository{get;set;}
 
		IT_LKJ_S10_HISRepository IT_LKJ_S10_HISRepository{get;set;}
 
		IT_LKJ_S11Repository IT_LKJ_S11Repository{get;set;}
 
		IT_LKJ_S11_HISRepository IT_LKJ_S11_HISRepository{get;set;}
 
		IT_LKJ_S12Repository IT_LKJ_S12Repository{get;set;}
 
		IT_LKJ_S12_HISRepository IT_LKJ_S12_HISRepository{get;set;}
 
		IT_LKJ_S13Repository IT_LKJ_S13Repository{get;set;}
 
		IT_LKJ_S13_HISRepository IT_LKJ_S13_HISRepository{get;set;}
 
		IT_LKJ_S2Repository IT_LKJ_S2Repository{get;set;}
 
		IT_LKJ_S2_HISRepository IT_LKJ_S2_HISRepository{get;set;}
 
		IT_LKJ_S3Repository IT_LKJ_S3Repository{get;set;}
 
		IT_LKJ_S3_HISRepository IT_LKJ_S3_HISRepository{get;set;}
 
		IT_LKJ_S4Repository IT_LKJ_S4Repository{get;set;}
 
		IT_LKJ_S4_HISRepository IT_LKJ_S4_HISRepository{get;set;}
 
		IT_LKJ_S5Repository IT_LKJ_S5Repository{get;set;}
 
		IT_LKJ_S5_HISRepository IT_LKJ_S5_HISRepository{get;set;}
 
		IT_LKJ_S6Repository IT_LKJ_S6Repository{get;set;}
 
		IT_LKJ_S6_HISRepository IT_LKJ_S6_HISRepository{get;set;}
 
		IT_LKJ_S7Repository IT_LKJ_S7Repository{get;set;}
 
		IT_LKJ_S7_HISRepository IT_LKJ_S7_HISRepository{get;set;}
 
		IT_LKJ_S8Repository IT_LKJ_S8Repository{get;set;}
 
		IT_LKJ_S8_HISRepository IT_LKJ_S8_HISRepository{get;set;}
 
		IT_LKJ_S9Repository IT_LKJ_S9Repository{get;set;}
 
		IT_LKJ_S9_HISRepository IT_LKJ_S9_HISRepository{get;set;}
 
		IT_LKJ_ST1Repository IT_LKJ_ST1Repository{get;set;}
 
		IT_LKJ_ST1_HISRepository IT_LKJ_ST1_HISRepository{get;set;}
 
		IT_LKJ_STARELTIONRepository IT_LKJ_STARELTIONRepository{get;set;}
 
		IT_LKJ_SYSTABLERepository IT_LKJ_SYSTABLERepository{get;set;}
 
		IT_LKJ_VERSIONNUMRepository IT_LKJ_VERSIONNUMRepository{get;set;}
 
		IT_LKJ_WIRINGDIAGRAMRepository IT_LKJ_WIRINGDIAGRAMRepository{get;set;}
 
		IT_LKJ_WORKPROCESSRepository IT_LKJ_WORKPROCESSRepository{get;set;}
 
		IT_LKJ_WORKPROCESS_HISRepository IT_LKJ_WORKPROCESS_HISRepository{get;set;}
 
		IT_MOBILEFILERepository IT_MOBILEFILERepository{get;set;}
 
		IT_MOBILEFILE_TODOWNRepository IT_MOBILEFILE_TODOWNRepository{get;set;}
 
		IT_MOBILELASTPOSRepository IT_MOBILELASTPOSRepository{get;set;}
 
		IT_MOBILEROUTERepository IT_MOBILEROUTERepository{get;set;}
 
		IT_MOBILEROUTE_HISRepository IT_MOBILEROUTE_HISRepository{get;set;}
 
		IT_OILPOSRepository IT_OILPOSRepository{get;set;}
 
		IT_RAINRepository IT_RAINRepository{get;set;}
 
		IT_RAIN_SMSRepository IT_RAIN_SMSRepository{get;set;}
 
		IT_RAINWARNRepository IT_RAINWARNRepository{get;set;}
 
		IT_REALRAINDATARepository IT_REALRAINDATARepository{get;set;}
 
		IT_SGJHWARNRepository IT_SGJHWARNRepository{get;set;}
 
		IT_SGJHWARNTMPRepository IT_SGJHWARNTMPRepository{get;set;}
 
		IT_VEHICLELOCATIONRepository IT_VEHICLELOCATIONRepository{get;set;}
 
		IT_WATERRepository IT_WATERRepository{get;set;}
 
		IT_WATER_DEVICERepository IT_WATER_DEVICERepository{get;set;}
 
		IT_WATER_WARNRepository IT_WATER_WARNRepository{get;set;}
 
		ITASK_CARDRepository ITASK_CARDRepository{get;set;}
 
		ITASK_CONSTITLERepository ITASK_CONSTITLERepository{get;set;}
 
		ITASK_CONSTRUCTIONRepository ITASK_CONSTRUCTIONRepository{get;set;}
 
		ITASK_DAMAGE_RAILRepository ITASK_DAMAGE_RAILRepository{get;set;}
 
		ITASK_FLOORRepository ITASK_FLOORRepository{get;set;}
 
		ITASK_GBH_RAILRepository ITASK_GBH_RAILRepository{get;set;}
 
		ITASK_LAY_LINEROADRepository ITASK_LAY_LINEROADRepository{get;set;}
 
		ITASK_PLANRepository ITASK_PLANRepository{get;set;}
 
		ITASK_PLAN_MATERIALRepository ITASK_PLAN_MATERIALRepository{get;set;}
 
		ITASK_PLAN_PROBLEMRepository ITASK_PLAN_PROBLEMRepository{get;set;}
 
		ITASK_PLAN_TOOLRepository ITASK_PLAN_TOOLRepository{get;set;}
 
		ITASK_RAILRepository ITASK_RAILRepository{get;set;}
 
		ITASK_RAILCOUNTRepository ITASK_RAILCOUNTRepository{get;set;}
 
		ITASK_RECOVER_STUFFRepository ITASK_RECOVER_STUFFRepository{get;set;}
 
		ITASK_REPLACE_RAILRepository ITASK_REPLACE_RAILRepository{get;set;}
 
		ITASK_REPLACE_TIERepository ITASK_REPLACE_TIERepository{get;set;}
 
		ITASK_SLIGHT_FROGRepository ITASK_SLIGHT_FROGRepository{get;set;}
 
		ITASK_SLIGHT_JRAILRepository ITASK_SLIGHT_JRAILRepository{get;set;}
 
		ITASK_SLIGHT_OUTLINERepository ITASK_SLIGHT_OUTLINERepository{get;set;}
 
		ITASK_SLIGHT_OUTLINE_FILERepository ITASK_SLIGHT_OUTLINE_FILERepository{get;set;}
 
		ITASK_SLIGHT_RAILRepository ITASK_SLIGHT_RAILRepository{get;set;}
 
		ITASK_SLIGHT_RAILP43Repository ITASK_SLIGHT_RAILP43Repository{get;set;}
 
		ITASK_SLIGHT_RAILP50Repository ITASK_SLIGHT_RAILP50Repository{get;set;}
 
		ITASK_SLIGHT_RAILP60Repository ITASK_SLIGHT_RAILP60Repository{get;set;}
 
		ITASK_SVGRepository ITASK_SVGRepository{get;set;}
 
		ITASK_TOOLINFORepository ITASK_TOOLINFORepository{get;set;}
 
		ITASK_UNLOAD_RAILRepository ITASK_UNLOAD_RAILRepository{get;set;}
 
		ITASK_UNLOAD_STONERepository ITASK_UNLOAD_STONERepository{get;set;}
 
		ITASK_UNLOAD_TIERepository ITASK_UNLOAD_TIERepository{get;set;}
 
		ITASK_WORKLOADRepository ITASK_WORKLOADRepository{get;set;}
 
		ITEMPERATURE_SECTION_LINERepository ITEMPERATURE_SECTION_LINERepository{get;set;}
 
		ITOOL_BDATE_DICRepository ITOOL_BDATE_DICRepository{get;set;}
 
		ITOOL_BDATE_STOREHOURSERepository ITOOL_BDATE_STOREHOURSERepository{get;set;}
 
		ITOOL_BDATE_TOOLNAMERepository ITOOL_BDATE_TOOLNAMERepository{get;set;}
 
		ITOOL_INOUTMNG_INFORepository ITOOL_INOUTMNG_INFORepository{get;set;}
 
		ITOOL_JOB_PLANRepository ITOOL_JOB_PLANRepository{get;set;}
 
		ITOOL_JOB_PLAN_IMPORTRepository ITOOL_JOB_PLAN_IMPORTRepository{get;set;}
 
		ITOOL_PHONE_USERRepository ITOOL_PHONE_USERRepository{get;set;}
 
		ITOOL_TOOLMNG_INOUTRepository ITOOL_TOOLMNG_INOUTRepository{get;set;}
 
		ITOOL_UPDOWN_LINERepository ITOOL_UPDOWN_LINERepository{get;set;}
 
		ITOOL_USERepository ITOOL_USERepository{get;set;}
 
		ITOOL_VIRTUAL_JOB_PLANRepository ITOOL_VIRTUAL_JOB_PLANRepository{get;set;}
 
		ITOOL_VIRTUAL_UPDOWN_LINERepository ITOOL_VIRTUAL_UPDOWN_LINERepository{get;set;}
 
		ITOOL_VIRTUAL_USERepository ITOOL_VIRTUAL_USERepository{get;set;}
 
		ITOOL_VIRTUAL_WARMRepository ITOOL_VIRTUAL_WARMRepository{get;set;}
 
		ITOOL_WARMRepository ITOOL_WARMRepository{get;set;}
 
		ITURNOUT_BASERepository ITURNOUT_BASERepository{get;set;}
 
		ITURNOUT_BDATE_DICRepository ITURNOUT_BDATE_DICRepository{get;set;}
 
		ITURNOUT_BRANCHRepository ITURNOUT_BRANCHRepository{get;set;}
 
		ITURNOUT_HIS_BRANCHRepository ITURNOUT_HIS_BRANCHRepository{get;set;}
 
		ITURNOUT_HIS_PARTRepository ITURNOUT_HIS_PARTRepository{get;set;}
 
		ITURNOUT_HIS_PICRepository ITURNOUT_HIS_PICRepository{get;set;}
 
		ITURNOUT_HIS_RAILRepository ITURNOUT_HIS_RAILRepository{get;set;}
 
		ITURNOUT_HISTORYRepository ITURNOUT_HISTORYRepository{get;set;}
 
		ITURNOUT_PARTRepository ITURNOUT_PARTRepository{get;set;}
 
		ITURNOUT_PICRepository ITURNOUT_PICRepository{get;set;}
 
		ITURNOUT_RAILRepository ITURNOUT_RAILRepository{get;set;}
 
		ITYPEFLOOD_PHOTORepository ITYPEFLOOD_PHOTORepository{get;set;}
 
		IVEHICLELOC_BDATA_LOCOMOTIVERepository IVEHICLELOC_BDATA_LOCOMOTIVERepository{get;set;}
 
		IVIDEO_BDATA_DEVICERepository IVIDEO_BDATA_DEVICERepository{get;set;}
 
		IVIDEO_FILERepository IVIDEO_FILERepository{get;set;}
 
		IWEATHER_PROVINCE_FORECASTRepository IWEATHER_PROVINCE_FORECASTRepository{get;set;}
 
		IWEATHER_PROVINCE_HOURFORECASTRepository IWEATHER_PROVINCE_HOURFORECASTRepository{get;set;}
 
		IWINDRepository IWINDRepository{get;set;}
 
		IWIND_BASEINFORepository IWIND_BASEINFORepository{get;set;}
 
		IWIND_DAYRPTRepository IWIND_DAYRPTRepository{get;set;}
 
		IWIND_DIRECTIONRepository IWIND_DIRECTIONRepository{get;set;}
 
		IWIND_GRADINGRepository IWIND_GRADINGRepository{get;set;}
 
		IWIND_MONRPTRepository IWIND_MONRPTRepository{get;set;}
 
		IWIND_SECTION_LINERepository IWIND_SECTION_LINERepository{get;set;}
 
		IWIND_WARNRepository IWIND_WARNRepository{get;set;}
 
		IWIND_WARN_STANDARDRepository IWIND_WARN_STANDARDRepository{get;set;}
 
		IWIND_YEARRPTRepository IWIND_YEARRPTRepository{get;set;}
 
		IWUFENG_BIAOZHUNRepository IWUFENG_BIAOZHUNRepository{get;set;}
 
		IWUFENG_CHEZHANRepository IWUFENG_CHEZHANRepository{get;set;}
 
		IWUFENG_DANYUANRepository IWUFENG_DANYUANRepository{get;set;}
 
		IWUFENG_DANYUAN_LISHIRepository IWUFENG_DANYUAN_LISHIRepository{get;set;}
 
		IWUFENG_DAOCHARepository IWUFENG_DAOCHARepository{get;set;}
 
		IWUFENG_JILURepository IWUFENG_JILURepository{get;set;}
 
		IWUFENG_XIANMINGRepository IWUFENG_XIANMINGRepository{get;set;}
    }

}
