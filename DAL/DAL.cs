  
       
using System;       
using System.Collections.Generic;   
using System.Linq; 
using System.Text;        
using Model;    
using IDAL;   
namespace DAL
{  
	public partial class ALL_LINE_DATARepository : BaseRepository<ALL_LINE_DATA>,IALL_LINE_DATARepository
    {
    }
	public partial class ALL_STATION_DATARepository : BaseRepository<ALL_STATION_DATA>,IALL_STATION_DATARepository
    {
    }
	public partial class ALL_VEHTYPE_DATARepository : BaseRepository<ALL_VEHTYPE_DATA>,IALL_VEHTYPE_DATARepository
    {
    }
	public partial class ALL_VIDEOFILE_DATARepository : BaseRepository<ALL_VIDEOFILE_DATA>,IALL_VIDEOFILE_DATARepository
    {
    }
	public partial class ASSET_BASE_ACCOUNTRepository : BaseRepository<ASSET_BASE_ACCOUNT>,IASSET_BASE_ACCOUNTRepository
    {
    }
	public partial class ASSET_BASE_CATALOGRepository : BaseRepository<ASSET_BASE_CATALOG>,IASSET_BASE_CATALOGRepository
    {
    }
	public partial class ASSET_BASE_MATERIAL_DICRepository : BaseRepository<ASSET_BASE_MATERIAL_DIC>,IASSET_BASE_MATERIAL_DICRepository
    {
    }
	public partial class ASSET_BASE_RATERepository : BaseRepository<ASSET_BASE_RATE>,IASSET_BASE_RATERepository
    {
    }
	public partial class ASSET_BASE_RELATION_UNITRepository : BaseRepository<ASSET_BASE_RELATION_UNIT>,IASSET_BASE_RELATION_UNITRepository
    {
    }
	public partial class ASSET_BASE_SUPPLIERRepository : BaseRepository<ASSET_BASE_SUPPLIER>,IASSET_BASE_SUPPLIERRepository
    {
    }
	public partial class ASSET_BASE_SUPPLIER_MATERIALRepository : BaseRepository<ASSET_BASE_SUPPLIER_MATERIAL>,IASSET_BASE_SUPPLIER_MATERIALRepository
    {
    }
	public partial class ASSET_INVENTORYRepository : BaseRepository<ASSET_INVENTORY>,IASSET_INVENTORYRepository
    {
    }
	public partial class ASSET_MOBILERepository : BaseRepository<ASSET_MOBILE>,IASSET_MOBILERepository
    {
    }
	public partial class ASSET_MRPRepository : BaseRepository<ASSET_MRP>,IASSET_MRPRepository
    {
    }
	public partial class ASSET_MRP_BOMRepository : BaseRepository<ASSET_MRP_BOM>,IASSET_MRP_BOMRepository
    {
    }
	public partial class ASSET_WAREHOUSERepository : BaseRepository<ASSET_WAREHOUSE>,IASSET_WAREHOUSERepository
    {
    }
	public partial class BASE_BOUNDARYRepository : BaseRepository<BASE_BOUNDARY>,IBASE_BOUNDARYRepository
    {
    }
	public partial class BASE_DICTRepository : BaseRepository<BASE_DICT>,IBASE_DICTRepository
    {
    }
	public partial class BASE_LINERepository : BaseRepository<BASE_LINE>,IBASE_LINERepository
    {
    }
	public partial class BASE_STATIONRepository : BaseRepository<BASE_STATION>,IBASE_STATIONRepository
    {
    }
	public partial class BOOT_BASERepository : BaseRepository<BOOT_BASE>,IBOOT_BASERepository
    {
    }
	public partial class BOOT_RECORDRepository : BaseRepository<BOOT_RECORD>,IBOOT_RECORDRepository
    {
    }
	public partial class BRIDGE_BOUNDRepository : BaseRepository<BRIDGE_BOUND>,IBRIDGE_BOUNDRepository
    {
    }
	public partial class BRIDGE_BRIDGERepository : BaseRepository<BRIDGE_BRIDGE>,IBRIDGE_BRIDGERepository
    {
    }
	public partial class BRIDGE_CULVERTRepository : BaseRepository<BRIDGE_CULVERT>,IBRIDGE_CULVERTRepository
    {
    }
	public partial class BRIDGE_EQU_CLEARANCERepository : BaseRepository<BRIDGE_EQU_CLEARANCE>,IBRIDGE_EQU_CLEARANCERepository
    {
    }
	public partial class BRIDGE_EQU_CLEARANCE_FILERepository : BaseRepository<BRIDGE_EQU_CLEARANCE_FILE>,IBRIDGE_EQU_CLEARANCE_FILERepository
    {
    }
	public partial class BRIDGE_EQU_DATA_TEMPRepository : BaseRepository<BRIDGE_EQU_DATA_TEMP>,IBRIDGE_EQU_DATA_TEMPRepository
    {
    }
	public partial class BRIDGE_EQU_FILERepository : BaseRepository<BRIDGE_EQU_FILE>,IBRIDGE_EQU_FILERepository
    {
    }
	public partial class BRIDGE_LIMITOVERHEADRepository : BaseRepository<BRIDGE_LIMITOVERHEAD>,IBRIDGE_LIMITOVERHEADRepository
    {
    }
	public partial class BRIDGE_LRONRepository : BaseRepository<BRIDGE_LRON>,IBRIDGE_LRONRepository
    {
    }
	public partial class BRIDGE_LRON_OVERPASSRepository : BaseRepository<BRIDGE_LRON_OVERPASS>,IBRIDGE_LRON_OVERPASSRepository
    {
    }
	public partial class BRIDGE_MAINTENAN_EVALUATERepository : BaseRepository<BRIDGE_MAINTENAN_EVALUATE>,IBRIDGE_MAINTENAN_EVALUATERepository
    {
    }
	public partial class BRIDGE_MAINTENAN_NOTICERepository : BaseRepository<BRIDGE_MAINTENAN_NOTICE>,IBRIDGE_MAINTENAN_NOTICERepository
    {
    }
	public partial class BRIDGE_MAINTENAN_NOTICE_PRORepository : BaseRepository<BRIDGE_MAINTENAN_NOTICE_PRO>,IBRIDGE_MAINTENAN_NOTICE_PRORepository
    {
    }
	public partial class BRIDGE_MAINTENAN_PRORepository : BaseRepository<BRIDGE_MAINTENAN_PRO>,IBRIDGE_MAINTENAN_PRORepository
    {
    }
	public partial class BRIDGE_MAINTENAN_PRO_HISRepository : BaseRepository<BRIDGE_MAINTENAN_PRO_HIS>,IBRIDGE_MAINTENAN_PRO_HISRepository
    {
    }
	public partial class BRIDGE_MAINTENAN_REPORTRepository : BaseRepository<BRIDGE_MAINTENAN_REPORT>,IBRIDGE_MAINTENAN_REPORTRepository
    {
    }
	public partial class BRIDGE_MSGRepository : BaseRepository<BRIDGE_MSG>,IBRIDGE_MSGRepository
    {
    }
	public partial class BRIDGE_OTHER_DEVICERepository : BaseRepository<BRIDGE_OTHER_DEVICE>,IBRIDGE_OTHER_DEVICERepository
    {
    }
	public partial class BRIDGE_OVERPASSRepository : BaseRepository<BRIDGE_OVERPASS>,IBRIDGE_OVERPASSRepository
    {
    }
	public partial class BRIDGE_OVERPASS_WATERRepository : BaseRepository<BRIDGE_OVERPASS_WATER>,IBRIDGE_OVERPASS_WATERRepository
    {
    }
	public partial class BRIDGE_PARA_MAINTENANRepository : BaseRepository<BRIDGE_PARA_MAINTENAN>,IBRIDGE_PARA_MAINTENANRepository
    {
    }
	public partial class BRIDGE_PARA_STATUSRepository : BaseRepository<BRIDGE_PARA_STATUS>,IBRIDGE_PARA_STATUSRepository
    {
    }
	public partial class BRIDGE_SHALLOW_FOUNDATIONRepository : BaseRepository<BRIDGE_SHALLOW_FOUNDATION>,IBRIDGE_SHALLOW_FOUNDATIONRepository
    {
    }
	public partial class BRIDGE_STATE_PRORepository : BaseRepository<BRIDGE_STATE_PRO>,IBRIDGE_STATE_PRORepository
    {
    }
	public partial class BRIDGE_STATE_PRO_FILERepository : BaseRepository<BRIDGE_STATE_PRO_FILE>,IBRIDGE_STATE_PRO_FILERepository
    {
    }
	public partial class BRIDGE_STATE_PRO_HISRepository : BaseRepository<BRIDGE_STATE_PRO_HIS>,IBRIDGE_STATE_PRO_HISRepository
    {
    }
	public partial class BRIDGE_STATE_REPORTRepository : BaseRepository<BRIDGE_STATE_REPORT>,IBRIDGE_STATE_REPORTRepository
    {
    }
	public partial class BRIDGE_TUNNELRepository : BaseRepository<BRIDGE_TUNNEL>,IBRIDGE_TUNNELRepository
    {
    }
	public partial class BROKENRAIL_BDATA_BOUNDARYRepository : BaseRepository<BROKENRAIL_BDATA_BOUNDARY>,IBROKENRAIL_BDATA_BOUNDARYRepository
    {
    }
	public partial class BROKENRAIL_BDATA_DEVICERepository : BaseRepository<BROKENRAIL_BDATA_DEVICE>,IBROKENRAIL_BDATA_DEVICERepository
    {
    }
	public partial class BROKENRAIL_BDATA_DEVICE_STATUSRepository : BaseRepository<BROKENRAIL_BDATA_DEVICE_STATUS>,IBROKENRAIL_BDATA_DEVICE_STATUSRepository
    {
    }
	public partial class BROKENRAIL_BDATA_SECTIONRepository : BaseRepository<BROKENRAIL_BDATA_SECTION>,IBROKENRAIL_BDATA_SECTIONRepository
    {
    }
	public partial class BROKENRAIL_DEVICE_STATUSRepository : BaseRepository<BROKENRAIL_DEVICE_STATUS>,IBROKENRAIL_DEVICE_STATUSRepository
    {
    }
	public partial class BROKENRAIL_DEVICE_STATUSHISRepository : BaseRepository<BROKENRAIL_DEVICE_STATUSHIS>,IBROKENRAIL_DEVICE_STATUSHISRepository
    {
    }
	public partial class BROKENRAIL_NEEDSENDRepository : BaseRepository<BROKENRAIL_NEEDSEND>,IBROKENRAIL_NEEDSENDRepository
    {
    }
	public partial class BROKENRAIL_SECTION_LINERepository : BaseRepository<BROKENRAIL_SECTION_LINE>,IBROKENRAIL_SECTION_LINERepository
    {
    }
	public partial class BROKENRAIL_SECTION_STATUSRepository : BaseRepository<BROKENRAIL_SECTION_STATUS>,IBROKENRAIL_SECTION_STATUSRepository
    {
    }
	public partial class BROKENRAIL_SECTION_STATUSHISRepository : BaseRepository<BROKENRAIL_SECTION_STATUSHIS>,IBROKENRAIL_SECTION_STATUSHISRepository
    {
    }
	public partial class BROKENRAIL_SOUND_SENDPHONERepository : BaseRepository<BROKENRAIL_SOUND_SENDPHONE>,IBROKENRAIL_SOUND_SENDPHONERepository
    {
    }
	public partial class BROKENRAIL_VOLTAGE_SMSRepository : BaseRepository<BROKENRAIL_VOLTAGE_SMS>,IBROKENRAIL_VOLTAGE_SMSRepository
    {
    }
	public partial class BROKENRAIL_VOLTAGE_STATUSRepository : BaseRepository<BROKENRAIL_VOLTAGE_STATUS>,IBROKENRAIL_VOLTAGE_STATUSRepository
    {
    }
	public partial class BROKENRAIL_VOLTAGE_STATUSHISRepository : BaseRepository<BROKENRAIL_VOLTAGE_STATUSHIS>,IBROKENRAIL_VOLTAGE_STATUSHISRepository
    {
    }
	public partial class BROKENRAIL_WARN_CONTROLRepository : BaseRepository<BROKENRAIL_WARN_CONTROL>,IBROKENRAIL_WARN_CONTROLRepository
    {
    }
	public partial class BROKENRAIL_WARN_DEVICERepository : BaseRepository<BROKENRAIL_WARN_DEVICE>,IBROKENRAIL_WARN_DEVICERepository
    {
    }
	public partial class BROKENRAIL_WARN_FLAGRepository : BaseRepository<BROKENRAIL_WARN_FLAG>,IBROKENRAIL_WARN_FLAGRepository
    {
    }
	public partial class CAR_BDATA_CARRepository : BaseRepository<CAR_BDATA_CAR>,ICAR_BDATA_CARRepository
    {
    }
	public partial class CAR_LAST_LONLATRepository : BaseRepository<CAR_LAST_LONLAT>,ICAR_LAST_LONLATRepository
    {
    }
	public partial class CAR_OVER_SPEEDRepository : BaseRepository<CAR_OVER_SPEED>,ICAR_OVER_SPEEDRepository
    {
    }
	public partial class CAR_OVERSPEED_WARNRepository : BaseRepository<CAR_OVERSPEED_WARN>,ICAR_OVERSPEED_WARNRepository
    {
    }
	public partial class CAR_PHONE_INFORepository : BaseRepository<CAR_PHONE_INFO>,ICAR_PHONE_INFORepository
    {
    }
	public partial class CHARTRepository : BaseRepository<CHART>,ICHARTRepository
    {
    }
	public partial class CHK_BDATA_DEVICERepository : BaseRepository<CHK_BDATA_DEVICE>,ICHK_BDATA_DEVICERepository
    {
    }
	public partial class COMMAND_PUBLISHRepository : BaseRepository<COMMAND_PUBLISH>,ICOMMAND_PUBLISHRepository
    {
    }
	public partial class COMMAND_PUBLISH_HISRepository : BaseRepository<COMMAND_PUBLISH_HIS>,ICOMMAND_PUBLISH_HISRepository
    {
    }
	public partial class CONFIR_CARRepository : BaseRepository<CONFIR_CAR>,ICONFIR_CARRepository
    {
    }
	public partial class CONFIR_CAR_PLANRepository : BaseRepository<CONFIR_CAR_PLAN>,ICONFIR_CAR_PLANRepository
    {
    }
	public partial class CONFIR_CAR_WARNRepository : BaseRepository<CONFIR_CAR_WARN>,ICONFIR_CAR_WARNRepository
    {
    }
	public partial class CONTROL_FOUR_DICRepository : BaseRepository<CONTROL_FOUR_DIC>,ICONTROL_FOUR_DICRepository
    {
    }
	public partial class CONTROL_FOUR_PLANRepository : BaseRepository<CONTROL_FOUR_PLAN>,ICONTROL_FOUR_PLANRepository
    {
    }
	public partial class CURVE_BASERepository : BaseRepository<CURVE_BASE>,ICURVE_BASERepository
    {
    }
	public partial class CURVE_BASE_EXTRepository : BaseRepository<CURVE_BASE_EXT>,ICURVE_BASE_EXTRepository
    {
    }
	public partial class CURVE_CWRRepository : BaseRepository<CURVE_CWR>,ICURVE_CWRRepository
    {
    }
	public partial class CURVE_PICRepository : BaseRepository<CURVE_PIC>,ICURVE_PICRepository
    {
    }
	public partial class CURVE_PSNRepository : BaseRepository<CURVE_PSN>,ICURVE_PSNRepository
    {
    }
	public partial class CURVE_RAILRepository : BaseRepository<CURVE_RAIL>,ICURVE_RAILRepository
    {
    }
	public partial class CURVE_RAILWEARRepository : BaseRepository<CURVE_RAILWEAR>,ICURVE_RAILWEARRepository
    {
    }
	public partial class DR_IDX_DOC_CONTENT_IRepository : BaseRepository<DR_IDX_DOC_CONTENT_I>,IDR_IDX_DOC_CONTENT_IRepository
    {
    }
	public partial class DR_IDX_DOC_CONTENT_KRepository : BaseRepository<DR_IDX_DOC_CONTENT_K>,IDR_IDX_DOC_CONTENT_KRepository
    {
    }
	public partial class DR_IDX_DOC_CONTENT_NRepository : BaseRepository<DR_IDX_DOC_CONTENT_N>,IDR_IDX_DOC_CONTENT_NRepository
    {
    }
	public partial class DR_IDX_DOC_CONTENT_RRepository : BaseRepository<DR_IDX_DOC_CONTENT_R>,IDR_IDX_DOC_CONTENT_RRepository
    {
    }
	public partial class EMERGENCY_MERCYRepository : BaseRepository<EMERGENCY_MERCY>,IEMERGENCY_MERCYRepository
    {
    }
	public partial class EMERGENCY_RECRepository : BaseRepository<EMERGENCY_REC>,IEMERGENCY_RECRepository
    {
    }
	public partial class EMERGENCY_REC_FILERepository : BaseRepository<EMERGENCY_REC_FILE>,IEMERGENCY_REC_FILERepository
    {
    }
	public partial class EMERGENCY_REC_PHOTORepository : BaseRepository<EMERGENCY_REC_PHOTO>,IEMERGENCY_REC_PHOTORepository
    {
    }
	public partial class EMERGENCY_RESCUERepository : BaseRepository<EMERGENCY_RESCUE>,IEMERGENCY_RESCUERepository
    {
    }
	public partial class EMERGENCY_RESCUE_TOOLRepository : BaseRepository<EMERGENCY_RESCUE_TOOL>,IEMERGENCY_RESCUE_TOOLRepository
    {
    }
	public partial class EMERGENCY_RULESRepository : BaseRepository<EMERGENCY_RULES>,IEMERGENCY_RULESRepository
    {
    }
	public partial class EMERGENCY_TALENT_POOLRepository : BaseRepository<EMERGENCY_TALENT_POOL>,IEMERGENCY_TALENT_POOLRepository
    {
    }
	public partial class EMERGENCY_VIECHLERepository : BaseRepository<EMERGENCY_VIECHLE>,IEMERGENCY_VIECHLERepository
    {
    }
	public partial class ENFORCEMENT_BDATARepository : BaseRepository<ENFORCEMENT_BDATA>,IENFORCEMENT_BDATARepository
    {
    }
	public partial class ENFORCEMENT_BDATA_ONLINERepository : BaseRepository<ENFORCEMENT_BDATA_ONLINE>,IENFORCEMENT_BDATA_ONLINERepository
    {
    }
	public partial class ENFORCEMENT_FILERepository : BaseRepository<ENFORCEMENT_FILE>,IENFORCEMENT_FILERepository
    {
    }
	public partial class FIVET_INFORepository : BaseRepository<FIVET_INFO>,IFIVET_INFORepository
    {
    }
	public partial class FIVET_INFO_FILERepository : BaseRepository<FIVET_INFO_FILE>,IFIVET_INFO_FILERepository
    {
    }
	public partial class FIVET_INFO_PHOTORepository : BaseRepository<FIVET_INFO_PHOTO>,IFIVET_INFO_PHOTORepository
    {
    }
	public partial class FIVET_INFO_TYPERepository : BaseRepository<FIVET_INFO_TYPE>,IFIVET_INFO_TYPERepository
    {
    }
	public partial class FIVET_INFO_VIDEORepository : BaseRepository<FIVET_INFO_VIDEO>,IFIVET_INFO_VIDEORepository
    {
    }
	public partial class FLOODPOINTRepository : BaseRepository<FLOODPOINT>,IFLOODPOINTRepository
    {
    }
	public partial class FLOW_BASERepository : BaseRepository<FLOW_BASE>,IFLOW_BASERepository
    {
    }
	public partial class FLOW_JOBRepository : BaseRepository<FLOW_JOB>,IFLOW_JOBRepository
    {
    }
	public partial class FLOW_STEPRepository : BaseRepository<FLOW_STEP>,IFLOW_STEPRepository
    {
    }
	public partial class GATE_BDATA_CARDRepository : BaseRepository<GATE_BDATA_CARD>,IGATE_BDATA_CARDRepository
    {
    }
	public partial class GATE_BDATA_CLIENTRepository : BaseRepository<GATE_BDATA_CLIENT>,IGATE_BDATA_CLIENTRepository
    {
    }
	public partial class GATE_BDATA_DICRepository : BaseRepository<GATE_BDATA_DIC>,IGATE_BDATA_DICRepository
    {
    }
	public partial class GATE_BDATA_GATERepository : BaseRepository<GATE_BDATA_GATE>,IGATE_BDATA_GATERepository
    {
    }
	public partial class GATE_BDATA_LIMITRepository : BaseRepository<GATE_BDATA_LIMIT>,IGATE_BDATA_LIMITRepository
    {
    }
	public partial class GATE_BDATA_SKYLIGHTRepository : BaseRepository<GATE_BDATA_SKYLIGHT>,IGATE_BDATA_SKYLIGHTRepository
    {
    }
	public partial class GATE_BDATA_TOOLRepository : BaseRepository<GATE_BDATA_TOOL>,IGATE_BDATA_TOOLRepository
    {
    }
	public partial class GATE_DEPT_MAPRepository : BaseRepository<GATE_DEPT_MAP>,IGATE_DEPT_MAPRepository
    {
    }
	public partial class GATE_GATEMNG_AUTHHISTORYRepository : BaseRepository<GATE_GATEMNG_AUTHHISTORY>,IGATE_GATEMNG_AUTHHISTORYRepository
    {
    }
	public partial class GATE_GATEMNG_AUTHORIZATIONRepository : BaseRepository<GATE_GATEMNG_AUTHORIZATION>,IGATE_GATEMNG_AUTHORIZATIONRepository
    {
    }
	public partial class GATE_GATEMNG_CARDLISTRepository : BaseRepository<GATE_GATEMNG_CARDLIST>,IGATE_GATEMNG_CARDLISTRepository
    {
    }
	public partial class GATE_GATEMNG_INGATERepository : BaseRepository<GATE_GATEMNG_INGATE>,IGATE_GATEMNG_INGATERepository
    {
    }
	public partial class GATE_GATEMNG_INOUTRepository : BaseRepository<GATE_GATEMNG_INOUT>,IGATE_GATEMNG_INOUTRepository
    {
    }
	public partial class GATE_GATEMNG_INOUTHISRepository : BaseRepository<GATE_GATEMNG_INOUTHIS>,IGATE_GATEMNG_INOUTHISRepository
    {
    }
	public partial class GATE_GATEMNG_LASTCARDLISTRepository : BaseRepository<GATE_GATEMNG_LASTCARDLIST>,IGATE_GATEMNG_LASTCARDLISTRepository
    {
    }
	public partial class GATE_GATEMNG_LASTSTATERepository : BaseRepository<GATE_GATEMNG_LASTSTATE>,IGATE_GATEMNG_LASTSTATERepository
    {
    }
	public partial class GATE_GATEMNG_LONGDISHISTORYRepository : BaseRepository<GATE_GATEMNG_LONGDISHISTORY>,IGATE_GATEMNG_LONGDISHISTORYRepository
    {
    }
	public partial class GATE_GATEMNG_STATERepository : BaseRepository<GATE_GATEMNG_STATE>,IGATE_GATEMNG_STATERepository
    {
    }
	public partial class GATE_GATEMNG_WARNINGRepository : BaseRepository<GATE_GATEMNG_WARNING>,IGATE_GATEMNG_WARNINGRepository
    {
    }
	public partial class GATE_JOB_PLANRepository : BaseRepository<GATE_JOB_PLAN>,IGATE_JOB_PLANRepository
    {
    }
	public partial class GATE_SEND_MSGRepository : BaseRepository<GATE_SEND_MSG>,IGATE_SEND_MSGRepository
    {
    }
	public partial class GATE_SEND_PHONENORepository : BaseRepository<GATE_SEND_PHONENO>,IGATE_SEND_PHONENORepository
    {
    }
	public partial class HEART_BROADCASTRepository : BaseRepository<HEART_BROADCAST>,IHEART_BROADCASTRepository
    {
    }
	public partial class HEART_BROADCAST_HISRepository : BaseRepository<HEART_BROADCAST_HIS>,IHEART_BROADCAST_HISRepository
    {
    }
	public partial class HEART_DG_DIS_PHONERepository : BaseRepository<HEART_DG_DIS_PHONE>,IHEART_DG_DIS_PHONERepository
    {
    }
	public partial class HEART_DG_VOLTAGE_SENDRepository : BaseRepository<HEART_DG_VOLTAGE_SEND>,IHEART_DG_VOLTAGE_SENDRepository
    {
    }
	public partial class HEART_DG_WAVERepository : BaseRepository<HEART_DG_WAVE>,IHEART_DG_WAVERepository
    {
    }
	public partial class HEART_DG_WAVE_HEADRepository : BaseRepository<HEART_DG_WAVE_HEAD>,IHEART_DG_WAVE_HEADRepository
    {
    }
	public partial class HEART_DG_WEBRepository : BaseRepository<HEART_DG_WEB>,IHEART_DG_WEBRepository
    {
    }
	public partial class HEART_MESSAGERepository : BaseRepository<HEART_MESSAGE>,IHEART_MESSAGERepository
    {
    }
	public partial class HEART_RECENT_SARepository : BaseRepository<HEART_RECENT_SA>,IHEART_RECENT_SARepository
    {
    }
	public partial class HIK_PIC_INFORepository : BaseRepository<HIK_PIC_INFO>,IHIK_PIC_INFORepository
    {
    }
	public partial class HRAIL_BALLASTRepository : BaseRepository<HRAIL_BALLAST>,IHRAIL_BALLASTRepository
    {
    }
	public partial class HRAIL_CROSSINGRepository : BaseRepository<HRAIL_CROSSING>,IHRAIL_CROSSINGRepository
    {
    }
	public partial class HRAIL_CURVERepository : BaseRepository<HRAIL_CURVE>,IHRAIL_CURVERepository
    {
    }
	public partial class HRAIL_DEPT_STATIONRepository : BaseRepository<HRAIL_DEPT_STATION>,IHRAIL_DEPT_STATIONRepository
    {
    }
	public partial class HRAIL_LINEUNITRepository : BaseRepository<HRAIL_LINEUNIT>,IHRAIL_LINEUNITRepository
    {
    }
	public partial class HRAIL_PARA_JOBITEMRepository : BaseRepository<HRAIL_PARA_JOBITEM>,IHRAIL_PARA_JOBITEMRepository
    {
    }
	public partial class HRAIL_PARA_PROITEMRepository : BaseRepository<HRAIL_PARA_PROITEM>,IHRAIL_PARA_PROITEMRepository
    {
    }
	public partial class HRAIL_PARA_PROITEM_SCORERepository : BaseRepository<HRAIL_PARA_PROITEM_SCORE>,IHRAIL_PARA_PROITEM_SCORERepository
    {
    }
	public partial class HRAIL_PLANRepository : BaseRepository<HRAIL_PLAN>,IHRAIL_PLANRepository
    {
    }
	public partial class HRAIL_PLAN_EMPRepository : BaseRepository<HRAIL_PLAN_EMP>,IHRAIL_PLAN_EMPRepository
    {
    }
	public partial class HRAIL_PLAN_FILERepository : BaseRepository<HRAIL_PLAN_FILE>,IHRAIL_PLAN_FILERepository
    {
    }
	public partial class HRAIL_PLAN_FLOWRepository : BaseRepository<HRAIL_PLAN_FLOW>,IHRAIL_PLAN_FLOWRepository
    {
    }
	public partial class HRAIL_PLAN_ITEMRepository : BaseRepository<HRAIL_PLAN_ITEM>,IHRAIL_PLAN_ITEMRepository
    {
    }
	public partial class HRAIL_PLAN_LOCRepository : BaseRepository<HRAIL_PLAN_LOC>,IHRAIL_PLAN_LOCRepository
    {
    }
	public partial class HRAIL_PLAN_MATERIALRepository : BaseRepository<HRAIL_PLAN_MATERIAL>,IHRAIL_PLAN_MATERIALRepository
    {
    }
	public partial class HRAIL_PLAN_PROBLEMRepository : BaseRepository<HRAIL_PLAN_PROBLEM>,IHRAIL_PLAN_PROBLEMRepository
    {
    }
	public partial class HRAIL_PLAN_TOOLRepository : BaseRepository<HRAIL_PLAN_TOOL>,IHRAIL_PLAN_TOOLRepository
    {
    }
	public partial class HRAIL_PLAN_YEARRepository : BaseRepository<HRAIL_PLAN_YEAR>,IHRAIL_PLAN_YEARRepository
    {
    }
	public partial class HRAIL_PROBLEMRepository : BaseRepository<HRAIL_PROBLEM>,IHRAIL_PROBLEMRepository
    {
    }
	public partial class HRAIL_PROBLEM_DNYRepository : BaseRepository<HRAIL_PROBLEM_DNY>,IHRAIL_PROBLEM_DNYRepository
    {
    }
	public partial class HRAIL_PROBLEM_FILERepository : BaseRepository<HRAIL_PROBLEM_FILE>,IHRAIL_PROBLEM_FILERepository
    {
    }
	public partial class HRAIL_RAILRepository : BaseRepository<HRAIL_RAIL>,IHRAIL_RAILRepository
    {
    }
	public partial class HRAIL_SLOPERepository : BaseRepository<HRAIL_SLOPE>,IHRAIL_SLOPERepository
    {
    }
	public partial class HRAIL_STARTMILERepository : BaseRepository<HRAIL_STARTMILE>,IHRAIL_STARTMILERepository
    {
    }
	public partial class HRAIL_STATIONRepository : BaseRepository<HRAIL_STATION>,IHRAIL_STATIONRepository
    {
    }
	public partial class HRAIL_TQIRepository : BaseRepository<HRAIL_TQI>,IHRAIL_TQIRepository
    {
    }
	public partial class HRAIL_TRACKRepository : BaseRepository<HRAIL_TRACK>,IHRAIL_TRACKRepository
    {
    }
	public partial class HRAIL_TURNOUTRepository : BaseRepository<HRAIL_TURNOUT>,IHRAIL_TURNOUTRepository
    {
    }
	public partial class HRAIL_UNIT_VALRepository : BaseRepository<HRAIL_UNIT_VAL>,IHRAIL_UNIT_VALRepository
    {
    }
	public partial class HRAIL_UNIT_VAL_DETAILRepository : BaseRepository<HRAIL_UNIT_VAL_DETAIL>,IHRAIL_UNIT_VAL_DETAILRepository
    {
    }
	public partial class JOB_JOB_PLANRepository : BaseRepository<JOB_JOB_PLAN>,IJOB_JOB_PLANRepository
    {
    }
	public partial class JOB_MSG_BATCHREPLYRepository : BaseRepository<JOB_MSG_BATCHREPLY>,IJOB_MSG_BATCHREPLYRepository
    {
    }
	public partial class JOB_MSG_BATCHSENDRepository : BaseRepository<JOB_MSG_BATCHSEND>,IJOB_MSG_BATCHSENDRepository
    {
    }
	public partial class JOB_MSG_BATCHSENDPHOTORepository : BaseRepository<JOB_MSG_BATCHSENDPHOTO>,IJOB_MSG_BATCHSENDPHOTORepository
    {
    }
	public partial class JOB_PLANRepository : BaseRepository<JOB_PLAN>,IJOB_PLANRepository
    {
    }
	public partial class JOB_PLAN_ADDPASSENGER_TESTRepository : BaseRepository<JOB_PLAN_ADDPASSENGER_TEST>,IJOB_PLAN_ADDPASSENGER_TESTRepository
    {
    }
	public partial class JOB_PLAN_APPROVALRepository : BaseRepository<JOB_PLAN_APPROVAL>,IJOB_PLAN_APPROVALRepository
    {
    }
	public partial class JOB_PLAN_BYTIMRepository : BaseRepository<JOB_PLAN_BYTIM>,IJOB_PLAN_BYTIMRepository
    {
    }
	public partial class JOB_PLAN_CONTROLRepository : BaseRepository<JOB_PLAN_CONTROL>,IJOB_PLAN_CONTROLRepository
    {
    }
	public partial class JOB_PLAN_DELINGHA_FILLRepository : BaseRepository<JOB_PLAN_DELINGHA_FILL>,IJOB_PLAN_DELINGHA_FILLRepository
    {
    }
	public partial class JOB_PLAN_DELINGHA_FILL_DETAILRepository : BaseRepository<JOB_PLAN_DELINGHA_FILL_DETAIL>,IJOB_PLAN_DELINGHA_FILL_DETAILRepository
    {
    }
	public partial class JOB_PLAN_DELINGHA_MONTHRepository : BaseRepository<JOB_PLAN_DELINGHA_MONTH>,IJOB_PLAN_DELINGHA_MONTHRepository
    {
    }
	public partial class JOB_PLAN_DELINGHA_WEEKRepository : BaseRepository<JOB_PLAN_DELINGHA_WEEK>,IJOB_PLAN_DELINGHA_WEEKRepository
    {
    }
	public partial class JOB_PLAN_EQUIPMENTRepository : BaseRepository<JOB_PLAN_EQUIPMENT>,IJOB_PLAN_EQUIPMENTRepository
    {
    }
	public partial class JOB_PLAN_LINERepository : BaseRepository<JOB_PLAN_LINE>,IJOB_PLAN_LINERepository
    {
    }
	public partial class JOB_PLAN_LINE_EQUIANDTIMRepository : BaseRepository<JOB_PLAN_LINE_EQUIANDTIM>,IJOB_PLAN_LINE_EQUIANDTIMRepository
    {
    }
	public partial class JOB_PLAN_LOOKOUTRepository : BaseRepository<JOB_PLAN_LOOKOUT>,IJOB_PLAN_LOOKOUTRepository
    {
    }
	public partial class JOB_PLAN_MEMBERPHONE_MAPRepository : BaseRepository<JOB_PLAN_MEMBERPHONE_MAP>,IJOB_PLAN_MEMBERPHONE_MAPRepository
    {
    }
	public partial class JOB_PLAN_OLDRepository : BaseRepository<JOB_PLAN_OLD>,IJOB_PLAN_OLDRepository
    {
    }
	public partial class JOB_PLAN_PHONE_USERRepository : BaseRepository<JOB_PLAN_PHONE_USER>,IJOB_PLAN_PHONE_USERRepository
    {
    }
	public partial class JOB_PLAN_SAFERepository : BaseRepository<JOB_PLAN_SAFE>,IJOB_PLAN_SAFERepository
    {
    }
	public partial class JOB_PLAN_TRAINRepository : BaseRepository<JOB_PLAN_TRAIN>,IJOB_PLAN_TRAINRepository
    {
    }
	public partial class JOB_PLAN_TYPERepository : BaseRepository<JOB_PLAN_TYPE>,IJOB_PLAN_TYPERepository
    {
    }
	public partial class JOB_PLAN_UPDOWNRepository : BaseRepository<JOB_PLAN_UPDOWN>,IJOB_PLAN_UPDOWNRepository
    {
    }
	public partial class JOB_PLAN_UPDOWNHISRepository : BaseRepository<JOB_PLAN_UPDOWNHIS>,IJOB_PLAN_UPDOWNHISRepository
    {
    }
	public partial class JOB_PLAN_WARNPHONESETRepository : BaseRepository<JOB_PLAN_WARNPHONESET>,IJOB_PLAN_WARNPHONESETRepository
    {
    }
	public partial class JOB_PLAN_WARNPOSSETRepository : BaseRepository<JOB_PLAN_WARNPOSSET>,IJOB_PLAN_WARNPOSSETRepository
    {
    }
	public partial class JOB_PLANCONTROL_COMMANDRepository : BaseRepository<JOB_PLANCONTROL_COMMAND>,IJOB_PLANCONTROL_COMMANDRepository
    {
    }
	public partial class JOB_WARNRepository : BaseRepository<JOB_WARN>,IJOB_WARNRepository
    {
    }
	public partial class LEDGER_BIGEQUI_TECHPARAMRepository : BaseRepository<LEDGER_BIGEQUI_TECHPARAM>,ILEDGER_BIGEQUI_TECHPARAMRepository
    {
    }
	public partial class LEDGER_DICT_INTERPHONERepository : BaseRepository<LEDGER_DICT_INTERPHONE>,ILEDGER_DICT_INTERPHONERepository
    {
    }
	public partial class LEDGER_DICT_LARGEMACHINERYRepository : BaseRepository<LEDGER_DICT_LARGEMACHINERY>,ILEDGER_DICT_LARGEMACHINERYRepository
    {
    }
	public partial class LEDGER_DICT_MACHINETOOLRepository : BaseRepository<LEDGER_DICT_MACHINETOOL>,ILEDGER_DICT_MACHINETOOLRepository
    {
    }
	public partial class LEDGER_DICT_MECHANICALVEHICLERepository : BaseRepository<LEDGER_DICT_MECHANICALVEHICLE>,ILEDGER_DICT_MECHANICALVEHICLERepository
    {
    }
	public partial class LEDGER_DICT_ROADVEHICLERepository : BaseRepository<LEDGER_DICT_ROADVEHICLE>,ILEDGER_DICT_ROADVEHICLERepository
    {
    }
	public partial class LEDGER_DICT_TRAFFICVEHICLERepository : BaseRepository<LEDGER_DICT_TRAFFICVEHICLE>,ILEDGER_DICT_TRAFFICVEHICLERepository
    {
    }
	public partial class LEDGER_INTERPHONERepository : BaseRepository<LEDGER_INTERPHONE>,ILEDGER_INTERPHONERepository
    {
    }
	public partial class LEDGER_LARGE_MACHINERYRepository : BaseRepository<LEDGER_LARGE_MACHINERY>,ILEDGER_LARGE_MACHINERYRepository
    {
    }
	public partial class LEDGER_LEVELCROSS_INFORepository : BaseRepository<LEDGER_LEVELCROSS_INFO>,ILEDGER_LEVELCROSS_INFORepository
    {
    }
	public partial class LEDGER_LEVELCROSS_PIPE_LINERepository : BaseRepository<LEDGER_LEVELCROSS_PIPE_LINE>,ILEDGER_LEVELCROSS_PIPE_LINERepository
    {
    }
	public partial class LEDGER_LEVELCROSS_REPAIR_LINERepository : BaseRepository<LEDGER_LEVELCROSS_REPAIR_LINE>,ILEDGER_LEVELCROSS_REPAIR_LINERepository
    {
    }
	public partial class LEDGER_MACHINE_TOOLRepository : BaseRepository<LEDGER_MACHINE_TOOL>,ILEDGER_MACHINE_TOOLRepository
    {
    }
	public partial class LEDGER_MECHANICAL_VEHICLERepository : BaseRepository<LEDGER_MECHANICAL_VEHICLE>,ILEDGER_MECHANICAL_VEHICLERepository
    {
    }
	public partial class LEDGER_RAIL_MATERIALRepository : BaseRepository<LEDGER_RAIL_MATERIAL>,ILEDGER_RAIL_MATERIALRepository
    {
    }
	public partial class LEDGER_RAILCAR_TECHPARAMRepository : BaseRepository<LEDGER_RAILCAR_TECHPARAM>,ILEDGER_RAILCAR_TECHPARAMRepository
    {
    }
	public partial class LEDGER_ROAD_VEHICLERepository : BaseRepository<LEDGER_ROAD_VEHICLE>,ILEDGER_ROAD_VEHICLERepository
    {
    }
	public partial class LEDGER_SMALLEQUI_TECHPARAMRepository : BaseRepository<LEDGER_SMALLEQUI_TECHPARAM>,ILEDGER_SMALLEQUI_TECHPARAMRepository
    {
    }
	public partial class LEDGER_TRAFFIC_VEHICLESRepository : BaseRepository<LEDGER_TRAFFIC_VEHICLES>,ILEDGER_TRAFFIC_VEHICLESRepository
    {
    }
	public partial class LKJ_ALLOW_SPEEDRepository : BaseRepository<LKJ_ALLOW_SPEED>,ILKJ_ALLOW_SPEEDRepository
    {
    }
	public partial class LKJ_BRIDGERepository : BaseRepository<LKJ_BRIDGE>,ILKJ_BRIDGERepository
    {
    }
	public partial class LKJ_BROKEN_CHAINRepository : BaseRepository<LKJ_BROKEN_CHAIN>,ILKJ_BROKEN_CHAINRepository
    {
    }
	public partial class LKJ_CROSSINGRepository : BaseRepository<LKJ_CROSSING>,ILKJ_CROSSINGRepository
    {
    }
	public partial class LKJ_CURVERepository : BaseRepository<LKJ_CURVE>,ILKJ_CURVERepository
    {
    }
	public partial class LKJ_LINE_NAMERepository : BaseRepository<LKJ_LINE_NAME>,ILKJ_LINE_NAMERepository
    {
    }
	public partial class LKJ_MAIN_TRACK_MILEAGERepository : BaseRepository<LKJ_MAIN_TRACK_MILEAGE>,ILKJ_MAIN_TRACK_MILEAGERepository
    {
    }
	public partial class LKJ_ROAD_FORKRepository : BaseRepository<LKJ_ROAD_FORK>,ILKJ_ROAD_FORKRepository
    {
    }
	public partial class LKJ_SLOPERepository : BaseRepository<LKJ_SLOPE>,ILKJ_SLOPERepository
    {
    }
	public partial class LKJ_STATIONRepository : BaseRepository<LKJ_STATION>,ILKJ_STATIONRepository
    {
    }
	public partial class LKJ_TRACKRepository : BaseRepository<LKJ_TRACK>,ILKJ_TRACKRepository
    {
    }
	public partial class LKJ_TUNNELRepository : BaseRepository<LKJ_TUNNEL>,ILKJ_TUNNELRepository
    {
    }
	public partial class MATERIAL_BDATE_DICRepository : BaseRepository<MATERIAL_BDATE_DIC>,IMATERIAL_BDATE_DICRepository
    {
    }
	public partial class MATERIAL_BDATE_MATERIALNAMERepository : BaseRepository<MATERIAL_BDATE_MATERIALNAME>,IMATERIAL_BDATE_MATERIALNAMERepository
    {
    }
	public partial class MATERIAL_INOUT_BILLRepository : BaseRepository<MATERIAL_INOUT_BILL>,IMATERIAL_INOUT_BILLRepository
    {
    }
	public partial class MATERIAL_INOUT_BILL_DETAILRepository : BaseRepository<MATERIAL_INOUT_BILL_DETAIL>,IMATERIAL_INOUT_BILL_DETAILRepository
    {
    }
	public partial class MATERIAL_MATERIALMNGRepository : BaseRepository<MATERIAL_MATERIALMNG>,IMATERIAL_MATERIALMNGRepository
    {
    }
	public partial class MATERIAL_MONSURPRUSRepository : BaseRepository<MATERIAL_MONSURPRUS>,IMATERIAL_MONSURPRUSRepository
    {
    }
	public partial class OIL_BDATA_CURVERepository : BaseRepository<OIL_BDATA_CURVE>,IOIL_BDATA_CURVERepository
    {
    }
	public partial class OIL_BDATA_DEVICERepository : BaseRepository<OIL_BDATA_DEVICE>,IOIL_BDATA_DEVICERepository
    {
    }
	public partial class OIL_BDATA_OPRepository : BaseRepository<OIL_BDATA_OP>,IOIL_BDATA_OPRepository
    {
    }
	public partial class OIL_RECORD_CHECKRepository : BaseRepository<OIL_RECORD_CHECK>,IOIL_RECORD_CHECKRepository
    {
    }
	public partial class OIL_RECORD_OILRepository : BaseRepository<OIL_RECORD_OIL>,IOIL_RECORD_OILRepository
    {
    }
	public partial class PHONEDICRepository : BaseRepository<PHONEDIC>,IPHONEDICRepository
    {
    }
	public partial class PROTECTEDNET_BDATA_DEVICERepository : BaseRepository<PROTECTEDNET_BDATA_DEVICE>,IPROTECTEDNET_BDATA_DEVICERepository
    {
    }
	public partial class PROTECTEDNET_RECORD_CHECKRepository : BaseRepository<PROTECTEDNET_RECORD_CHECK>,IPROTECTEDNET_RECORD_CHECKRepository
    {
    }
	public partial class PROTECTEDNET_RECORD_WARNRepository : BaseRepository<PROTECTEDNET_RECORD_WARN>,IPROTECTEDNET_RECORD_WARNRepository
    {
    }
	public partial class PROTECTEDNET_VIDEO_FILERepository : BaseRepository<PROTECTEDNET_VIDEO_FILE>,IPROTECTEDNET_VIDEO_FILERepository
    {
    }
	public partial class RAIL_BDATA_HOSTRepository : BaseRepository<RAIL_BDATA_HOST>,IRAIL_BDATA_HOSTRepository
    {
    }
	public partial class RAIL_BDATA_POINTRepository : BaseRepository<RAIL_BDATA_POINT>,IRAIL_BDATA_POINTRepository
    {
    }
	public partial class RAIL_BDATA_SENDPHONENORepository : BaseRepository<RAIL_BDATA_SENDPHONENO>,IRAIL_BDATA_SENDPHONENORepository
    {
    }
	public partial class RAIL_CARRIERBDATA_POINTRepository : BaseRepository<RAIL_CARRIERBDATA_POINT>,IRAIL_CARRIERBDATA_POINTRepository
    {
    }
	public partial class RAIL_CARRIERBDATA_SECTIONRepository : BaseRepository<RAIL_CARRIERBDATA_SECTION>,IRAIL_CARRIERBDATA_SECTIONRepository
    {
    }
	public partial class RAIL_CARRIERDEVICE_STATUSRepository : BaseRepository<RAIL_CARRIERDEVICE_STATUS>,IRAIL_CARRIERDEVICE_STATUSRepository
    {
    }
	public partial class RAIL_CARRIERDEVICE_WARNRepository : BaseRepository<RAIL_CARRIERDEVICE_WARN>,IRAIL_CARRIERDEVICE_WARNRepository
    {
    }
	public partial class RAIL_CARRIERRECORD_POINTRepository : BaseRepository<RAIL_CARRIERRECORD_POINT>,IRAIL_CARRIERRECORD_POINTRepository
    {
    }
	public partial class RAIL_CARRIERRECORD_WARNRepository : BaseRepository<RAIL_CARRIERRECORD_WARN>,IRAIL_CARRIERRECORD_WARNRepository
    {
    }
	public partial class RAIL_CARRIERRECORD_WARN_FINALRepository : BaseRepository<RAIL_CARRIERRECORD_WARN_FINAL>,IRAIL_CARRIERRECORD_WARN_FINALRepository
    {
    }
	public partial class RAIL_CARRIERSECTION_LASTWARNRepository : BaseRepository<RAIL_CARRIERSECTION_LASTWARN>,IRAIL_CARRIERSECTION_LASTWARNRepository
    {
    }
	public partial class RAIL_CARRIERSECTION_WARNRepository : BaseRepository<RAIL_CARRIERSECTION_WARN>,IRAIL_CARRIERSECTION_WARNRepository
    {
    }
	public partial class RAIL_CARRIERWAVE_LOGRepository : BaseRepository<RAIL_CARRIERWAVE_LOG>,IRAIL_CARRIERWAVE_LOGRepository
    {
    }
	public partial class RAIL_CARRIERWAVE_POINTRepository : BaseRepository<RAIL_CARRIERWAVE_POINT>,IRAIL_CARRIERWAVE_POINTRepository
    {
    }
	public partial class RAIL_COMMRepository : BaseRepository<RAIL_COMM>,IRAIL_COMMRepository
    {
    }
	public partial class RAIL_DEVICE_RECORDRepository : BaseRepository<RAIL_DEVICE_RECORD>,IRAIL_DEVICE_RECORDRepository
    {
    }
	public partial class RAIL_RECORD_HOSTRepository : BaseRepository<RAIL_RECORD_HOST>,IRAIL_RECORD_HOSTRepository
    {
    }
	public partial class RAIL_RECORD_POINTRepository : BaseRepository<RAIL_RECORD_POINT>,IRAIL_RECORD_POINTRepository
    {
    }
	public partial class RAIL_RECORD_SAMPWARNRepository : BaseRepository<RAIL_RECORD_SAMPWARN>,IRAIL_RECORD_SAMPWARNRepository
    {
    }
	public partial class RAIL_RECORD_WARNRepository : BaseRepository<RAIL_RECORD_WARN>,IRAIL_RECORD_WARNRepository
    {
    }
	public partial class RAIL_SECTION_LINERepository : BaseRepository<RAIL_SECTION_LINE>,IRAIL_SECTION_LINERepository
    {
    }
	public partial class RAIL_SOUNDBDATA_POINTRepository : BaseRepository<RAIL_SOUNDBDATA_POINT>,IRAIL_SOUNDBDATA_POINTRepository
    {
    }
	public partial class RAIL_SOUNDBDATA_SECTIONRepository : BaseRepository<RAIL_SOUNDBDATA_SECTION>,IRAIL_SOUNDBDATA_SECTIONRepository
    {
    }
	public partial class RAIL_SOUNDDEVICE_LASTWARNRepository : BaseRepository<RAIL_SOUNDDEVICE_LASTWARN>,IRAIL_SOUNDDEVICE_LASTWARNRepository
    {
    }
	public partial class RAIL_SOUNDDEVICE_WARNRepository : BaseRepository<RAIL_SOUNDDEVICE_WARN>,IRAIL_SOUNDDEVICE_WARNRepository
    {
    }
	public partial class RAIL_SOUNDRECEIVE_ORIDATARepository : BaseRepository<RAIL_SOUNDRECEIVE_ORIDATA>,IRAIL_SOUNDRECEIVE_ORIDATARepository
    {
    }
	public partial class RAIL_SOUNDRECORD_LASTWARNRepository : BaseRepository<RAIL_SOUNDRECORD_LASTWARN>,IRAIL_SOUNDRECORD_LASTWARNRepository
    {
    }
	public partial class RAIL_SOUNDRECORD_POINTRepository : BaseRepository<RAIL_SOUNDRECORD_POINT>,IRAIL_SOUNDRECORD_POINTRepository
    {
    }
	public partial class RAIL_SOUNDRECORD_WARNRepository : BaseRepository<RAIL_SOUNDRECORD_WARN>,IRAIL_SOUNDRECORD_WARNRepository
    {
    }
	public partial class RAIL_SOUNDRECORD_WARN_FINALRepository : BaseRepository<RAIL_SOUNDRECORD_WARN_FINAL>,IRAIL_SOUNDRECORD_WARN_FINALRepository
    {
    }
	public partial class RAIL_SOUNDSECTION_LASTWARNRepository : BaseRepository<RAIL_SOUNDSECTION_LASTWARN>,IRAIL_SOUNDSECTION_LASTWARNRepository
    {
    }
	public partial class RAIL_SOUNDSECTION_WARNRepository : BaseRepository<RAIL_SOUNDSECTION_WARN>,IRAIL_SOUNDSECTION_WARNRepository
    {
    }
	public partial class RAIL_SOUNDWAVE_LOGRepository : BaseRepository<RAIL_SOUNDWAVE_LOG>,IRAIL_SOUNDWAVE_LOGRepository
    {
    }
	public partial class RAILCAR_BDATARepository : BaseRepository<RAILCAR_BDATA>,IRAILCAR_BDATARepository
    {
    }
	public partial class RAILCAR_BDATA_ONLINERepository : BaseRepository<RAILCAR_BDATA_ONLINE>,IRAILCAR_BDATA_ONLINERepository
    {
    }
	public partial class RAILCAR_FILERepository : BaseRepository<RAILCAR_FILE>,IRAILCAR_FILERepository
    {
    }
	public partial class RAIN_DEVICERepository : BaseRepository<RAIN_DEVICE>,IRAIN_DEVICERepository
    {
    }
	public partial class RAIN_DEVICE_PLANLOGRepository : BaseRepository<RAIN_DEVICE_PLANLOG>,IRAIN_DEVICE_PLANLOGRepository
    {
    }
	public partial class RAIN_FLOOD_LABOURRepository : BaseRepository<RAIN_FLOOD_LABOUR>,IRAIN_FLOOD_LABOURRepository
    {
    }
	public partial class RAIN_FLOOD_RESERVE_PLANRepository : BaseRepository<RAIN_FLOOD_RESERVE_PLAN>,IRAIN_FLOOD_RESERVE_PLANRepository
    {
    }
	public partial class RAIN_FLOOD_STOCKRepository : BaseRepository<RAIN_FLOOD_STOCK>,IRAIN_FLOOD_STOCKRepository
    {
    }
	public partial class RAIN_FLOOD_STOCK_PHOTORepository : BaseRepository<RAIN_FLOOD_STOCK_PHOTO>,IRAIN_FLOOD_STOCK_PHOTORepository
    {
    }
	public partial class RAIN_PLANRepository : BaseRepository<RAIN_PLAN>,IRAIN_PLANRepository
    {
    }
	public partial class RAIN_PLAN_WARNRepository : BaseRepository<RAIN_PLAN_WARN>,IRAIN_PLAN_WARNRepository
    {
    }
	public partial class RAIN_SECTION_LINERepository : BaseRepository<RAIN_SECTION_LINE>,IRAIN_SECTION_LINERepository
    {
    }
	public partial class REPAIR_ACCOUNTRepository : BaseRepository<REPAIR_ACCOUNT>,IREPAIR_ACCOUNTRepository
    {
    }
	public partial class REPAIR_OVERRUNRepository : BaseRepository<REPAIR_OVERRUN>,IREPAIR_OVERRUNRepository
    {
    }
	public partial class RESCUE_LINERepository : BaseRepository<RESCUE_LINE>,IRESCUE_LINERepository
    {
    }
	public partial class RESCUE_LINE_INFORepository : BaseRepository<RESCUE_LINE_INFO>,IRESCUE_LINE_INFORepository
    {
    }
	public partial class RESCUE_LINE_PHOTORepository : BaseRepository<RESCUE_LINE_PHOTO>,IRESCUE_LINE_PHOTORepository
    {
    }
	public partial class RESCUE_LINE_PORTRepository : BaseRepository<RESCUE_LINE_PORT>,IRESCUE_LINE_PORTRepository
    {
    }
	public partial class ROADBED_ITEM_PARARepository : BaseRepository<ROADBED_ITEM_PARA>,IROADBED_ITEM_PARARepository
    {
    }
	public partial class ROADBED_KEYDISEASE_EVALUATERepository : BaseRepository<ROADBED_KEYDISEASE_EVALUATE>,IROADBED_KEYDISEASE_EVALUATERepository
    {
    }
	public partial class ROADBED_KEYDISEASE_PRORepository : BaseRepository<ROADBED_KEYDISEASE_PRO>,IROADBED_KEYDISEASE_PRORepository
    {
    }
	public partial class ROADBED_KEYDISEASE_PRO_HISRepository : BaseRepository<ROADBED_KEYDISEASE_PRO_HIS>,IROADBED_KEYDISEASE_PRO_HISRepository
    {
    }
	public partial class ROADBED_KEYDISEASE_REPORTRepository : BaseRepository<ROADBED_KEYDISEASE_REPORT>,IROADBED_KEYDISEASE_REPORTRepository
    {
    }
	public partial class RULE_BASE_DEPTRepository : BaseRepository<RULE_BASE_DEPT>,IRULE_BASE_DEPTRepository
    {
    }
	public partial class RULE_BDATE_DICRepository : BaseRepository<RULE_BDATE_DIC>,IRULE_BDATE_DICRepository
    {
    }
	public partial class RULE_DOCRepository : BaseRepository<RULE_DOC>,IRULE_DOCRepository
    {
    }
	public partial class RULE_DOC_ITEMRepository : BaseRepository<RULE_DOC_ITEM>,IRULE_DOC_ITEMRepository
    {
    }
	public partial class RULE_DOC_KEYWORDRepository : BaseRepository<RULE_DOC_KEYWORD>,IRULE_DOC_KEYWORDRepository
    {
    }
	public partial class RULE_KEYWORDRepository : BaseRepository<RULE_KEYWORD>,IRULE_KEYWORDRepository
    {
    }
	public partial class RULE_PARA_SCORERepository : BaseRepository<RULE_PARA_SCORE>,IRULE_PARA_SCORERepository
    {
    }
	public partial class RULE_PARSE_MARKUPRepository : BaseRepository<RULE_PARSE_MARKUP>,IRULE_PARSE_MARKUPRepository
    {
    }
	public partial class RULE_PARSE_MARKUP_MATCHRepository : BaseRepository<RULE_PARSE_MARKUP_MATCH>,IRULE_PARSE_MARKUP_MATCHRepository
    {
    }
	public partial class RULE_PARSE_RESULTRepository : BaseRepository<RULE_PARSE_RESULT>,IRULE_PARSE_RESULTRepository
    {
    }
	public partial class RULE_PARSE_RESULT_REPORTRepository : BaseRepository<RULE_PARSE_RESULT_REPORT>,IRULE_PARSE_RESULT_REPORTRepository
    {
    }
	public partial class RULE_PROBLEMRepository : BaseRepository<RULE_PROBLEM>,IRULE_PROBLEMRepository
    {
    }
	public partial class RULE_PROBLEM_BLAMERepository : BaseRepository<RULE_PROBLEM_BLAME>,IRULE_PROBLEM_BLAMERepository
    {
    }
	public partial class RULE_PROBLEM_KEYWORDRepository : BaseRepository<RULE_PROBLEM_KEYWORD>,IRULE_PROBLEM_KEYWORDRepository
    {
    }
	public partial class RULE_PROBLEM_POSTRepository : BaseRepository<RULE_PROBLEM_POST>,IRULE_PROBLEM_POSTRepository
    {
    }
	public partial class RULE_PROBLEM_PUBLISH_CONFIGERRepository : BaseRepository<RULE_PROBLEM_PUBLISH_CONFIGER>,IRULE_PROBLEM_PUBLISH_CONFIGERRepository
    {
    }
	public partial class RULE_PROBLEM_PUNISHRepository : BaseRepository<RULE_PROBLEM_PUNISH>,IRULE_PROBLEM_PUNISHRepository
    {
    }
	public partial class RULE_RESULT_CENSUSRepository : BaseRepository<RULE_RESULT_CENSUS>,IRULE_RESULT_CENSUSRepository
    {
    }
	public partial class RULE_RESULT_PROTREND_TMPRepository : BaseRepository<RULE_RESULT_PROTREND_TMP>,IRULE_RESULT_PROTREND_TMPRepository
    {
    }
	public partial class SCRIPT_SECTION_BRIDGETUNNELRepository : BaseRepository<SCRIPT_SECTION_BRIDGETUNNEL>,ISCRIPT_SECTION_BRIDGETUNNELRepository
    {
    }
	public partial class SCRIPTS_LEADER_MONITORERepository : BaseRepository<SCRIPTS_LEADER_MONITORE>,ISCRIPTS_LEADER_MONITORERepository
    {
    }
	public partial class SCRIPTS_MEMBER_ONLINERepository : BaseRepository<SCRIPTS_MEMBER_ONLINE>,ISCRIPTS_MEMBER_ONLINERepository
    {
    }
	public partial class SCRIPTS_SECTION_BADSIGNALRepository : BaseRepository<SCRIPTS_SECTION_BADSIGNAL>,ISCRIPTS_SECTION_BADSIGNALRepository
    {
    }
	public partial class SCRIPTS_SECTION_FLOOD_PHOTORepository : BaseRepository<SCRIPTS_SECTION_FLOOD_PHOTO>,ISCRIPTS_SECTION_FLOOD_PHOTORepository
    {
    }
	public partial class SCRIPTS_SECTION_FLOOD_PIC_TESTRepository : BaseRepository<SCRIPTS_SECTION_FLOOD_PIC_TEST>,ISCRIPTS_SECTION_FLOOD_PIC_TESTRepository
    {
    }
	public partial class SCRIPTS_SECTION_LINERepository : BaseRepository<SCRIPTS_SECTION_LINE>,ISCRIPTS_SECTION_LINERepository
    {
    }
	public partial class SCRIPTS_SECTION_OTHER_PHOTORepository : BaseRepository<SCRIPTS_SECTION_OTHER_PHOTO>,ISCRIPTS_SECTION_OTHER_PHOTORepository
    {
    }
	public partial class SCRIPTS_SECTION_ROAD_LINERepository : BaseRepository<SCRIPTS_SECTION_ROAD_LINE>,ISCRIPTS_SECTION_ROAD_LINERepository
    {
    }
	public partial class SCRIPTS_SECTION_ROADMOTORRepository : BaseRepository<SCRIPTS_SECTION_ROADMOTOR>,ISCRIPTS_SECTION_ROADMOTORRepository
    {
    }
	public partial class SCRIPTS_SECTION_TRACKRepository : BaseRepository<SCRIPTS_SECTION_TRACK>,ISCRIPTS_SECTION_TRACKRepository
    {
    }
	public partial class SCRIPTS_SECTION_TRACK_INFORepository : BaseRepository<SCRIPTS_SECTION_TRACK_INFO>,ISCRIPTS_SECTION_TRACK_INFORepository
    {
    }
	public partial class SCRIPTS_SECTION_TYPECROSSRepository : BaseRepository<SCRIPTS_SECTION_TYPECROSS>,ISCRIPTS_SECTION_TYPECROSSRepository
    {
    }
	public partial class SCRIPTS_SECTION_TYPEFLOODRepository : BaseRepository<SCRIPTS_SECTION_TYPEFLOOD>,ISCRIPTS_SECTION_TYPEFLOODRepository
    {
    }
	public partial class SCRIPTS_SECTION_TYPEOTHERRepository : BaseRepository<SCRIPTS_SECTION_TYPEOTHER>,ISCRIPTS_SECTION_TYPEOTHERRepository
    {
    }
	public partial class SCRIPTS_SECTION_TYPEOTHERINFORepository : BaseRepository<SCRIPTS_SECTION_TYPEOTHERINFO>,ISCRIPTS_SECTION_TYPEOTHERINFORepository
    {
    }
	public partial class SCRIPTS_SPECIAL_FLAGRepository : BaseRepository<SCRIPTS_SPECIAL_FLAG>,ISCRIPTS_SPECIAL_FLAGRepository
    {
    }
	public partial class SCRIPTS_STATION_CHECKRepository : BaseRepository<SCRIPTS_STATION_CHECK>,ISCRIPTS_STATION_CHECKRepository
    {
    }
	public partial class SNOW_BDATA_DEVICERepository : BaseRepository<SNOW_BDATA_DEVICE>,ISNOW_BDATA_DEVICERepository
    {
    }
	public partial class SNOW_BDATA_WARNSTANDARDRepository : BaseRepository<SNOW_BDATA_WARNSTANDARD>,ISNOW_BDATA_WARNSTANDARDRepository
    {
    }
	public partial class SNOW_RECORD_HISRepository : BaseRepository<SNOW_RECORD_HIS>,ISNOW_RECORD_HISRepository
    {
    }
	public partial class SNOW_SECTION_LINERepository : BaseRepository<SNOW_SECTION_LINE>,ISNOW_SECTION_LINERepository
    {
    }
	public partial class SNOW_VIDEO_FILERepository : BaseRepository<SNOW_VIDEO_FILE>,ISNOW_VIDEO_FILERepository
    {
    }
	public partial class SYS_DEPTRepository : BaseRepository<SYS_DEPT>,ISYS_DEPTRepository
    {
    }
	public partial class SYS_INTELLIGENCE_DICRepository : BaseRepository<SYS_INTELLIGENCE_DIC>,ISYS_INTELLIGENCE_DICRepository
    {
    }
	public partial class SYS_MEMBERRepository : BaseRepository<SYS_MEMBER>,ISYS_MEMBERRepository
    {
    }
	public partial class SYS_MENURepository : BaseRepository<SYS_MENU>,ISYS_MENURepository
    {
    }
	public partial class SYS_MENU_HELPCONTENTRepository : BaseRepository<SYS_MENU_HELPCONTENT>,ISYS_MENU_HELPCONTENTRepository
    {
    }
	public partial class SYS_MENUOPTRepository : BaseRepository<SYS_MENUOPT>,ISYS_MENUOPTRepository
    {
    }
	public partial class SYS_POSLEVEL_DICRepository : BaseRepository<SYS_POSLEVEL_DIC>,ISYS_POSLEVEL_DICRepository
    {
    }
	public partial class SYS_ROLERepository : BaseRepository<SYS_ROLE>,ISYS_ROLERepository
    {
    }
	public partial class SYS_ROLE_MENU_MAPRepository : BaseRepository<SYS_ROLE_MENU_MAP>,ISYS_ROLE_MENU_MAPRepository
    {
    }
	public partial class SYS_ROLE_MENUOPT_MAPRepository : BaseRepository<SYS_ROLE_MENUOPT_MAP>,ISYS_ROLE_MENUOPT_MAPRepository
    {
    }
	public partial class SYS_STATIONMEMBER_NORepository : BaseRepository<SYS_STATIONMEMBER_NO>,ISYS_STATIONMEMBER_NORepository
    {
    }
	public partial class SYS_USERRepository : BaseRepository<SYS_USER>,ISYS_USERRepository
    {
    }
	public partial class SYS_USER_DEFAULTMENURepository : BaseRepository<SYS_USER_DEFAULTMENU>,ISYS_USER_DEFAULTMENURepository
    {
    }
	public partial class SYS_USER_PHONE_DICRepository : BaseRepository<SYS_USER_PHONE_DIC>,ISYS_USER_PHONE_DICRepository
    {
    }
	public partial class SYS_USER_ROLE_MAPRepository : BaseRepository<SYS_USER_ROLE_MAP>,ISYS_USER_ROLE_MAPRepository
    {
    }
	public partial class SYS_USERLOGINRepository : BaseRepository<SYS_USERLOGIN>,ISYS_USERLOGINRepository
    {
    }
	public partial class T_ASS_BOUNDRepository : BaseRepository<T_ASS_BOUND>,IT_ASS_BOUNDRepository
    {
    }
	public partial class T_ASS_BRIDGERepository : BaseRepository<T_ASS_BRIDGE>,IT_ASS_BRIDGERepository
    {
    }
	public partial class T_ASS_BROKENCHAINRepository : BaseRepository<T_ASS_BROKENCHAIN>,IT_ASS_BROKENCHAINRepository
    {
    }
	public partial class T_ASS_COMBINEDRAWRepository : BaseRepository<T_ASS_COMBINEDRAW>,IT_ASS_COMBINEDRAWRepository
    {
    }
	public partial class T_ASS_COMPMAINT_PLANRepository : BaseRepository<T_ASS_COMPMAINT_PLAN>,IT_ASS_COMPMAINT_PLANRepository
    {
    }
	public partial class T_ASS_COMPMAINT_PLAN_DETAILRepository : BaseRepository<T_ASS_COMPMAINT_PLAN_DETAIL>,IT_ASS_COMPMAINT_PLAN_DETAILRepository
    {
    }
	public partial class T_ASS_CURVERepository : BaseRepository<T_ASS_CURVE>,IT_ASS_CURVERepository
    {
    }
	public partial class T_ASS_EMPRepository : BaseRepository<T_ASS_EMP>,IT_ASS_EMPRepository
    {
    }
	public partial class T_ASS_EQU_DATA_TEMPRepository : BaseRepository<T_ASS_EQU_DATA_TEMP>,IT_ASS_EQU_DATA_TEMPRepository
    {
    }
	public partial class T_ASS_FLOWRepository : BaseRepository<T_ASS_FLOW>,IT_ASS_FLOWRepository
    {
    }
	public partial class T_ASS_FLOW_INSTANCERepository : BaseRepository<T_ASS_FLOW_INSTANCE>,IT_ASS_FLOW_INSTANCERepository
    {
    }
	public partial class T_ASS_FLOW_PROCESSRepository : BaseRepository<T_ASS_FLOW_PROCESS>,IT_ASS_FLOW_PROCESSRepository
    {
    }
	public partial class T_ASS_FLOW_ROLERepository : BaseRepository<T_ASS_FLOW_ROLE>,IT_ASS_FLOW_ROLERepository
    {
    }
	public partial class T_ASS_FLOW_STEPRepository : BaseRepository<T_ASS_FLOW_STEP>,IT_ASS_FLOW_STEPRepository
    {
    }
	public partial class T_ASS_FLOW_USER_ROLERepository : BaseRepository<T_ASS_FLOW_USER_ROLE>,IT_ASS_FLOW_USER_ROLERepository
    {
    }
	public partial class T_ASS_GJC_AVESCORERepository : BaseRepository<T_ASS_GJC_AVESCORE>,IT_ASS_GJC_AVESCORERepository
    {
    }
	public partial class T_ASS_LINEDRAWRepository : BaseRepository<T_ASS_LINEDRAW>,IT_ASS_LINEDRAWRepository
    {
    }
	public partial class T_ASS_MATERIALRepository : BaseRepository<T_ASS_MATERIAL>,IT_ASS_MATERIALRepository
    {
    }
	public partial class T_ASS_PARA_DYN_SCORERepository : BaseRepository<T_ASS_PARA_DYN_SCORE>,IT_ASS_PARA_DYN_SCORERepository
    {
    }
	public partial class T_ASS_PARA_LEVEL_SCORERepository : BaseRepository<T_ASS_PARA_LEVEL_SCORE>,IT_ASS_PARA_LEVEL_SCORERepository
    {
    }
	public partial class T_ASS_PARA_PLACERepository : BaseRepository<T_ASS_PARA_PLACE>,IT_ASS_PARA_PLACERepository
    {
    }
	public partial class T_ASS_PARA_PRO_CTRLRepository : BaseRepository<T_ASS_PARA_PRO_CTRL>,IT_ASS_PARA_PRO_CTRLRepository
    {
    }
	public partial class T_ASS_PARA_PRO_TYPERepository : BaseRepository<T_ASS_PARA_PRO_TYPE>,IT_ASS_PARA_PRO_TYPERepository
    {
    }
	public partial class T_ASS_PARA_SCORERepository : BaseRepository<T_ASS_PARA_SCORE>,IT_ASS_PARA_SCORERepository
    {
    }
	public partial class T_ASS_PARAREPORT_TEMPRepository : BaseRepository<T_ASS_PARAREPORT_TEMP>,IT_ASS_PARAREPORT_TEMPRepository
    {
    }
	public partial class T_ASS_PLAN_CONSTRUCTIONRepository : BaseRepository<T_ASS_PLAN_CONSTRUCTION>,IT_ASS_PLAN_CONSTRUCTIONRepository
    {
    }
	public partial class T_ASS_PLAN_DAILYRepository : BaseRepository<T_ASS_PLAN_DAILY>,IT_ASS_PLAN_DAILYRepository
    {
    }
	public partial class T_ASS_PLAN_DATA_TEMPRepository : BaseRepository<T_ASS_PLAN_DATA_TEMP>,IT_ASS_PLAN_DATA_TEMPRepository
    {
    }
	public partial class T_ASS_PLAN_FLOWRepository : BaseRepository<T_ASS_PLAN_FLOW>,IT_ASS_PLAN_FLOWRepository
    {
    }
	public partial class T_ASS_PLAN_LOCATERepository : BaseRepository<T_ASS_PLAN_LOCATE>,IT_ASS_PLAN_LOCATERepository
    {
    }
	public partial class T_ASS_PLAN_MATERIALRepository : BaseRepository<T_ASS_PLAN_MATERIAL>,IT_ASS_PLAN_MATERIALRepository
    {
    }
	public partial class T_ASS_PLAN_MEMBERRepository : BaseRepository<T_ASS_PLAN_MEMBER>,IT_ASS_PLAN_MEMBERRepository
    {
    }
	public partial class T_ASS_PLAN_MONTHRepository : BaseRepository<T_ASS_PLAN_MONTH>,IT_ASS_PLAN_MONTHRepository
    {
    }
	public partial class T_ASS_PLAN_PROBLEMRepository : BaseRepository<T_ASS_PLAN_PROBLEM>,IT_ASS_PLAN_PROBLEMRepository
    {
    }
	public partial class T_ASS_PLAN_PROJECTRepository : BaseRepository<T_ASS_PLAN_PROJECT>,IT_ASS_PLAN_PROJECTRepository
    {
    }
	public partial class T_ASS_PLAN_REPAIRRepository : BaseRepository<T_ASS_PLAN_REPAIR>,IT_ASS_PLAN_REPAIRRepository
    {
    }
	public partial class T_ASS_PLAN_TOOLRepository : BaseRepository<T_ASS_PLAN_TOOL>,IT_ASS_PLAN_TOOLRepository
    {
    }
	public partial class T_ASS_PLAN_UNIT_PRO_STATRepository : BaseRepository<T_ASS_PLAN_UNIT_PRO_STAT>,IT_ASS_PLAN_UNIT_PRO_STATRepository
    {
    }
	public partial class T_ASS_PLAN_WEEKRepository : BaseRepository<T_ASS_PLAN_WEEK>,IT_ASS_PLAN_WEEKRepository
    {
    }
	public partial class T_ASS_PROBLEMRepository : BaseRepository<T_ASS_PROBLEM>,IT_ASS_PROBLEMRepository
    {
    }
	public partial class T_ASS_PROBLEM_HISRepository : BaseRepository<T_ASS_PROBLEM_HIS>,IT_ASS_PROBLEM_HISRepository
    {
    }
	public partial class T_ASS_PROBLEM_LJRepository : BaseRepository<T_ASS_PROBLEM_LJ>,IT_ASS_PROBLEM_LJRepository
    {
    }
	public partial class T_ASS_PROBLEM_ORIRepository : BaseRepository<T_ASS_PROBLEM_ORI>,IT_ASS_PROBLEM_ORIRepository
    {
    }
	public partial class T_ASS_PROBLEM_TEMPRepository : BaseRepository<T_ASS_PROBLEM_TEMP>,IT_ASS_PROBLEM_TEMPRepository
    {
    }
	public partial class T_ASS_PROJECTRepository : BaseRepository<T_ASS_PROJECT>,IT_ASS_PROJECTRepository
    {
    }
	public partial class T_ASS_REPEAT_PROBLEMRepository : BaseRepository<T_ASS_REPEAT_PROBLEM>,IT_ASS_REPEAT_PROBLEMRepository
    {
    }
	public partial class T_ASS_REPEAT_PRODETAILRepository : BaseRepository<T_ASS_REPEAT_PRODETAIL>,IT_ASS_REPEAT_PRODETAILRepository
    {
    }
	public partial class T_ASS_SECURITY_OFFERRepository : BaseRepository<T_ASS_SECURITY_OFFER>,IT_ASS_SECURITY_OFFERRepository
    {
    }
	public partial class T_ASS_STATIONRepository : BaseRepository<T_ASS_STATION>,IT_ASS_STATIONRepository
    {
    }
	public partial class T_ASS_STATIONSTAIRSRepository : BaseRepository<T_ASS_STATIONSTAIRS>,IT_ASS_STATIONSTAIRSRepository
    {
    }
	public partial class T_ASS_TEMREPAIR_PLANRepository : BaseRepository<T_ASS_TEMREPAIR_PLAN>,IT_ASS_TEMREPAIR_PLANRepository
    {
    }
	public partial class T_ASS_TEMREPAIR_PLAN_DETAILRepository : BaseRepository<T_ASS_TEMREPAIR_PLAN_DETAIL>,IT_ASS_TEMREPAIR_PLAN_DETAILRepository
    {
    }
	public partial class T_ASS_TOOLINFORepository : BaseRepository<T_ASS_TOOLINFO>,IT_ASS_TOOLINFORepository
    {
    }
	public partial class T_ASS_TQIRepository : BaseRepository<T_ASS_TQI>,IT_ASS_TQIRepository
    {
    }
	public partial class T_ASS_TQI_AVESCORERepository : BaseRepository<T_ASS_TQI_AVESCORE>,IT_ASS_TQI_AVESCORERepository
    {
    }
	public partial class T_ASS_TQI_DETAILRepository : BaseRepository<T_ASS_TQI_DETAIL>,IT_ASS_TQI_DETAILRepository
    {
    }
	public partial class T_ASS_TQI_PARARepository : BaseRepository<T_ASS_TQI_PARA>,IT_ASS_TQI_PARARepository
    {
    }
	public partial class T_ASS_TQI_PARA2Repository : BaseRepository<T_ASS_TQI_PARA2>,IT_ASS_TQI_PARA2Repository
    {
    }
	public partial class T_ASS_TRACKRepository : BaseRepository<T_ASS_TRACK>,IT_ASS_TRACKRepository
    {
    }
	public partial class T_ASS_TRACK_VALRepository : BaseRepository<T_ASS_TRACK_VAL>,IT_ASS_TRACK_VALRepository
    {
    }
	public partial class T_ASS_TRACK_VAL_DETAILRepository : BaseRepository<T_ASS_TRACK_VAL_DETAIL>,IT_ASS_TRACK_VAL_DETAILRepository
    {
    }
	public partial class T_ASS_TUNNELRepository : BaseRepository<T_ASS_TUNNEL>,IT_ASS_TUNNELRepository
    {
    }
	public partial class T_ASS_TURNOUTRepository : BaseRepository<T_ASS_TURNOUT>,IT_ASS_TURNOUTRepository
    {
    }
	public partial class T_ASS_TURNOUT_VALRepository : BaseRepository<T_ASS_TURNOUT_VAL>,IT_ASS_TURNOUT_VALRepository
    {
    }
	public partial class T_ASS_TURNOUT_VAL_DETAILRepository : BaseRepository<T_ASS_TURNOUT_VAL_DETAIL>,IT_ASS_TURNOUT_VAL_DETAILRepository
    {
    }
	public partial class T_ASS_UNITRepository : BaseRepository<T_ASS_UNIT>,IT_ASS_UNITRepository
    {
    }
	public partial class T_ASS_UNIT_TQIRepository : BaseRepository<T_ASS_UNIT_TQI>,IT_ASS_UNIT_TQIRepository
    {
    }
	public partial class T_ASS_UNIT_VALRepository : BaseRepository<T_ASS_UNIT_VAL>,IT_ASS_UNIT_VALRepository
    {
    }
	public partial class T_ASS_UNIT_VAL_DETAILRepository : BaseRepository<T_ASS_UNIT_VAL_DETAIL>,IT_ASS_UNIT_VAL_DETAILRepository
    {
    }
	public partial class T_ASS_UNIT625Repository : BaseRepository<T_ASS_UNIT625>,IT_ASS_UNIT625Repository
    {
    }
	public partial class T_ASS_UNIT625_VALRepository : BaseRepository<T_ASS_UNIT625_VAL>,IT_ASS_UNIT625_VALRepository
    {
    }
	public partial class T_ASS_UNIT625_VAL_DETAILRepository : BaseRepository<T_ASS_UNIT625_VAL_DETAIL>,IT_ASS_UNIT625_VAL_DETAILRepository
    {
    }
	public partial class T_BOOTRECINFORepository : BaseRepository<T_BOOTRECINFO>,IT_BOOTRECINFORepository
    {
    }
	public partial class T_CARLASTOBDRepository : BaseRepository<T_CARLASTOBD>,IT_CARLASTOBDRepository
    {
    }
	public partial class T_CAROBDRepository : BaseRepository<T_CAROBD>,IT_CAROBDRepository
    {
    }
	public partial class T_CHK_CURVERepository : BaseRepository<T_CHK_CURVE>,IT_CHK_CURVERepository
    {
    }
	public partial class T_CHK_CURVE_ITEMSRepository : BaseRepository<T_CHK_CURVE_ITEMS>,IT_CHK_CURVE_ITEMSRepository
    {
    }
	public partial class T_CHK_DICRepository : BaseRepository<T_CHK_DIC>,IT_CHK_DICRepository
    {
    }
	public partial class T_CHK_DISEASE_ITEMSRepository : BaseRepository<T_CHK_DISEASE_ITEMS>,IT_CHK_DISEASE_ITEMSRepository
    {
    }
	public partial class T_CHK_DISEASE_STANDARDRepository : BaseRepository<T_CHK_DISEASE_STANDARD>,IT_CHK_DISEASE_STANDARDRepository
    {
    }
	public partial class T_CHK_LINERepository : BaseRepository<T_CHK_LINE>,IT_CHK_LINERepository
    {
    }
	public partial class T_CHK_LINE_ITEMSRepository : BaseRepository<T_CHK_LINE_ITEMS>,IT_CHK_LINE_ITEMSRepository
    {
    }
	public partial class T_CHK_MEDIA_ITEMSRepository : BaseRepository<T_CHK_MEDIA_ITEMS>,IT_CHK_MEDIA_ITEMSRepository
    {
    }
	public partial class T_CHK_TURNOUTRepository : BaseRepository<T_CHK_TURNOUT>,IT_CHK_TURNOUTRepository
    {
    }
	public partial class T_CHK_TURNOUT_DIAMOND_ITEMSRepository : BaseRepository<T_CHK_TURNOUT_DIAMOND_ITEMS>,IT_CHK_TURNOUT_DIAMOND_ITEMSRepository
    {
    }
	public partial class T_CHK_TURNOUT_DOUBLE_ITEMSRepository : BaseRepository<T_CHK_TURNOUT_DOUBLE_ITEMS>,IT_CHK_TURNOUT_DOUBLE_ITEMSRepository
    {
    }
	public partial class T_CHK_TURNOUT_ITEMSRepository : BaseRepository<T_CHK_TURNOUT_ITEMS>,IT_CHK_TURNOUT_ITEMSRepository
    {
    }
	public partial class T_CHK_TURNOUT_MOVPOINT_ITEMSRepository : BaseRepository<T_CHK_TURNOUT_MOVPOINT_ITEMS>,IT_CHK_TURNOUT_MOVPOINT_ITEMSRepository
    {
    }
	public partial class T_CHK_TURNOUT_SLIP_ITEMSRepository : BaseRepository<T_CHK_TURNOUT_SLIP_ITEMS>,IT_CHK_TURNOUT_SLIP_ITEMSRepository
    {
    }
	public partial class T_CHK_VISCHECK_ITEMSRepository : BaseRepository<T_CHK_VISCHECK_ITEMS>,IT_CHK_VISCHECK_ITEMSRepository
    {
    }
	public partial class T_CHK_VISUAL_ITEMSRepository : BaseRepository<T_CHK_VISUAL_ITEMS>,IT_CHK_VISUAL_ITEMSRepository
    {
    }
	public partial class T_CHK_WIDENING_VALUERepository : BaseRepository<T_CHK_WIDENING_VALUE>,IT_CHK_WIDENING_VALUERepository
    {
    }
	public partial class T_CHKPOSRepository : BaseRepository<T_CHKPOS>,IT_CHKPOSRepository
    {
    }
	public partial class T_CUSTOM_STATIONRepository : BaseRepository<T_CUSTOM_STATION>,IT_CUSTOM_STATIONRepository
    {
    }
	public partial class T_CZ_CCRepository : BaseRepository<T_CZ_CC>,IT_CZ_CCRepository
    {
    }
	public partial class T_CZ_FREQ_TEMPRepository : BaseRepository<T_CZ_FREQ_TEMP>,IT_CZ_FREQ_TEMPRepository
    {
    }
	public partial class T_CZ_GJRepository : BaseRepository<T_CZ_GJ>,IT_CZ_GJRepository
    {
    }
	public partial class T_CZ_JCHRepository : BaseRepository<T_CZ_JCH>,IT_CZ_JCHRepository
    {
    }
	public partial class T_CZ_NLINENORepository : BaseRepository<T_CZ_NLINENO>,IT_CZ_NLINENORepository
    {
    }
	public partial class T_CZ_PHONERepository : BaseRepository<T_CZ_PHONE>,IT_CZ_PHONERepository
    {
    }
	public partial class T_CZ_TBLRepository : BaseRepository<T_CZ_TBL>,IT_CZ_TBLRepository
    {
    }
	public partial class T_CZ_TDWID_TEMPRepository : BaseRepository<T_CZ_TDWID_TEMP>,IT_CZ_TDWID_TEMPRepository
    {
    }
	public partial class T_CZ_TJ_TEMPRepository : BaseRepository<T_CZ_TJ_TEMP>,IT_CZ_TJ_TEMPRepository
    {
    }
	public partial class T_CZ_WARPRepository : BaseRepository<T_CZ_WARP>,IT_CZ_WARPRepository
    {
    }
	public partial class T_CZ_WARP_TEMPRepository : BaseRepository<T_CZ_WARP_TEMP>,IT_CZ_WARP_TEMPRepository
    {
    }
	public partial class T_GIS_LINERepository : BaseRepository<T_GIS_LINE>,IT_GIS_LINERepository
    {
    }
	public partial class T_GIS_LINE_TESTRepository : BaseRepository<T_GIS_LINE_TEST>,IT_GIS_LINE_TESTRepository
    {
    }
	public partial class T_GIS_LINE_TEST_NOPWDRepository : BaseRepository<T_GIS_LINE_TEST_NOPWD>,IT_GIS_LINE_TEST_NOPWDRepository
    {
    }
	public partial class T_GIS_STATIONRepository : BaseRepository<T_GIS_STATION>,IT_GIS_STATIONRepository
    {
    }
	public partial class T_GIS_STATION_TESTRepository : BaseRepository<T_GIS_STATION_TEST>,IT_GIS_STATION_TESTRepository
    {
    }
	public partial class T_GWBASERepository : BaseRepository<T_GWBASE>,IT_GWBASERepository
    {
    }
	public partial class T_GWBASE_SECTION_LINERepository : BaseRepository<T_GWBASE_SECTION_LINE>,IT_GWBASE_SECTION_LINERepository
    {
    }
	public partial class T_GWBASE_TESTRepository : BaseRepository<T_GWBASE_TEST>,IT_GWBASE_TESTRepository
    {
    }
	public partial class T_GWDETAILRepository : BaseRepository<T_GWDETAIL>,IT_GWDETAILRepository
    {
    }
	public partial class T_GWTRANSETRepository : BaseRepository<T_GWTRANSET>,IT_GWTRANSETRepository
    {
    }
	public partial class T_JOB_LINERepository : BaseRepository<T_JOB_LINE>,IT_JOB_LINERepository
    {
    }
	public partial class T_LKJ_FLOW_ATTACHRepository : BaseRepository<T_LKJ_FLOW_ATTACH>,IT_LKJ_FLOW_ATTACHRepository
    {
    }
	public partial class T_LKJ_FLOW_DOCRepository : BaseRepository<T_LKJ_FLOW_DOC>,IT_LKJ_FLOW_DOCRepository
    {
    }
	public partial class T_LKJ_FLOW_FEEDBACKRepository : BaseRepository<T_LKJ_FLOW_FEEDBACK>,IT_LKJ_FLOW_FEEDBACKRepository
    {
    }
	public partial class T_LKJ_FLOW_INFORepository : BaseRepository<T_LKJ_FLOW_INFO>,IT_LKJ_FLOW_INFORepository
    {
    }
	public partial class T_LKJ_FLOW_MESSAGERepository : BaseRepository<T_LKJ_FLOW_MESSAGE>,IT_LKJ_FLOW_MESSAGERepository
    {
    }
	public partial class T_LKJ_FLOW_REFERENCERepository : BaseRepository<T_LKJ_FLOW_REFERENCE>,IT_LKJ_FLOW_REFERENCERepository
    {
    }
	public partial class T_LKJ_FLOW_ROLERepository : BaseRepository<T_LKJ_FLOW_ROLE>,IT_LKJ_FLOW_ROLERepository
    {
    }
	public partial class T_LKJ_FLOW_STEPINFORepository : BaseRepository<T_LKJ_FLOW_STEPINFO>,IT_LKJ_FLOW_STEPINFORepository
    {
    }
	public partial class T_LKJ_FLOW_USERROLERepository : BaseRepository<T_LKJ_FLOW_USERROLE>,IT_LKJ_FLOW_USERROLERepository
    {
    }
	public partial class T_LKJ_LINESTATIONRepository : BaseRepository<T_LKJ_LINESTATION>,IT_LKJ_LINESTATIONRepository
    {
    }
	public partial class T_LKJ_ROLEFLOWRepository : BaseRepository<T_LKJ_ROLEFLOW>,IT_LKJ_ROLEFLOWRepository
    {
    }
	public partial class T_LKJ_S1Repository : BaseRepository<T_LKJ_S1>,IT_LKJ_S1Repository
    {
    }
	public partial class T_LKJ_S1_HISRepository : BaseRepository<T_LKJ_S1_HIS>,IT_LKJ_S1_HISRepository
    {
    }
	public partial class T_LKJ_S10Repository : BaseRepository<T_LKJ_S10>,IT_LKJ_S10Repository
    {
    }
	public partial class T_LKJ_S10_HISRepository : BaseRepository<T_LKJ_S10_HIS>,IT_LKJ_S10_HISRepository
    {
    }
	public partial class T_LKJ_S11Repository : BaseRepository<T_LKJ_S11>,IT_LKJ_S11Repository
    {
    }
	public partial class T_LKJ_S11_HISRepository : BaseRepository<T_LKJ_S11_HIS>,IT_LKJ_S11_HISRepository
    {
    }
	public partial class T_LKJ_S12Repository : BaseRepository<T_LKJ_S12>,IT_LKJ_S12Repository
    {
    }
	public partial class T_LKJ_S12_HISRepository : BaseRepository<T_LKJ_S12_HIS>,IT_LKJ_S12_HISRepository
    {
    }
	public partial class T_LKJ_S13Repository : BaseRepository<T_LKJ_S13>,IT_LKJ_S13Repository
    {
    }
	public partial class T_LKJ_S13_HISRepository : BaseRepository<T_LKJ_S13_HIS>,IT_LKJ_S13_HISRepository
    {
    }
	public partial class T_LKJ_S2Repository : BaseRepository<T_LKJ_S2>,IT_LKJ_S2Repository
    {
    }
	public partial class T_LKJ_S2_HISRepository : BaseRepository<T_LKJ_S2_HIS>,IT_LKJ_S2_HISRepository
    {
    }
	public partial class T_LKJ_S3Repository : BaseRepository<T_LKJ_S3>,IT_LKJ_S3Repository
    {
    }
	public partial class T_LKJ_S3_HISRepository : BaseRepository<T_LKJ_S3_HIS>,IT_LKJ_S3_HISRepository
    {
    }
	public partial class T_LKJ_S4Repository : BaseRepository<T_LKJ_S4>,IT_LKJ_S4Repository
    {
    }
	public partial class T_LKJ_S4_HISRepository : BaseRepository<T_LKJ_S4_HIS>,IT_LKJ_S4_HISRepository
    {
    }
	public partial class T_LKJ_S5Repository : BaseRepository<T_LKJ_S5>,IT_LKJ_S5Repository
    {
    }
	public partial class T_LKJ_S5_HISRepository : BaseRepository<T_LKJ_S5_HIS>,IT_LKJ_S5_HISRepository
    {
    }
	public partial class T_LKJ_S6Repository : BaseRepository<T_LKJ_S6>,IT_LKJ_S6Repository
    {
    }
	public partial class T_LKJ_S6_HISRepository : BaseRepository<T_LKJ_S6_HIS>,IT_LKJ_S6_HISRepository
    {
    }
	public partial class T_LKJ_S7Repository : BaseRepository<T_LKJ_S7>,IT_LKJ_S7Repository
    {
    }
	public partial class T_LKJ_S7_HISRepository : BaseRepository<T_LKJ_S7_HIS>,IT_LKJ_S7_HISRepository
    {
    }
	public partial class T_LKJ_S8Repository : BaseRepository<T_LKJ_S8>,IT_LKJ_S8Repository
    {
    }
	public partial class T_LKJ_S8_HISRepository : BaseRepository<T_LKJ_S8_HIS>,IT_LKJ_S8_HISRepository
    {
    }
	public partial class T_LKJ_S9Repository : BaseRepository<T_LKJ_S9>,IT_LKJ_S9Repository
    {
    }
	public partial class T_LKJ_S9_HISRepository : BaseRepository<T_LKJ_S9_HIS>,IT_LKJ_S9_HISRepository
    {
    }
	public partial class T_LKJ_ST1Repository : BaseRepository<T_LKJ_ST1>,IT_LKJ_ST1Repository
    {
    }
	public partial class T_LKJ_ST1_HISRepository : BaseRepository<T_LKJ_ST1_HIS>,IT_LKJ_ST1_HISRepository
    {
    }
	public partial class T_LKJ_STARELTIONRepository : BaseRepository<T_LKJ_STARELTION>,IT_LKJ_STARELTIONRepository
    {
    }
	public partial class T_LKJ_SYSTABLERepository : BaseRepository<T_LKJ_SYSTABLE>,IT_LKJ_SYSTABLERepository
    {
    }
	public partial class T_LKJ_VERSIONNUMRepository : BaseRepository<T_LKJ_VERSIONNUM>,IT_LKJ_VERSIONNUMRepository
    {
    }
	public partial class T_LKJ_WIRINGDIAGRAMRepository : BaseRepository<T_LKJ_WIRINGDIAGRAM>,IT_LKJ_WIRINGDIAGRAMRepository
    {
    }
	public partial class T_LKJ_WORKPROCESSRepository : BaseRepository<T_LKJ_WORKPROCESS>,IT_LKJ_WORKPROCESSRepository
    {
    }
	public partial class T_LKJ_WORKPROCESS_HISRepository : BaseRepository<T_LKJ_WORKPROCESS_HIS>,IT_LKJ_WORKPROCESS_HISRepository
    {
    }
	public partial class T_MOBILEFILERepository : BaseRepository<T_MOBILEFILE>,IT_MOBILEFILERepository
    {
    }
	public partial class T_MOBILEFILE_TODOWNRepository : BaseRepository<T_MOBILEFILE_TODOWN>,IT_MOBILEFILE_TODOWNRepository
    {
    }
	public partial class T_MOBILELASTPOSRepository : BaseRepository<T_MOBILELASTPOS>,IT_MOBILELASTPOSRepository
    {
    }
	public partial class T_MOBILEROUTERepository : BaseRepository<T_MOBILEROUTE>,IT_MOBILEROUTERepository
    {
    }
	public partial class T_MOBILEROUTE_HISRepository : BaseRepository<T_MOBILEROUTE_HIS>,IT_MOBILEROUTE_HISRepository
    {
    }
	public partial class T_OILPOSRepository : BaseRepository<T_OILPOS>,IT_OILPOSRepository
    {
    }
	public partial class T_RAINRepository : BaseRepository<T_RAIN>,IT_RAINRepository
    {
    }
	public partial class T_RAIN_SMSRepository : BaseRepository<T_RAIN_SMS>,IT_RAIN_SMSRepository
    {
    }
	public partial class T_RAINWARNRepository : BaseRepository<T_RAINWARN>,IT_RAINWARNRepository
    {
    }
	public partial class T_REALRAINDATARepository : BaseRepository<T_REALRAINDATA>,IT_REALRAINDATARepository
    {
    }
	public partial class T_SGJHWARNRepository : BaseRepository<T_SGJHWARN>,IT_SGJHWARNRepository
    {
    }
	public partial class T_SGJHWARNTMPRepository : BaseRepository<T_SGJHWARNTMP>,IT_SGJHWARNTMPRepository
    {
    }
	public partial class T_VEHICLELOCATIONRepository : BaseRepository<T_VEHICLELOCATION>,IT_VEHICLELOCATIONRepository
    {
    }
	public partial class T_WATERRepository : BaseRepository<T_WATER>,IT_WATERRepository
    {
    }
	public partial class T_WATER_DEVICERepository : BaseRepository<T_WATER_DEVICE>,IT_WATER_DEVICERepository
    {
    }
	public partial class T_WATER_WARNRepository : BaseRepository<T_WATER_WARN>,IT_WATER_WARNRepository
    {
    }
	public partial class TASK_CARDRepository : BaseRepository<TASK_CARD>,ITASK_CARDRepository
    {
    }
	public partial class TASK_CONSTITLERepository : BaseRepository<TASK_CONSTITLE>,ITASK_CONSTITLERepository
    {
    }
	public partial class TASK_CONSTRUCTIONRepository : BaseRepository<TASK_CONSTRUCTION>,ITASK_CONSTRUCTIONRepository
    {
    }
	public partial class TASK_DAMAGE_RAILRepository : BaseRepository<TASK_DAMAGE_RAIL>,ITASK_DAMAGE_RAILRepository
    {
    }
	public partial class TASK_FLOORRepository : BaseRepository<TASK_FLOOR>,ITASK_FLOORRepository
    {
    }
	public partial class TASK_GBH_RAILRepository : BaseRepository<TASK_GBH_RAIL>,ITASK_GBH_RAILRepository
    {
    }
	public partial class TASK_LAY_LINEROADRepository : BaseRepository<TASK_LAY_LINEROAD>,ITASK_LAY_LINEROADRepository
    {
    }
	public partial class TASK_PLANRepository : BaseRepository<TASK_PLAN>,ITASK_PLANRepository
    {
    }
	public partial class TASK_PLAN_MATERIALRepository : BaseRepository<TASK_PLAN_MATERIAL>,ITASK_PLAN_MATERIALRepository
    {
    }
	public partial class TASK_PLAN_PROBLEMRepository : BaseRepository<TASK_PLAN_PROBLEM>,ITASK_PLAN_PROBLEMRepository
    {
    }
	public partial class TASK_PLAN_TOOLRepository : BaseRepository<TASK_PLAN_TOOL>,ITASK_PLAN_TOOLRepository
    {
    }
	public partial class TASK_RAILRepository : BaseRepository<TASK_RAIL>,ITASK_RAILRepository
    {
    }
	public partial class TASK_RAILCOUNTRepository : BaseRepository<TASK_RAILCOUNT>,ITASK_RAILCOUNTRepository
    {
    }
	public partial class TASK_RECOVER_STUFFRepository : BaseRepository<TASK_RECOVER_STUFF>,ITASK_RECOVER_STUFFRepository
    {
    }
	public partial class TASK_REPLACE_RAILRepository : BaseRepository<TASK_REPLACE_RAIL>,ITASK_REPLACE_RAILRepository
    {
    }
	public partial class TASK_REPLACE_TIERepository : BaseRepository<TASK_REPLACE_TIE>,ITASK_REPLACE_TIERepository
    {
    }
	public partial class TASK_SLIGHT_FROGRepository : BaseRepository<TASK_SLIGHT_FROG>,ITASK_SLIGHT_FROGRepository
    {
    }
	public partial class TASK_SLIGHT_JRAILRepository : BaseRepository<TASK_SLIGHT_JRAIL>,ITASK_SLIGHT_JRAILRepository
    {
    }
	public partial class TASK_SLIGHT_OUTLINERepository : BaseRepository<TASK_SLIGHT_OUTLINE>,ITASK_SLIGHT_OUTLINERepository
    {
    }
	public partial class TASK_SLIGHT_OUTLINE_FILERepository : BaseRepository<TASK_SLIGHT_OUTLINE_FILE>,ITASK_SLIGHT_OUTLINE_FILERepository
    {
    }
	public partial class TASK_SLIGHT_RAILRepository : BaseRepository<TASK_SLIGHT_RAIL>,ITASK_SLIGHT_RAILRepository
    {
    }
	public partial class TASK_SLIGHT_RAILP43Repository : BaseRepository<TASK_SLIGHT_RAILP43>,ITASK_SLIGHT_RAILP43Repository
    {
    }
	public partial class TASK_SLIGHT_RAILP50Repository : BaseRepository<TASK_SLIGHT_RAILP50>,ITASK_SLIGHT_RAILP50Repository
    {
    }
	public partial class TASK_SLIGHT_RAILP60Repository : BaseRepository<TASK_SLIGHT_RAILP60>,ITASK_SLIGHT_RAILP60Repository
    {
    }
	public partial class TASK_SVGRepository : BaseRepository<TASK_SVG>,ITASK_SVGRepository
    {
    }
	public partial class TASK_TOOLINFORepository : BaseRepository<TASK_TOOLINFO>,ITASK_TOOLINFORepository
    {
    }
	public partial class TASK_UNLOAD_RAILRepository : BaseRepository<TASK_UNLOAD_RAIL>,ITASK_UNLOAD_RAILRepository
    {
    }
	public partial class TASK_UNLOAD_STONERepository : BaseRepository<TASK_UNLOAD_STONE>,ITASK_UNLOAD_STONERepository
    {
    }
	public partial class TASK_UNLOAD_TIERepository : BaseRepository<TASK_UNLOAD_TIE>,ITASK_UNLOAD_TIERepository
    {
    }
	public partial class TASK_WORKLOADRepository : BaseRepository<TASK_WORKLOAD>,ITASK_WORKLOADRepository
    {
    }
	public partial class TEMPERATURE_SECTION_LINERepository : BaseRepository<TEMPERATURE_SECTION_LINE>,ITEMPERATURE_SECTION_LINERepository
    {
    }
	public partial class TOOL_BDATE_DICRepository : BaseRepository<TOOL_BDATE_DIC>,ITOOL_BDATE_DICRepository
    {
    }
	public partial class TOOL_BDATE_STOREHOURSERepository : BaseRepository<TOOL_BDATE_STOREHOURSE>,ITOOL_BDATE_STOREHOURSERepository
    {
    }
	public partial class TOOL_BDATE_TOOLNAMERepository : BaseRepository<TOOL_BDATE_TOOLNAME>,ITOOL_BDATE_TOOLNAMERepository
    {
    }
	public partial class TOOL_INOUTMNG_INFORepository : BaseRepository<TOOL_INOUTMNG_INFO>,ITOOL_INOUTMNG_INFORepository
    {
    }
	public partial class TOOL_JOB_PLANRepository : BaseRepository<TOOL_JOB_PLAN>,ITOOL_JOB_PLANRepository
    {
    }
	public partial class TOOL_JOB_PLAN_IMPORTRepository : BaseRepository<TOOL_JOB_PLAN_IMPORT>,ITOOL_JOB_PLAN_IMPORTRepository
    {
    }
	public partial class TOOL_PHONE_USERRepository : BaseRepository<TOOL_PHONE_USER>,ITOOL_PHONE_USERRepository
    {
    }
	public partial class TOOL_TOOLMNG_INOUTRepository : BaseRepository<TOOL_TOOLMNG_INOUT>,ITOOL_TOOLMNG_INOUTRepository
    {
    }
	public partial class TOOL_UPDOWN_LINERepository : BaseRepository<TOOL_UPDOWN_LINE>,ITOOL_UPDOWN_LINERepository
    {
    }
	public partial class TOOL_USERepository : BaseRepository<TOOL_USE>,ITOOL_USERepository
    {
    }
	public partial class TOOL_VIRTUAL_JOB_PLANRepository : BaseRepository<TOOL_VIRTUAL_JOB_PLAN>,ITOOL_VIRTUAL_JOB_PLANRepository
    {
    }
	public partial class TOOL_VIRTUAL_UPDOWN_LINERepository : BaseRepository<TOOL_VIRTUAL_UPDOWN_LINE>,ITOOL_VIRTUAL_UPDOWN_LINERepository
    {
    }
	public partial class TOOL_VIRTUAL_USERepository : BaseRepository<TOOL_VIRTUAL_USE>,ITOOL_VIRTUAL_USERepository
    {
    }
	public partial class TOOL_VIRTUAL_WARMRepository : BaseRepository<TOOL_VIRTUAL_WARM>,ITOOL_VIRTUAL_WARMRepository
    {
    }
	public partial class TOOL_WARMRepository : BaseRepository<TOOL_WARM>,ITOOL_WARMRepository
    {
    }
	public partial class TURNOUT_BASERepository : BaseRepository<TURNOUT_BASE>,ITURNOUT_BASERepository
    {
    }
	public partial class TURNOUT_BDATE_DICRepository : BaseRepository<TURNOUT_BDATE_DIC>,ITURNOUT_BDATE_DICRepository
    {
    }
	public partial class TURNOUT_BRANCHRepository : BaseRepository<TURNOUT_BRANCH>,ITURNOUT_BRANCHRepository
    {
    }
	public partial class TURNOUT_HIS_BRANCHRepository : BaseRepository<TURNOUT_HIS_BRANCH>,ITURNOUT_HIS_BRANCHRepository
    {
    }
	public partial class TURNOUT_HIS_PARTRepository : BaseRepository<TURNOUT_HIS_PART>,ITURNOUT_HIS_PARTRepository
    {
    }
	public partial class TURNOUT_HIS_PICRepository : BaseRepository<TURNOUT_HIS_PIC>,ITURNOUT_HIS_PICRepository
    {
    }
	public partial class TURNOUT_HIS_RAILRepository : BaseRepository<TURNOUT_HIS_RAIL>,ITURNOUT_HIS_RAILRepository
    {
    }
	public partial class TURNOUT_HISTORYRepository : BaseRepository<TURNOUT_HISTORY>,ITURNOUT_HISTORYRepository
    {
    }
	public partial class TURNOUT_PARTRepository : BaseRepository<TURNOUT_PART>,ITURNOUT_PARTRepository
    {
    }
	public partial class TURNOUT_PICRepository : BaseRepository<TURNOUT_PIC>,ITURNOUT_PICRepository
    {
    }
	public partial class TURNOUT_RAILRepository : BaseRepository<TURNOUT_RAIL>,ITURNOUT_RAILRepository
    {
    }
	public partial class TYPEFLOOD_PHOTORepository : BaseRepository<TYPEFLOOD_PHOTO>,ITYPEFLOOD_PHOTORepository
    {
    }
	public partial class VEHICLELOC_BDATA_LOCOMOTIVERepository : BaseRepository<VEHICLELOC_BDATA_LOCOMOTIVE>,IVEHICLELOC_BDATA_LOCOMOTIVERepository
    {
    }
	public partial class VIDEO_BDATA_DEVICERepository : BaseRepository<VIDEO_BDATA_DEVICE>,IVIDEO_BDATA_DEVICERepository
    {
    }
	public partial class VIDEO_FILERepository : BaseRepository<VIDEO_FILE>,IVIDEO_FILERepository
    {
    }
	public partial class WEATHER_PROVINCE_FORECASTRepository : BaseRepository<WEATHER_PROVINCE_FORECAST>,IWEATHER_PROVINCE_FORECASTRepository
    {
    }
	public partial class WEATHER_PROVINCE_HOURFORECASTRepository : BaseRepository<WEATHER_PROVINCE_HOURFORECAST>,IWEATHER_PROVINCE_HOURFORECASTRepository
    {
    }
	public partial class WINDRepository : BaseRepository<WIND>,IWINDRepository
    {
    }
	public partial class WIND_BASEINFORepository : BaseRepository<WIND_BASEINFO>,IWIND_BASEINFORepository
    {
    }
	public partial class WIND_DAYRPTRepository : BaseRepository<WIND_DAYRPT>,IWIND_DAYRPTRepository
    {
    }
	public partial class WIND_DIRECTIONRepository : BaseRepository<WIND_DIRECTION>,IWIND_DIRECTIONRepository
    {
    }
	public partial class WIND_GRADINGRepository : BaseRepository<WIND_GRADING>,IWIND_GRADINGRepository
    {
    }
	public partial class WIND_MONRPTRepository : BaseRepository<WIND_MONRPT>,IWIND_MONRPTRepository
    {
    }
	public partial class WIND_SECTION_LINERepository : BaseRepository<WIND_SECTION_LINE>,IWIND_SECTION_LINERepository
    {
    }
	public partial class WIND_WARNRepository : BaseRepository<WIND_WARN>,IWIND_WARNRepository
    {
    }
	public partial class WIND_WARN_STANDARDRepository : BaseRepository<WIND_WARN_STANDARD>,IWIND_WARN_STANDARDRepository
    {
    }
	public partial class WIND_YEARRPTRepository : BaseRepository<WIND_YEARRPT>,IWIND_YEARRPTRepository
    {
    }
	public partial class WUFENG_BIAOZHUNRepository : BaseRepository<WUFENG_BIAOZHUN>,IWUFENG_BIAOZHUNRepository
    {
    }
	public partial class WUFENG_CHEZHANRepository : BaseRepository<WUFENG_CHEZHAN>,IWUFENG_CHEZHANRepository
    {
    }
	public partial class WUFENG_DANYUANRepository : BaseRepository<WUFENG_DANYUAN>,IWUFENG_DANYUANRepository
    {
    }
	public partial class WUFENG_DANYUAN_LISHIRepository : BaseRepository<WUFENG_DANYUAN_LISHI>,IWUFENG_DANYUAN_LISHIRepository
    {
    }
	public partial class WUFENG_DAOCHARepository : BaseRepository<WUFENG_DAOCHA>,IWUFENG_DAOCHARepository
    {
    }
	public partial class WUFENG_JILURepository : BaseRepository<WUFENG_JILU>,IWUFENG_JILURepository
    {
    }
	public partial class WUFENG_XIANMINGRepository : BaseRepository<WUFENG_XIANMING>,IWUFENG_XIANMINGRepository
    {
    }
}