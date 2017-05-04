                
using System;   
using System.Collections.Generic;   
using System.Linq;    
using System.Text; 
using IBLL;       
using Model;  
namespace BLL    
{ 
 
	public partial class ALL_LINE_DATAService : BaseService<ALL_LINE_DATA>,IALL_LINE_DATAService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IALL_LINE_DATARepository;
        }
    }
 
	public partial class ALL_STATION_DATAService : BaseService<ALL_STATION_DATA>,IALL_STATION_DATAService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IALL_STATION_DATARepository;
        }
    }
 
	public partial class ALL_VEHTYPE_DATAService : BaseService<ALL_VEHTYPE_DATA>,IALL_VEHTYPE_DATAService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IALL_VEHTYPE_DATARepository;
        }
    }
 
	public partial class ALL_VIDEOFILE_DATAService : BaseService<ALL_VIDEOFILE_DATA>,IALL_VIDEOFILE_DATAService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IALL_VIDEOFILE_DATARepository;
        }
    }
 
	public partial class ASSET_BASE_ACCOUNTService : BaseService<ASSET_BASE_ACCOUNT>,IASSET_BASE_ACCOUNTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IASSET_BASE_ACCOUNTRepository;
        }
    }
 
	public partial class ASSET_BASE_CATALOGService : BaseService<ASSET_BASE_CATALOG>,IASSET_BASE_CATALOGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IASSET_BASE_CATALOGRepository;
        }
    }
 
	public partial class ASSET_BASE_MATERIAL_DICService : BaseService<ASSET_BASE_MATERIAL_DIC>,IASSET_BASE_MATERIAL_DICService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IASSET_BASE_MATERIAL_DICRepository;
        }
    }
 
	public partial class ASSET_BASE_RATEService : BaseService<ASSET_BASE_RATE>,IASSET_BASE_RATEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IASSET_BASE_RATERepository;
        }
    }
 
	public partial class ASSET_BASE_RELATION_UNITService : BaseService<ASSET_BASE_RELATION_UNIT>,IASSET_BASE_RELATION_UNITService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IASSET_BASE_RELATION_UNITRepository;
        }
    }
 
	public partial class ASSET_BASE_SUPPLIERService : BaseService<ASSET_BASE_SUPPLIER>,IASSET_BASE_SUPPLIERService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IASSET_BASE_SUPPLIERRepository;
        }
    }
 
	public partial class ASSET_BASE_SUPPLIER_MATERIALService : BaseService<ASSET_BASE_SUPPLIER_MATERIAL>,IASSET_BASE_SUPPLIER_MATERIALService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IASSET_BASE_SUPPLIER_MATERIALRepository;
        }
    }
 
	public partial class ASSET_INVENTORYService : BaseService<ASSET_INVENTORY>,IASSET_INVENTORYService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IASSET_INVENTORYRepository;
        }
    }
 
	public partial class ASSET_MOBILEService : BaseService<ASSET_MOBILE>,IASSET_MOBILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IASSET_MOBILERepository;
        }
    }
 
	public partial class ASSET_MRPService : BaseService<ASSET_MRP>,IASSET_MRPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IASSET_MRPRepository;
        }
    }
 
	public partial class ASSET_MRP_BOMService : BaseService<ASSET_MRP_BOM>,IASSET_MRP_BOMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IASSET_MRP_BOMRepository;
        }
    }
 
	public partial class ASSET_WAREHOUSEService : BaseService<ASSET_WAREHOUSE>,IASSET_WAREHOUSEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IASSET_WAREHOUSERepository;
        }
    }
 
	public partial class BASE_BOUNDARYService : BaseService<BASE_BOUNDARY>,IBASE_BOUNDARYService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBASE_BOUNDARYRepository;
        }
    }
 
	public partial class BASE_DICTService : BaseService<BASE_DICT>,IBASE_DICTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBASE_DICTRepository;
        }
    }
 
	public partial class BASE_LINEService : BaseService<BASE_LINE>,IBASE_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBASE_LINERepository;
        }
    }
 
	public partial class BASE_STATIONService : BaseService<BASE_STATION>,IBASE_STATIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBASE_STATIONRepository;
        }
    }
 
	public partial class BOOT_BASEService : BaseService<BOOT_BASE>,IBOOT_BASEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBOOT_BASERepository;
        }
    }
 
	public partial class BOOT_RECORDService : BaseService<BOOT_RECORD>,IBOOT_RECORDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBOOT_RECORDRepository;
        }
    }
 
	public partial class BRIDGE_BOUNDService : BaseService<BRIDGE_BOUND>,IBRIDGE_BOUNDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_BOUNDRepository;
        }
    }
 
	public partial class BRIDGE_BRIDGEService : BaseService<BRIDGE_BRIDGE>,IBRIDGE_BRIDGEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_BRIDGERepository;
        }
    }
 
	public partial class BRIDGE_CULVERTService : BaseService<BRIDGE_CULVERT>,IBRIDGE_CULVERTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_CULVERTRepository;
        }
    }
 
	public partial class BRIDGE_EQU_CLEARANCEService : BaseService<BRIDGE_EQU_CLEARANCE>,IBRIDGE_EQU_CLEARANCEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_EQU_CLEARANCERepository;
        }
    }
 
	public partial class BRIDGE_EQU_CLEARANCE_FILEService : BaseService<BRIDGE_EQU_CLEARANCE_FILE>,IBRIDGE_EQU_CLEARANCE_FILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_EQU_CLEARANCE_FILERepository;
        }
    }
 
	public partial class BRIDGE_EQU_DATA_TEMPService : BaseService<BRIDGE_EQU_DATA_TEMP>,IBRIDGE_EQU_DATA_TEMPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_EQU_DATA_TEMPRepository;
        }
    }
 
	public partial class BRIDGE_EQU_FILEService : BaseService<BRIDGE_EQU_FILE>,IBRIDGE_EQU_FILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_EQU_FILERepository;
        }
    }
 
	public partial class BRIDGE_LIMITOVERHEADService : BaseService<BRIDGE_LIMITOVERHEAD>,IBRIDGE_LIMITOVERHEADService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_LIMITOVERHEADRepository;
        }
    }
 
	public partial class BRIDGE_LRONService : BaseService<BRIDGE_LRON>,IBRIDGE_LRONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_LRONRepository;
        }
    }
 
	public partial class BRIDGE_LRON_OVERPASSService : BaseService<BRIDGE_LRON_OVERPASS>,IBRIDGE_LRON_OVERPASSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_LRON_OVERPASSRepository;
        }
    }
 
	public partial class BRIDGE_MAINTENAN_EVALUATEService : BaseService<BRIDGE_MAINTENAN_EVALUATE>,IBRIDGE_MAINTENAN_EVALUATEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_MAINTENAN_EVALUATERepository;
        }
    }
 
	public partial class BRIDGE_MAINTENAN_NOTICEService : BaseService<BRIDGE_MAINTENAN_NOTICE>,IBRIDGE_MAINTENAN_NOTICEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_MAINTENAN_NOTICERepository;
        }
    }
 
	public partial class BRIDGE_MAINTENAN_NOTICE_PROService : BaseService<BRIDGE_MAINTENAN_NOTICE_PRO>,IBRIDGE_MAINTENAN_NOTICE_PROService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_MAINTENAN_NOTICE_PRORepository;
        }
    }
 
	public partial class BRIDGE_MAINTENAN_PROService : BaseService<BRIDGE_MAINTENAN_PRO>,IBRIDGE_MAINTENAN_PROService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_MAINTENAN_PRORepository;
        }
    }
 
	public partial class BRIDGE_MAINTENAN_PRO_HISService : BaseService<BRIDGE_MAINTENAN_PRO_HIS>,IBRIDGE_MAINTENAN_PRO_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_MAINTENAN_PRO_HISRepository;
        }
    }
 
	public partial class BRIDGE_MAINTENAN_REPORTService : BaseService<BRIDGE_MAINTENAN_REPORT>,IBRIDGE_MAINTENAN_REPORTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_MAINTENAN_REPORTRepository;
        }
    }
 
	public partial class BRIDGE_MSGService : BaseService<BRIDGE_MSG>,IBRIDGE_MSGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_MSGRepository;
        }
    }
 
	public partial class BRIDGE_OTHER_DEVICEService : BaseService<BRIDGE_OTHER_DEVICE>,IBRIDGE_OTHER_DEVICEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_OTHER_DEVICERepository;
        }
    }
 
	public partial class BRIDGE_OVERPASSService : BaseService<BRIDGE_OVERPASS>,IBRIDGE_OVERPASSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_OVERPASSRepository;
        }
    }
 
	public partial class BRIDGE_OVERPASS_WATERService : BaseService<BRIDGE_OVERPASS_WATER>,IBRIDGE_OVERPASS_WATERService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_OVERPASS_WATERRepository;
        }
    }
 
	public partial class BRIDGE_PARA_MAINTENANService : BaseService<BRIDGE_PARA_MAINTENAN>,IBRIDGE_PARA_MAINTENANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_PARA_MAINTENANRepository;
        }
    }
 
	public partial class BRIDGE_PARA_STATUSService : BaseService<BRIDGE_PARA_STATUS>,IBRIDGE_PARA_STATUSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_PARA_STATUSRepository;
        }
    }
 
	public partial class BRIDGE_SHALLOW_FOUNDATIONService : BaseService<BRIDGE_SHALLOW_FOUNDATION>,IBRIDGE_SHALLOW_FOUNDATIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_SHALLOW_FOUNDATIONRepository;
        }
    }
 
	public partial class BRIDGE_STATE_PROService : BaseService<BRIDGE_STATE_PRO>,IBRIDGE_STATE_PROService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_STATE_PRORepository;
        }
    }
 
	public partial class BRIDGE_STATE_PRO_FILEService : BaseService<BRIDGE_STATE_PRO_FILE>,IBRIDGE_STATE_PRO_FILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_STATE_PRO_FILERepository;
        }
    }
 
	public partial class BRIDGE_STATE_PRO_HISService : BaseService<BRIDGE_STATE_PRO_HIS>,IBRIDGE_STATE_PRO_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_STATE_PRO_HISRepository;
        }
    }
 
	public partial class BRIDGE_STATE_REPORTService : BaseService<BRIDGE_STATE_REPORT>,IBRIDGE_STATE_REPORTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_STATE_REPORTRepository;
        }
    }
 
	public partial class BRIDGE_TUNNELService : BaseService<BRIDGE_TUNNEL>,IBRIDGE_TUNNELService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBRIDGE_TUNNELRepository;
        }
    }
 
	public partial class BROKENRAIL_BDATA_BOUNDARYService : BaseService<BROKENRAIL_BDATA_BOUNDARY>,IBROKENRAIL_BDATA_BOUNDARYService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_BDATA_BOUNDARYRepository;
        }
    }
 
	public partial class BROKENRAIL_BDATA_DEVICEService : BaseService<BROKENRAIL_BDATA_DEVICE>,IBROKENRAIL_BDATA_DEVICEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_BDATA_DEVICERepository;
        }
    }
 
	public partial class BROKENRAIL_BDATA_DEVICE_STATUSService : BaseService<BROKENRAIL_BDATA_DEVICE_STATUS>,IBROKENRAIL_BDATA_DEVICE_STATUSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_BDATA_DEVICE_STATUSRepository;
        }
    }
 
	public partial class BROKENRAIL_BDATA_SECTIONService : BaseService<BROKENRAIL_BDATA_SECTION>,IBROKENRAIL_BDATA_SECTIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_BDATA_SECTIONRepository;
        }
    }
 
	public partial class BROKENRAIL_DEVICE_STATUSService : BaseService<BROKENRAIL_DEVICE_STATUS>,IBROKENRAIL_DEVICE_STATUSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_DEVICE_STATUSRepository;
        }
    }
 
	public partial class BROKENRAIL_DEVICE_STATUSHISService : BaseService<BROKENRAIL_DEVICE_STATUSHIS>,IBROKENRAIL_DEVICE_STATUSHISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_DEVICE_STATUSHISRepository;
        }
    }
 
	public partial class BROKENRAIL_NEEDSENDService : BaseService<BROKENRAIL_NEEDSEND>,IBROKENRAIL_NEEDSENDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_NEEDSENDRepository;
        }
    }
 
	public partial class BROKENRAIL_SECTION_LINEService : BaseService<BROKENRAIL_SECTION_LINE>,IBROKENRAIL_SECTION_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_SECTION_LINERepository;
        }
    }
 
	public partial class BROKENRAIL_SECTION_STATUSService : BaseService<BROKENRAIL_SECTION_STATUS>,IBROKENRAIL_SECTION_STATUSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_SECTION_STATUSRepository;
        }
    }
 
	public partial class BROKENRAIL_SECTION_STATUSHISService : BaseService<BROKENRAIL_SECTION_STATUSHIS>,IBROKENRAIL_SECTION_STATUSHISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_SECTION_STATUSHISRepository;
        }
    }
 
	public partial class BROKENRAIL_SOUND_SENDPHONEService : BaseService<BROKENRAIL_SOUND_SENDPHONE>,IBROKENRAIL_SOUND_SENDPHONEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_SOUND_SENDPHONERepository;
        }
    }
 
	public partial class BROKENRAIL_VOLTAGE_SMSService : BaseService<BROKENRAIL_VOLTAGE_SMS>,IBROKENRAIL_VOLTAGE_SMSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_VOLTAGE_SMSRepository;
        }
    }
 
	public partial class BROKENRAIL_VOLTAGE_STATUSService : BaseService<BROKENRAIL_VOLTAGE_STATUS>,IBROKENRAIL_VOLTAGE_STATUSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_VOLTAGE_STATUSRepository;
        }
    }
 
	public partial class BROKENRAIL_VOLTAGE_STATUSHISService : BaseService<BROKENRAIL_VOLTAGE_STATUSHIS>,IBROKENRAIL_VOLTAGE_STATUSHISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_VOLTAGE_STATUSHISRepository;
        }
    }
 
	public partial class BROKENRAIL_WARN_CONTROLService : BaseService<BROKENRAIL_WARN_CONTROL>,IBROKENRAIL_WARN_CONTROLService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_WARN_CONTROLRepository;
        }
    }
 
	public partial class BROKENRAIL_WARN_DEVICEService : BaseService<BROKENRAIL_WARN_DEVICE>,IBROKENRAIL_WARN_DEVICEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_WARN_DEVICERepository;
        }
    }
 
	public partial class BROKENRAIL_WARN_FLAGService : BaseService<BROKENRAIL_WARN_FLAG>,IBROKENRAIL_WARN_FLAGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IBROKENRAIL_WARN_FLAGRepository;
        }
    }
 
	public partial class CAR_BDATA_CARService : BaseService<CAR_BDATA_CAR>,ICAR_BDATA_CARService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICAR_BDATA_CARRepository;
        }
    }
 
	public partial class CAR_LAST_LONLATService : BaseService<CAR_LAST_LONLAT>,ICAR_LAST_LONLATService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICAR_LAST_LONLATRepository;
        }
    }
 
	public partial class CAR_OVER_SPEEDService : BaseService<CAR_OVER_SPEED>,ICAR_OVER_SPEEDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICAR_OVER_SPEEDRepository;
        }
    }
 
	public partial class CAR_OVERSPEED_WARNService : BaseService<CAR_OVERSPEED_WARN>,ICAR_OVERSPEED_WARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICAR_OVERSPEED_WARNRepository;
        }
    }
 
	public partial class CAR_PHONE_INFOService : BaseService<CAR_PHONE_INFO>,ICAR_PHONE_INFOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICAR_PHONE_INFORepository;
        }
    }
 
	public partial class CHARTService : BaseService<CHART>,ICHARTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICHARTRepository;
        }
    }
 
	public partial class CHK_BDATA_DEVICEService : BaseService<CHK_BDATA_DEVICE>,ICHK_BDATA_DEVICEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICHK_BDATA_DEVICERepository;
        }
    }
 
	public partial class COMMAND_PUBLISHService : BaseService<COMMAND_PUBLISH>,ICOMMAND_PUBLISHService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICOMMAND_PUBLISHRepository;
        }
    }
 
	public partial class COMMAND_PUBLISH_HISService : BaseService<COMMAND_PUBLISH_HIS>,ICOMMAND_PUBLISH_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICOMMAND_PUBLISH_HISRepository;
        }
    }
 
	public partial class CONFIR_CARService : BaseService<CONFIR_CAR>,ICONFIR_CARService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICONFIR_CARRepository;
        }
    }
 
	public partial class CONFIR_CAR_PLANService : BaseService<CONFIR_CAR_PLAN>,ICONFIR_CAR_PLANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICONFIR_CAR_PLANRepository;
        }
    }
 
	public partial class CONFIR_CAR_WARNService : BaseService<CONFIR_CAR_WARN>,ICONFIR_CAR_WARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICONFIR_CAR_WARNRepository;
        }
    }
 
	public partial class CONTROL_FOUR_DICService : BaseService<CONTROL_FOUR_DIC>,ICONTROL_FOUR_DICService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICONTROL_FOUR_DICRepository;
        }
    }
 
	public partial class CONTROL_FOUR_PLANService : BaseService<CONTROL_FOUR_PLAN>,ICONTROL_FOUR_PLANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICONTROL_FOUR_PLANRepository;
        }
    }
 
	public partial class CURVE_BASEService : BaseService<CURVE_BASE>,ICURVE_BASEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICURVE_BASERepository;
        }
    }
 
	public partial class CURVE_BASE_EXTService : BaseService<CURVE_BASE_EXT>,ICURVE_BASE_EXTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICURVE_BASE_EXTRepository;
        }
    }
 
	public partial class CURVE_CWRService : BaseService<CURVE_CWR>,ICURVE_CWRService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICURVE_CWRRepository;
        }
    }
 
	public partial class CURVE_PICService : BaseService<CURVE_PIC>,ICURVE_PICService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICURVE_PICRepository;
        }
    }
 
	public partial class CURVE_PSNService : BaseService<CURVE_PSN>,ICURVE_PSNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICURVE_PSNRepository;
        }
    }
 
	public partial class CURVE_RAILService : BaseService<CURVE_RAIL>,ICURVE_RAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICURVE_RAILRepository;
        }
    }
 
	public partial class CURVE_RAILWEARService : BaseService<CURVE_RAILWEAR>,ICURVE_RAILWEARService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ICURVE_RAILWEARRepository;
        }
    }
 
	public partial class DR_IDX_DOC_CONTENT_IService : BaseService<DR_IDX_DOC_CONTENT_I>,IDR_IDX_DOC_CONTENT_IService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IDR_IDX_DOC_CONTENT_IRepository;
        }
    }
 
	public partial class DR_IDX_DOC_CONTENT_KService : BaseService<DR_IDX_DOC_CONTENT_K>,IDR_IDX_DOC_CONTENT_KService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IDR_IDX_DOC_CONTENT_KRepository;
        }
    }
 
	public partial class DR_IDX_DOC_CONTENT_NService : BaseService<DR_IDX_DOC_CONTENT_N>,IDR_IDX_DOC_CONTENT_NService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IDR_IDX_DOC_CONTENT_NRepository;
        }
    }
 
	public partial class DR_IDX_DOC_CONTENT_RService : BaseService<DR_IDX_DOC_CONTENT_R>,IDR_IDX_DOC_CONTENT_RService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IDR_IDX_DOC_CONTENT_RRepository;
        }
    }
 
	public partial class EMERGENCY_MERCYService : BaseService<EMERGENCY_MERCY>,IEMERGENCY_MERCYService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IEMERGENCY_MERCYRepository;
        }
    }
 
	public partial class EMERGENCY_RECService : BaseService<EMERGENCY_REC>,IEMERGENCY_RECService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IEMERGENCY_RECRepository;
        }
    }
 
	public partial class EMERGENCY_REC_FILEService : BaseService<EMERGENCY_REC_FILE>,IEMERGENCY_REC_FILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IEMERGENCY_REC_FILERepository;
        }
    }
 
	public partial class EMERGENCY_REC_PHOTOService : BaseService<EMERGENCY_REC_PHOTO>,IEMERGENCY_REC_PHOTOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IEMERGENCY_REC_PHOTORepository;
        }
    }
 
	public partial class EMERGENCY_RESCUEService : BaseService<EMERGENCY_RESCUE>,IEMERGENCY_RESCUEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IEMERGENCY_RESCUERepository;
        }
    }
 
	public partial class EMERGENCY_RESCUE_TOOLService : BaseService<EMERGENCY_RESCUE_TOOL>,IEMERGENCY_RESCUE_TOOLService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IEMERGENCY_RESCUE_TOOLRepository;
        }
    }
 
	public partial class EMERGENCY_RULESService : BaseService<EMERGENCY_RULES>,IEMERGENCY_RULESService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IEMERGENCY_RULESRepository;
        }
    }
 
	public partial class EMERGENCY_TALENT_POOLService : BaseService<EMERGENCY_TALENT_POOL>,IEMERGENCY_TALENT_POOLService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IEMERGENCY_TALENT_POOLRepository;
        }
    }
 
	public partial class EMERGENCY_VIECHLEService : BaseService<EMERGENCY_VIECHLE>,IEMERGENCY_VIECHLEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IEMERGENCY_VIECHLERepository;
        }
    }
 
	public partial class ENFORCEMENT_BDATAService : BaseService<ENFORCEMENT_BDATA>,IENFORCEMENT_BDATAService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IENFORCEMENT_BDATARepository;
        }
    }
 
	public partial class ENFORCEMENT_BDATA_ONLINEService : BaseService<ENFORCEMENT_BDATA_ONLINE>,IENFORCEMENT_BDATA_ONLINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IENFORCEMENT_BDATA_ONLINERepository;
        }
    }
 
	public partial class ENFORCEMENT_FILEService : BaseService<ENFORCEMENT_FILE>,IENFORCEMENT_FILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IENFORCEMENT_FILERepository;
        }
    }
 
	public partial class FIVET_INFOService : BaseService<FIVET_INFO>,IFIVET_INFOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IFIVET_INFORepository;
        }
    }
 
	public partial class FIVET_INFO_FILEService : BaseService<FIVET_INFO_FILE>,IFIVET_INFO_FILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IFIVET_INFO_FILERepository;
        }
    }
 
	public partial class FIVET_INFO_PHOTOService : BaseService<FIVET_INFO_PHOTO>,IFIVET_INFO_PHOTOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IFIVET_INFO_PHOTORepository;
        }
    }
 
	public partial class FIVET_INFO_TYPEService : BaseService<FIVET_INFO_TYPE>,IFIVET_INFO_TYPEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IFIVET_INFO_TYPERepository;
        }
    }
 
	public partial class FIVET_INFO_VIDEOService : BaseService<FIVET_INFO_VIDEO>,IFIVET_INFO_VIDEOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IFIVET_INFO_VIDEORepository;
        }
    }
 
	public partial class FLOODPOINTService : BaseService<FLOODPOINT>,IFLOODPOINTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IFLOODPOINTRepository;
        }
    }
 
	public partial class FLOW_BASEService : BaseService<FLOW_BASE>,IFLOW_BASEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IFLOW_BASERepository;
        }
    }
 
	public partial class FLOW_JOBService : BaseService<FLOW_JOB>,IFLOW_JOBService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IFLOW_JOBRepository;
        }
    }
 
	public partial class FLOW_STEPService : BaseService<FLOW_STEP>,IFLOW_STEPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IFLOW_STEPRepository;
        }
    }
 
	public partial class GATE_BDATA_CARDService : BaseService<GATE_BDATA_CARD>,IGATE_BDATA_CARDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_BDATA_CARDRepository;
        }
    }
 
	public partial class GATE_BDATA_CLIENTService : BaseService<GATE_BDATA_CLIENT>,IGATE_BDATA_CLIENTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_BDATA_CLIENTRepository;
        }
    }
 
	public partial class GATE_BDATA_DICService : BaseService<GATE_BDATA_DIC>,IGATE_BDATA_DICService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_BDATA_DICRepository;
        }
    }
 
	public partial class GATE_BDATA_GATEService : BaseService<GATE_BDATA_GATE>,IGATE_BDATA_GATEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_BDATA_GATERepository;
        }
    }
 
	public partial class GATE_BDATA_LIMITService : BaseService<GATE_BDATA_LIMIT>,IGATE_BDATA_LIMITService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_BDATA_LIMITRepository;
        }
    }
 
	public partial class GATE_BDATA_SKYLIGHTService : BaseService<GATE_BDATA_SKYLIGHT>,IGATE_BDATA_SKYLIGHTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_BDATA_SKYLIGHTRepository;
        }
    }
 
	public partial class GATE_BDATA_TOOLService : BaseService<GATE_BDATA_TOOL>,IGATE_BDATA_TOOLService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_BDATA_TOOLRepository;
        }
    }
 
	public partial class GATE_DEPT_MAPService : BaseService<GATE_DEPT_MAP>,IGATE_DEPT_MAPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_DEPT_MAPRepository;
        }
    }
 
	public partial class GATE_GATEMNG_AUTHHISTORYService : BaseService<GATE_GATEMNG_AUTHHISTORY>,IGATE_GATEMNG_AUTHHISTORYService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_GATEMNG_AUTHHISTORYRepository;
        }
    }
 
	public partial class GATE_GATEMNG_AUTHORIZATIONService : BaseService<GATE_GATEMNG_AUTHORIZATION>,IGATE_GATEMNG_AUTHORIZATIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_GATEMNG_AUTHORIZATIONRepository;
        }
    }
 
	public partial class GATE_GATEMNG_CARDLISTService : BaseService<GATE_GATEMNG_CARDLIST>,IGATE_GATEMNG_CARDLISTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_GATEMNG_CARDLISTRepository;
        }
    }
 
	public partial class GATE_GATEMNG_INGATEService : BaseService<GATE_GATEMNG_INGATE>,IGATE_GATEMNG_INGATEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_GATEMNG_INGATERepository;
        }
    }
 
	public partial class GATE_GATEMNG_INOUTService : BaseService<GATE_GATEMNG_INOUT>,IGATE_GATEMNG_INOUTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_GATEMNG_INOUTRepository;
        }
    }
 
	public partial class GATE_GATEMNG_INOUTHISService : BaseService<GATE_GATEMNG_INOUTHIS>,IGATE_GATEMNG_INOUTHISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_GATEMNG_INOUTHISRepository;
        }
    }
 
	public partial class GATE_GATEMNG_LASTCARDLISTService : BaseService<GATE_GATEMNG_LASTCARDLIST>,IGATE_GATEMNG_LASTCARDLISTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_GATEMNG_LASTCARDLISTRepository;
        }
    }
 
	public partial class GATE_GATEMNG_LASTSTATEService : BaseService<GATE_GATEMNG_LASTSTATE>,IGATE_GATEMNG_LASTSTATEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_GATEMNG_LASTSTATERepository;
        }
    }
 
	public partial class GATE_GATEMNG_LONGDISHISTORYService : BaseService<GATE_GATEMNG_LONGDISHISTORY>,IGATE_GATEMNG_LONGDISHISTORYService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_GATEMNG_LONGDISHISTORYRepository;
        }
    }
 
	public partial class GATE_GATEMNG_STATEService : BaseService<GATE_GATEMNG_STATE>,IGATE_GATEMNG_STATEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_GATEMNG_STATERepository;
        }
    }
 
	public partial class GATE_GATEMNG_WARNINGService : BaseService<GATE_GATEMNG_WARNING>,IGATE_GATEMNG_WARNINGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_GATEMNG_WARNINGRepository;
        }
    }
 
	public partial class GATE_JOB_PLANService : BaseService<GATE_JOB_PLAN>,IGATE_JOB_PLANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_JOB_PLANRepository;
        }
    }
 
	public partial class GATE_SEND_MSGService : BaseService<GATE_SEND_MSG>,IGATE_SEND_MSGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_SEND_MSGRepository;
        }
    }
 
	public partial class GATE_SEND_PHONENOService : BaseService<GATE_SEND_PHONENO>,IGATE_SEND_PHONENOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IGATE_SEND_PHONENORepository;
        }
    }
 
	public partial class HEART_BROADCASTService : BaseService<HEART_BROADCAST>,IHEART_BROADCASTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHEART_BROADCASTRepository;
        }
    }
 
	public partial class HEART_BROADCAST_HISService : BaseService<HEART_BROADCAST_HIS>,IHEART_BROADCAST_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHEART_BROADCAST_HISRepository;
        }
    }
 
	public partial class HEART_DG_DIS_PHONEService : BaseService<HEART_DG_DIS_PHONE>,IHEART_DG_DIS_PHONEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHEART_DG_DIS_PHONERepository;
        }
    }
 
	public partial class HEART_DG_VOLTAGE_SENDService : BaseService<HEART_DG_VOLTAGE_SEND>,IHEART_DG_VOLTAGE_SENDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHEART_DG_VOLTAGE_SENDRepository;
        }
    }
 
	public partial class HEART_DG_WAVEService : BaseService<HEART_DG_WAVE>,IHEART_DG_WAVEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHEART_DG_WAVERepository;
        }
    }
 
	public partial class HEART_DG_WAVE_HEADService : BaseService<HEART_DG_WAVE_HEAD>,IHEART_DG_WAVE_HEADService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHEART_DG_WAVE_HEADRepository;
        }
    }
 
	public partial class HEART_DG_WEBService : BaseService<HEART_DG_WEB>,IHEART_DG_WEBService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHEART_DG_WEBRepository;
        }
    }
 
	public partial class HEART_MESSAGEService : BaseService<HEART_MESSAGE>,IHEART_MESSAGEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHEART_MESSAGERepository;
        }
    }
 
	public partial class HEART_RECENT_SAService : BaseService<HEART_RECENT_SA>,IHEART_RECENT_SAService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHEART_RECENT_SARepository;
        }
    }
 
	public partial class HIK_PIC_INFOService : BaseService<HIK_PIC_INFO>,IHIK_PIC_INFOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHIK_PIC_INFORepository;
        }
    }
 
	public partial class HRAIL_BALLASTService : BaseService<HRAIL_BALLAST>,IHRAIL_BALLASTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_BALLASTRepository;
        }
    }
 
	public partial class HRAIL_CROSSINGService : BaseService<HRAIL_CROSSING>,IHRAIL_CROSSINGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_CROSSINGRepository;
        }
    }
 
	public partial class HRAIL_CURVEService : BaseService<HRAIL_CURVE>,IHRAIL_CURVEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_CURVERepository;
        }
    }
 
	public partial class HRAIL_DEPT_STATIONService : BaseService<HRAIL_DEPT_STATION>,IHRAIL_DEPT_STATIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_DEPT_STATIONRepository;
        }
    }
 
	public partial class HRAIL_LINEUNITService : BaseService<HRAIL_LINEUNIT>,IHRAIL_LINEUNITService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_LINEUNITRepository;
        }
    }
 
	public partial class HRAIL_PARA_JOBITEMService : BaseService<HRAIL_PARA_JOBITEM>,IHRAIL_PARA_JOBITEMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PARA_JOBITEMRepository;
        }
    }
 
	public partial class HRAIL_PARA_PROITEMService : BaseService<HRAIL_PARA_PROITEM>,IHRAIL_PARA_PROITEMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PARA_PROITEMRepository;
        }
    }
 
	public partial class HRAIL_PARA_PROITEM_SCOREService : BaseService<HRAIL_PARA_PROITEM_SCORE>,IHRAIL_PARA_PROITEM_SCOREService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PARA_PROITEM_SCORERepository;
        }
    }
 
	public partial class HRAIL_PLANService : BaseService<HRAIL_PLAN>,IHRAIL_PLANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PLANRepository;
        }
    }
 
	public partial class HRAIL_PLAN_EMPService : BaseService<HRAIL_PLAN_EMP>,IHRAIL_PLAN_EMPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PLAN_EMPRepository;
        }
    }
 
	public partial class HRAIL_PLAN_FILEService : BaseService<HRAIL_PLAN_FILE>,IHRAIL_PLAN_FILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PLAN_FILERepository;
        }
    }
 
	public partial class HRAIL_PLAN_FLOWService : BaseService<HRAIL_PLAN_FLOW>,IHRAIL_PLAN_FLOWService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PLAN_FLOWRepository;
        }
    }
 
	public partial class HRAIL_PLAN_ITEMService : BaseService<HRAIL_PLAN_ITEM>,IHRAIL_PLAN_ITEMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PLAN_ITEMRepository;
        }
    }
 
	public partial class HRAIL_PLAN_LOCService : BaseService<HRAIL_PLAN_LOC>,IHRAIL_PLAN_LOCService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PLAN_LOCRepository;
        }
    }
 
	public partial class HRAIL_PLAN_MATERIALService : BaseService<HRAIL_PLAN_MATERIAL>,IHRAIL_PLAN_MATERIALService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PLAN_MATERIALRepository;
        }
    }
 
	public partial class HRAIL_PLAN_PROBLEMService : BaseService<HRAIL_PLAN_PROBLEM>,IHRAIL_PLAN_PROBLEMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PLAN_PROBLEMRepository;
        }
    }
 
	public partial class HRAIL_PLAN_TOOLService : BaseService<HRAIL_PLAN_TOOL>,IHRAIL_PLAN_TOOLService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PLAN_TOOLRepository;
        }
    }
 
	public partial class HRAIL_PLAN_YEARService : BaseService<HRAIL_PLAN_YEAR>,IHRAIL_PLAN_YEARService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PLAN_YEARRepository;
        }
    }
 
	public partial class HRAIL_PROBLEMService : BaseService<HRAIL_PROBLEM>,IHRAIL_PROBLEMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PROBLEMRepository;
        }
    }
 
	public partial class HRAIL_PROBLEM_DNYService : BaseService<HRAIL_PROBLEM_DNY>,IHRAIL_PROBLEM_DNYService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PROBLEM_DNYRepository;
        }
    }
 
	public partial class HRAIL_PROBLEM_FILEService : BaseService<HRAIL_PROBLEM_FILE>,IHRAIL_PROBLEM_FILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_PROBLEM_FILERepository;
        }
    }
 
	public partial class HRAIL_RAILService : BaseService<HRAIL_RAIL>,IHRAIL_RAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_RAILRepository;
        }
    }
 
	public partial class HRAIL_SLOPEService : BaseService<HRAIL_SLOPE>,IHRAIL_SLOPEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_SLOPERepository;
        }
    }
 
	public partial class HRAIL_STARTMILEService : BaseService<HRAIL_STARTMILE>,IHRAIL_STARTMILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_STARTMILERepository;
        }
    }
 
	public partial class HRAIL_STATIONService : BaseService<HRAIL_STATION>,IHRAIL_STATIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_STATIONRepository;
        }
    }
 
	public partial class HRAIL_TQIService : BaseService<HRAIL_TQI>,IHRAIL_TQIService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_TQIRepository;
        }
    }
 
	public partial class HRAIL_TRACKService : BaseService<HRAIL_TRACK>,IHRAIL_TRACKService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_TRACKRepository;
        }
    }
 
	public partial class HRAIL_TURNOUTService : BaseService<HRAIL_TURNOUT>,IHRAIL_TURNOUTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_TURNOUTRepository;
        }
    }
 
	public partial class HRAIL_UNIT_VALService : BaseService<HRAIL_UNIT_VAL>,IHRAIL_UNIT_VALService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_UNIT_VALRepository;
        }
    }
 
	public partial class HRAIL_UNIT_VAL_DETAILService : BaseService<HRAIL_UNIT_VAL_DETAIL>,IHRAIL_UNIT_VAL_DETAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IHRAIL_UNIT_VAL_DETAILRepository;
        }
    }
 
	public partial class JOB_JOB_PLANService : BaseService<JOB_JOB_PLAN>,IJOB_JOB_PLANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_JOB_PLANRepository;
        }
    }
 
	public partial class JOB_MSG_BATCHREPLYService : BaseService<JOB_MSG_BATCHREPLY>,IJOB_MSG_BATCHREPLYService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_MSG_BATCHREPLYRepository;
        }
    }
 
	public partial class JOB_MSG_BATCHSENDService : BaseService<JOB_MSG_BATCHSEND>,IJOB_MSG_BATCHSENDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_MSG_BATCHSENDRepository;
        }
    }
 
	public partial class JOB_MSG_BATCHSENDPHOTOService : BaseService<JOB_MSG_BATCHSENDPHOTO>,IJOB_MSG_BATCHSENDPHOTOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_MSG_BATCHSENDPHOTORepository;
        }
    }
 
	public partial class JOB_PLANService : BaseService<JOB_PLAN>,IJOB_PLANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLANRepository;
        }
    }
 
	public partial class JOB_PLAN_ADDPASSENGER_TESTService : BaseService<JOB_PLAN_ADDPASSENGER_TEST>,IJOB_PLAN_ADDPASSENGER_TESTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_ADDPASSENGER_TESTRepository;
        }
    }
 
	public partial class JOB_PLAN_APPROVALService : BaseService<JOB_PLAN_APPROVAL>,IJOB_PLAN_APPROVALService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_APPROVALRepository;
        }
    }
 
	public partial class JOB_PLAN_BYTIMService : BaseService<JOB_PLAN_BYTIM>,IJOB_PLAN_BYTIMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_BYTIMRepository;
        }
    }
 
	public partial class JOB_PLAN_CONTROLService : BaseService<JOB_PLAN_CONTROL>,IJOB_PLAN_CONTROLService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_CONTROLRepository;
        }
    }
 
	public partial class JOB_PLAN_DELINGHA_FILLService : BaseService<JOB_PLAN_DELINGHA_FILL>,IJOB_PLAN_DELINGHA_FILLService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_DELINGHA_FILLRepository;
        }
    }
 
	public partial class JOB_PLAN_DELINGHA_FILL_DETAILService : BaseService<JOB_PLAN_DELINGHA_FILL_DETAIL>,IJOB_PLAN_DELINGHA_FILL_DETAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_DELINGHA_FILL_DETAILRepository;
        }
    }
 
	public partial class JOB_PLAN_DELINGHA_MONTHService : BaseService<JOB_PLAN_DELINGHA_MONTH>,IJOB_PLAN_DELINGHA_MONTHService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_DELINGHA_MONTHRepository;
        }
    }
 
	public partial class JOB_PLAN_DELINGHA_WEEKService : BaseService<JOB_PLAN_DELINGHA_WEEK>,IJOB_PLAN_DELINGHA_WEEKService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_DELINGHA_WEEKRepository;
        }
    }
 
	public partial class JOB_PLAN_EQUIPMENTService : BaseService<JOB_PLAN_EQUIPMENT>,IJOB_PLAN_EQUIPMENTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_EQUIPMENTRepository;
        }
    }
 
	public partial class JOB_PLAN_LINEService : BaseService<JOB_PLAN_LINE>,IJOB_PLAN_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_LINERepository;
        }
    }
 
	public partial class JOB_PLAN_LINE_EQUIANDTIMService : BaseService<JOB_PLAN_LINE_EQUIANDTIM>,IJOB_PLAN_LINE_EQUIANDTIMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_LINE_EQUIANDTIMRepository;
        }
    }
 
	public partial class JOB_PLAN_LOOKOUTService : BaseService<JOB_PLAN_LOOKOUT>,IJOB_PLAN_LOOKOUTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_LOOKOUTRepository;
        }
    }
 
	public partial class JOB_PLAN_MEMBERPHONE_MAPService : BaseService<JOB_PLAN_MEMBERPHONE_MAP>,IJOB_PLAN_MEMBERPHONE_MAPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_MEMBERPHONE_MAPRepository;
        }
    }
 
	public partial class JOB_PLAN_OLDService : BaseService<JOB_PLAN_OLD>,IJOB_PLAN_OLDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_OLDRepository;
        }
    }
 
	public partial class JOB_PLAN_PHONE_USERService : BaseService<JOB_PLAN_PHONE_USER>,IJOB_PLAN_PHONE_USERService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_PHONE_USERRepository;
        }
    }
 
	public partial class JOB_PLAN_SAFEService : BaseService<JOB_PLAN_SAFE>,IJOB_PLAN_SAFEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_SAFERepository;
        }
    }
 
	public partial class JOB_PLAN_TRAINService : BaseService<JOB_PLAN_TRAIN>,IJOB_PLAN_TRAINService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_TRAINRepository;
        }
    }
 
	public partial class JOB_PLAN_TYPEService : BaseService<JOB_PLAN_TYPE>,IJOB_PLAN_TYPEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_TYPERepository;
        }
    }
 
	public partial class JOB_PLAN_UPDOWNService : BaseService<JOB_PLAN_UPDOWN>,IJOB_PLAN_UPDOWNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_UPDOWNRepository;
        }
    }
 
	public partial class JOB_PLAN_UPDOWNHISService : BaseService<JOB_PLAN_UPDOWNHIS>,IJOB_PLAN_UPDOWNHISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_UPDOWNHISRepository;
        }
    }
 
	public partial class JOB_PLAN_WARNPHONESETService : BaseService<JOB_PLAN_WARNPHONESET>,IJOB_PLAN_WARNPHONESETService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_WARNPHONESETRepository;
        }
    }
 
	public partial class JOB_PLAN_WARNPOSSETService : BaseService<JOB_PLAN_WARNPOSSET>,IJOB_PLAN_WARNPOSSETService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLAN_WARNPOSSETRepository;
        }
    }
 
	public partial class JOB_PLANCONTROL_COMMANDService : BaseService<JOB_PLANCONTROL_COMMAND>,IJOB_PLANCONTROL_COMMANDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_PLANCONTROL_COMMANDRepository;
        }
    }
 
	public partial class JOB_WARNService : BaseService<JOB_WARN>,IJOB_WARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IJOB_WARNRepository;
        }
    }
 
	public partial class LEDGER_BIGEQUI_TECHPARAMService : BaseService<LEDGER_BIGEQUI_TECHPARAM>,ILEDGER_BIGEQUI_TECHPARAMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_BIGEQUI_TECHPARAMRepository;
        }
    }
 
	public partial class LEDGER_DICT_INTERPHONEService : BaseService<LEDGER_DICT_INTERPHONE>,ILEDGER_DICT_INTERPHONEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_DICT_INTERPHONERepository;
        }
    }
 
	public partial class LEDGER_DICT_LARGEMACHINERYService : BaseService<LEDGER_DICT_LARGEMACHINERY>,ILEDGER_DICT_LARGEMACHINERYService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_DICT_LARGEMACHINERYRepository;
        }
    }
 
	public partial class LEDGER_DICT_MACHINETOOLService : BaseService<LEDGER_DICT_MACHINETOOL>,ILEDGER_DICT_MACHINETOOLService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_DICT_MACHINETOOLRepository;
        }
    }
 
	public partial class LEDGER_DICT_MECHANICALVEHICLEService : BaseService<LEDGER_DICT_MECHANICALVEHICLE>,ILEDGER_DICT_MECHANICALVEHICLEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_DICT_MECHANICALVEHICLERepository;
        }
    }
 
	public partial class LEDGER_DICT_ROADVEHICLEService : BaseService<LEDGER_DICT_ROADVEHICLE>,ILEDGER_DICT_ROADVEHICLEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_DICT_ROADVEHICLERepository;
        }
    }
 
	public partial class LEDGER_DICT_TRAFFICVEHICLEService : BaseService<LEDGER_DICT_TRAFFICVEHICLE>,ILEDGER_DICT_TRAFFICVEHICLEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_DICT_TRAFFICVEHICLERepository;
        }
    }
 
	public partial class LEDGER_INTERPHONEService : BaseService<LEDGER_INTERPHONE>,ILEDGER_INTERPHONEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_INTERPHONERepository;
        }
    }
 
	public partial class LEDGER_LARGE_MACHINERYService : BaseService<LEDGER_LARGE_MACHINERY>,ILEDGER_LARGE_MACHINERYService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_LARGE_MACHINERYRepository;
        }
    }
 
	public partial class LEDGER_LEVELCROSS_INFOService : BaseService<LEDGER_LEVELCROSS_INFO>,ILEDGER_LEVELCROSS_INFOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_LEVELCROSS_INFORepository;
        }
    }
 
	public partial class LEDGER_LEVELCROSS_PIPE_LINEService : BaseService<LEDGER_LEVELCROSS_PIPE_LINE>,ILEDGER_LEVELCROSS_PIPE_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_LEVELCROSS_PIPE_LINERepository;
        }
    }
 
	public partial class LEDGER_LEVELCROSS_REPAIR_LINEService : BaseService<LEDGER_LEVELCROSS_REPAIR_LINE>,ILEDGER_LEVELCROSS_REPAIR_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_LEVELCROSS_REPAIR_LINERepository;
        }
    }
 
	public partial class LEDGER_MACHINE_TOOLService : BaseService<LEDGER_MACHINE_TOOL>,ILEDGER_MACHINE_TOOLService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_MACHINE_TOOLRepository;
        }
    }
 
	public partial class LEDGER_MECHANICAL_VEHICLEService : BaseService<LEDGER_MECHANICAL_VEHICLE>,ILEDGER_MECHANICAL_VEHICLEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_MECHANICAL_VEHICLERepository;
        }
    }
 
	public partial class LEDGER_RAIL_MATERIALService : BaseService<LEDGER_RAIL_MATERIAL>,ILEDGER_RAIL_MATERIALService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_RAIL_MATERIALRepository;
        }
    }
 
	public partial class LEDGER_RAILCAR_TECHPARAMService : BaseService<LEDGER_RAILCAR_TECHPARAM>,ILEDGER_RAILCAR_TECHPARAMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_RAILCAR_TECHPARAMRepository;
        }
    }
 
	public partial class LEDGER_ROAD_VEHICLEService : BaseService<LEDGER_ROAD_VEHICLE>,ILEDGER_ROAD_VEHICLEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_ROAD_VEHICLERepository;
        }
    }
 
	public partial class LEDGER_SMALLEQUI_TECHPARAMService : BaseService<LEDGER_SMALLEQUI_TECHPARAM>,ILEDGER_SMALLEQUI_TECHPARAMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_SMALLEQUI_TECHPARAMRepository;
        }
    }
 
	public partial class LEDGER_TRAFFIC_VEHICLESService : BaseService<LEDGER_TRAFFIC_VEHICLES>,ILEDGER_TRAFFIC_VEHICLESService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILEDGER_TRAFFIC_VEHICLESRepository;
        }
    }
 
	public partial class LKJ_ALLOW_SPEEDService : BaseService<LKJ_ALLOW_SPEED>,ILKJ_ALLOW_SPEEDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILKJ_ALLOW_SPEEDRepository;
        }
    }
 
	public partial class LKJ_BRIDGEService : BaseService<LKJ_BRIDGE>,ILKJ_BRIDGEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILKJ_BRIDGERepository;
        }
    }
 
	public partial class LKJ_BROKEN_CHAINService : BaseService<LKJ_BROKEN_CHAIN>,ILKJ_BROKEN_CHAINService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILKJ_BROKEN_CHAINRepository;
        }
    }
 
	public partial class LKJ_CROSSINGService : BaseService<LKJ_CROSSING>,ILKJ_CROSSINGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILKJ_CROSSINGRepository;
        }
    }
 
	public partial class LKJ_CURVEService : BaseService<LKJ_CURVE>,ILKJ_CURVEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILKJ_CURVERepository;
        }
    }
 
	public partial class LKJ_LINE_NAMEService : BaseService<LKJ_LINE_NAME>,ILKJ_LINE_NAMEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILKJ_LINE_NAMERepository;
        }
    }
 
	public partial class LKJ_MAIN_TRACK_MILEAGEService : BaseService<LKJ_MAIN_TRACK_MILEAGE>,ILKJ_MAIN_TRACK_MILEAGEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILKJ_MAIN_TRACK_MILEAGERepository;
        }
    }
 
	public partial class LKJ_ROAD_FORKService : BaseService<LKJ_ROAD_FORK>,ILKJ_ROAD_FORKService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILKJ_ROAD_FORKRepository;
        }
    }
 
	public partial class LKJ_SLOPEService : BaseService<LKJ_SLOPE>,ILKJ_SLOPEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILKJ_SLOPERepository;
        }
    }
 
	public partial class LKJ_STATIONService : BaseService<LKJ_STATION>,ILKJ_STATIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILKJ_STATIONRepository;
        }
    }
 
	public partial class LKJ_TRACKService : BaseService<LKJ_TRACK>,ILKJ_TRACKService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILKJ_TRACKRepository;
        }
    }
 
	public partial class LKJ_TUNNELService : BaseService<LKJ_TUNNEL>,ILKJ_TUNNELService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ILKJ_TUNNELRepository;
        }
    }
 
	public partial class MATERIAL_BDATE_DICService : BaseService<MATERIAL_BDATE_DIC>,IMATERIAL_BDATE_DICService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IMATERIAL_BDATE_DICRepository;
        }
    }
 
	public partial class MATERIAL_BDATE_MATERIALNAMEService : BaseService<MATERIAL_BDATE_MATERIALNAME>,IMATERIAL_BDATE_MATERIALNAMEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IMATERIAL_BDATE_MATERIALNAMERepository;
        }
    }
 
	public partial class MATERIAL_INOUT_BILLService : BaseService<MATERIAL_INOUT_BILL>,IMATERIAL_INOUT_BILLService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IMATERIAL_INOUT_BILLRepository;
        }
    }
 
	public partial class MATERIAL_INOUT_BILL_DETAILService : BaseService<MATERIAL_INOUT_BILL_DETAIL>,IMATERIAL_INOUT_BILL_DETAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IMATERIAL_INOUT_BILL_DETAILRepository;
        }
    }
 
	public partial class MATERIAL_MATERIALMNGService : BaseService<MATERIAL_MATERIALMNG>,IMATERIAL_MATERIALMNGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IMATERIAL_MATERIALMNGRepository;
        }
    }
 
	public partial class MATERIAL_MONSURPRUSService : BaseService<MATERIAL_MONSURPRUS>,IMATERIAL_MONSURPRUSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IMATERIAL_MONSURPRUSRepository;
        }
    }
 
	public partial class OIL_BDATA_CURVEService : BaseService<OIL_BDATA_CURVE>,IOIL_BDATA_CURVEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IOIL_BDATA_CURVERepository;
        }
    }
 
	public partial class OIL_BDATA_DEVICEService : BaseService<OIL_BDATA_DEVICE>,IOIL_BDATA_DEVICEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IOIL_BDATA_DEVICERepository;
        }
    }
 
	public partial class OIL_BDATA_OPService : BaseService<OIL_BDATA_OP>,IOIL_BDATA_OPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IOIL_BDATA_OPRepository;
        }
    }
 
	public partial class OIL_RECORD_CHECKService : BaseService<OIL_RECORD_CHECK>,IOIL_RECORD_CHECKService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IOIL_RECORD_CHECKRepository;
        }
    }
 
	public partial class OIL_RECORD_OILService : BaseService<OIL_RECORD_OIL>,IOIL_RECORD_OILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IOIL_RECORD_OILRepository;
        }
    }
 
	public partial class PHONEDICService : BaseService<PHONEDIC>,IPHONEDICService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IPHONEDICRepository;
        }
    }
 
	public partial class PROTECTEDNET_BDATA_DEVICEService : BaseService<PROTECTEDNET_BDATA_DEVICE>,IPROTECTEDNET_BDATA_DEVICEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IPROTECTEDNET_BDATA_DEVICERepository;
        }
    }
 
	public partial class PROTECTEDNET_RECORD_CHECKService : BaseService<PROTECTEDNET_RECORD_CHECK>,IPROTECTEDNET_RECORD_CHECKService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IPROTECTEDNET_RECORD_CHECKRepository;
        }
    }
 
	public partial class PROTECTEDNET_RECORD_WARNService : BaseService<PROTECTEDNET_RECORD_WARN>,IPROTECTEDNET_RECORD_WARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IPROTECTEDNET_RECORD_WARNRepository;
        }
    }
 
	public partial class PROTECTEDNET_VIDEO_FILEService : BaseService<PROTECTEDNET_VIDEO_FILE>,IPROTECTEDNET_VIDEO_FILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IPROTECTEDNET_VIDEO_FILERepository;
        }
    }
 
	public partial class RAIL_BDATA_HOSTService : BaseService<RAIL_BDATA_HOST>,IRAIL_BDATA_HOSTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_BDATA_HOSTRepository;
        }
    }
 
	public partial class RAIL_BDATA_POINTService : BaseService<RAIL_BDATA_POINT>,IRAIL_BDATA_POINTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_BDATA_POINTRepository;
        }
    }
 
	public partial class RAIL_BDATA_SENDPHONENOService : BaseService<RAIL_BDATA_SENDPHONENO>,IRAIL_BDATA_SENDPHONENOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_BDATA_SENDPHONENORepository;
        }
    }
 
	public partial class RAIL_CARRIERBDATA_POINTService : BaseService<RAIL_CARRIERBDATA_POINT>,IRAIL_CARRIERBDATA_POINTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_CARRIERBDATA_POINTRepository;
        }
    }
 
	public partial class RAIL_CARRIERBDATA_SECTIONService : BaseService<RAIL_CARRIERBDATA_SECTION>,IRAIL_CARRIERBDATA_SECTIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_CARRIERBDATA_SECTIONRepository;
        }
    }
 
	public partial class RAIL_CARRIERDEVICE_STATUSService : BaseService<RAIL_CARRIERDEVICE_STATUS>,IRAIL_CARRIERDEVICE_STATUSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_CARRIERDEVICE_STATUSRepository;
        }
    }
 
	public partial class RAIL_CARRIERDEVICE_WARNService : BaseService<RAIL_CARRIERDEVICE_WARN>,IRAIL_CARRIERDEVICE_WARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_CARRIERDEVICE_WARNRepository;
        }
    }
 
	public partial class RAIL_CARRIERRECORD_POINTService : BaseService<RAIL_CARRIERRECORD_POINT>,IRAIL_CARRIERRECORD_POINTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_CARRIERRECORD_POINTRepository;
        }
    }
 
	public partial class RAIL_CARRIERRECORD_WARNService : BaseService<RAIL_CARRIERRECORD_WARN>,IRAIL_CARRIERRECORD_WARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_CARRIERRECORD_WARNRepository;
        }
    }
 
	public partial class RAIL_CARRIERRECORD_WARN_FINALService : BaseService<RAIL_CARRIERRECORD_WARN_FINAL>,IRAIL_CARRIERRECORD_WARN_FINALService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_CARRIERRECORD_WARN_FINALRepository;
        }
    }
 
	public partial class RAIL_CARRIERSECTION_LASTWARNService : BaseService<RAIL_CARRIERSECTION_LASTWARN>,IRAIL_CARRIERSECTION_LASTWARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_CARRIERSECTION_LASTWARNRepository;
        }
    }
 
	public partial class RAIL_CARRIERSECTION_WARNService : BaseService<RAIL_CARRIERSECTION_WARN>,IRAIL_CARRIERSECTION_WARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_CARRIERSECTION_WARNRepository;
        }
    }
 
	public partial class RAIL_CARRIERWAVE_LOGService : BaseService<RAIL_CARRIERWAVE_LOG>,IRAIL_CARRIERWAVE_LOGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_CARRIERWAVE_LOGRepository;
        }
    }
 
	public partial class RAIL_CARRIERWAVE_POINTService : BaseService<RAIL_CARRIERWAVE_POINT>,IRAIL_CARRIERWAVE_POINTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_CARRIERWAVE_POINTRepository;
        }
    }
 
	public partial class RAIL_COMMService : BaseService<RAIL_COMM>,IRAIL_COMMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_COMMRepository;
        }
    }
 
	public partial class RAIL_DEVICE_RECORDService : BaseService<RAIL_DEVICE_RECORD>,IRAIL_DEVICE_RECORDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_DEVICE_RECORDRepository;
        }
    }
 
	public partial class RAIL_RECORD_HOSTService : BaseService<RAIL_RECORD_HOST>,IRAIL_RECORD_HOSTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_RECORD_HOSTRepository;
        }
    }
 
	public partial class RAIL_RECORD_POINTService : BaseService<RAIL_RECORD_POINT>,IRAIL_RECORD_POINTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_RECORD_POINTRepository;
        }
    }
 
	public partial class RAIL_RECORD_SAMPWARNService : BaseService<RAIL_RECORD_SAMPWARN>,IRAIL_RECORD_SAMPWARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_RECORD_SAMPWARNRepository;
        }
    }
 
	public partial class RAIL_RECORD_WARNService : BaseService<RAIL_RECORD_WARN>,IRAIL_RECORD_WARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_RECORD_WARNRepository;
        }
    }
 
	public partial class RAIL_SECTION_LINEService : BaseService<RAIL_SECTION_LINE>,IRAIL_SECTION_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_SECTION_LINERepository;
        }
    }
 
	public partial class RAIL_SOUNDBDATA_POINTService : BaseService<RAIL_SOUNDBDATA_POINT>,IRAIL_SOUNDBDATA_POINTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_SOUNDBDATA_POINTRepository;
        }
    }
 
	public partial class RAIL_SOUNDBDATA_SECTIONService : BaseService<RAIL_SOUNDBDATA_SECTION>,IRAIL_SOUNDBDATA_SECTIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_SOUNDBDATA_SECTIONRepository;
        }
    }
 
	public partial class RAIL_SOUNDDEVICE_LASTWARNService : BaseService<RAIL_SOUNDDEVICE_LASTWARN>,IRAIL_SOUNDDEVICE_LASTWARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_SOUNDDEVICE_LASTWARNRepository;
        }
    }
 
	public partial class RAIL_SOUNDDEVICE_WARNService : BaseService<RAIL_SOUNDDEVICE_WARN>,IRAIL_SOUNDDEVICE_WARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_SOUNDDEVICE_WARNRepository;
        }
    }
 
	public partial class RAIL_SOUNDRECEIVE_ORIDATAService : BaseService<RAIL_SOUNDRECEIVE_ORIDATA>,IRAIL_SOUNDRECEIVE_ORIDATAService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_SOUNDRECEIVE_ORIDATARepository;
        }
    }
 
	public partial class RAIL_SOUNDRECORD_LASTWARNService : BaseService<RAIL_SOUNDRECORD_LASTWARN>,IRAIL_SOUNDRECORD_LASTWARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_SOUNDRECORD_LASTWARNRepository;
        }
    }
 
	public partial class RAIL_SOUNDRECORD_POINTService : BaseService<RAIL_SOUNDRECORD_POINT>,IRAIL_SOUNDRECORD_POINTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_SOUNDRECORD_POINTRepository;
        }
    }
 
	public partial class RAIL_SOUNDRECORD_WARNService : BaseService<RAIL_SOUNDRECORD_WARN>,IRAIL_SOUNDRECORD_WARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_SOUNDRECORD_WARNRepository;
        }
    }
 
	public partial class RAIL_SOUNDRECORD_WARN_FINALService : BaseService<RAIL_SOUNDRECORD_WARN_FINAL>,IRAIL_SOUNDRECORD_WARN_FINALService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_SOUNDRECORD_WARN_FINALRepository;
        }
    }
 
	public partial class RAIL_SOUNDSECTION_LASTWARNService : BaseService<RAIL_SOUNDSECTION_LASTWARN>,IRAIL_SOUNDSECTION_LASTWARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_SOUNDSECTION_LASTWARNRepository;
        }
    }
 
	public partial class RAIL_SOUNDSECTION_WARNService : BaseService<RAIL_SOUNDSECTION_WARN>,IRAIL_SOUNDSECTION_WARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_SOUNDSECTION_WARNRepository;
        }
    }
 
	public partial class RAIL_SOUNDWAVE_LOGService : BaseService<RAIL_SOUNDWAVE_LOG>,IRAIL_SOUNDWAVE_LOGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIL_SOUNDWAVE_LOGRepository;
        }
    }
 
	public partial class RAILCAR_BDATAService : BaseService<RAILCAR_BDATA>,IRAILCAR_BDATAService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAILCAR_BDATARepository;
        }
    }
 
	public partial class RAILCAR_BDATA_ONLINEService : BaseService<RAILCAR_BDATA_ONLINE>,IRAILCAR_BDATA_ONLINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAILCAR_BDATA_ONLINERepository;
        }
    }
 
	public partial class RAILCAR_FILEService : BaseService<RAILCAR_FILE>,IRAILCAR_FILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAILCAR_FILERepository;
        }
    }
 
	public partial class RAIN_DEVICEService : BaseService<RAIN_DEVICE>,IRAIN_DEVICEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIN_DEVICERepository;
        }
    }
 
	public partial class RAIN_DEVICE_PLANLOGService : BaseService<RAIN_DEVICE_PLANLOG>,IRAIN_DEVICE_PLANLOGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIN_DEVICE_PLANLOGRepository;
        }
    }
 
	public partial class RAIN_FLOOD_LABOURService : BaseService<RAIN_FLOOD_LABOUR>,IRAIN_FLOOD_LABOURService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIN_FLOOD_LABOURRepository;
        }
    }
 
	public partial class RAIN_FLOOD_RESERVE_PLANService : BaseService<RAIN_FLOOD_RESERVE_PLAN>,IRAIN_FLOOD_RESERVE_PLANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIN_FLOOD_RESERVE_PLANRepository;
        }
    }
 
	public partial class RAIN_FLOOD_STOCKService : BaseService<RAIN_FLOOD_STOCK>,IRAIN_FLOOD_STOCKService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIN_FLOOD_STOCKRepository;
        }
    }
 
	public partial class RAIN_FLOOD_STOCK_PHOTOService : BaseService<RAIN_FLOOD_STOCK_PHOTO>,IRAIN_FLOOD_STOCK_PHOTOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIN_FLOOD_STOCK_PHOTORepository;
        }
    }
 
	public partial class RAIN_PLANService : BaseService<RAIN_PLAN>,IRAIN_PLANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIN_PLANRepository;
        }
    }
 
	public partial class RAIN_PLAN_WARNService : BaseService<RAIN_PLAN_WARN>,IRAIN_PLAN_WARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIN_PLAN_WARNRepository;
        }
    }
 
	public partial class RAIN_SECTION_LINEService : BaseService<RAIN_SECTION_LINE>,IRAIN_SECTION_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRAIN_SECTION_LINERepository;
        }
    }
 
	public partial class REPAIR_ACCOUNTService : BaseService<REPAIR_ACCOUNT>,IREPAIR_ACCOUNTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IREPAIR_ACCOUNTRepository;
        }
    }
 
	public partial class REPAIR_OVERRUNService : BaseService<REPAIR_OVERRUN>,IREPAIR_OVERRUNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IREPAIR_OVERRUNRepository;
        }
    }
 
	public partial class RESCUE_LINEService : BaseService<RESCUE_LINE>,IRESCUE_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRESCUE_LINERepository;
        }
    }
 
	public partial class RESCUE_LINE_INFOService : BaseService<RESCUE_LINE_INFO>,IRESCUE_LINE_INFOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRESCUE_LINE_INFORepository;
        }
    }
 
	public partial class RESCUE_LINE_PHOTOService : BaseService<RESCUE_LINE_PHOTO>,IRESCUE_LINE_PHOTOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRESCUE_LINE_PHOTORepository;
        }
    }
 
	public partial class RESCUE_LINE_PORTService : BaseService<RESCUE_LINE_PORT>,IRESCUE_LINE_PORTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRESCUE_LINE_PORTRepository;
        }
    }
 
	public partial class ROADBED_ITEM_PARAService : BaseService<ROADBED_ITEM_PARA>,IROADBED_ITEM_PARAService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IROADBED_ITEM_PARARepository;
        }
    }
 
	public partial class ROADBED_KEYDISEASE_EVALUATEService : BaseService<ROADBED_KEYDISEASE_EVALUATE>,IROADBED_KEYDISEASE_EVALUATEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IROADBED_KEYDISEASE_EVALUATERepository;
        }
    }
 
	public partial class ROADBED_KEYDISEASE_PROService : BaseService<ROADBED_KEYDISEASE_PRO>,IROADBED_KEYDISEASE_PROService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IROADBED_KEYDISEASE_PRORepository;
        }
    }
 
	public partial class ROADBED_KEYDISEASE_PRO_HISService : BaseService<ROADBED_KEYDISEASE_PRO_HIS>,IROADBED_KEYDISEASE_PRO_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IROADBED_KEYDISEASE_PRO_HISRepository;
        }
    }
 
	public partial class ROADBED_KEYDISEASE_REPORTService : BaseService<ROADBED_KEYDISEASE_REPORT>,IROADBED_KEYDISEASE_REPORTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IROADBED_KEYDISEASE_REPORTRepository;
        }
    }
 
	public partial class RULE_BASE_DEPTService : BaseService<RULE_BASE_DEPT>,IRULE_BASE_DEPTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_BASE_DEPTRepository;
        }
    }
 
	public partial class RULE_BDATE_DICService : BaseService<RULE_BDATE_DIC>,IRULE_BDATE_DICService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_BDATE_DICRepository;
        }
    }
 
	public partial class RULE_DOCService : BaseService<RULE_DOC>,IRULE_DOCService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_DOCRepository;
        }
    }
 
	public partial class RULE_DOC_ITEMService : BaseService<RULE_DOC_ITEM>,IRULE_DOC_ITEMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_DOC_ITEMRepository;
        }
    }
 
	public partial class RULE_DOC_KEYWORDService : BaseService<RULE_DOC_KEYWORD>,IRULE_DOC_KEYWORDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_DOC_KEYWORDRepository;
        }
    }
 
	public partial class RULE_KEYWORDService : BaseService<RULE_KEYWORD>,IRULE_KEYWORDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_KEYWORDRepository;
        }
    }
 
	public partial class RULE_PARA_SCOREService : BaseService<RULE_PARA_SCORE>,IRULE_PARA_SCOREService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_PARA_SCORERepository;
        }
    }
 
	public partial class RULE_PARSE_MARKUPService : BaseService<RULE_PARSE_MARKUP>,IRULE_PARSE_MARKUPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_PARSE_MARKUPRepository;
        }
    }
 
	public partial class RULE_PARSE_MARKUP_MATCHService : BaseService<RULE_PARSE_MARKUP_MATCH>,IRULE_PARSE_MARKUP_MATCHService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_PARSE_MARKUP_MATCHRepository;
        }
    }
 
	public partial class RULE_PARSE_RESULTService : BaseService<RULE_PARSE_RESULT>,IRULE_PARSE_RESULTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_PARSE_RESULTRepository;
        }
    }
 
	public partial class RULE_PARSE_RESULT_REPORTService : BaseService<RULE_PARSE_RESULT_REPORT>,IRULE_PARSE_RESULT_REPORTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_PARSE_RESULT_REPORTRepository;
        }
    }
 
	public partial class RULE_PROBLEMService : BaseService<RULE_PROBLEM>,IRULE_PROBLEMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_PROBLEMRepository;
        }
    }
 
	public partial class RULE_PROBLEM_BLAMEService : BaseService<RULE_PROBLEM_BLAME>,IRULE_PROBLEM_BLAMEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_PROBLEM_BLAMERepository;
        }
    }
 
	public partial class RULE_PROBLEM_KEYWORDService : BaseService<RULE_PROBLEM_KEYWORD>,IRULE_PROBLEM_KEYWORDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_PROBLEM_KEYWORDRepository;
        }
    }
 
	public partial class RULE_PROBLEM_POSTService : BaseService<RULE_PROBLEM_POST>,IRULE_PROBLEM_POSTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_PROBLEM_POSTRepository;
        }
    }
 
	public partial class RULE_PROBLEM_PUBLISH_CONFIGERService : BaseService<RULE_PROBLEM_PUBLISH_CONFIGER>,IRULE_PROBLEM_PUBLISH_CONFIGERService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_PROBLEM_PUBLISH_CONFIGERRepository;
        }
    }
 
	public partial class RULE_PROBLEM_PUNISHService : BaseService<RULE_PROBLEM_PUNISH>,IRULE_PROBLEM_PUNISHService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_PROBLEM_PUNISHRepository;
        }
    }
 
	public partial class RULE_RESULT_CENSUSService : BaseService<RULE_RESULT_CENSUS>,IRULE_RESULT_CENSUSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_RESULT_CENSUSRepository;
        }
    }
 
	public partial class RULE_RESULT_PROTREND_TMPService : BaseService<RULE_RESULT_PROTREND_TMP>,IRULE_RESULT_PROTREND_TMPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IRULE_RESULT_PROTREND_TMPRepository;
        }
    }
 
	public partial class SCRIPT_SECTION_BRIDGETUNNELService : BaseService<SCRIPT_SECTION_BRIDGETUNNEL>,ISCRIPT_SECTION_BRIDGETUNNELService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPT_SECTION_BRIDGETUNNELRepository;
        }
    }
 
	public partial class SCRIPTS_LEADER_MONITOREService : BaseService<SCRIPTS_LEADER_MONITORE>,ISCRIPTS_LEADER_MONITOREService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_LEADER_MONITORERepository;
        }
    }
 
	public partial class SCRIPTS_MEMBER_ONLINEService : BaseService<SCRIPTS_MEMBER_ONLINE>,ISCRIPTS_MEMBER_ONLINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_MEMBER_ONLINERepository;
        }
    }
 
	public partial class SCRIPTS_SECTION_BADSIGNALService : BaseService<SCRIPTS_SECTION_BADSIGNAL>,ISCRIPTS_SECTION_BADSIGNALService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_SECTION_BADSIGNALRepository;
        }
    }
 
	public partial class SCRIPTS_SECTION_FLOOD_PHOTOService : BaseService<SCRIPTS_SECTION_FLOOD_PHOTO>,ISCRIPTS_SECTION_FLOOD_PHOTOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_SECTION_FLOOD_PHOTORepository;
        }
    }
 
	public partial class SCRIPTS_SECTION_FLOOD_PIC_TESTService : BaseService<SCRIPTS_SECTION_FLOOD_PIC_TEST>,ISCRIPTS_SECTION_FLOOD_PIC_TESTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_SECTION_FLOOD_PIC_TESTRepository;
        }
    }
 
	public partial class SCRIPTS_SECTION_LINEService : BaseService<SCRIPTS_SECTION_LINE>,ISCRIPTS_SECTION_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_SECTION_LINERepository;
        }
    }
 
	public partial class SCRIPTS_SECTION_OTHER_PHOTOService : BaseService<SCRIPTS_SECTION_OTHER_PHOTO>,ISCRIPTS_SECTION_OTHER_PHOTOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_SECTION_OTHER_PHOTORepository;
        }
    }
 
	public partial class SCRIPTS_SECTION_ROAD_LINEService : BaseService<SCRIPTS_SECTION_ROAD_LINE>,ISCRIPTS_SECTION_ROAD_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_SECTION_ROAD_LINERepository;
        }
    }
 
	public partial class SCRIPTS_SECTION_ROADMOTORService : BaseService<SCRIPTS_SECTION_ROADMOTOR>,ISCRIPTS_SECTION_ROADMOTORService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_SECTION_ROADMOTORRepository;
        }
    }
 
	public partial class SCRIPTS_SECTION_TRACKService : BaseService<SCRIPTS_SECTION_TRACK>,ISCRIPTS_SECTION_TRACKService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_SECTION_TRACKRepository;
        }
    }
 
	public partial class SCRIPTS_SECTION_TRACK_INFOService : BaseService<SCRIPTS_SECTION_TRACK_INFO>,ISCRIPTS_SECTION_TRACK_INFOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_SECTION_TRACK_INFORepository;
        }
    }
 
	public partial class SCRIPTS_SECTION_TYPECROSSService : BaseService<SCRIPTS_SECTION_TYPECROSS>,ISCRIPTS_SECTION_TYPECROSSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_SECTION_TYPECROSSRepository;
        }
    }
 
	public partial class SCRIPTS_SECTION_TYPEFLOODService : BaseService<SCRIPTS_SECTION_TYPEFLOOD>,ISCRIPTS_SECTION_TYPEFLOODService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_SECTION_TYPEFLOODRepository;
        }
    }
 
	public partial class SCRIPTS_SECTION_TYPEOTHERService : BaseService<SCRIPTS_SECTION_TYPEOTHER>,ISCRIPTS_SECTION_TYPEOTHERService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_SECTION_TYPEOTHERRepository;
        }
    }
 
	public partial class SCRIPTS_SECTION_TYPEOTHERINFOService : BaseService<SCRIPTS_SECTION_TYPEOTHERINFO>,ISCRIPTS_SECTION_TYPEOTHERINFOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_SECTION_TYPEOTHERINFORepository;
        }
    }
 
	public partial class SCRIPTS_SPECIAL_FLAGService : BaseService<SCRIPTS_SPECIAL_FLAG>,ISCRIPTS_SPECIAL_FLAGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_SPECIAL_FLAGRepository;
        }
    }
 
	public partial class SCRIPTS_STATION_CHECKService : BaseService<SCRIPTS_STATION_CHECK>,ISCRIPTS_STATION_CHECKService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISCRIPTS_STATION_CHECKRepository;
        }
    }
 
	public partial class SNOW_BDATA_DEVICEService : BaseService<SNOW_BDATA_DEVICE>,ISNOW_BDATA_DEVICEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISNOW_BDATA_DEVICERepository;
        }
    }
 
	public partial class SNOW_BDATA_WARNSTANDARDService : BaseService<SNOW_BDATA_WARNSTANDARD>,ISNOW_BDATA_WARNSTANDARDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISNOW_BDATA_WARNSTANDARDRepository;
        }
    }
 
	public partial class SNOW_RECORD_HISService : BaseService<SNOW_RECORD_HIS>,ISNOW_RECORD_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISNOW_RECORD_HISRepository;
        }
    }
 
	public partial class SNOW_SECTION_LINEService : BaseService<SNOW_SECTION_LINE>,ISNOW_SECTION_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISNOW_SECTION_LINERepository;
        }
    }
 
	public partial class SNOW_VIDEO_FILEService : BaseService<SNOW_VIDEO_FILE>,ISNOW_VIDEO_FILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISNOW_VIDEO_FILERepository;
        }
    }
 
	public partial class SYS_DEPTService : BaseService<SYS_DEPT>,ISYS_DEPTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_DEPTRepository;
        }
    }
 
	public partial class SYS_INTELLIGENCE_DICService : BaseService<SYS_INTELLIGENCE_DIC>,ISYS_INTELLIGENCE_DICService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_INTELLIGENCE_DICRepository;
        }
    }
 
	public partial class SYS_MEMBERService : BaseService<SYS_MEMBER>,ISYS_MEMBERService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_MEMBERRepository;
        }
    }
 
	public partial class SYS_MENUService : BaseService<SYS_MENU>,ISYS_MENUService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_MENURepository;
        }
    }
 
	public partial class SYS_MENU_HELPCONTENTService : BaseService<SYS_MENU_HELPCONTENT>,ISYS_MENU_HELPCONTENTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_MENU_HELPCONTENTRepository;
        }
    }
 
	public partial class SYS_MENUOPTService : BaseService<SYS_MENUOPT>,ISYS_MENUOPTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_MENUOPTRepository;
        }
    }
 
	public partial class SYS_POSLEVEL_DICService : BaseService<SYS_POSLEVEL_DIC>,ISYS_POSLEVEL_DICService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_POSLEVEL_DICRepository;
        }
    }
 
	public partial class SYS_ROLEService : BaseService<SYS_ROLE>,ISYS_ROLEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_ROLERepository;
        }
    }
 
	public partial class SYS_ROLE_MENU_MAPService : BaseService<SYS_ROLE_MENU_MAP>,ISYS_ROLE_MENU_MAPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_ROLE_MENU_MAPRepository;
        }
    }
 
	public partial class SYS_ROLE_MENUOPT_MAPService : BaseService<SYS_ROLE_MENUOPT_MAP>,ISYS_ROLE_MENUOPT_MAPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_ROLE_MENUOPT_MAPRepository;
        }
    }
 
	public partial class SYS_STATIONMEMBER_NOService : BaseService<SYS_STATIONMEMBER_NO>,ISYS_STATIONMEMBER_NOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_STATIONMEMBER_NORepository;
        }
    }
 
	public partial class SYS_USERService : BaseService<SYS_USER>,ISYS_USERService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_USERRepository;
        }
    }
 
	public partial class SYS_USER_DEFAULTMENUService : BaseService<SYS_USER_DEFAULTMENU>,ISYS_USER_DEFAULTMENUService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_USER_DEFAULTMENURepository;
        }
    }
 
	public partial class SYS_USER_PHONE_DICService : BaseService<SYS_USER_PHONE_DIC>,ISYS_USER_PHONE_DICService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_USER_PHONE_DICRepository;
        }
    }
 
	public partial class SYS_USER_ROLE_MAPService : BaseService<SYS_USER_ROLE_MAP>,ISYS_USER_ROLE_MAPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_USER_ROLE_MAPRepository;
        }
    }
 
	public partial class SYS_USERLOGINService : BaseService<SYS_USERLOGIN>,ISYS_USERLOGINService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ISYS_USERLOGINRepository;
        }
    }
 
	public partial class T_ASS_BOUNDService : BaseService<T_ASS_BOUND>,IT_ASS_BOUNDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_BOUNDRepository;
        }
    }
 
	public partial class T_ASS_BRIDGEService : BaseService<T_ASS_BRIDGE>,IT_ASS_BRIDGEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_BRIDGERepository;
        }
    }
 
	public partial class T_ASS_BROKENCHAINService : BaseService<T_ASS_BROKENCHAIN>,IT_ASS_BROKENCHAINService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_BROKENCHAINRepository;
        }
    }
 
	public partial class T_ASS_COMBINEDRAWService : BaseService<T_ASS_COMBINEDRAW>,IT_ASS_COMBINEDRAWService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_COMBINEDRAWRepository;
        }
    }
 
	public partial class T_ASS_COMPMAINT_PLANService : BaseService<T_ASS_COMPMAINT_PLAN>,IT_ASS_COMPMAINT_PLANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_COMPMAINT_PLANRepository;
        }
    }
 
	public partial class T_ASS_COMPMAINT_PLAN_DETAILService : BaseService<T_ASS_COMPMAINT_PLAN_DETAIL>,IT_ASS_COMPMAINT_PLAN_DETAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_COMPMAINT_PLAN_DETAILRepository;
        }
    }
 
	public partial class T_ASS_CURVEService : BaseService<T_ASS_CURVE>,IT_ASS_CURVEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_CURVERepository;
        }
    }
 
	public partial class T_ASS_EMPService : BaseService<T_ASS_EMP>,IT_ASS_EMPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_EMPRepository;
        }
    }
 
	public partial class T_ASS_EQU_DATA_TEMPService : BaseService<T_ASS_EQU_DATA_TEMP>,IT_ASS_EQU_DATA_TEMPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_EQU_DATA_TEMPRepository;
        }
    }
 
	public partial class T_ASS_FLOWService : BaseService<T_ASS_FLOW>,IT_ASS_FLOWService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_FLOWRepository;
        }
    }
 
	public partial class T_ASS_FLOW_INSTANCEService : BaseService<T_ASS_FLOW_INSTANCE>,IT_ASS_FLOW_INSTANCEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_FLOW_INSTANCERepository;
        }
    }
 
	public partial class T_ASS_FLOW_PROCESSService : BaseService<T_ASS_FLOW_PROCESS>,IT_ASS_FLOW_PROCESSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_FLOW_PROCESSRepository;
        }
    }
 
	public partial class T_ASS_FLOW_ROLEService : BaseService<T_ASS_FLOW_ROLE>,IT_ASS_FLOW_ROLEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_FLOW_ROLERepository;
        }
    }
 
	public partial class T_ASS_FLOW_STEPService : BaseService<T_ASS_FLOW_STEP>,IT_ASS_FLOW_STEPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_FLOW_STEPRepository;
        }
    }
 
	public partial class T_ASS_FLOW_USER_ROLEService : BaseService<T_ASS_FLOW_USER_ROLE>,IT_ASS_FLOW_USER_ROLEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_FLOW_USER_ROLERepository;
        }
    }
 
	public partial class T_ASS_GJC_AVESCOREService : BaseService<T_ASS_GJC_AVESCORE>,IT_ASS_GJC_AVESCOREService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_GJC_AVESCORERepository;
        }
    }
 
	public partial class T_ASS_LINEDRAWService : BaseService<T_ASS_LINEDRAW>,IT_ASS_LINEDRAWService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_LINEDRAWRepository;
        }
    }
 
	public partial class T_ASS_MATERIALService : BaseService<T_ASS_MATERIAL>,IT_ASS_MATERIALService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_MATERIALRepository;
        }
    }
 
	public partial class T_ASS_PARA_DYN_SCOREService : BaseService<T_ASS_PARA_DYN_SCORE>,IT_ASS_PARA_DYN_SCOREService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PARA_DYN_SCORERepository;
        }
    }
 
	public partial class T_ASS_PARA_LEVEL_SCOREService : BaseService<T_ASS_PARA_LEVEL_SCORE>,IT_ASS_PARA_LEVEL_SCOREService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PARA_LEVEL_SCORERepository;
        }
    }
 
	public partial class T_ASS_PARA_PLACEService : BaseService<T_ASS_PARA_PLACE>,IT_ASS_PARA_PLACEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PARA_PLACERepository;
        }
    }
 
	public partial class T_ASS_PARA_PRO_CTRLService : BaseService<T_ASS_PARA_PRO_CTRL>,IT_ASS_PARA_PRO_CTRLService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PARA_PRO_CTRLRepository;
        }
    }
 
	public partial class T_ASS_PARA_PRO_TYPEService : BaseService<T_ASS_PARA_PRO_TYPE>,IT_ASS_PARA_PRO_TYPEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PARA_PRO_TYPERepository;
        }
    }
 
	public partial class T_ASS_PARA_SCOREService : BaseService<T_ASS_PARA_SCORE>,IT_ASS_PARA_SCOREService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PARA_SCORERepository;
        }
    }
 
	public partial class T_ASS_PARAREPORT_TEMPService : BaseService<T_ASS_PARAREPORT_TEMP>,IT_ASS_PARAREPORT_TEMPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PARAREPORT_TEMPRepository;
        }
    }
 
	public partial class T_ASS_PLAN_CONSTRUCTIONService : BaseService<T_ASS_PLAN_CONSTRUCTION>,IT_ASS_PLAN_CONSTRUCTIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PLAN_CONSTRUCTIONRepository;
        }
    }
 
	public partial class T_ASS_PLAN_DAILYService : BaseService<T_ASS_PLAN_DAILY>,IT_ASS_PLAN_DAILYService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PLAN_DAILYRepository;
        }
    }
 
	public partial class T_ASS_PLAN_DATA_TEMPService : BaseService<T_ASS_PLAN_DATA_TEMP>,IT_ASS_PLAN_DATA_TEMPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PLAN_DATA_TEMPRepository;
        }
    }
 
	public partial class T_ASS_PLAN_FLOWService : BaseService<T_ASS_PLAN_FLOW>,IT_ASS_PLAN_FLOWService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PLAN_FLOWRepository;
        }
    }
 
	public partial class T_ASS_PLAN_LOCATEService : BaseService<T_ASS_PLAN_LOCATE>,IT_ASS_PLAN_LOCATEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PLAN_LOCATERepository;
        }
    }
 
	public partial class T_ASS_PLAN_MATERIALService : BaseService<T_ASS_PLAN_MATERIAL>,IT_ASS_PLAN_MATERIALService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PLAN_MATERIALRepository;
        }
    }
 
	public partial class T_ASS_PLAN_MEMBERService : BaseService<T_ASS_PLAN_MEMBER>,IT_ASS_PLAN_MEMBERService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PLAN_MEMBERRepository;
        }
    }
 
	public partial class T_ASS_PLAN_MONTHService : BaseService<T_ASS_PLAN_MONTH>,IT_ASS_PLAN_MONTHService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PLAN_MONTHRepository;
        }
    }
 
	public partial class T_ASS_PLAN_PROBLEMService : BaseService<T_ASS_PLAN_PROBLEM>,IT_ASS_PLAN_PROBLEMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PLAN_PROBLEMRepository;
        }
    }
 
	public partial class T_ASS_PLAN_PROJECTService : BaseService<T_ASS_PLAN_PROJECT>,IT_ASS_PLAN_PROJECTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PLAN_PROJECTRepository;
        }
    }
 
	public partial class T_ASS_PLAN_REPAIRService : BaseService<T_ASS_PLAN_REPAIR>,IT_ASS_PLAN_REPAIRService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PLAN_REPAIRRepository;
        }
    }
 
	public partial class T_ASS_PLAN_TOOLService : BaseService<T_ASS_PLAN_TOOL>,IT_ASS_PLAN_TOOLService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PLAN_TOOLRepository;
        }
    }
 
	public partial class T_ASS_PLAN_UNIT_PRO_STATService : BaseService<T_ASS_PLAN_UNIT_PRO_STAT>,IT_ASS_PLAN_UNIT_PRO_STATService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PLAN_UNIT_PRO_STATRepository;
        }
    }
 
	public partial class T_ASS_PLAN_WEEKService : BaseService<T_ASS_PLAN_WEEK>,IT_ASS_PLAN_WEEKService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PLAN_WEEKRepository;
        }
    }
 
	public partial class T_ASS_PROBLEMService : BaseService<T_ASS_PROBLEM>,IT_ASS_PROBLEMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PROBLEMRepository;
        }
    }
 
	public partial class T_ASS_PROBLEM_HISService : BaseService<T_ASS_PROBLEM_HIS>,IT_ASS_PROBLEM_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PROBLEM_HISRepository;
        }
    }
 
	public partial class T_ASS_PROBLEM_LJService : BaseService<T_ASS_PROBLEM_LJ>,IT_ASS_PROBLEM_LJService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PROBLEM_LJRepository;
        }
    }
 
	public partial class T_ASS_PROBLEM_ORIService : BaseService<T_ASS_PROBLEM_ORI>,IT_ASS_PROBLEM_ORIService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PROBLEM_ORIRepository;
        }
    }
 
	public partial class T_ASS_PROBLEM_TEMPService : BaseService<T_ASS_PROBLEM_TEMP>,IT_ASS_PROBLEM_TEMPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PROBLEM_TEMPRepository;
        }
    }
 
	public partial class T_ASS_PROJECTService : BaseService<T_ASS_PROJECT>,IT_ASS_PROJECTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_PROJECTRepository;
        }
    }
 
	public partial class T_ASS_REPEAT_PROBLEMService : BaseService<T_ASS_REPEAT_PROBLEM>,IT_ASS_REPEAT_PROBLEMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_REPEAT_PROBLEMRepository;
        }
    }
 
	public partial class T_ASS_REPEAT_PRODETAILService : BaseService<T_ASS_REPEAT_PRODETAIL>,IT_ASS_REPEAT_PRODETAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_REPEAT_PRODETAILRepository;
        }
    }
 
	public partial class T_ASS_SECURITY_OFFERService : BaseService<T_ASS_SECURITY_OFFER>,IT_ASS_SECURITY_OFFERService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_SECURITY_OFFERRepository;
        }
    }
 
	public partial class T_ASS_STATIONService : BaseService<T_ASS_STATION>,IT_ASS_STATIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_STATIONRepository;
        }
    }
 
	public partial class T_ASS_STATIONSTAIRSService : BaseService<T_ASS_STATIONSTAIRS>,IT_ASS_STATIONSTAIRSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_STATIONSTAIRSRepository;
        }
    }
 
	public partial class T_ASS_TEMREPAIR_PLANService : BaseService<T_ASS_TEMREPAIR_PLAN>,IT_ASS_TEMREPAIR_PLANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_TEMREPAIR_PLANRepository;
        }
    }
 
	public partial class T_ASS_TEMREPAIR_PLAN_DETAILService : BaseService<T_ASS_TEMREPAIR_PLAN_DETAIL>,IT_ASS_TEMREPAIR_PLAN_DETAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_TEMREPAIR_PLAN_DETAILRepository;
        }
    }
 
	public partial class T_ASS_TOOLINFOService : BaseService<T_ASS_TOOLINFO>,IT_ASS_TOOLINFOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_TOOLINFORepository;
        }
    }
 
	public partial class T_ASS_TQIService : BaseService<T_ASS_TQI>,IT_ASS_TQIService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_TQIRepository;
        }
    }
 
	public partial class T_ASS_TQI_AVESCOREService : BaseService<T_ASS_TQI_AVESCORE>,IT_ASS_TQI_AVESCOREService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_TQI_AVESCORERepository;
        }
    }
 
	public partial class T_ASS_TQI_DETAILService : BaseService<T_ASS_TQI_DETAIL>,IT_ASS_TQI_DETAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_TQI_DETAILRepository;
        }
    }
 
	public partial class T_ASS_TQI_PARAService : BaseService<T_ASS_TQI_PARA>,IT_ASS_TQI_PARAService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_TQI_PARARepository;
        }
    }
 
	public partial class T_ASS_TQI_PARA2Service : BaseService<T_ASS_TQI_PARA2>,IT_ASS_TQI_PARA2Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_TQI_PARA2Repository;
        }
    }
 
	public partial class T_ASS_TRACKService : BaseService<T_ASS_TRACK>,IT_ASS_TRACKService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_TRACKRepository;
        }
    }
 
	public partial class T_ASS_TRACK_VALService : BaseService<T_ASS_TRACK_VAL>,IT_ASS_TRACK_VALService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_TRACK_VALRepository;
        }
    }
 
	public partial class T_ASS_TRACK_VAL_DETAILService : BaseService<T_ASS_TRACK_VAL_DETAIL>,IT_ASS_TRACK_VAL_DETAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_TRACK_VAL_DETAILRepository;
        }
    }
 
	public partial class T_ASS_TUNNELService : BaseService<T_ASS_TUNNEL>,IT_ASS_TUNNELService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_TUNNELRepository;
        }
    }
 
	public partial class T_ASS_TURNOUTService : BaseService<T_ASS_TURNOUT>,IT_ASS_TURNOUTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_TURNOUTRepository;
        }
    }
 
	public partial class T_ASS_TURNOUT_VALService : BaseService<T_ASS_TURNOUT_VAL>,IT_ASS_TURNOUT_VALService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_TURNOUT_VALRepository;
        }
    }
 
	public partial class T_ASS_TURNOUT_VAL_DETAILService : BaseService<T_ASS_TURNOUT_VAL_DETAIL>,IT_ASS_TURNOUT_VAL_DETAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_TURNOUT_VAL_DETAILRepository;
        }
    }
 
	public partial class T_ASS_UNITService : BaseService<T_ASS_UNIT>,IT_ASS_UNITService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_UNITRepository;
        }
    }
 
	public partial class T_ASS_UNIT_TQIService : BaseService<T_ASS_UNIT_TQI>,IT_ASS_UNIT_TQIService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_UNIT_TQIRepository;
        }
    }
 
	public partial class T_ASS_UNIT_VALService : BaseService<T_ASS_UNIT_VAL>,IT_ASS_UNIT_VALService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_UNIT_VALRepository;
        }
    }
 
	public partial class T_ASS_UNIT_VAL_DETAILService : BaseService<T_ASS_UNIT_VAL_DETAIL>,IT_ASS_UNIT_VAL_DETAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_UNIT_VAL_DETAILRepository;
        }
    }
 
	public partial class T_ASS_UNIT625Service : BaseService<T_ASS_UNIT625>,IT_ASS_UNIT625Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_UNIT625Repository;
        }
    }
 
	public partial class T_ASS_UNIT625_VALService : BaseService<T_ASS_UNIT625_VAL>,IT_ASS_UNIT625_VALService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_UNIT625_VALRepository;
        }
    }
 
	public partial class T_ASS_UNIT625_VAL_DETAILService : BaseService<T_ASS_UNIT625_VAL_DETAIL>,IT_ASS_UNIT625_VAL_DETAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_ASS_UNIT625_VAL_DETAILRepository;
        }
    }
 
	public partial class T_BOOTRECINFOService : BaseService<T_BOOTRECINFO>,IT_BOOTRECINFOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_BOOTRECINFORepository;
        }
    }
 
	public partial class T_CARLASTOBDService : BaseService<T_CARLASTOBD>,IT_CARLASTOBDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CARLASTOBDRepository;
        }
    }
 
	public partial class T_CAROBDService : BaseService<T_CAROBD>,IT_CAROBDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CAROBDRepository;
        }
    }
 
	public partial class T_CHK_CURVEService : BaseService<T_CHK_CURVE>,IT_CHK_CURVEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_CURVERepository;
        }
    }
 
	public partial class T_CHK_CURVE_ITEMSService : BaseService<T_CHK_CURVE_ITEMS>,IT_CHK_CURVE_ITEMSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_CURVE_ITEMSRepository;
        }
    }
 
	public partial class T_CHK_DICService : BaseService<T_CHK_DIC>,IT_CHK_DICService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_DICRepository;
        }
    }
 
	public partial class T_CHK_DISEASE_ITEMSService : BaseService<T_CHK_DISEASE_ITEMS>,IT_CHK_DISEASE_ITEMSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_DISEASE_ITEMSRepository;
        }
    }
 
	public partial class T_CHK_DISEASE_STANDARDService : BaseService<T_CHK_DISEASE_STANDARD>,IT_CHK_DISEASE_STANDARDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_DISEASE_STANDARDRepository;
        }
    }
 
	public partial class T_CHK_LINEService : BaseService<T_CHK_LINE>,IT_CHK_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_LINERepository;
        }
    }
 
	public partial class T_CHK_LINE_ITEMSService : BaseService<T_CHK_LINE_ITEMS>,IT_CHK_LINE_ITEMSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_LINE_ITEMSRepository;
        }
    }
 
	public partial class T_CHK_MEDIA_ITEMSService : BaseService<T_CHK_MEDIA_ITEMS>,IT_CHK_MEDIA_ITEMSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_MEDIA_ITEMSRepository;
        }
    }
 
	public partial class T_CHK_TURNOUTService : BaseService<T_CHK_TURNOUT>,IT_CHK_TURNOUTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_TURNOUTRepository;
        }
    }
 
	public partial class T_CHK_TURNOUT_DIAMOND_ITEMSService : BaseService<T_CHK_TURNOUT_DIAMOND_ITEMS>,IT_CHK_TURNOUT_DIAMOND_ITEMSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_TURNOUT_DIAMOND_ITEMSRepository;
        }
    }
 
	public partial class T_CHK_TURNOUT_DOUBLE_ITEMSService : BaseService<T_CHK_TURNOUT_DOUBLE_ITEMS>,IT_CHK_TURNOUT_DOUBLE_ITEMSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_TURNOUT_DOUBLE_ITEMSRepository;
        }
    }
 
	public partial class T_CHK_TURNOUT_ITEMSService : BaseService<T_CHK_TURNOUT_ITEMS>,IT_CHK_TURNOUT_ITEMSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_TURNOUT_ITEMSRepository;
        }
    }
 
	public partial class T_CHK_TURNOUT_MOVPOINT_ITEMSService : BaseService<T_CHK_TURNOUT_MOVPOINT_ITEMS>,IT_CHK_TURNOUT_MOVPOINT_ITEMSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_TURNOUT_MOVPOINT_ITEMSRepository;
        }
    }
 
	public partial class T_CHK_TURNOUT_SLIP_ITEMSService : BaseService<T_CHK_TURNOUT_SLIP_ITEMS>,IT_CHK_TURNOUT_SLIP_ITEMSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_TURNOUT_SLIP_ITEMSRepository;
        }
    }
 
	public partial class T_CHK_VISCHECK_ITEMSService : BaseService<T_CHK_VISCHECK_ITEMS>,IT_CHK_VISCHECK_ITEMSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_VISCHECK_ITEMSRepository;
        }
    }
 
	public partial class T_CHK_VISUAL_ITEMSService : BaseService<T_CHK_VISUAL_ITEMS>,IT_CHK_VISUAL_ITEMSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_VISUAL_ITEMSRepository;
        }
    }
 
	public partial class T_CHK_WIDENING_VALUEService : BaseService<T_CHK_WIDENING_VALUE>,IT_CHK_WIDENING_VALUEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHK_WIDENING_VALUERepository;
        }
    }
 
	public partial class T_CHKPOSService : BaseService<T_CHKPOS>,IT_CHKPOSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CHKPOSRepository;
        }
    }
 
	public partial class T_CUSTOM_STATIONService : BaseService<T_CUSTOM_STATION>,IT_CUSTOM_STATIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CUSTOM_STATIONRepository;
        }
    }
 
	public partial class T_CZ_CCService : BaseService<T_CZ_CC>,IT_CZ_CCService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CZ_CCRepository;
        }
    }
 
	public partial class T_CZ_FREQ_TEMPService : BaseService<T_CZ_FREQ_TEMP>,IT_CZ_FREQ_TEMPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CZ_FREQ_TEMPRepository;
        }
    }
 
	public partial class T_CZ_GJService : BaseService<T_CZ_GJ>,IT_CZ_GJService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CZ_GJRepository;
        }
    }
 
	public partial class T_CZ_JCHService : BaseService<T_CZ_JCH>,IT_CZ_JCHService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CZ_JCHRepository;
        }
    }
 
	public partial class T_CZ_NLINENOService : BaseService<T_CZ_NLINENO>,IT_CZ_NLINENOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CZ_NLINENORepository;
        }
    }
 
	public partial class T_CZ_PHONEService : BaseService<T_CZ_PHONE>,IT_CZ_PHONEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CZ_PHONERepository;
        }
    }
 
	public partial class T_CZ_TBLService : BaseService<T_CZ_TBL>,IT_CZ_TBLService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CZ_TBLRepository;
        }
    }
 
	public partial class T_CZ_TDWID_TEMPService : BaseService<T_CZ_TDWID_TEMP>,IT_CZ_TDWID_TEMPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CZ_TDWID_TEMPRepository;
        }
    }
 
	public partial class T_CZ_TJ_TEMPService : BaseService<T_CZ_TJ_TEMP>,IT_CZ_TJ_TEMPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CZ_TJ_TEMPRepository;
        }
    }
 
	public partial class T_CZ_WARPService : BaseService<T_CZ_WARP>,IT_CZ_WARPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CZ_WARPRepository;
        }
    }
 
	public partial class T_CZ_WARP_TEMPService : BaseService<T_CZ_WARP_TEMP>,IT_CZ_WARP_TEMPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_CZ_WARP_TEMPRepository;
        }
    }
 
	public partial class T_GIS_LINEService : BaseService<T_GIS_LINE>,IT_GIS_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_GIS_LINERepository;
        }
    }
 
	public partial class T_GIS_LINE_TESTService : BaseService<T_GIS_LINE_TEST>,IT_GIS_LINE_TESTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_GIS_LINE_TESTRepository;
        }
    }
 
	public partial class T_GIS_LINE_TEST_NOPWDService : BaseService<T_GIS_LINE_TEST_NOPWD>,IT_GIS_LINE_TEST_NOPWDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_GIS_LINE_TEST_NOPWDRepository;
        }
    }
 
	public partial class T_GIS_STATIONService : BaseService<T_GIS_STATION>,IT_GIS_STATIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_GIS_STATIONRepository;
        }
    }
 
	public partial class T_GIS_STATION_TESTService : BaseService<T_GIS_STATION_TEST>,IT_GIS_STATION_TESTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_GIS_STATION_TESTRepository;
        }
    }
 
	public partial class T_GWBASEService : BaseService<T_GWBASE>,IT_GWBASEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_GWBASERepository;
        }
    }
 
	public partial class T_GWBASE_SECTION_LINEService : BaseService<T_GWBASE_SECTION_LINE>,IT_GWBASE_SECTION_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_GWBASE_SECTION_LINERepository;
        }
    }
 
	public partial class T_GWBASE_TESTService : BaseService<T_GWBASE_TEST>,IT_GWBASE_TESTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_GWBASE_TESTRepository;
        }
    }
 
	public partial class T_GWDETAILService : BaseService<T_GWDETAIL>,IT_GWDETAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_GWDETAILRepository;
        }
    }
 
	public partial class T_GWTRANSETService : BaseService<T_GWTRANSET>,IT_GWTRANSETService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_GWTRANSETRepository;
        }
    }
 
	public partial class T_JOB_LINEService : BaseService<T_JOB_LINE>,IT_JOB_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_JOB_LINERepository;
        }
    }
 
	public partial class T_LKJ_FLOW_ATTACHService : BaseService<T_LKJ_FLOW_ATTACH>,IT_LKJ_FLOW_ATTACHService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_FLOW_ATTACHRepository;
        }
    }
 
	public partial class T_LKJ_FLOW_DOCService : BaseService<T_LKJ_FLOW_DOC>,IT_LKJ_FLOW_DOCService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_FLOW_DOCRepository;
        }
    }
 
	public partial class T_LKJ_FLOW_FEEDBACKService : BaseService<T_LKJ_FLOW_FEEDBACK>,IT_LKJ_FLOW_FEEDBACKService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_FLOW_FEEDBACKRepository;
        }
    }
 
	public partial class T_LKJ_FLOW_INFOService : BaseService<T_LKJ_FLOW_INFO>,IT_LKJ_FLOW_INFOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_FLOW_INFORepository;
        }
    }
 
	public partial class T_LKJ_FLOW_MESSAGEService : BaseService<T_LKJ_FLOW_MESSAGE>,IT_LKJ_FLOW_MESSAGEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_FLOW_MESSAGERepository;
        }
    }
 
	public partial class T_LKJ_FLOW_REFERENCEService : BaseService<T_LKJ_FLOW_REFERENCE>,IT_LKJ_FLOW_REFERENCEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_FLOW_REFERENCERepository;
        }
    }
 
	public partial class T_LKJ_FLOW_ROLEService : BaseService<T_LKJ_FLOW_ROLE>,IT_LKJ_FLOW_ROLEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_FLOW_ROLERepository;
        }
    }
 
	public partial class T_LKJ_FLOW_STEPINFOService : BaseService<T_LKJ_FLOW_STEPINFO>,IT_LKJ_FLOW_STEPINFOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_FLOW_STEPINFORepository;
        }
    }
 
	public partial class T_LKJ_FLOW_USERROLEService : BaseService<T_LKJ_FLOW_USERROLE>,IT_LKJ_FLOW_USERROLEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_FLOW_USERROLERepository;
        }
    }
 
	public partial class T_LKJ_LINESTATIONService : BaseService<T_LKJ_LINESTATION>,IT_LKJ_LINESTATIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_LINESTATIONRepository;
        }
    }
 
	public partial class T_LKJ_ROLEFLOWService : BaseService<T_LKJ_ROLEFLOW>,IT_LKJ_ROLEFLOWService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_ROLEFLOWRepository;
        }
    }
 
	public partial class T_LKJ_S1Service : BaseService<T_LKJ_S1>,IT_LKJ_S1Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S1Repository;
        }
    }
 
	public partial class T_LKJ_S1_HISService : BaseService<T_LKJ_S1_HIS>,IT_LKJ_S1_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S1_HISRepository;
        }
    }
 
	public partial class T_LKJ_S10Service : BaseService<T_LKJ_S10>,IT_LKJ_S10Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S10Repository;
        }
    }
 
	public partial class T_LKJ_S10_HISService : BaseService<T_LKJ_S10_HIS>,IT_LKJ_S10_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S10_HISRepository;
        }
    }
 
	public partial class T_LKJ_S11Service : BaseService<T_LKJ_S11>,IT_LKJ_S11Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S11Repository;
        }
    }
 
	public partial class T_LKJ_S11_HISService : BaseService<T_LKJ_S11_HIS>,IT_LKJ_S11_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S11_HISRepository;
        }
    }
 
	public partial class T_LKJ_S12Service : BaseService<T_LKJ_S12>,IT_LKJ_S12Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S12Repository;
        }
    }
 
	public partial class T_LKJ_S12_HISService : BaseService<T_LKJ_S12_HIS>,IT_LKJ_S12_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S12_HISRepository;
        }
    }
 
	public partial class T_LKJ_S13Service : BaseService<T_LKJ_S13>,IT_LKJ_S13Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S13Repository;
        }
    }
 
	public partial class T_LKJ_S13_HISService : BaseService<T_LKJ_S13_HIS>,IT_LKJ_S13_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S13_HISRepository;
        }
    }
 
	public partial class T_LKJ_S2Service : BaseService<T_LKJ_S2>,IT_LKJ_S2Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S2Repository;
        }
    }
 
	public partial class T_LKJ_S2_HISService : BaseService<T_LKJ_S2_HIS>,IT_LKJ_S2_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S2_HISRepository;
        }
    }
 
	public partial class T_LKJ_S3Service : BaseService<T_LKJ_S3>,IT_LKJ_S3Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S3Repository;
        }
    }
 
	public partial class T_LKJ_S3_HISService : BaseService<T_LKJ_S3_HIS>,IT_LKJ_S3_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S3_HISRepository;
        }
    }
 
	public partial class T_LKJ_S4Service : BaseService<T_LKJ_S4>,IT_LKJ_S4Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S4Repository;
        }
    }
 
	public partial class T_LKJ_S4_HISService : BaseService<T_LKJ_S4_HIS>,IT_LKJ_S4_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S4_HISRepository;
        }
    }
 
	public partial class T_LKJ_S5Service : BaseService<T_LKJ_S5>,IT_LKJ_S5Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S5Repository;
        }
    }
 
	public partial class T_LKJ_S5_HISService : BaseService<T_LKJ_S5_HIS>,IT_LKJ_S5_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S5_HISRepository;
        }
    }
 
	public partial class T_LKJ_S6Service : BaseService<T_LKJ_S6>,IT_LKJ_S6Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S6Repository;
        }
    }
 
	public partial class T_LKJ_S6_HISService : BaseService<T_LKJ_S6_HIS>,IT_LKJ_S6_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S6_HISRepository;
        }
    }
 
	public partial class T_LKJ_S7Service : BaseService<T_LKJ_S7>,IT_LKJ_S7Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S7Repository;
        }
    }
 
	public partial class T_LKJ_S7_HISService : BaseService<T_LKJ_S7_HIS>,IT_LKJ_S7_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S7_HISRepository;
        }
    }
 
	public partial class T_LKJ_S8Service : BaseService<T_LKJ_S8>,IT_LKJ_S8Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S8Repository;
        }
    }
 
	public partial class T_LKJ_S8_HISService : BaseService<T_LKJ_S8_HIS>,IT_LKJ_S8_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S8_HISRepository;
        }
    }
 
	public partial class T_LKJ_S9Service : BaseService<T_LKJ_S9>,IT_LKJ_S9Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S9Repository;
        }
    }
 
	public partial class T_LKJ_S9_HISService : BaseService<T_LKJ_S9_HIS>,IT_LKJ_S9_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_S9_HISRepository;
        }
    }
 
	public partial class T_LKJ_ST1Service : BaseService<T_LKJ_ST1>,IT_LKJ_ST1Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_ST1Repository;
        }
    }
 
	public partial class T_LKJ_ST1_HISService : BaseService<T_LKJ_ST1_HIS>,IT_LKJ_ST1_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_ST1_HISRepository;
        }
    }
 
	public partial class T_LKJ_STARELTIONService : BaseService<T_LKJ_STARELTION>,IT_LKJ_STARELTIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_STARELTIONRepository;
        }
    }
 
	public partial class T_LKJ_SYSTABLEService : BaseService<T_LKJ_SYSTABLE>,IT_LKJ_SYSTABLEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_SYSTABLERepository;
        }
    }
 
	public partial class T_LKJ_VERSIONNUMService : BaseService<T_LKJ_VERSIONNUM>,IT_LKJ_VERSIONNUMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_VERSIONNUMRepository;
        }
    }
 
	public partial class T_LKJ_WIRINGDIAGRAMService : BaseService<T_LKJ_WIRINGDIAGRAM>,IT_LKJ_WIRINGDIAGRAMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_WIRINGDIAGRAMRepository;
        }
    }
 
	public partial class T_LKJ_WORKPROCESSService : BaseService<T_LKJ_WORKPROCESS>,IT_LKJ_WORKPROCESSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_WORKPROCESSRepository;
        }
    }
 
	public partial class T_LKJ_WORKPROCESS_HISService : BaseService<T_LKJ_WORKPROCESS_HIS>,IT_LKJ_WORKPROCESS_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_LKJ_WORKPROCESS_HISRepository;
        }
    }
 
	public partial class T_MOBILEFILEService : BaseService<T_MOBILEFILE>,IT_MOBILEFILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_MOBILEFILERepository;
        }
    }
 
	public partial class T_MOBILEFILE_TODOWNService : BaseService<T_MOBILEFILE_TODOWN>,IT_MOBILEFILE_TODOWNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_MOBILEFILE_TODOWNRepository;
        }
    }
 
	public partial class T_MOBILELASTPOSService : BaseService<T_MOBILELASTPOS>,IT_MOBILELASTPOSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_MOBILELASTPOSRepository;
        }
    }
 
	public partial class T_MOBILEROUTEService : BaseService<T_MOBILEROUTE>,IT_MOBILEROUTEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_MOBILEROUTERepository;
        }
    }
 
	public partial class T_MOBILEROUTE_HISService : BaseService<T_MOBILEROUTE_HIS>,IT_MOBILEROUTE_HISService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_MOBILEROUTE_HISRepository;
        }
    }
 
	public partial class T_OILPOSService : BaseService<T_OILPOS>,IT_OILPOSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_OILPOSRepository;
        }
    }
 
	public partial class T_RAINService : BaseService<T_RAIN>,IT_RAINService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_RAINRepository;
        }
    }
 
	public partial class T_RAIN_SMSService : BaseService<T_RAIN_SMS>,IT_RAIN_SMSService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_RAIN_SMSRepository;
        }
    }
 
	public partial class T_RAINWARNService : BaseService<T_RAINWARN>,IT_RAINWARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_RAINWARNRepository;
        }
    }
 
	public partial class T_REALRAINDATAService : BaseService<T_REALRAINDATA>,IT_REALRAINDATAService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_REALRAINDATARepository;
        }
    }
 
	public partial class T_SGJHWARNService : BaseService<T_SGJHWARN>,IT_SGJHWARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_SGJHWARNRepository;
        }
    }
 
	public partial class T_SGJHWARNTMPService : BaseService<T_SGJHWARNTMP>,IT_SGJHWARNTMPService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_SGJHWARNTMPRepository;
        }
    }
 
	public partial class T_VEHICLELOCATIONService : BaseService<T_VEHICLELOCATION>,IT_VEHICLELOCATIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_VEHICLELOCATIONRepository;
        }
    }
 
	public partial class T_WATERService : BaseService<T_WATER>,IT_WATERService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_WATERRepository;
        }
    }
 
	public partial class T_WATER_DEVICEService : BaseService<T_WATER_DEVICE>,IT_WATER_DEVICEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_WATER_DEVICERepository;
        }
    }
 
	public partial class T_WATER_WARNService : BaseService<T_WATER_WARN>,IT_WATER_WARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IT_WATER_WARNRepository;
        }
    }
 
	public partial class TASK_CARDService : BaseService<TASK_CARD>,ITASK_CARDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_CARDRepository;
        }
    }
 
	public partial class TASK_CONSTITLEService : BaseService<TASK_CONSTITLE>,ITASK_CONSTITLEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_CONSTITLERepository;
        }
    }
 
	public partial class TASK_CONSTRUCTIONService : BaseService<TASK_CONSTRUCTION>,ITASK_CONSTRUCTIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_CONSTRUCTIONRepository;
        }
    }
 
	public partial class TASK_DAMAGE_RAILService : BaseService<TASK_DAMAGE_RAIL>,ITASK_DAMAGE_RAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_DAMAGE_RAILRepository;
        }
    }
 
	public partial class TASK_FLOORService : BaseService<TASK_FLOOR>,ITASK_FLOORService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_FLOORRepository;
        }
    }
 
	public partial class TASK_GBH_RAILService : BaseService<TASK_GBH_RAIL>,ITASK_GBH_RAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_GBH_RAILRepository;
        }
    }
 
	public partial class TASK_LAY_LINEROADService : BaseService<TASK_LAY_LINEROAD>,ITASK_LAY_LINEROADService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_LAY_LINEROADRepository;
        }
    }
 
	public partial class TASK_PLANService : BaseService<TASK_PLAN>,ITASK_PLANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_PLANRepository;
        }
    }
 
	public partial class TASK_PLAN_MATERIALService : BaseService<TASK_PLAN_MATERIAL>,ITASK_PLAN_MATERIALService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_PLAN_MATERIALRepository;
        }
    }
 
	public partial class TASK_PLAN_PROBLEMService : BaseService<TASK_PLAN_PROBLEM>,ITASK_PLAN_PROBLEMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_PLAN_PROBLEMRepository;
        }
    }
 
	public partial class TASK_PLAN_TOOLService : BaseService<TASK_PLAN_TOOL>,ITASK_PLAN_TOOLService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_PLAN_TOOLRepository;
        }
    }
 
	public partial class TASK_RAILService : BaseService<TASK_RAIL>,ITASK_RAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_RAILRepository;
        }
    }
 
	public partial class TASK_RAILCOUNTService : BaseService<TASK_RAILCOUNT>,ITASK_RAILCOUNTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_RAILCOUNTRepository;
        }
    }
 
	public partial class TASK_RECOVER_STUFFService : BaseService<TASK_RECOVER_STUFF>,ITASK_RECOVER_STUFFService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_RECOVER_STUFFRepository;
        }
    }
 
	public partial class TASK_REPLACE_RAILService : BaseService<TASK_REPLACE_RAIL>,ITASK_REPLACE_RAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_REPLACE_RAILRepository;
        }
    }
 
	public partial class TASK_REPLACE_TIEService : BaseService<TASK_REPLACE_TIE>,ITASK_REPLACE_TIEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_REPLACE_TIERepository;
        }
    }
 
	public partial class TASK_SLIGHT_FROGService : BaseService<TASK_SLIGHT_FROG>,ITASK_SLIGHT_FROGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_SLIGHT_FROGRepository;
        }
    }
 
	public partial class TASK_SLIGHT_JRAILService : BaseService<TASK_SLIGHT_JRAIL>,ITASK_SLIGHT_JRAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_SLIGHT_JRAILRepository;
        }
    }
 
	public partial class TASK_SLIGHT_OUTLINEService : BaseService<TASK_SLIGHT_OUTLINE>,ITASK_SLIGHT_OUTLINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_SLIGHT_OUTLINERepository;
        }
    }
 
	public partial class TASK_SLIGHT_OUTLINE_FILEService : BaseService<TASK_SLIGHT_OUTLINE_FILE>,ITASK_SLIGHT_OUTLINE_FILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_SLIGHT_OUTLINE_FILERepository;
        }
    }
 
	public partial class TASK_SLIGHT_RAILService : BaseService<TASK_SLIGHT_RAIL>,ITASK_SLIGHT_RAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_SLIGHT_RAILRepository;
        }
    }
 
	public partial class TASK_SLIGHT_RAILP43Service : BaseService<TASK_SLIGHT_RAILP43>,ITASK_SLIGHT_RAILP43Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_SLIGHT_RAILP43Repository;
        }
    }
 
	public partial class TASK_SLIGHT_RAILP50Service : BaseService<TASK_SLIGHT_RAILP50>,ITASK_SLIGHT_RAILP50Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_SLIGHT_RAILP50Repository;
        }
    }
 
	public partial class TASK_SLIGHT_RAILP60Service : BaseService<TASK_SLIGHT_RAILP60>,ITASK_SLIGHT_RAILP60Service
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_SLIGHT_RAILP60Repository;
        }
    }
 
	public partial class TASK_SVGService : BaseService<TASK_SVG>,ITASK_SVGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_SVGRepository;
        }
    }
 
	public partial class TASK_TOOLINFOService : BaseService<TASK_TOOLINFO>,ITASK_TOOLINFOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_TOOLINFORepository;
        }
    }
 
	public partial class TASK_UNLOAD_RAILService : BaseService<TASK_UNLOAD_RAIL>,ITASK_UNLOAD_RAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_UNLOAD_RAILRepository;
        }
    }
 
	public partial class TASK_UNLOAD_STONEService : BaseService<TASK_UNLOAD_STONE>,ITASK_UNLOAD_STONEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_UNLOAD_STONERepository;
        }
    }
 
	public partial class TASK_UNLOAD_TIEService : BaseService<TASK_UNLOAD_TIE>,ITASK_UNLOAD_TIEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_UNLOAD_TIERepository;
        }
    }
 
	public partial class TASK_WORKLOADService : BaseService<TASK_WORKLOAD>,ITASK_WORKLOADService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITASK_WORKLOADRepository;
        }
    }
 
	public partial class TEMPERATURE_SECTION_LINEService : BaseService<TEMPERATURE_SECTION_LINE>,ITEMPERATURE_SECTION_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITEMPERATURE_SECTION_LINERepository;
        }
    }
 
	public partial class TOOL_BDATE_DICService : BaseService<TOOL_BDATE_DIC>,ITOOL_BDATE_DICService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITOOL_BDATE_DICRepository;
        }
    }
 
	public partial class TOOL_BDATE_STOREHOURSEService : BaseService<TOOL_BDATE_STOREHOURSE>,ITOOL_BDATE_STOREHOURSEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITOOL_BDATE_STOREHOURSERepository;
        }
    }
 
	public partial class TOOL_BDATE_TOOLNAMEService : BaseService<TOOL_BDATE_TOOLNAME>,ITOOL_BDATE_TOOLNAMEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITOOL_BDATE_TOOLNAMERepository;
        }
    }
 
	public partial class TOOL_INOUTMNG_INFOService : BaseService<TOOL_INOUTMNG_INFO>,ITOOL_INOUTMNG_INFOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITOOL_INOUTMNG_INFORepository;
        }
    }
 
	public partial class TOOL_JOB_PLANService : BaseService<TOOL_JOB_PLAN>,ITOOL_JOB_PLANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITOOL_JOB_PLANRepository;
        }
    }
 
	public partial class TOOL_JOB_PLAN_IMPORTService : BaseService<TOOL_JOB_PLAN_IMPORT>,ITOOL_JOB_PLAN_IMPORTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITOOL_JOB_PLAN_IMPORTRepository;
        }
    }
 
	public partial class TOOL_PHONE_USERService : BaseService<TOOL_PHONE_USER>,ITOOL_PHONE_USERService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITOOL_PHONE_USERRepository;
        }
    }
 
	public partial class TOOL_TOOLMNG_INOUTService : BaseService<TOOL_TOOLMNG_INOUT>,ITOOL_TOOLMNG_INOUTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITOOL_TOOLMNG_INOUTRepository;
        }
    }
 
	public partial class TOOL_UPDOWN_LINEService : BaseService<TOOL_UPDOWN_LINE>,ITOOL_UPDOWN_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITOOL_UPDOWN_LINERepository;
        }
    }
 
	public partial class TOOL_USEService : BaseService<TOOL_USE>,ITOOL_USEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITOOL_USERepository;
        }
    }
 
	public partial class TOOL_VIRTUAL_JOB_PLANService : BaseService<TOOL_VIRTUAL_JOB_PLAN>,ITOOL_VIRTUAL_JOB_PLANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITOOL_VIRTUAL_JOB_PLANRepository;
        }
    }
 
	public partial class TOOL_VIRTUAL_UPDOWN_LINEService : BaseService<TOOL_VIRTUAL_UPDOWN_LINE>,ITOOL_VIRTUAL_UPDOWN_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITOOL_VIRTUAL_UPDOWN_LINERepository;
        }
    }
 
	public partial class TOOL_VIRTUAL_USEService : BaseService<TOOL_VIRTUAL_USE>,ITOOL_VIRTUAL_USEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITOOL_VIRTUAL_USERepository;
        }
    }
 
	public partial class TOOL_VIRTUAL_WARMService : BaseService<TOOL_VIRTUAL_WARM>,ITOOL_VIRTUAL_WARMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITOOL_VIRTUAL_WARMRepository;
        }
    }
 
	public partial class TOOL_WARMService : BaseService<TOOL_WARM>,ITOOL_WARMService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITOOL_WARMRepository;
        }
    }
 
	public partial class TURNOUT_BASEService : BaseService<TURNOUT_BASE>,ITURNOUT_BASEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITURNOUT_BASERepository;
        }
    }
 
	public partial class TURNOUT_BDATE_DICService : BaseService<TURNOUT_BDATE_DIC>,ITURNOUT_BDATE_DICService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITURNOUT_BDATE_DICRepository;
        }
    }
 
	public partial class TURNOUT_BRANCHService : BaseService<TURNOUT_BRANCH>,ITURNOUT_BRANCHService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITURNOUT_BRANCHRepository;
        }
    }
 
	public partial class TURNOUT_HIS_BRANCHService : BaseService<TURNOUT_HIS_BRANCH>,ITURNOUT_HIS_BRANCHService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITURNOUT_HIS_BRANCHRepository;
        }
    }
 
	public partial class TURNOUT_HIS_PARTService : BaseService<TURNOUT_HIS_PART>,ITURNOUT_HIS_PARTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITURNOUT_HIS_PARTRepository;
        }
    }
 
	public partial class TURNOUT_HIS_PICService : BaseService<TURNOUT_HIS_PIC>,ITURNOUT_HIS_PICService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITURNOUT_HIS_PICRepository;
        }
    }
 
	public partial class TURNOUT_HIS_RAILService : BaseService<TURNOUT_HIS_RAIL>,ITURNOUT_HIS_RAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITURNOUT_HIS_RAILRepository;
        }
    }
 
	public partial class TURNOUT_HISTORYService : BaseService<TURNOUT_HISTORY>,ITURNOUT_HISTORYService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITURNOUT_HISTORYRepository;
        }
    }
 
	public partial class TURNOUT_PARTService : BaseService<TURNOUT_PART>,ITURNOUT_PARTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITURNOUT_PARTRepository;
        }
    }
 
	public partial class TURNOUT_PICService : BaseService<TURNOUT_PIC>,ITURNOUT_PICService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITURNOUT_PICRepository;
        }
    }
 
	public partial class TURNOUT_RAILService : BaseService<TURNOUT_RAIL>,ITURNOUT_RAILService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITURNOUT_RAILRepository;
        }
    }
 
	public partial class TYPEFLOOD_PHOTOService : BaseService<TYPEFLOOD_PHOTO>,ITYPEFLOOD_PHOTOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.ITYPEFLOOD_PHOTORepository;
        }
    }
 
	public partial class VEHICLELOC_BDATA_LOCOMOTIVEService : BaseService<VEHICLELOC_BDATA_LOCOMOTIVE>,IVEHICLELOC_BDATA_LOCOMOTIVEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IVEHICLELOC_BDATA_LOCOMOTIVERepository;
        }
    }
 
	public partial class VIDEO_BDATA_DEVICEService : BaseService<VIDEO_BDATA_DEVICE>,IVIDEO_BDATA_DEVICEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IVIDEO_BDATA_DEVICERepository;
        }
    }
 
	public partial class VIDEO_FILEService : BaseService<VIDEO_FILE>,IVIDEO_FILEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IVIDEO_FILERepository;
        }
    }
 
	public partial class WEATHER_PROVINCE_FORECASTService : BaseService<WEATHER_PROVINCE_FORECAST>,IWEATHER_PROVINCE_FORECASTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWEATHER_PROVINCE_FORECASTRepository;
        }
    }
 
	public partial class WEATHER_PROVINCE_HOURFORECASTService : BaseService<WEATHER_PROVINCE_HOURFORECAST>,IWEATHER_PROVINCE_HOURFORECASTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWEATHER_PROVINCE_HOURFORECASTRepository;
        }
    }
 
	public partial class WINDService : BaseService<WIND>,IWINDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWINDRepository;
        }
    }
 
	public partial class WIND_BASEINFOService : BaseService<WIND_BASEINFO>,IWIND_BASEINFOService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWIND_BASEINFORepository;
        }
    }
 
	public partial class WIND_DAYRPTService : BaseService<WIND_DAYRPT>,IWIND_DAYRPTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWIND_DAYRPTRepository;
        }
    }
 
	public partial class WIND_DIRECTIONService : BaseService<WIND_DIRECTION>,IWIND_DIRECTIONService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWIND_DIRECTIONRepository;
        }
    }
 
	public partial class WIND_GRADINGService : BaseService<WIND_GRADING>,IWIND_GRADINGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWIND_GRADINGRepository;
        }
    }
 
	public partial class WIND_MONRPTService : BaseService<WIND_MONRPT>,IWIND_MONRPTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWIND_MONRPTRepository;
        }
    }
 
	public partial class WIND_SECTION_LINEService : BaseService<WIND_SECTION_LINE>,IWIND_SECTION_LINEService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWIND_SECTION_LINERepository;
        }
    }
 
	public partial class WIND_WARNService : BaseService<WIND_WARN>,IWIND_WARNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWIND_WARNRepository;
        }
    }
 
	public partial class WIND_WARN_STANDARDService : BaseService<WIND_WARN_STANDARD>,IWIND_WARN_STANDARDService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWIND_WARN_STANDARDRepository;
        }
    }
 
	public partial class WIND_YEARRPTService : BaseService<WIND_YEARRPT>,IWIND_YEARRPTService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWIND_YEARRPTRepository;
        }
    }
 
	public partial class WUFENG_BIAOZHUNService : BaseService<WUFENG_BIAOZHUN>,IWUFENG_BIAOZHUNService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWUFENG_BIAOZHUNRepository;
        }
    }
 
	public partial class WUFENG_CHEZHANService : BaseService<WUFENG_CHEZHAN>,IWUFENG_CHEZHANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWUFENG_CHEZHANRepository;
        }
    }
 
	public partial class WUFENG_DANYUANService : BaseService<WUFENG_DANYUAN>,IWUFENG_DANYUANService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWUFENG_DANYUANRepository;
        }
    }
 
	public partial class WUFENG_DANYUAN_LISHIService : BaseService<WUFENG_DANYUAN_LISHI>,IWUFENG_DANYUAN_LISHIService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWUFENG_DANYUAN_LISHIRepository;
        }
    }
 
	public partial class WUFENG_DAOCHAService : BaseService<WUFENG_DAOCHA>,IWUFENG_DAOCHAService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWUFENG_DAOCHARepository;
        }
    }
 
	public partial class WUFENG_JILUService : BaseService<WUFENG_JILU>,IWUFENG_JILUService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWUFENG_JILURepository;
        }
    }
 
	public partial class WUFENG_XIANMINGService : BaseService<WUFENG_XIANMING>,IWUFENG_XIANMINGService
    {
        public override void SetCurrentRepository()
        {
            CurrentRepository = DbSession.IWUFENG_XIANMINGRepository;
        }
    }
}
