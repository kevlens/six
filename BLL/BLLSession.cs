 
                          
using System;  
using System.Collections.Generic;
using System.Linq;       
using System.Text;         
using IBLL; 
namespace BLL
{  
	public partial class BLLSession:IBLLSession   
    {  
    
		#region 01 业务接口 IALL_LINE_DATAService
		IALL_LINE_DATAService iALL_LINE_DATAService;
		public IALL_LINE_DATAService IALL_LINE_DATAService
		{
			get
			{
				if(iALL_LINE_DATAService==null)
					iALL_LINE_DATAService= new ALL_LINE_DATAService();
				return iALL_LINE_DATAService;
			}
			set
			{
				iALL_LINE_DATAService= value;
			}
		}
		#endregion

    
		#region 02 业务接口 IALL_STATION_DATAService
		IALL_STATION_DATAService iALL_STATION_DATAService;
		public IALL_STATION_DATAService IALL_STATION_DATAService
		{
			get
			{
				if(iALL_STATION_DATAService==null)
					iALL_STATION_DATAService= new ALL_STATION_DATAService();
				return iALL_STATION_DATAService;
			}
			set
			{
				iALL_STATION_DATAService= value;
			}
		}
		#endregion

    
		#region 03 业务接口 IALL_VEHTYPE_DATAService
		IALL_VEHTYPE_DATAService iALL_VEHTYPE_DATAService;
		public IALL_VEHTYPE_DATAService IALL_VEHTYPE_DATAService
		{
			get
			{
				if(iALL_VEHTYPE_DATAService==null)
					iALL_VEHTYPE_DATAService= new ALL_VEHTYPE_DATAService();
				return iALL_VEHTYPE_DATAService;
			}
			set
			{
				iALL_VEHTYPE_DATAService= value;
			}
		}
		#endregion

    
		#region 04 业务接口 IALL_VIDEOFILE_DATAService
		IALL_VIDEOFILE_DATAService iALL_VIDEOFILE_DATAService;
		public IALL_VIDEOFILE_DATAService IALL_VIDEOFILE_DATAService
		{
			get
			{
				if(iALL_VIDEOFILE_DATAService==null)
					iALL_VIDEOFILE_DATAService= new ALL_VIDEOFILE_DATAService();
				return iALL_VIDEOFILE_DATAService;
			}
			set
			{
				iALL_VIDEOFILE_DATAService= value;
			}
		}
		#endregion

    
		#region 05 业务接口 IASSET_BASE_ACCOUNTService
		IASSET_BASE_ACCOUNTService iASSET_BASE_ACCOUNTService;
		public IASSET_BASE_ACCOUNTService IASSET_BASE_ACCOUNTService
		{
			get
			{
				if(iASSET_BASE_ACCOUNTService==null)
					iASSET_BASE_ACCOUNTService= new ASSET_BASE_ACCOUNTService();
				return iASSET_BASE_ACCOUNTService;
			}
			set
			{
				iASSET_BASE_ACCOUNTService= value;
			}
		}
		#endregion

    
		#region 06 业务接口 IASSET_BASE_CATALOGService
		IASSET_BASE_CATALOGService iASSET_BASE_CATALOGService;
		public IASSET_BASE_CATALOGService IASSET_BASE_CATALOGService
		{
			get
			{
				if(iASSET_BASE_CATALOGService==null)
					iASSET_BASE_CATALOGService= new ASSET_BASE_CATALOGService();
				return iASSET_BASE_CATALOGService;
			}
			set
			{
				iASSET_BASE_CATALOGService= value;
			}
		}
		#endregion

    
		#region 07 业务接口 IASSET_BASE_MATERIAL_DICService
		IASSET_BASE_MATERIAL_DICService iASSET_BASE_MATERIAL_DICService;
		public IASSET_BASE_MATERIAL_DICService IASSET_BASE_MATERIAL_DICService
		{
			get
			{
				if(iASSET_BASE_MATERIAL_DICService==null)
					iASSET_BASE_MATERIAL_DICService= new ASSET_BASE_MATERIAL_DICService();
				return iASSET_BASE_MATERIAL_DICService;
			}
			set
			{
				iASSET_BASE_MATERIAL_DICService= value;
			}
		}
		#endregion

    
		#region 08 业务接口 IASSET_BASE_RATEService
		IASSET_BASE_RATEService iASSET_BASE_RATEService;
		public IASSET_BASE_RATEService IASSET_BASE_RATEService
		{
			get
			{
				if(iASSET_BASE_RATEService==null)
					iASSET_BASE_RATEService= new ASSET_BASE_RATEService();
				return iASSET_BASE_RATEService;
			}
			set
			{
				iASSET_BASE_RATEService= value;
			}
		}
		#endregion

    
		#region 09 业务接口 IASSET_BASE_RELATION_UNITService
		IASSET_BASE_RELATION_UNITService iASSET_BASE_RELATION_UNITService;
		public IASSET_BASE_RELATION_UNITService IASSET_BASE_RELATION_UNITService
		{
			get
			{
				if(iASSET_BASE_RELATION_UNITService==null)
					iASSET_BASE_RELATION_UNITService= new ASSET_BASE_RELATION_UNITService();
				return iASSET_BASE_RELATION_UNITService;
			}
			set
			{
				iASSET_BASE_RELATION_UNITService= value;
			}
		}
		#endregion

    
		#region 10 业务接口 IASSET_BASE_SUPPLIERService
		IASSET_BASE_SUPPLIERService iASSET_BASE_SUPPLIERService;
		public IASSET_BASE_SUPPLIERService IASSET_BASE_SUPPLIERService
		{
			get
			{
				if(iASSET_BASE_SUPPLIERService==null)
					iASSET_BASE_SUPPLIERService= new ASSET_BASE_SUPPLIERService();
				return iASSET_BASE_SUPPLIERService;
			}
			set
			{
				iASSET_BASE_SUPPLIERService= value;
			}
		}
		#endregion

    
		#region 11 业务接口 IASSET_BASE_SUPPLIER_MATERIALService
		IASSET_BASE_SUPPLIER_MATERIALService iASSET_BASE_SUPPLIER_MATERIALService;
		public IASSET_BASE_SUPPLIER_MATERIALService IASSET_BASE_SUPPLIER_MATERIALService
		{
			get
			{
				if(iASSET_BASE_SUPPLIER_MATERIALService==null)
					iASSET_BASE_SUPPLIER_MATERIALService= new ASSET_BASE_SUPPLIER_MATERIALService();
				return iASSET_BASE_SUPPLIER_MATERIALService;
			}
			set
			{
				iASSET_BASE_SUPPLIER_MATERIALService= value;
			}
		}
		#endregion

    
		#region 12 业务接口 IASSET_INVENTORYService
		IASSET_INVENTORYService iASSET_INVENTORYService;
		public IASSET_INVENTORYService IASSET_INVENTORYService
		{
			get
			{
				if(iASSET_INVENTORYService==null)
					iASSET_INVENTORYService= new ASSET_INVENTORYService();
				return iASSET_INVENTORYService;
			}
			set
			{
				iASSET_INVENTORYService= value;
			}
		}
		#endregion

    
		#region 13 业务接口 IASSET_MOBILEService
		IASSET_MOBILEService iASSET_MOBILEService;
		public IASSET_MOBILEService IASSET_MOBILEService
		{
			get
			{
				if(iASSET_MOBILEService==null)
					iASSET_MOBILEService= new ASSET_MOBILEService();
				return iASSET_MOBILEService;
			}
			set
			{
				iASSET_MOBILEService= value;
			}
		}
		#endregion

    
		#region 14 业务接口 IASSET_MRPService
		IASSET_MRPService iASSET_MRPService;
		public IASSET_MRPService IASSET_MRPService
		{
			get
			{
				if(iASSET_MRPService==null)
					iASSET_MRPService= new ASSET_MRPService();
				return iASSET_MRPService;
			}
			set
			{
				iASSET_MRPService= value;
			}
		}
		#endregion

    
		#region 15 业务接口 IASSET_MRP_BOMService
		IASSET_MRP_BOMService iASSET_MRP_BOMService;
		public IASSET_MRP_BOMService IASSET_MRP_BOMService
		{
			get
			{
				if(iASSET_MRP_BOMService==null)
					iASSET_MRP_BOMService= new ASSET_MRP_BOMService();
				return iASSET_MRP_BOMService;
			}
			set
			{
				iASSET_MRP_BOMService= value;
			}
		}
		#endregion

    
		#region 16 业务接口 IASSET_WAREHOUSEService
		IASSET_WAREHOUSEService iASSET_WAREHOUSEService;
		public IASSET_WAREHOUSEService IASSET_WAREHOUSEService
		{
			get
			{
				if(iASSET_WAREHOUSEService==null)
					iASSET_WAREHOUSEService= new ASSET_WAREHOUSEService();
				return iASSET_WAREHOUSEService;
			}
			set
			{
				iASSET_WAREHOUSEService= value;
			}
		}
		#endregion

    
		#region 17 业务接口 IBASE_BOUNDARYService
		IBASE_BOUNDARYService iBASE_BOUNDARYService;
		public IBASE_BOUNDARYService IBASE_BOUNDARYService
		{
			get
			{
				if(iBASE_BOUNDARYService==null)
					iBASE_BOUNDARYService= new BASE_BOUNDARYService();
				return iBASE_BOUNDARYService;
			}
			set
			{
				iBASE_BOUNDARYService= value;
			}
		}
		#endregion

    
		#region 18 业务接口 IBASE_DICTService
		IBASE_DICTService iBASE_DICTService;
		public IBASE_DICTService IBASE_DICTService
		{
			get
			{
				if(iBASE_DICTService==null)
					iBASE_DICTService= new BASE_DICTService();
				return iBASE_DICTService;
			}
			set
			{
				iBASE_DICTService= value;
			}
		}
		#endregion

    
		#region 19 业务接口 IBASE_LINEService
		IBASE_LINEService iBASE_LINEService;
		public IBASE_LINEService IBASE_LINEService
		{
			get
			{
				if(iBASE_LINEService==null)
					iBASE_LINEService= new BASE_LINEService();
				return iBASE_LINEService;
			}
			set
			{
				iBASE_LINEService= value;
			}
		}
		#endregion

    
		#region 20 业务接口 IBASE_STATIONService
		IBASE_STATIONService iBASE_STATIONService;
		public IBASE_STATIONService IBASE_STATIONService
		{
			get
			{
				if(iBASE_STATIONService==null)
					iBASE_STATIONService= new BASE_STATIONService();
				return iBASE_STATIONService;
			}
			set
			{
				iBASE_STATIONService= value;
			}
		}
		#endregion

    
		#region 21 业务接口 IBOOT_BASEService
		IBOOT_BASEService iBOOT_BASEService;
		public IBOOT_BASEService IBOOT_BASEService
		{
			get
			{
				if(iBOOT_BASEService==null)
					iBOOT_BASEService= new BOOT_BASEService();
				return iBOOT_BASEService;
			}
			set
			{
				iBOOT_BASEService= value;
			}
		}
		#endregion

    
		#region 22 业务接口 IBOOT_RECORDService
		IBOOT_RECORDService iBOOT_RECORDService;
		public IBOOT_RECORDService IBOOT_RECORDService
		{
			get
			{
				if(iBOOT_RECORDService==null)
					iBOOT_RECORDService= new BOOT_RECORDService();
				return iBOOT_RECORDService;
			}
			set
			{
				iBOOT_RECORDService= value;
			}
		}
		#endregion

    
		#region 23 业务接口 IBRIDGE_BOUNDService
		IBRIDGE_BOUNDService iBRIDGE_BOUNDService;
		public IBRIDGE_BOUNDService IBRIDGE_BOUNDService
		{
			get
			{
				if(iBRIDGE_BOUNDService==null)
					iBRIDGE_BOUNDService= new BRIDGE_BOUNDService();
				return iBRIDGE_BOUNDService;
			}
			set
			{
				iBRIDGE_BOUNDService= value;
			}
		}
		#endregion

    
		#region 24 业务接口 IBRIDGE_BRIDGEService
		IBRIDGE_BRIDGEService iBRIDGE_BRIDGEService;
		public IBRIDGE_BRIDGEService IBRIDGE_BRIDGEService
		{
			get
			{
				if(iBRIDGE_BRIDGEService==null)
					iBRIDGE_BRIDGEService= new BRIDGE_BRIDGEService();
				return iBRIDGE_BRIDGEService;
			}
			set
			{
				iBRIDGE_BRIDGEService= value;
			}
		}
		#endregion

    
		#region 25 业务接口 IBRIDGE_CULVERTService
		IBRIDGE_CULVERTService iBRIDGE_CULVERTService;
		public IBRIDGE_CULVERTService IBRIDGE_CULVERTService
		{
			get
			{
				if(iBRIDGE_CULVERTService==null)
					iBRIDGE_CULVERTService= new BRIDGE_CULVERTService();
				return iBRIDGE_CULVERTService;
			}
			set
			{
				iBRIDGE_CULVERTService= value;
			}
		}
		#endregion

    
		#region 26 业务接口 IBRIDGE_EQU_CLEARANCEService
		IBRIDGE_EQU_CLEARANCEService iBRIDGE_EQU_CLEARANCEService;
		public IBRIDGE_EQU_CLEARANCEService IBRIDGE_EQU_CLEARANCEService
		{
			get
			{
				if(iBRIDGE_EQU_CLEARANCEService==null)
					iBRIDGE_EQU_CLEARANCEService= new BRIDGE_EQU_CLEARANCEService();
				return iBRIDGE_EQU_CLEARANCEService;
			}
			set
			{
				iBRIDGE_EQU_CLEARANCEService= value;
			}
		}
		#endregion

    
		#region 27 业务接口 IBRIDGE_EQU_CLEARANCE_FILEService
		IBRIDGE_EQU_CLEARANCE_FILEService iBRIDGE_EQU_CLEARANCE_FILEService;
		public IBRIDGE_EQU_CLEARANCE_FILEService IBRIDGE_EQU_CLEARANCE_FILEService
		{
			get
			{
				if(iBRIDGE_EQU_CLEARANCE_FILEService==null)
					iBRIDGE_EQU_CLEARANCE_FILEService= new BRIDGE_EQU_CLEARANCE_FILEService();
				return iBRIDGE_EQU_CLEARANCE_FILEService;
			}
			set
			{
				iBRIDGE_EQU_CLEARANCE_FILEService= value;
			}
		}
		#endregion

    
		#region 28 业务接口 IBRIDGE_EQU_DATA_TEMPService
		IBRIDGE_EQU_DATA_TEMPService iBRIDGE_EQU_DATA_TEMPService;
		public IBRIDGE_EQU_DATA_TEMPService IBRIDGE_EQU_DATA_TEMPService
		{
			get
			{
				if(iBRIDGE_EQU_DATA_TEMPService==null)
					iBRIDGE_EQU_DATA_TEMPService= new BRIDGE_EQU_DATA_TEMPService();
				return iBRIDGE_EQU_DATA_TEMPService;
			}
			set
			{
				iBRIDGE_EQU_DATA_TEMPService= value;
			}
		}
		#endregion

    
		#region 29 业务接口 IBRIDGE_EQU_FILEService
		IBRIDGE_EQU_FILEService iBRIDGE_EQU_FILEService;
		public IBRIDGE_EQU_FILEService IBRIDGE_EQU_FILEService
		{
			get
			{
				if(iBRIDGE_EQU_FILEService==null)
					iBRIDGE_EQU_FILEService= new BRIDGE_EQU_FILEService();
				return iBRIDGE_EQU_FILEService;
			}
			set
			{
				iBRIDGE_EQU_FILEService= value;
			}
		}
		#endregion

    
		#region 30 业务接口 IBRIDGE_LIMITOVERHEADService
		IBRIDGE_LIMITOVERHEADService iBRIDGE_LIMITOVERHEADService;
		public IBRIDGE_LIMITOVERHEADService IBRIDGE_LIMITOVERHEADService
		{
			get
			{
				if(iBRIDGE_LIMITOVERHEADService==null)
					iBRIDGE_LIMITOVERHEADService= new BRIDGE_LIMITOVERHEADService();
				return iBRIDGE_LIMITOVERHEADService;
			}
			set
			{
				iBRIDGE_LIMITOVERHEADService= value;
			}
		}
		#endregion

    
		#region 31 业务接口 IBRIDGE_LRONService
		IBRIDGE_LRONService iBRIDGE_LRONService;
		public IBRIDGE_LRONService IBRIDGE_LRONService
		{
			get
			{
				if(iBRIDGE_LRONService==null)
					iBRIDGE_LRONService= new BRIDGE_LRONService();
				return iBRIDGE_LRONService;
			}
			set
			{
				iBRIDGE_LRONService= value;
			}
		}
		#endregion

    
		#region 32 业务接口 IBRIDGE_LRON_OVERPASSService
		IBRIDGE_LRON_OVERPASSService iBRIDGE_LRON_OVERPASSService;
		public IBRIDGE_LRON_OVERPASSService IBRIDGE_LRON_OVERPASSService
		{
			get
			{
				if(iBRIDGE_LRON_OVERPASSService==null)
					iBRIDGE_LRON_OVERPASSService= new BRIDGE_LRON_OVERPASSService();
				return iBRIDGE_LRON_OVERPASSService;
			}
			set
			{
				iBRIDGE_LRON_OVERPASSService= value;
			}
		}
		#endregion

    
		#region 33 业务接口 IBRIDGE_MAINTENAN_EVALUATEService
		IBRIDGE_MAINTENAN_EVALUATEService iBRIDGE_MAINTENAN_EVALUATEService;
		public IBRIDGE_MAINTENAN_EVALUATEService IBRIDGE_MAINTENAN_EVALUATEService
		{
			get
			{
				if(iBRIDGE_MAINTENAN_EVALUATEService==null)
					iBRIDGE_MAINTENAN_EVALUATEService= new BRIDGE_MAINTENAN_EVALUATEService();
				return iBRIDGE_MAINTENAN_EVALUATEService;
			}
			set
			{
				iBRIDGE_MAINTENAN_EVALUATEService= value;
			}
		}
		#endregion

    
		#region 34 业务接口 IBRIDGE_MAINTENAN_NOTICEService
		IBRIDGE_MAINTENAN_NOTICEService iBRIDGE_MAINTENAN_NOTICEService;
		public IBRIDGE_MAINTENAN_NOTICEService IBRIDGE_MAINTENAN_NOTICEService
		{
			get
			{
				if(iBRIDGE_MAINTENAN_NOTICEService==null)
					iBRIDGE_MAINTENAN_NOTICEService= new BRIDGE_MAINTENAN_NOTICEService();
				return iBRIDGE_MAINTENAN_NOTICEService;
			}
			set
			{
				iBRIDGE_MAINTENAN_NOTICEService= value;
			}
		}
		#endregion

    
		#region 35 业务接口 IBRIDGE_MAINTENAN_NOTICE_PROService
		IBRIDGE_MAINTENAN_NOTICE_PROService iBRIDGE_MAINTENAN_NOTICE_PROService;
		public IBRIDGE_MAINTENAN_NOTICE_PROService IBRIDGE_MAINTENAN_NOTICE_PROService
		{
			get
			{
				if(iBRIDGE_MAINTENAN_NOTICE_PROService==null)
					iBRIDGE_MAINTENAN_NOTICE_PROService= new BRIDGE_MAINTENAN_NOTICE_PROService();
				return iBRIDGE_MAINTENAN_NOTICE_PROService;
			}
			set
			{
				iBRIDGE_MAINTENAN_NOTICE_PROService= value;
			}
		}
		#endregion

    
		#region 36 业务接口 IBRIDGE_MAINTENAN_PROService
		IBRIDGE_MAINTENAN_PROService iBRIDGE_MAINTENAN_PROService;
		public IBRIDGE_MAINTENAN_PROService IBRIDGE_MAINTENAN_PROService
		{
			get
			{
				if(iBRIDGE_MAINTENAN_PROService==null)
					iBRIDGE_MAINTENAN_PROService= new BRIDGE_MAINTENAN_PROService();
				return iBRIDGE_MAINTENAN_PROService;
			}
			set
			{
				iBRIDGE_MAINTENAN_PROService= value;
			}
		}
		#endregion

    
		#region 37 业务接口 IBRIDGE_MAINTENAN_PRO_HISService
		IBRIDGE_MAINTENAN_PRO_HISService iBRIDGE_MAINTENAN_PRO_HISService;
		public IBRIDGE_MAINTENAN_PRO_HISService IBRIDGE_MAINTENAN_PRO_HISService
		{
			get
			{
				if(iBRIDGE_MAINTENAN_PRO_HISService==null)
					iBRIDGE_MAINTENAN_PRO_HISService= new BRIDGE_MAINTENAN_PRO_HISService();
				return iBRIDGE_MAINTENAN_PRO_HISService;
			}
			set
			{
				iBRIDGE_MAINTENAN_PRO_HISService= value;
			}
		}
		#endregion

    
		#region 38 业务接口 IBRIDGE_MAINTENAN_REPORTService
		IBRIDGE_MAINTENAN_REPORTService iBRIDGE_MAINTENAN_REPORTService;
		public IBRIDGE_MAINTENAN_REPORTService IBRIDGE_MAINTENAN_REPORTService
		{
			get
			{
				if(iBRIDGE_MAINTENAN_REPORTService==null)
					iBRIDGE_MAINTENAN_REPORTService= new BRIDGE_MAINTENAN_REPORTService();
				return iBRIDGE_MAINTENAN_REPORTService;
			}
			set
			{
				iBRIDGE_MAINTENAN_REPORTService= value;
			}
		}
		#endregion

    
		#region 39 业务接口 IBRIDGE_MSGService
		IBRIDGE_MSGService iBRIDGE_MSGService;
		public IBRIDGE_MSGService IBRIDGE_MSGService
		{
			get
			{
				if(iBRIDGE_MSGService==null)
					iBRIDGE_MSGService= new BRIDGE_MSGService();
				return iBRIDGE_MSGService;
			}
			set
			{
				iBRIDGE_MSGService= value;
			}
		}
		#endregion

    
		#region 40 业务接口 IBRIDGE_OTHER_DEVICEService
		IBRIDGE_OTHER_DEVICEService iBRIDGE_OTHER_DEVICEService;
		public IBRIDGE_OTHER_DEVICEService IBRIDGE_OTHER_DEVICEService
		{
			get
			{
				if(iBRIDGE_OTHER_DEVICEService==null)
					iBRIDGE_OTHER_DEVICEService= new BRIDGE_OTHER_DEVICEService();
				return iBRIDGE_OTHER_DEVICEService;
			}
			set
			{
				iBRIDGE_OTHER_DEVICEService= value;
			}
		}
		#endregion

    
		#region 41 业务接口 IBRIDGE_OVERPASSService
		IBRIDGE_OVERPASSService iBRIDGE_OVERPASSService;
		public IBRIDGE_OVERPASSService IBRIDGE_OVERPASSService
		{
			get
			{
				if(iBRIDGE_OVERPASSService==null)
					iBRIDGE_OVERPASSService= new BRIDGE_OVERPASSService();
				return iBRIDGE_OVERPASSService;
			}
			set
			{
				iBRIDGE_OVERPASSService= value;
			}
		}
		#endregion

    
		#region 42 业务接口 IBRIDGE_OVERPASS_WATERService
		IBRIDGE_OVERPASS_WATERService iBRIDGE_OVERPASS_WATERService;
		public IBRIDGE_OVERPASS_WATERService IBRIDGE_OVERPASS_WATERService
		{
			get
			{
				if(iBRIDGE_OVERPASS_WATERService==null)
					iBRIDGE_OVERPASS_WATERService= new BRIDGE_OVERPASS_WATERService();
				return iBRIDGE_OVERPASS_WATERService;
			}
			set
			{
				iBRIDGE_OVERPASS_WATERService= value;
			}
		}
		#endregion

    
		#region 43 业务接口 IBRIDGE_PARA_MAINTENANService
		IBRIDGE_PARA_MAINTENANService iBRIDGE_PARA_MAINTENANService;
		public IBRIDGE_PARA_MAINTENANService IBRIDGE_PARA_MAINTENANService
		{
			get
			{
				if(iBRIDGE_PARA_MAINTENANService==null)
					iBRIDGE_PARA_MAINTENANService= new BRIDGE_PARA_MAINTENANService();
				return iBRIDGE_PARA_MAINTENANService;
			}
			set
			{
				iBRIDGE_PARA_MAINTENANService= value;
			}
		}
		#endregion

    
		#region 44 业务接口 IBRIDGE_PARA_STATUSService
		IBRIDGE_PARA_STATUSService iBRIDGE_PARA_STATUSService;
		public IBRIDGE_PARA_STATUSService IBRIDGE_PARA_STATUSService
		{
			get
			{
				if(iBRIDGE_PARA_STATUSService==null)
					iBRIDGE_PARA_STATUSService= new BRIDGE_PARA_STATUSService();
				return iBRIDGE_PARA_STATUSService;
			}
			set
			{
				iBRIDGE_PARA_STATUSService= value;
			}
		}
		#endregion

    
		#region 45 业务接口 IBRIDGE_SHALLOW_FOUNDATIONService
		IBRIDGE_SHALLOW_FOUNDATIONService iBRIDGE_SHALLOW_FOUNDATIONService;
		public IBRIDGE_SHALLOW_FOUNDATIONService IBRIDGE_SHALLOW_FOUNDATIONService
		{
			get
			{
				if(iBRIDGE_SHALLOW_FOUNDATIONService==null)
					iBRIDGE_SHALLOW_FOUNDATIONService= new BRIDGE_SHALLOW_FOUNDATIONService();
				return iBRIDGE_SHALLOW_FOUNDATIONService;
			}
			set
			{
				iBRIDGE_SHALLOW_FOUNDATIONService= value;
			}
		}
		#endregion

    
		#region 46 业务接口 IBRIDGE_STATE_PROService
		IBRIDGE_STATE_PROService iBRIDGE_STATE_PROService;
		public IBRIDGE_STATE_PROService IBRIDGE_STATE_PROService
		{
			get
			{
				if(iBRIDGE_STATE_PROService==null)
					iBRIDGE_STATE_PROService= new BRIDGE_STATE_PROService();
				return iBRIDGE_STATE_PROService;
			}
			set
			{
				iBRIDGE_STATE_PROService= value;
			}
		}
		#endregion

    
		#region 47 业务接口 IBRIDGE_STATE_PRO_FILEService
		IBRIDGE_STATE_PRO_FILEService iBRIDGE_STATE_PRO_FILEService;
		public IBRIDGE_STATE_PRO_FILEService IBRIDGE_STATE_PRO_FILEService
		{
			get
			{
				if(iBRIDGE_STATE_PRO_FILEService==null)
					iBRIDGE_STATE_PRO_FILEService= new BRIDGE_STATE_PRO_FILEService();
				return iBRIDGE_STATE_PRO_FILEService;
			}
			set
			{
				iBRIDGE_STATE_PRO_FILEService= value;
			}
		}
		#endregion

    
		#region 48 业务接口 IBRIDGE_STATE_PRO_HISService
		IBRIDGE_STATE_PRO_HISService iBRIDGE_STATE_PRO_HISService;
		public IBRIDGE_STATE_PRO_HISService IBRIDGE_STATE_PRO_HISService
		{
			get
			{
				if(iBRIDGE_STATE_PRO_HISService==null)
					iBRIDGE_STATE_PRO_HISService= new BRIDGE_STATE_PRO_HISService();
				return iBRIDGE_STATE_PRO_HISService;
			}
			set
			{
				iBRIDGE_STATE_PRO_HISService= value;
			}
		}
		#endregion

    
		#region 49 业务接口 IBRIDGE_STATE_REPORTService
		IBRIDGE_STATE_REPORTService iBRIDGE_STATE_REPORTService;
		public IBRIDGE_STATE_REPORTService IBRIDGE_STATE_REPORTService
		{
			get
			{
				if(iBRIDGE_STATE_REPORTService==null)
					iBRIDGE_STATE_REPORTService= new BRIDGE_STATE_REPORTService();
				return iBRIDGE_STATE_REPORTService;
			}
			set
			{
				iBRIDGE_STATE_REPORTService= value;
			}
		}
		#endregion

    
		#region 50 业务接口 IBRIDGE_TUNNELService
		IBRIDGE_TUNNELService iBRIDGE_TUNNELService;
		public IBRIDGE_TUNNELService IBRIDGE_TUNNELService
		{
			get
			{
				if(iBRIDGE_TUNNELService==null)
					iBRIDGE_TUNNELService= new BRIDGE_TUNNELService();
				return iBRIDGE_TUNNELService;
			}
			set
			{
				iBRIDGE_TUNNELService= value;
			}
		}
		#endregion

    
		#region 51 业务接口 IBROKENRAIL_BDATA_BOUNDARYService
		IBROKENRAIL_BDATA_BOUNDARYService iBROKENRAIL_BDATA_BOUNDARYService;
		public IBROKENRAIL_BDATA_BOUNDARYService IBROKENRAIL_BDATA_BOUNDARYService
		{
			get
			{
				if(iBROKENRAIL_BDATA_BOUNDARYService==null)
					iBROKENRAIL_BDATA_BOUNDARYService= new BROKENRAIL_BDATA_BOUNDARYService();
				return iBROKENRAIL_BDATA_BOUNDARYService;
			}
			set
			{
				iBROKENRAIL_BDATA_BOUNDARYService= value;
			}
		}
		#endregion

    
		#region 52 业务接口 IBROKENRAIL_BDATA_DEVICEService
		IBROKENRAIL_BDATA_DEVICEService iBROKENRAIL_BDATA_DEVICEService;
		public IBROKENRAIL_BDATA_DEVICEService IBROKENRAIL_BDATA_DEVICEService
		{
			get
			{
				if(iBROKENRAIL_BDATA_DEVICEService==null)
					iBROKENRAIL_BDATA_DEVICEService= new BROKENRAIL_BDATA_DEVICEService();
				return iBROKENRAIL_BDATA_DEVICEService;
			}
			set
			{
				iBROKENRAIL_BDATA_DEVICEService= value;
			}
		}
		#endregion

    
		#region 53 业务接口 IBROKENRAIL_BDATA_DEVICE_STATUSService
		IBROKENRAIL_BDATA_DEVICE_STATUSService iBROKENRAIL_BDATA_DEVICE_STATUSService;
		public IBROKENRAIL_BDATA_DEVICE_STATUSService IBROKENRAIL_BDATA_DEVICE_STATUSService
		{
			get
			{
				if(iBROKENRAIL_BDATA_DEVICE_STATUSService==null)
					iBROKENRAIL_BDATA_DEVICE_STATUSService= new BROKENRAIL_BDATA_DEVICE_STATUSService();
				return iBROKENRAIL_BDATA_DEVICE_STATUSService;
			}
			set
			{
				iBROKENRAIL_BDATA_DEVICE_STATUSService= value;
			}
		}
		#endregion

    
		#region 54 业务接口 IBROKENRAIL_BDATA_SECTIONService
		IBROKENRAIL_BDATA_SECTIONService iBROKENRAIL_BDATA_SECTIONService;
		public IBROKENRAIL_BDATA_SECTIONService IBROKENRAIL_BDATA_SECTIONService
		{
			get
			{
				if(iBROKENRAIL_BDATA_SECTIONService==null)
					iBROKENRAIL_BDATA_SECTIONService= new BROKENRAIL_BDATA_SECTIONService();
				return iBROKENRAIL_BDATA_SECTIONService;
			}
			set
			{
				iBROKENRAIL_BDATA_SECTIONService= value;
			}
		}
		#endregion

    
		#region 55 业务接口 IBROKENRAIL_DEVICE_STATUSService
		IBROKENRAIL_DEVICE_STATUSService iBROKENRAIL_DEVICE_STATUSService;
		public IBROKENRAIL_DEVICE_STATUSService IBROKENRAIL_DEVICE_STATUSService
		{
			get
			{
				if(iBROKENRAIL_DEVICE_STATUSService==null)
					iBROKENRAIL_DEVICE_STATUSService= new BROKENRAIL_DEVICE_STATUSService();
				return iBROKENRAIL_DEVICE_STATUSService;
			}
			set
			{
				iBROKENRAIL_DEVICE_STATUSService= value;
			}
		}
		#endregion

    
		#region 56 业务接口 IBROKENRAIL_DEVICE_STATUSHISService
		IBROKENRAIL_DEVICE_STATUSHISService iBROKENRAIL_DEVICE_STATUSHISService;
		public IBROKENRAIL_DEVICE_STATUSHISService IBROKENRAIL_DEVICE_STATUSHISService
		{
			get
			{
				if(iBROKENRAIL_DEVICE_STATUSHISService==null)
					iBROKENRAIL_DEVICE_STATUSHISService= new BROKENRAIL_DEVICE_STATUSHISService();
				return iBROKENRAIL_DEVICE_STATUSHISService;
			}
			set
			{
				iBROKENRAIL_DEVICE_STATUSHISService= value;
			}
		}
		#endregion

    
		#region 57 业务接口 IBROKENRAIL_NEEDSENDService
		IBROKENRAIL_NEEDSENDService iBROKENRAIL_NEEDSENDService;
		public IBROKENRAIL_NEEDSENDService IBROKENRAIL_NEEDSENDService
		{
			get
			{
				if(iBROKENRAIL_NEEDSENDService==null)
					iBROKENRAIL_NEEDSENDService= new BROKENRAIL_NEEDSENDService();
				return iBROKENRAIL_NEEDSENDService;
			}
			set
			{
				iBROKENRAIL_NEEDSENDService= value;
			}
		}
		#endregion

    
		#region 58 业务接口 IBROKENRAIL_SECTION_LINEService
		IBROKENRAIL_SECTION_LINEService iBROKENRAIL_SECTION_LINEService;
		public IBROKENRAIL_SECTION_LINEService IBROKENRAIL_SECTION_LINEService
		{
			get
			{
				if(iBROKENRAIL_SECTION_LINEService==null)
					iBROKENRAIL_SECTION_LINEService= new BROKENRAIL_SECTION_LINEService();
				return iBROKENRAIL_SECTION_LINEService;
			}
			set
			{
				iBROKENRAIL_SECTION_LINEService= value;
			}
		}
		#endregion

    
		#region 59 业务接口 IBROKENRAIL_SECTION_STATUSService
		IBROKENRAIL_SECTION_STATUSService iBROKENRAIL_SECTION_STATUSService;
		public IBROKENRAIL_SECTION_STATUSService IBROKENRAIL_SECTION_STATUSService
		{
			get
			{
				if(iBROKENRAIL_SECTION_STATUSService==null)
					iBROKENRAIL_SECTION_STATUSService= new BROKENRAIL_SECTION_STATUSService();
				return iBROKENRAIL_SECTION_STATUSService;
			}
			set
			{
				iBROKENRAIL_SECTION_STATUSService= value;
			}
		}
		#endregion

    
		#region 60 业务接口 IBROKENRAIL_SECTION_STATUSHISService
		IBROKENRAIL_SECTION_STATUSHISService iBROKENRAIL_SECTION_STATUSHISService;
		public IBROKENRAIL_SECTION_STATUSHISService IBROKENRAIL_SECTION_STATUSHISService
		{
			get
			{
				if(iBROKENRAIL_SECTION_STATUSHISService==null)
					iBROKENRAIL_SECTION_STATUSHISService= new BROKENRAIL_SECTION_STATUSHISService();
				return iBROKENRAIL_SECTION_STATUSHISService;
			}
			set
			{
				iBROKENRAIL_SECTION_STATUSHISService= value;
			}
		}
		#endregion

    
		#region 61 业务接口 IBROKENRAIL_SOUND_SENDPHONEService
		IBROKENRAIL_SOUND_SENDPHONEService iBROKENRAIL_SOUND_SENDPHONEService;
		public IBROKENRAIL_SOUND_SENDPHONEService IBROKENRAIL_SOUND_SENDPHONEService
		{
			get
			{
				if(iBROKENRAIL_SOUND_SENDPHONEService==null)
					iBROKENRAIL_SOUND_SENDPHONEService= new BROKENRAIL_SOUND_SENDPHONEService();
				return iBROKENRAIL_SOUND_SENDPHONEService;
			}
			set
			{
				iBROKENRAIL_SOUND_SENDPHONEService= value;
			}
		}
		#endregion

    
		#region 62 业务接口 IBROKENRAIL_VOLTAGE_SMSService
		IBROKENRAIL_VOLTAGE_SMSService iBROKENRAIL_VOLTAGE_SMSService;
		public IBROKENRAIL_VOLTAGE_SMSService IBROKENRAIL_VOLTAGE_SMSService
		{
			get
			{
				if(iBROKENRAIL_VOLTAGE_SMSService==null)
					iBROKENRAIL_VOLTAGE_SMSService= new BROKENRAIL_VOLTAGE_SMSService();
				return iBROKENRAIL_VOLTAGE_SMSService;
			}
			set
			{
				iBROKENRAIL_VOLTAGE_SMSService= value;
			}
		}
		#endregion

    
		#region 63 业务接口 IBROKENRAIL_VOLTAGE_STATUSService
		IBROKENRAIL_VOLTAGE_STATUSService iBROKENRAIL_VOLTAGE_STATUSService;
		public IBROKENRAIL_VOLTAGE_STATUSService IBROKENRAIL_VOLTAGE_STATUSService
		{
			get
			{
				if(iBROKENRAIL_VOLTAGE_STATUSService==null)
					iBROKENRAIL_VOLTAGE_STATUSService= new BROKENRAIL_VOLTAGE_STATUSService();
				return iBROKENRAIL_VOLTAGE_STATUSService;
			}
			set
			{
				iBROKENRAIL_VOLTAGE_STATUSService= value;
			}
		}
		#endregion

    
		#region 64 业务接口 IBROKENRAIL_VOLTAGE_STATUSHISService
		IBROKENRAIL_VOLTAGE_STATUSHISService iBROKENRAIL_VOLTAGE_STATUSHISService;
		public IBROKENRAIL_VOLTAGE_STATUSHISService IBROKENRAIL_VOLTAGE_STATUSHISService
		{
			get
			{
				if(iBROKENRAIL_VOLTAGE_STATUSHISService==null)
					iBROKENRAIL_VOLTAGE_STATUSHISService= new BROKENRAIL_VOLTAGE_STATUSHISService();
				return iBROKENRAIL_VOLTAGE_STATUSHISService;
			}
			set
			{
				iBROKENRAIL_VOLTAGE_STATUSHISService= value;
			}
		}
		#endregion

    
		#region 65 业务接口 IBROKENRAIL_WARN_CONTROLService
		IBROKENRAIL_WARN_CONTROLService iBROKENRAIL_WARN_CONTROLService;
		public IBROKENRAIL_WARN_CONTROLService IBROKENRAIL_WARN_CONTROLService
		{
			get
			{
				if(iBROKENRAIL_WARN_CONTROLService==null)
					iBROKENRAIL_WARN_CONTROLService= new BROKENRAIL_WARN_CONTROLService();
				return iBROKENRAIL_WARN_CONTROLService;
			}
			set
			{
				iBROKENRAIL_WARN_CONTROLService= value;
			}
		}
		#endregion

    
		#region 66 业务接口 IBROKENRAIL_WARN_DEVICEService
		IBROKENRAIL_WARN_DEVICEService iBROKENRAIL_WARN_DEVICEService;
		public IBROKENRAIL_WARN_DEVICEService IBROKENRAIL_WARN_DEVICEService
		{
			get
			{
				if(iBROKENRAIL_WARN_DEVICEService==null)
					iBROKENRAIL_WARN_DEVICEService= new BROKENRAIL_WARN_DEVICEService();
				return iBROKENRAIL_WARN_DEVICEService;
			}
			set
			{
				iBROKENRAIL_WARN_DEVICEService= value;
			}
		}
		#endregion

    
		#region 67 业务接口 IBROKENRAIL_WARN_FLAGService
		IBROKENRAIL_WARN_FLAGService iBROKENRAIL_WARN_FLAGService;
		public IBROKENRAIL_WARN_FLAGService IBROKENRAIL_WARN_FLAGService
		{
			get
			{
				if(iBROKENRAIL_WARN_FLAGService==null)
					iBROKENRAIL_WARN_FLAGService= new BROKENRAIL_WARN_FLAGService();
				return iBROKENRAIL_WARN_FLAGService;
			}
			set
			{
				iBROKENRAIL_WARN_FLAGService= value;
			}
		}
		#endregion

    
		#region 68 业务接口 ICAR_BDATA_CARService
		ICAR_BDATA_CARService iCAR_BDATA_CARService;
		public ICAR_BDATA_CARService ICAR_BDATA_CARService
		{
			get
			{
				if(iCAR_BDATA_CARService==null)
					iCAR_BDATA_CARService= new CAR_BDATA_CARService();
				return iCAR_BDATA_CARService;
			}
			set
			{
				iCAR_BDATA_CARService= value;
			}
		}
		#endregion

    
		#region 69 业务接口 ICAR_LAST_LONLATService
		ICAR_LAST_LONLATService iCAR_LAST_LONLATService;
		public ICAR_LAST_LONLATService ICAR_LAST_LONLATService
		{
			get
			{
				if(iCAR_LAST_LONLATService==null)
					iCAR_LAST_LONLATService= new CAR_LAST_LONLATService();
				return iCAR_LAST_LONLATService;
			}
			set
			{
				iCAR_LAST_LONLATService= value;
			}
		}
		#endregion

    
		#region 70 业务接口 ICAR_OVER_SPEEDService
		ICAR_OVER_SPEEDService iCAR_OVER_SPEEDService;
		public ICAR_OVER_SPEEDService ICAR_OVER_SPEEDService
		{
			get
			{
				if(iCAR_OVER_SPEEDService==null)
					iCAR_OVER_SPEEDService= new CAR_OVER_SPEEDService();
				return iCAR_OVER_SPEEDService;
			}
			set
			{
				iCAR_OVER_SPEEDService= value;
			}
		}
		#endregion

    
		#region 71 业务接口 ICAR_OVERSPEED_WARNService
		ICAR_OVERSPEED_WARNService iCAR_OVERSPEED_WARNService;
		public ICAR_OVERSPEED_WARNService ICAR_OVERSPEED_WARNService
		{
			get
			{
				if(iCAR_OVERSPEED_WARNService==null)
					iCAR_OVERSPEED_WARNService= new CAR_OVERSPEED_WARNService();
				return iCAR_OVERSPEED_WARNService;
			}
			set
			{
				iCAR_OVERSPEED_WARNService= value;
			}
		}
		#endregion

    
		#region 72 业务接口 ICAR_PHONE_INFOService
		ICAR_PHONE_INFOService iCAR_PHONE_INFOService;
		public ICAR_PHONE_INFOService ICAR_PHONE_INFOService
		{
			get
			{
				if(iCAR_PHONE_INFOService==null)
					iCAR_PHONE_INFOService= new CAR_PHONE_INFOService();
				return iCAR_PHONE_INFOService;
			}
			set
			{
				iCAR_PHONE_INFOService= value;
			}
		}
		#endregion

    
		#region 73 业务接口 ICHARTService
		ICHARTService iCHARTService;
		public ICHARTService ICHARTService
		{
			get
			{
				if(iCHARTService==null)
					iCHARTService= new CHARTService();
				return iCHARTService;
			}
			set
			{
				iCHARTService= value;
			}
		}
		#endregion

    
		#region 74 业务接口 ICHK_BDATA_DEVICEService
		ICHK_BDATA_DEVICEService iCHK_BDATA_DEVICEService;
		public ICHK_BDATA_DEVICEService ICHK_BDATA_DEVICEService
		{
			get
			{
				if(iCHK_BDATA_DEVICEService==null)
					iCHK_BDATA_DEVICEService= new CHK_BDATA_DEVICEService();
				return iCHK_BDATA_DEVICEService;
			}
			set
			{
				iCHK_BDATA_DEVICEService= value;
			}
		}
		#endregion

    
		#region 75 业务接口 ICOMMAND_PUBLISHService
		ICOMMAND_PUBLISHService iCOMMAND_PUBLISHService;
		public ICOMMAND_PUBLISHService ICOMMAND_PUBLISHService
		{
			get
			{
				if(iCOMMAND_PUBLISHService==null)
					iCOMMAND_PUBLISHService= new COMMAND_PUBLISHService();
				return iCOMMAND_PUBLISHService;
			}
			set
			{
				iCOMMAND_PUBLISHService= value;
			}
		}
		#endregion

    
		#region 76 业务接口 ICOMMAND_PUBLISH_HISService
		ICOMMAND_PUBLISH_HISService iCOMMAND_PUBLISH_HISService;
		public ICOMMAND_PUBLISH_HISService ICOMMAND_PUBLISH_HISService
		{
			get
			{
				if(iCOMMAND_PUBLISH_HISService==null)
					iCOMMAND_PUBLISH_HISService= new COMMAND_PUBLISH_HISService();
				return iCOMMAND_PUBLISH_HISService;
			}
			set
			{
				iCOMMAND_PUBLISH_HISService= value;
			}
		}
		#endregion

    
		#region 77 业务接口 ICONFIR_CARService
		ICONFIR_CARService iCONFIR_CARService;
		public ICONFIR_CARService ICONFIR_CARService
		{
			get
			{
				if(iCONFIR_CARService==null)
					iCONFIR_CARService= new CONFIR_CARService();
				return iCONFIR_CARService;
			}
			set
			{
				iCONFIR_CARService= value;
			}
		}
		#endregion

    
		#region 78 业务接口 ICONFIR_CAR_PLANService
		ICONFIR_CAR_PLANService iCONFIR_CAR_PLANService;
		public ICONFIR_CAR_PLANService ICONFIR_CAR_PLANService
		{
			get
			{
				if(iCONFIR_CAR_PLANService==null)
					iCONFIR_CAR_PLANService= new CONFIR_CAR_PLANService();
				return iCONFIR_CAR_PLANService;
			}
			set
			{
				iCONFIR_CAR_PLANService= value;
			}
		}
		#endregion

    
		#region 79 业务接口 ICONFIR_CAR_WARNService
		ICONFIR_CAR_WARNService iCONFIR_CAR_WARNService;
		public ICONFIR_CAR_WARNService ICONFIR_CAR_WARNService
		{
			get
			{
				if(iCONFIR_CAR_WARNService==null)
					iCONFIR_CAR_WARNService= new CONFIR_CAR_WARNService();
				return iCONFIR_CAR_WARNService;
			}
			set
			{
				iCONFIR_CAR_WARNService= value;
			}
		}
		#endregion

    
		#region 80 业务接口 ICONTROL_FOUR_DICService
		ICONTROL_FOUR_DICService iCONTROL_FOUR_DICService;
		public ICONTROL_FOUR_DICService ICONTROL_FOUR_DICService
		{
			get
			{
				if(iCONTROL_FOUR_DICService==null)
					iCONTROL_FOUR_DICService= new CONTROL_FOUR_DICService();
				return iCONTROL_FOUR_DICService;
			}
			set
			{
				iCONTROL_FOUR_DICService= value;
			}
		}
		#endregion

    
		#region 81 业务接口 ICONTROL_FOUR_PLANService
		ICONTROL_FOUR_PLANService iCONTROL_FOUR_PLANService;
		public ICONTROL_FOUR_PLANService ICONTROL_FOUR_PLANService
		{
			get
			{
				if(iCONTROL_FOUR_PLANService==null)
					iCONTROL_FOUR_PLANService= new CONTROL_FOUR_PLANService();
				return iCONTROL_FOUR_PLANService;
			}
			set
			{
				iCONTROL_FOUR_PLANService= value;
			}
		}
		#endregion

    
		#region 82 业务接口 ICURVE_BASEService
		ICURVE_BASEService iCURVE_BASEService;
		public ICURVE_BASEService ICURVE_BASEService
		{
			get
			{
				if(iCURVE_BASEService==null)
					iCURVE_BASEService= new CURVE_BASEService();
				return iCURVE_BASEService;
			}
			set
			{
				iCURVE_BASEService= value;
			}
		}
		#endregion

    
		#region 83 业务接口 ICURVE_BASE_EXTService
		ICURVE_BASE_EXTService iCURVE_BASE_EXTService;
		public ICURVE_BASE_EXTService ICURVE_BASE_EXTService
		{
			get
			{
				if(iCURVE_BASE_EXTService==null)
					iCURVE_BASE_EXTService= new CURVE_BASE_EXTService();
				return iCURVE_BASE_EXTService;
			}
			set
			{
				iCURVE_BASE_EXTService= value;
			}
		}
		#endregion

    
		#region 84 业务接口 ICURVE_CWRService
		ICURVE_CWRService iCURVE_CWRService;
		public ICURVE_CWRService ICURVE_CWRService
		{
			get
			{
				if(iCURVE_CWRService==null)
					iCURVE_CWRService= new CURVE_CWRService();
				return iCURVE_CWRService;
			}
			set
			{
				iCURVE_CWRService= value;
			}
		}
		#endregion

    
		#region 85 业务接口 ICURVE_PICService
		ICURVE_PICService iCURVE_PICService;
		public ICURVE_PICService ICURVE_PICService
		{
			get
			{
				if(iCURVE_PICService==null)
					iCURVE_PICService= new CURVE_PICService();
				return iCURVE_PICService;
			}
			set
			{
				iCURVE_PICService= value;
			}
		}
		#endregion

    
		#region 86 业务接口 ICURVE_PSNService
		ICURVE_PSNService iCURVE_PSNService;
		public ICURVE_PSNService ICURVE_PSNService
		{
			get
			{
				if(iCURVE_PSNService==null)
					iCURVE_PSNService= new CURVE_PSNService();
				return iCURVE_PSNService;
			}
			set
			{
				iCURVE_PSNService= value;
			}
		}
		#endregion

    
		#region 87 业务接口 ICURVE_RAILService
		ICURVE_RAILService iCURVE_RAILService;
		public ICURVE_RAILService ICURVE_RAILService
		{
			get
			{
				if(iCURVE_RAILService==null)
					iCURVE_RAILService= new CURVE_RAILService();
				return iCURVE_RAILService;
			}
			set
			{
				iCURVE_RAILService= value;
			}
		}
		#endregion

    
		#region 88 业务接口 ICURVE_RAILWEARService
		ICURVE_RAILWEARService iCURVE_RAILWEARService;
		public ICURVE_RAILWEARService ICURVE_RAILWEARService
		{
			get
			{
				if(iCURVE_RAILWEARService==null)
					iCURVE_RAILWEARService= new CURVE_RAILWEARService();
				return iCURVE_RAILWEARService;
			}
			set
			{
				iCURVE_RAILWEARService= value;
			}
		}
		#endregion

    
		#region 89 业务接口 IDR_IDX_DOC_CONTENT_IService
		IDR_IDX_DOC_CONTENT_IService iDR_IDX_DOC_CONTENT_IService;
		public IDR_IDX_DOC_CONTENT_IService IDR_IDX_DOC_CONTENT_IService
		{
			get
			{
				if(iDR_IDX_DOC_CONTENT_IService==null)
					iDR_IDX_DOC_CONTENT_IService= new DR_IDX_DOC_CONTENT_IService();
				return iDR_IDX_DOC_CONTENT_IService;
			}
			set
			{
				iDR_IDX_DOC_CONTENT_IService= value;
			}
		}
		#endregion

    
		#region 90 业务接口 IDR_IDX_DOC_CONTENT_KService
		IDR_IDX_DOC_CONTENT_KService iDR_IDX_DOC_CONTENT_KService;
		public IDR_IDX_DOC_CONTENT_KService IDR_IDX_DOC_CONTENT_KService
		{
			get
			{
				if(iDR_IDX_DOC_CONTENT_KService==null)
					iDR_IDX_DOC_CONTENT_KService= new DR_IDX_DOC_CONTENT_KService();
				return iDR_IDX_DOC_CONTENT_KService;
			}
			set
			{
				iDR_IDX_DOC_CONTENT_KService= value;
			}
		}
		#endregion

    
		#region 91 业务接口 IDR_IDX_DOC_CONTENT_NService
		IDR_IDX_DOC_CONTENT_NService iDR_IDX_DOC_CONTENT_NService;
		public IDR_IDX_DOC_CONTENT_NService IDR_IDX_DOC_CONTENT_NService
		{
			get
			{
				if(iDR_IDX_DOC_CONTENT_NService==null)
					iDR_IDX_DOC_CONTENT_NService= new DR_IDX_DOC_CONTENT_NService();
				return iDR_IDX_DOC_CONTENT_NService;
			}
			set
			{
				iDR_IDX_DOC_CONTENT_NService= value;
			}
		}
		#endregion

    
		#region 92 业务接口 IDR_IDX_DOC_CONTENT_RService
		IDR_IDX_DOC_CONTENT_RService iDR_IDX_DOC_CONTENT_RService;
		public IDR_IDX_DOC_CONTENT_RService IDR_IDX_DOC_CONTENT_RService
		{
			get
			{
				if(iDR_IDX_DOC_CONTENT_RService==null)
					iDR_IDX_DOC_CONTENT_RService= new DR_IDX_DOC_CONTENT_RService();
				return iDR_IDX_DOC_CONTENT_RService;
			}
			set
			{
				iDR_IDX_DOC_CONTENT_RService= value;
			}
		}
		#endregion

    
		#region 93 业务接口 IEMERGENCY_MERCYService
		IEMERGENCY_MERCYService iEMERGENCY_MERCYService;
		public IEMERGENCY_MERCYService IEMERGENCY_MERCYService
		{
			get
			{
				if(iEMERGENCY_MERCYService==null)
					iEMERGENCY_MERCYService= new EMERGENCY_MERCYService();
				return iEMERGENCY_MERCYService;
			}
			set
			{
				iEMERGENCY_MERCYService= value;
			}
		}
		#endregion

    
		#region 94 业务接口 IEMERGENCY_RECService
		IEMERGENCY_RECService iEMERGENCY_RECService;
		public IEMERGENCY_RECService IEMERGENCY_RECService
		{
			get
			{
				if(iEMERGENCY_RECService==null)
					iEMERGENCY_RECService= new EMERGENCY_RECService();
				return iEMERGENCY_RECService;
			}
			set
			{
				iEMERGENCY_RECService= value;
			}
		}
		#endregion

    
		#region 95 业务接口 IEMERGENCY_REC_FILEService
		IEMERGENCY_REC_FILEService iEMERGENCY_REC_FILEService;
		public IEMERGENCY_REC_FILEService IEMERGENCY_REC_FILEService
		{
			get
			{
				if(iEMERGENCY_REC_FILEService==null)
					iEMERGENCY_REC_FILEService= new EMERGENCY_REC_FILEService();
				return iEMERGENCY_REC_FILEService;
			}
			set
			{
				iEMERGENCY_REC_FILEService= value;
			}
		}
		#endregion

    
		#region 96 业务接口 IEMERGENCY_REC_PHOTOService
		IEMERGENCY_REC_PHOTOService iEMERGENCY_REC_PHOTOService;
		public IEMERGENCY_REC_PHOTOService IEMERGENCY_REC_PHOTOService
		{
			get
			{
				if(iEMERGENCY_REC_PHOTOService==null)
					iEMERGENCY_REC_PHOTOService= new EMERGENCY_REC_PHOTOService();
				return iEMERGENCY_REC_PHOTOService;
			}
			set
			{
				iEMERGENCY_REC_PHOTOService= value;
			}
		}
		#endregion

    
		#region 97 业务接口 IEMERGENCY_RESCUEService
		IEMERGENCY_RESCUEService iEMERGENCY_RESCUEService;
		public IEMERGENCY_RESCUEService IEMERGENCY_RESCUEService
		{
			get
			{
				if(iEMERGENCY_RESCUEService==null)
					iEMERGENCY_RESCUEService= new EMERGENCY_RESCUEService();
				return iEMERGENCY_RESCUEService;
			}
			set
			{
				iEMERGENCY_RESCUEService= value;
			}
		}
		#endregion

    
		#region 98 业务接口 IEMERGENCY_RESCUE_TOOLService
		IEMERGENCY_RESCUE_TOOLService iEMERGENCY_RESCUE_TOOLService;
		public IEMERGENCY_RESCUE_TOOLService IEMERGENCY_RESCUE_TOOLService
		{
			get
			{
				if(iEMERGENCY_RESCUE_TOOLService==null)
					iEMERGENCY_RESCUE_TOOLService= new EMERGENCY_RESCUE_TOOLService();
				return iEMERGENCY_RESCUE_TOOLService;
			}
			set
			{
				iEMERGENCY_RESCUE_TOOLService= value;
			}
		}
		#endregion

    
		#region 99 业务接口 IEMERGENCY_RULESService
		IEMERGENCY_RULESService iEMERGENCY_RULESService;
		public IEMERGENCY_RULESService IEMERGENCY_RULESService
		{
			get
			{
				if(iEMERGENCY_RULESService==null)
					iEMERGENCY_RULESService= new EMERGENCY_RULESService();
				return iEMERGENCY_RULESService;
			}
			set
			{
				iEMERGENCY_RULESService= value;
			}
		}
		#endregion

    
		#region 100 业务接口 IEMERGENCY_TALENT_POOLService
		IEMERGENCY_TALENT_POOLService iEMERGENCY_TALENT_POOLService;
		public IEMERGENCY_TALENT_POOLService IEMERGENCY_TALENT_POOLService
		{
			get
			{
				if(iEMERGENCY_TALENT_POOLService==null)
					iEMERGENCY_TALENT_POOLService= new EMERGENCY_TALENT_POOLService();
				return iEMERGENCY_TALENT_POOLService;
			}
			set
			{
				iEMERGENCY_TALENT_POOLService= value;
			}
		}
		#endregion

    
		#region 101 业务接口 IEMERGENCY_VIECHLEService
		IEMERGENCY_VIECHLEService iEMERGENCY_VIECHLEService;
		public IEMERGENCY_VIECHLEService IEMERGENCY_VIECHLEService
		{
			get
			{
				if(iEMERGENCY_VIECHLEService==null)
					iEMERGENCY_VIECHLEService= new EMERGENCY_VIECHLEService();
				return iEMERGENCY_VIECHLEService;
			}
			set
			{
				iEMERGENCY_VIECHLEService= value;
			}
		}
		#endregion

    
		#region 102 业务接口 IENFORCEMENT_BDATAService
		IENFORCEMENT_BDATAService iENFORCEMENT_BDATAService;
		public IENFORCEMENT_BDATAService IENFORCEMENT_BDATAService
		{
			get
			{
				if(iENFORCEMENT_BDATAService==null)
					iENFORCEMENT_BDATAService= new ENFORCEMENT_BDATAService();
				return iENFORCEMENT_BDATAService;
			}
			set
			{
				iENFORCEMENT_BDATAService= value;
			}
		}
		#endregion

    
		#region 103 业务接口 IENFORCEMENT_BDATA_ONLINEService
		IENFORCEMENT_BDATA_ONLINEService iENFORCEMENT_BDATA_ONLINEService;
		public IENFORCEMENT_BDATA_ONLINEService IENFORCEMENT_BDATA_ONLINEService
		{
			get
			{
				if(iENFORCEMENT_BDATA_ONLINEService==null)
					iENFORCEMENT_BDATA_ONLINEService= new ENFORCEMENT_BDATA_ONLINEService();
				return iENFORCEMENT_BDATA_ONLINEService;
			}
			set
			{
				iENFORCEMENT_BDATA_ONLINEService= value;
			}
		}
		#endregion

    
		#region 104 业务接口 IENFORCEMENT_FILEService
		IENFORCEMENT_FILEService iENFORCEMENT_FILEService;
		public IENFORCEMENT_FILEService IENFORCEMENT_FILEService
		{
			get
			{
				if(iENFORCEMENT_FILEService==null)
					iENFORCEMENT_FILEService= new ENFORCEMENT_FILEService();
				return iENFORCEMENT_FILEService;
			}
			set
			{
				iENFORCEMENT_FILEService= value;
			}
		}
		#endregion

    
		#region 105 业务接口 IFIVET_INFOService
		IFIVET_INFOService iFIVET_INFOService;
		public IFIVET_INFOService IFIVET_INFOService
		{
			get
			{
				if(iFIVET_INFOService==null)
					iFIVET_INFOService= new FIVET_INFOService();
				return iFIVET_INFOService;
			}
			set
			{
				iFIVET_INFOService= value;
			}
		}
		#endregion

    
		#region 106 业务接口 IFIVET_INFO_FILEService
		IFIVET_INFO_FILEService iFIVET_INFO_FILEService;
		public IFIVET_INFO_FILEService IFIVET_INFO_FILEService
		{
			get
			{
				if(iFIVET_INFO_FILEService==null)
					iFIVET_INFO_FILEService= new FIVET_INFO_FILEService();
				return iFIVET_INFO_FILEService;
			}
			set
			{
				iFIVET_INFO_FILEService= value;
			}
		}
		#endregion

    
		#region 107 业务接口 IFIVET_INFO_PHOTOService
		IFIVET_INFO_PHOTOService iFIVET_INFO_PHOTOService;
		public IFIVET_INFO_PHOTOService IFIVET_INFO_PHOTOService
		{
			get
			{
				if(iFIVET_INFO_PHOTOService==null)
					iFIVET_INFO_PHOTOService= new FIVET_INFO_PHOTOService();
				return iFIVET_INFO_PHOTOService;
			}
			set
			{
				iFIVET_INFO_PHOTOService= value;
			}
		}
		#endregion

    
		#region 108 业务接口 IFIVET_INFO_TYPEService
		IFIVET_INFO_TYPEService iFIVET_INFO_TYPEService;
		public IFIVET_INFO_TYPEService IFIVET_INFO_TYPEService
		{
			get
			{
				if(iFIVET_INFO_TYPEService==null)
					iFIVET_INFO_TYPEService= new FIVET_INFO_TYPEService();
				return iFIVET_INFO_TYPEService;
			}
			set
			{
				iFIVET_INFO_TYPEService= value;
			}
		}
		#endregion

    
		#region 109 业务接口 IFIVET_INFO_VIDEOService
		IFIVET_INFO_VIDEOService iFIVET_INFO_VIDEOService;
		public IFIVET_INFO_VIDEOService IFIVET_INFO_VIDEOService
		{
			get
			{
				if(iFIVET_INFO_VIDEOService==null)
					iFIVET_INFO_VIDEOService= new FIVET_INFO_VIDEOService();
				return iFIVET_INFO_VIDEOService;
			}
			set
			{
				iFIVET_INFO_VIDEOService= value;
			}
		}
		#endregion

    
		#region 110 业务接口 IFLOODPOINTService
		IFLOODPOINTService iFLOODPOINTService;
		public IFLOODPOINTService IFLOODPOINTService
		{
			get
			{
				if(iFLOODPOINTService==null)
					iFLOODPOINTService= new FLOODPOINTService();
				return iFLOODPOINTService;
			}
			set
			{
				iFLOODPOINTService= value;
			}
		}
		#endregion

    
		#region 111 业务接口 IFLOW_BASEService
		IFLOW_BASEService iFLOW_BASEService;
		public IFLOW_BASEService IFLOW_BASEService
		{
			get
			{
				if(iFLOW_BASEService==null)
					iFLOW_BASEService= new FLOW_BASEService();
				return iFLOW_BASEService;
			}
			set
			{
				iFLOW_BASEService= value;
			}
		}
		#endregion

    
		#region 112 业务接口 IFLOW_JOBService
		IFLOW_JOBService iFLOW_JOBService;
		public IFLOW_JOBService IFLOW_JOBService
		{
			get
			{
				if(iFLOW_JOBService==null)
					iFLOW_JOBService= new FLOW_JOBService();
				return iFLOW_JOBService;
			}
			set
			{
				iFLOW_JOBService= value;
			}
		}
		#endregion

    
		#region 113 业务接口 IFLOW_STEPService
		IFLOW_STEPService iFLOW_STEPService;
		public IFLOW_STEPService IFLOW_STEPService
		{
			get
			{
				if(iFLOW_STEPService==null)
					iFLOW_STEPService= new FLOW_STEPService();
				return iFLOW_STEPService;
			}
			set
			{
				iFLOW_STEPService= value;
			}
		}
		#endregion

    
		#region 114 业务接口 IGATE_BDATA_CARDService
		IGATE_BDATA_CARDService iGATE_BDATA_CARDService;
		public IGATE_BDATA_CARDService IGATE_BDATA_CARDService
		{
			get
			{
				if(iGATE_BDATA_CARDService==null)
					iGATE_BDATA_CARDService= new GATE_BDATA_CARDService();
				return iGATE_BDATA_CARDService;
			}
			set
			{
				iGATE_BDATA_CARDService= value;
			}
		}
		#endregion

    
		#region 115 业务接口 IGATE_BDATA_CLIENTService
		IGATE_BDATA_CLIENTService iGATE_BDATA_CLIENTService;
		public IGATE_BDATA_CLIENTService IGATE_BDATA_CLIENTService
		{
			get
			{
				if(iGATE_BDATA_CLIENTService==null)
					iGATE_BDATA_CLIENTService= new GATE_BDATA_CLIENTService();
				return iGATE_BDATA_CLIENTService;
			}
			set
			{
				iGATE_BDATA_CLIENTService= value;
			}
		}
		#endregion

    
		#region 116 业务接口 IGATE_BDATA_DICService
		IGATE_BDATA_DICService iGATE_BDATA_DICService;
		public IGATE_BDATA_DICService IGATE_BDATA_DICService
		{
			get
			{
				if(iGATE_BDATA_DICService==null)
					iGATE_BDATA_DICService= new GATE_BDATA_DICService();
				return iGATE_BDATA_DICService;
			}
			set
			{
				iGATE_BDATA_DICService= value;
			}
		}
		#endregion

    
		#region 117 业务接口 IGATE_BDATA_GATEService
		IGATE_BDATA_GATEService iGATE_BDATA_GATEService;
		public IGATE_BDATA_GATEService IGATE_BDATA_GATEService
		{
			get
			{
				if(iGATE_BDATA_GATEService==null)
					iGATE_BDATA_GATEService= new GATE_BDATA_GATEService();
				return iGATE_BDATA_GATEService;
			}
			set
			{
				iGATE_BDATA_GATEService= value;
			}
		}
		#endregion

    
		#region 118 业务接口 IGATE_BDATA_LIMITService
		IGATE_BDATA_LIMITService iGATE_BDATA_LIMITService;
		public IGATE_BDATA_LIMITService IGATE_BDATA_LIMITService
		{
			get
			{
				if(iGATE_BDATA_LIMITService==null)
					iGATE_BDATA_LIMITService= new GATE_BDATA_LIMITService();
				return iGATE_BDATA_LIMITService;
			}
			set
			{
				iGATE_BDATA_LIMITService= value;
			}
		}
		#endregion

    
		#region 119 业务接口 IGATE_BDATA_SKYLIGHTService
		IGATE_BDATA_SKYLIGHTService iGATE_BDATA_SKYLIGHTService;
		public IGATE_BDATA_SKYLIGHTService IGATE_BDATA_SKYLIGHTService
		{
			get
			{
				if(iGATE_BDATA_SKYLIGHTService==null)
					iGATE_BDATA_SKYLIGHTService= new GATE_BDATA_SKYLIGHTService();
				return iGATE_BDATA_SKYLIGHTService;
			}
			set
			{
				iGATE_BDATA_SKYLIGHTService= value;
			}
		}
		#endregion

    
		#region 120 业务接口 IGATE_BDATA_TOOLService
		IGATE_BDATA_TOOLService iGATE_BDATA_TOOLService;
		public IGATE_BDATA_TOOLService IGATE_BDATA_TOOLService
		{
			get
			{
				if(iGATE_BDATA_TOOLService==null)
					iGATE_BDATA_TOOLService= new GATE_BDATA_TOOLService();
				return iGATE_BDATA_TOOLService;
			}
			set
			{
				iGATE_BDATA_TOOLService= value;
			}
		}
		#endregion

    
		#region 121 业务接口 IGATE_DEPT_MAPService
		IGATE_DEPT_MAPService iGATE_DEPT_MAPService;
		public IGATE_DEPT_MAPService IGATE_DEPT_MAPService
		{
			get
			{
				if(iGATE_DEPT_MAPService==null)
					iGATE_DEPT_MAPService= new GATE_DEPT_MAPService();
				return iGATE_DEPT_MAPService;
			}
			set
			{
				iGATE_DEPT_MAPService= value;
			}
		}
		#endregion

    
		#region 122 业务接口 IGATE_GATEMNG_AUTHHISTORYService
		IGATE_GATEMNG_AUTHHISTORYService iGATE_GATEMNG_AUTHHISTORYService;
		public IGATE_GATEMNG_AUTHHISTORYService IGATE_GATEMNG_AUTHHISTORYService
		{
			get
			{
				if(iGATE_GATEMNG_AUTHHISTORYService==null)
					iGATE_GATEMNG_AUTHHISTORYService= new GATE_GATEMNG_AUTHHISTORYService();
				return iGATE_GATEMNG_AUTHHISTORYService;
			}
			set
			{
				iGATE_GATEMNG_AUTHHISTORYService= value;
			}
		}
		#endregion

    
		#region 123 业务接口 IGATE_GATEMNG_AUTHORIZATIONService
		IGATE_GATEMNG_AUTHORIZATIONService iGATE_GATEMNG_AUTHORIZATIONService;
		public IGATE_GATEMNG_AUTHORIZATIONService IGATE_GATEMNG_AUTHORIZATIONService
		{
			get
			{
				if(iGATE_GATEMNG_AUTHORIZATIONService==null)
					iGATE_GATEMNG_AUTHORIZATIONService= new GATE_GATEMNG_AUTHORIZATIONService();
				return iGATE_GATEMNG_AUTHORIZATIONService;
			}
			set
			{
				iGATE_GATEMNG_AUTHORIZATIONService= value;
			}
		}
		#endregion

    
		#region 124 业务接口 IGATE_GATEMNG_CARDLISTService
		IGATE_GATEMNG_CARDLISTService iGATE_GATEMNG_CARDLISTService;
		public IGATE_GATEMNG_CARDLISTService IGATE_GATEMNG_CARDLISTService
		{
			get
			{
				if(iGATE_GATEMNG_CARDLISTService==null)
					iGATE_GATEMNG_CARDLISTService= new GATE_GATEMNG_CARDLISTService();
				return iGATE_GATEMNG_CARDLISTService;
			}
			set
			{
				iGATE_GATEMNG_CARDLISTService= value;
			}
		}
		#endregion

    
		#region 125 业务接口 IGATE_GATEMNG_INGATEService
		IGATE_GATEMNG_INGATEService iGATE_GATEMNG_INGATEService;
		public IGATE_GATEMNG_INGATEService IGATE_GATEMNG_INGATEService
		{
			get
			{
				if(iGATE_GATEMNG_INGATEService==null)
					iGATE_GATEMNG_INGATEService= new GATE_GATEMNG_INGATEService();
				return iGATE_GATEMNG_INGATEService;
			}
			set
			{
				iGATE_GATEMNG_INGATEService= value;
			}
		}
		#endregion

    
		#region 126 业务接口 IGATE_GATEMNG_INOUTService
		IGATE_GATEMNG_INOUTService iGATE_GATEMNG_INOUTService;
		public IGATE_GATEMNG_INOUTService IGATE_GATEMNG_INOUTService
		{
			get
			{
				if(iGATE_GATEMNG_INOUTService==null)
					iGATE_GATEMNG_INOUTService= new GATE_GATEMNG_INOUTService();
				return iGATE_GATEMNG_INOUTService;
			}
			set
			{
				iGATE_GATEMNG_INOUTService= value;
			}
		}
		#endregion

    
		#region 127 业务接口 IGATE_GATEMNG_INOUTHISService
		IGATE_GATEMNG_INOUTHISService iGATE_GATEMNG_INOUTHISService;
		public IGATE_GATEMNG_INOUTHISService IGATE_GATEMNG_INOUTHISService
		{
			get
			{
				if(iGATE_GATEMNG_INOUTHISService==null)
					iGATE_GATEMNG_INOUTHISService= new GATE_GATEMNG_INOUTHISService();
				return iGATE_GATEMNG_INOUTHISService;
			}
			set
			{
				iGATE_GATEMNG_INOUTHISService= value;
			}
		}
		#endregion

    
		#region 128 业务接口 IGATE_GATEMNG_LASTCARDLISTService
		IGATE_GATEMNG_LASTCARDLISTService iGATE_GATEMNG_LASTCARDLISTService;
		public IGATE_GATEMNG_LASTCARDLISTService IGATE_GATEMNG_LASTCARDLISTService
		{
			get
			{
				if(iGATE_GATEMNG_LASTCARDLISTService==null)
					iGATE_GATEMNG_LASTCARDLISTService= new GATE_GATEMNG_LASTCARDLISTService();
				return iGATE_GATEMNG_LASTCARDLISTService;
			}
			set
			{
				iGATE_GATEMNG_LASTCARDLISTService= value;
			}
		}
		#endregion

    
		#region 129 业务接口 IGATE_GATEMNG_LASTSTATEService
		IGATE_GATEMNG_LASTSTATEService iGATE_GATEMNG_LASTSTATEService;
		public IGATE_GATEMNG_LASTSTATEService IGATE_GATEMNG_LASTSTATEService
		{
			get
			{
				if(iGATE_GATEMNG_LASTSTATEService==null)
					iGATE_GATEMNG_LASTSTATEService= new GATE_GATEMNG_LASTSTATEService();
				return iGATE_GATEMNG_LASTSTATEService;
			}
			set
			{
				iGATE_GATEMNG_LASTSTATEService= value;
			}
		}
		#endregion

    
		#region 130 业务接口 IGATE_GATEMNG_LONGDISHISTORYService
		IGATE_GATEMNG_LONGDISHISTORYService iGATE_GATEMNG_LONGDISHISTORYService;
		public IGATE_GATEMNG_LONGDISHISTORYService IGATE_GATEMNG_LONGDISHISTORYService
		{
			get
			{
				if(iGATE_GATEMNG_LONGDISHISTORYService==null)
					iGATE_GATEMNG_LONGDISHISTORYService= new GATE_GATEMNG_LONGDISHISTORYService();
				return iGATE_GATEMNG_LONGDISHISTORYService;
			}
			set
			{
				iGATE_GATEMNG_LONGDISHISTORYService= value;
			}
		}
		#endregion

    
		#region 131 业务接口 IGATE_GATEMNG_STATEService
		IGATE_GATEMNG_STATEService iGATE_GATEMNG_STATEService;
		public IGATE_GATEMNG_STATEService IGATE_GATEMNG_STATEService
		{
			get
			{
				if(iGATE_GATEMNG_STATEService==null)
					iGATE_GATEMNG_STATEService= new GATE_GATEMNG_STATEService();
				return iGATE_GATEMNG_STATEService;
			}
			set
			{
				iGATE_GATEMNG_STATEService= value;
			}
		}
		#endregion

    
		#region 132 业务接口 IGATE_GATEMNG_WARNINGService
		IGATE_GATEMNG_WARNINGService iGATE_GATEMNG_WARNINGService;
		public IGATE_GATEMNG_WARNINGService IGATE_GATEMNG_WARNINGService
		{
			get
			{
				if(iGATE_GATEMNG_WARNINGService==null)
					iGATE_GATEMNG_WARNINGService= new GATE_GATEMNG_WARNINGService();
				return iGATE_GATEMNG_WARNINGService;
			}
			set
			{
				iGATE_GATEMNG_WARNINGService= value;
			}
		}
		#endregion

    
		#region 133 业务接口 IGATE_JOB_PLANService
		IGATE_JOB_PLANService iGATE_JOB_PLANService;
		public IGATE_JOB_PLANService IGATE_JOB_PLANService
		{
			get
			{
				if(iGATE_JOB_PLANService==null)
					iGATE_JOB_PLANService= new GATE_JOB_PLANService();
				return iGATE_JOB_PLANService;
			}
			set
			{
				iGATE_JOB_PLANService= value;
			}
		}
		#endregion

    
		#region 134 业务接口 IGATE_SEND_MSGService
		IGATE_SEND_MSGService iGATE_SEND_MSGService;
		public IGATE_SEND_MSGService IGATE_SEND_MSGService
		{
			get
			{
				if(iGATE_SEND_MSGService==null)
					iGATE_SEND_MSGService= new GATE_SEND_MSGService();
				return iGATE_SEND_MSGService;
			}
			set
			{
				iGATE_SEND_MSGService= value;
			}
		}
		#endregion

    
		#region 135 业务接口 IGATE_SEND_PHONENOService
		IGATE_SEND_PHONENOService iGATE_SEND_PHONENOService;
		public IGATE_SEND_PHONENOService IGATE_SEND_PHONENOService
		{
			get
			{
				if(iGATE_SEND_PHONENOService==null)
					iGATE_SEND_PHONENOService= new GATE_SEND_PHONENOService();
				return iGATE_SEND_PHONENOService;
			}
			set
			{
				iGATE_SEND_PHONENOService= value;
			}
		}
		#endregion

    
		#region 136 业务接口 IHEART_BROADCASTService
		IHEART_BROADCASTService iHEART_BROADCASTService;
		public IHEART_BROADCASTService IHEART_BROADCASTService
		{
			get
			{
				if(iHEART_BROADCASTService==null)
					iHEART_BROADCASTService= new HEART_BROADCASTService();
				return iHEART_BROADCASTService;
			}
			set
			{
				iHEART_BROADCASTService= value;
			}
		}
		#endregion

    
		#region 137 业务接口 IHEART_BROADCAST_HISService
		IHEART_BROADCAST_HISService iHEART_BROADCAST_HISService;
		public IHEART_BROADCAST_HISService IHEART_BROADCAST_HISService
		{
			get
			{
				if(iHEART_BROADCAST_HISService==null)
					iHEART_BROADCAST_HISService= new HEART_BROADCAST_HISService();
				return iHEART_BROADCAST_HISService;
			}
			set
			{
				iHEART_BROADCAST_HISService= value;
			}
		}
		#endregion

    
		#region 138 业务接口 IHEART_DG_DIS_PHONEService
		IHEART_DG_DIS_PHONEService iHEART_DG_DIS_PHONEService;
		public IHEART_DG_DIS_PHONEService IHEART_DG_DIS_PHONEService
		{
			get
			{
				if(iHEART_DG_DIS_PHONEService==null)
					iHEART_DG_DIS_PHONEService= new HEART_DG_DIS_PHONEService();
				return iHEART_DG_DIS_PHONEService;
			}
			set
			{
				iHEART_DG_DIS_PHONEService= value;
			}
		}
		#endregion

    
		#region 139 业务接口 IHEART_DG_VOLTAGE_SENDService
		IHEART_DG_VOLTAGE_SENDService iHEART_DG_VOLTAGE_SENDService;
		public IHEART_DG_VOLTAGE_SENDService IHEART_DG_VOLTAGE_SENDService
		{
			get
			{
				if(iHEART_DG_VOLTAGE_SENDService==null)
					iHEART_DG_VOLTAGE_SENDService= new HEART_DG_VOLTAGE_SENDService();
				return iHEART_DG_VOLTAGE_SENDService;
			}
			set
			{
				iHEART_DG_VOLTAGE_SENDService= value;
			}
		}
		#endregion

    
		#region 140 业务接口 IHEART_DG_WAVEService
		IHEART_DG_WAVEService iHEART_DG_WAVEService;
		public IHEART_DG_WAVEService IHEART_DG_WAVEService
		{
			get
			{
				if(iHEART_DG_WAVEService==null)
					iHEART_DG_WAVEService= new HEART_DG_WAVEService();
				return iHEART_DG_WAVEService;
			}
			set
			{
				iHEART_DG_WAVEService= value;
			}
		}
		#endregion

    
		#region 141 业务接口 IHEART_DG_WAVE_HEADService
		IHEART_DG_WAVE_HEADService iHEART_DG_WAVE_HEADService;
		public IHEART_DG_WAVE_HEADService IHEART_DG_WAVE_HEADService
		{
			get
			{
				if(iHEART_DG_WAVE_HEADService==null)
					iHEART_DG_WAVE_HEADService= new HEART_DG_WAVE_HEADService();
				return iHEART_DG_WAVE_HEADService;
			}
			set
			{
				iHEART_DG_WAVE_HEADService= value;
			}
		}
		#endregion

    
		#region 142 业务接口 IHEART_DG_WEBService
		IHEART_DG_WEBService iHEART_DG_WEBService;
		public IHEART_DG_WEBService IHEART_DG_WEBService
		{
			get
			{
				if(iHEART_DG_WEBService==null)
					iHEART_DG_WEBService= new HEART_DG_WEBService();
				return iHEART_DG_WEBService;
			}
			set
			{
				iHEART_DG_WEBService= value;
			}
		}
		#endregion

    
		#region 143 业务接口 IHEART_MESSAGEService
		IHEART_MESSAGEService iHEART_MESSAGEService;
		public IHEART_MESSAGEService IHEART_MESSAGEService
		{
			get
			{
				if(iHEART_MESSAGEService==null)
					iHEART_MESSAGEService= new HEART_MESSAGEService();
				return iHEART_MESSAGEService;
			}
			set
			{
				iHEART_MESSAGEService= value;
			}
		}
		#endregion

    
		#region 144 业务接口 IHEART_RECENT_SAService
		IHEART_RECENT_SAService iHEART_RECENT_SAService;
		public IHEART_RECENT_SAService IHEART_RECENT_SAService
		{
			get
			{
				if(iHEART_RECENT_SAService==null)
					iHEART_RECENT_SAService= new HEART_RECENT_SAService();
				return iHEART_RECENT_SAService;
			}
			set
			{
				iHEART_RECENT_SAService= value;
			}
		}
		#endregion

    
		#region 145 业务接口 IHIK_PIC_INFOService
		IHIK_PIC_INFOService iHIK_PIC_INFOService;
		public IHIK_PIC_INFOService IHIK_PIC_INFOService
		{
			get
			{
				if(iHIK_PIC_INFOService==null)
					iHIK_PIC_INFOService= new HIK_PIC_INFOService();
				return iHIK_PIC_INFOService;
			}
			set
			{
				iHIK_PIC_INFOService= value;
			}
		}
		#endregion

    
		#region 146 业务接口 IHRAIL_BALLASTService
		IHRAIL_BALLASTService iHRAIL_BALLASTService;
		public IHRAIL_BALLASTService IHRAIL_BALLASTService
		{
			get
			{
				if(iHRAIL_BALLASTService==null)
					iHRAIL_BALLASTService= new HRAIL_BALLASTService();
				return iHRAIL_BALLASTService;
			}
			set
			{
				iHRAIL_BALLASTService= value;
			}
		}
		#endregion

    
		#region 147 业务接口 IHRAIL_CROSSINGService
		IHRAIL_CROSSINGService iHRAIL_CROSSINGService;
		public IHRAIL_CROSSINGService IHRAIL_CROSSINGService
		{
			get
			{
				if(iHRAIL_CROSSINGService==null)
					iHRAIL_CROSSINGService= new HRAIL_CROSSINGService();
				return iHRAIL_CROSSINGService;
			}
			set
			{
				iHRAIL_CROSSINGService= value;
			}
		}
		#endregion

    
		#region 148 业务接口 IHRAIL_CURVEService
		IHRAIL_CURVEService iHRAIL_CURVEService;
		public IHRAIL_CURVEService IHRAIL_CURVEService
		{
			get
			{
				if(iHRAIL_CURVEService==null)
					iHRAIL_CURVEService= new HRAIL_CURVEService();
				return iHRAIL_CURVEService;
			}
			set
			{
				iHRAIL_CURVEService= value;
			}
		}
		#endregion

    
		#region 149 业务接口 IHRAIL_DEPT_STATIONService
		IHRAIL_DEPT_STATIONService iHRAIL_DEPT_STATIONService;
		public IHRAIL_DEPT_STATIONService IHRAIL_DEPT_STATIONService
		{
			get
			{
				if(iHRAIL_DEPT_STATIONService==null)
					iHRAIL_DEPT_STATIONService= new HRAIL_DEPT_STATIONService();
				return iHRAIL_DEPT_STATIONService;
			}
			set
			{
				iHRAIL_DEPT_STATIONService= value;
			}
		}
		#endregion

    
		#region 150 业务接口 IHRAIL_LINEUNITService
		IHRAIL_LINEUNITService iHRAIL_LINEUNITService;
		public IHRAIL_LINEUNITService IHRAIL_LINEUNITService
		{
			get
			{
				if(iHRAIL_LINEUNITService==null)
					iHRAIL_LINEUNITService= new HRAIL_LINEUNITService();
				return iHRAIL_LINEUNITService;
			}
			set
			{
				iHRAIL_LINEUNITService= value;
			}
		}
		#endregion

    
		#region 151 业务接口 IHRAIL_PARA_JOBITEMService
		IHRAIL_PARA_JOBITEMService iHRAIL_PARA_JOBITEMService;
		public IHRAIL_PARA_JOBITEMService IHRAIL_PARA_JOBITEMService
		{
			get
			{
				if(iHRAIL_PARA_JOBITEMService==null)
					iHRAIL_PARA_JOBITEMService= new HRAIL_PARA_JOBITEMService();
				return iHRAIL_PARA_JOBITEMService;
			}
			set
			{
				iHRAIL_PARA_JOBITEMService= value;
			}
		}
		#endregion

    
		#region 152 业务接口 IHRAIL_PARA_PROITEMService
		IHRAIL_PARA_PROITEMService iHRAIL_PARA_PROITEMService;
		public IHRAIL_PARA_PROITEMService IHRAIL_PARA_PROITEMService
		{
			get
			{
				if(iHRAIL_PARA_PROITEMService==null)
					iHRAIL_PARA_PROITEMService= new HRAIL_PARA_PROITEMService();
				return iHRAIL_PARA_PROITEMService;
			}
			set
			{
				iHRAIL_PARA_PROITEMService= value;
			}
		}
		#endregion

    
		#region 153 业务接口 IHRAIL_PARA_PROITEM_SCOREService
		IHRAIL_PARA_PROITEM_SCOREService iHRAIL_PARA_PROITEM_SCOREService;
		public IHRAIL_PARA_PROITEM_SCOREService IHRAIL_PARA_PROITEM_SCOREService
		{
			get
			{
				if(iHRAIL_PARA_PROITEM_SCOREService==null)
					iHRAIL_PARA_PROITEM_SCOREService= new HRAIL_PARA_PROITEM_SCOREService();
				return iHRAIL_PARA_PROITEM_SCOREService;
			}
			set
			{
				iHRAIL_PARA_PROITEM_SCOREService= value;
			}
		}
		#endregion

    
		#region 154 业务接口 IHRAIL_PLANService
		IHRAIL_PLANService iHRAIL_PLANService;
		public IHRAIL_PLANService IHRAIL_PLANService
		{
			get
			{
				if(iHRAIL_PLANService==null)
					iHRAIL_PLANService= new HRAIL_PLANService();
				return iHRAIL_PLANService;
			}
			set
			{
				iHRAIL_PLANService= value;
			}
		}
		#endregion

    
		#region 155 业务接口 IHRAIL_PLAN_EMPService
		IHRAIL_PLAN_EMPService iHRAIL_PLAN_EMPService;
		public IHRAIL_PLAN_EMPService IHRAIL_PLAN_EMPService
		{
			get
			{
				if(iHRAIL_PLAN_EMPService==null)
					iHRAIL_PLAN_EMPService= new HRAIL_PLAN_EMPService();
				return iHRAIL_PLAN_EMPService;
			}
			set
			{
				iHRAIL_PLAN_EMPService= value;
			}
		}
		#endregion

    
		#region 156 业务接口 IHRAIL_PLAN_FILEService
		IHRAIL_PLAN_FILEService iHRAIL_PLAN_FILEService;
		public IHRAIL_PLAN_FILEService IHRAIL_PLAN_FILEService
		{
			get
			{
				if(iHRAIL_PLAN_FILEService==null)
					iHRAIL_PLAN_FILEService= new HRAIL_PLAN_FILEService();
				return iHRAIL_PLAN_FILEService;
			}
			set
			{
				iHRAIL_PLAN_FILEService= value;
			}
		}
		#endregion

    
		#region 157 业务接口 IHRAIL_PLAN_FLOWService
		IHRAIL_PLAN_FLOWService iHRAIL_PLAN_FLOWService;
		public IHRAIL_PLAN_FLOWService IHRAIL_PLAN_FLOWService
		{
			get
			{
				if(iHRAIL_PLAN_FLOWService==null)
					iHRAIL_PLAN_FLOWService= new HRAIL_PLAN_FLOWService();
				return iHRAIL_PLAN_FLOWService;
			}
			set
			{
				iHRAIL_PLAN_FLOWService= value;
			}
		}
		#endregion

    
		#region 158 业务接口 IHRAIL_PLAN_ITEMService
		IHRAIL_PLAN_ITEMService iHRAIL_PLAN_ITEMService;
		public IHRAIL_PLAN_ITEMService IHRAIL_PLAN_ITEMService
		{
			get
			{
				if(iHRAIL_PLAN_ITEMService==null)
					iHRAIL_PLAN_ITEMService= new HRAIL_PLAN_ITEMService();
				return iHRAIL_PLAN_ITEMService;
			}
			set
			{
				iHRAIL_PLAN_ITEMService= value;
			}
		}
		#endregion

    
		#region 159 业务接口 IHRAIL_PLAN_LOCService
		IHRAIL_PLAN_LOCService iHRAIL_PLAN_LOCService;
		public IHRAIL_PLAN_LOCService IHRAIL_PLAN_LOCService
		{
			get
			{
				if(iHRAIL_PLAN_LOCService==null)
					iHRAIL_PLAN_LOCService= new HRAIL_PLAN_LOCService();
				return iHRAIL_PLAN_LOCService;
			}
			set
			{
				iHRAIL_PLAN_LOCService= value;
			}
		}
		#endregion

    
		#region 160 业务接口 IHRAIL_PLAN_MATERIALService
		IHRAIL_PLAN_MATERIALService iHRAIL_PLAN_MATERIALService;
		public IHRAIL_PLAN_MATERIALService IHRAIL_PLAN_MATERIALService
		{
			get
			{
				if(iHRAIL_PLAN_MATERIALService==null)
					iHRAIL_PLAN_MATERIALService= new HRAIL_PLAN_MATERIALService();
				return iHRAIL_PLAN_MATERIALService;
			}
			set
			{
				iHRAIL_PLAN_MATERIALService= value;
			}
		}
		#endregion

    
		#region 161 业务接口 IHRAIL_PLAN_PROBLEMService
		IHRAIL_PLAN_PROBLEMService iHRAIL_PLAN_PROBLEMService;
		public IHRAIL_PLAN_PROBLEMService IHRAIL_PLAN_PROBLEMService
		{
			get
			{
				if(iHRAIL_PLAN_PROBLEMService==null)
					iHRAIL_PLAN_PROBLEMService= new HRAIL_PLAN_PROBLEMService();
				return iHRAIL_PLAN_PROBLEMService;
			}
			set
			{
				iHRAIL_PLAN_PROBLEMService= value;
			}
		}
		#endregion

    
		#region 162 业务接口 IHRAIL_PLAN_TOOLService
		IHRAIL_PLAN_TOOLService iHRAIL_PLAN_TOOLService;
		public IHRAIL_PLAN_TOOLService IHRAIL_PLAN_TOOLService
		{
			get
			{
				if(iHRAIL_PLAN_TOOLService==null)
					iHRAIL_PLAN_TOOLService= new HRAIL_PLAN_TOOLService();
				return iHRAIL_PLAN_TOOLService;
			}
			set
			{
				iHRAIL_PLAN_TOOLService= value;
			}
		}
		#endregion

    
		#region 163 业务接口 IHRAIL_PLAN_YEARService
		IHRAIL_PLAN_YEARService iHRAIL_PLAN_YEARService;
		public IHRAIL_PLAN_YEARService IHRAIL_PLAN_YEARService
		{
			get
			{
				if(iHRAIL_PLAN_YEARService==null)
					iHRAIL_PLAN_YEARService= new HRAIL_PLAN_YEARService();
				return iHRAIL_PLAN_YEARService;
			}
			set
			{
				iHRAIL_PLAN_YEARService= value;
			}
		}
		#endregion

    
		#region 164 业务接口 IHRAIL_PROBLEMService
		IHRAIL_PROBLEMService iHRAIL_PROBLEMService;
		public IHRAIL_PROBLEMService IHRAIL_PROBLEMService
		{
			get
			{
				if(iHRAIL_PROBLEMService==null)
					iHRAIL_PROBLEMService= new HRAIL_PROBLEMService();
				return iHRAIL_PROBLEMService;
			}
			set
			{
				iHRAIL_PROBLEMService= value;
			}
		}
		#endregion

    
		#region 165 业务接口 IHRAIL_PROBLEM_DNYService
		IHRAIL_PROBLEM_DNYService iHRAIL_PROBLEM_DNYService;
		public IHRAIL_PROBLEM_DNYService IHRAIL_PROBLEM_DNYService
		{
			get
			{
				if(iHRAIL_PROBLEM_DNYService==null)
					iHRAIL_PROBLEM_DNYService= new HRAIL_PROBLEM_DNYService();
				return iHRAIL_PROBLEM_DNYService;
			}
			set
			{
				iHRAIL_PROBLEM_DNYService= value;
			}
		}
		#endregion

    
		#region 166 业务接口 IHRAIL_PROBLEM_FILEService
		IHRAIL_PROBLEM_FILEService iHRAIL_PROBLEM_FILEService;
		public IHRAIL_PROBLEM_FILEService IHRAIL_PROBLEM_FILEService
		{
			get
			{
				if(iHRAIL_PROBLEM_FILEService==null)
					iHRAIL_PROBLEM_FILEService= new HRAIL_PROBLEM_FILEService();
				return iHRAIL_PROBLEM_FILEService;
			}
			set
			{
				iHRAIL_PROBLEM_FILEService= value;
			}
		}
		#endregion

    
		#region 167 业务接口 IHRAIL_RAILService
		IHRAIL_RAILService iHRAIL_RAILService;
		public IHRAIL_RAILService IHRAIL_RAILService
		{
			get
			{
				if(iHRAIL_RAILService==null)
					iHRAIL_RAILService= new HRAIL_RAILService();
				return iHRAIL_RAILService;
			}
			set
			{
				iHRAIL_RAILService= value;
			}
		}
		#endregion

    
		#region 168 业务接口 IHRAIL_SLOPEService
		IHRAIL_SLOPEService iHRAIL_SLOPEService;
		public IHRAIL_SLOPEService IHRAIL_SLOPEService
		{
			get
			{
				if(iHRAIL_SLOPEService==null)
					iHRAIL_SLOPEService= new HRAIL_SLOPEService();
				return iHRAIL_SLOPEService;
			}
			set
			{
				iHRAIL_SLOPEService= value;
			}
		}
		#endregion

    
		#region 169 业务接口 IHRAIL_STARTMILEService
		IHRAIL_STARTMILEService iHRAIL_STARTMILEService;
		public IHRAIL_STARTMILEService IHRAIL_STARTMILEService
		{
			get
			{
				if(iHRAIL_STARTMILEService==null)
					iHRAIL_STARTMILEService= new HRAIL_STARTMILEService();
				return iHRAIL_STARTMILEService;
			}
			set
			{
				iHRAIL_STARTMILEService= value;
			}
		}
		#endregion

    
		#region 170 业务接口 IHRAIL_STATIONService
		IHRAIL_STATIONService iHRAIL_STATIONService;
		public IHRAIL_STATIONService IHRAIL_STATIONService
		{
			get
			{
				if(iHRAIL_STATIONService==null)
					iHRAIL_STATIONService= new HRAIL_STATIONService();
				return iHRAIL_STATIONService;
			}
			set
			{
				iHRAIL_STATIONService= value;
			}
		}
		#endregion

    
		#region 171 业务接口 IHRAIL_TQIService
		IHRAIL_TQIService iHRAIL_TQIService;
		public IHRAIL_TQIService IHRAIL_TQIService
		{
			get
			{
				if(iHRAIL_TQIService==null)
					iHRAIL_TQIService= new HRAIL_TQIService();
				return iHRAIL_TQIService;
			}
			set
			{
				iHRAIL_TQIService= value;
			}
		}
		#endregion

    
		#region 172 业务接口 IHRAIL_TRACKService
		IHRAIL_TRACKService iHRAIL_TRACKService;
		public IHRAIL_TRACKService IHRAIL_TRACKService
		{
			get
			{
				if(iHRAIL_TRACKService==null)
					iHRAIL_TRACKService= new HRAIL_TRACKService();
				return iHRAIL_TRACKService;
			}
			set
			{
				iHRAIL_TRACKService= value;
			}
		}
		#endregion

    
		#region 173 业务接口 IHRAIL_TURNOUTService
		IHRAIL_TURNOUTService iHRAIL_TURNOUTService;
		public IHRAIL_TURNOUTService IHRAIL_TURNOUTService
		{
			get
			{
				if(iHRAIL_TURNOUTService==null)
					iHRAIL_TURNOUTService= new HRAIL_TURNOUTService();
				return iHRAIL_TURNOUTService;
			}
			set
			{
				iHRAIL_TURNOUTService= value;
			}
		}
		#endregion

    
		#region 174 业务接口 IHRAIL_UNIT_VALService
		IHRAIL_UNIT_VALService iHRAIL_UNIT_VALService;
		public IHRAIL_UNIT_VALService IHRAIL_UNIT_VALService
		{
			get
			{
				if(iHRAIL_UNIT_VALService==null)
					iHRAIL_UNIT_VALService= new HRAIL_UNIT_VALService();
				return iHRAIL_UNIT_VALService;
			}
			set
			{
				iHRAIL_UNIT_VALService= value;
			}
		}
		#endregion

    
		#region 175 业务接口 IHRAIL_UNIT_VAL_DETAILService
		IHRAIL_UNIT_VAL_DETAILService iHRAIL_UNIT_VAL_DETAILService;
		public IHRAIL_UNIT_VAL_DETAILService IHRAIL_UNIT_VAL_DETAILService
		{
			get
			{
				if(iHRAIL_UNIT_VAL_DETAILService==null)
					iHRAIL_UNIT_VAL_DETAILService= new HRAIL_UNIT_VAL_DETAILService();
				return iHRAIL_UNIT_VAL_DETAILService;
			}
			set
			{
				iHRAIL_UNIT_VAL_DETAILService= value;
			}
		}
		#endregion

    
		#region 176 业务接口 IJOB_JOB_PLANService
		IJOB_JOB_PLANService iJOB_JOB_PLANService;
		public IJOB_JOB_PLANService IJOB_JOB_PLANService
		{
			get
			{
				if(iJOB_JOB_PLANService==null)
					iJOB_JOB_PLANService= new JOB_JOB_PLANService();
				return iJOB_JOB_PLANService;
			}
			set
			{
				iJOB_JOB_PLANService= value;
			}
		}
		#endregion

    
		#region 177 业务接口 IJOB_MSG_BATCHREPLYService
		IJOB_MSG_BATCHREPLYService iJOB_MSG_BATCHREPLYService;
		public IJOB_MSG_BATCHREPLYService IJOB_MSG_BATCHREPLYService
		{
			get
			{
				if(iJOB_MSG_BATCHREPLYService==null)
					iJOB_MSG_BATCHREPLYService= new JOB_MSG_BATCHREPLYService();
				return iJOB_MSG_BATCHREPLYService;
			}
			set
			{
				iJOB_MSG_BATCHREPLYService= value;
			}
		}
		#endregion

    
		#region 178 业务接口 IJOB_MSG_BATCHSENDService
		IJOB_MSG_BATCHSENDService iJOB_MSG_BATCHSENDService;
		public IJOB_MSG_BATCHSENDService IJOB_MSG_BATCHSENDService
		{
			get
			{
				if(iJOB_MSG_BATCHSENDService==null)
					iJOB_MSG_BATCHSENDService= new JOB_MSG_BATCHSENDService();
				return iJOB_MSG_BATCHSENDService;
			}
			set
			{
				iJOB_MSG_BATCHSENDService= value;
			}
		}
		#endregion

    
		#region 179 业务接口 IJOB_MSG_BATCHSENDPHOTOService
		IJOB_MSG_BATCHSENDPHOTOService iJOB_MSG_BATCHSENDPHOTOService;
		public IJOB_MSG_BATCHSENDPHOTOService IJOB_MSG_BATCHSENDPHOTOService
		{
			get
			{
				if(iJOB_MSG_BATCHSENDPHOTOService==null)
					iJOB_MSG_BATCHSENDPHOTOService= new JOB_MSG_BATCHSENDPHOTOService();
				return iJOB_MSG_BATCHSENDPHOTOService;
			}
			set
			{
				iJOB_MSG_BATCHSENDPHOTOService= value;
			}
		}
		#endregion

    
		#region 180 业务接口 IJOB_PLANService
		IJOB_PLANService iJOB_PLANService;
		public IJOB_PLANService IJOB_PLANService
		{
			get
			{
				if(iJOB_PLANService==null)
					iJOB_PLANService= new JOB_PLANService();
				return iJOB_PLANService;
			}
			set
			{
				iJOB_PLANService= value;
			}
		}
		#endregion

    
		#region 181 业务接口 IJOB_PLAN_ADDPASSENGER_TESTService
		IJOB_PLAN_ADDPASSENGER_TESTService iJOB_PLAN_ADDPASSENGER_TESTService;
		public IJOB_PLAN_ADDPASSENGER_TESTService IJOB_PLAN_ADDPASSENGER_TESTService
		{
			get
			{
				if(iJOB_PLAN_ADDPASSENGER_TESTService==null)
					iJOB_PLAN_ADDPASSENGER_TESTService= new JOB_PLAN_ADDPASSENGER_TESTService();
				return iJOB_PLAN_ADDPASSENGER_TESTService;
			}
			set
			{
				iJOB_PLAN_ADDPASSENGER_TESTService= value;
			}
		}
		#endregion

    
		#region 182 业务接口 IJOB_PLAN_APPROVALService
		IJOB_PLAN_APPROVALService iJOB_PLAN_APPROVALService;
		public IJOB_PLAN_APPROVALService IJOB_PLAN_APPROVALService
		{
			get
			{
				if(iJOB_PLAN_APPROVALService==null)
					iJOB_PLAN_APPROVALService= new JOB_PLAN_APPROVALService();
				return iJOB_PLAN_APPROVALService;
			}
			set
			{
				iJOB_PLAN_APPROVALService= value;
			}
		}
		#endregion

    
		#region 183 业务接口 IJOB_PLAN_BYTIMService
		IJOB_PLAN_BYTIMService iJOB_PLAN_BYTIMService;
		public IJOB_PLAN_BYTIMService IJOB_PLAN_BYTIMService
		{
			get
			{
				if(iJOB_PLAN_BYTIMService==null)
					iJOB_PLAN_BYTIMService= new JOB_PLAN_BYTIMService();
				return iJOB_PLAN_BYTIMService;
			}
			set
			{
				iJOB_PLAN_BYTIMService= value;
			}
		}
		#endregion

    
		#region 184 业务接口 IJOB_PLAN_CONTROLService
		IJOB_PLAN_CONTROLService iJOB_PLAN_CONTROLService;
		public IJOB_PLAN_CONTROLService IJOB_PLAN_CONTROLService
		{
			get
			{
				if(iJOB_PLAN_CONTROLService==null)
					iJOB_PLAN_CONTROLService= new JOB_PLAN_CONTROLService();
				return iJOB_PLAN_CONTROLService;
			}
			set
			{
				iJOB_PLAN_CONTROLService= value;
			}
		}
		#endregion

    
		#region 185 业务接口 IJOB_PLAN_DELINGHA_FILLService
		IJOB_PLAN_DELINGHA_FILLService iJOB_PLAN_DELINGHA_FILLService;
		public IJOB_PLAN_DELINGHA_FILLService IJOB_PLAN_DELINGHA_FILLService
		{
			get
			{
				if(iJOB_PLAN_DELINGHA_FILLService==null)
					iJOB_PLAN_DELINGHA_FILLService= new JOB_PLAN_DELINGHA_FILLService();
				return iJOB_PLAN_DELINGHA_FILLService;
			}
			set
			{
				iJOB_PLAN_DELINGHA_FILLService= value;
			}
		}
		#endregion

    
		#region 186 业务接口 IJOB_PLAN_DELINGHA_FILL_DETAILService
		IJOB_PLAN_DELINGHA_FILL_DETAILService iJOB_PLAN_DELINGHA_FILL_DETAILService;
		public IJOB_PLAN_DELINGHA_FILL_DETAILService IJOB_PLAN_DELINGHA_FILL_DETAILService
		{
			get
			{
				if(iJOB_PLAN_DELINGHA_FILL_DETAILService==null)
					iJOB_PLAN_DELINGHA_FILL_DETAILService= new JOB_PLAN_DELINGHA_FILL_DETAILService();
				return iJOB_PLAN_DELINGHA_FILL_DETAILService;
			}
			set
			{
				iJOB_PLAN_DELINGHA_FILL_DETAILService= value;
			}
		}
		#endregion

    
		#region 187 业务接口 IJOB_PLAN_DELINGHA_MONTHService
		IJOB_PLAN_DELINGHA_MONTHService iJOB_PLAN_DELINGHA_MONTHService;
		public IJOB_PLAN_DELINGHA_MONTHService IJOB_PLAN_DELINGHA_MONTHService
		{
			get
			{
				if(iJOB_PLAN_DELINGHA_MONTHService==null)
					iJOB_PLAN_DELINGHA_MONTHService= new JOB_PLAN_DELINGHA_MONTHService();
				return iJOB_PLAN_DELINGHA_MONTHService;
			}
			set
			{
				iJOB_PLAN_DELINGHA_MONTHService= value;
			}
		}
		#endregion

    
		#region 188 业务接口 IJOB_PLAN_DELINGHA_WEEKService
		IJOB_PLAN_DELINGHA_WEEKService iJOB_PLAN_DELINGHA_WEEKService;
		public IJOB_PLAN_DELINGHA_WEEKService IJOB_PLAN_DELINGHA_WEEKService
		{
			get
			{
				if(iJOB_PLAN_DELINGHA_WEEKService==null)
					iJOB_PLAN_DELINGHA_WEEKService= new JOB_PLAN_DELINGHA_WEEKService();
				return iJOB_PLAN_DELINGHA_WEEKService;
			}
			set
			{
				iJOB_PLAN_DELINGHA_WEEKService= value;
			}
		}
		#endregion

    
		#region 189 业务接口 IJOB_PLAN_EQUIPMENTService
		IJOB_PLAN_EQUIPMENTService iJOB_PLAN_EQUIPMENTService;
		public IJOB_PLAN_EQUIPMENTService IJOB_PLAN_EQUIPMENTService
		{
			get
			{
				if(iJOB_PLAN_EQUIPMENTService==null)
					iJOB_PLAN_EQUIPMENTService= new JOB_PLAN_EQUIPMENTService();
				return iJOB_PLAN_EQUIPMENTService;
			}
			set
			{
				iJOB_PLAN_EQUIPMENTService= value;
			}
		}
		#endregion

    
		#region 190 业务接口 IJOB_PLAN_LINEService
		IJOB_PLAN_LINEService iJOB_PLAN_LINEService;
		public IJOB_PLAN_LINEService IJOB_PLAN_LINEService
		{
			get
			{
				if(iJOB_PLAN_LINEService==null)
					iJOB_PLAN_LINEService= new JOB_PLAN_LINEService();
				return iJOB_PLAN_LINEService;
			}
			set
			{
				iJOB_PLAN_LINEService= value;
			}
		}
		#endregion

    
		#region 191 业务接口 IJOB_PLAN_LINE_EQUIANDTIMService
		IJOB_PLAN_LINE_EQUIANDTIMService iJOB_PLAN_LINE_EQUIANDTIMService;
		public IJOB_PLAN_LINE_EQUIANDTIMService IJOB_PLAN_LINE_EQUIANDTIMService
		{
			get
			{
				if(iJOB_PLAN_LINE_EQUIANDTIMService==null)
					iJOB_PLAN_LINE_EQUIANDTIMService= new JOB_PLAN_LINE_EQUIANDTIMService();
				return iJOB_PLAN_LINE_EQUIANDTIMService;
			}
			set
			{
				iJOB_PLAN_LINE_EQUIANDTIMService= value;
			}
		}
		#endregion

    
		#region 192 业务接口 IJOB_PLAN_LOOKOUTService
		IJOB_PLAN_LOOKOUTService iJOB_PLAN_LOOKOUTService;
		public IJOB_PLAN_LOOKOUTService IJOB_PLAN_LOOKOUTService
		{
			get
			{
				if(iJOB_PLAN_LOOKOUTService==null)
					iJOB_PLAN_LOOKOUTService= new JOB_PLAN_LOOKOUTService();
				return iJOB_PLAN_LOOKOUTService;
			}
			set
			{
				iJOB_PLAN_LOOKOUTService= value;
			}
		}
		#endregion

    
		#region 193 业务接口 IJOB_PLAN_MEMBERPHONE_MAPService
		IJOB_PLAN_MEMBERPHONE_MAPService iJOB_PLAN_MEMBERPHONE_MAPService;
		public IJOB_PLAN_MEMBERPHONE_MAPService IJOB_PLAN_MEMBERPHONE_MAPService
		{
			get
			{
				if(iJOB_PLAN_MEMBERPHONE_MAPService==null)
					iJOB_PLAN_MEMBERPHONE_MAPService= new JOB_PLAN_MEMBERPHONE_MAPService();
				return iJOB_PLAN_MEMBERPHONE_MAPService;
			}
			set
			{
				iJOB_PLAN_MEMBERPHONE_MAPService= value;
			}
		}
		#endregion

    
		#region 194 业务接口 IJOB_PLAN_OLDService
		IJOB_PLAN_OLDService iJOB_PLAN_OLDService;
		public IJOB_PLAN_OLDService IJOB_PLAN_OLDService
		{
			get
			{
				if(iJOB_PLAN_OLDService==null)
					iJOB_PLAN_OLDService= new JOB_PLAN_OLDService();
				return iJOB_PLAN_OLDService;
			}
			set
			{
				iJOB_PLAN_OLDService= value;
			}
		}
		#endregion

    
		#region 195 业务接口 IJOB_PLAN_PHONE_USERService
		IJOB_PLAN_PHONE_USERService iJOB_PLAN_PHONE_USERService;
		public IJOB_PLAN_PHONE_USERService IJOB_PLAN_PHONE_USERService
		{
			get
			{
				if(iJOB_PLAN_PHONE_USERService==null)
					iJOB_PLAN_PHONE_USERService= new JOB_PLAN_PHONE_USERService();
				return iJOB_PLAN_PHONE_USERService;
			}
			set
			{
				iJOB_PLAN_PHONE_USERService= value;
			}
		}
		#endregion

    
		#region 196 业务接口 IJOB_PLAN_SAFEService
		IJOB_PLAN_SAFEService iJOB_PLAN_SAFEService;
		public IJOB_PLAN_SAFEService IJOB_PLAN_SAFEService
		{
			get
			{
				if(iJOB_PLAN_SAFEService==null)
					iJOB_PLAN_SAFEService= new JOB_PLAN_SAFEService();
				return iJOB_PLAN_SAFEService;
			}
			set
			{
				iJOB_PLAN_SAFEService= value;
			}
		}
		#endregion

    
		#region 197 业务接口 IJOB_PLAN_TRAINService
		IJOB_PLAN_TRAINService iJOB_PLAN_TRAINService;
		public IJOB_PLAN_TRAINService IJOB_PLAN_TRAINService
		{
			get
			{
				if(iJOB_PLAN_TRAINService==null)
					iJOB_PLAN_TRAINService= new JOB_PLAN_TRAINService();
				return iJOB_PLAN_TRAINService;
			}
			set
			{
				iJOB_PLAN_TRAINService= value;
			}
		}
		#endregion

    
		#region 198 业务接口 IJOB_PLAN_TYPEService
		IJOB_PLAN_TYPEService iJOB_PLAN_TYPEService;
		public IJOB_PLAN_TYPEService IJOB_PLAN_TYPEService
		{
			get
			{
				if(iJOB_PLAN_TYPEService==null)
					iJOB_PLAN_TYPEService= new JOB_PLAN_TYPEService();
				return iJOB_PLAN_TYPEService;
			}
			set
			{
				iJOB_PLAN_TYPEService= value;
			}
		}
		#endregion

    
		#region 199 业务接口 IJOB_PLAN_UPDOWNService
		IJOB_PLAN_UPDOWNService iJOB_PLAN_UPDOWNService;
		public IJOB_PLAN_UPDOWNService IJOB_PLAN_UPDOWNService
		{
			get
			{
				if(iJOB_PLAN_UPDOWNService==null)
					iJOB_PLAN_UPDOWNService= new JOB_PLAN_UPDOWNService();
				return iJOB_PLAN_UPDOWNService;
			}
			set
			{
				iJOB_PLAN_UPDOWNService= value;
			}
		}
		#endregion

    
		#region 200 业务接口 IJOB_PLAN_UPDOWNHISService
		IJOB_PLAN_UPDOWNHISService iJOB_PLAN_UPDOWNHISService;
		public IJOB_PLAN_UPDOWNHISService IJOB_PLAN_UPDOWNHISService
		{
			get
			{
				if(iJOB_PLAN_UPDOWNHISService==null)
					iJOB_PLAN_UPDOWNHISService= new JOB_PLAN_UPDOWNHISService();
				return iJOB_PLAN_UPDOWNHISService;
			}
			set
			{
				iJOB_PLAN_UPDOWNHISService= value;
			}
		}
		#endregion

    
		#region 201 业务接口 IJOB_PLAN_WARNPHONESETService
		IJOB_PLAN_WARNPHONESETService iJOB_PLAN_WARNPHONESETService;
		public IJOB_PLAN_WARNPHONESETService IJOB_PLAN_WARNPHONESETService
		{
			get
			{
				if(iJOB_PLAN_WARNPHONESETService==null)
					iJOB_PLAN_WARNPHONESETService= new JOB_PLAN_WARNPHONESETService();
				return iJOB_PLAN_WARNPHONESETService;
			}
			set
			{
				iJOB_PLAN_WARNPHONESETService= value;
			}
		}
		#endregion

    
		#region 202 业务接口 IJOB_PLAN_WARNPOSSETService
		IJOB_PLAN_WARNPOSSETService iJOB_PLAN_WARNPOSSETService;
		public IJOB_PLAN_WARNPOSSETService IJOB_PLAN_WARNPOSSETService
		{
			get
			{
				if(iJOB_PLAN_WARNPOSSETService==null)
					iJOB_PLAN_WARNPOSSETService= new JOB_PLAN_WARNPOSSETService();
				return iJOB_PLAN_WARNPOSSETService;
			}
			set
			{
				iJOB_PLAN_WARNPOSSETService= value;
			}
		}
		#endregion

    
		#region 203 业务接口 IJOB_PLANCONTROL_COMMANDService
		IJOB_PLANCONTROL_COMMANDService iJOB_PLANCONTROL_COMMANDService;
		public IJOB_PLANCONTROL_COMMANDService IJOB_PLANCONTROL_COMMANDService
		{
			get
			{
				if(iJOB_PLANCONTROL_COMMANDService==null)
					iJOB_PLANCONTROL_COMMANDService= new JOB_PLANCONTROL_COMMANDService();
				return iJOB_PLANCONTROL_COMMANDService;
			}
			set
			{
				iJOB_PLANCONTROL_COMMANDService= value;
			}
		}
		#endregion

    
		#region 204 业务接口 IJOB_WARNService
		IJOB_WARNService iJOB_WARNService;
		public IJOB_WARNService IJOB_WARNService
		{
			get
			{
				if(iJOB_WARNService==null)
					iJOB_WARNService= new JOB_WARNService();
				return iJOB_WARNService;
			}
			set
			{
				iJOB_WARNService= value;
			}
		}
		#endregion

    
		#region 205 业务接口 ILEDGER_BIGEQUI_TECHPARAMService
		ILEDGER_BIGEQUI_TECHPARAMService iLEDGER_BIGEQUI_TECHPARAMService;
		public ILEDGER_BIGEQUI_TECHPARAMService ILEDGER_BIGEQUI_TECHPARAMService
		{
			get
			{
				if(iLEDGER_BIGEQUI_TECHPARAMService==null)
					iLEDGER_BIGEQUI_TECHPARAMService= new LEDGER_BIGEQUI_TECHPARAMService();
				return iLEDGER_BIGEQUI_TECHPARAMService;
			}
			set
			{
				iLEDGER_BIGEQUI_TECHPARAMService= value;
			}
		}
		#endregion

    
		#region 206 业务接口 ILEDGER_DICT_INTERPHONEService
		ILEDGER_DICT_INTERPHONEService iLEDGER_DICT_INTERPHONEService;
		public ILEDGER_DICT_INTERPHONEService ILEDGER_DICT_INTERPHONEService
		{
			get
			{
				if(iLEDGER_DICT_INTERPHONEService==null)
					iLEDGER_DICT_INTERPHONEService= new LEDGER_DICT_INTERPHONEService();
				return iLEDGER_DICT_INTERPHONEService;
			}
			set
			{
				iLEDGER_DICT_INTERPHONEService= value;
			}
		}
		#endregion

    
		#region 207 业务接口 ILEDGER_DICT_LARGEMACHINERYService
		ILEDGER_DICT_LARGEMACHINERYService iLEDGER_DICT_LARGEMACHINERYService;
		public ILEDGER_DICT_LARGEMACHINERYService ILEDGER_DICT_LARGEMACHINERYService
		{
			get
			{
				if(iLEDGER_DICT_LARGEMACHINERYService==null)
					iLEDGER_DICT_LARGEMACHINERYService= new LEDGER_DICT_LARGEMACHINERYService();
				return iLEDGER_DICT_LARGEMACHINERYService;
			}
			set
			{
				iLEDGER_DICT_LARGEMACHINERYService= value;
			}
		}
		#endregion

    
		#region 208 业务接口 ILEDGER_DICT_MACHINETOOLService
		ILEDGER_DICT_MACHINETOOLService iLEDGER_DICT_MACHINETOOLService;
		public ILEDGER_DICT_MACHINETOOLService ILEDGER_DICT_MACHINETOOLService
		{
			get
			{
				if(iLEDGER_DICT_MACHINETOOLService==null)
					iLEDGER_DICT_MACHINETOOLService= new LEDGER_DICT_MACHINETOOLService();
				return iLEDGER_DICT_MACHINETOOLService;
			}
			set
			{
				iLEDGER_DICT_MACHINETOOLService= value;
			}
		}
		#endregion

    
		#region 209 业务接口 ILEDGER_DICT_MECHANICALVEHICLEService
		ILEDGER_DICT_MECHANICALVEHICLEService iLEDGER_DICT_MECHANICALVEHICLEService;
		public ILEDGER_DICT_MECHANICALVEHICLEService ILEDGER_DICT_MECHANICALVEHICLEService
		{
			get
			{
				if(iLEDGER_DICT_MECHANICALVEHICLEService==null)
					iLEDGER_DICT_MECHANICALVEHICLEService= new LEDGER_DICT_MECHANICALVEHICLEService();
				return iLEDGER_DICT_MECHANICALVEHICLEService;
			}
			set
			{
				iLEDGER_DICT_MECHANICALVEHICLEService= value;
			}
		}
		#endregion

    
		#region 210 业务接口 ILEDGER_DICT_ROADVEHICLEService
		ILEDGER_DICT_ROADVEHICLEService iLEDGER_DICT_ROADVEHICLEService;
		public ILEDGER_DICT_ROADVEHICLEService ILEDGER_DICT_ROADVEHICLEService
		{
			get
			{
				if(iLEDGER_DICT_ROADVEHICLEService==null)
					iLEDGER_DICT_ROADVEHICLEService= new LEDGER_DICT_ROADVEHICLEService();
				return iLEDGER_DICT_ROADVEHICLEService;
			}
			set
			{
				iLEDGER_DICT_ROADVEHICLEService= value;
			}
		}
		#endregion

    
		#region 211 业务接口 ILEDGER_DICT_TRAFFICVEHICLEService
		ILEDGER_DICT_TRAFFICVEHICLEService iLEDGER_DICT_TRAFFICVEHICLEService;
		public ILEDGER_DICT_TRAFFICVEHICLEService ILEDGER_DICT_TRAFFICVEHICLEService
		{
			get
			{
				if(iLEDGER_DICT_TRAFFICVEHICLEService==null)
					iLEDGER_DICT_TRAFFICVEHICLEService= new LEDGER_DICT_TRAFFICVEHICLEService();
				return iLEDGER_DICT_TRAFFICVEHICLEService;
			}
			set
			{
				iLEDGER_DICT_TRAFFICVEHICLEService= value;
			}
		}
		#endregion

    
		#region 212 业务接口 ILEDGER_INTERPHONEService
		ILEDGER_INTERPHONEService iLEDGER_INTERPHONEService;
		public ILEDGER_INTERPHONEService ILEDGER_INTERPHONEService
		{
			get
			{
				if(iLEDGER_INTERPHONEService==null)
					iLEDGER_INTERPHONEService= new LEDGER_INTERPHONEService();
				return iLEDGER_INTERPHONEService;
			}
			set
			{
				iLEDGER_INTERPHONEService= value;
			}
		}
		#endregion

    
		#region 213 业务接口 ILEDGER_LARGE_MACHINERYService
		ILEDGER_LARGE_MACHINERYService iLEDGER_LARGE_MACHINERYService;
		public ILEDGER_LARGE_MACHINERYService ILEDGER_LARGE_MACHINERYService
		{
			get
			{
				if(iLEDGER_LARGE_MACHINERYService==null)
					iLEDGER_LARGE_MACHINERYService= new LEDGER_LARGE_MACHINERYService();
				return iLEDGER_LARGE_MACHINERYService;
			}
			set
			{
				iLEDGER_LARGE_MACHINERYService= value;
			}
		}
		#endregion

    
		#region 214 业务接口 ILEDGER_LEVELCROSS_INFOService
		ILEDGER_LEVELCROSS_INFOService iLEDGER_LEVELCROSS_INFOService;
		public ILEDGER_LEVELCROSS_INFOService ILEDGER_LEVELCROSS_INFOService
		{
			get
			{
				if(iLEDGER_LEVELCROSS_INFOService==null)
					iLEDGER_LEVELCROSS_INFOService= new LEDGER_LEVELCROSS_INFOService();
				return iLEDGER_LEVELCROSS_INFOService;
			}
			set
			{
				iLEDGER_LEVELCROSS_INFOService= value;
			}
		}
		#endregion

    
		#region 215 业务接口 ILEDGER_LEVELCROSS_PIPE_LINEService
		ILEDGER_LEVELCROSS_PIPE_LINEService iLEDGER_LEVELCROSS_PIPE_LINEService;
		public ILEDGER_LEVELCROSS_PIPE_LINEService ILEDGER_LEVELCROSS_PIPE_LINEService
		{
			get
			{
				if(iLEDGER_LEVELCROSS_PIPE_LINEService==null)
					iLEDGER_LEVELCROSS_PIPE_LINEService= new LEDGER_LEVELCROSS_PIPE_LINEService();
				return iLEDGER_LEVELCROSS_PIPE_LINEService;
			}
			set
			{
				iLEDGER_LEVELCROSS_PIPE_LINEService= value;
			}
		}
		#endregion

    
		#region 216 业务接口 ILEDGER_LEVELCROSS_REPAIR_LINEService
		ILEDGER_LEVELCROSS_REPAIR_LINEService iLEDGER_LEVELCROSS_REPAIR_LINEService;
		public ILEDGER_LEVELCROSS_REPAIR_LINEService ILEDGER_LEVELCROSS_REPAIR_LINEService
		{
			get
			{
				if(iLEDGER_LEVELCROSS_REPAIR_LINEService==null)
					iLEDGER_LEVELCROSS_REPAIR_LINEService= new LEDGER_LEVELCROSS_REPAIR_LINEService();
				return iLEDGER_LEVELCROSS_REPAIR_LINEService;
			}
			set
			{
				iLEDGER_LEVELCROSS_REPAIR_LINEService= value;
			}
		}
		#endregion

    
		#region 217 业务接口 ILEDGER_MACHINE_TOOLService
		ILEDGER_MACHINE_TOOLService iLEDGER_MACHINE_TOOLService;
		public ILEDGER_MACHINE_TOOLService ILEDGER_MACHINE_TOOLService
		{
			get
			{
				if(iLEDGER_MACHINE_TOOLService==null)
					iLEDGER_MACHINE_TOOLService= new LEDGER_MACHINE_TOOLService();
				return iLEDGER_MACHINE_TOOLService;
			}
			set
			{
				iLEDGER_MACHINE_TOOLService= value;
			}
		}
		#endregion

    
		#region 218 业务接口 ILEDGER_MECHANICAL_VEHICLEService
		ILEDGER_MECHANICAL_VEHICLEService iLEDGER_MECHANICAL_VEHICLEService;
		public ILEDGER_MECHANICAL_VEHICLEService ILEDGER_MECHANICAL_VEHICLEService
		{
			get
			{
				if(iLEDGER_MECHANICAL_VEHICLEService==null)
					iLEDGER_MECHANICAL_VEHICLEService= new LEDGER_MECHANICAL_VEHICLEService();
				return iLEDGER_MECHANICAL_VEHICLEService;
			}
			set
			{
				iLEDGER_MECHANICAL_VEHICLEService= value;
			}
		}
		#endregion

    
		#region 219 业务接口 ILEDGER_RAIL_MATERIALService
		ILEDGER_RAIL_MATERIALService iLEDGER_RAIL_MATERIALService;
		public ILEDGER_RAIL_MATERIALService ILEDGER_RAIL_MATERIALService
		{
			get
			{
				if(iLEDGER_RAIL_MATERIALService==null)
					iLEDGER_RAIL_MATERIALService= new LEDGER_RAIL_MATERIALService();
				return iLEDGER_RAIL_MATERIALService;
			}
			set
			{
				iLEDGER_RAIL_MATERIALService= value;
			}
		}
		#endregion

    
		#region 220 业务接口 ILEDGER_RAILCAR_TECHPARAMService
		ILEDGER_RAILCAR_TECHPARAMService iLEDGER_RAILCAR_TECHPARAMService;
		public ILEDGER_RAILCAR_TECHPARAMService ILEDGER_RAILCAR_TECHPARAMService
		{
			get
			{
				if(iLEDGER_RAILCAR_TECHPARAMService==null)
					iLEDGER_RAILCAR_TECHPARAMService= new LEDGER_RAILCAR_TECHPARAMService();
				return iLEDGER_RAILCAR_TECHPARAMService;
			}
			set
			{
				iLEDGER_RAILCAR_TECHPARAMService= value;
			}
		}
		#endregion

    
		#region 221 业务接口 ILEDGER_ROAD_VEHICLEService
		ILEDGER_ROAD_VEHICLEService iLEDGER_ROAD_VEHICLEService;
		public ILEDGER_ROAD_VEHICLEService ILEDGER_ROAD_VEHICLEService
		{
			get
			{
				if(iLEDGER_ROAD_VEHICLEService==null)
					iLEDGER_ROAD_VEHICLEService= new LEDGER_ROAD_VEHICLEService();
				return iLEDGER_ROAD_VEHICLEService;
			}
			set
			{
				iLEDGER_ROAD_VEHICLEService= value;
			}
		}
		#endregion

    
		#region 222 业务接口 ILEDGER_SMALLEQUI_TECHPARAMService
		ILEDGER_SMALLEQUI_TECHPARAMService iLEDGER_SMALLEQUI_TECHPARAMService;
		public ILEDGER_SMALLEQUI_TECHPARAMService ILEDGER_SMALLEQUI_TECHPARAMService
		{
			get
			{
				if(iLEDGER_SMALLEQUI_TECHPARAMService==null)
					iLEDGER_SMALLEQUI_TECHPARAMService= new LEDGER_SMALLEQUI_TECHPARAMService();
				return iLEDGER_SMALLEQUI_TECHPARAMService;
			}
			set
			{
				iLEDGER_SMALLEQUI_TECHPARAMService= value;
			}
		}
		#endregion

    
		#region 223 业务接口 ILEDGER_TRAFFIC_VEHICLESService
		ILEDGER_TRAFFIC_VEHICLESService iLEDGER_TRAFFIC_VEHICLESService;
		public ILEDGER_TRAFFIC_VEHICLESService ILEDGER_TRAFFIC_VEHICLESService
		{
			get
			{
				if(iLEDGER_TRAFFIC_VEHICLESService==null)
					iLEDGER_TRAFFIC_VEHICLESService= new LEDGER_TRAFFIC_VEHICLESService();
				return iLEDGER_TRAFFIC_VEHICLESService;
			}
			set
			{
				iLEDGER_TRAFFIC_VEHICLESService= value;
			}
		}
		#endregion

    
		#region 224 业务接口 ILKJ_ALLOW_SPEEDService
		ILKJ_ALLOW_SPEEDService iLKJ_ALLOW_SPEEDService;
		public ILKJ_ALLOW_SPEEDService ILKJ_ALLOW_SPEEDService
		{
			get
			{
				if(iLKJ_ALLOW_SPEEDService==null)
					iLKJ_ALLOW_SPEEDService= new LKJ_ALLOW_SPEEDService();
				return iLKJ_ALLOW_SPEEDService;
			}
			set
			{
				iLKJ_ALLOW_SPEEDService= value;
			}
		}
		#endregion

    
		#region 225 业务接口 ILKJ_BRIDGEService
		ILKJ_BRIDGEService iLKJ_BRIDGEService;
		public ILKJ_BRIDGEService ILKJ_BRIDGEService
		{
			get
			{
				if(iLKJ_BRIDGEService==null)
					iLKJ_BRIDGEService= new LKJ_BRIDGEService();
				return iLKJ_BRIDGEService;
			}
			set
			{
				iLKJ_BRIDGEService= value;
			}
		}
		#endregion

    
		#region 226 业务接口 ILKJ_BROKEN_CHAINService
		ILKJ_BROKEN_CHAINService iLKJ_BROKEN_CHAINService;
		public ILKJ_BROKEN_CHAINService ILKJ_BROKEN_CHAINService
		{
			get
			{
				if(iLKJ_BROKEN_CHAINService==null)
					iLKJ_BROKEN_CHAINService= new LKJ_BROKEN_CHAINService();
				return iLKJ_BROKEN_CHAINService;
			}
			set
			{
				iLKJ_BROKEN_CHAINService= value;
			}
		}
		#endregion

    
		#region 227 业务接口 ILKJ_CROSSINGService
		ILKJ_CROSSINGService iLKJ_CROSSINGService;
		public ILKJ_CROSSINGService ILKJ_CROSSINGService
		{
			get
			{
				if(iLKJ_CROSSINGService==null)
					iLKJ_CROSSINGService= new LKJ_CROSSINGService();
				return iLKJ_CROSSINGService;
			}
			set
			{
				iLKJ_CROSSINGService= value;
			}
		}
		#endregion

    
		#region 228 业务接口 ILKJ_CURVEService
		ILKJ_CURVEService iLKJ_CURVEService;
		public ILKJ_CURVEService ILKJ_CURVEService
		{
			get
			{
				if(iLKJ_CURVEService==null)
					iLKJ_CURVEService= new LKJ_CURVEService();
				return iLKJ_CURVEService;
			}
			set
			{
				iLKJ_CURVEService= value;
			}
		}
		#endregion

    
		#region 229 业务接口 ILKJ_LINE_NAMEService
		ILKJ_LINE_NAMEService iLKJ_LINE_NAMEService;
		public ILKJ_LINE_NAMEService ILKJ_LINE_NAMEService
		{
			get
			{
				if(iLKJ_LINE_NAMEService==null)
					iLKJ_LINE_NAMEService= new LKJ_LINE_NAMEService();
				return iLKJ_LINE_NAMEService;
			}
			set
			{
				iLKJ_LINE_NAMEService= value;
			}
		}
		#endregion

    
		#region 230 业务接口 ILKJ_MAIN_TRACK_MILEAGEService
		ILKJ_MAIN_TRACK_MILEAGEService iLKJ_MAIN_TRACK_MILEAGEService;
		public ILKJ_MAIN_TRACK_MILEAGEService ILKJ_MAIN_TRACK_MILEAGEService
		{
			get
			{
				if(iLKJ_MAIN_TRACK_MILEAGEService==null)
					iLKJ_MAIN_TRACK_MILEAGEService= new LKJ_MAIN_TRACK_MILEAGEService();
				return iLKJ_MAIN_TRACK_MILEAGEService;
			}
			set
			{
				iLKJ_MAIN_TRACK_MILEAGEService= value;
			}
		}
		#endregion

    
		#region 231 业务接口 ILKJ_ROAD_FORKService
		ILKJ_ROAD_FORKService iLKJ_ROAD_FORKService;
		public ILKJ_ROAD_FORKService ILKJ_ROAD_FORKService
		{
			get
			{
				if(iLKJ_ROAD_FORKService==null)
					iLKJ_ROAD_FORKService= new LKJ_ROAD_FORKService();
				return iLKJ_ROAD_FORKService;
			}
			set
			{
				iLKJ_ROAD_FORKService= value;
			}
		}
		#endregion

    
		#region 232 业务接口 ILKJ_SLOPEService
		ILKJ_SLOPEService iLKJ_SLOPEService;
		public ILKJ_SLOPEService ILKJ_SLOPEService
		{
			get
			{
				if(iLKJ_SLOPEService==null)
					iLKJ_SLOPEService= new LKJ_SLOPEService();
				return iLKJ_SLOPEService;
			}
			set
			{
				iLKJ_SLOPEService= value;
			}
		}
		#endregion

    
		#region 233 业务接口 ILKJ_STATIONService
		ILKJ_STATIONService iLKJ_STATIONService;
		public ILKJ_STATIONService ILKJ_STATIONService
		{
			get
			{
				if(iLKJ_STATIONService==null)
					iLKJ_STATIONService= new LKJ_STATIONService();
				return iLKJ_STATIONService;
			}
			set
			{
				iLKJ_STATIONService= value;
			}
		}
		#endregion

    
		#region 234 业务接口 ILKJ_TRACKService
		ILKJ_TRACKService iLKJ_TRACKService;
		public ILKJ_TRACKService ILKJ_TRACKService
		{
			get
			{
				if(iLKJ_TRACKService==null)
					iLKJ_TRACKService= new LKJ_TRACKService();
				return iLKJ_TRACKService;
			}
			set
			{
				iLKJ_TRACKService= value;
			}
		}
		#endregion

    
		#region 235 业务接口 ILKJ_TUNNELService
		ILKJ_TUNNELService iLKJ_TUNNELService;
		public ILKJ_TUNNELService ILKJ_TUNNELService
		{
			get
			{
				if(iLKJ_TUNNELService==null)
					iLKJ_TUNNELService= new LKJ_TUNNELService();
				return iLKJ_TUNNELService;
			}
			set
			{
				iLKJ_TUNNELService= value;
			}
		}
		#endregion

    
		#region 236 业务接口 IMATERIAL_BDATE_DICService
		IMATERIAL_BDATE_DICService iMATERIAL_BDATE_DICService;
		public IMATERIAL_BDATE_DICService IMATERIAL_BDATE_DICService
		{
			get
			{
				if(iMATERIAL_BDATE_DICService==null)
					iMATERIAL_BDATE_DICService= new MATERIAL_BDATE_DICService();
				return iMATERIAL_BDATE_DICService;
			}
			set
			{
				iMATERIAL_BDATE_DICService= value;
			}
		}
		#endregion

    
		#region 237 业务接口 IMATERIAL_BDATE_MATERIALNAMEService
		IMATERIAL_BDATE_MATERIALNAMEService iMATERIAL_BDATE_MATERIALNAMEService;
		public IMATERIAL_BDATE_MATERIALNAMEService IMATERIAL_BDATE_MATERIALNAMEService
		{
			get
			{
				if(iMATERIAL_BDATE_MATERIALNAMEService==null)
					iMATERIAL_BDATE_MATERIALNAMEService= new MATERIAL_BDATE_MATERIALNAMEService();
				return iMATERIAL_BDATE_MATERIALNAMEService;
			}
			set
			{
				iMATERIAL_BDATE_MATERIALNAMEService= value;
			}
		}
		#endregion

    
		#region 238 业务接口 IMATERIAL_INOUT_BILLService
		IMATERIAL_INOUT_BILLService iMATERIAL_INOUT_BILLService;
		public IMATERIAL_INOUT_BILLService IMATERIAL_INOUT_BILLService
		{
			get
			{
				if(iMATERIAL_INOUT_BILLService==null)
					iMATERIAL_INOUT_BILLService= new MATERIAL_INOUT_BILLService();
				return iMATERIAL_INOUT_BILLService;
			}
			set
			{
				iMATERIAL_INOUT_BILLService= value;
			}
		}
		#endregion

    
		#region 239 业务接口 IMATERIAL_INOUT_BILL_DETAILService
		IMATERIAL_INOUT_BILL_DETAILService iMATERIAL_INOUT_BILL_DETAILService;
		public IMATERIAL_INOUT_BILL_DETAILService IMATERIAL_INOUT_BILL_DETAILService
		{
			get
			{
				if(iMATERIAL_INOUT_BILL_DETAILService==null)
					iMATERIAL_INOUT_BILL_DETAILService= new MATERIAL_INOUT_BILL_DETAILService();
				return iMATERIAL_INOUT_BILL_DETAILService;
			}
			set
			{
				iMATERIAL_INOUT_BILL_DETAILService= value;
			}
		}
		#endregion

    
		#region 240 业务接口 IMATERIAL_MATERIALMNGService
		IMATERIAL_MATERIALMNGService iMATERIAL_MATERIALMNGService;
		public IMATERIAL_MATERIALMNGService IMATERIAL_MATERIALMNGService
		{
			get
			{
				if(iMATERIAL_MATERIALMNGService==null)
					iMATERIAL_MATERIALMNGService= new MATERIAL_MATERIALMNGService();
				return iMATERIAL_MATERIALMNGService;
			}
			set
			{
				iMATERIAL_MATERIALMNGService= value;
			}
		}
		#endregion

    
		#region 241 业务接口 IMATERIAL_MONSURPRUSService
		IMATERIAL_MONSURPRUSService iMATERIAL_MONSURPRUSService;
		public IMATERIAL_MONSURPRUSService IMATERIAL_MONSURPRUSService
		{
			get
			{
				if(iMATERIAL_MONSURPRUSService==null)
					iMATERIAL_MONSURPRUSService= new MATERIAL_MONSURPRUSService();
				return iMATERIAL_MONSURPRUSService;
			}
			set
			{
				iMATERIAL_MONSURPRUSService= value;
			}
		}
		#endregion

    
		#region 242 业务接口 IOIL_BDATA_CURVEService
		IOIL_BDATA_CURVEService iOIL_BDATA_CURVEService;
		public IOIL_BDATA_CURVEService IOIL_BDATA_CURVEService
		{
			get
			{
				if(iOIL_BDATA_CURVEService==null)
					iOIL_BDATA_CURVEService= new OIL_BDATA_CURVEService();
				return iOIL_BDATA_CURVEService;
			}
			set
			{
				iOIL_BDATA_CURVEService= value;
			}
		}
		#endregion

    
		#region 243 业务接口 IOIL_BDATA_DEVICEService
		IOIL_BDATA_DEVICEService iOIL_BDATA_DEVICEService;
		public IOIL_BDATA_DEVICEService IOIL_BDATA_DEVICEService
		{
			get
			{
				if(iOIL_BDATA_DEVICEService==null)
					iOIL_BDATA_DEVICEService= new OIL_BDATA_DEVICEService();
				return iOIL_BDATA_DEVICEService;
			}
			set
			{
				iOIL_BDATA_DEVICEService= value;
			}
		}
		#endregion

    
		#region 244 业务接口 IOIL_BDATA_OPService
		IOIL_BDATA_OPService iOIL_BDATA_OPService;
		public IOIL_BDATA_OPService IOIL_BDATA_OPService
		{
			get
			{
				if(iOIL_BDATA_OPService==null)
					iOIL_BDATA_OPService= new OIL_BDATA_OPService();
				return iOIL_BDATA_OPService;
			}
			set
			{
				iOIL_BDATA_OPService= value;
			}
		}
		#endregion

    
		#region 245 业务接口 IOIL_RECORD_CHECKService
		IOIL_RECORD_CHECKService iOIL_RECORD_CHECKService;
		public IOIL_RECORD_CHECKService IOIL_RECORD_CHECKService
		{
			get
			{
				if(iOIL_RECORD_CHECKService==null)
					iOIL_RECORD_CHECKService= new OIL_RECORD_CHECKService();
				return iOIL_RECORD_CHECKService;
			}
			set
			{
				iOIL_RECORD_CHECKService= value;
			}
		}
		#endregion

    
		#region 246 业务接口 IOIL_RECORD_OILService
		IOIL_RECORD_OILService iOIL_RECORD_OILService;
		public IOIL_RECORD_OILService IOIL_RECORD_OILService
		{
			get
			{
				if(iOIL_RECORD_OILService==null)
					iOIL_RECORD_OILService= new OIL_RECORD_OILService();
				return iOIL_RECORD_OILService;
			}
			set
			{
				iOIL_RECORD_OILService= value;
			}
		}
		#endregion

    
		#region 247 业务接口 IPHONEDICService
		IPHONEDICService iPHONEDICService;
		public IPHONEDICService IPHONEDICService
		{
			get
			{
				if(iPHONEDICService==null)
					iPHONEDICService= new PHONEDICService();
				return iPHONEDICService;
			}
			set
			{
				iPHONEDICService= value;
			}
		}
		#endregion

    
		#region 248 业务接口 IPROTECTEDNET_BDATA_DEVICEService
		IPROTECTEDNET_BDATA_DEVICEService iPROTECTEDNET_BDATA_DEVICEService;
		public IPROTECTEDNET_BDATA_DEVICEService IPROTECTEDNET_BDATA_DEVICEService
		{
			get
			{
				if(iPROTECTEDNET_BDATA_DEVICEService==null)
					iPROTECTEDNET_BDATA_DEVICEService= new PROTECTEDNET_BDATA_DEVICEService();
				return iPROTECTEDNET_BDATA_DEVICEService;
			}
			set
			{
				iPROTECTEDNET_BDATA_DEVICEService= value;
			}
		}
		#endregion

    
		#region 249 业务接口 IPROTECTEDNET_RECORD_CHECKService
		IPROTECTEDNET_RECORD_CHECKService iPROTECTEDNET_RECORD_CHECKService;
		public IPROTECTEDNET_RECORD_CHECKService IPROTECTEDNET_RECORD_CHECKService
		{
			get
			{
				if(iPROTECTEDNET_RECORD_CHECKService==null)
					iPROTECTEDNET_RECORD_CHECKService= new PROTECTEDNET_RECORD_CHECKService();
				return iPROTECTEDNET_RECORD_CHECKService;
			}
			set
			{
				iPROTECTEDNET_RECORD_CHECKService= value;
			}
		}
		#endregion

    
		#region 250 业务接口 IPROTECTEDNET_RECORD_WARNService
		IPROTECTEDNET_RECORD_WARNService iPROTECTEDNET_RECORD_WARNService;
		public IPROTECTEDNET_RECORD_WARNService IPROTECTEDNET_RECORD_WARNService
		{
			get
			{
				if(iPROTECTEDNET_RECORD_WARNService==null)
					iPROTECTEDNET_RECORD_WARNService= new PROTECTEDNET_RECORD_WARNService();
				return iPROTECTEDNET_RECORD_WARNService;
			}
			set
			{
				iPROTECTEDNET_RECORD_WARNService= value;
			}
		}
		#endregion

    
		#region 251 业务接口 IPROTECTEDNET_VIDEO_FILEService
		IPROTECTEDNET_VIDEO_FILEService iPROTECTEDNET_VIDEO_FILEService;
		public IPROTECTEDNET_VIDEO_FILEService IPROTECTEDNET_VIDEO_FILEService
		{
			get
			{
				if(iPROTECTEDNET_VIDEO_FILEService==null)
					iPROTECTEDNET_VIDEO_FILEService= new PROTECTEDNET_VIDEO_FILEService();
				return iPROTECTEDNET_VIDEO_FILEService;
			}
			set
			{
				iPROTECTEDNET_VIDEO_FILEService= value;
			}
		}
		#endregion

    
		#region 252 业务接口 IRAIL_BDATA_HOSTService
		IRAIL_BDATA_HOSTService iRAIL_BDATA_HOSTService;
		public IRAIL_BDATA_HOSTService IRAIL_BDATA_HOSTService
		{
			get
			{
				if(iRAIL_BDATA_HOSTService==null)
					iRAIL_BDATA_HOSTService= new RAIL_BDATA_HOSTService();
				return iRAIL_BDATA_HOSTService;
			}
			set
			{
				iRAIL_BDATA_HOSTService= value;
			}
		}
		#endregion

    
		#region 253 业务接口 IRAIL_BDATA_POINTService
		IRAIL_BDATA_POINTService iRAIL_BDATA_POINTService;
		public IRAIL_BDATA_POINTService IRAIL_BDATA_POINTService
		{
			get
			{
				if(iRAIL_BDATA_POINTService==null)
					iRAIL_BDATA_POINTService= new RAIL_BDATA_POINTService();
				return iRAIL_BDATA_POINTService;
			}
			set
			{
				iRAIL_BDATA_POINTService= value;
			}
		}
		#endregion

    
		#region 254 业务接口 IRAIL_BDATA_SENDPHONENOService
		IRAIL_BDATA_SENDPHONENOService iRAIL_BDATA_SENDPHONENOService;
		public IRAIL_BDATA_SENDPHONENOService IRAIL_BDATA_SENDPHONENOService
		{
			get
			{
				if(iRAIL_BDATA_SENDPHONENOService==null)
					iRAIL_BDATA_SENDPHONENOService= new RAIL_BDATA_SENDPHONENOService();
				return iRAIL_BDATA_SENDPHONENOService;
			}
			set
			{
				iRAIL_BDATA_SENDPHONENOService= value;
			}
		}
		#endregion

    
		#region 255 业务接口 IRAIL_CARRIERBDATA_POINTService
		IRAIL_CARRIERBDATA_POINTService iRAIL_CARRIERBDATA_POINTService;
		public IRAIL_CARRIERBDATA_POINTService IRAIL_CARRIERBDATA_POINTService
		{
			get
			{
				if(iRAIL_CARRIERBDATA_POINTService==null)
					iRAIL_CARRIERBDATA_POINTService= new RAIL_CARRIERBDATA_POINTService();
				return iRAIL_CARRIERBDATA_POINTService;
			}
			set
			{
				iRAIL_CARRIERBDATA_POINTService= value;
			}
		}
		#endregion

    
		#region 256 业务接口 IRAIL_CARRIERBDATA_SECTIONService
		IRAIL_CARRIERBDATA_SECTIONService iRAIL_CARRIERBDATA_SECTIONService;
		public IRAIL_CARRIERBDATA_SECTIONService IRAIL_CARRIERBDATA_SECTIONService
		{
			get
			{
				if(iRAIL_CARRIERBDATA_SECTIONService==null)
					iRAIL_CARRIERBDATA_SECTIONService= new RAIL_CARRIERBDATA_SECTIONService();
				return iRAIL_CARRIERBDATA_SECTIONService;
			}
			set
			{
				iRAIL_CARRIERBDATA_SECTIONService= value;
			}
		}
		#endregion

    
		#region 257 业务接口 IRAIL_CARRIERDEVICE_STATUSService
		IRAIL_CARRIERDEVICE_STATUSService iRAIL_CARRIERDEVICE_STATUSService;
		public IRAIL_CARRIERDEVICE_STATUSService IRAIL_CARRIERDEVICE_STATUSService
		{
			get
			{
				if(iRAIL_CARRIERDEVICE_STATUSService==null)
					iRAIL_CARRIERDEVICE_STATUSService= new RAIL_CARRIERDEVICE_STATUSService();
				return iRAIL_CARRIERDEVICE_STATUSService;
			}
			set
			{
				iRAIL_CARRIERDEVICE_STATUSService= value;
			}
		}
		#endregion

    
		#region 258 业务接口 IRAIL_CARRIERDEVICE_WARNService
		IRAIL_CARRIERDEVICE_WARNService iRAIL_CARRIERDEVICE_WARNService;
		public IRAIL_CARRIERDEVICE_WARNService IRAIL_CARRIERDEVICE_WARNService
		{
			get
			{
				if(iRAIL_CARRIERDEVICE_WARNService==null)
					iRAIL_CARRIERDEVICE_WARNService= new RAIL_CARRIERDEVICE_WARNService();
				return iRAIL_CARRIERDEVICE_WARNService;
			}
			set
			{
				iRAIL_CARRIERDEVICE_WARNService= value;
			}
		}
		#endregion

    
		#region 259 业务接口 IRAIL_CARRIERRECORD_POINTService
		IRAIL_CARRIERRECORD_POINTService iRAIL_CARRIERRECORD_POINTService;
		public IRAIL_CARRIERRECORD_POINTService IRAIL_CARRIERRECORD_POINTService
		{
			get
			{
				if(iRAIL_CARRIERRECORD_POINTService==null)
					iRAIL_CARRIERRECORD_POINTService= new RAIL_CARRIERRECORD_POINTService();
				return iRAIL_CARRIERRECORD_POINTService;
			}
			set
			{
				iRAIL_CARRIERRECORD_POINTService= value;
			}
		}
		#endregion

    
		#region 260 业务接口 IRAIL_CARRIERRECORD_WARNService
		IRAIL_CARRIERRECORD_WARNService iRAIL_CARRIERRECORD_WARNService;
		public IRAIL_CARRIERRECORD_WARNService IRAIL_CARRIERRECORD_WARNService
		{
			get
			{
				if(iRAIL_CARRIERRECORD_WARNService==null)
					iRAIL_CARRIERRECORD_WARNService= new RAIL_CARRIERRECORD_WARNService();
				return iRAIL_CARRIERRECORD_WARNService;
			}
			set
			{
				iRAIL_CARRIERRECORD_WARNService= value;
			}
		}
		#endregion

    
		#region 261 业务接口 IRAIL_CARRIERRECORD_WARN_FINALService
		IRAIL_CARRIERRECORD_WARN_FINALService iRAIL_CARRIERRECORD_WARN_FINALService;
		public IRAIL_CARRIERRECORD_WARN_FINALService IRAIL_CARRIERRECORD_WARN_FINALService
		{
			get
			{
				if(iRAIL_CARRIERRECORD_WARN_FINALService==null)
					iRAIL_CARRIERRECORD_WARN_FINALService= new RAIL_CARRIERRECORD_WARN_FINALService();
				return iRAIL_CARRIERRECORD_WARN_FINALService;
			}
			set
			{
				iRAIL_CARRIERRECORD_WARN_FINALService= value;
			}
		}
		#endregion

    
		#region 262 业务接口 IRAIL_CARRIERSECTION_LASTWARNService
		IRAIL_CARRIERSECTION_LASTWARNService iRAIL_CARRIERSECTION_LASTWARNService;
		public IRAIL_CARRIERSECTION_LASTWARNService IRAIL_CARRIERSECTION_LASTWARNService
		{
			get
			{
				if(iRAIL_CARRIERSECTION_LASTWARNService==null)
					iRAIL_CARRIERSECTION_LASTWARNService= new RAIL_CARRIERSECTION_LASTWARNService();
				return iRAIL_CARRIERSECTION_LASTWARNService;
			}
			set
			{
				iRAIL_CARRIERSECTION_LASTWARNService= value;
			}
		}
		#endregion

    
		#region 263 业务接口 IRAIL_CARRIERSECTION_WARNService
		IRAIL_CARRIERSECTION_WARNService iRAIL_CARRIERSECTION_WARNService;
		public IRAIL_CARRIERSECTION_WARNService IRAIL_CARRIERSECTION_WARNService
		{
			get
			{
				if(iRAIL_CARRIERSECTION_WARNService==null)
					iRAIL_CARRIERSECTION_WARNService= new RAIL_CARRIERSECTION_WARNService();
				return iRAIL_CARRIERSECTION_WARNService;
			}
			set
			{
				iRAIL_CARRIERSECTION_WARNService= value;
			}
		}
		#endregion

    
		#region 264 业务接口 IRAIL_CARRIERWAVE_LOGService
		IRAIL_CARRIERWAVE_LOGService iRAIL_CARRIERWAVE_LOGService;
		public IRAIL_CARRIERWAVE_LOGService IRAIL_CARRIERWAVE_LOGService
		{
			get
			{
				if(iRAIL_CARRIERWAVE_LOGService==null)
					iRAIL_CARRIERWAVE_LOGService= new RAIL_CARRIERWAVE_LOGService();
				return iRAIL_CARRIERWAVE_LOGService;
			}
			set
			{
				iRAIL_CARRIERWAVE_LOGService= value;
			}
		}
		#endregion

    
		#region 265 业务接口 IRAIL_CARRIERWAVE_POINTService
		IRAIL_CARRIERWAVE_POINTService iRAIL_CARRIERWAVE_POINTService;
		public IRAIL_CARRIERWAVE_POINTService IRAIL_CARRIERWAVE_POINTService
		{
			get
			{
				if(iRAIL_CARRIERWAVE_POINTService==null)
					iRAIL_CARRIERWAVE_POINTService= new RAIL_CARRIERWAVE_POINTService();
				return iRAIL_CARRIERWAVE_POINTService;
			}
			set
			{
				iRAIL_CARRIERWAVE_POINTService= value;
			}
		}
		#endregion

    
		#region 266 业务接口 IRAIL_COMMService
		IRAIL_COMMService iRAIL_COMMService;
		public IRAIL_COMMService IRAIL_COMMService
		{
			get
			{
				if(iRAIL_COMMService==null)
					iRAIL_COMMService= new RAIL_COMMService();
				return iRAIL_COMMService;
			}
			set
			{
				iRAIL_COMMService= value;
			}
		}
		#endregion

    
		#region 267 业务接口 IRAIL_DEVICE_RECORDService
		IRAIL_DEVICE_RECORDService iRAIL_DEVICE_RECORDService;
		public IRAIL_DEVICE_RECORDService IRAIL_DEVICE_RECORDService
		{
			get
			{
				if(iRAIL_DEVICE_RECORDService==null)
					iRAIL_DEVICE_RECORDService= new RAIL_DEVICE_RECORDService();
				return iRAIL_DEVICE_RECORDService;
			}
			set
			{
				iRAIL_DEVICE_RECORDService= value;
			}
		}
		#endregion

    
		#region 268 业务接口 IRAIL_RECORD_HOSTService
		IRAIL_RECORD_HOSTService iRAIL_RECORD_HOSTService;
		public IRAIL_RECORD_HOSTService IRAIL_RECORD_HOSTService
		{
			get
			{
				if(iRAIL_RECORD_HOSTService==null)
					iRAIL_RECORD_HOSTService= new RAIL_RECORD_HOSTService();
				return iRAIL_RECORD_HOSTService;
			}
			set
			{
				iRAIL_RECORD_HOSTService= value;
			}
		}
		#endregion

    
		#region 269 业务接口 IRAIL_RECORD_POINTService
		IRAIL_RECORD_POINTService iRAIL_RECORD_POINTService;
		public IRAIL_RECORD_POINTService IRAIL_RECORD_POINTService
		{
			get
			{
				if(iRAIL_RECORD_POINTService==null)
					iRAIL_RECORD_POINTService= new RAIL_RECORD_POINTService();
				return iRAIL_RECORD_POINTService;
			}
			set
			{
				iRAIL_RECORD_POINTService= value;
			}
		}
		#endregion

    
		#region 270 业务接口 IRAIL_RECORD_SAMPWARNService
		IRAIL_RECORD_SAMPWARNService iRAIL_RECORD_SAMPWARNService;
		public IRAIL_RECORD_SAMPWARNService IRAIL_RECORD_SAMPWARNService
		{
			get
			{
				if(iRAIL_RECORD_SAMPWARNService==null)
					iRAIL_RECORD_SAMPWARNService= new RAIL_RECORD_SAMPWARNService();
				return iRAIL_RECORD_SAMPWARNService;
			}
			set
			{
				iRAIL_RECORD_SAMPWARNService= value;
			}
		}
		#endregion

    
		#region 271 业务接口 IRAIL_RECORD_WARNService
		IRAIL_RECORD_WARNService iRAIL_RECORD_WARNService;
		public IRAIL_RECORD_WARNService IRAIL_RECORD_WARNService
		{
			get
			{
				if(iRAIL_RECORD_WARNService==null)
					iRAIL_RECORD_WARNService= new RAIL_RECORD_WARNService();
				return iRAIL_RECORD_WARNService;
			}
			set
			{
				iRAIL_RECORD_WARNService= value;
			}
		}
		#endregion

    
		#region 272 业务接口 IRAIL_SECTION_LINEService
		IRAIL_SECTION_LINEService iRAIL_SECTION_LINEService;
		public IRAIL_SECTION_LINEService IRAIL_SECTION_LINEService
		{
			get
			{
				if(iRAIL_SECTION_LINEService==null)
					iRAIL_SECTION_LINEService= new RAIL_SECTION_LINEService();
				return iRAIL_SECTION_LINEService;
			}
			set
			{
				iRAIL_SECTION_LINEService= value;
			}
		}
		#endregion

    
		#region 273 业务接口 IRAIL_SOUNDBDATA_POINTService
		IRAIL_SOUNDBDATA_POINTService iRAIL_SOUNDBDATA_POINTService;
		public IRAIL_SOUNDBDATA_POINTService IRAIL_SOUNDBDATA_POINTService
		{
			get
			{
				if(iRAIL_SOUNDBDATA_POINTService==null)
					iRAIL_SOUNDBDATA_POINTService= new RAIL_SOUNDBDATA_POINTService();
				return iRAIL_SOUNDBDATA_POINTService;
			}
			set
			{
				iRAIL_SOUNDBDATA_POINTService= value;
			}
		}
		#endregion

    
		#region 274 业务接口 IRAIL_SOUNDBDATA_SECTIONService
		IRAIL_SOUNDBDATA_SECTIONService iRAIL_SOUNDBDATA_SECTIONService;
		public IRAIL_SOUNDBDATA_SECTIONService IRAIL_SOUNDBDATA_SECTIONService
		{
			get
			{
				if(iRAIL_SOUNDBDATA_SECTIONService==null)
					iRAIL_SOUNDBDATA_SECTIONService= new RAIL_SOUNDBDATA_SECTIONService();
				return iRAIL_SOUNDBDATA_SECTIONService;
			}
			set
			{
				iRAIL_SOUNDBDATA_SECTIONService= value;
			}
		}
		#endregion

    
		#region 275 业务接口 IRAIL_SOUNDDEVICE_LASTWARNService
		IRAIL_SOUNDDEVICE_LASTWARNService iRAIL_SOUNDDEVICE_LASTWARNService;
		public IRAIL_SOUNDDEVICE_LASTWARNService IRAIL_SOUNDDEVICE_LASTWARNService
		{
			get
			{
				if(iRAIL_SOUNDDEVICE_LASTWARNService==null)
					iRAIL_SOUNDDEVICE_LASTWARNService= new RAIL_SOUNDDEVICE_LASTWARNService();
				return iRAIL_SOUNDDEVICE_LASTWARNService;
			}
			set
			{
				iRAIL_SOUNDDEVICE_LASTWARNService= value;
			}
		}
		#endregion

    
		#region 276 业务接口 IRAIL_SOUNDDEVICE_WARNService
		IRAIL_SOUNDDEVICE_WARNService iRAIL_SOUNDDEVICE_WARNService;
		public IRAIL_SOUNDDEVICE_WARNService IRAIL_SOUNDDEVICE_WARNService
		{
			get
			{
				if(iRAIL_SOUNDDEVICE_WARNService==null)
					iRAIL_SOUNDDEVICE_WARNService= new RAIL_SOUNDDEVICE_WARNService();
				return iRAIL_SOUNDDEVICE_WARNService;
			}
			set
			{
				iRAIL_SOUNDDEVICE_WARNService= value;
			}
		}
		#endregion

    
		#region 277 业务接口 IRAIL_SOUNDRECEIVE_ORIDATAService
		IRAIL_SOUNDRECEIVE_ORIDATAService iRAIL_SOUNDRECEIVE_ORIDATAService;
		public IRAIL_SOUNDRECEIVE_ORIDATAService IRAIL_SOUNDRECEIVE_ORIDATAService
		{
			get
			{
				if(iRAIL_SOUNDRECEIVE_ORIDATAService==null)
					iRAIL_SOUNDRECEIVE_ORIDATAService= new RAIL_SOUNDRECEIVE_ORIDATAService();
				return iRAIL_SOUNDRECEIVE_ORIDATAService;
			}
			set
			{
				iRAIL_SOUNDRECEIVE_ORIDATAService= value;
			}
		}
		#endregion

    
		#region 278 业务接口 IRAIL_SOUNDRECORD_LASTWARNService
		IRAIL_SOUNDRECORD_LASTWARNService iRAIL_SOUNDRECORD_LASTWARNService;
		public IRAIL_SOUNDRECORD_LASTWARNService IRAIL_SOUNDRECORD_LASTWARNService
		{
			get
			{
				if(iRAIL_SOUNDRECORD_LASTWARNService==null)
					iRAIL_SOUNDRECORD_LASTWARNService= new RAIL_SOUNDRECORD_LASTWARNService();
				return iRAIL_SOUNDRECORD_LASTWARNService;
			}
			set
			{
				iRAIL_SOUNDRECORD_LASTWARNService= value;
			}
		}
		#endregion

    
		#region 279 业务接口 IRAIL_SOUNDRECORD_POINTService
		IRAIL_SOUNDRECORD_POINTService iRAIL_SOUNDRECORD_POINTService;
		public IRAIL_SOUNDRECORD_POINTService IRAIL_SOUNDRECORD_POINTService
		{
			get
			{
				if(iRAIL_SOUNDRECORD_POINTService==null)
					iRAIL_SOUNDRECORD_POINTService= new RAIL_SOUNDRECORD_POINTService();
				return iRAIL_SOUNDRECORD_POINTService;
			}
			set
			{
				iRAIL_SOUNDRECORD_POINTService= value;
			}
		}
		#endregion

    
		#region 280 业务接口 IRAIL_SOUNDRECORD_WARNService
		IRAIL_SOUNDRECORD_WARNService iRAIL_SOUNDRECORD_WARNService;
		public IRAIL_SOUNDRECORD_WARNService IRAIL_SOUNDRECORD_WARNService
		{
			get
			{
				if(iRAIL_SOUNDRECORD_WARNService==null)
					iRAIL_SOUNDRECORD_WARNService= new RAIL_SOUNDRECORD_WARNService();
				return iRAIL_SOUNDRECORD_WARNService;
			}
			set
			{
				iRAIL_SOUNDRECORD_WARNService= value;
			}
		}
		#endregion

    
		#region 281 业务接口 IRAIL_SOUNDRECORD_WARN_FINALService
		IRAIL_SOUNDRECORD_WARN_FINALService iRAIL_SOUNDRECORD_WARN_FINALService;
		public IRAIL_SOUNDRECORD_WARN_FINALService IRAIL_SOUNDRECORD_WARN_FINALService
		{
			get
			{
				if(iRAIL_SOUNDRECORD_WARN_FINALService==null)
					iRAIL_SOUNDRECORD_WARN_FINALService= new RAIL_SOUNDRECORD_WARN_FINALService();
				return iRAIL_SOUNDRECORD_WARN_FINALService;
			}
			set
			{
				iRAIL_SOUNDRECORD_WARN_FINALService= value;
			}
		}
		#endregion

    
		#region 282 业务接口 IRAIL_SOUNDSECTION_LASTWARNService
		IRAIL_SOUNDSECTION_LASTWARNService iRAIL_SOUNDSECTION_LASTWARNService;
		public IRAIL_SOUNDSECTION_LASTWARNService IRAIL_SOUNDSECTION_LASTWARNService
		{
			get
			{
				if(iRAIL_SOUNDSECTION_LASTWARNService==null)
					iRAIL_SOUNDSECTION_LASTWARNService= new RAIL_SOUNDSECTION_LASTWARNService();
				return iRAIL_SOUNDSECTION_LASTWARNService;
			}
			set
			{
				iRAIL_SOUNDSECTION_LASTWARNService= value;
			}
		}
		#endregion

    
		#region 283 业务接口 IRAIL_SOUNDSECTION_WARNService
		IRAIL_SOUNDSECTION_WARNService iRAIL_SOUNDSECTION_WARNService;
		public IRAIL_SOUNDSECTION_WARNService IRAIL_SOUNDSECTION_WARNService
		{
			get
			{
				if(iRAIL_SOUNDSECTION_WARNService==null)
					iRAIL_SOUNDSECTION_WARNService= new RAIL_SOUNDSECTION_WARNService();
				return iRAIL_SOUNDSECTION_WARNService;
			}
			set
			{
				iRAIL_SOUNDSECTION_WARNService= value;
			}
		}
		#endregion

    
		#region 284 业务接口 IRAIL_SOUNDWAVE_LOGService
		IRAIL_SOUNDWAVE_LOGService iRAIL_SOUNDWAVE_LOGService;
		public IRAIL_SOUNDWAVE_LOGService IRAIL_SOUNDWAVE_LOGService
		{
			get
			{
				if(iRAIL_SOUNDWAVE_LOGService==null)
					iRAIL_SOUNDWAVE_LOGService= new RAIL_SOUNDWAVE_LOGService();
				return iRAIL_SOUNDWAVE_LOGService;
			}
			set
			{
				iRAIL_SOUNDWAVE_LOGService= value;
			}
		}
		#endregion

    
		#region 285 业务接口 IRAILCAR_BDATAService
		IRAILCAR_BDATAService iRAILCAR_BDATAService;
		public IRAILCAR_BDATAService IRAILCAR_BDATAService
		{
			get
			{
				if(iRAILCAR_BDATAService==null)
					iRAILCAR_BDATAService= new RAILCAR_BDATAService();
				return iRAILCAR_BDATAService;
			}
			set
			{
				iRAILCAR_BDATAService= value;
			}
		}
		#endregion

    
		#region 286 业务接口 IRAILCAR_BDATA_ONLINEService
		IRAILCAR_BDATA_ONLINEService iRAILCAR_BDATA_ONLINEService;
		public IRAILCAR_BDATA_ONLINEService IRAILCAR_BDATA_ONLINEService
		{
			get
			{
				if(iRAILCAR_BDATA_ONLINEService==null)
					iRAILCAR_BDATA_ONLINEService= new RAILCAR_BDATA_ONLINEService();
				return iRAILCAR_BDATA_ONLINEService;
			}
			set
			{
				iRAILCAR_BDATA_ONLINEService= value;
			}
		}
		#endregion

    
		#region 287 业务接口 IRAILCAR_FILEService
		IRAILCAR_FILEService iRAILCAR_FILEService;
		public IRAILCAR_FILEService IRAILCAR_FILEService
		{
			get
			{
				if(iRAILCAR_FILEService==null)
					iRAILCAR_FILEService= new RAILCAR_FILEService();
				return iRAILCAR_FILEService;
			}
			set
			{
				iRAILCAR_FILEService= value;
			}
		}
		#endregion

    
		#region 288 业务接口 IRAIN_DEVICEService
		IRAIN_DEVICEService iRAIN_DEVICEService;
		public IRAIN_DEVICEService IRAIN_DEVICEService
		{
			get
			{
				if(iRAIN_DEVICEService==null)
					iRAIN_DEVICEService= new RAIN_DEVICEService();
				return iRAIN_DEVICEService;
			}
			set
			{
				iRAIN_DEVICEService= value;
			}
		}
		#endregion

    
		#region 289 业务接口 IRAIN_DEVICE_PLANLOGService
		IRAIN_DEVICE_PLANLOGService iRAIN_DEVICE_PLANLOGService;
		public IRAIN_DEVICE_PLANLOGService IRAIN_DEVICE_PLANLOGService
		{
			get
			{
				if(iRAIN_DEVICE_PLANLOGService==null)
					iRAIN_DEVICE_PLANLOGService= new RAIN_DEVICE_PLANLOGService();
				return iRAIN_DEVICE_PLANLOGService;
			}
			set
			{
				iRAIN_DEVICE_PLANLOGService= value;
			}
		}
		#endregion

    
		#region 290 业务接口 IRAIN_FLOOD_LABOURService
		IRAIN_FLOOD_LABOURService iRAIN_FLOOD_LABOURService;
		public IRAIN_FLOOD_LABOURService IRAIN_FLOOD_LABOURService
		{
			get
			{
				if(iRAIN_FLOOD_LABOURService==null)
					iRAIN_FLOOD_LABOURService= new RAIN_FLOOD_LABOURService();
				return iRAIN_FLOOD_LABOURService;
			}
			set
			{
				iRAIN_FLOOD_LABOURService= value;
			}
		}
		#endregion

    
		#region 291 业务接口 IRAIN_FLOOD_RESERVE_PLANService
		IRAIN_FLOOD_RESERVE_PLANService iRAIN_FLOOD_RESERVE_PLANService;
		public IRAIN_FLOOD_RESERVE_PLANService IRAIN_FLOOD_RESERVE_PLANService
		{
			get
			{
				if(iRAIN_FLOOD_RESERVE_PLANService==null)
					iRAIN_FLOOD_RESERVE_PLANService= new RAIN_FLOOD_RESERVE_PLANService();
				return iRAIN_FLOOD_RESERVE_PLANService;
			}
			set
			{
				iRAIN_FLOOD_RESERVE_PLANService= value;
			}
		}
		#endregion

    
		#region 292 业务接口 IRAIN_FLOOD_STOCKService
		IRAIN_FLOOD_STOCKService iRAIN_FLOOD_STOCKService;
		public IRAIN_FLOOD_STOCKService IRAIN_FLOOD_STOCKService
		{
			get
			{
				if(iRAIN_FLOOD_STOCKService==null)
					iRAIN_FLOOD_STOCKService= new RAIN_FLOOD_STOCKService();
				return iRAIN_FLOOD_STOCKService;
			}
			set
			{
				iRAIN_FLOOD_STOCKService= value;
			}
		}
		#endregion

    
		#region 293 业务接口 IRAIN_FLOOD_STOCK_PHOTOService
		IRAIN_FLOOD_STOCK_PHOTOService iRAIN_FLOOD_STOCK_PHOTOService;
		public IRAIN_FLOOD_STOCK_PHOTOService IRAIN_FLOOD_STOCK_PHOTOService
		{
			get
			{
				if(iRAIN_FLOOD_STOCK_PHOTOService==null)
					iRAIN_FLOOD_STOCK_PHOTOService= new RAIN_FLOOD_STOCK_PHOTOService();
				return iRAIN_FLOOD_STOCK_PHOTOService;
			}
			set
			{
				iRAIN_FLOOD_STOCK_PHOTOService= value;
			}
		}
		#endregion

    
		#region 294 业务接口 IRAIN_PLANService
		IRAIN_PLANService iRAIN_PLANService;
		public IRAIN_PLANService IRAIN_PLANService
		{
			get
			{
				if(iRAIN_PLANService==null)
					iRAIN_PLANService= new RAIN_PLANService();
				return iRAIN_PLANService;
			}
			set
			{
				iRAIN_PLANService= value;
			}
		}
		#endregion

    
		#region 295 业务接口 IRAIN_PLAN_WARNService
		IRAIN_PLAN_WARNService iRAIN_PLAN_WARNService;
		public IRAIN_PLAN_WARNService IRAIN_PLAN_WARNService
		{
			get
			{
				if(iRAIN_PLAN_WARNService==null)
					iRAIN_PLAN_WARNService= new RAIN_PLAN_WARNService();
				return iRAIN_PLAN_WARNService;
			}
			set
			{
				iRAIN_PLAN_WARNService= value;
			}
		}
		#endregion

    
		#region 296 业务接口 IRAIN_SECTION_LINEService
		IRAIN_SECTION_LINEService iRAIN_SECTION_LINEService;
		public IRAIN_SECTION_LINEService IRAIN_SECTION_LINEService
		{
			get
			{
				if(iRAIN_SECTION_LINEService==null)
					iRAIN_SECTION_LINEService= new RAIN_SECTION_LINEService();
				return iRAIN_SECTION_LINEService;
			}
			set
			{
				iRAIN_SECTION_LINEService= value;
			}
		}
		#endregion

    
		#region 297 业务接口 IREPAIR_ACCOUNTService
		IREPAIR_ACCOUNTService iREPAIR_ACCOUNTService;
		public IREPAIR_ACCOUNTService IREPAIR_ACCOUNTService
		{
			get
			{
				if(iREPAIR_ACCOUNTService==null)
					iREPAIR_ACCOUNTService= new REPAIR_ACCOUNTService();
				return iREPAIR_ACCOUNTService;
			}
			set
			{
				iREPAIR_ACCOUNTService= value;
			}
		}
		#endregion

    
		#region 298 业务接口 IREPAIR_OVERRUNService
		IREPAIR_OVERRUNService iREPAIR_OVERRUNService;
		public IREPAIR_OVERRUNService IREPAIR_OVERRUNService
		{
			get
			{
				if(iREPAIR_OVERRUNService==null)
					iREPAIR_OVERRUNService= new REPAIR_OVERRUNService();
				return iREPAIR_OVERRUNService;
			}
			set
			{
				iREPAIR_OVERRUNService= value;
			}
		}
		#endregion

    
		#region 299 业务接口 IRESCUE_LINEService
		IRESCUE_LINEService iRESCUE_LINEService;
		public IRESCUE_LINEService IRESCUE_LINEService
		{
			get
			{
				if(iRESCUE_LINEService==null)
					iRESCUE_LINEService= new RESCUE_LINEService();
				return iRESCUE_LINEService;
			}
			set
			{
				iRESCUE_LINEService= value;
			}
		}
		#endregion

    
		#region 300 业务接口 IRESCUE_LINE_INFOService
		IRESCUE_LINE_INFOService iRESCUE_LINE_INFOService;
		public IRESCUE_LINE_INFOService IRESCUE_LINE_INFOService
		{
			get
			{
				if(iRESCUE_LINE_INFOService==null)
					iRESCUE_LINE_INFOService= new RESCUE_LINE_INFOService();
				return iRESCUE_LINE_INFOService;
			}
			set
			{
				iRESCUE_LINE_INFOService= value;
			}
		}
		#endregion

    
		#region 301 业务接口 IRESCUE_LINE_PHOTOService
		IRESCUE_LINE_PHOTOService iRESCUE_LINE_PHOTOService;
		public IRESCUE_LINE_PHOTOService IRESCUE_LINE_PHOTOService
		{
			get
			{
				if(iRESCUE_LINE_PHOTOService==null)
					iRESCUE_LINE_PHOTOService= new RESCUE_LINE_PHOTOService();
				return iRESCUE_LINE_PHOTOService;
			}
			set
			{
				iRESCUE_LINE_PHOTOService= value;
			}
		}
		#endregion

    
		#region 302 业务接口 IRESCUE_LINE_PORTService
		IRESCUE_LINE_PORTService iRESCUE_LINE_PORTService;
		public IRESCUE_LINE_PORTService IRESCUE_LINE_PORTService
		{
			get
			{
				if(iRESCUE_LINE_PORTService==null)
					iRESCUE_LINE_PORTService= new RESCUE_LINE_PORTService();
				return iRESCUE_LINE_PORTService;
			}
			set
			{
				iRESCUE_LINE_PORTService= value;
			}
		}
		#endregion

    
		#region 303 业务接口 IROADBED_ITEM_PARAService
		IROADBED_ITEM_PARAService iROADBED_ITEM_PARAService;
		public IROADBED_ITEM_PARAService IROADBED_ITEM_PARAService
		{
			get
			{
				if(iROADBED_ITEM_PARAService==null)
					iROADBED_ITEM_PARAService= new ROADBED_ITEM_PARAService();
				return iROADBED_ITEM_PARAService;
			}
			set
			{
				iROADBED_ITEM_PARAService= value;
			}
		}
		#endregion

    
		#region 304 业务接口 IROADBED_KEYDISEASE_EVALUATEService
		IROADBED_KEYDISEASE_EVALUATEService iROADBED_KEYDISEASE_EVALUATEService;
		public IROADBED_KEYDISEASE_EVALUATEService IROADBED_KEYDISEASE_EVALUATEService
		{
			get
			{
				if(iROADBED_KEYDISEASE_EVALUATEService==null)
					iROADBED_KEYDISEASE_EVALUATEService= new ROADBED_KEYDISEASE_EVALUATEService();
				return iROADBED_KEYDISEASE_EVALUATEService;
			}
			set
			{
				iROADBED_KEYDISEASE_EVALUATEService= value;
			}
		}
		#endregion

    
		#region 305 业务接口 IROADBED_KEYDISEASE_PROService
		IROADBED_KEYDISEASE_PROService iROADBED_KEYDISEASE_PROService;
		public IROADBED_KEYDISEASE_PROService IROADBED_KEYDISEASE_PROService
		{
			get
			{
				if(iROADBED_KEYDISEASE_PROService==null)
					iROADBED_KEYDISEASE_PROService= new ROADBED_KEYDISEASE_PROService();
				return iROADBED_KEYDISEASE_PROService;
			}
			set
			{
				iROADBED_KEYDISEASE_PROService= value;
			}
		}
		#endregion

    
		#region 306 业务接口 IROADBED_KEYDISEASE_PRO_HISService
		IROADBED_KEYDISEASE_PRO_HISService iROADBED_KEYDISEASE_PRO_HISService;
		public IROADBED_KEYDISEASE_PRO_HISService IROADBED_KEYDISEASE_PRO_HISService
		{
			get
			{
				if(iROADBED_KEYDISEASE_PRO_HISService==null)
					iROADBED_KEYDISEASE_PRO_HISService= new ROADBED_KEYDISEASE_PRO_HISService();
				return iROADBED_KEYDISEASE_PRO_HISService;
			}
			set
			{
				iROADBED_KEYDISEASE_PRO_HISService= value;
			}
		}
		#endregion

    
		#region 307 业务接口 IROADBED_KEYDISEASE_REPORTService
		IROADBED_KEYDISEASE_REPORTService iROADBED_KEYDISEASE_REPORTService;
		public IROADBED_KEYDISEASE_REPORTService IROADBED_KEYDISEASE_REPORTService
		{
			get
			{
				if(iROADBED_KEYDISEASE_REPORTService==null)
					iROADBED_KEYDISEASE_REPORTService= new ROADBED_KEYDISEASE_REPORTService();
				return iROADBED_KEYDISEASE_REPORTService;
			}
			set
			{
				iROADBED_KEYDISEASE_REPORTService= value;
			}
		}
		#endregion

    
		#region 308 业务接口 IRULE_BASE_DEPTService
		IRULE_BASE_DEPTService iRULE_BASE_DEPTService;
		public IRULE_BASE_DEPTService IRULE_BASE_DEPTService
		{
			get
			{
				if(iRULE_BASE_DEPTService==null)
					iRULE_BASE_DEPTService= new RULE_BASE_DEPTService();
				return iRULE_BASE_DEPTService;
			}
			set
			{
				iRULE_BASE_DEPTService= value;
			}
		}
		#endregion

    
		#region 309 业务接口 IRULE_BDATE_DICService
		IRULE_BDATE_DICService iRULE_BDATE_DICService;
		public IRULE_BDATE_DICService IRULE_BDATE_DICService
		{
			get
			{
				if(iRULE_BDATE_DICService==null)
					iRULE_BDATE_DICService= new RULE_BDATE_DICService();
				return iRULE_BDATE_DICService;
			}
			set
			{
				iRULE_BDATE_DICService= value;
			}
		}
		#endregion

    
		#region 310 业务接口 IRULE_DOCService
		IRULE_DOCService iRULE_DOCService;
		public IRULE_DOCService IRULE_DOCService
		{
			get
			{
				if(iRULE_DOCService==null)
					iRULE_DOCService= new RULE_DOCService();
				return iRULE_DOCService;
			}
			set
			{
				iRULE_DOCService= value;
			}
		}
		#endregion

    
		#region 311 业务接口 IRULE_DOC_ITEMService
		IRULE_DOC_ITEMService iRULE_DOC_ITEMService;
		public IRULE_DOC_ITEMService IRULE_DOC_ITEMService
		{
			get
			{
				if(iRULE_DOC_ITEMService==null)
					iRULE_DOC_ITEMService= new RULE_DOC_ITEMService();
				return iRULE_DOC_ITEMService;
			}
			set
			{
				iRULE_DOC_ITEMService= value;
			}
		}
		#endregion

    
		#region 312 业务接口 IRULE_DOC_KEYWORDService
		IRULE_DOC_KEYWORDService iRULE_DOC_KEYWORDService;
		public IRULE_DOC_KEYWORDService IRULE_DOC_KEYWORDService
		{
			get
			{
				if(iRULE_DOC_KEYWORDService==null)
					iRULE_DOC_KEYWORDService= new RULE_DOC_KEYWORDService();
				return iRULE_DOC_KEYWORDService;
			}
			set
			{
				iRULE_DOC_KEYWORDService= value;
			}
		}
		#endregion

    
		#region 313 业务接口 IRULE_KEYWORDService
		IRULE_KEYWORDService iRULE_KEYWORDService;
		public IRULE_KEYWORDService IRULE_KEYWORDService
		{
			get
			{
				if(iRULE_KEYWORDService==null)
					iRULE_KEYWORDService= new RULE_KEYWORDService();
				return iRULE_KEYWORDService;
			}
			set
			{
				iRULE_KEYWORDService= value;
			}
		}
		#endregion

    
		#region 314 业务接口 IRULE_PARA_SCOREService
		IRULE_PARA_SCOREService iRULE_PARA_SCOREService;
		public IRULE_PARA_SCOREService IRULE_PARA_SCOREService
		{
			get
			{
				if(iRULE_PARA_SCOREService==null)
					iRULE_PARA_SCOREService= new RULE_PARA_SCOREService();
				return iRULE_PARA_SCOREService;
			}
			set
			{
				iRULE_PARA_SCOREService= value;
			}
		}
		#endregion

    
		#region 315 业务接口 IRULE_PARSE_MARKUPService
		IRULE_PARSE_MARKUPService iRULE_PARSE_MARKUPService;
		public IRULE_PARSE_MARKUPService IRULE_PARSE_MARKUPService
		{
			get
			{
				if(iRULE_PARSE_MARKUPService==null)
					iRULE_PARSE_MARKUPService= new RULE_PARSE_MARKUPService();
				return iRULE_PARSE_MARKUPService;
			}
			set
			{
				iRULE_PARSE_MARKUPService= value;
			}
		}
		#endregion

    
		#region 316 业务接口 IRULE_PARSE_MARKUP_MATCHService
		IRULE_PARSE_MARKUP_MATCHService iRULE_PARSE_MARKUP_MATCHService;
		public IRULE_PARSE_MARKUP_MATCHService IRULE_PARSE_MARKUP_MATCHService
		{
			get
			{
				if(iRULE_PARSE_MARKUP_MATCHService==null)
					iRULE_PARSE_MARKUP_MATCHService= new RULE_PARSE_MARKUP_MATCHService();
				return iRULE_PARSE_MARKUP_MATCHService;
			}
			set
			{
				iRULE_PARSE_MARKUP_MATCHService= value;
			}
		}
		#endregion

    
		#region 317 业务接口 IRULE_PARSE_RESULTService
		IRULE_PARSE_RESULTService iRULE_PARSE_RESULTService;
		public IRULE_PARSE_RESULTService IRULE_PARSE_RESULTService
		{
			get
			{
				if(iRULE_PARSE_RESULTService==null)
					iRULE_PARSE_RESULTService= new RULE_PARSE_RESULTService();
				return iRULE_PARSE_RESULTService;
			}
			set
			{
				iRULE_PARSE_RESULTService= value;
			}
		}
		#endregion

    
		#region 318 业务接口 IRULE_PARSE_RESULT_REPORTService
		IRULE_PARSE_RESULT_REPORTService iRULE_PARSE_RESULT_REPORTService;
		public IRULE_PARSE_RESULT_REPORTService IRULE_PARSE_RESULT_REPORTService
		{
			get
			{
				if(iRULE_PARSE_RESULT_REPORTService==null)
					iRULE_PARSE_RESULT_REPORTService= new RULE_PARSE_RESULT_REPORTService();
				return iRULE_PARSE_RESULT_REPORTService;
			}
			set
			{
				iRULE_PARSE_RESULT_REPORTService= value;
			}
		}
		#endregion

    
		#region 319 业务接口 IRULE_PROBLEMService
		IRULE_PROBLEMService iRULE_PROBLEMService;
		public IRULE_PROBLEMService IRULE_PROBLEMService
		{
			get
			{
				if(iRULE_PROBLEMService==null)
					iRULE_PROBLEMService= new RULE_PROBLEMService();
				return iRULE_PROBLEMService;
			}
			set
			{
				iRULE_PROBLEMService= value;
			}
		}
		#endregion

    
		#region 320 业务接口 IRULE_PROBLEM_BLAMEService
		IRULE_PROBLEM_BLAMEService iRULE_PROBLEM_BLAMEService;
		public IRULE_PROBLEM_BLAMEService IRULE_PROBLEM_BLAMEService
		{
			get
			{
				if(iRULE_PROBLEM_BLAMEService==null)
					iRULE_PROBLEM_BLAMEService= new RULE_PROBLEM_BLAMEService();
				return iRULE_PROBLEM_BLAMEService;
			}
			set
			{
				iRULE_PROBLEM_BLAMEService= value;
			}
		}
		#endregion

    
		#region 321 业务接口 IRULE_PROBLEM_KEYWORDService
		IRULE_PROBLEM_KEYWORDService iRULE_PROBLEM_KEYWORDService;
		public IRULE_PROBLEM_KEYWORDService IRULE_PROBLEM_KEYWORDService
		{
			get
			{
				if(iRULE_PROBLEM_KEYWORDService==null)
					iRULE_PROBLEM_KEYWORDService= new RULE_PROBLEM_KEYWORDService();
				return iRULE_PROBLEM_KEYWORDService;
			}
			set
			{
				iRULE_PROBLEM_KEYWORDService= value;
			}
		}
		#endregion

    
		#region 322 业务接口 IRULE_PROBLEM_POSTService
		IRULE_PROBLEM_POSTService iRULE_PROBLEM_POSTService;
		public IRULE_PROBLEM_POSTService IRULE_PROBLEM_POSTService
		{
			get
			{
				if(iRULE_PROBLEM_POSTService==null)
					iRULE_PROBLEM_POSTService= new RULE_PROBLEM_POSTService();
				return iRULE_PROBLEM_POSTService;
			}
			set
			{
				iRULE_PROBLEM_POSTService= value;
			}
		}
		#endregion

    
		#region 323 业务接口 IRULE_PROBLEM_PUBLISH_CONFIGERService
		IRULE_PROBLEM_PUBLISH_CONFIGERService iRULE_PROBLEM_PUBLISH_CONFIGERService;
		public IRULE_PROBLEM_PUBLISH_CONFIGERService IRULE_PROBLEM_PUBLISH_CONFIGERService
		{
			get
			{
				if(iRULE_PROBLEM_PUBLISH_CONFIGERService==null)
					iRULE_PROBLEM_PUBLISH_CONFIGERService= new RULE_PROBLEM_PUBLISH_CONFIGERService();
				return iRULE_PROBLEM_PUBLISH_CONFIGERService;
			}
			set
			{
				iRULE_PROBLEM_PUBLISH_CONFIGERService= value;
			}
		}
		#endregion

    
		#region 324 业务接口 IRULE_PROBLEM_PUNISHService
		IRULE_PROBLEM_PUNISHService iRULE_PROBLEM_PUNISHService;
		public IRULE_PROBLEM_PUNISHService IRULE_PROBLEM_PUNISHService
		{
			get
			{
				if(iRULE_PROBLEM_PUNISHService==null)
					iRULE_PROBLEM_PUNISHService= new RULE_PROBLEM_PUNISHService();
				return iRULE_PROBLEM_PUNISHService;
			}
			set
			{
				iRULE_PROBLEM_PUNISHService= value;
			}
		}
		#endregion

    
		#region 325 业务接口 IRULE_RESULT_CENSUSService
		IRULE_RESULT_CENSUSService iRULE_RESULT_CENSUSService;
		public IRULE_RESULT_CENSUSService IRULE_RESULT_CENSUSService
		{
			get
			{
				if(iRULE_RESULT_CENSUSService==null)
					iRULE_RESULT_CENSUSService= new RULE_RESULT_CENSUSService();
				return iRULE_RESULT_CENSUSService;
			}
			set
			{
				iRULE_RESULT_CENSUSService= value;
			}
		}
		#endregion

    
		#region 326 业务接口 IRULE_RESULT_PROTREND_TMPService
		IRULE_RESULT_PROTREND_TMPService iRULE_RESULT_PROTREND_TMPService;
		public IRULE_RESULT_PROTREND_TMPService IRULE_RESULT_PROTREND_TMPService
		{
			get
			{
				if(iRULE_RESULT_PROTREND_TMPService==null)
					iRULE_RESULT_PROTREND_TMPService= new RULE_RESULT_PROTREND_TMPService();
				return iRULE_RESULT_PROTREND_TMPService;
			}
			set
			{
				iRULE_RESULT_PROTREND_TMPService= value;
			}
		}
		#endregion

    
		#region 327 业务接口 ISCRIPT_SECTION_BRIDGETUNNELService
		ISCRIPT_SECTION_BRIDGETUNNELService iSCRIPT_SECTION_BRIDGETUNNELService;
		public ISCRIPT_SECTION_BRIDGETUNNELService ISCRIPT_SECTION_BRIDGETUNNELService
		{
			get
			{
				if(iSCRIPT_SECTION_BRIDGETUNNELService==null)
					iSCRIPT_SECTION_BRIDGETUNNELService= new SCRIPT_SECTION_BRIDGETUNNELService();
				return iSCRIPT_SECTION_BRIDGETUNNELService;
			}
			set
			{
				iSCRIPT_SECTION_BRIDGETUNNELService= value;
			}
		}
		#endregion

    
		#region 328 业务接口 ISCRIPTS_LEADER_MONITOREService
		ISCRIPTS_LEADER_MONITOREService iSCRIPTS_LEADER_MONITOREService;
		public ISCRIPTS_LEADER_MONITOREService ISCRIPTS_LEADER_MONITOREService
		{
			get
			{
				if(iSCRIPTS_LEADER_MONITOREService==null)
					iSCRIPTS_LEADER_MONITOREService= new SCRIPTS_LEADER_MONITOREService();
				return iSCRIPTS_LEADER_MONITOREService;
			}
			set
			{
				iSCRIPTS_LEADER_MONITOREService= value;
			}
		}
		#endregion

    
		#region 329 业务接口 ISCRIPTS_MEMBER_ONLINEService
		ISCRIPTS_MEMBER_ONLINEService iSCRIPTS_MEMBER_ONLINEService;
		public ISCRIPTS_MEMBER_ONLINEService ISCRIPTS_MEMBER_ONLINEService
		{
			get
			{
				if(iSCRIPTS_MEMBER_ONLINEService==null)
					iSCRIPTS_MEMBER_ONLINEService= new SCRIPTS_MEMBER_ONLINEService();
				return iSCRIPTS_MEMBER_ONLINEService;
			}
			set
			{
				iSCRIPTS_MEMBER_ONLINEService= value;
			}
		}
		#endregion

    
		#region 330 业务接口 ISCRIPTS_SECTION_BADSIGNALService
		ISCRIPTS_SECTION_BADSIGNALService iSCRIPTS_SECTION_BADSIGNALService;
		public ISCRIPTS_SECTION_BADSIGNALService ISCRIPTS_SECTION_BADSIGNALService
		{
			get
			{
				if(iSCRIPTS_SECTION_BADSIGNALService==null)
					iSCRIPTS_SECTION_BADSIGNALService= new SCRIPTS_SECTION_BADSIGNALService();
				return iSCRIPTS_SECTION_BADSIGNALService;
			}
			set
			{
				iSCRIPTS_SECTION_BADSIGNALService= value;
			}
		}
		#endregion

    
		#region 331 业务接口 ISCRIPTS_SECTION_FLOOD_PHOTOService
		ISCRIPTS_SECTION_FLOOD_PHOTOService iSCRIPTS_SECTION_FLOOD_PHOTOService;
		public ISCRIPTS_SECTION_FLOOD_PHOTOService ISCRIPTS_SECTION_FLOOD_PHOTOService
		{
			get
			{
				if(iSCRIPTS_SECTION_FLOOD_PHOTOService==null)
					iSCRIPTS_SECTION_FLOOD_PHOTOService= new SCRIPTS_SECTION_FLOOD_PHOTOService();
				return iSCRIPTS_SECTION_FLOOD_PHOTOService;
			}
			set
			{
				iSCRIPTS_SECTION_FLOOD_PHOTOService= value;
			}
		}
		#endregion

    
		#region 332 业务接口 ISCRIPTS_SECTION_FLOOD_PIC_TESTService
		ISCRIPTS_SECTION_FLOOD_PIC_TESTService iSCRIPTS_SECTION_FLOOD_PIC_TESTService;
		public ISCRIPTS_SECTION_FLOOD_PIC_TESTService ISCRIPTS_SECTION_FLOOD_PIC_TESTService
		{
			get
			{
				if(iSCRIPTS_SECTION_FLOOD_PIC_TESTService==null)
					iSCRIPTS_SECTION_FLOOD_PIC_TESTService= new SCRIPTS_SECTION_FLOOD_PIC_TESTService();
				return iSCRIPTS_SECTION_FLOOD_PIC_TESTService;
			}
			set
			{
				iSCRIPTS_SECTION_FLOOD_PIC_TESTService= value;
			}
		}
		#endregion

    
		#region 333 业务接口 ISCRIPTS_SECTION_LINEService
		ISCRIPTS_SECTION_LINEService iSCRIPTS_SECTION_LINEService;
		public ISCRIPTS_SECTION_LINEService ISCRIPTS_SECTION_LINEService
		{
			get
			{
				if(iSCRIPTS_SECTION_LINEService==null)
					iSCRIPTS_SECTION_LINEService= new SCRIPTS_SECTION_LINEService();
				return iSCRIPTS_SECTION_LINEService;
			}
			set
			{
				iSCRIPTS_SECTION_LINEService= value;
			}
		}
		#endregion

    
		#region 334 业务接口 ISCRIPTS_SECTION_OTHER_PHOTOService
		ISCRIPTS_SECTION_OTHER_PHOTOService iSCRIPTS_SECTION_OTHER_PHOTOService;
		public ISCRIPTS_SECTION_OTHER_PHOTOService ISCRIPTS_SECTION_OTHER_PHOTOService
		{
			get
			{
				if(iSCRIPTS_SECTION_OTHER_PHOTOService==null)
					iSCRIPTS_SECTION_OTHER_PHOTOService= new SCRIPTS_SECTION_OTHER_PHOTOService();
				return iSCRIPTS_SECTION_OTHER_PHOTOService;
			}
			set
			{
				iSCRIPTS_SECTION_OTHER_PHOTOService= value;
			}
		}
		#endregion

    
		#region 335 业务接口 ISCRIPTS_SECTION_ROAD_LINEService
		ISCRIPTS_SECTION_ROAD_LINEService iSCRIPTS_SECTION_ROAD_LINEService;
		public ISCRIPTS_SECTION_ROAD_LINEService ISCRIPTS_SECTION_ROAD_LINEService
		{
			get
			{
				if(iSCRIPTS_SECTION_ROAD_LINEService==null)
					iSCRIPTS_SECTION_ROAD_LINEService= new SCRIPTS_SECTION_ROAD_LINEService();
				return iSCRIPTS_SECTION_ROAD_LINEService;
			}
			set
			{
				iSCRIPTS_SECTION_ROAD_LINEService= value;
			}
		}
		#endregion

    
		#region 336 业务接口 ISCRIPTS_SECTION_ROADMOTORService
		ISCRIPTS_SECTION_ROADMOTORService iSCRIPTS_SECTION_ROADMOTORService;
		public ISCRIPTS_SECTION_ROADMOTORService ISCRIPTS_SECTION_ROADMOTORService
		{
			get
			{
				if(iSCRIPTS_SECTION_ROADMOTORService==null)
					iSCRIPTS_SECTION_ROADMOTORService= new SCRIPTS_SECTION_ROADMOTORService();
				return iSCRIPTS_SECTION_ROADMOTORService;
			}
			set
			{
				iSCRIPTS_SECTION_ROADMOTORService= value;
			}
		}
		#endregion

    
		#region 337 业务接口 ISCRIPTS_SECTION_TRACKService
		ISCRIPTS_SECTION_TRACKService iSCRIPTS_SECTION_TRACKService;
		public ISCRIPTS_SECTION_TRACKService ISCRIPTS_SECTION_TRACKService
		{
			get
			{
				if(iSCRIPTS_SECTION_TRACKService==null)
					iSCRIPTS_SECTION_TRACKService= new SCRIPTS_SECTION_TRACKService();
				return iSCRIPTS_SECTION_TRACKService;
			}
			set
			{
				iSCRIPTS_SECTION_TRACKService= value;
			}
		}
		#endregion

    
		#region 338 业务接口 ISCRIPTS_SECTION_TRACK_INFOService
		ISCRIPTS_SECTION_TRACK_INFOService iSCRIPTS_SECTION_TRACK_INFOService;
		public ISCRIPTS_SECTION_TRACK_INFOService ISCRIPTS_SECTION_TRACK_INFOService
		{
			get
			{
				if(iSCRIPTS_SECTION_TRACK_INFOService==null)
					iSCRIPTS_SECTION_TRACK_INFOService= new SCRIPTS_SECTION_TRACK_INFOService();
				return iSCRIPTS_SECTION_TRACK_INFOService;
			}
			set
			{
				iSCRIPTS_SECTION_TRACK_INFOService= value;
			}
		}
		#endregion

    
		#region 339 业务接口 ISCRIPTS_SECTION_TYPECROSSService
		ISCRIPTS_SECTION_TYPECROSSService iSCRIPTS_SECTION_TYPECROSSService;
		public ISCRIPTS_SECTION_TYPECROSSService ISCRIPTS_SECTION_TYPECROSSService
		{
			get
			{
				if(iSCRIPTS_SECTION_TYPECROSSService==null)
					iSCRIPTS_SECTION_TYPECROSSService= new SCRIPTS_SECTION_TYPECROSSService();
				return iSCRIPTS_SECTION_TYPECROSSService;
			}
			set
			{
				iSCRIPTS_SECTION_TYPECROSSService= value;
			}
		}
		#endregion

    
		#region 340 业务接口 ISCRIPTS_SECTION_TYPEFLOODService
		ISCRIPTS_SECTION_TYPEFLOODService iSCRIPTS_SECTION_TYPEFLOODService;
		public ISCRIPTS_SECTION_TYPEFLOODService ISCRIPTS_SECTION_TYPEFLOODService
		{
			get
			{
				if(iSCRIPTS_SECTION_TYPEFLOODService==null)
					iSCRIPTS_SECTION_TYPEFLOODService= new SCRIPTS_SECTION_TYPEFLOODService();
				return iSCRIPTS_SECTION_TYPEFLOODService;
			}
			set
			{
				iSCRIPTS_SECTION_TYPEFLOODService= value;
			}
		}
		#endregion

    
		#region 341 业务接口 ISCRIPTS_SECTION_TYPEOTHERService
		ISCRIPTS_SECTION_TYPEOTHERService iSCRIPTS_SECTION_TYPEOTHERService;
		public ISCRIPTS_SECTION_TYPEOTHERService ISCRIPTS_SECTION_TYPEOTHERService
		{
			get
			{
				if(iSCRIPTS_SECTION_TYPEOTHERService==null)
					iSCRIPTS_SECTION_TYPEOTHERService= new SCRIPTS_SECTION_TYPEOTHERService();
				return iSCRIPTS_SECTION_TYPEOTHERService;
			}
			set
			{
				iSCRIPTS_SECTION_TYPEOTHERService= value;
			}
		}
		#endregion

    
		#region 342 业务接口 ISCRIPTS_SECTION_TYPEOTHERINFOService
		ISCRIPTS_SECTION_TYPEOTHERINFOService iSCRIPTS_SECTION_TYPEOTHERINFOService;
		public ISCRIPTS_SECTION_TYPEOTHERINFOService ISCRIPTS_SECTION_TYPEOTHERINFOService
		{
			get
			{
				if(iSCRIPTS_SECTION_TYPEOTHERINFOService==null)
					iSCRIPTS_SECTION_TYPEOTHERINFOService= new SCRIPTS_SECTION_TYPEOTHERINFOService();
				return iSCRIPTS_SECTION_TYPEOTHERINFOService;
			}
			set
			{
				iSCRIPTS_SECTION_TYPEOTHERINFOService= value;
			}
		}
		#endregion

    
		#region 343 业务接口 ISCRIPTS_SPECIAL_FLAGService
		ISCRIPTS_SPECIAL_FLAGService iSCRIPTS_SPECIAL_FLAGService;
		public ISCRIPTS_SPECIAL_FLAGService ISCRIPTS_SPECIAL_FLAGService
		{
			get
			{
				if(iSCRIPTS_SPECIAL_FLAGService==null)
					iSCRIPTS_SPECIAL_FLAGService= new SCRIPTS_SPECIAL_FLAGService();
				return iSCRIPTS_SPECIAL_FLAGService;
			}
			set
			{
				iSCRIPTS_SPECIAL_FLAGService= value;
			}
		}
		#endregion

    
		#region 344 业务接口 ISCRIPTS_STATION_CHECKService
		ISCRIPTS_STATION_CHECKService iSCRIPTS_STATION_CHECKService;
		public ISCRIPTS_STATION_CHECKService ISCRIPTS_STATION_CHECKService
		{
			get
			{
				if(iSCRIPTS_STATION_CHECKService==null)
					iSCRIPTS_STATION_CHECKService= new SCRIPTS_STATION_CHECKService();
				return iSCRIPTS_STATION_CHECKService;
			}
			set
			{
				iSCRIPTS_STATION_CHECKService= value;
			}
		}
		#endregion

    
		#region 345 业务接口 ISNOW_BDATA_DEVICEService
		ISNOW_BDATA_DEVICEService iSNOW_BDATA_DEVICEService;
		public ISNOW_BDATA_DEVICEService ISNOW_BDATA_DEVICEService
		{
			get
			{
				if(iSNOW_BDATA_DEVICEService==null)
					iSNOW_BDATA_DEVICEService= new SNOW_BDATA_DEVICEService();
				return iSNOW_BDATA_DEVICEService;
			}
			set
			{
				iSNOW_BDATA_DEVICEService= value;
			}
		}
		#endregion

    
		#region 346 业务接口 ISNOW_BDATA_WARNSTANDARDService
		ISNOW_BDATA_WARNSTANDARDService iSNOW_BDATA_WARNSTANDARDService;
		public ISNOW_BDATA_WARNSTANDARDService ISNOW_BDATA_WARNSTANDARDService
		{
			get
			{
				if(iSNOW_BDATA_WARNSTANDARDService==null)
					iSNOW_BDATA_WARNSTANDARDService= new SNOW_BDATA_WARNSTANDARDService();
				return iSNOW_BDATA_WARNSTANDARDService;
			}
			set
			{
				iSNOW_BDATA_WARNSTANDARDService= value;
			}
		}
		#endregion

    
		#region 347 业务接口 ISNOW_RECORD_HISService
		ISNOW_RECORD_HISService iSNOW_RECORD_HISService;
		public ISNOW_RECORD_HISService ISNOW_RECORD_HISService
		{
			get
			{
				if(iSNOW_RECORD_HISService==null)
					iSNOW_RECORD_HISService= new SNOW_RECORD_HISService();
				return iSNOW_RECORD_HISService;
			}
			set
			{
				iSNOW_RECORD_HISService= value;
			}
		}
		#endregion

    
		#region 348 业务接口 ISNOW_SECTION_LINEService
		ISNOW_SECTION_LINEService iSNOW_SECTION_LINEService;
		public ISNOW_SECTION_LINEService ISNOW_SECTION_LINEService
		{
			get
			{
				if(iSNOW_SECTION_LINEService==null)
					iSNOW_SECTION_LINEService= new SNOW_SECTION_LINEService();
				return iSNOW_SECTION_LINEService;
			}
			set
			{
				iSNOW_SECTION_LINEService= value;
			}
		}
		#endregion

    
		#region 349 业务接口 ISNOW_VIDEO_FILEService
		ISNOW_VIDEO_FILEService iSNOW_VIDEO_FILEService;
		public ISNOW_VIDEO_FILEService ISNOW_VIDEO_FILEService
		{
			get
			{
				if(iSNOW_VIDEO_FILEService==null)
					iSNOW_VIDEO_FILEService= new SNOW_VIDEO_FILEService();
				return iSNOW_VIDEO_FILEService;
			}
			set
			{
				iSNOW_VIDEO_FILEService= value;
			}
		}
		#endregion

    
		#region 350 业务接口 ISYS_DEPTService
		ISYS_DEPTService iSYS_DEPTService;
		public ISYS_DEPTService ISYS_DEPTService
		{
			get
			{
				if(iSYS_DEPTService==null)
					iSYS_DEPTService= new SYS_DEPTService();
				return iSYS_DEPTService;
			}
			set
			{
				iSYS_DEPTService= value;
			}
		}
		#endregion

    
		#region 351 业务接口 ISYS_INTELLIGENCE_DICService
		ISYS_INTELLIGENCE_DICService iSYS_INTELLIGENCE_DICService;
		public ISYS_INTELLIGENCE_DICService ISYS_INTELLIGENCE_DICService
		{
			get
			{
				if(iSYS_INTELLIGENCE_DICService==null)
					iSYS_INTELLIGENCE_DICService= new SYS_INTELLIGENCE_DICService();
				return iSYS_INTELLIGENCE_DICService;
			}
			set
			{
				iSYS_INTELLIGENCE_DICService= value;
			}
		}
		#endregion

    
		#region 352 业务接口 ISYS_MEMBERService
		ISYS_MEMBERService iSYS_MEMBERService;
		public ISYS_MEMBERService ISYS_MEMBERService
		{
			get
			{
				if(iSYS_MEMBERService==null)
					iSYS_MEMBERService= new SYS_MEMBERService();
				return iSYS_MEMBERService;
			}
			set
			{
				iSYS_MEMBERService= value;
			}
		}
		#endregion

    
		#region 353 业务接口 ISYS_MENUService
		ISYS_MENUService iSYS_MENUService;
		public ISYS_MENUService ISYS_MENUService
		{
			get
			{
				if(iSYS_MENUService==null)
					iSYS_MENUService= new SYS_MENUService();
				return iSYS_MENUService;
			}
			set
			{
				iSYS_MENUService= value;
			}
		}
		#endregion

    
		#region 354 业务接口 ISYS_MENU_HELPCONTENTService
		ISYS_MENU_HELPCONTENTService iSYS_MENU_HELPCONTENTService;
		public ISYS_MENU_HELPCONTENTService ISYS_MENU_HELPCONTENTService
		{
			get
			{
				if(iSYS_MENU_HELPCONTENTService==null)
					iSYS_MENU_HELPCONTENTService= new SYS_MENU_HELPCONTENTService();
				return iSYS_MENU_HELPCONTENTService;
			}
			set
			{
				iSYS_MENU_HELPCONTENTService= value;
			}
		}
		#endregion

    
		#region 355 业务接口 ISYS_MENUOPTService
		ISYS_MENUOPTService iSYS_MENUOPTService;
		public ISYS_MENUOPTService ISYS_MENUOPTService
		{
			get
			{
				if(iSYS_MENUOPTService==null)
					iSYS_MENUOPTService= new SYS_MENUOPTService();
				return iSYS_MENUOPTService;
			}
			set
			{
				iSYS_MENUOPTService= value;
			}
		}
		#endregion

    
		#region 356 业务接口 ISYS_POSLEVEL_DICService
		ISYS_POSLEVEL_DICService iSYS_POSLEVEL_DICService;
		public ISYS_POSLEVEL_DICService ISYS_POSLEVEL_DICService
		{
			get
			{
				if(iSYS_POSLEVEL_DICService==null)
					iSYS_POSLEVEL_DICService= new SYS_POSLEVEL_DICService();
				return iSYS_POSLEVEL_DICService;
			}
			set
			{
				iSYS_POSLEVEL_DICService= value;
			}
		}
		#endregion

    
		#region 357 业务接口 ISYS_ROLEService
		ISYS_ROLEService iSYS_ROLEService;
		public ISYS_ROLEService ISYS_ROLEService
		{
			get
			{
				if(iSYS_ROLEService==null)
					iSYS_ROLEService= new SYS_ROLEService();
				return iSYS_ROLEService;
			}
			set
			{
				iSYS_ROLEService= value;
			}
		}
		#endregion

    
		#region 358 业务接口 ISYS_ROLE_MENU_MAPService
		ISYS_ROLE_MENU_MAPService iSYS_ROLE_MENU_MAPService;
		public ISYS_ROLE_MENU_MAPService ISYS_ROLE_MENU_MAPService
		{
			get
			{
				if(iSYS_ROLE_MENU_MAPService==null)
					iSYS_ROLE_MENU_MAPService= new SYS_ROLE_MENU_MAPService();
				return iSYS_ROLE_MENU_MAPService;
			}
			set
			{
				iSYS_ROLE_MENU_MAPService= value;
			}
		}
		#endregion

    
		#region 359 业务接口 ISYS_ROLE_MENUOPT_MAPService
		ISYS_ROLE_MENUOPT_MAPService iSYS_ROLE_MENUOPT_MAPService;
		public ISYS_ROLE_MENUOPT_MAPService ISYS_ROLE_MENUOPT_MAPService
		{
			get
			{
				if(iSYS_ROLE_MENUOPT_MAPService==null)
					iSYS_ROLE_MENUOPT_MAPService= new SYS_ROLE_MENUOPT_MAPService();
				return iSYS_ROLE_MENUOPT_MAPService;
			}
			set
			{
				iSYS_ROLE_MENUOPT_MAPService= value;
			}
		}
		#endregion

    
		#region 360 业务接口 ISYS_STATIONMEMBER_NOService
		ISYS_STATIONMEMBER_NOService iSYS_STATIONMEMBER_NOService;
		public ISYS_STATIONMEMBER_NOService ISYS_STATIONMEMBER_NOService
		{
			get
			{
				if(iSYS_STATIONMEMBER_NOService==null)
					iSYS_STATIONMEMBER_NOService= new SYS_STATIONMEMBER_NOService();
				return iSYS_STATIONMEMBER_NOService;
			}
			set
			{
				iSYS_STATIONMEMBER_NOService= value;
			}
		}
		#endregion

    
		#region 361 业务接口 ISYS_USERService
		ISYS_USERService iSYS_USERService;
		public ISYS_USERService ISYS_USERService
		{
			get
			{
				if(iSYS_USERService==null)
					iSYS_USERService= new SYS_USERService();
				return iSYS_USERService;
			}
			set
			{
				iSYS_USERService= value;
			}
		}
		#endregion

    
		#region 362 业务接口 ISYS_USER_DEFAULTMENUService
		ISYS_USER_DEFAULTMENUService iSYS_USER_DEFAULTMENUService;
		public ISYS_USER_DEFAULTMENUService ISYS_USER_DEFAULTMENUService
		{
			get
			{
				if(iSYS_USER_DEFAULTMENUService==null)
					iSYS_USER_DEFAULTMENUService= new SYS_USER_DEFAULTMENUService();
				return iSYS_USER_DEFAULTMENUService;
			}
			set
			{
				iSYS_USER_DEFAULTMENUService= value;
			}
		}
		#endregion

    
		#region 363 业务接口 ISYS_USER_PHONE_DICService
		ISYS_USER_PHONE_DICService iSYS_USER_PHONE_DICService;
		public ISYS_USER_PHONE_DICService ISYS_USER_PHONE_DICService
		{
			get
			{
				if(iSYS_USER_PHONE_DICService==null)
					iSYS_USER_PHONE_DICService= new SYS_USER_PHONE_DICService();
				return iSYS_USER_PHONE_DICService;
			}
			set
			{
				iSYS_USER_PHONE_DICService= value;
			}
		}
		#endregion

    
		#region 364 业务接口 ISYS_USER_ROLE_MAPService
		ISYS_USER_ROLE_MAPService iSYS_USER_ROLE_MAPService;
		public ISYS_USER_ROLE_MAPService ISYS_USER_ROLE_MAPService
		{
			get
			{
				if(iSYS_USER_ROLE_MAPService==null)
					iSYS_USER_ROLE_MAPService= new SYS_USER_ROLE_MAPService();
				return iSYS_USER_ROLE_MAPService;
			}
			set
			{
				iSYS_USER_ROLE_MAPService= value;
			}
		}
		#endregion

    
		#region 365 业务接口 ISYS_USERLOGINService
		ISYS_USERLOGINService iSYS_USERLOGINService;
		public ISYS_USERLOGINService ISYS_USERLOGINService
		{
			get
			{
				if(iSYS_USERLOGINService==null)
					iSYS_USERLOGINService= new SYS_USERLOGINService();
				return iSYS_USERLOGINService;
			}
			set
			{
				iSYS_USERLOGINService= value;
			}
		}
		#endregion

    
		#region 366 业务接口 IT_ASS_BOUNDService
		IT_ASS_BOUNDService iT_ASS_BOUNDService;
		public IT_ASS_BOUNDService IT_ASS_BOUNDService
		{
			get
			{
				if(iT_ASS_BOUNDService==null)
					iT_ASS_BOUNDService= new T_ASS_BOUNDService();
				return iT_ASS_BOUNDService;
			}
			set
			{
				iT_ASS_BOUNDService= value;
			}
		}
		#endregion

    
		#region 367 业务接口 IT_ASS_BRIDGEService
		IT_ASS_BRIDGEService iT_ASS_BRIDGEService;
		public IT_ASS_BRIDGEService IT_ASS_BRIDGEService
		{
			get
			{
				if(iT_ASS_BRIDGEService==null)
					iT_ASS_BRIDGEService= new T_ASS_BRIDGEService();
				return iT_ASS_BRIDGEService;
			}
			set
			{
				iT_ASS_BRIDGEService= value;
			}
		}
		#endregion

    
		#region 368 业务接口 IT_ASS_BROKENCHAINService
		IT_ASS_BROKENCHAINService iT_ASS_BROKENCHAINService;
		public IT_ASS_BROKENCHAINService IT_ASS_BROKENCHAINService
		{
			get
			{
				if(iT_ASS_BROKENCHAINService==null)
					iT_ASS_BROKENCHAINService= new T_ASS_BROKENCHAINService();
				return iT_ASS_BROKENCHAINService;
			}
			set
			{
				iT_ASS_BROKENCHAINService= value;
			}
		}
		#endregion

    
		#region 369 业务接口 IT_ASS_COMBINEDRAWService
		IT_ASS_COMBINEDRAWService iT_ASS_COMBINEDRAWService;
		public IT_ASS_COMBINEDRAWService IT_ASS_COMBINEDRAWService
		{
			get
			{
				if(iT_ASS_COMBINEDRAWService==null)
					iT_ASS_COMBINEDRAWService= new T_ASS_COMBINEDRAWService();
				return iT_ASS_COMBINEDRAWService;
			}
			set
			{
				iT_ASS_COMBINEDRAWService= value;
			}
		}
		#endregion

    
		#region 370 业务接口 IT_ASS_COMPMAINT_PLANService
		IT_ASS_COMPMAINT_PLANService iT_ASS_COMPMAINT_PLANService;
		public IT_ASS_COMPMAINT_PLANService IT_ASS_COMPMAINT_PLANService
		{
			get
			{
				if(iT_ASS_COMPMAINT_PLANService==null)
					iT_ASS_COMPMAINT_PLANService= new T_ASS_COMPMAINT_PLANService();
				return iT_ASS_COMPMAINT_PLANService;
			}
			set
			{
				iT_ASS_COMPMAINT_PLANService= value;
			}
		}
		#endregion

    
		#region 371 业务接口 IT_ASS_COMPMAINT_PLAN_DETAILService
		IT_ASS_COMPMAINT_PLAN_DETAILService iT_ASS_COMPMAINT_PLAN_DETAILService;
		public IT_ASS_COMPMAINT_PLAN_DETAILService IT_ASS_COMPMAINT_PLAN_DETAILService
		{
			get
			{
				if(iT_ASS_COMPMAINT_PLAN_DETAILService==null)
					iT_ASS_COMPMAINT_PLAN_DETAILService= new T_ASS_COMPMAINT_PLAN_DETAILService();
				return iT_ASS_COMPMAINT_PLAN_DETAILService;
			}
			set
			{
				iT_ASS_COMPMAINT_PLAN_DETAILService= value;
			}
		}
		#endregion

    
		#region 372 业务接口 IT_ASS_CURVEService
		IT_ASS_CURVEService iT_ASS_CURVEService;
		public IT_ASS_CURVEService IT_ASS_CURVEService
		{
			get
			{
				if(iT_ASS_CURVEService==null)
					iT_ASS_CURVEService= new T_ASS_CURVEService();
				return iT_ASS_CURVEService;
			}
			set
			{
				iT_ASS_CURVEService= value;
			}
		}
		#endregion

    
		#region 373 业务接口 IT_ASS_EMPService
		IT_ASS_EMPService iT_ASS_EMPService;
		public IT_ASS_EMPService IT_ASS_EMPService
		{
			get
			{
				if(iT_ASS_EMPService==null)
					iT_ASS_EMPService= new T_ASS_EMPService();
				return iT_ASS_EMPService;
			}
			set
			{
				iT_ASS_EMPService= value;
			}
		}
		#endregion

    
		#region 374 业务接口 IT_ASS_EQU_DATA_TEMPService
		IT_ASS_EQU_DATA_TEMPService iT_ASS_EQU_DATA_TEMPService;
		public IT_ASS_EQU_DATA_TEMPService IT_ASS_EQU_DATA_TEMPService
		{
			get
			{
				if(iT_ASS_EQU_DATA_TEMPService==null)
					iT_ASS_EQU_DATA_TEMPService= new T_ASS_EQU_DATA_TEMPService();
				return iT_ASS_EQU_DATA_TEMPService;
			}
			set
			{
				iT_ASS_EQU_DATA_TEMPService= value;
			}
		}
		#endregion

    
		#region 375 业务接口 IT_ASS_FLOWService
		IT_ASS_FLOWService iT_ASS_FLOWService;
		public IT_ASS_FLOWService IT_ASS_FLOWService
		{
			get
			{
				if(iT_ASS_FLOWService==null)
					iT_ASS_FLOWService= new T_ASS_FLOWService();
				return iT_ASS_FLOWService;
			}
			set
			{
				iT_ASS_FLOWService= value;
			}
		}
		#endregion

    
		#region 376 业务接口 IT_ASS_FLOW_INSTANCEService
		IT_ASS_FLOW_INSTANCEService iT_ASS_FLOW_INSTANCEService;
		public IT_ASS_FLOW_INSTANCEService IT_ASS_FLOW_INSTANCEService
		{
			get
			{
				if(iT_ASS_FLOW_INSTANCEService==null)
					iT_ASS_FLOW_INSTANCEService= new T_ASS_FLOW_INSTANCEService();
				return iT_ASS_FLOW_INSTANCEService;
			}
			set
			{
				iT_ASS_FLOW_INSTANCEService= value;
			}
		}
		#endregion

    
		#region 377 业务接口 IT_ASS_FLOW_PROCESSService
		IT_ASS_FLOW_PROCESSService iT_ASS_FLOW_PROCESSService;
		public IT_ASS_FLOW_PROCESSService IT_ASS_FLOW_PROCESSService
		{
			get
			{
				if(iT_ASS_FLOW_PROCESSService==null)
					iT_ASS_FLOW_PROCESSService= new T_ASS_FLOW_PROCESSService();
				return iT_ASS_FLOW_PROCESSService;
			}
			set
			{
				iT_ASS_FLOW_PROCESSService= value;
			}
		}
		#endregion

    
		#region 378 业务接口 IT_ASS_FLOW_ROLEService
		IT_ASS_FLOW_ROLEService iT_ASS_FLOW_ROLEService;
		public IT_ASS_FLOW_ROLEService IT_ASS_FLOW_ROLEService
		{
			get
			{
				if(iT_ASS_FLOW_ROLEService==null)
					iT_ASS_FLOW_ROLEService= new T_ASS_FLOW_ROLEService();
				return iT_ASS_FLOW_ROLEService;
			}
			set
			{
				iT_ASS_FLOW_ROLEService= value;
			}
		}
		#endregion

    
		#region 379 业务接口 IT_ASS_FLOW_STEPService
		IT_ASS_FLOW_STEPService iT_ASS_FLOW_STEPService;
		public IT_ASS_FLOW_STEPService IT_ASS_FLOW_STEPService
		{
			get
			{
				if(iT_ASS_FLOW_STEPService==null)
					iT_ASS_FLOW_STEPService= new T_ASS_FLOW_STEPService();
				return iT_ASS_FLOW_STEPService;
			}
			set
			{
				iT_ASS_FLOW_STEPService= value;
			}
		}
		#endregion

    
		#region 380 业务接口 IT_ASS_FLOW_USER_ROLEService
		IT_ASS_FLOW_USER_ROLEService iT_ASS_FLOW_USER_ROLEService;
		public IT_ASS_FLOW_USER_ROLEService IT_ASS_FLOW_USER_ROLEService
		{
			get
			{
				if(iT_ASS_FLOW_USER_ROLEService==null)
					iT_ASS_FLOW_USER_ROLEService= new T_ASS_FLOW_USER_ROLEService();
				return iT_ASS_FLOW_USER_ROLEService;
			}
			set
			{
				iT_ASS_FLOW_USER_ROLEService= value;
			}
		}
		#endregion

    
		#region 381 业务接口 IT_ASS_GJC_AVESCOREService
		IT_ASS_GJC_AVESCOREService iT_ASS_GJC_AVESCOREService;
		public IT_ASS_GJC_AVESCOREService IT_ASS_GJC_AVESCOREService
		{
			get
			{
				if(iT_ASS_GJC_AVESCOREService==null)
					iT_ASS_GJC_AVESCOREService= new T_ASS_GJC_AVESCOREService();
				return iT_ASS_GJC_AVESCOREService;
			}
			set
			{
				iT_ASS_GJC_AVESCOREService= value;
			}
		}
		#endregion

    
		#region 382 业务接口 IT_ASS_LINEDRAWService
		IT_ASS_LINEDRAWService iT_ASS_LINEDRAWService;
		public IT_ASS_LINEDRAWService IT_ASS_LINEDRAWService
		{
			get
			{
				if(iT_ASS_LINEDRAWService==null)
					iT_ASS_LINEDRAWService= new T_ASS_LINEDRAWService();
				return iT_ASS_LINEDRAWService;
			}
			set
			{
				iT_ASS_LINEDRAWService= value;
			}
		}
		#endregion

    
		#region 383 业务接口 IT_ASS_MATERIALService
		IT_ASS_MATERIALService iT_ASS_MATERIALService;
		public IT_ASS_MATERIALService IT_ASS_MATERIALService
		{
			get
			{
				if(iT_ASS_MATERIALService==null)
					iT_ASS_MATERIALService= new T_ASS_MATERIALService();
				return iT_ASS_MATERIALService;
			}
			set
			{
				iT_ASS_MATERIALService= value;
			}
		}
		#endregion

    
		#region 384 业务接口 IT_ASS_PARA_DYN_SCOREService
		IT_ASS_PARA_DYN_SCOREService iT_ASS_PARA_DYN_SCOREService;
		public IT_ASS_PARA_DYN_SCOREService IT_ASS_PARA_DYN_SCOREService
		{
			get
			{
				if(iT_ASS_PARA_DYN_SCOREService==null)
					iT_ASS_PARA_DYN_SCOREService= new T_ASS_PARA_DYN_SCOREService();
				return iT_ASS_PARA_DYN_SCOREService;
			}
			set
			{
				iT_ASS_PARA_DYN_SCOREService= value;
			}
		}
		#endregion

    
		#region 385 业务接口 IT_ASS_PARA_LEVEL_SCOREService
		IT_ASS_PARA_LEVEL_SCOREService iT_ASS_PARA_LEVEL_SCOREService;
		public IT_ASS_PARA_LEVEL_SCOREService IT_ASS_PARA_LEVEL_SCOREService
		{
			get
			{
				if(iT_ASS_PARA_LEVEL_SCOREService==null)
					iT_ASS_PARA_LEVEL_SCOREService= new T_ASS_PARA_LEVEL_SCOREService();
				return iT_ASS_PARA_LEVEL_SCOREService;
			}
			set
			{
				iT_ASS_PARA_LEVEL_SCOREService= value;
			}
		}
		#endregion

    
		#region 386 业务接口 IT_ASS_PARA_PLACEService
		IT_ASS_PARA_PLACEService iT_ASS_PARA_PLACEService;
		public IT_ASS_PARA_PLACEService IT_ASS_PARA_PLACEService
		{
			get
			{
				if(iT_ASS_PARA_PLACEService==null)
					iT_ASS_PARA_PLACEService= new T_ASS_PARA_PLACEService();
				return iT_ASS_PARA_PLACEService;
			}
			set
			{
				iT_ASS_PARA_PLACEService= value;
			}
		}
		#endregion

    
		#region 387 业务接口 IT_ASS_PARA_PRO_CTRLService
		IT_ASS_PARA_PRO_CTRLService iT_ASS_PARA_PRO_CTRLService;
		public IT_ASS_PARA_PRO_CTRLService IT_ASS_PARA_PRO_CTRLService
		{
			get
			{
				if(iT_ASS_PARA_PRO_CTRLService==null)
					iT_ASS_PARA_PRO_CTRLService= new T_ASS_PARA_PRO_CTRLService();
				return iT_ASS_PARA_PRO_CTRLService;
			}
			set
			{
				iT_ASS_PARA_PRO_CTRLService= value;
			}
		}
		#endregion

    
		#region 388 业务接口 IT_ASS_PARA_PRO_TYPEService
		IT_ASS_PARA_PRO_TYPEService iT_ASS_PARA_PRO_TYPEService;
		public IT_ASS_PARA_PRO_TYPEService IT_ASS_PARA_PRO_TYPEService
		{
			get
			{
				if(iT_ASS_PARA_PRO_TYPEService==null)
					iT_ASS_PARA_PRO_TYPEService= new T_ASS_PARA_PRO_TYPEService();
				return iT_ASS_PARA_PRO_TYPEService;
			}
			set
			{
				iT_ASS_PARA_PRO_TYPEService= value;
			}
		}
		#endregion

    
		#region 389 业务接口 IT_ASS_PARA_SCOREService
		IT_ASS_PARA_SCOREService iT_ASS_PARA_SCOREService;
		public IT_ASS_PARA_SCOREService IT_ASS_PARA_SCOREService
		{
			get
			{
				if(iT_ASS_PARA_SCOREService==null)
					iT_ASS_PARA_SCOREService= new T_ASS_PARA_SCOREService();
				return iT_ASS_PARA_SCOREService;
			}
			set
			{
				iT_ASS_PARA_SCOREService= value;
			}
		}
		#endregion

    
		#region 390 业务接口 IT_ASS_PARAREPORT_TEMPService
		IT_ASS_PARAREPORT_TEMPService iT_ASS_PARAREPORT_TEMPService;
		public IT_ASS_PARAREPORT_TEMPService IT_ASS_PARAREPORT_TEMPService
		{
			get
			{
				if(iT_ASS_PARAREPORT_TEMPService==null)
					iT_ASS_PARAREPORT_TEMPService= new T_ASS_PARAREPORT_TEMPService();
				return iT_ASS_PARAREPORT_TEMPService;
			}
			set
			{
				iT_ASS_PARAREPORT_TEMPService= value;
			}
		}
		#endregion

    
		#region 391 业务接口 IT_ASS_PLAN_CONSTRUCTIONService
		IT_ASS_PLAN_CONSTRUCTIONService iT_ASS_PLAN_CONSTRUCTIONService;
		public IT_ASS_PLAN_CONSTRUCTIONService IT_ASS_PLAN_CONSTRUCTIONService
		{
			get
			{
				if(iT_ASS_PLAN_CONSTRUCTIONService==null)
					iT_ASS_PLAN_CONSTRUCTIONService= new T_ASS_PLAN_CONSTRUCTIONService();
				return iT_ASS_PLAN_CONSTRUCTIONService;
			}
			set
			{
				iT_ASS_PLAN_CONSTRUCTIONService= value;
			}
		}
		#endregion

    
		#region 392 业务接口 IT_ASS_PLAN_DAILYService
		IT_ASS_PLAN_DAILYService iT_ASS_PLAN_DAILYService;
		public IT_ASS_PLAN_DAILYService IT_ASS_PLAN_DAILYService
		{
			get
			{
				if(iT_ASS_PLAN_DAILYService==null)
					iT_ASS_PLAN_DAILYService= new T_ASS_PLAN_DAILYService();
				return iT_ASS_PLAN_DAILYService;
			}
			set
			{
				iT_ASS_PLAN_DAILYService= value;
			}
		}
		#endregion

    
		#region 393 业务接口 IT_ASS_PLAN_DATA_TEMPService
		IT_ASS_PLAN_DATA_TEMPService iT_ASS_PLAN_DATA_TEMPService;
		public IT_ASS_PLAN_DATA_TEMPService IT_ASS_PLAN_DATA_TEMPService
		{
			get
			{
				if(iT_ASS_PLAN_DATA_TEMPService==null)
					iT_ASS_PLAN_DATA_TEMPService= new T_ASS_PLAN_DATA_TEMPService();
				return iT_ASS_PLAN_DATA_TEMPService;
			}
			set
			{
				iT_ASS_PLAN_DATA_TEMPService= value;
			}
		}
		#endregion

    
		#region 394 业务接口 IT_ASS_PLAN_FLOWService
		IT_ASS_PLAN_FLOWService iT_ASS_PLAN_FLOWService;
		public IT_ASS_PLAN_FLOWService IT_ASS_PLAN_FLOWService
		{
			get
			{
				if(iT_ASS_PLAN_FLOWService==null)
					iT_ASS_PLAN_FLOWService= new T_ASS_PLAN_FLOWService();
				return iT_ASS_PLAN_FLOWService;
			}
			set
			{
				iT_ASS_PLAN_FLOWService= value;
			}
		}
		#endregion

    
		#region 395 业务接口 IT_ASS_PLAN_LOCATEService
		IT_ASS_PLAN_LOCATEService iT_ASS_PLAN_LOCATEService;
		public IT_ASS_PLAN_LOCATEService IT_ASS_PLAN_LOCATEService
		{
			get
			{
				if(iT_ASS_PLAN_LOCATEService==null)
					iT_ASS_PLAN_LOCATEService= new T_ASS_PLAN_LOCATEService();
				return iT_ASS_PLAN_LOCATEService;
			}
			set
			{
				iT_ASS_PLAN_LOCATEService= value;
			}
		}
		#endregion

    
		#region 396 业务接口 IT_ASS_PLAN_MATERIALService
		IT_ASS_PLAN_MATERIALService iT_ASS_PLAN_MATERIALService;
		public IT_ASS_PLAN_MATERIALService IT_ASS_PLAN_MATERIALService
		{
			get
			{
				if(iT_ASS_PLAN_MATERIALService==null)
					iT_ASS_PLAN_MATERIALService= new T_ASS_PLAN_MATERIALService();
				return iT_ASS_PLAN_MATERIALService;
			}
			set
			{
				iT_ASS_PLAN_MATERIALService= value;
			}
		}
		#endregion

    
		#region 397 业务接口 IT_ASS_PLAN_MEMBERService
		IT_ASS_PLAN_MEMBERService iT_ASS_PLAN_MEMBERService;
		public IT_ASS_PLAN_MEMBERService IT_ASS_PLAN_MEMBERService
		{
			get
			{
				if(iT_ASS_PLAN_MEMBERService==null)
					iT_ASS_PLAN_MEMBERService= new T_ASS_PLAN_MEMBERService();
				return iT_ASS_PLAN_MEMBERService;
			}
			set
			{
				iT_ASS_PLAN_MEMBERService= value;
			}
		}
		#endregion

    
		#region 398 业务接口 IT_ASS_PLAN_MONTHService
		IT_ASS_PLAN_MONTHService iT_ASS_PLAN_MONTHService;
		public IT_ASS_PLAN_MONTHService IT_ASS_PLAN_MONTHService
		{
			get
			{
				if(iT_ASS_PLAN_MONTHService==null)
					iT_ASS_PLAN_MONTHService= new T_ASS_PLAN_MONTHService();
				return iT_ASS_PLAN_MONTHService;
			}
			set
			{
				iT_ASS_PLAN_MONTHService= value;
			}
		}
		#endregion

    
		#region 399 业务接口 IT_ASS_PLAN_PROBLEMService
		IT_ASS_PLAN_PROBLEMService iT_ASS_PLAN_PROBLEMService;
		public IT_ASS_PLAN_PROBLEMService IT_ASS_PLAN_PROBLEMService
		{
			get
			{
				if(iT_ASS_PLAN_PROBLEMService==null)
					iT_ASS_PLAN_PROBLEMService= new T_ASS_PLAN_PROBLEMService();
				return iT_ASS_PLAN_PROBLEMService;
			}
			set
			{
				iT_ASS_PLAN_PROBLEMService= value;
			}
		}
		#endregion

    
		#region 400 业务接口 IT_ASS_PLAN_PROJECTService
		IT_ASS_PLAN_PROJECTService iT_ASS_PLAN_PROJECTService;
		public IT_ASS_PLAN_PROJECTService IT_ASS_PLAN_PROJECTService
		{
			get
			{
				if(iT_ASS_PLAN_PROJECTService==null)
					iT_ASS_PLAN_PROJECTService= new T_ASS_PLAN_PROJECTService();
				return iT_ASS_PLAN_PROJECTService;
			}
			set
			{
				iT_ASS_PLAN_PROJECTService= value;
			}
		}
		#endregion

    
		#region 401 业务接口 IT_ASS_PLAN_REPAIRService
		IT_ASS_PLAN_REPAIRService iT_ASS_PLAN_REPAIRService;
		public IT_ASS_PLAN_REPAIRService IT_ASS_PLAN_REPAIRService
		{
			get
			{
				if(iT_ASS_PLAN_REPAIRService==null)
					iT_ASS_PLAN_REPAIRService= new T_ASS_PLAN_REPAIRService();
				return iT_ASS_PLAN_REPAIRService;
			}
			set
			{
				iT_ASS_PLAN_REPAIRService= value;
			}
		}
		#endregion

    
		#region 402 业务接口 IT_ASS_PLAN_TOOLService
		IT_ASS_PLAN_TOOLService iT_ASS_PLAN_TOOLService;
		public IT_ASS_PLAN_TOOLService IT_ASS_PLAN_TOOLService
		{
			get
			{
				if(iT_ASS_PLAN_TOOLService==null)
					iT_ASS_PLAN_TOOLService= new T_ASS_PLAN_TOOLService();
				return iT_ASS_PLAN_TOOLService;
			}
			set
			{
				iT_ASS_PLAN_TOOLService= value;
			}
		}
		#endregion

    
		#region 403 业务接口 IT_ASS_PLAN_UNIT_PRO_STATService
		IT_ASS_PLAN_UNIT_PRO_STATService iT_ASS_PLAN_UNIT_PRO_STATService;
		public IT_ASS_PLAN_UNIT_PRO_STATService IT_ASS_PLAN_UNIT_PRO_STATService
		{
			get
			{
				if(iT_ASS_PLAN_UNIT_PRO_STATService==null)
					iT_ASS_PLAN_UNIT_PRO_STATService= new T_ASS_PLAN_UNIT_PRO_STATService();
				return iT_ASS_PLAN_UNIT_PRO_STATService;
			}
			set
			{
				iT_ASS_PLAN_UNIT_PRO_STATService= value;
			}
		}
		#endregion

    
		#region 404 业务接口 IT_ASS_PLAN_WEEKService
		IT_ASS_PLAN_WEEKService iT_ASS_PLAN_WEEKService;
		public IT_ASS_PLAN_WEEKService IT_ASS_PLAN_WEEKService
		{
			get
			{
				if(iT_ASS_PLAN_WEEKService==null)
					iT_ASS_PLAN_WEEKService= new T_ASS_PLAN_WEEKService();
				return iT_ASS_PLAN_WEEKService;
			}
			set
			{
				iT_ASS_PLAN_WEEKService= value;
			}
		}
		#endregion

    
		#region 405 业务接口 IT_ASS_PROBLEMService
		IT_ASS_PROBLEMService iT_ASS_PROBLEMService;
		public IT_ASS_PROBLEMService IT_ASS_PROBLEMService
		{
			get
			{
				if(iT_ASS_PROBLEMService==null)
					iT_ASS_PROBLEMService= new T_ASS_PROBLEMService();
				return iT_ASS_PROBLEMService;
			}
			set
			{
				iT_ASS_PROBLEMService= value;
			}
		}
		#endregion

    
		#region 406 业务接口 IT_ASS_PROBLEM_HISService
		IT_ASS_PROBLEM_HISService iT_ASS_PROBLEM_HISService;
		public IT_ASS_PROBLEM_HISService IT_ASS_PROBLEM_HISService
		{
			get
			{
				if(iT_ASS_PROBLEM_HISService==null)
					iT_ASS_PROBLEM_HISService= new T_ASS_PROBLEM_HISService();
				return iT_ASS_PROBLEM_HISService;
			}
			set
			{
				iT_ASS_PROBLEM_HISService= value;
			}
		}
		#endregion

    
		#region 407 业务接口 IT_ASS_PROBLEM_LJService
		IT_ASS_PROBLEM_LJService iT_ASS_PROBLEM_LJService;
		public IT_ASS_PROBLEM_LJService IT_ASS_PROBLEM_LJService
		{
			get
			{
				if(iT_ASS_PROBLEM_LJService==null)
					iT_ASS_PROBLEM_LJService= new T_ASS_PROBLEM_LJService();
				return iT_ASS_PROBLEM_LJService;
			}
			set
			{
				iT_ASS_PROBLEM_LJService= value;
			}
		}
		#endregion

    
		#region 408 业务接口 IT_ASS_PROBLEM_ORIService
		IT_ASS_PROBLEM_ORIService iT_ASS_PROBLEM_ORIService;
		public IT_ASS_PROBLEM_ORIService IT_ASS_PROBLEM_ORIService
		{
			get
			{
				if(iT_ASS_PROBLEM_ORIService==null)
					iT_ASS_PROBLEM_ORIService= new T_ASS_PROBLEM_ORIService();
				return iT_ASS_PROBLEM_ORIService;
			}
			set
			{
				iT_ASS_PROBLEM_ORIService= value;
			}
		}
		#endregion

    
		#region 409 业务接口 IT_ASS_PROBLEM_TEMPService
		IT_ASS_PROBLEM_TEMPService iT_ASS_PROBLEM_TEMPService;
		public IT_ASS_PROBLEM_TEMPService IT_ASS_PROBLEM_TEMPService
		{
			get
			{
				if(iT_ASS_PROBLEM_TEMPService==null)
					iT_ASS_PROBLEM_TEMPService= new T_ASS_PROBLEM_TEMPService();
				return iT_ASS_PROBLEM_TEMPService;
			}
			set
			{
				iT_ASS_PROBLEM_TEMPService= value;
			}
		}
		#endregion

    
		#region 410 业务接口 IT_ASS_PROJECTService
		IT_ASS_PROJECTService iT_ASS_PROJECTService;
		public IT_ASS_PROJECTService IT_ASS_PROJECTService
		{
			get
			{
				if(iT_ASS_PROJECTService==null)
					iT_ASS_PROJECTService= new T_ASS_PROJECTService();
				return iT_ASS_PROJECTService;
			}
			set
			{
				iT_ASS_PROJECTService= value;
			}
		}
		#endregion

    
		#region 411 业务接口 IT_ASS_REPEAT_PROBLEMService
		IT_ASS_REPEAT_PROBLEMService iT_ASS_REPEAT_PROBLEMService;
		public IT_ASS_REPEAT_PROBLEMService IT_ASS_REPEAT_PROBLEMService
		{
			get
			{
				if(iT_ASS_REPEAT_PROBLEMService==null)
					iT_ASS_REPEAT_PROBLEMService= new T_ASS_REPEAT_PROBLEMService();
				return iT_ASS_REPEAT_PROBLEMService;
			}
			set
			{
				iT_ASS_REPEAT_PROBLEMService= value;
			}
		}
		#endregion

    
		#region 412 业务接口 IT_ASS_REPEAT_PRODETAILService
		IT_ASS_REPEAT_PRODETAILService iT_ASS_REPEAT_PRODETAILService;
		public IT_ASS_REPEAT_PRODETAILService IT_ASS_REPEAT_PRODETAILService
		{
			get
			{
				if(iT_ASS_REPEAT_PRODETAILService==null)
					iT_ASS_REPEAT_PRODETAILService= new T_ASS_REPEAT_PRODETAILService();
				return iT_ASS_REPEAT_PRODETAILService;
			}
			set
			{
				iT_ASS_REPEAT_PRODETAILService= value;
			}
		}
		#endregion

    
		#region 413 业务接口 IT_ASS_SECURITY_OFFERService
		IT_ASS_SECURITY_OFFERService iT_ASS_SECURITY_OFFERService;
		public IT_ASS_SECURITY_OFFERService IT_ASS_SECURITY_OFFERService
		{
			get
			{
				if(iT_ASS_SECURITY_OFFERService==null)
					iT_ASS_SECURITY_OFFERService= new T_ASS_SECURITY_OFFERService();
				return iT_ASS_SECURITY_OFFERService;
			}
			set
			{
				iT_ASS_SECURITY_OFFERService= value;
			}
		}
		#endregion

    
		#region 414 业务接口 IT_ASS_STATIONService
		IT_ASS_STATIONService iT_ASS_STATIONService;
		public IT_ASS_STATIONService IT_ASS_STATIONService
		{
			get
			{
				if(iT_ASS_STATIONService==null)
					iT_ASS_STATIONService= new T_ASS_STATIONService();
				return iT_ASS_STATIONService;
			}
			set
			{
				iT_ASS_STATIONService= value;
			}
		}
		#endregion

    
		#region 415 业务接口 IT_ASS_STATIONSTAIRSService
		IT_ASS_STATIONSTAIRSService iT_ASS_STATIONSTAIRSService;
		public IT_ASS_STATIONSTAIRSService IT_ASS_STATIONSTAIRSService
		{
			get
			{
				if(iT_ASS_STATIONSTAIRSService==null)
					iT_ASS_STATIONSTAIRSService= new T_ASS_STATIONSTAIRSService();
				return iT_ASS_STATIONSTAIRSService;
			}
			set
			{
				iT_ASS_STATIONSTAIRSService= value;
			}
		}
		#endregion

    
		#region 416 业务接口 IT_ASS_TEMREPAIR_PLANService
		IT_ASS_TEMREPAIR_PLANService iT_ASS_TEMREPAIR_PLANService;
		public IT_ASS_TEMREPAIR_PLANService IT_ASS_TEMREPAIR_PLANService
		{
			get
			{
				if(iT_ASS_TEMREPAIR_PLANService==null)
					iT_ASS_TEMREPAIR_PLANService= new T_ASS_TEMREPAIR_PLANService();
				return iT_ASS_TEMREPAIR_PLANService;
			}
			set
			{
				iT_ASS_TEMREPAIR_PLANService= value;
			}
		}
		#endregion

    
		#region 417 业务接口 IT_ASS_TEMREPAIR_PLAN_DETAILService
		IT_ASS_TEMREPAIR_PLAN_DETAILService iT_ASS_TEMREPAIR_PLAN_DETAILService;
		public IT_ASS_TEMREPAIR_PLAN_DETAILService IT_ASS_TEMREPAIR_PLAN_DETAILService
		{
			get
			{
				if(iT_ASS_TEMREPAIR_PLAN_DETAILService==null)
					iT_ASS_TEMREPAIR_PLAN_DETAILService= new T_ASS_TEMREPAIR_PLAN_DETAILService();
				return iT_ASS_TEMREPAIR_PLAN_DETAILService;
			}
			set
			{
				iT_ASS_TEMREPAIR_PLAN_DETAILService= value;
			}
		}
		#endregion

    
		#region 418 业务接口 IT_ASS_TOOLINFOService
		IT_ASS_TOOLINFOService iT_ASS_TOOLINFOService;
		public IT_ASS_TOOLINFOService IT_ASS_TOOLINFOService
		{
			get
			{
				if(iT_ASS_TOOLINFOService==null)
					iT_ASS_TOOLINFOService= new T_ASS_TOOLINFOService();
				return iT_ASS_TOOLINFOService;
			}
			set
			{
				iT_ASS_TOOLINFOService= value;
			}
		}
		#endregion

    
		#region 419 业务接口 IT_ASS_TQIService
		IT_ASS_TQIService iT_ASS_TQIService;
		public IT_ASS_TQIService IT_ASS_TQIService
		{
			get
			{
				if(iT_ASS_TQIService==null)
					iT_ASS_TQIService= new T_ASS_TQIService();
				return iT_ASS_TQIService;
			}
			set
			{
				iT_ASS_TQIService= value;
			}
		}
		#endregion

    
		#region 420 业务接口 IT_ASS_TQI_AVESCOREService
		IT_ASS_TQI_AVESCOREService iT_ASS_TQI_AVESCOREService;
		public IT_ASS_TQI_AVESCOREService IT_ASS_TQI_AVESCOREService
		{
			get
			{
				if(iT_ASS_TQI_AVESCOREService==null)
					iT_ASS_TQI_AVESCOREService= new T_ASS_TQI_AVESCOREService();
				return iT_ASS_TQI_AVESCOREService;
			}
			set
			{
				iT_ASS_TQI_AVESCOREService= value;
			}
		}
		#endregion

    
		#region 421 业务接口 IT_ASS_TQI_DETAILService
		IT_ASS_TQI_DETAILService iT_ASS_TQI_DETAILService;
		public IT_ASS_TQI_DETAILService IT_ASS_TQI_DETAILService
		{
			get
			{
				if(iT_ASS_TQI_DETAILService==null)
					iT_ASS_TQI_DETAILService= new T_ASS_TQI_DETAILService();
				return iT_ASS_TQI_DETAILService;
			}
			set
			{
				iT_ASS_TQI_DETAILService= value;
			}
		}
		#endregion

    
		#region 422 业务接口 IT_ASS_TQI_PARAService
		IT_ASS_TQI_PARAService iT_ASS_TQI_PARAService;
		public IT_ASS_TQI_PARAService IT_ASS_TQI_PARAService
		{
			get
			{
				if(iT_ASS_TQI_PARAService==null)
					iT_ASS_TQI_PARAService= new T_ASS_TQI_PARAService();
				return iT_ASS_TQI_PARAService;
			}
			set
			{
				iT_ASS_TQI_PARAService= value;
			}
		}
		#endregion

    
		#region 423 业务接口 IT_ASS_TQI_PARA2Service
		IT_ASS_TQI_PARA2Service iT_ASS_TQI_PARA2Service;
		public IT_ASS_TQI_PARA2Service IT_ASS_TQI_PARA2Service
		{
			get
			{
				if(iT_ASS_TQI_PARA2Service==null)
					iT_ASS_TQI_PARA2Service= new T_ASS_TQI_PARA2Service();
				return iT_ASS_TQI_PARA2Service;
			}
			set
			{
				iT_ASS_TQI_PARA2Service= value;
			}
		}
		#endregion

    
		#region 424 业务接口 IT_ASS_TRACKService
		IT_ASS_TRACKService iT_ASS_TRACKService;
		public IT_ASS_TRACKService IT_ASS_TRACKService
		{
			get
			{
				if(iT_ASS_TRACKService==null)
					iT_ASS_TRACKService= new T_ASS_TRACKService();
				return iT_ASS_TRACKService;
			}
			set
			{
				iT_ASS_TRACKService= value;
			}
		}
		#endregion

    
		#region 425 业务接口 IT_ASS_TRACK_VALService
		IT_ASS_TRACK_VALService iT_ASS_TRACK_VALService;
		public IT_ASS_TRACK_VALService IT_ASS_TRACK_VALService
		{
			get
			{
				if(iT_ASS_TRACK_VALService==null)
					iT_ASS_TRACK_VALService= new T_ASS_TRACK_VALService();
				return iT_ASS_TRACK_VALService;
			}
			set
			{
				iT_ASS_TRACK_VALService= value;
			}
		}
		#endregion

    
		#region 426 业务接口 IT_ASS_TRACK_VAL_DETAILService
		IT_ASS_TRACK_VAL_DETAILService iT_ASS_TRACK_VAL_DETAILService;
		public IT_ASS_TRACK_VAL_DETAILService IT_ASS_TRACK_VAL_DETAILService
		{
			get
			{
				if(iT_ASS_TRACK_VAL_DETAILService==null)
					iT_ASS_TRACK_VAL_DETAILService= new T_ASS_TRACK_VAL_DETAILService();
				return iT_ASS_TRACK_VAL_DETAILService;
			}
			set
			{
				iT_ASS_TRACK_VAL_DETAILService= value;
			}
		}
		#endregion

    
		#region 427 业务接口 IT_ASS_TUNNELService
		IT_ASS_TUNNELService iT_ASS_TUNNELService;
		public IT_ASS_TUNNELService IT_ASS_TUNNELService
		{
			get
			{
				if(iT_ASS_TUNNELService==null)
					iT_ASS_TUNNELService= new T_ASS_TUNNELService();
				return iT_ASS_TUNNELService;
			}
			set
			{
				iT_ASS_TUNNELService= value;
			}
		}
		#endregion

    
		#region 428 业务接口 IT_ASS_TURNOUTService
		IT_ASS_TURNOUTService iT_ASS_TURNOUTService;
		public IT_ASS_TURNOUTService IT_ASS_TURNOUTService
		{
			get
			{
				if(iT_ASS_TURNOUTService==null)
					iT_ASS_TURNOUTService= new T_ASS_TURNOUTService();
				return iT_ASS_TURNOUTService;
			}
			set
			{
				iT_ASS_TURNOUTService= value;
			}
		}
		#endregion

    
		#region 429 业务接口 IT_ASS_TURNOUT_VALService
		IT_ASS_TURNOUT_VALService iT_ASS_TURNOUT_VALService;
		public IT_ASS_TURNOUT_VALService IT_ASS_TURNOUT_VALService
		{
			get
			{
				if(iT_ASS_TURNOUT_VALService==null)
					iT_ASS_TURNOUT_VALService= new T_ASS_TURNOUT_VALService();
				return iT_ASS_TURNOUT_VALService;
			}
			set
			{
				iT_ASS_TURNOUT_VALService= value;
			}
		}
		#endregion

    
		#region 430 业务接口 IT_ASS_TURNOUT_VAL_DETAILService
		IT_ASS_TURNOUT_VAL_DETAILService iT_ASS_TURNOUT_VAL_DETAILService;
		public IT_ASS_TURNOUT_VAL_DETAILService IT_ASS_TURNOUT_VAL_DETAILService
		{
			get
			{
				if(iT_ASS_TURNOUT_VAL_DETAILService==null)
					iT_ASS_TURNOUT_VAL_DETAILService= new T_ASS_TURNOUT_VAL_DETAILService();
				return iT_ASS_TURNOUT_VAL_DETAILService;
			}
			set
			{
				iT_ASS_TURNOUT_VAL_DETAILService= value;
			}
		}
		#endregion

    
		#region 431 业务接口 IT_ASS_UNITService
		IT_ASS_UNITService iT_ASS_UNITService;
		public IT_ASS_UNITService IT_ASS_UNITService
		{
			get
			{
				if(iT_ASS_UNITService==null)
					iT_ASS_UNITService= new T_ASS_UNITService();
				return iT_ASS_UNITService;
			}
			set
			{
				iT_ASS_UNITService= value;
			}
		}
		#endregion

    
		#region 432 业务接口 IT_ASS_UNIT_TQIService
		IT_ASS_UNIT_TQIService iT_ASS_UNIT_TQIService;
		public IT_ASS_UNIT_TQIService IT_ASS_UNIT_TQIService
		{
			get
			{
				if(iT_ASS_UNIT_TQIService==null)
					iT_ASS_UNIT_TQIService= new T_ASS_UNIT_TQIService();
				return iT_ASS_UNIT_TQIService;
			}
			set
			{
				iT_ASS_UNIT_TQIService= value;
			}
		}
		#endregion

    
		#region 433 业务接口 IT_ASS_UNIT_VALService
		IT_ASS_UNIT_VALService iT_ASS_UNIT_VALService;
		public IT_ASS_UNIT_VALService IT_ASS_UNIT_VALService
		{
			get
			{
				if(iT_ASS_UNIT_VALService==null)
					iT_ASS_UNIT_VALService= new T_ASS_UNIT_VALService();
				return iT_ASS_UNIT_VALService;
			}
			set
			{
				iT_ASS_UNIT_VALService= value;
			}
		}
		#endregion

    
		#region 434 业务接口 IT_ASS_UNIT_VAL_DETAILService
		IT_ASS_UNIT_VAL_DETAILService iT_ASS_UNIT_VAL_DETAILService;
		public IT_ASS_UNIT_VAL_DETAILService IT_ASS_UNIT_VAL_DETAILService
		{
			get
			{
				if(iT_ASS_UNIT_VAL_DETAILService==null)
					iT_ASS_UNIT_VAL_DETAILService= new T_ASS_UNIT_VAL_DETAILService();
				return iT_ASS_UNIT_VAL_DETAILService;
			}
			set
			{
				iT_ASS_UNIT_VAL_DETAILService= value;
			}
		}
		#endregion

    
		#region 435 业务接口 IT_ASS_UNIT625Service
		IT_ASS_UNIT625Service iT_ASS_UNIT625Service;
		public IT_ASS_UNIT625Service IT_ASS_UNIT625Service
		{
			get
			{
				if(iT_ASS_UNIT625Service==null)
					iT_ASS_UNIT625Service= new T_ASS_UNIT625Service();
				return iT_ASS_UNIT625Service;
			}
			set
			{
				iT_ASS_UNIT625Service= value;
			}
		}
		#endregion

    
		#region 436 业务接口 IT_ASS_UNIT625_VALService
		IT_ASS_UNIT625_VALService iT_ASS_UNIT625_VALService;
		public IT_ASS_UNIT625_VALService IT_ASS_UNIT625_VALService
		{
			get
			{
				if(iT_ASS_UNIT625_VALService==null)
					iT_ASS_UNIT625_VALService= new T_ASS_UNIT625_VALService();
				return iT_ASS_UNIT625_VALService;
			}
			set
			{
				iT_ASS_UNIT625_VALService= value;
			}
		}
		#endregion

    
		#region 437 业务接口 IT_ASS_UNIT625_VAL_DETAILService
		IT_ASS_UNIT625_VAL_DETAILService iT_ASS_UNIT625_VAL_DETAILService;
		public IT_ASS_UNIT625_VAL_DETAILService IT_ASS_UNIT625_VAL_DETAILService
		{
			get
			{
				if(iT_ASS_UNIT625_VAL_DETAILService==null)
					iT_ASS_UNIT625_VAL_DETAILService= new T_ASS_UNIT625_VAL_DETAILService();
				return iT_ASS_UNIT625_VAL_DETAILService;
			}
			set
			{
				iT_ASS_UNIT625_VAL_DETAILService= value;
			}
		}
		#endregion

    
		#region 438 业务接口 IT_BOOTRECINFOService
		IT_BOOTRECINFOService iT_BOOTRECINFOService;
		public IT_BOOTRECINFOService IT_BOOTRECINFOService
		{
			get
			{
				if(iT_BOOTRECINFOService==null)
					iT_BOOTRECINFOService= new T_BOOTRECINFOService();
				return iT_BOOTRECINFOService;
			}
			set
			{
				iT_BOOTRECINFOService= value;
			}
		}
		#endregion

    
		#region 439 业务接口 IT_CARLASTOBDService
		IT_CARLASTOBDService iT_CARLASTOBDService;
		public IT_CARLASTOBDService IT_CARLASTOBDService
		{
			get
			{
				if(iT_CARLASTOBDService==null)
					iT_CARLASTOBDService= new T_CARLASTOBDService();
				return iT_CARLASTOBDService;
			}
			set
			{
				iT_CARLASTOBDService= value;
			}
		}
		#endregion

    
		#region 440 业务接口 IT_CAROBDService
		IT_CAROBDService iT_CAROBDService;
		public IT_CAROBDService IT_CAROBDService
		{
			get
			{
				if(iT_CAROBDService==null)
					iT_CAROBDService= new T_CAROBDService();
				return iT_CAROBDService;
			}
			set
			{
				iT_CAROBDService= value;
			}
		}
		#endregion

    
		#region 441 业务接口 IT_CHK_CURVEService
		IT_CHK_CURVEService iT_CHK_CURVEService;
		public IT_CHK_CURVEService IT_CHK_CURVEService
		{
			get
			{
				if(iT_CHK_CURVEService==null)
					iT_CHK_CURVEService= new T_CHK_CURVEService();
				return iT_CHK_CURVEService;
			}
			set
			{
				iT_CHK_CURVEService= value;
			}
		}
		#endregion

    
		#region 442 业务接口 IT_CHK_CURVE_ITEMSService
		IT_CHK_CURVE_ITEMSService iT_CHK_CURVE_ITEMSService;
		public IT_CHK_CURVE_ITEMSService IT_CHK_CURVE_ITEMSService
		{
			get
			{
				if(iT_CHK_CURVE_ITEMSService==null)
					iT_CHK_CURVE_ITEMSService= new T_CHK_CURVE_ITEMSService();
				return iT_CHK_CURVE_ITEMSService;
			}
			set
			{
				iT_CHK_CURVE_ITEMSService= value;
			}
		}
		#endregion

    
		#region 443 业务接口 IT_CHK_DICService
		IT_CHK_DICService iT_CHK_DICService;
		public IT_CHK_DICService IT_CHK_DICService
		{
			get
			{
				if(iT_CHK_DICService==null)
					iT_CHK_DICService= new T_CHK_DICService();
				return iT_CHK_DICService;
			}
			set
			{
				iT_CHK_DICService= value;
			}
		}
		#endregion

    
		#region 444 业务接口 IT_CHK_DISEASE_ITEMSService
		IT_CHK_DISEASE_ITEMSService iT_CHK_DISEASE_ITEMSService;
		public IT_CHK_DISEASE_ITEMSService IT_CHK_DISEASE_ITEMSService
		{
			get
			{
				if(iT_CHK_DISEASE_ITEMSService==null)
					iT_CHK_DISEASE_ITEMSService= new T_CHK_DISEASE_ITEMSService();
				return iT_CHK_DISEASE_ITEMSService;
			}
			set
			{
				iT_CHK_DISEASE_ITEMSService= value;
			}
		}
		#endregion

    
		#region 445 业务接口 IT_CHK_DISEASE_STANDARDService
		IT_CHK_DISEASE_STANDARDService iT_CHK_DISEASE_STANDARDService;
		public IT_CHK_DISEASE_STANDARDService IT_CHK_DISEASE_STANDARDService
		{
			get
			{
				if(iT_CHK_DISEASE_STANDARDService==null)
					iT_CHK_DISEASE_STANDARDService= new T_CHK_DISEASE_STANDARDService();
				return iT_CHK_DISEASE_STANDARDService;
			}
			set
			{
				iT_CHK_DISEASE_STANDARDService= value;
			}
		}
		#endregion

    
		#region 446 业务接口 IT_CHK_LINEService
		IT_CHK_LINEService iT_CHK_LINEService;
		public IT_CHK_LINEService IT_CHK_LINEService
		{
			get
			{
				if(iT_CHK_LINEService==null)
					iT_CHK_LINEService= new T_CHK_LINEService();
				return iT_CHK_LINEService;
			}
			set
			{
				iT_CHK_LINEService= value;
			}
		}
		#endregion

    
		#region 447 业务接口 IT_CHK_LINE_ITEMSService
		IT_CHK_LINE_ITEMSService iT_CHK_LINE_ITEMSService;
		public IT_CHK_LINE_ITEMSService IT_CHK_LINE_ITEMSService
		{
			get
			{
				if(iT_CHK_LINE_ITEMSService==null)
					iT_CHK_LINE_ITEMSService= new T_CHK_LINE_ITEMSService();
				return iT_CHK_LINE_ITEMSService;
			}
			set
			{
				iT_CHK_LINE_ITEMSService= value;
			}
		}
		#endregion

    
		#region 448 业务接口 IT_CHK_MEDIA_ITEMSService
		IT_CHK_MEDIA_ITEMSService iT_CHK_MEDIA_ITEMSService;
		public IT_CHK_MEDIA_ITEMSService IT_CHK_MEDIA_ITEMSService
		{
			get
			{
				if(iT_CHK_MEDIA_ITEMSService==null)
					iT_CHK_MEDIA_ITEMSService= new T_CHK_MEDIA_ITEMSService();
				return iT_CHK_MEDIA_ITEMSService;
			}
			set
			{
				iT_CHK_MEDIA_ITEMSService= value;
			}
		}
		#endregion

    
		#region 449 业务接口 IT_CHK_TURNOUTService
		IT_CHK_TURNOUTService iT_CHK_TURNOUTService;
		public IT_CHK_TURNOUTService IT_CHK_TURNOUTService
		{
			get
			{
				if(iT_CHK_TURNOUTService==null)
					iT_CHK_TURNOUTService= new T_CHK_TURNOUTService();
				return iT_CHK_TURNOUTService;
			}
			set
			{
				iT_CHK_TURNOUTService= value;
			}
		}
		#endregion

    
		#region 450 业务接口 IT_CHK_TURNOUT_DIAMOND_ITEMSService
		IT_CHK_TURNOUT_DIAMOND_ITEMSService iT_CHK_TURNOUT_DIAMOND_ITEMSService;
		public IT_CHK_TURNOUT_DIAMOND_ITEMSService IT_CHK_TURNOUT_DIAMOND_ITEMSService
		{
			get
			{
				if(iT_CHK_TURNOUT_DIAMOND_ITEMSService==null)
					iT_CHK_TURNOUT_DIAMOND_ITEMSService= new T_CHK_TURNOUT_DIAMOND_ITEMSService();
				return iT_CHK_TURNOUT_DIAMOND_ITEMSService;
			}
			set
			{
				iT_CHK_TURNOUT_DIAMOND_ITEMSService= value;
			}
		}
		#endregion

    
		#region 451 业务接口 IT_CHK_TURNOUT_DOUBLE_ITEMSService
		IT_CHK_TURNOUT_DOUBLE_ITEMSService iT_CHK_TURNOUT_DOUBLE_ITEMSService;
		public IT_CHK_TURNOUT_DOUBLE_ITEMSService IT_CHK_TURNOUT_DOUBLE_ITEMSService
		{
			get
			{
				if(iT_CHK_TURNOUT_DOUBLE_ITEMSService==null)
					iT_CHK_TURNOUT_DOUBLE_ITEMSService= new T_CHK_TURNOUT_DOUBLE_ITEMSService();
				return iT_CHK_TURNOUT_DOUBLE_ITEMSService;
			}
			set
			{
				iT_CHK_TURNOUT_DOUBLE_ITEMSService= value;
			}
		}
		#endregion

    
		#region 452 业务接口 IT_CHK_TURNOUT_ITEMSService
		IT_CHK_TURNOUT_ITEMSService iT_CHK_TURNOUT_ITEMSService;
		public IT_CHK_TURNOUT_ITEMSService IT_CHK_TURNOUT_ITEMSService
		{
			get
			{
				if(iT_CHK_TURNOUT_ITEMSService==null)
					iT_CHK_TURNOUT_ITEMSService= new T_CHK_TURNOUT_ITEMSService();
				return iT_CHK_TURNOUT_ITEMSService;
			}
			set
			{
				iT_CHK_TURNOUT_ITEMSService= value;
			}
		}
		#endregion

    
		#region 453 业务接口 IT_CHK_TURNOUT_MOVPOINT_ITEMSService
		IT_CHK_TURNOUT_MOVPOINT_ITEMSService iT_CHK_TURNOUT_MOVPOINT_ITEMSService;
		public IT_CHK_TURNOUT_MOVPOINT_ITEMSService IT_CHK_TURNOUT_MOVPOINT_ITEMSService
		{
			get
			{
				if(iT_CHK_TURNOUT_MOVPOINT_ITEMSService==null)
					iT_CHK_TURNOUT_MOVPOINT_ITEMSService= new T_CHK_TURNOUT_MOVPOINT_ITEMSService();
				return iT_CHK_TURNOUT_MOVPOINT_ITEMSService;
			}
			set
			{
				iT_CHK_TURNOUT_MOVPOINT_ITEMSService= value;
			}
		}
		#endregion

    
		#region 454 业务接口 IT_CHK_TURNOUT_SLIP_ITEMSService
		IT_CHK_TURNOUT_SLIP_ITEMSService iT_CHK_TURNOUT_SLIP_ITEMSService;
		public IT_CHK_TURNOUT_SLIP_ITEMSService IT_CHK_TURNOUT_SLIP_ITEMSService
		{
			get
			{
				if(iT_CHK_TURNOUT_SLIP_ITEMSService==null)
					iT_CHK_TURNOUT_SLIP_ITEMSService= new T_CHK_TURNOUT_SLIP_ITEMSService();
				return iT_CHK_TURNOUT_SLIP_ITEMSService;
			}
			set
			{
				iT_CHK_TURNOUT_SLIP_ITEMSService= value;
			}
		}
		#endregion

    
		#region 455 业务接口 IT_CHK_VISCHECK_ITEMSService
		IT_CHK_VISCHECK_ITEMSService iT_CHK_VISCHECK_ITEMSService;
		public IT_CHK_VISCHECK_ITEMSService IT_CHK_VISCHECK_ITEMSService
		{
			get
			{
				if(iT_CHK_VISCHECK_ITEMSService==null)
					iT_CHK_VISCHECK_ITEMSService= new T_CHK_VISCHECK_ITEMSService();
				return iT_CHK_VISCHECK_ITEMSService;
			}
			set
			{
				iT_CHK_VISCHECK_ITEMSService= value;
			}
		}
		#endregion

    
		#region 456 业务接口 IT_CHK_VISUAL_ITEMSService
		IT_CHK_VISUAL_ITEMSService iT_CHK_VISUAL_ITEMSService;
		public IT_CHK_VISUAL_ITEMSService IT_CHK_VISUAL_ITEMSService
		{
			get
			{
				if(iT_CHK_VISUAL_ITEMSService==null)
					iT_CHK_VISUAL_ITEMSService= new T_CHK_VISUAL_ITEMSService();
				return iT_CHK_VISUAL_ITEMSService;
			}
			set
			{
				iT_CHK_VISUAL_ITEMSService= value;
			}
		}
		#endregion

    
		#region 457 业务接口 IT_CHK_WIDENING_VALUEService
		IT_CHK_WIDENING_VALUEService iT_CHK_WIDENING_VALUEService;
		public IT_CHK_WIDENING_VALUEService IT_CHK_WIDENING_VALUEService
		{
			get
			{
				if(iT_CHK_WIDENING_VALUEService==null)
					iT_CHK_WIDENING_VALUEService= new T_CHK_WIDENING_VALUEService();
				return iT_CHK_WIDENING_VALUEService;
			}
			set
			{
				iT_CHK_WIDENING_VALUEService= value;
			}
		}
		#endregion

    
		#region 458 业务接口 IT_CHKPOSService
		IT_CHKPOSService iT_CHKPOSService;
		public IT_CHKPOSService IT_CHKPOSService
		{
			get
			{
				if(iT_CHKPOSService==null)
					iT_CHKPOSService= new T_CHKPOSService();
				return iT_CHKPOSService;
			}
			set
			{
				iT_CHKPOSService= value;
			}
		}
		#endregion

    
		#region 459 业务接口 IT_CUSTOM_STATIONService
		IT_CUSTOM_STATIONService iT_CUSTOM_STATIONService;
		public IT_CUSTOM_STATIONService IT_CUSTOM_STATIONService
		{
			get
			{
				if(iT_CUSTOM_STATIONService==null)
					iT_CUSTOM_STATIONService= new T_CUSTOM_STATIONService();
				return iT_CUSTOM_STATIONService;
			}
			set
			{
				iT_CUSTOM_STATIONService= value;
			}
		}
		#endregion

    
		#region 460 业务接口 IT_CZ_CCService
		IT_CZ_CCService iT_CZ_CCService;
		public IT_CZ_CCService IT_CZ_CCService
		{
			get
			{
				if(iT_CZ_CCService==null)
					iT_CZ_CCService= new T_CZ_CCService();
				return iT_CZ_CCService;
			}
			set
			{
				iT_CZ_CCService= value;
			}
		}
		#endregion

    
		#region 461 业务接口 IT_CZ_FREQ_TEMPService
		IT_CZ_FREQ_TEMPService iT_CZ_FREQ_TEMPService;
		public IT_CZ_FREQ_TEMPService IT_CZ_FREQ_TEMPService
		{
			get
			{
				if(iT_CZ_FREQ_TEMPService==null)
					iT_CZ_FREQ_TEMPService= new T_CZ_FREQ_TEMPService();
				return iT_CZ_FREQ_TEMPService;
			}
			set
			{
				iT_CZ_FREQ_TEMPService= value;
			}
		}
		#endregion

    
		#region 462 业务接口 IT_CZ_GJService
		IT_CZ_GJService iT_CZ_GJService;
		public IT_CZ_GJService IT_CZ_GJService
		{
			get
			{
				if(iT_CZ_GJService==null)
					iT_CZ_GJService= new T_CZ_GJService();
				return iT_CZ_GJService;
			}
			set
			{
				iT_CZ_GJService= value;
			}
		}
		#endregion

    
		#region 463 业务接口 IT_CZ_JCHService
		IT_CZ_JCHService iT_CZ_JCHService;
		public IT_CZ_JCHService IT_CZ_JCHService
		{
			get
			{
				if(iT_CZ_JCHService==null)
					iT_CZ_JCHService= new T_CZ_JCHService();
				return iT_CZ_JCHService;
			}
			set
			{
				iT_CZ_JCHService= value;
			}
		}
		#endregion

    
		#region 464 业务接口 IT_CZ_NLINENOService
		IT_CZ_NLINENOService iT_CZ_NLINENOService;
		public IT_CZ_NLINENOService IT_CZ_NLINENOService
		{
			get
			{
				if(iT_CZ_NLINENOService==null)
					iT_CZ_NLINENOService= new T_CZ_NLINENOService();
				return iT_CZ_NLINENOService;
			}
			set
			{
				iT_CZ_NLINENOService= value;
			}
		}
		#endregion

    
		#region 465 业务接口 IT_CZ_PHONEService
		IT_CZ_PHONEService iT_CZ_PHONEService;
		public IT_CZ_PHONEService IT_CZ_PHONEService
		{
			get
			{
				if(iT_CZ_PHONEService==null)
					iT_CZ_PHONEService= new T_CZ_PHONEService();
				return iT_CZ_PHONEService;
			}
			set
			{
				iT_CZ_PHONEService= value;
			}
		}
		#endregion

    
		#region 466 业务接口 IT_CZ_TBLService
		IT_CZ_TBLService iT_CZ_TBLService;
		public IT_CZ_TBLService IT_CZ_TBLService
		{
			get
			{
				if(iT_CZ_TBLService==null)
					iT_CZ_TBLService= new T_CZ_TBLService();
				return iT_CZ_TBLService;
			}
			set
			{
				iT_CZ_TBLService= value;
			}
		}
		#endregion

    
		#region 467 业务接口 IT_CZ_TDWID_TEMPService
		IT_CZ_TDWID_TEMPService iT_CZ_TDWID_TEMPService;
		public IT_CZ_TDWID_TEMPService IT_CZ_TDWID_TEMPService
		{
			get
			{
				if(iT_CZ_TDWID_TEMPService==null)
					iT_CZ_TDWID_TEMPService= new T_CZ_TDWID_TEMPService();
				return iT_CZ_TDWID_TEMPService;
			}
			set
			{
				iT_CZ_TDWID_TEMPService= value;
			}
		}
		#endregion

    
		#region 468 业务接口 IT_CZ_TJ_TEMPService
		IT_CZ_TJ_TEMPService iT_CZ_TJ_TEMPService;
		public IT_CZ_TJ_TEMPService IT_CZ_TJ_TEMPService
		{
			get
			{
				if(iT_CZ_TJ_TEMPService==null)
					iT_CZ_TJ_TEMPService= new T_CZ_TJ_TEMPService();
				return iT_CZ_TJ_TEMPService;
			}
			set
			{
				iT_CZ_TJ_TEMPService= value;
			}
		}
		#endregion

    
		#region 469 业务接口 IT_CZ_WARPService
		IT_CZ_WARPService iT_CZ_WARPService;
		public IT_CZ_WARPService IT_CZ_WARPService
		{
			get
			{
				if(iT_CZ_WARPService==null)
					iT_CZ_WARPService= new T_CZ_WARPService();
				return iT_CZ_WARPService;
			}
			set
			{
				iT_CZ_WARPService= value;
			}
		}
		#endregion

    
		#region 470 业务接口 IT_CZ_WARP_TEMPService
		IT_CZ_WARP_TEMPService iT_CZ_WARP_TEMPService;
		public IT_CZ_WARP_TEMPService IT_CZ_WARP_TEMPService
		{
			get
			{
				if(iT_CZ_WARP_TEMPService==null)
					iT_CZ_WARP_TEMPService= new T_CZ_WARP_TEMPService();
				return iT_CZ_WARP_TEMPService;
			}
			set
			{
				iT_CZ_WARP_TEMPService= value;
			}
		}
		#endregion

    
		#region 471 业务接口 IT_GIS_LINEService
		IT_GIS_LINEService iT_GIS_LINEService;
		public IT_GIS_LINEService IT_GIS_LINEService
		{
			get
			{
				if(iT_GIS_LINEService==null)
					iT_GIS_LINEService= new T_GIS_LINEService();
				return iT_GIS_LINEService;
			}
			set
			{
				iT_GIS_LINEService= value;
			}
		}
		#endregion

    
		#region 472 业务接口 IT_GIS_LINE_TESTService
		IT_GIS_LINE_TESTService iT_GIS_LINE_TESTService;
		public IT_GIS_LINE_TESTService IT_GIS_LINE_TESTService
		{
			get
			{
				if(iT_GIS_LINE_TESTService==null)
					iT_GIS_LINE_TESTService= new T_GIS_LINE_TESTService();
				return iT_GIS_LINE_TESTService;
			}
			set
			{
				iT_GIS_LINE_TESTService= value;
			}
		}
		#endregion

    
		#region 473 业务接口 IT_GIS_LINE_TEST_NOPWDService
		IT_GIS_LINE_TEST_NOPWDService iT_GIS_LINE_TEST_NOPWDService;
		public IT_GIS_LINE_TEST_NOPWDService IT_GIS_LINE_TEST_NOPWDService
		{
			get
			{
				if(iT_GIS_LINE_TEST_NOPWDService==null)
					iT_GIS_LINE_TEST_NOPWDService= new T_GIS_LINE_TEST_NOPWDService();
				return iT_GIS_LINE_TEST_NOPWDService;
			}
			set
			{
				iT_GIS_LINE_TEST_NOPWDService= value;
			}
		}
		#endregion

    
		#region 474 业务接口 IT_GIS_STATIONService
		IT_GIS_STATIONService iT_GIS_STATIONService;
		public IT_GIS_STATIONService IT_GIS_STATIONService
		{
			get
			{
				if(iT_GIS_STATIONService==null)
					iT_GIS_STATIONService= new T_GIS_STATIONService();
				return iT_GIS_STATIONService;
			}
			set
			{
				iT_GIS_STATIONService= value;
			}
		}
		#endregion

    
		#region 475 业务接口 IT_GIS_STATION_TESTService
		IT_GIS_STATION_TESTService iT_GIS_STATION_TESTService;
		public IT_GIS_STATION_TESTService IT_GIS_STATION_TESTService
		{
			get
			{
				if(iT_GIS_STATION_TESTService==null)
					iT_GIS_STATION_TESTService= new T_GIS_STATION_TESTService();
				return iT_GIS_STATION_TESTService;
			}
			set
			{
				iT_GIS_STATION_TESTService= value;
			}
		}
		#endregion

    
		#region 476 业务接口 IT_GWBASEService
		IT_GWBASEService iT_GWBASEService;
		public IT_GWBASEService IT_GWBASEService
		{
			get
			{
				if(iT_GWBASEService==null)
					iT_GWBASEService= new T_GWBASEService();
				return iT_GWBASEService;
			}
			set
			{
				iT_GWBASEService= value;
			}
		}
		#endregion

    
		#region 477 业务接口 IT_GWBASE_SECTION_LINEService
		IT_GWBASE_SECTION_LINEService iT_GWBASE_SECTION_LINEService;
		public IT_GWBASE_SECTION_LINEService IT_GWBASE_SECTION_LINEService
		{
			get
			{
				if(iT_GWBASE_SECTION_LINEService==null)
					iT_GWBASE_SECTION_LINEService= new T_GWBASE_SECTION_LINEService();
				return iT_GWBASE_SECTION_LINEService;
			}
			set
			{
				iT_GWBASE_SECTION_LINEService= value;
			}
		}
		#endregion

    
		#region 478 业务接口 IT_GWBASE_TESTService
		IT_GWBASE_TESTService iT_GWBASE_TESTService;
		public IT_GWBASE_TESTService IT_GWBASE_TESTService
		{
			get
			{
				if(iT_GWBASE_TESTService==null)
					iT_GWBASE_TESTService= new T_GWBASE_TESTService();
				return iT_GWBASE_TESTService;
			}
			set
			{
				iT_GWBASE_TESTService= value;
			}
		}
		#endregion

    
		#region 479 业务接口 IT_GWDETAILService
		IT_GWDETAILService iT_GWDETAILService;
		public IT_GWDETAILService IT_GWDETAILService
		{
			get
			{
				if(iT_GWDETAILService==null)
					iT_GWDETAILService= new T_GWDETAILService();
				return iT_GWDETAILService;
			}
			set
			{
				iT_GWDETAILService= value;
			}
		}
		#endregion

    
		#region 480 业务接口 IT_GWTRANSETService
		IT_GWTRANSETService iT_GWTRANSETService;
		public IT_GWTRANSETService IT_GWTRANSETService
		{
			get
			{
				if(iT_GWTRANSETService==null)
					iT_GWTRANSETService= new T_GWTRANSETService();
				return iT_GWTRANSETService;
			}
			set
			{
				iT_GWTRANSETService= value;
			}
		}
		#endregion

    
		#region 481 业务接口 IT_JOB_LINEService
		IT_JOB_LINEService iT_JOB_LINEService;
		public IT_JOB_LINEService IT_JOB_LINEService
		{
			get
			{
				if(iT_JOB_LINEService==null)
					iT_JOB_LINEService= new T_JOB_LINEService();
				return iT_JOB_LINEService;
			}
			set
			{
				iT_JOB_LINEService= value;
			}
		}
		#endregion

    
		#region 482 业务接口 IT_LKJ_FLOW_ATTACHService
		IT_LKJ_FLOW_ATTACHService iT_LKJ_FLOW_ATTACHService;
		public IT_LKJ_FLOW_ATTACHService IT_LKJ_FLOW_ATTACHService
		{
			get
			{
				if(iT_LKJ_FLOW_ATTACHService==null)
					iT_LKJ_FLOW_ATTACHService= new T_LKJ_FLOW_ATTACHService();
				return iT_LKJ_FLOW_ATTACHService;
			}
			set
			{
				iT_LKJ_FLOW_ATTACHService= value;
			}
		}
		#endregion

    
		#region 483 业务接口 IT_LKJ_FLOW_DOCService
		IT_LKJ_FLOW_DOCService iT_LKJ_FLOW_DOCService;
		public IT_LKJ_FLOW_DOCService IT_LKJ_FLOW_DOCService
		{
			get
			{
				if(iT_LKJ_FLOW_DOCService==null)
					iT_LKJ_FLOW_DOCService= new T_LKJ_FLOW_DOCService();
				return iT_LKJ_FLOW_DOCService;
			}
			set
			{
				iT_LKJ_FLOW_DOCService= value;
			}
		}
		#endregion

    
		#region 484 业务接口 IT_LKJ_FLOW_FEEDBACKService
		IT_LKJ_FLOW_FEEDBACKService iT_LKJ_FLOW_FEEDBACKService;
		public IT_LKJ_FLOW_FEEDBACKService IT_LKJ_FLOW_FEEDBACKService
		{
			get
			{
				if(iT_LKJ_FLOW_FEEDBACKService==null)
					iT_LKJ_FLOW_FEEDBACKService= new T_LKJ_FLOW_FEEDBACKService();
				return iT_LKJ_FLOW_FEEDBACKService;
			}
			set
			{
				iT_LKJ_FLOW_FEEDBACKService= value;
			}
		}
		#endregion

    
		#region 485 业务接口 IT_LKJ_FLOW_INFOService
		IT_LKJ_FLOW_INFOService iT_LKJ_FLOW_INFOService;
		public IT_LKJ_FLOW_INFOService IT_LKJ_FLOW_INFOService
		{
			get
			{
				if(iT_LKJ_FLOW_INFOService==null)
					iT_LKJ_FLOW_INFOService= new T_LKJ_FLOW_INFOService();
				return iT_LKJ_FLOW_INFOService;
			}
			set
			{
				iT_LKJ_FLOW_INFOService= value;
			}
		}
		#endregion

    
		#region 486 业务接口 IT_LKJ_FLOW_MESSAGEService
		IT_LKJ_FLOW_MESSAGEService iT_LKJ_FLOW_MESSAGEService;
		public IT_LKJ_FLOW_MESSAGEService IT_LKJ_FLOW_MESSAGEService
		{
			get
			{
				if(iT_LKJ_FLOW_MESSAGEService==null)
					iT_LKJ_FLOW_MESSAGEService= new T_LKJ_FLOW_MESSAGEService();
				return iT_LKJ_FLOW_MESSAGEService;
			}
			set
			{
				iT_LKJ_FLOW_MESSAGEService= value;
			}
		}
		#endregion

    
		#region 487 业务接口 IT_LKJ_FLOW_REFERENCEService
		IT_LKJ_FLOW_REFERENCEService iT_LKJ_FLOW_REFERENCEService;
		public IT_LKJ_FLOW_REFERENCEService IT_LKJ_FLOW_REFERENCEService
		{
			get
			{
				if(iT_LKJ_FLOW_REFERENCEService==null)
					iT_LKJ_FLOW_REFERENCEService= new T_LKJ_FLOW_REFERENCEService();
				return iT_LKJ_FLOW_REFERENCEService;
			}
			set
			{
				iT_LKJ_FLOW_REFERENCEService= value;
			}
		}
		#endregion

    
		#region 488 业务接口 IT_LKJ_FLOW_ROLEService
		IT_LKJ_FLOW_ROLEService iT_LKJ_FLOW_ROLEService;
		public IT_LKJ_FLOW_ROLEService IT_LKJ_FLOW_ROLEService
		{
			get
			{
				if(iT_LKJ_FLOW_ROLEService==null)
					iT_LKJ_FLOW_ROLEService= new T_LKJ_FLOW_ROLEService();
				return iT_LKJ_FLOW_ROLEService;
			}
			set
			{
				iT_LKJ_FLOW_ROLEService= value;
			}
		}
		#endregion

    
		#region 489 业务接口 IT_LKJ_FLOW_STEPINFOService
		IT_LKJ_FLOW_STEPINFOService iT_LKJ_FLOW_STEPINFOService;
		public IT_LKJ_FLOW_STEPINFOService IT_LKJ_FLOW_STEPINFOService
		{
			get
			{
				if(iT_LKJ_FLOW_STEPINFOService==null)
					iT_LKJ_FLOW_STEPINFOService= new T_LKJ_FLOW_STEPINFOService();
				return iT_LKJ_FLOW_STEPINFOService;
			}
			set
			{
				iT_LKJ_FLOW_STEPINFOService= value;
			}
		}
		#endregion

    
		#region 490 业务接口 IT_LKJ_FLOW_USERROLEService
		IT_LKJ_FLOW_USERROLEService iT_LKJ_FLOW_USERROLEService;
		public IT_LKJ_FLOW_USERROLEService IT_LKJ_FLOW_USERROLEService
		{
			get
			{
				if(iT_LKJ_FLOW_USERROLEService==null)
					iT_LKJ_FLOW_USERROLEService= new T_LKJ_FLOW_USERROLEService();
				return iT_LKJ_FLOW_USERROLEService;
			}
			set
			{
				iT_LKJ_FLOW_USERROLEService= value;
			}
		}
		#endregion

    
		#region 491 业务接口 IT_LKJ_LINESTATIONService
		IT_LKJ_LINESTATIONService iT_LKJ_LINESTATIONService;
		public IT_LKJ_LINESTATIONService IT_LKJ_LINESTATIONService
		{
			get
			{
				if(iT_LKJ_LINESTATIONService==null)
					iT_LKJ_LINESTATIONService= new T_LKJ_LINESTATIONService();
				return iT_LKJ_LINESTATIONService;
			}
			set
			{
				iT_LKJ_LINESTATIONService= value;
			}
		}
		#endregion

    
		#region 492 业务接口 IT_LKJ_ROLEFLOWService
		IT_LKJ_ROLEFLOWService iT_LKJ_ROLEFLOWService;
		public IT_LKJ_ROLEFLOWService IT_LKJ_ROLEFLOWService
		{
			get
			{
				if(iT_LKJ_ROLEFLOWService==null)
					iT_LKJ_ROLEFLOWService= new T_LKJ_ROLEFLOWService();
				return iT_LKJ_ROLEFLOWService;
			}
			set
			{
				iT_LKJ_ROLEFLOWService= value;
			}
		}
		#endregion

    
		#region 493 业务接口 IT_LKJ_S1Service
		IT_LKJ_S1Service iT_LKJ_S1Service;
		public IT_LKJ_S1Service IT_LKJ_S1Service
		{
			get
			{
				if(iT_LKJ_S1Service==null)
					iT_LKJ_S1Service= new T_LKJ_S1Service();
				return iT_LKJ_S1Service;
			}
			set
			{
				iT_LKJ_S1Service= value;
			}
		}
		#endregion

    
		#region 494 业务接口 IT_LKJ_S1_HISService
		IT_LKJ_S1_HISService iT_LKJ_S1_HISService;
		public IT_LKJ_S1_HISService IT_LKJ_S1_HISService
		{
			get
			{
				if(iT_LKJ_S1_HISService==null)
					iT_LKJ_S1_HISService= new T_LKJ_S1_HISService();
				return iT_LKJ_S1_HISService;
			}
			set
			{
				iT_LKJ_S1_HISService= value;
			}
		}
		#endregion

    
		#region 495 业务接口 IT_LKJ_S10Service
		IT_LKJ_S10Service iT_LKJ_S10Service;
		public IT_LKJ_S10Service IT_LKJ_S10Service
		{
			get
			{
				if(iT_LKJ_S10Service==null)
					iT_LKJ_S10Service= new T_LKJ_S10Service();
				return iT_LKJ_S10Service;
			}
			set
			{
				iT_LKJ_S10Service= value;
			}
		}
		#endregion

    
		#region 496 业务接口 IT_LKJ_S10_HISService
		IT_LKJ_S10_HISService iT_LKJ_S10_HISService;
		public IT_LKJ_S10_HISService IT_LKJ_S10_HISService
		{
			get
			{
				if(iT_LKJ_S10_HISService==null)
					iT_LKJ_S10_HISService= new T_LKJ_S10_HISService();
				return iT_LKJ_S10_HISService;
			}
			set
			{
				iT_LKJ_S10_HISService= value;
			}
		}
		#endregion

    
		#region 497 业务接口 IT_LKJ_S11Service
		IT_LKJ_S11Service iT_LKJ_S11Service;
		public IT_LKJ_S11Service IT_LKJ_S11Service
		{
			get
			{
				if(iT_LKJ_S11Service==null)
					iT_LKJ_S11Service= new T_LKJ_S11Service();
				return iT_LKJ_S11Service;
			}
			set
			{
				iT_LKJ_S11Service= value;
			}
		}
		#endregion

    
		#region 498 业务接口 IT_LKJ_S11_HISService
		IT_LKJ_S11_HISService iT_LKJ_S11_HISService;
		public IT_LKJ_S11_HISService IT_LKJ_S11_HISService
		{
			get
			{
				if(iT_LKJ_S11_HISService==null)
					iT_LKJ_S11_HISService= new T_LKJ_S11_HISService();
				return iT_LKJ_S11_HISService;
			}
			set
			{
				iT_LKJ_S11_HISService= value;
			}
		}
		#endregion

    
		#region 499 业务接口 IT_LKJ_S12Service
		IT_LKJ_S12Service iT_LKJ_S12Service;
		public IT_LKJ_S12Service IT_LKJ_S12Service
		{
			get
			{
				if(iT_LKJ_S12Service==null)
					iT_LKJ_S12Service= new T_LKJ_S12Service();
				return iT_LKJ_S12Service;
			}
			set
			{
				iT_LKJ_S12Service= value;
			}
		}
		#endregion

    
		#region 500 业务接口 IT_LKJ_S12_HISService
		IT_LKJ_S12_HISService iT_LKJ_S12_HISService;
		public IT_LKJ_S12_HISService IT_LKJ_S12_HISService
		{
			get
			{
				if(iT_LKJ_S12_HISService==null)
					iT_LKJ_S12_HISService= new T_LKJ_S12_HISService();
				return iT_LKJ_S12_HISService;
			}
			set
			{
				iT_LKJ_S12_HISService= value;
			}
		}
		#endregion

    
		#region 501 业务接口 IT_LKJ_S13Service
		IT_LKJ_S13Service iT_LKJ_S13Service;
		public IT_LKJ_S13Service IT_LKJ_S13Service
		{
			get
			{
				if(iT_LKJ_S13Service==null)
					iT_LKJ_S13Service= new T_LKJ_S13Service();
				return iT_LKJ_S13Service;
			}
			set
			{
				iT_LKJ_S13Service= value;
			}
		}
		#endregion

    
		#region 502 业务接口 IT_LKJ_S13_HISService
		IT_LKJ_S13_HISService iT_LKJ_S13_HISService;
		public IT_LKJ_S13_HISService IT_LKJ_S13_HISService
		{
			get
			{
				if(iT_LKJ_S13_HISService==null)
					iT_LKJ_S13_HISService= new T_LKJ_S13_HISService();
				return iT_LKJ_S13_HISService;
			}
			set
			{
				iT_LKJ_S13_HISService= value;
			}
		}
		#endregion

    
		#region 503 业务接口 IT_LKJ_S2Service
		IT_LKJ_S2Service iT_LKJ_S2Service;
		public IT_LKJ_S2Service IT_LKJ_S2Service
		{
			get
			{
				if(iT_LKJ_S2Service==null)
					iT_LKJ_S2Service= new T_LKJ_S2Service();
				return iT_LKJ_S2Service;
			}
			set
			{
				iT_LKJ_S2Service= value;
			}
		}
		#endregion

    
		#region 504 业务接口 IT_LKJ_S2_HISService
		IT_LKJ_S2_HISService iT_LKJ_S2_HISService;
		public IT_LKJ_S2_HISService IT_LKJ_S2_HISService
		{
			get
			{
				if(iT_LKJ_S2_HISService==null)
					iT_LKJ_S2_HISService= new T_LKJ_S2_HISService();
				return iT_LKJ_S2_HISService;
			}
			set
			{
				iT_LKJ_S2_HISService= value;
			}
		}
		#endregion

    
		#region 505 业务接口 IT_LKJ_S3Service
		IT_LKJ_S3Service iT_LKJ_S3Service;
		public IT_LKJ_S3Service IT_LKJ_S3Service
		{
			get
			{
				if(iT_LKJ_S3Service==null)
					iT_LKJ_S3Service= new T_LKJ_S3Service();
				return iT_LKJ_S3Service;
			}
			set
			{
				iT_LKJ_S3Service= value;
			}
		}
		#endregion

    
		#region 506 业务接口 IT_LKJ_S3_HISService
		IT_LKJ_S3_HISService iT_LKJ_S3_HISService;
		public IT_LKJ_S3_HISService IT_LKJ_S3_HISService
		{
			get
			{
				if(iT_LKJ_S3_HISService==null)
					iT_LKJ_S3_HISService= new T_LKJ_S3_HISService();
				return iT_LKJ_S3_HISService;
			}
			set
			{
				iT_LKJ_S3_HISService= value;
			}
		}
		#endregion

    
		#region 507 业务接口 IT_LKJ_S4Service
		IT_LKJ_S4Service iT_LKJ_S4Service;
		public IT_LKJ_S4Service IT_LKJ_S4Service
		{
			get
			{
				if(iT_LKJ_S4Service==null)
					iT_LKJ_S4Service= new T_LKJ_S4Service();
				return iT_LKJ_S4Service;
			}
			set
			{
				iT_LKJ_S4Service= value;
			}
		}
		#endregion

    
		#region 508 业务接口 IT_LKJ_S4_HISService
		IT_LKJ_S4_HISService iT_LKJ_S4_HISService;
		public IT_LKJ_S4_HISService IT_LKJ_S4_HISService
		{
			get
			{
				if(iT_LKJ_S4_HISService==null)
					iT_LKJ_S4_HISService= new T_LKJ_S4_HISService();
				return iT_LKJ_S4_HISService;
			}
			set
			{
				iT_LKJ_S4_HISService= value;
			}
		}
		#endregion

    
		#region 509 业务接口 IT_LKJ_S5Service
		IT_LKJ_S5Service iT_LKJ_S5Service;
		public IT_LKJ_S5Service IT_LKJ_S5Service
		{
			get
			{
				if(iT_LKJ_S5Service==null)
					iT_LKJ_S5Service= new T_LKJ_S5Service();
				return iT_LKJ_S5Service;
			}
			set
			{
				iT_LKJ_S5Service= value;
			}
		}
		#endregion

    
		#region 510 业务接口 IT_LKJ_S5_HISService
		IT_LKJ_S5_HISService iT_LKJ_S5_HISService;
		public IT_LKJ_S5_HISService IT_LKJ_S5_HISService
		{
			get
			{
				if(iT_LKJ_S5_HISService==null)
					iT_LKJ_S5_HISService= new T_LKJ_S5_HISService();
				return iT_LKJ_S5_HISService;
			}
			set
			{
				iT_LKJ_S5_HISService= value;
			}
		}
		#endregion

    
		#region 511 业务接口 IT_LKJ_S6Service
		IT_LKJ_S6Service iT_LKJ_S6Service;
		public IT_LKJ_S6Service IT_LKJ_S6Service
		{
			get
			{
				if(iT_LKJ_S6Service==null)
					iT_LKJ_S6Service= new T_LKJ_S6Service();
				return iT_LKJ_S6Service;
			}
			set
			{
				iT_LKJ_S6Service= value;
			}
		}
		#endregion

    
		#region 512 业务接口 IT_LKJ_S6_HISService
		IT_LKJ_S6_HISService iT_LKJ_S6_HISService;
		public IT_LKJ_S6_HISService IT_LKJ_S6_HISService
		{
			get
			{
				if(iT_LKJ_S6_HISService==null)
					iT_LKJ_S6_HISService= new T_LKJ_S6_HISService();
				return iT_LKJ_S6_HISService;
			}
			set
			{
				iT_LKJ_S6_HISService= value;
			}
		}
		#endregion

    
		#region 513 业务接口 IT_LKJ_S7Service
		IT_LKJ_S7Service iT_LKJ_S7Service;
		public IT_LKJ_S7Service IT_LKJ_S7Service
		{
			get
			{
				if(iT_LKJ_S7Service==null)
					iT_LKJ_S7Service= new T_LKJ_S7Service();
				return iT_LKJ_S7Service;
			}
			set
			{
				iT_LKJ_S7Service= value;
			}
		}
		#endregion

    
		#region 514 业务接口 IT_LKJ_S7_HISService
		IT_LKJ_S7_HISService iT_LKJ_S7_HISService;
		public IT_LKJ_S7_HISService IT_LKJ_S7_HISService
		{
			get
			{
				if(iT_LKJ_S7_HISService==null)
					iT_LKJ_S7_HISService= new T_LKJ_S7_HISService();
				return iT_LKJ_S7_HISService;
			}
			set
			{
				iT_LKJ_S7_HISService= value;
			}
		}
		#endregion

    
		#region 515 业务接口 IT_LKJ_S8Service
		IT_LKJ_S8Service iT_LKJ_S8Service;
		public IT_LKJ_S8Service IT_LKJ_S8Service
		{
			get
			{
				if(iT_LKJ_S8Service==null)
					iT_LKJ_S8Service= new T_LKJ_S8Service();
				return iT_LKJ_S8Service;
			}
			set
			{
				iT_LKJ_S8Service= value;
			}
		}
		#endregion

    
		#region 516 业务接口 IT_LKJ_S8_HISService
		IT_LKJ_S8_HISService iT_LKJ_S8_HISService;
		public IT_LKJ_S8_HISService IT_LKJ_S8_HISService
		{
			get
			{
				if(iT_LKJ_S8_HISService==null)
					iT_LKJ_S8_HISService= new T_LKJ_S8_HISService();
				return iT_LKJ_S8_HISService;
			}
			set
			{
				iT_LKJ_S8_HISService= value;
			}
		}
		#endregion

    
		#region 517 业务接口 IT_LKJ_S9Service
		IT_LKJ_S9Service iT_LKJ_S9Service;
		public IT_LKJ_S9Service IT_LKJ_S9Service
		{
			get
			{
				if(iT_LKJ_S9Service==null)
					iT_LKJ_S9Service= new T_LKJ_S9Service();
				return iT_LKJ_S9Service;
			}
			set
			{
				iT_LKJ_S9Service= value;
			}
		}
		#endregion

    
		#region 518 业务接口 IT_LKJ_S9_HISService
		IT_LKJ_S9_HISService iT_LKJ_S9_HISService;
		public IT_LKJ_S9_HISService IT_LKJ_S9_HISService
		{
			get
			{
				if(iT_LKJ_S9_HISService==null)
					iT_LKJ_S9_HISService= new T_LKJ_S9_HISService();
				return iT_LKJ_S9_HISService;
			}
			set
			{
				iT_LKJ_S9_HISService= value;
			}
		}
		#endregion

    
		#region 519 业务接口 IT_LKJ_ST1Service
		IT_LKJ_ST1Service iT_LKJ_ST1Service;
		public IT_LKJ_ST1Service IT_LKJ_ST1Service
		{
			get
			{
				if(iT_LKJ_ST1Service==null)
					iT_LKJ_ST1Service= new T_LKJ_ST1Service();
				return iT_LKJ_ST1Service;
			}
			set
			{
				iT_LKJ_ST1Service= value;
			}
		}
		#endregion

    
		#region 520 业务接口 IT_LKJ_ST1_HISService
		IT_LKJ_ST1_HISService iT_LKJ_ST1_HISService;
		public IT_LKJ_ST1_HISService IT_LKJ_ST1_HISService
		{
			get
			{
				if(iT_LKJ_ST1_HISService==null)
					iT_LKJ_ST1_HISService= new T_LKJ_ST1_HISService();
				return iT_LKJ_ST1_HISService;
			}
			set
			{
				iT_LKJ_ST1_HISService= value;
			}
		}
		#endregion

    
		#region 521 业务接口 IT_LKJ_STARELTIONService
		IT_LKJ_STARELTIONService iT_LKJ_STARELTIONService;
		public IT_LKJ_STARELTIONService IT_LKJ_STARELTIONService
		{
			get
			{
				if(iT_LKJ_STARELTIONService==null)
					iT_LKJ_STARELTIONService= new T_LKJ_STARELTIONService();
				return iT_LKJ_STARELTIONService;
			}
			set
			{
				iT_LKJ_STARELTIONService= value;
			}
		}
		#endregion

    
		#region 522 业务接口 IT_LKJ_SYSTABLEService
		IT_LKJ_SYSTABLEService iT_LKJ_SYSTABLEService;
		public IT_LKJ_SYSTABLEService IT_LKJ_SYSTABLEService
		{
			get
			{
				if(iT_LKJ_SYSTABLEService==null)
					iT_LKJ_SYSTABLEService= new T_LKJ_SYSTABLEService();
				return iT_LKJ_SYSTABLEService;
			}
			set
			{
				iT_LKJ_SYSTABLEService= value;
			}
		}
		#endregion

    
		#region 523 业务接口 IT_LKJ_VERSIONNUMService
		IT_LKJ_VERSIONNUMService iT_LKJ_VERSIONNUMService;
		public IT_LKJ_VERSIONNUMService IT_LKJ_VERSIONNUMService
		{
			get
			{
				if(iT_LKJ_VERSIONNUMService==null)
					iT_LKJ_VERSIONNUMService= new T_LKJ_VERSIONNUMService();
				return iT_LKJ_VERSIONNUMService;
			}
			set
			{
				iT_LKJ_VERSIONNUMService= value;
			}
		}
		#endregion

    
		#region 524 业务接口 IT_LKJ_WIRINGDIAGRAMService
		IT_LKJ_WIRINGDIAGRAMService iT_LKJ_WIRINGDIAGRAMService;
		public IT_LKJ_WIRINGDIAGRAMService IT_LKJ_WIRINGDIAGRAMService
		{
			get
			{
				if(iT_LKJ_WIRINGDIAGRAMService==null)
					iT_LKJ_WIRINGDIAGRAMService= new T_LKJ_WIRINGDIAGRAMService();
				return iT_LKJ_WIRINGDIAGRAMService;
			}
			set
			{
				iT_LKJ_WIRINGDIAGRAMService= value;
			}
		}
		#endregion

    
		#region 525 业务接口 IT_LKJ_WORKPROCESSService
		IT_LKJ_WORKPROCESSService iT_LKJ_WORKPROCESSService;
		public IT_LKJ_WORKPROCESSService IT_LKJ_WORKPROCESSService
		{
			get
			{
				if(iT_LKJ_WORKPROCESSService==null)
					iT_LKJ_WORKPROCESSService= new T_LKJ_WORKPROCESSService();
				return iT_LKJ_WORKPROCESSService;
			}
			set
			{
				iT_LKJ_WORKPROCESSService= value;
			}
		}
		#endregion

    
		#region 526 业务接口 IT_LKJ_WORKPROCESS_HISService
		IT_LKJ_WORKPROCESS_HISService iT_LKJ_WORKPROCESS_HISService;
		public IT_LKJ_WORKPROCESS_HISService IT_LKJ_WORKPROCESS_HISService
		{
			get
			{
				if(iT_LKJ_WORKPROCESS_HISService==null)
					iT_LKJ_WORKPROCESS_HISService= new T_LKJ_WORKPROCESS_HISService();
				return iT_LKJ_WORKPROCESS_HISService;
			}
			set
			{
				iT_LKJ_WORKPROCESS_HISService= value;
			}
		}
		#endregion

    
		#region 527 业务接口 IT_MOBILEFILEService
		IT_MOBILEFILEService iT_MOBILEFILEService;
		public IT_MOBILEFILEService IT_MOBILEFILEService
		{
			get
			{
				if(iT_MOBILEFILEService==null)
					iT_MOBILEFILEService= new T_MOBILEFILEService();
				return iT_MOBILEFILEService;
			}
			set
			{
				iT_MOBILEFILEService= value;
			}
		}
		#endregion

    
		#region 528 业务接口 IT_MOBILEFILE_TODOWNService
		IT_MOBILEFILE_TODOWNService iT_MOBILEFILE_TODOWNService;
		public IT_MOBILEFILE_TODOWNService IT_MOBILEFILE_TODOWNService
		{
			get
			{
				if(iT_MOBILEFILE_TODOWNService==null)
					iT_MOBILEFILE_TODOWNService= new T_MOBILEFILE_TODOWNService();
				return iT_MOBILEFILE_TODOWNService;
			}
			set
			{
				iT_MOBILEFILE_TODOWNService= value;
			}
		}
		#endregion

    
		#region 529 业务接口 IT_MOBILELASTPOSService
		IT_MOBILELASTPOSService iT_MOBILELASTPOSService;
		public IT_MOBILELASTPOSService IT_MOBILELASTPOSService
		{
			get
			{
				if(iT_MOBILELASTPOSService==null)
					iT_MOBILELASTPOSService= new T_MOBILELASTPOSService();
				return iT_MOBILELASTPOSService;
			}
			set
			{
				iT_MOBILELASTPOSService= value;
			}
		}
		#endregion

    
		#region 530 业务接口 IT_MOBILEROUTEService
		IT_MOBILEROUTEService iT_MOBILEROUTEService;
		public IT_MOBILEROUTEService IT_MOBILEROUTEService
		{
			get
			{
				if(iT_MOBILEROUTEService==null)
					iT_MOBILEROUTEService= new T_MOBILEROUTEService();
				return iT_MOBILEROUTEService;
			}
			set
			{
				iT_MOBILEROUTEService= value;
			}
		}
		#endregion

    
		#region 531 业务接口 IT_MOBILEROUTE_HISService
		IT_MOBILEROUTE_HISService iT_MOBILEROUTE_HISService;
		public IT_MOBILEROUTE_HISService IT_MOBILEROUTE_HISService
		{
			get
			{
				if(iT_MOBILEROUTE_HISService==null)
					iT_MOBILEROUTE_HISService= new T_MOBILEROUTE_HISService();
				return iT_MOBILEROUTE_HISService;
			}
			set
			{
				iT_MOBILEROUTE_HISService= value;
			}
		}
		#endregion

    
		#region 532 业务接口 IT_OILPOSService
		IT_OILPOSService iT_OILPOSService;
		public IT_OILPOSService IT_OILPOSService
		{
			get
			{
				if(iT_OILPOSService==null)
					iT_OILPOSService= new T_OILPOSService();
				return iT_OILPOSService;
			}
			set
			{
				iT_OILPOSService= value;
			}
		}
		#endregion

    
		#region 533 业务接口 IT_RAINService
		IT_RAINService iT_RAINService;
		public IT_RAINService IT_RAINService
		{
			get
			{
				if(iT_RAINService==null)
					iT_RAINService= new T_RAINService();
				return iT_RAINService;
			}
			set
			{
				iT_RAINService= value;
			}
		}
		#endregion

    
		#region 534 业务接口 IT_RAIN_SMSService
		IT_RAIN_SMSService iT_RAIN_SMSService;
		public IT_RAIN_SMSService IT_RAIN_SMSService
		{
			get
			{
				if(iT_RAIN_SMSService==null)
					iT_RAIN_SMSService= new T_RAIN_SMSService();
				return iT_RAIN_SMSService;
			}
			set
			{
				iT_RAIN_SMSService= value;
			}
		}
		#endregion

    
		#region 535 业务接口 IT_RAINWARNService
		IT_RAINWARNService iT_RAINWARNService;
		public IT_RAINWARNService IT_RAINWARNService
		{
			get
			{
				if(iT_RAINWARNService==null)
					iT_RAINWARNService= new T_RAINWARNService();
				return iT_RAINWARNService;
			}
			set
			{
				iT_RAINWARNService= value;
			}
		}
		#endregion

    
		#region 536 业务接口 IT_REALRAINDATAService
		IT_REALRAINDATAService iT_REALRAINDATAService;
		public IT_REALRAINDATAService IT_REALRAINDATAService
		{
			get
			{
				if(iT_REALRAINDATAService==null)
					iT_REALRAINDATAService= new T_REALRAINDATAService();
				return iT_REALRAINDATAService;
			}
			set
			{
				iT_REALRAINDATAService= value;
			}
		}
		#endregion

    
		#region 537 业务接口 IT_SGJHWARNService
		IT_SGJHWARNService iT_SGJHWARNService;
		public IT_SGJHWARNService IT_SGJHWARNService
		{
			get
			{
				if(iT_SGJHWARNService==null)
					iT_SGJHWARNService= new T_SGJHWARNService();
				return iT_SGJHWARNService;
			}
			set
			{
				iT_SGJHWARNService= value;
			}
		}
		#endregion

    
		#region 538 业务接口 IT_SGJHWARNTMPService
		IT_SGJHWARNTMPService iT_SGJHWARNTMPService;
		public IT_SGJHWARNTMPService IT_SGJHWARNTMPService
		{
			get
			{
				if(iT_SGJHWARNTMPService==null)
					iT_SGJHWARNTMPService= new T_SGJHWARNTMPService();
				return iT_SGJHWARNTMPService;
			}
			set
			{
				iT_SGJHWARNTMPService= value;
			}
		}
		#endregion

    
		#region 539 业务接口 IT_VEHICLELOCATIONService
		IT_VEHICLELOCATIONService iT_VEHICLELOCATIONService;
		public IT_VEHICLELOCATIONService IT_VEHICLELOCATIONService
		{
			get
			{
				if(iT_VEHICLELOCATIONService==null)
					iT_VEHICLELOCATIONService= new T_VEHICLELOCATIONService();
				return iT_VEHICLELOCATIONService;
			}
			set
			{
				iT_VEHICLELOCATIONService= value;
			}
		}
		#endregion

    
		#region 540 业务接口 IT_WATERService
		IT_WATERService iT_WATERService;
		public IT_WATERService IT_WATERService
		{
			get
			{
				if(iT_WATERService==null)
					iT_WATERService= new T_WATERService();
				return iT_WATERService;
			}
			set
			{
				iT_WATERService= value;
			}
		}
		#endregion

    
		#region 541 业务接口 IT_WATER_DEVICEService
		IT_WATER_DEVICEService iT_WATER_DEVICEService;
		public IT_WATER_DEVICEService IT_WATER_DEVICEService
		{
			get
			{
				if(iT_WATER_DEVICEService==null)
					iT_WATER_DEVICEService= new T_WATER_DEVICEService();
				return iT_WATER_DEVICEService;
			}
			set
			{
				iT_WATER_DEVICEService= value;
			}
		}
		#endregion

    
		#region 542 业务接口 IT_WATER_WARNService
		IT_WATER_WARNService iT_WATER_WARNService;
		public IT_WATER_WARNService IT_WATER_WARNService
		{
			get
			{
				if(iT_WATER_WARNService==null)
					iT_WATER_WARNService= new T_WATER_WARNService();
				return iT_WATER_WARNService;
			}
			set
			{
				iT_WATER_WARNService= value;
			}
		}
		#endregion

    
		#region 543 业务接口 ITASK_CARDService
		ITASK_CARDService iTASK_CARDService;
		public ITASK_CARDService ITASK_CARDService
		{
			get
			{
				if(iTASK_CARDService==null)
					iTASK_CARDService= new TASK_CARDService();
				return iTASK_CARDService;
			}
			set
			{
				iTASK_CARDService= value;
			}
		}
		#endregion

    
		#region 544 业务接口 ITASK_CONSTITLEService
		ITASK_CONSTITLEService iTASK_CONSTITLEService;
		public ITASK_CONSTITLEService ITASK_CONSTITLEService
		{
			get
			{
				if(iTASK_CONSTITLEService==null)
					iTASK_CONSTITLEService= new TASK_CONSTITLEService();
				return iTASK_CONSTITLEService;
			}
			set
			{
				iTASK_CONSTITLEService= value;
			}
		}
		#endregion

    
		#region 545 业务接口 ITASK_CONSTRUCTIONService
		ITASK_CONSTRUCTIONService iTASK_CONSTRUCTIONService;
		public ITASK_CONSTRUCTIONService ITASK_CONSTRUCTIONService
		{
			get
			{
				if(iTASK_CONSTRUCTIONService==null)
					iTASK_CONSTRUCTIONService= new TASK_CONSTRUCTIONService();
				return iTASK_CONSTRUCTIONService;
			}
			set
			{
				iTASK_CONSTRUCTIONService= value;
			}
		}
		#endregion

    
		#region 546 业务接口 ITASK_DAMAGE_RAILService
		ITASK_DAMAGE_RAILService iTASK_DAMAGE_RAILService;
		public ITASK_DAMAGE_RAILService ITASK_DAMAGE_RAILService
		{
			get
			{
				if(iTASK_DAMAGE_RAILService==null)
					iTASK_DAMAGE_RAILService= new TASK_DAMAGE_RAILService();
				return iTASK_DAMAGE_RAILService;
			}
			set
			{
				iTASK_DAMAGE_RAILService= value;
			}
		}
		#endregion

    
		#region 547 业务接口 ITASK_FLOORService
		ITASK_FLOORService iTASK_FLOORService;
		public ITASK_FLOORService ITASK_FLOORService
		{
			get
			{
				if(iTASK_FLOORService==null)
					iTASK_FLOORService= new TASK_FLOORService();
				return iTASK_FLOORService;
			}
			set
			{
				iTASK_FLOORService= value;
			}
		}
		#endregion

    
		#region 548 业务接口 ITASK_GBH_RAILService
		ITASK_GBH_RAILService iTASK_GBH_RAILService;
		public ITASK_GBH_RAILService ITASK_GBH_RAILService
		{
			get
			{
				if(iTASK_GBH_RAILService==null)
					iTASK_GBH_RAILService= new TASK_GBH_RAILService();
				return iTASK_GBH_RAILService;
			}
			set
			{
				iTASK_GBH_RAILService= value;
			}
		}
		#endregion

    
		#region 549 业务接口 ITASK_LAY_LINEROADService
		ITASK_LAY_LINEROADService iTASK_LAY_LINEROADService;
		public ITASK_LAY_LINEROADService ITASK_LAY_LINEROADService
		{
			get
			{
				if(iTASK_LAY_LINEROADService==null)
					iTASK_LAY_LINEROADService= new TASK_LAY_LINEROADService();
				return iTASK_LAY_LINEROADService;
			}
			set
			{
				iTASK_LAY_LINEROADService= value;
			}
		}
		#endregion

    
		#region 550 业务接口 ITASK_PLANService
		ITASK_PLANService iTASK_PLANService;
		public ITASK_PLANService ITASK_PLANService
		{
			get
			{
				if(iTASK_PLANService==null)
					iTASK_PLANService= new TASK_PLANService();
				return iTASK_PLANService;
			}
			set
			{
				iTASK_PLANService= value;
			}
		}
		#endregion

    
		#region 551 业务接口 ITASK_PLAN_MATERIALService
		ITASK_PLAN_MATERIALService iTASK_PLAN_MATERIALService;
		public ITASK_PLAN_MATERIALService ITASK_PLAN_MATERIALService
		{
			get
			{
				if(iTASK_PLAN_MATERIALService==null)
					iTASK_PLAN_MATERIALService= new TASK_PLAN_MATERIALService();
				return iTASK_PLAN_MATERIALService;
			}
			set
			{
				iTASK_PLAN_MATERIALService= value;
			}
		}
		#endregion

    
		#region 552 业务接口 ITASK_PLAN_PROBLEMService
		ITASK_PLAN_PROBLEMService iTASK_PLAN_PROBLEMService;
		public ITASK_PLAN_PROBLEMService ITASK_PLAN_PROBLEMService
		{
			get
			{
				if(iTASK_PLAN_PROBLEMService==null)
					iTASK_PLAN_PROBLEMService= new TASK_PLAN_PROBLEMService();
				return iTASK_PLAN_PROBLEMService;
			}
			set
			{
				iTASK_PLAN_PROBLEMService= value;
			}
		}
		#endregion

    
		#region 553 业务接口 ITASK_PLAN_TOOLService
		ITASK_PLAN_TOOLService iTASK_PLAN_TOOLService;
		public ITASK_PLAN_TOOLService ITASK_PLAN_TOOLService
		{
			get
			{
				if(iTASK_PLAN_TOOLService==null)
					iTASK_PLAN_TOOLService= new TASK_PLAN_TOOLService();
				return iTASK_PLAN_TOOLService;
			}
			set
			{
				iTASK_PLAN_TOOLService= value;
			}
		}
		#endregion

    
		#region 554 业务接口 ITASK_RAILService
		ITASK_RAILService iTASK_RAILService;
		public ITASK_RAILService ITASK_RAILService
		{
			get
			{
				if(iTASK_RAILService==null)
					iTASK_RAILService= new TASK_RAILService();
				return iTASK_RAILService;
			}
			set
			{
				iTASK_RAILService= value;
			}
		}
		#endregion

    
		#region 555 业务接口 ITASK_RAILCOUNTService
		ITASK_RAILCOUNTService iTASK_RAILCOUNTService;
		public ITASK_RAILCOUNTService ITASK_RAILCOUNTService
		{
			get
			{
				if(iTASK_RAILCOUNTService==null)
					iTASK_RAILCOUNTService= new TASK_RAILCOUNTService();
				return iTASK_RAILCOUNTService;
			}
			set
			{
				iTASK_RAILCOUNTService= value;
			}
		}
		#endregion

    
		#region 556 业务接口 ITASK_RECOVER_STUFFService
		ITASK_RECOVER_STUFFService iTASK_RECOVER_STUFFService;
		public ITASK_RECOVER_STUFFService ITASK_RECOVER_STUFFService
		{
			get
			{
				if(iTASK_RECOVER_STUFFService==null)
					iTASK_RECOVER_STUFFService= new TASK_RECOVER_STUFFService();
				return iTASK_RECOVER_STUFFService;
			}
			set
			{
				iTASK_RECOVER_STUFFService= value;
			}
		}
		#endregion

    
		#region 557 业务接口 ITASK_REPLACE_RAILService
		ITASK_REPLACE_RAILService iTASK_REPLACE_RAILService;
		public ITASK_REPLACE_RAILService ITASK_REPLACE_RAILService
		{
			get
			{
				if(iTASK_REPLACE_RAILService==null)
					iTASK_REPLACE_RAILService= new TASK_REPLACE_RAILService();
				return iTASK_REPLACE_RAILService;
			}
			set
			{
				iTASK_REPLACE_RAILService= value;
			}
		}
		#endregion

    
		#region 558 业务接口 ITASK_REPLACE_TIEService
		ITASK_REPLACE_TIEService iTASK_REPLACE_TIEService;
		public ITASK_REPLACE_TIEService ITASK_REPLACE_TIEService
		{
			get
			{
				if(iTASK_REPLACE_TIEService==null)
					iTASK_REPLACE_TIEService= new TASK_REPLACE_TIEService();
				return iTASK_REPLACE_TIEService;
			}
			set
			{
				iTASK_REPLACE_TIEService= value;
			}
		}
		#endregion

    
		#region 559 业务接口 ITASK_SLIGHT_FROGService
		ITASK_SLIGHT_FROGService iTASK_SLIGHT_FROGService;
		public ITASK_SLIGHT_FROGService ITASK_SLIGHT_FROGService
		{
			get
			{
				if(iTASK_SLIGHT_FROGService==null)
					iTASK_SLIGHT_FROGService= new TASK_SLIGHT_FROGService();
				return iTASK_SLIGHT_FROGService;
			}
			set
			{
				iTASK_SLIGHT_FROGService= value;
			}
		}
		#endregion

    
		#region 560 业务接口 ITASK_SLIGHT_JRAILService
		ITASK_SLIGHT_JRAILService iTASK_SLIGHT_JRAILService;
		public ITASK_SLIGHT_JRAILService ITASK_SLIGHT_JRAILService
		{
			get
			{
				if(iTASK_SLIGHT_JRAILService==null)
					iTASK_SLIGHT_JRAILService= new TASK_SLIGHT_JRAILService();
				return iTASK_SLIGHT_JRAILService;
			}
			set
			{
				iTASK_SLIGHT_JRAILService= value;
			}
		}
		#endregion

    
		#region 561 业务接口 ITASK_SLIGHT_OUTLINEService
		ITASK_SLIGHT_OUTLINEService iTASK_SLIGHT_OUTLINEService;
		public ITASK_SLIGHT_OUTLINEService ITASK_SLIGHT_OUTLINEService
		{
			get
			{
				if(iTASK_SLIGHT_OUTLINEService==null)
					iTASK_SLIGHT_OUTLINEService= new TASK_SLIGHT_OUTLINEService();
				return iTASK_SLIGHT_OUTLINEService;
			}
			set
			{
				iTASK_SLIGHT_OUTLINEService= value;
			}
		}
		#endregion

    
		#region 562 业务接口 ITASK_SLIGHT_OUTLINE_FILEService
		ITASK_SLIGHT_OUTLINE_FILEService iTASK_SLIGHT_OUTLINE_FILEService;
		public ITASK_SLIGHT_OUTLINE_FILEService ITASK_SLIGHT_OUTLINE_FILEService
		{
			get
			{
				if(iTASK_SLIGHT_OUTLINE_FILEService==null)
					iTASK_SLIGHT_OUTLINE_FILEService= new TASK_SLIGHT_OUTLINE_FILEService();
				return iTASK_SLIGHT_OUTLINE_FILEService;
			}
			set
			{
				iTASK_SLIGHT_OUTLINE_FILEService= value;
			}
		}
		#endregion

    
		#region 563 业务接口 ITASK_SLIGHT_RAILService
		ITASK_SLIGHT_RAILService iTASK_SLIGHT_RAILService;
		public ITASK_SLIGHT_RAILService ITASK_SLIGHT_RAILService
		{
			get
			{
				if(iTASK_SLIGHT_RAILService==null)
					iTASK_SLIGHT_RAILService= new TASK_SLIGHT_RAILService();
				return iTASK_SLIGHT_RAILService;
			}
			set
			{
				iTASK_SLIGHT_RAILService= value;
			}
		}
		#endregion

    
		#region 564 业务接口 ITASK_SLIGHT_RAILP43Service
		ITASK_SLIGHT_RAILP43Service iTASK_SLIGHT_RAILP43Service;
		public ITASK_SLIGHT_RAILP43Service ITASK_SLIGHT_RAILP43Service
		{
			get
			{
				if(iTASK_SLIGHT_RAILP43Service==null)
					iTASK_SLIGHT_RAILP43Service= new TASK_SLIGHT_RAILP43Service();
				return iTASK_SLIGHT_RAILP43Service;
			}
			set
			{
				iTASK_SLIGHT_RAILP43Service= value;
			}
		}
		#endregion

    
		#region 565 业务接口 ITASK_SLIGHT_RAILP50Service
		ITASK_SLIGHT_RAILP50Service iTASK_SLIGHT_RAILP50Service;
		public ITASK_SLIGHT_RAILP50Service ITASK_SLIGHT_RAILP50Service
		{
			get
			{
				if(iTASK_SLIGHT_RAILP50Service==null)
					iTASK_SLIGHT_RAILP50Service= new TASK_SLIGHT_RAILP50Service();
				return iTASK_SLIGHT_RAILP50Service;
			}
			set
			{
				iTASK_SLIGHT_RAILP50Service= value;
			}
		}
		#endregion

    
		#region 566 业务接口 ITASK_SLIGHT_RAILP60Service
		ITASK_SLIGHT_RAILP60Service iTASK_SLIGHT_RAILP60Service;
		public ITASK_SLIGHT_RAILP60Service ITASK_SLIGHT_RAILP60Service
		{
			get
			{
				if(iTASK_SLIGHT_RAILP60Service==null)
					iTASK_SLIGHT_RAILP60Service= new TASK_SLIGHT_RAILP60Service();
				return iTASK_SLIGHT_RAILP60Service;
			}
			set
			{
				iTASK_SLIGHT_RAILP60Service= value;
			}
		}
		#endregion

    
		#region 567 业务接口 ITASK_SVGService
		ITASK_SVGService iTASK_SVGService;
		public ITASK_SVGService ITASK_SVGService
		{
			get
			{
				if(iTASK_SVGService==null)
					iTASK_SVGService= new TASK_SVGService();
				return iTASK_SVGService;
			}
			set
			{
				iTASK_SVGService= value;
			}
		}
		#endregion

    
		#region 568 业务接口 ITASK_TOOLINFOService
		ITASK_TOOLINFOService iTASK_TOOLINFOService;
		public ITASK_TOOLINFOService ITASK_TOOLINFOService
		{
			get
			{
				if(iTASK_TOOLINFOService==null)
					iTASK_TOOLINFOService= new TASK_TOOLINFOService();
				return iTASK_TOOLINFOService;
			}
			set
			{
				iTASK_TOOLINFOService= value;
			}
		}
		#endregion

    
		#region 569 业务接口 ITASK_UNLOAD_RAILService
		ITASK_UNLOAD_RAILService iTASK_UNLOAD_RAILService;
		public ITASK_UNLOAD_RAILService ITASK_UNLOAD_RAILService
		{
			get
			{
				if(iTASK_UNLOAD_RAILService==null)
					iTASK_UNLOAD_RAILService= new TASK_UNLOAD_RAILService();
				return iTASK_UNLOAD_RAILService;
			}
			set
			{
				iTASK_UNLOAD_RAILService= value;
			}
		}
		#endregion

    
		#region 570 业务接口 ITASK_UNLOAD_STONEService
		ITASK_UNLOAD_STONEService iTASK_UNLOAD_STONEService;
		public ITASK_UNLOAD_STONEService ITASK_UNLOAD_STONEService
		{
			get
			{
				if(iTASK_UNLOAD_STONEService==null)
					iTASK_UNLOAD_STONEService= new TASK_UNLOAD_STONEService();
				return iTASK_UNLOAD_STONEService;
			}
			set
			{
				iTASK_UNLOAD_STONEService= value;
			}
		}
		#endregion

    
		#region 571 业务接口 ITASK_UNLOAD_TIEService
		ITASK_UNLOAD_TIEService iTASK_UNLOAD_TIEService;
		public ITASK_UNLOAD_TIEService ITASK_UNLOAD_TIEService
		{
			get
			{
				if(iTASK_UNLOAD_TIEService==null)
					iTASK_UNLOAD_TIEService= new TASK_UNLOAD_TIEService();
				return iTASK_UNLOAD_TIEService;
			}
			set
			{
				iTASK_UNLOAD_TIEService= value;
			}
		}
		#endregion

    
		#region 572 业务接口 ITASK_WORKLOADService
		ITASK_WORKLOADService iTASK_WORKLOADService;
		public ITASK_WORKLOADService ITASK_WORKLOADService
		{
			get
			{
				if(iTASK_WORKLOADService==null)
					iTASK_WORKLOADService= new TASK_WORKLOADService();
				return iTASK_WORKLOADService;
			}
			set
			{
				iTASK_WORKLOADService= value;
			}
		}
		#endregion

    
		#region 573 业务接口 ITEMPERATURE_SECTION_LINEService
		ITEMPERATURE_SECTION_LINEService iTEMPERATURE_SECTION_LINEService;
		public ITEMPERATURE_SECTION_LINEService ITEMPERATURE_SECTION_LINEService
		{
			get
			{
				if(iTEMPERATURE_SECTION_LINEService==null)
					iTEMPERATURE_SECTION_LINEService= new TEMPERATURE_SECTION_LINEService();
				return iTEMPERATURE_SECTION_LINEService;
			}
			set
			{
				iTEMPERATURE_SECTION_LINEService= value;
			}
		}
		#endregion

    
		#region 574 业务接口 ITOOL_BDATE_DICService
		ITOOL_BDATE_DICService iTOOL_BDATE_DICService;
		public ITOOL_BDATE_DICService ITOOL_BDATE_DICService
		{
			get
			{
				if(iTOOL_BDATE_DICService==null)
					iTOOL_BDATE_DICService= new TOOL_BDATE_DICService();
				return iTOOL_BDATE_DICService;
			}
			set
			{
				iTOOL_BDATE_DICService= value;
			}
		}
		#endregion

    
		#region 575 业务接口 ITOOL_BDATE_STOREHOURSEService
		ITOOL_BDATE_STOREHOURSEService iTOOL_BDATE_STOREHOURSEService;
		public ITOOL_BDATE_STOREHOURSEService ITOOL_BDATE_STOREHOURSEService
		{
			get
			{
				if(iTOOL_BDATE_STOREHOURSEService==null)
					iTOOL_BDATE_STOREHOURSEService= new TOOL_BDATE_STOREHOURSEService();
				return iTOOL_BDATE_STOREHOURSEService;
			}
			set
			{
				iTOOL_BDATE_STOREHOURSEService= value;
			}
		}
		#endregion

    
		#region 576 业务接口 ITOOL_BDATE_TOOLNAMEService
		ITOOL_BDATE_TOOLNAMEService iTOOL_BDATE_TOOLNAMEService;
		public ITOOL_BDATE_TOOLNAMEService ITOOL_BDATE_TOOLNAMEService
		{
			get
			{
				if(iTOOL_BDATE_TOOLNAMEService==null)
					iTOOL_BDATE_TOOLNAMEService= new TOOL_BDATE_TOOLNAMEService();
				return iTOOL_BDATE_TOOLNAMEService;
			}
			set
			{
				iTOOL_BDATE_TOOLNAMEService= value;
			}
		}
		#endregion

    
		#region 577 业务接口 ITOOL_INOUTMNG_INFOService
		ITOOL_INOUTMNG_INFOService iTOOL_INOUTMNG_INFOService;
		public ITOOL_INOUTMNG_INFOService ITOOL_INOUTMNG_INFOService
		{
			get
			{
				if(iTOOL_INOUTMNG_INFOService==null)
					iTOOL_INOUTMNG_INFOService= new TOOL_INOUTMNG_INFOService();
				return iTOOL_INOUTMNG_INFOService;
			}
			set
			{
				iTOOL_INOUTMNG_INFOService= value;
			}
		}
		#endregion

    
		#region 578 业务接口 ITOOL_JOB_PLANService
		ITOOL_JOB_PLANService iTOOL_JOB_PLANService;
		public ITOOL_JOB_PLANService ITOOL_JOB_PLANService
		{
			get
			{
				if(iTOOL_JOB_PLANService==null)
					iTOOL_JOB_PLANService= new TOOL_JOB_PLANService();
				return iTOOL_JOB_PLANService;
			}
			set
			{
				iTOOL_JOB_PLANService= value;
			}
		}
		#endregion

    
		#region 579 业务接口 ITOOL_JOB_PLAN_IMPORTService
		ITOOL_JOB_PLAN_IMPORTService iTOOL_JOB_PLAN_IMPORTService;
		public ITOOL_JOB_PLAN_IMPORTService ITOOL_JOB_PLAN_IMPORTService
		{
			get
			{
				if(iTOOL_JOB_PLAN_IMPORTService==null)
					iTOOL_JOB_PLAN_IMPORTService= new TOOL_JOB_PLAN_IMPORTService();
				return iTOOL_JOB_PLAN_IMPORTService;
			}
			set
			{
				iTOOL_JOB_PLAN_IMPORTService= value;
			}
		}
		#endregion

    
		#region 580 业务接口 ITOOL_PHONE_USERService
		ITOOL_PHONE_USERService iTOOL_PHONE_USERService;
		public ITOOL_PHONE_USERService ITOOL_PHONE_USERService
		{
			get
			{
				if(iTOOL_PHONE_USERService==null)
					iTOOL_PHONE_USERService= new TOOL_PHONE_USERService();
				return iTOOL_PHONE_USERService;
			}
			set
			{
				iTOOL_PHONE_USERService= value;
			}
		}
		#endregion

    
		#region 581 业务接口 ITOOL_TOOLMNG_INOUTService
		ITOOL_TOOLMNG_INOUTService iTOOL_TOOLMNG_INOUTService;
		public ITOOL_TOOLMNG_INOUTService ITOOL_TOOLMNG_INOUTService
		{
			get
			{
				if(iTOOL_TOOLMNG_INOUTService==null)
					iTOOL_TOOLMNG_INOUTService= new TOOL_TOOLMNG_INOUTService();
				return iTOOL_TOOLMNG_INOUTService;
			}
			set
			{
				iTOOL_TOOLMNG_INOUTService= value;
			}
		}
		#endregion

    
		#region 582 业务接口 ITOOL_UPDOWN_LINEService
		ITOOL_UPDOWN_LINEService iTOOL_UPDOWN_LINEService;
		public ITOOL_UPDOWN_LINEService ITOOL_UPDOWN_LINEService
		{
			get
			{
				if(iTOOL_UPDOWN_LINEService==null)
					iTOOL_UPDOWN_LINEService= new TOOL_UPDOWN_LINEService();
				return iTOOL_UPDOWN_LINEService;
			}
			set
			{
				iTOOL_UPDOWN_LINEService= value;
			}
		}
		#endregion

    
		#region 583 业务接口 ITOOL_USEService
		ITOOL_USEService iTOOL_USEService;
		public ITOOL_USEService ITOOL_USEService
		{
			get
			{
				if(iTOOL_USEService==null)
					iTOOL_USEService= new TOOL_USEService();
				return iTOOL_USEService;
			}
			set
			{
				iTOOL_USEService= value;
			}
		}
		#endregion

    
		#region 584 业务接口 ITOOL_VIRTUAL_JOB_PLANService
		ITOOL_VIRTUAL_JOB_PLANService iTOOL_VIRTUAL_JOB_PLANService;
		public ITOOL_VIRTUAL_JOB_PLANService ITOOL_VIRTUAL_JOB_PLANService
		{
			get
			{
				if(iTOOL_VIRTUAL_JOB_PLANService==null)
					iTOOL_VIRTUAL_JOB_PLANService= new TOOL_VIRTUAL_JOB_PLANService();
				return iTOOL_VIRTUAL_JOB_PLANService;
			}
			set
			{
				iTOOL_VIRTUAL_JOB_PLANService= value;
			}
		}
		#endregion

    
		#region 585 业务接口 ITOOL_VIRTUAL_UPDOWN_LINEService
		ITOOL_VIRTUAL_UPDOWN_LINEService iTOOL_VIRTUAL_UPDOWN_LINEService;
		public ITOOL_VIRTUAL_UPDOWN_LINEService ITOOL_VIRTUAL_UPDOWN_LINEService
		{
			get
			{
				if(iTOOL_VIRTUAL_UPDOWN_LINEService==null)
					iTOOL_VIRTUAL_UPDOWN_LINEService= new TOOL_VIRTUAL_UPDOWN_LINEService();
				return iTOOL_VIRTUAL_UPDOWN_LINEService;
			}
			set
			{
				iTOOL_VIRTUAL_UPDOWN_LINEService= value;
			}
		}
		#endregion

    
		#region 586 业务接口 ITOOL_VIRTUAL_USEService
		ITOOL_VIRTUAL_USEService iTOOL_VIRTUAL_USEService;
		public ITOOL_VIRTUAL_USEService ITOOL_VIRTUAL_USEService
		{
			get
			{
				if(iTOOL_VIRTUAL_USEService==null)
					iTOOL_VIRTUAL_USEService= new TOOL_VIRTUAL_USEService();
				return iTOOL_VIRTUAL_USEService;
			}
			set
			{
				iTOOL_VIRTUAL_USEService= value;
			}
		}
		#endregion

    
		#region 587 业务接口 ITOOL_VIRTUAL_WARMService
		ITOOL_VIRTUAL_WARMService iTOOL_VIRTUAL_WARMService;
		public ITOOL_VIRTUAL_WARMService ITOOL_VIRTUAL_WARMService
		{
			get
			{
				if(iTOOL_VIRTUAL_WARMService==null)
					iTOOL_VIRTUAL_WARMService= new TOOL_VIRTUAL_WARMService();
				return iTOOL_VIRTUAL_WARMService;
			}
			set
			{
				iTOOL_VIRTUAL_WARMService= value;
			}
		}
		#endregion

    
		#region 588 业务接口 ITOOL_WARMService
		ITOOL_WARMService iTOOL_WARMService;
		public ITOOL_WARMService ITOOL_WARMService
		{
			get
			{
				if(iTOOL_WARMService==null)
					iTOOL_WARMService= new TOOL_WARMService();
				return iTOOL_WARMService;
			}
			set
			{
				iTOOL_WARMService= value;
			}
		}
		#endregion

    
		#region 589 业务接口 ITURNOUT_BASEService
		ITURNOUT_BASEService iTURNOUT_BASEService;
		public ITURNOUT_BASEService ITURNOUT_BASEService
		{
			get
			{
				if(iTURNOUT_BASEService==null)
					iTURNOUT_BASEService= new TURNOUT_BASEService();
				return iTURNOUT_BASEService;
			}
			set
			{
				iTURNOUT_BASEService= value;
			}
		}
		#endregion

    
		#region 590 业务接口 ITURNOUT_BDATE_DICService
		ITURNOUT_BDATE_DICService iTURNOUT_BDATE_DICService;
		public ITURNOUT_BDATE_DICService ITURNOUT_BDATE_DICService
		{
			get
			{
				if(iTURNOUT_BDATE_DICService==null)
					iTURNOUT_BDATE_DICService= new TURNOUT_BDATE_DICService();
				return iTURNOUT_BDATE_DICService;
			}
			set
			{
				iTURNOUT_BDATE_DICService= value;
			}
		}
		#endregion

    
		#region 591 业务接口 ITURNOUT_BRANCHService
		ITURNOUT_BRANCHService iTURNOUT_BRANCHService;
		public ITURNOUT_BRANCHService ITURNOUT_BRANCHService
		{
			get
			{
				if(iTURNOUT_BRANCHService==null)
					iTURNOUT_BRANCHService= new TURNOUT_BRANCHService();
				return iTURNOUT_BRANCHService;
			}
			set
			{
				iTURNOUT_BRANCHService= value;
			}
		}
		#endregion

    
		#region 592 业务接口 ITURNOUT_HIS_BRANCHService
		ITURNOUT_HIS_BRANCHService iTURNOUT_HIS_BRANCHService;
		public ITURNOUT_HIS_BRANCHService ITURNOUT_HIS_BRANCHService
		{
			get
			{
				if(iTURNOUT_HIS_BRANCHService==null)
					iTURNOUT_HIS_BRANCHService= new TURNOUT_HIS_BRANCHService();
				return iTURNOUT_HIS_BRANCHService;
			}
			set
			{
				iTURNOUT_HIS_BRANCHService= value;
			}
		}
		#endregion

    
		#region 593 业务接口 ITURNOUT_HIS_PARTService
		ITURNOUT_HIS_PARTService iTURNOUT_HIS_PARTService;
		public ITURNOUT_HIS_PARTService ITURNOUT_HIS_PARTService
		{
			get
			{
				if(iTURNOUT_HIS_PARTService==null)
					iTURNOUT_HIS_PARTService= new TURNOUT_HIS_PARTService();
				return iTURNOUT_HIS_PARTService;
			}
			set
			{
				iTURNOUT_HIS_PARTService= value;
			}
		}
		#endregion

    
		#region 594 业务接口 ITURNOUT_HIS_PICService
		ITURNOUT_HIS_PICService iTURNOUT_HIS_PICService;
		public ITURNOUT_HIS_PICService ITURNOUT_HIS_PICService
		{
			get
			{
				if(iTURNOUT_HIS_PICService==null)
					iTURNOUT_HIS_PICService= new TURNOUT_HIS_PICService();
				return iTURNOUT_HIS_PICService;
			}
			set
			{
				iTURNOUT_HIS_PICService= value;
			}
		}
		#endregion

    
		#region 595 业务接口 ITURNOUT_HIS_RAILService
		ITURNOUT_HIS_RAILService iTURNOUT_HIS_RAILService;
		public ITURNOUT_HIS_RAILService ITURNOUT_HIS_RAILService
		{
			get
			{
				if(iTURNOUT_HIS_RAILService==null)
					iTURNOUT_HIS_RAILService= new TURNOUT_HIS_RAILService();
				return iTURNOUT_HIS_RAILService;
			}
			set
			{
				iTURNOUT_HIS_RAILService= value;
			}
		}
		#endregion

    
		#region 596 业务接口 ITURNOUT_HISTORYService
		ITURNOUT_HISTORYService iTURNOUT_HISTORYService;
		public ITURNOUT_HISTORYService ITURNOUT_HISTORYService
		{
			get
			{
				if(iTURNOUT_HISTORYService==null)
					iTURNOUT_HISTORYService= new TURNOUT_HISTORYService();
				return iTURNOUT_HISTORYService;
			}
			set
			{
				iTURNOUT_HISTORYService= value;
			}
		}
		#endregion

    
		#region 597 业务接口 ITURNOUT_PARTService
		ITURNOUT_PARTService iTURNOUT_PARTService;
		public ITURNOUT_PARTService ITURNOUT_PARTService
		{
			get
			{
				if(iTURNOUT_PARTService==null)
					iTURNOUT_PARTService= new TURNOUT_PARTService();
				return iTURNOUT_PARTService;
			}
			set
			{
				iTURNOUT_PARTService= value;
			}
		}
		#endregion

    
		#region 598 业务接口 ITURNOUT_PICService
		ITURNOUT_PICService iTURNOUT_PICService;
		public ITURNOUT_PICService ITURNOUT_PICService
		{
			get
			{
				if(iTURNOUT_PICService==null)
					iTURNOUT_PICService= new TURNOUT_PICService();
				return iTURNOUT_PICService;
			}
			set
			{
				iTURNOUT_PICService= value;
			}
		}
		#endregion

    
		#region 599 业务接口 ITURNOUT_RAILService
		ITURNOUT_RAILService iTURNOUT_RAILService;
		public ITURNOUT_RAILService ITURNOUT_RAILService
		{
			get
			{
				if(iTURNOUT_RAILService==null)
					iTURNOUT_RAILService= new TURNOUT_RAILService();
				return iTURNOUT_RAILService;
			}
			set
			{
				iTURNOUT_RAILService= value;
			}
		}
		#endregion

    
		#region 600 业务接口 ITYPEFLOOD_PHOTOService
		ITYPEFLOOD_PHOTOService iTYPEFLOOD_PHOTOService;
		public ITYPEFLOOD_PHOTOService ITYPEFLOOD_PHOTOService
		{
			get
			{
				if(iTYPEFLOOD_PHOTOService==null)
					iTYPEFLOOD_PHOTOService= new TYPEFLOOD_PHOTOService();
				return iTYPEFLOOD_PHOTOService;
			}
			set
			{
				iTYPEFLOOD_PHOTOService= value;
			}
		}
		#endregion

    
		#region 601 业务接口 IVEHICLELOC_BDATA_LOCOMOTIVEService
		IVEHICLELOC_BDATA_LOCOMOTIVEService iVEHICLELOC_BDATA_LOCOMOTIVEService;
		public IVEHICLELOC_BDATA_LOCOMOTIVEService IVEHICLELOC_BDATA_LOCOMOTIVEService
		{
			get
			{
				if(iVEHICLELOC_BDATA_LOCOMOTIVEService==null)
					iVEHICLELOC_BDATA_LOCOMOTIVEService= new VEHICLELOC_BDATA_LOCOMOTIVEService();
				return iVEHICLELOC_BDATA_LOCOMOTIVEService;
			}
			set
			{
				iVEHICLELOC_BDATA_LOCOMOTIVEService= value;
			}
		}
		#endregion

    
		#region 602 业务接口 IVIDEO_BDATA_DEVICEService
		IVIDEO_BDATA_DEVICEService iVIDEO_BDATA_DEVICEService;
		public IVIDEO_BDATA_DEVICEService IVIDEO_BDATA_DEVICEService
		{
			get
			{
				if(iVIDEO_BDATA_DEVICEService==null)
					iVIDEO_BDATA_DEVICEService= new VIDEO_BDATA_DEVICEService();
				return iVIDEO_BDATA_DEVICEService;
			}
			set
			{
				iVIDEO_BDATA_DEVICEService= value;
			}
		}
		#endregion

    
		#region 603 业务接口 IVIDEO_FILEService
		IVIDEO_FILEService iVIDEO_FILEService;
		public IVIDEO_FILEService IVIDEO_FILEService
		{
			get
			{
				if(iVIDEO_FILEService==null)
					iVIDEO_FILEService= new VIDEO_FILEService();
				return iVIDEO_FILEService;
			}
			set
			{
				iVIDEO_FILEService= value;
			}
		}
		#endregion

    
		#region 604 业务接口 IWEATHER_PROVINCE_FORECASTService
		IWEATHER_PROVINCE_FORECASTService iWEATHER_PROVINCE_FORECASTService;
		public IWEATHER_PROVINCE_FORECASTService IWEATHER_PROVINCE_FORECASTService
		{
			get
			{
				if(iWEATHER_PROVINCE_FORECASTService==null)
					iWEATHER_PROVINCE_FORECASTService= new WEATHER_PROVINCE_FORECASTService();
				return iWEATHER_PROVINCE_FORECASTService;
			}
			set
			{
				iWEATHER_PROVINCE_FORECASTService= value;
			}
		}
		#endregion

    
		#region 605 业务接口 IWEATHER_PROVINCE_HOURFORECASTService
		IWEATHER_PROVINCE_HOURFORECASTService iWEATHER_PROVINCE_HOURFORECASTService;
		public IWEATHER_PROVINCE_HOURFORECASTService IWEATHER_PROVINCE_HOURFORECASTService
		{
			get
			{
				if(iWEATHER_PROVINCE_HOURFORECASTService==null)
					iWEATHER_PROVINCE_HOURFORECASTService= new WEATHER_PROVINCE_HOURFORECASTService();
				return iWEATHER_PROVINCE_HOURFORECASTService;
			}
			set
			{
				iWEATHER_PROVINCE_HOURFORECASTService= value;
			}
		}
		#endregion

    
		#region 606 业务接口 IWINDService
		IWINDService iWINDService;
		public IWINDService IWINDService
		{
			get
			{
				if(iWINDService==null)
					iWINDService= new WINDService();
				return iWINDService;
			}
			set
			{
				iWINDService= value;
			}
		}
		#endregion

    
		#region 607 业务接口 IWIND_BASEINFOService
		IWIND_BASEINFOService iWIND_BASEINFOService;
		public IWIND_BASEINFOService IWIND_BASEINFOService
		{
			get
			{
				if(iWIND_BASEINFOService==null)
					iWIND_BASEINFOService= new WIND_BASEINFOService();
				return iWIND_BASEINFOService;
			}
			set
			{
				iWIND_BASEINFOService= value;
			}
		}
		#endregion

    
		#region 608 业务接口 IWIND_DAYRPTService
		IWIND_DAYRPTService iWIND_DAYRPTService;
		public IWIND_DAYRPTService IWIND_DAYRPTService
		{
			get
			{
				if(iWIND_DAYRPTService==null)
					iWIND_DAYRPTService= new WIND_DAYRPTService();
				return iWIND_DAYRPTService;
			}
			set
			{
				iWIND_DAYRPTService= value;
			}
		}
		#endregion

    
		#region 609 业务接口 IWIND_DIRECTIONService
		IWIND_DIRECTIONService iWIND_DIRECTIONService;
		public IWIND_DIRECTIONService IWIND_DIRECTIONService
		{
			get
			{
				if(iWIND_DIRECTIONService==null)
					iWIND_DIRECTIONService= new WIND_DIRECTIONService();
				return iWIND_DIRECTIONService;
			}
			set
			{
				iWIND_DIRECTIONService= value;
			}
		}
		#endregion

    
		#region 610 业务接口 IWIND_GRADINGService
		IWIND_GRADINGService iWIND_GRADINGService;
		public IWIND_GRADINGService IWIND_GRADINGService
		{
			get
			{
				if(iWIND_GRADINGService==null)
					iWIND_GRADINGService= new WIND_GRADINGService();
				return iWIND_GRADINGService;
			}
			set
			{
				iWIND_GRADINGService= value;
			}
		}
		#endregion

    
		#region 611 业务接口 IWIND_MONRPTService
		IWIND_MONRPTService iWIND_MONRPTService;
		public IWIND_MONRPTService IWIND_MONRPTService
		{
			get
			{
				if(iWIND_MONRPTService==null)
					iWIND_MONRPTService= new WIND_MONRPTService();
				return iWIND_MONRPTService;
			}
			set
			{
				iWIND_MONRPTService= value;
			}
		}
		#endregion

    
		#region 612 业务接口 IWIND_SECTION_LINEService
		IWIND_SECTION_LINEService iWIND_SECTION_LINEService;
		public IWIND_SECTION_LINEService IWIND_SECTION_LINEService
		{
			get
			{
				if(iWIND_SECTION_LINEService==null)
					iWIND_SECTION_LINEService= new WIND_SECTION_LINEService();
				return iWIND_SECTION_LINEService;
			}
			set
			{
				iWIND_SECTION_LINEService= value;
			}
		}
		#endregion

    
		#region 613 业务接口 IWIND_WARNService
		IWIND_WARNService iWIND_WARNService;
		public IWIND_WARNService IWIND_WARNService
		{
			get
			{
				if(iWIND_WARNService==null)
					iWIND_WARNService= new WIND_WARNService();
				return iWIND_WARNService;
			}
			set
			{
				iWIND_WARNService= value;
			}
		}
		#endregion

    
		#region 614 业务接口 IWIND_WARN_STANDARDService
		IWIND_WARN_STANDARDService iWIND_WARN_STANDARDService;
		public IWIND_WARN_STANDARDService IWIND_WARN_STANDARDService
		{
			get
			{
				if(iWIND_WARN_STANDARDService==null)
					iWIND_WARN_STANDARDService= new WIND_WARN_STANDARDService();
				return iWIND_WARN_STANDARDService;
			}
			set
			{
				iWIND_WARN_STANDARDService= value;
			}
		}
		#endregion

    
		#region 615 业务接口 IWIND_YEARRPTService
		IWIND_YEARRPTService iWIND_YEARRPTService;
		public IWIND_YEARRPTService IWIND_YEARRPTService
		{
			get
			{
				if(iWIND_YEARRPTService==null)
					iWIND_YEARRPTService= new WIND_YEARRPTService();
				return iWIND_YEARRPTService;
			}
			set
			{
				iWIND_YEARRPTService= value;
			}
		}
		#endregion

    
		#region 616 业务接口 IWUFENG_BIAOZHUNService
		IWUFENG_BIAOZHUNService iWUFENG_BIAOZHUNService;
		public IWUFENG_BIAOZHUNService IWUFENG_BIAOZHUNService
		{
			get
			{
				if(iWUFENG_BIAOZHUNService==null)
					iWUFENG_BIAOZHUNService= new WUFENG_BIAOZHUNService();
				return iWUFENG_BIAOZHUNService;
			}
			set
			{
				iWUFENG_BIAOZHUNService= value;
			}
		}
		#endregion

    
		#region 617 业务接口 IWUFENG_CHEZHANService
		IWUFENG_CHEZHANService iWUFENG_CHEZHANService;
		public IWUFENG_CHEZHANService IWUFENG_CHEZHANService
		{
			get
			{
				if(iWUFENG_CHEZHANService==null)
					iWUFENG_CHEZHANService= new WUFENG_CHEZHANService();
				return iWUFENG_CHEZHANService;
			}
			set
			{
				iWUFENG_CHEZHANService= value;
			}
		}
		#endregion

    
		#region 618 业务接口 IWUFENG_DANYUANService
		IWUFENG_DANYUANService iWUFENG_DANYUANService;
		public IWUFENG_DANYUANService IWUFENG_DANYUANService
		{
			get
			{
				if(iWUFENG_DANYUANService==null)
					iWUFENG_DANYUANService= new WUFENG_DANYUANService();
				return iWUFENG_DANYUANService;
			}
			set
			{
				iWUFENG_DANYUANService= value;
			}
		}
		#endregion

    
		#region 619 业务接口 IWUFENG_DANYUAN_LISHIService
		IWUFENG_DANYUAN_LISHIService iWUFENG_DANYUAN_LISHIService;
		public IWUFENG_DANYUAN_LISHIService IWUFENG_DANYUAN_LISHIService
		{
			get
			{
				if(iWUFENG_DANYUAN_LISHIService==null)
					iWUFENG_DANYUAN_LISHIService= new WUFENG_DANYUAN_LISHIService();
				return iWUFENG_DANYUAN_LISHIService;
			}
			set
			{
				iWUFENG_DANYUAN_LISHIService= value;
			}
		}
		#endregion

    
		#region 620 业务接口 IWUFENG_DAOCHAService
		IWUFENG_DAOCHAService iWUFENG_DAOCHAService;
		public IWUFENG_DAOCHAService IWUFENG_DAOCHAService
		{
			get
			{
				if(iWUFENG_DAOCHAService==null)
					iWUFENG_DAOCHAService= new WUFENG_DAOCHAService();
				return iWUFENG_DAOCHAService;
			}
			set
			{
				iWUFENG_DAOCHAService= value;
			}
		}
		#endregion

    
		#region 621 业务接口 IWUFENG_JILUService
		IWUFENG_JILUService iWUFENG_JILUService;
		public IWUFENG_JILUService IWUFENG_JILUService
		{
			get
			{
				if(iWUFENG_JILUService==null)
					iWUFENG_JILUService= new WUFENG_JILUService();
				return iWUFENG_JILUService;
			}
			set
			{
				iWUFENG_JILUService= value;
			}
		}
		#endregion

    
		#region 622 业务接口 IWUFENG_XIANMINGService
		IWUFENG_XIANMINGService iWUFENG_XIANMINGService;
		public IWUFENG_XIANMINGService IWUFENG_XIANMINGService
		{
			get
			{
				if(iWUFENG_XIANMINGService==null)
					iWUFENG_XIANMINGService= new WUFENG_XIANMINGService();
				return iWUFENG_XIANMINGService;
			}
			set
			{
				iWUFENG_XIANMINGService= value;
			}
		}
		#endregion

    }

}