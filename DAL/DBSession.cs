
            
using System;   
using System.Collections.Generic;     
using System.Linq;
using System.Text;        
using IDAL;     
namespace DAL 
{     
	public partial class DBSession:IDBSession         
    {     
		#region 01 数据接口 IALL_LINE_DATARepository
		IALL_LINE_DATARepository iALL_LINE_DATARepository;
		public IALL_LINE_DATARepository IALL_LINE_DATARepository
		{
		 
			get 
			{
				if(iALL_LINE_DATARepository==null)
					iALL_LINE_DATARepository= new ALL_LINE_DATARepository();
				return iALL_LINE_DATARepository;
			}
			set
			{
				iALL_LINE_DATARepository= value;
			}
		}
		#endregion

		#region 02 数据接口 IALL_STATION_DATARepository
		IALL_STATION_DATARepository iALL_STATION_DATARepository;
		public IALL_STATION_DATARepository IALL_STATION_DATARepository
		{
		 
			get 
			{
				if(iALL_STATION_DATARepository==null)
					iALL_STATION_DATARepository= new ALL_STATION_DATARepository();
				return iALL_STATION_DATARepository;
			}
			set
			{
				iALL_STATION_DATARepository= value;
			}
		}
		#endregion

		#region 03 数据接口 IALL_VEHTYPE_DATARepository
		IALL_VEHTYPE_DATARepository iALL_VEHTYPE_DATARepository;
		public IALL_VEHTYPE_DATARepository IALL_VEHTYPE_DATARepository
		{
		 
			get 
			{
				if(iALL_VEHTYPE_DATARepository==null)
					iALL_VEHTYPE_DATARepository= new ALL_VEHTYPE_DATARepository();
				return iALL_VEHTYPE_DATARepository;
			}
			set
			{
				iALL_VEHTYPE_DATARepository= value;
			}
		}
		#endregion

		#region 04 数据接口 IALL_VIDEOFILE_DATARepository
		IALL_VIDEOFILE_DATARepository iALL_VIDEOFILE_DATARepository;
		public IALL_VIDEOFILE_DATARepository IALL_VIDEOFILE_DATARepository
		{
		 
			get 
			{
				if(iALL_VIDEOFILE_DATARepository==null)
					iALL_VIDEOFILE_DATARepository= new ALL_VIDEOFILE_DATARepository();
				return iALL_VIDEOFILE_DATARepository;
			}
			set
			{
				iALL_VIDEOFILE_DATARepository= value;
			}
		}
		#endregion

		#region 05 数据接口 IASSET_BASE_ACCOUNTRepository
		IASSET_BASE_ACCOUNTRepository iASSET_BASE_ACCOUNTRepository;
		public IASSET_BASE_ACCOUNTRepository IASSET_BASE_ACCOUNTRepository
		{
		 
			get 
			{
				if(iASSET_BASE_ACCOUNTRepository==null)
					iASSET_BASE_ACCOUNTRepository= new ASSET_BASE_ACCOUNTRepository();
				return iASSET_BASE_ACCOUNTRepository;
			}
			set
			{
				iASSET_BASE_ACCOUNTRepository= value;
			}
		}
		#endregion

		#region 06 数据接口 IASSET_BASE_CATALOGRepository
		IASSET_BASE_CATALOGRepository iASSET_BASE_CATALOGRepository;
		public IASSET_BASE_CATALOGRepository IASSET_BASE_CATALOGRepository
		{
		 
			get 
			{
				if(iASSET_BASE_CATALOGRepository==null)
					iASSET_BASE_CATALOGRepository= new ASSET_BASE_CATALOGRepository();
				return iASSET_BASE_CATALOGRepository;
			}
			set
			{
				iASSET_BASE_CATALOGRepository= value;
			}
		}
		#endregion

		#region 07 数据接口 IASSET_BASE_MATERIAL_DICRepository
		IASSET_BASE_MATERIAL_DICRepository iASSET_BASE_MATERIAL_DICRepository;
		public IASSET_BASE_MATERIAL_DICRepository IASSET_BASE_MATERIAL_DICRepository
		{
		 
			get 
			{
				if(iASSET_BASE_MATERIAL_DICRepository==null)
					iASSET_BASE_MATERIAL_DICRepository= new ASSET_BASE_MATERIAL_DICRepository();
				return iASSET_BASE_MATERIAL_DICRepository;
			}
			set
			{
				iASSET_BASE_MATERIAL_DICRepository= value;
			}
		}
		#endregion

		#region 08 数据接口 IASSET_BASE_RATERepository
		IASSET_BASE_RATERepository iASSET_BASE_RATERepository;
		public IASSET_BASE_RATERepository IASSET_BASE_RATERepository
		{
		 
			get 
			{
				if(iASSET_BASE_RATERepository==null)
					iASSET_BASE_RATERepository= new ASSET_BASE_RATERepository();
				return iASSET_BASE_RATERepository;
			}
			set
			{
				iASSET_BASE_RATERepository= value;
			}
		}
		#endregion

		#region 09 数据接口 IASSET_BASE_RELATION_UNITRepository
		IASSET_BASE_RELATION_UNITRepository iASSET_BASE_RELATION_UNITRepository;
		public IASSET_BASE_RELATION_UNITRepository IASSET_BASE_RELATION_UNITRepository
		{
		 
			get 
			{
				if(iASSET_BASE_RELATION_UNITRepository==null)
					iASSET_BASE_RELATION_UNITRepository= new ASSET_BASE_RELATION_UNITRepository();
				return iASSET_BASE_RELATION_UNITRepository;
			}
			set
			{
				iASSET_BASE_RELATION_UNITRepository= value;
			}
		}
		#endregion

		#region 10 数据接口 IASSET_BASE_SUPPLIERRepository
		IASSET_BASE_SUPPLIERRepository iASSET_BASE_SUPPLIERRepository;
		public IASSET_BASE_SUPPLIERRepository IASSET_BASE_SUPPLIERRepository
		{
		 
			get 
			{
				if(iASSET_BASE_SUPPLIERRepository==null)
					iASSET_BASE_SUPPLIERRepository= new ASSET_BASE_SUPPLIERRepository();
				return iASSET_BASE_SUPPLIERRepository;
			}
			set
			{
				iASSET_BASE_SUPPLIERRepository= value;
			}
		}
		#endregion

		#region 11 数据接口 IASSET_BASE_SUPPLIER_MATERIALRepository
		IASSET_BASE_SUPPLIER_MATERIALRepository iASSET_BASE_SUPPLIER_MATERIALRepository;
		public IASSET_BASE_SUPPLIER_MATERIALRepository IASSET_BASE_SUPPLIER_MATERIALRepository
		{
		 
			get 
			{
				if(iASSET_BASE_SUPPLIER_MATERIALRepository==null)
					iASSET_BASE_SUPPLIER_MATERIALRepository= new ASSET_BASE_SUPPLIER_MATERIALRepository();
				return iASSET_BASE_SUPPLIER_MATERIALRepository;
			}
			set
			{
				iASSET_BASE_SUPPLIER_MATERIALRepository= value;
			}
		}
		#endregion

		#region 12 数据接口 IASSET_INVENTORYRepository
		IASSET_INVENTORYRepository iASSET_INVENTORYRepository;
		public IASSET_INVENTORYRepository IASSET_INVENTORYRepository
		{
		 
			get 
			{
				if(iASSET_INVENTORYRepository==null)
					iASSET_INVENTORYRepository= new ASSET_INVENTORYRepository();
				return iASSET_INVENTORYRepository;
			}
			set
			{
				iASSET_INVENTORYRepository= value;
			}
		}
		#endregion

		#region 13 数据接口 IASSET_MOBILERepository
		IASSET_MOBILERepository iASSET_MOBILERepository;
		public IASSET_MOBILERepository IASSET_MOBILERepository
		{
		 
			get 
			{
				if(iASSET_MOBILERepository==null)
					iASSET_MOBILERepository= new ASSET_MOBILERepository();
				return iASSET_MOBILERepository;
			}
			set
			{
				iASSET_MOBILERepository= value;
			}
		}
		#endregion

		#region 14 数据接口 IASSET_MRPRepository
		IASSET_MRPRepository iASSET_MRPRepository;
		public IASSET_MRPRepository IASSET_MRPRepository
		{
		 
			get 
			{
				if(iASSET_MRPRepository==null)
					iASSET_MRPRepository= new ASSET_MRPRepository();
				return iASSET_MRPRepository;
			}
			set
			{
				iASSET_MRPRepository= value;
			}
		}
		#endregion

		#region 15 数据接口 IASSET_MRP_BOMRepository
		IASSET_MRP_BOMRepository iASSET_MRP_BOMRepository;
		public IASSET_MRP_BOMRepository IASSET_MRP_BOMRepository
		{
		 
			get 
			{
				if(iASSET_MRP_BOMRepository==null)
					iASSET_MRP_BOMRepository= new ASSET_MRP_BOMRepository();
				return iASSET_MRP_BOMRepository;
			}
			set
			{
				iASSET_MRP_BOMRepository= value;
			}
		}
		#endregion

		#region 16 数据接口 IASSET_WAREHOUSERepository
		IASSET_WAREHOUSERepository iASSET_WAREHOUSERepository;
		public IASSET_WAREHOUSERepository IASSET_WAREHOUSERepository
		{
		 
			get 
			{
				if(iASSET_WAREHOUSERepository==null)
					iASSET_WAREHOUSERepository= new ASSET_WAREHOUSERepository();
				return iASSET_WAREHOUSERepository;
			}
			set
			{
				iASSET_WAREHOUSERepository= value;
			}
		}
		#endregion

		#region 17 数据接口 IBASE_BOUNDARYRepository
		IBASE_BOUNDARYRepository iBASE_BOUNDARYRepository;
		public IBASE_BOUNDARYRepository IBASE_BOUNDARYRepository
		{
		 
			get 
			{
				if(iBASE_BOUNDARYRepository==null)
					iBASE_BOUNDARYRepository= new BASE_BOUNDARYRepository();
				return iBASE_BOUNDARYRepository;
			}
			set
			{
				iBASE_BOUNDARYRepository= value;
			}
		}
		#endregion

		#region 18 数据接口 IBASE_DICTRepository
		IBASE_DICTRepository iBASE_DICTRepository;
		public IBASE_DICTRepository IBASE_DICTRepository
		{
		 
			get 
			{
				if(iBASE_DICTRepository==null)
					iBASE_DICTRepository= new BASE_DICTRepository();
				return iBASE_DICTRepository;
			}
			set
			{
				iBASE_DICTRepository= value;
			}
		}
		#endregion

		#region 19 数据接口 IBASE_LINERepository
		IBASE_LINERepository iBASE_LINERepository;
		public IBASE_LINERepository IBASE_LINERepository
		{
		 
			get 
			{
				if(iBASE_LINERepository==null)
					iBASE_LINERepository= new BASE_LINERepository();
				return iBASE_LINERepository;
			}
			set
			{
				iBASE_LINERepository= value;
			}
		}
		#endregion

		#region 20 数据接口 IBASE_STATIONRepository
		IBASE_STATIONRepository iBASE_STATIONRepository;
		public IBASE_STATIONRepository IBASE_STATIONRepository
		{
		 
			get 
			{
				if(iBASE_STATIONRepository==null)
					iBASE_STATIONRepository= new BASE_STATIONRepository();
				return iBASE_STATIONRepository;
			}
			set
			{
				iBASE_STATIONRepository= value;
			}
		}
		#endregion

		#region 21 数据接口 IBOOT_BASERepository
		IBOOT_BASERepository iBOOT_BASERepository;
		public IBOOT_BASERepository IBOOT_BASERepository
		{
		 
			get 
			{
				if(iBOOT_BASERepository==null)
					iBOOT_BASERepository= new BOOT_BASERepository();
				return iBOOT_BASERepository;
			}
			set
			{
				iBOOT_BASERepository= value;
			}
		}
		#endregion

		#region 22 数据接口 IBOOT_RECORDRepository
		IBOOT_RECORDRepository iBOOT_RECORDRepository;
		public IBOOT_RECORDRepository IBOOT_RECORDRepository
		{
		 
			get 
			{
				if(iBOOT_RECORDRepository==null)
					iBOOT_RECORDRepository= new BOOT_RECORDRepository();
				return iBOOT_RECORDRepository;
			}
			set
			{
				iBOOT_RECORDRepository= value;
			}
		}
		#endregion

		#region 23 数据接口 IBRIDGE_BOUNDRepository
		IBRIDGE_BOUNDRepository iBRIDGE_BOUNDRepository;
		public IBRIDGE_BOUNDRepository IBRIDGE_BOUNDRepository
		{
		 
			get 
			{
				if(iBRIDGE_BOUNDRepository==null)
					iBRIDGE_BOUNDRepository= new BRIDGE_BOUNDRepository();
				return iBRIDGE_BOUNDRepository;
			}
			set
			{
				iBRIDGE_BOUNDRepository= value;
			}
		}
		#endregion

		#region 24 数据接口 IBRIDGE_BRIDGERepository
		IBRIDGE_BRIDGERepository iBRIDGE_BRIDGERepository;
		public IBRIDGE_BRIDGERepository IBRIDGE_BRIDGERepository
		{
		 
			get 
			{
				if(iBRIDGE_BRIDGERepository==null)
					iBRIDGE_BRIDGERepository= new BRIDGE_BRIDGERepository();
				return iBRIDGE_BRIDGERepository;
			}
			set
			{
				iBRIDGE_BRIDGERepository= value;
			}
		}
		#endregion

		#region 25 数据接口 IBRIDGE_CULVERTRepository
		IBRIDGE_CULVERTRepository iBRIDGE_CULVERTRepository;
		public IBRIDGE_CULVERTRepository IBRIDGE_CULVERTRepository
		{
		 
			get 
			{
				if(iBRIDGE_CULVERTRepository==null)
					iBRIDGE_CULVERTRepository= new BRIDGE_CULVERTRepository();
				return iBRIDGE_CULVERTRepository;
			}
			set
			{
				iBRIDGE_CULVERTRepository= value;
			}
		}
		#endregion

		#region 26 数据接口 IBRIDGE_EQU_CLEARANCERepository
		IBRIDGE_EQU_CLEARANCERepository iBRIDGE_EQU_CLEARANCERepository;
		public IBRIDGE_EQU_CLEARANCERepository IBRIDGE_EQU_CLEARANCERepository
		{
		 
			get 
			{
				if(iBRIDGE_EQU_CLEARANCERepository==null)
					iBRIDGE_EQU_CLEARANCERepository= new BRIDGE_EQU_CLEARANCERepository();
				return iBRIDGE_EQU_CLEARANCERepository;
			}
			set
			{
				iBRIDGE_EQU_CLEARANCERepository= value;
			}
		}
		#endregion

		#region 27 数据接口 IBRIDGE_EQU_CLEARANCE_FILERepository
		IBRIDGE_EQU_CLEARANCE_FILERepository iBRIDGE_EQU_CLEARANCE_FILERepository;
		public IBRIDGE_EQU_CLEARANCE_FILERepository IBRIDGE_EQU_CLEARANCE_FILERepository
		{
		 
			get 
			{
				if(iBRIDGE_EQU_CLEARANCE_FILERepository==null)
					iBRIDGE_EQU_CLEARANCE_FILERepository= new BRIDGE_EQU_CLEARANCE_FILERepository();
				return iBRIDGE_EQU_CLEARANCE_FILERepository;
			}
			set
			{
				iBRIDGE_EQU_CLEARANCE_FILERepository= value;
			}
		}
		#endregion

		#region 28 数据接口 IBRIDGE_EQU_DATA_TEMPRepository
		IBRIDGE_EQU_DATA_TEMPRepository iBRIDGE_EQU_DATA_TEMPRepository;
		public IBRIDGE_EQU_DATA_TEMPRepository IBRIDGE_EQU_DATA_TEMPRepository
		{
		 
			get 
			{
				if(iBRIDGE_EQU_DATA_TEMPRepository==null)
					iBRIDGE_EQU_DATA_TEMPRepository= new BRIDGE_EQU_DATA_TEMPRepository();
				return iBRIDGE_EQU_DATA_TEMPRepository;
			}
			set
			{
				iBRIDGE_EQU_DATA_TEMPRepository= value;
			}
		}
		#endregion

		#region 29 数据接口 IBRIDGE_EQU_FILERepository
		IBRIDGE_EQU_FILERepository iBRIDGE_EQU_FILERepository;
		public IBRIDGE_EQU_FILERepository IBRIDGE_EQU_FILERepository
		{
		 
			get 
			{
				if(iBRIDGE_EQU_FILERepository==null)
					iBRIDGE_EQU_FILERepository= new BRIDGE_EQU_FILERepository();
				return iBRIDGE_EQU_FILERepository;
			}
			set
			{
				iBRIDGE_EQU_FILERepository= value;
			}
		}
		#endregion

		#region 30 数据接口 IBRIDGE_LIMITOVERHEADRepository
		IBRIDGE_LIMITOVERHEADRepository iBRIDGE_LIMITOVERHEADRepository;
		public IBRIDGE_LIMITOVERHEADRepository IBRIDGE_LIMITOVERHEADRepository
		{
		 
			get 
			{
				if(iBRIDGE_LIMITOVERHEADRepository==null)
					iBRIDGE_LIMITOVERHEADRepository= new BRIDGE_LIMITOVERHEADRepository();
				return iBRIDGE_LIMITOVERHEADRepository;
			}
			set
			{
				iBRIDGE_LIMITOVERHEADRepository= value;
			}
		}
		#endregion

		#region 31 数据接口 IBRIDGE_LRONRepository
		IBRIDGE_LRONRepository iBRIDGE_LRONRepository;
		public IBRIDGE_LRONRepository IBRIDGE_LRONRepository
		{
		 
			get 
			{
				if(iBRIDGE_LRONRepository==null)
					iBRIDGE_LRONRepository= new BRIDGE_LRONRepository();
				return iBRIDGE_LRONRepository;
			}
			set
			{
				iBRIDGE_LRONRepository= value;
			}
		}
		#endregion

		#region 32 数据接口 IBRIDGE_LRON_OVERPASSRepository
		IBRIDGE_LRON_OVERPASSRepository iBRIDGE_LRON_OVERPASSRepository;
		public IBRIDGE_LRON_OVERPASSRepository IBRIDGE_LRON_OVERPASSRepository
		{
		 
			get 
			{
				if(iBRIDGE_LRON_OVERPASSRepository==null)
					iBRIDGE_LRON_OVERPASSRepository= new BRIDGE_LRON_OVERPASSRepository();
				return iBRIDGE_LRON_OVERPASSRepository;
			}
			set
			{
				iBRIDGE_LRON_OVERPASSRepository= value;
			}
		}
		#endregion

		#region 33 数据接口 IBRIDGE_MAINTENAN_EVALUATERepository
		IBRIDGE_MAINTENAN_EVALUATERepository iBRIDGE_MAINTENAN_EVALUATERepository;
		public IBRIDGE_MAINTENAN_EVALUATERepository IBRIDGE_MAINTENAN_EVALUATERepository
		{
		 
			get 
			{
				if(iBRIDGE_MAINTENAN_EVALUATERepository==null)
					iBRIDGE_MAINTENAN_EVALUATERepository= new BRIDGE_MAINTENAN_EVALUATERepository();
				return iBRIDGE_MAINTENAN_EVALUATERepository;
			}
			set
			{
				iBRIDGE_MAINTENAN_EVALUATERepository= value;
			}
		}
		#endregion

		#region 34 数据接口 IBRIDGE_MAINTENAN_NOTICERepository
		IBRIDGE_MAINTENAN_NOTICERepository iBRIDGE_MAINTENAN_NOTICERepository;
		public IBRIDGE_MAINTENAN_NOTICERepository IBRIDGE_MAINTENAN_NOTICERepository
		{
		 
			get 
			{
				if(iBRIDGE_MAINTENAN_NOTICERepository==null)
					iBRIDGE_MAINTENAN_NOTICERepository= new BRIDGE_MAINTENAN_NOTICERepository();
				return iBRIDGE_MAINTENAN_NOTICERepository;
			}
			set
			{
				iBRIDGE_MAINTENAN_NOTICERepository= value;
			}
		}
		#endregion

		#region 35 数据接口 IBRIDGE_MAINTENAN_NOTICE_PRORepository
		IBRIDGE_MAINTENAN_NOTICE_PRORepository iBRIDGE_MAINTENAN_NOTICE_PRORepository;
		public IBRIDGE_MAINTENAN_NOTICE_PRORepository IBRIDGE_MAINTENAN_NOTICE_PRORepository
		{
		 
			get 
			{
				if(iBRIDGE_MAINTENAN_NOTICE_PRORepository==null)
					iBRIDGE_MAINTENAN_NOTICE_PRORepository= new BRIDGE_MAINTENAN_NOTICE_PRORepository();
				return iBRIDGE_MAINTENAN_NOTICE_PRORepository;
			}
			set
			{
				iBRIDGE_MAINTENAN_NOTICE_PRORepository= value;
			}
		}
		#endregion

		#region 36 数据接口 IBRIDGE_MAINTENAN_PRORepository
		IBRIDGE_MAINTENAN_PRORepository iBRIDGE_MAINTENAN_PRORepository;
		public IBRIDGE_MAINTENAN_PRORepository IBRIDGE_MAINTENAN_PRORepository
		{
		 
			get 
			{
				if(iBRIDGE_MAINTENAN_PRORepository==null)
					iBRIDGE_MAINTENAN_PRORepository= new BRIDGE_MAINTENAN_PRORepository();
				return iBRIDGE_MAINTENAN_PRORepository;
			}
			set
			{
				iBRIDGE_MAINTENAN_PRORepository= value;
			}
		}
		#endregion

		#region 37 数据接口 IBRIDGE_MAINTENAN_PRO_HISRepository
		IBRIDGE_MAINTENAN_PRO_HISRepository iBRIDGE_MAINTENAN_PRO_HISRepository;
		public IBRIDGE_MAINTENAN_PRO_HISRepository IBRIDGE_MAINTENAN_PRO_HISRepository
		{
		 
			get 
			{
				if(iBRIDGE_MAINTENAN_PRO_HISRepository==null)
					iBRIDGE_MAINTENAN_PRO_HISRepository= new BRIDGE_MAINTENAN_PRO_HISRepository();
				return iBRIDGE_MAINTENAN_PRO_HISRepository;
			}
			set
			{
				iBRIDGE_MAINTENAN_PRO_HISRepository= value;
			}
		}
		#endregion

		#region 38 数据接口 IBRIDGE_MAINTENAN_REPORTRepository
		IBRIDGE_MAINTENAN_REPORTRepository iBRIDGE_MAINTENAN_REPORTRepository;
		public IBRIDGE_MAINTENAN_REPORTRepository IBRIDGE_MAINTENAN_REPORTRepository
		{
		 
			get 
			{
				if(iBRIDGE_MAINTENAN_REPORTRepository==null)
					iBRIDGE_MAINTENAN_REPORTRepository= new BRIDGE_MAINTENAN_REPORTRepository();
				return iBRIDGE_MAINTENAN_REPORTRepository;
			}
			set
			{
				iBRIDGE_MAINTENAN_REPORTRepository= value;
			}
		}
		#endregion

		#region 39 数据接口 IBRIDGE_MSGRepository
		IBRIDGE_MSGRepository iBRIDGE_MSGRepository;
		public IBRIDGE_MSGRepository IBRIDGE_MSGRepository
		{
		 
			get 
			{
				if(iBRIDGE_MSGRepository==null)
					iBRIDGE_MSGRepository= new BRIDGE_MSGRepository();
				return iBRIDGE_MSGRepository;
			}
			set
			{
				iBRIDGE_MSGRepository= value;
			}
		}
		#endregion

		#region 40 数据接口 IBRIDGE_OTHER_DEVICERepository
		IBRIDGE_OTHER_DEVICERepository iBRIDGE_OTHER_DEVICERepository;
		public IBRIDGE_OTHER_DEVICERepository IBRIDGE_OTHER_DEVICERepository
		{
		 
			get 
			{
				if(iBRIDGE_OTHER_DEVICERepository==null)
					iBRIDGE_OTHER_DEVICERepository= new BRIDGE_OTHER_DEVICERepository();
				return iBRIDGE_OTHER_DEVICERepository;
			}
			set
			{
				iBRIDGE_OTHER_DEVICERepository= value;
			}
		}
		#endregion

		#region 41 数据接口 IBRIDGE_OVERPASSRepository
		IBRIDGE_OVERPASSRepository iBRIDGE_OVERPASSRepository;
		public IBRIDGE_OVERPASSRepository IBRIDGE_OVERPASSRepository
		{
		 
			get 
			{
				if(iBRIDGE_OVERPASSRepository==null)
					iBRIDGE_OVERPASSRepository= new BRIDGE_OVERPASSRepository();
				return iBRIDGE_OVERPASSRepository;
			}
			set
			{
				iBRIDGE_OVERPASSRepository= value;
			}
		}
		#endregion

		#region 42 数据接口 IBRIDGE_OVERPASS_WATERRepository
		IBRIDGE_OVERPASS_WATERRepository iBRIDGE_OVERPASS_WATERRepository;
		public IBRIDGE_OVERPASS_WATERRepository IBRIDGE_OVERPASS_WATERRepository
		{
		 
			get 
			{
				if(iBRIDGE_OVERPASS_WATERRepository==null)
					iBRIDGE_OVERPASS_WATERRepository= new BRIDGE_OVERPASS_WATERRepository();
				return iBRIDGE_OVERPASS_WATERRepository;
			}
			set
			{
				iBRIDGE_OVERPASS_WATERRepository= value;
			}
		}
		#endregion

		#region 43 数据接口 IBRIDGE_PARA_MAINTENANRepository
		IBRIDGE_PARA_MAINTENANRepository iBRIDGE_PARA_MAINTENANRepository;
		public IBRIDGE_PARA_MAINTENANRepository IBRIDGE_PARA_MAINTENANRepository
		{
		 
			get 
			{
				if(iBRIDGE_PARA_MAINTENANRepository==null)
					iBRIDGE_PARA_MAINTENANRepository= new BRIDGE_PARA_MAINTENANRepository();
				return iBRIDGE_PARA_MAINTENANRepository;
			}
			set
			{
				iBRIDGE_PARA_MAINTENANRepository= value;
			}
		}
		#endregion

		#region 44 数据接口 IBRIDGE_PARA_STATUSRepository
		IBRIDGE_PARA_STATUSRepository iBRIDGE_PARA_STATUSRepository;
		public IBRIDGE_PARA_STATUSRepository IBRIDGE_PARA_STATUSRepository
		{
		 
			get 
			{
				if(iBRIDGE_PARA_STATUSRepository==null)
					iBRIDGE_PARA_STATUSRepository= new BRIDGE_PARA_STATUSRepository();
				return iBRIDGE_PARA_STATUSRepository;
			}
			set
			{
				iBRIDGE_PARA_STATUSRepository= value;
			}
		}
		#endregion

		#region 45 数据接口 IBRIDGE_SHALLOW_FOUNDATIONRepository
		IBRIDGE_SHALLOW_FOUNDATIONRepository iBRIDGE_SHALLOW_FOUNDATIONRepository;
		public IBRIDGE_SHALLOW_FOUNDATIONRepository IBRIDGE_SHALLOW_FOUNDATIONRepository
		{
		 
			get 
			{
				if(iBRIDGE_SHALLOW_FOUNDATIONRepository==null)
					iBRIDGE_SHALLOW_FOUNDATIONRepository= new BRIDGE_SHALLOW_FOUNDATIONRepository();
				return iBRIDGE_SHALLOW_FOUNDATIONRepository;
			}
			set
			{
				iBRIDGE_SHALLOW_FOUNDATIONRepository= value;
			}
		}
		#endregion

		#region 46 数据接口 IBRIDGE_STATE_PRORepository
		IBRIDGE_STATE_PRORepository iBRIDGE_STATE_PRORepository;
		public IBRIDGE_STATE_PRORepository IBRIDGE_STATE_PRORepository
		{
		 
			get 
			{
				if(iBRIDGE_STATE_PRORepository==null)
					iBRIDGE_STATE_PRORepository= new BRIDGE_STATE_PRORepository();
				return iBRIDGE_STATE_PRORepository;
			}
			set
			{
				iBRIDGE_STATE_PRORepository= value;
			}
		}
		#endregion

		#region 47 数据接口 IBRIDGE_STATE_PRO_FILERepository
		IBRIDGE_STATE_PRO_FILERepository iBRIDGE_STATE_PRO_FILERepository;
		public IBRIDGE_STATE_PRO_FILERepository IBRIDGE_STATE_PRO_FILERepository
		{
		 
			get 
			{
				if(iBRIDGE_STATE_PRO_FILERepository==null)
					iBRIDGE_STATE_PRO_FILERepository= new BRIDGE_STATE_PRO_FILERepository();
				return iBRIDGE_STATE_PRO_FILERepository;
			}
			set
			{
				iBRIDGE_STATE_PRO_FILERepository= value;
			}
		}
		#endregion

		#region 48 数据接口 IBRIDGE_STATE_PRO_HISRepository
		IBRIDGE_STATE_PRO_HISRepository iBRIDGE_STATE_PRO_HISRepository;
		public IBRIDGE_STATE_PRO_HISRepository IBRIDGE_STATE_PRO_HISRepository
		{
		 
			get 
			{
				if(iBRIDGE_STATE_PRO_HISRepository==null)
					iBRIDGE_STATE_PRO_HISRepository= new BRIDGE_STATE_PRO_HISRepository();
				return iBRIDGE_STATE_PRO_HISRepository;
			}
			set
			{
				iBRIDGE_STATE_PRO_HISRepository= value;
			}
		}
		#endregion

		#region 49 数据接口 IBRIDGE_STATE_REPORTRepository
		IBRIDGE_STATE_REPORTRepository iBRIDGE_STATE_REPORTRepository;
		public IBRIDGE_STATE_REPORTRepository IBRIDGE_STATE_REPORTRepository
		{
		 
			get 
			{
				if(iBRIDGE_STATE_REPORTRepository==null)
					iBRIDGE_STATE_REPORTRepository= new BRIDGE_STATE_REPORTRepository();
				return iBRIDGE_STATE_REPORTRepository;
			}
			set
			{
				iBRIDGE_STATE_REPORTRepository= value;
			}
		}
		#endregion

		#region 50 数据接口 IBRIDGE_TUNNELRepository
		IBRIDGE_TUNNELRepository iBRIDGE_TUNNELRepository;
		public IBRIDGE_TUNNELRepository IBRIDGE_TUNNELRepository
		{
		 
			get 
			{
				if(iBRIDGE_TUNNELRepository==null)
					iBRIDGE_TUNNELRepository= new BRIDGE_TUNNELRepository();
				return iBRIDGE_TUNNELRepository;
			}
			set
			{
				iBRIDGE_TUNNELRepository= value;
			}
		}
		#endregion

		#region 51 数据接口 IBROKENRAIL_BDATA_BOUNDARYRepository
		IBROKENRAIL_BDATA_BOUNDARYRepository iBROKENRAIL_BDATA_BOUNDARYRepository;
		public IBROKENRAIL_BDATA_BOUNDARYRepository IBROKENRAIL_BDATA_BOUNDARYRepository
		{
		 
			get 
			{
				if(iBROKENRAIL_BDATA_BOUNDARYRepository==null)
					iBROKENRAIL_BDATA_BOUNDARYRepository= new BROKENRAIL_BDATA_BOUNDARYRepository();
				return iBROKENRAIL_BDATA_BOUNDARYRepository;
			}
			set
			{
				iBROKENRAIL_BDATA_BOUNDARYRepository= value;
			}
		}
		#endregion

		#region 52 数据接口 IBROKENRAIL_BDATA_DEVICERepository
		IBROKENRAIL_BDATA_DEVICERepository iBROKENRAIL_BDATA_DEVICERepository;
		public IBROKENRAIL_BDATA_DEVICERepository IBROKENRAIL_BDATA_DEVICERepository
		{
		 
			get 
			{
				if(iBROKENRAIL_BDATA_DEVICERepository==null)
					iBROKENRAIL_BDATA_DEVICERepository= new BROKENRAIL_BDATA_DEVICERepository();
				return iBROKENRAIL_BDATA_DEVICERepository;
			}
			set
			{
				iBROKENRAIL_BDATA_DEVICERepository= value;
			}
		}
		#endregion

		#region 53 数据接口 IBROKENRAIL_BDATA_DEVICE_STATUSRepository
		IBROKENRAIL_BDATA_DEVICE_STATUSRepository iBROKENRAIL_BDATA_DEVICE_STATUSRepository;
		public IBROKENRAIL_BDATA_DEVICE_STATUSRepository IBROKENRAIL_BDATA_DEVICE_STATUSRepository
		{
		 
			get 
			{
				if(iBROKENRAIL_BDATA_DEVICE_STATUSRepository==null)
					iBROKENRAIL_BDATA_DEVICE_STATUSRepository= new BROKENRAIL_BDATA_DEVICE_STATUSRepository();
				return iBROKENRAIL_BDATA_DEVICE_STATUSRepository;
			}
			set
			{
				iBROKENRAIL_BDATA_DEVICE_STATUSRepository= value;
			}
		}
		#endregion

		#region 54 数据接口 IBROKENRAIL_BDATA_SECTIONRepository
		IBROKENRAIL_BDATA_SECTIONRepository iBROKENRAIL_BDATA_SECTIONRepository;
		public IBROKENRAIL_BDATA_SECTIONRepository IBROKENRAIL_BDATA_SECTIONRepository
		{
		 
			get 
			{
				if(iBROKENRAIL_BDATA_SECTIONRepository==null)
					iBROKENRAIL_BDATA_SECTIONRepository= new BROKENRAIL_BDATA_SECTIONRepository();
				return iBROKENRAIL_BDATA_SECTIONRepository;
			}
			set
			{
				iBROKENRAIL_BDATA_SECTIONRepository= value;
			}
		}
		#endregion

		#region 55 数据接口 IBROKENRAIL_DEVICE_STATUSRepository
		IBROKENRAIL_DEVICE_STATUSRepository iBROKENRAIL_DEVICE_STATUSRepository;
		public IBROKENRAIL_DEVICE_STATUSRepository IBROKENRAIL_DEVICE_STATUSRepository
		{
		 
			get 
			{
				if(iBROKENRAIL_DEVICE_STATUSRepository==null)
					iBROKENRAIL_DEVICE_STATUSRepository= new BROKENRAIL_DEVICE_STATUSRepository();
				return iBROKENRAIL_DEVICE_STATUSRepository;
			}
			set
			{
				iBROKENRAIL_DEVICE_STATUSRepository= value;
			}
		}
		#endregion

		#region 56 数据接口 IBROKENRAIL_DEVICE_STATUSHISRepository
		IBROKENRAIL_DEVICE_STATUSHISRepository iBROKENRAIL_DEVICE_STATUSHISRepository;
		public IBROKENRAIL_DEVICE_STATUSHISRepository IBROKENRAIL_DEVICE_STATUSHISRepository
		{
		 
			get 
			{
				if(iBROKENRAIL_DEVICE_STATUSHISRepository==null)
					iBROKENRAIL_DEVICE_STATUSHISRepository= new BROKENRAIL_DEVICE_STATUSHISRepository();
				return iBROKENRAIL_DEVICE_STATUSHISRepository;
			}
			set
			{
				iBROKENRAIL_DEVICE_STATUSHISRepository= value;
			}
		}
		#endregion

		#region 57 数据接口 IBROKENRAIL_NEEDSENDRepository
		IBROKENRAIL_NEEDSENDRepository iBROKENRAIL_NEEDSENDRepository;
		public IBROKENRAIL_NEEDSENDRepository IBROKENRAIL_NEEDSENDRepository
		{
		 
			get 
			{
				if(iBROKENRAIL_NEEDSENDRepository==null)
					iBROKENRAIL_NEEDSENDRepository= new BROKENRAIL_NEEDSENDRepository();
				return iBROKENRAIL_NEEDSENDRepository;
			}
			set
			{
				iBROKENRAIL_NEEDSENDRepository= value;
			}
		}
		#endregion

		#region 58 数据接口 IBROKENRAIL_SECTION_LINERepository
		IBROKENRAIL_SECTION_LINERepository iBROKENRAIL_SECTION_LINERepository;
		public IBROKENRAIL_SECTION_LINERepository IBROKENRAIL_SECTION_LINERepository
		{
		 
			get 
			{
				if(iBROKENRAIL_SECTION_LINERepository==null)
					iBROKENRAIL_SECTION_LINERepository= new BROKENRAIL_SECTION_LINERepository();
				return iBROKENRAIL_SECTION_LINERepository;
			}
			set
			{
				iBROKENRAIL_SECTION_LINERepository= value;
			}
		}
		#endregion

		#region 59 数据接口 IBROKENRAIL_SECTION_STATUSRepository
		IBROKENRAIL_SECTION_STATUSRepository iBROKENRAIL_SECTION_STATUSRepository;
		public IBROKENRAIL_SECTION_STATUSRepository IBROKENRAIL_SECTION_STATUSRepository
		{
		 
			get 
			{
				if(iBROKENRAIL_SECTION_STATUSRepository==null)
					iBROKENRAIL_SECTION_STATUSRepository= new BROKENRAIL_SECTION_STATUSRepository();
				return iBROKENRAIL_SECTION_STATUSRepository;
			}
			set
			{
				iBROKENRAIL_SECTION_STATUSRepository= value;
			}
		}
		#endregion

		#region 60 数据接口 IBROKENRAIL_SECTION_STATUSHISRepository
		IBROKENRAIL_SECTION_STATUSHISRepository iBROKENRAIL_SECTION_STATUSHISRepository;
		public IBROKENRAIL_SECTION_STATUSHISRepository IBROKENRAIL_SECTION_STATUSHISRepository
		{
		 
			get 
			{
				if(iBROKENRAIL_SECTION_STATUSHISRepository==null)
					iBROKENRAIL_SECTION_STATUSHISRepository= new BROKENRAIL_SECTION_STATUSHISRepository();
				return iBROKENRAIL_SECTION_STATUSHISRepository;
			}
			set
			{
				iBROKENRAIL_SECTION_STATUSHISRepository= value;
			}
		}
		#endregion

		#region 61 数据接口 IBROKENRAIL_SOUND_SENDPHONERepository
		IBROKENRAIL_SOUND_SENDPHONERepository iBROKENRAIL_SOUND_SENDPHONERepository;
		public IBROKENRAIL_SOUND_SENDPHONERepository IBROKENRAIL_SOUND_SENDPHONERepository
		{
		 
			get 
			{
				if(iBROKENRAIL_SOUND_SENDPHONERepository==null)
					iBROKENRAIL_SOUND_SENDPHONERepository= new BROKENRAIL_SOUND_SENDPHONERepository();
				return iBROKENRAIL_SOUND_SENDPHONERepository;
			}
			set
			{
				iBROKENRAIL_SOUND_SENDPHONERepository= value;
			}
		}
		#endregion

		#region 62 数据接口 IBROKENRAIL_VOLTAGE_SMSRepository
		IBROKENRAIL_VOLTAGE_SMSRepository iBROKENRAIL_VOLTAGE_SMSRepository;
		public IBROKENRAIL_VOLTAGE_SMSRepository IBROKENRAIL_VOLTAGE_SMSRepository
		{
		 
			get 
			{
				if(iBROKENRAIL_VOLTAGE_SMSRepository==null)
					iBROKENRAIL_VOLTAGE_SMSRepository= new BROKENRAIL_VOLTAGE_SMSRepository();
				return iBROKENRAIL_VOLTAGE_SMSRepository;
			}
			set
			{
				iBROKENRAIL_VOLTAGE_SMSRepository= value;
			}
		}
		#endregion

		#region 63 数据接口 IBROKENRAIL_VOLTAGE_STATUSRepository
		IBROKENRAIL_VOLTAGE_STATUSRepository iBROKENRAIL_VOLTAGE_STATUSRepository;
		public IBROKENRAIL_VOLTAGE_STATUSRepository IBROKENRAIL_VOLTAGE_STATUSRepository
		{
		 
			get 
			{
				if(iBROKENRAIL_VOLTAGE_STATUSRepository==null)
					iBROKENRAIL_VOLTAGE_STATUSRepository= new BROKENRAIL_VOLTAGE_STATUSRepository();
				return iBROKENRAIL_VOLTAGE_STATUSRepository;
			}
			set
			{
				iBROKENRAIL_VOLTAGE_STATUSRepository= value;
			}
		}
		#endregion

		#region 64 数据接口 IBROKENRAIL_VOLTAGE_STATUSHISRepository
		IBROKENRAIL_VOLTAGE_STATUSHISRepository iBROKENRAIL_VOLTAGE_STATUSHISRepository;
		public IBROKENRAIL_VOLTAGE_STATUSHISRepository IBROKENRAIL_VOLTAGE_STATUSHISRepository
		{
		 
			get 
			{
				if(iBROKENRAIL_VOLTAGE_STATUSHISRepository==null)
					iBROKENRAIL_VOLTAGE_STATUSHISRepository= new BROKENRAIL_VOLTAGE_STATUSHISRepository();
				return iBROKENRAIL_VOLTAGE_STATUSHISRepository;
			}
			set
			{
				iBROKENRAIL_VOLTAGE_STATUSHISRepository= value;
			}
		}
		#endregion

		#region 65 数据接口 IBROKENRAIL_WARN_CONTROLRepository
		IBROKENRAIL_WARN_CONTROLRepository iBROKENRAIL_WARN_CONTROLRepository;
		public IBROKENRAIL_WARN_CONTROLRepository IBROKENRAIL_WARN_CONTROLRepository
		{
		 
			get 
			{
				if(iBROKENRAIL_WARN_CONTROLRepository==null)
					iBROKENRAIL_WARN_CONTROLRepository= new BROKENRAIL_WARN_CONTROLRepository();
				return iBROKENRAIL_WARN_CONTROLRepository;
			}
			set
			{
				iBROKENRAIL_WARN_CONTROLRepository= value;
			}
		}
		#endregion

		#region 66 数据接口 IBROKENRAIL_WARN_DEVICERepository
		IBROKENRAIL_WARN_DEVICERepository iBROKENRAIL_WARN_DEVICERepository;
		public IBROKENRAIL_WARN_DEVICERepository IBROKENRAIL_WARN_DEVICERepository
		{
		 
			get 
			{
				if(iBROKENRAIL_WARN_DEVICERepository==null)
					iBROKENRAIL_WARN_DEVICERepository= new BROKENRAIL_WARN_DEVICERepository();
				return iBROKENRAIL_WARN_DEVICERepository;
			}
			set
			{
				iBROKENRAIL_WARN_DEVICERepository= value;
			}
		}
		#endregion

		#region 67 数据接口 IBROKENRAIL_WARN_FLAGRepository
		IBROKENRAIL_WARN_FLAGRepository iBROKENRAIL_WARN_FLAGRepository;
		public IBROKENRAIL_WARN_FLAGRepository IBROKENRAIL_WARN_FLAGRepository
		{
		 
			get 
			{
				if(iBROKENRAIL_WARN_FLAGRepository==null)
					iBROKENRAIL_WARN_FLAGRepository= new BROKENRAIL_WARN_FLAGRepository();
				return iBROKENRAIL_WARN_FLAGRepository;
			}
			set
			{
				iBROKENRAIL_WARN_FLAGRepository= value;
			}
		}
		#endregion

		#region 68 数据接口 ICAR_BDATA_CARRepository
		ICAR_BDATA_CARRepository iCAR_BDATA_CARRepository;
		public ICAR_BDATA_CARRepository ICAR_BDATA_CARRepository
		{
		 
			get 
			{
				if(iCAR_BDATA_CARRepository==null)
					iCAR_BDATA_CARRepository= new CAR_BDATA_CARRepository();
				return iCAR_BDATA_CARRepository;
			}
			set
			{
				iCAR_BDATA_CARRepository= value;
			}
		}
		#endregion

		#region 69 数据接口 ICAR_LAST_LONLATRepository
		ICAR_LAST_LONLATRepository iCAR_LAST_LONLATRepository;
		public ICAR_LAST_LONLATRepository ICAR_LAST_LONLATRepository
		{
		 
			get 
			{
				if(iCAR_LAST_LONLATRepository==null)
					iCAR_LAST_LONLATRepository= new CAR_LAST_LONLATRepository();
				return iCAR_LAST_LONLATRepository;
			}
			set
			{
				iCAR_LAST_LONLATRepository= value;
			}
		}
		#endregion

		#region 70 数据接口 ICAR_OVER_SPEEDRepository
		ICAR_OVER_SPEEDRepository iCAR_OVER_SPEEDRepository;
		public ICAR_OVER_SPEEDRepository ICAR_OVER_SPEEDRepository
		{
		 
			get 
			{
				if(iCAR_OVER_SPEEDRepository==null)
					iCAR_OVER_SPEEDRepository= new CAR_OVER_SPEEDRepository();
				return iCAR_OVER_SPEEDRepository;
			}
			set
			{
				iCAR_OVER_SPEEDRepository= value;
			}
		}
		#endregion

		#region 71 数据接口 ICAR_OVERSPEED_WARNRepository
		ICAR_OVERSPEED_WARNRepository iCAR_OVERSPEED_WARNRepository;
		public ICAR_OVERSPEED_WARNRepository ICAR_OVERSPEED_WARNRepository
		{
		 
			get 
			{
				if(iCAR_OVERSPEED_WARNRepository==null)
					iCAR_OVERSPEED_WARNRepository= new CAR_OVERSPEED_WARNRepository();
				return iCAR_OVERSPEED_WARNRepository;
			}
			set
			{
				iCAR_OVERSPEED_WARNRepository= value;
			}
		}
		#endregion

		#region 72 数据接口 ICAR_PHONE_INFORepository
		ICAR_PHONE_INFORepository iCAR_PHONE_INFORepository;
		public ICAR_PHONE_INFORepository ICAR_PHONE_INFORepository
		{
		 
			get 
			{
				if(iCAR_PHONE_INFORepository==null)
					iCAR_PHONE_INFORepository= new CAR_PHONE_INFORepository();
				return iCAR_PHONE_INFORepository;
			}
			set
			{
				iCAR_PHONE_INFORepository= value;
			}
		}
		#endregion

		#region 73 数据接口 ICHARTRepository
		ICHARTRepository iCHARTRepository;
		public ICHARTRepository ICHARTRepository
		{
		 
			get 
			{
				if(iCHARTRepository==null)
					iCHARTRepository= new CHARTRepository();
				return iCHARTRepository;
			}
			set
			{
				iCHARTRepository= value;
			}
		}
		#endregion

		#region 74 数据接口 ICHK_BDATA_DEVICERepository
		ICHK_BDATA_DEVICERepository iCHK_BDATA_DEVICERepository;
		public ICHK_BDATA_DEVICERepository ICHK_BDATA_DEVICERepository
		{
		 
			get 
			{
				if(iCHK_BDATA_DEVICERepository==null)
					iCHK_BDATA_DEVICERepository= new CHK_BDATA_DEVICERepository();
				return iCHK_BDATA_DEVICERepository;
			}
			set
			{
				iCHK_BDATA_DEVICERepository= value;
			}
		}
		#endregion

		#region 75 数据接口 ICOMMAND_PUBLISHRepository
		ICOMMAND_PUBLISHRepository iCOMMAND_PUBLISHRepository;
		public ICOMMAND_PUBLISHRepository ICOMMAND_PUBLISHRepository
		{
		 
			get 
			{
				if(iCOMMAND_PUBLISHRepository==null)
					iCOMMAND_PUBLISHRepository= new COMMAND_PUBLISHRepository();
				return iCOMMAND_PUBLISHRepository;
			}
			set
			{
				iCOMMAND_PUBLISHRepository= value;
			}
		}
		#endregion

		#region 76 数据接口 ICOMMAND_PUBLISH_HISRepository
		ICOMMAND_PUBLISH_HISRepository iCOMMAND_PUBLISH_HISRepository;
		public ICOMMAND_PUBLISH_HISRepository ICOMMAND_PUBLISH_HISRepository
		{
		 
			get 
			{
				if(iCOMMAND_PUBLISH_HISRepository==null)
					iCOMMAND_PUBLISH_HISRepository= new COMMAND_PUBLISH_HISRepository();
				return iCOMMAND_PUBLISH_HISRepository;
			}
			set
			{
				iCOMMAND_PUBLISH_HISRepository= value;
			}
		}
		#endregion

		#region 77 数据接口 ICONFIR_CARRepository
		ICONFIR_CARRepository iCONFIR_CARRepository;
		public ICONFIR_CARRepository ICONFIR_CARRepository
		{
		 
			get 
			{
				if(iCONFIR_CARRepository==null)
					iCONFIR_CARRepository= new CONFIR_CARRepository();
				return iCONFIR_CARRepository;
			}
			set
			{
				iCONFIR_CARRepository= value;
			}
		}
		#endregion

		#region 78 数据接口 ICONFIR_CAR_PLANRepository
		ICONFIR_CAR_PLANRepository iCONFIR_CAR_PLANRepository;
		public ICONFIR_CAR_PLANRepository ICONFIR_CAR_PLANRepository
		{
		 
			get 
			{
				if(iCONFIR_CAR_PLANRepository==null)
					iCONFIR_CAR_PLANRepository= new CONFIR_CAR_PLANRepository();
				return iCONFIR_CAR_PLANRepository;
			}
			set
			{
				iCONFIR_CAR_PLANRepository= value;
			}
		}
		#endregion

		#region 79 数据接口 ICONFIR_CAR_WARNRepository
		ICONFIR_CAR_WARNRepository iCONFIR_CAR_WARNRepository;
		public ICONFIR_CAR_WARNRepository ICONFIR_CAR_WARNRepository
		{
		 
			get 
			{
				if(iCONFIR_CAR_WARNRepository==null)
					iCONFIR_CAR_WARNRepository= new CONFIR_CAR_WARNRepository();
				return iCONFIR_CAR_WARNRepository;
			}
			set
			{
				iCONFIR_CAR_WARNRepository= value;
			}
		}
		#endregion

		#region 80 数据接口 ICONTROL_FOUR_DICRepository
		ICONTROL_FOUR_DICRepository iCONTROL_FOUR_DICRepository;
		public ICONTROL_FOUR_DICRepository ICONTROL_FOUR_DICRepository
		{
		 
			get 
			{
				if(iCONTROL_FOUR_DICRepository==null)
					iCONTROL_FOUR_DICRepository= new CONTROL_FOUR_DICRepository();
				return iCONTROL_FOUR_DICRepository;
			}
			set
			{
				iCONTROL_FOUR_DICRepository= value;
			}
		}
		#endregion

		#region 81 数据接口 ICONTROL_FOUR_PLANRepository
		ICONTROL_FOUR_PLANRepository iCONTROL_FOUR_PLANRepository;
		public ICONTROL_FOUR_PLANRepository ICONTROL_FOUR_PLANRepository
		{
		 
			get 
			{
				if(iCONTROL_FOUR_PLANRepository==null)
					iCONTROL_FOUR_PLANRepository= new CONTROL_FOUR_PLANRepository();
				return iCONTROL_FOUR_PLANRepository;
			}
			set
			{
				iCONTROL_FOUR_PLANRepository= value;
			}
		}
		#endregion

		#region 82 数据接口 ICURVE_BASERepository
		ICURVE_BASERepository iCURVE_BASERepository;
		public ICURVE_BASERepository ICURVE_BASERepository
		{
		 
			get 
			{
				if(iCURVE_BASERepository==null)
					iCURVE_BASERepository= new CURVE_BASERepository();
				return iCURVE_BASERepository;
			}
			set
			{
				iCURVE_BASERepository= value;
			}
		}
		#endregion

		#region 83 数据接口 ICURVE_BASE_EXTRepository
		ICURVE_BASE_EXTRepository iCURVE_BASE_EXTRepository;
		public ICURVE_BASE_EXTRepository ICURVE_BASE_EXTRepository
		{
		 
			get 
			{
				if(iCURVE_BASE_EXTRepository==null)
					iCURVE_BASE_EXTRepository= new CURVE_BASE_EXTRepository();
				return iCURVE_BASE_EXTRepository;
			}
			set
			{
				iCURVE_BASE_EXTRepository= value;
			}
		}
		#endregion

		#region 84 数据接口 ICURVE_CWRRepository
		ICURVE_CWRRepository iCURVE_CWRRepository;
		public ICURVE_CWRRepository ICURVE_CWRRepository
		{
		 
			get 
			{
				if(iCURVE_CWRRepository==null)
					iCURVE_CWRRepository= new CURVE_CWRRepository();
				return iCURVE_CWRRepository;
			}
			set
			{
				iCURVE_CWRRepository= value;
			}
		}
		#endregion

		#region 85 数据接口 ICURVE_PICRepository
		ICURVE_PICRepository iCURVE_PICRepository;
		public ICURVE_PICRepository ICURVE_PICRepository
		{
		 
			get 
			{
				if(iCURVE_PICRepository==null)
					iCURVE_PICRepository= new CURVE_PICRepository();
				return iCURVE_PICRepository;
			}
			set
			{
				iCURVE_PICRepository= value;
			}
		}
		#endregion

		#region 86 数据接口 ICURVE_PSNRepository
		ICURVE_PSNRepository iCURVE_PSNRepository;
		public ICURVE_PSNRepository ICURVE_PSNRepository
		{
		 
			get 
			{
				if(iCURVE_PSNRepository==null)
					iCURVE_PSNRepository= new CURVE_PSNRepository();
				return iCURVE_PSNRepository;
			}
			set
			{
				iCURVE_PSNRepository= value;
			}
		}
		#endregion

		#region 87 数据接口 ICURVE_RAILRepository
		ICURVE_RAILRepository iCURVE_RAILRepository;
		public ICURVE_RAILRepository ICURVE_RAILRepository
		{
		 
			get 
			{
				if(iCURVE_RAILRepository==null)
					iCURVE_RAILRepository= new CURVE_RAILRepository();
				return iCURVE_RAILRepository;
			}
			set
			{
				iCURVE_RAILRepository= value;
			}
		}
		#endregion

		#region 88 数据接口 ICURVE_RAILWEARRepository
		ICURVE_RAILWEARRepository iCURVE_RAILWEARRepository;
		public ICURVE_RAILWEARRepository ICURVE_RAILWEARRepository
		{
		 
			get 
			{
				if(iCURVE_RAILWEARRepository==null)
					iCURVE_RAILWEARRepository= new CURVE_RAILWEARRepository();
				return iCURVE_RAILWEARRepository;
			}
			set
			{
				iCURVE_RAILWEARRepository= value;
			}
		}
		#endregion

		#region 89 数据接口 IDR_IDX_DOC_CONTENT_IRepository
		IDR_IDX_DOC_CONTENT_IRepository iDR_IDX_DOC_CONTENT_IRepository;
		public IDR_IDX_DOC_CONTENT_IRepository IDR_IDX_DOC_CONTENT_IRepository
		{
		 
			get 
			{
				if(iDR_IDX_DOC_CONTENT_IRepository==null)
					iDR_IDX_DOC_CONTENT_IRepository= new DR_IDX_DOC_CONTENT_IRepository();
				return iDR_IDX_DOC_CONTENT_IRepository;
			}
			set
			{
				iDR_IDX_DOC_CONTENT_IRepository= value;
			}
		}
		#endregion

		#region 90 数据接口 IDR_IDX_DOC_CONTENT_KRepository
		IDR_IDX_DOC_CONTENT_KRepository iDR_IDX_DOC_CONTENT_KRepository;
		public IDR_IDX_DOC_CONTENT_KRepository IDR_IDX_DOC_CONTENT_KRepository
		{
		 
			get 
			{
				if(iDR_IDX_DOC_CONTENT_KRepository==null)
					iDR_IDX_DOC_CONTENT_KRepository= new DR_IDX_DOC_CONTENT_KRepository();
				return iDR_IDX_DOC_CONTENT_KRepository;
			}
			set
			{
				iDR_IDX_DOC_CONTENT_KRepository= value;
			}
		}
		#endregion

		#region 91 数据接口 IDR_IDX_DOC_CONTENT_NRepository
		IDR_IDX_DOC_CONTENT_NRepository iDR_IDX_DOC_CONTENT_NRepository;
		public IDR_IDX_DOC_CONTENT_NRepository IDR_IDX_DOC_CONTENT_NRepository
		{
		 
			get 
			{
				if(iDR_IDX_DOC_CONTENT_NRepository==null)
					iDR_IDX_DOC_CONTENT_NRepository= new DR_IDX_DOC_CONTENT_NRepository();
				return iDR_IDX_DOC_CONTENT_NRepository;
			}
			set
			{
				iDR_IDX_DOC_CONTENT_NRepository= value;
			}
		}
		#endregion

		#region 92 数据接口 IDR_IDX_DOC_CONTENT_RRepository
		IDR_IDX_DOC_CONTENT_RRepository iDR_IDX_DOC_CONTENT_RRepository;
		public IDR_IDX_DOC_CONTENT_RRepository IDR_IDX_DOC_CONTENT_RRepository
		{
		 
			get 
			{
				if(iDR_IDX_DOC_CONTENT_RRepository==null)
					iDR_IDX_DOC_CONTENT_RRepository= new DR_IDX_DOC_CONTENT_RRepository();
				return iDR_IDX_DOC_CONTENT_RRepository;
			}
			set
			{
				iDR_IDX_DOC_CONTENT_RRepository= value;
			}
		}
		#endregion

		#region 93 数据接口 IEMERGENCY_MERCYRepository
		IEMERGENCY_MERCYRepository iEMERGENCY_MERCYRepository;
		public IEMERGENCY_MERCYRepository IEMERGENCY_MERCYRepository
		{
		 
			get 
			{
				if(iEMERGENCY_MERCYRepository==null)
					iEMERGENCY_MERCYRepository= new EMERGENCY_MERCYRepository();
				return iEMERGENCY_MERCYRepository;
			}
			set
			{
				iEMERGENCY_MERCYRepository= value;
			}
		}
		#endregion

		#region 94 数据接口 IEMERGENCY_RECRepository
		IEMERGENCY_RECRepository iEMERGENCY_RECRepository;
		public IEMERGENCY_RECRepository IEMERGENCY_RECRepository
		{
		 
			get 
			{
				if(iEMERGENCY_RECRepository==null)
					iEMERGENCY_RECRepository= new EMERGENCY_RECRepository();
				return iEMERGENCY_RECRepository;
			}
			set
			{
				iEMERGENCY_RECRepository= value;
			}
		}
		#endregion

		#region 95 数据接口 IEMERGENCY_REC_FILERepository
		IEMERGENCY_REC_FILERepository iEMERGENCY_REC_FILERepository;
		public IEMERGENCY_REC_FILERepository IEMERGENCY_REC_FILERepository
		{
		 
			get 
			{
				if(iEMERGENCY_REC_FILERepository==null)
					iEMERGENCY_REC_FILERepository= new EMERGENCY_REC_FILERepository();
				return iEMERGENCY_REC_FILERepository;
			}
			set
			{
				iEMERGENCY_REC_FILERepository= value;
			}
		}
		#endregion

		#region 96 数据接口 IEMERGENCY_REC_PHOTORepository
		IEMERGENCY_REC_PHOTORepository iEMERGENCY_REC_PHOTORepository;
		public IEMERGENCY_REC_PHOTORepository IEMERGENCY_REC_PHOTORepository
		{
		 
			get 
			{
				if(iEMERGENCY_REC_PHOTORepository==null)
					iEMERGENCY_REC_PHOTORepository= new EMERGENCY_REC_PHOTORepository();
				return iEMERGENCY_REC_PHOTORepository;
			}
			set
			{
				iEMERGENCY_REC_PHOTORepository= value;
			}
		}
		#endregion

		#region 97 数据接口 IEMERGENCY_RESCUERepository
		IEMERGENCY_RESCUERepository iEMERGENCY_RESCUERepository;
		public IEMERGENCY_RESCUERepository IEMERGENCY_RESCUERepository
		{
		 
			get 
			{
				if(iEMERGENCY_RESCUERepository==null)
					iEMERGENCY_RESCUERepository= new EMERGENCY_RESCUERepository();
				return iEMERGENCY_RESCUERepository;
			}
			set
			{
				iEMERGENCY_RESCUERepository= value;
			}
		}
		#endregion

		#region 98 数据接口 IEMERGENCY_RESCUE_TOOLRepository
		IEMERGENCY_RESCUE_TOOLRepository iEMERGENCY_RESCUE_TOOLRepository;
		public IEMERGENCY_RESCUE_TOOLRepository IEMERGENCY_RESCUE_TOOLRepository
		{
		 
			get 
			{
				if(iEMERGENCY_RESCUE_TOOLRepository==null)
					iEMERGENCY_RESCUE_TOOLRepository= new EMERGENCY_RESCUE_TOOLRepository();
				return iEMERGENCY_RESCUE_TOOLRepository;
			}
			set
			{
				iEMERGENCY_RESCUE_TOOLRepository= value;
			}
		}
		#endregion

		#region 99 数据接口 IEMERGENCY_RULESRepository
		IEMERGENCY_RULESRepository iEMERGENCY_RULESRepository;
		public IEMERGENCY_RULESRepository IEMERGENCY_RULESRepository
		{
		 
			get 
			{
				if(iEMERGENCY_RULESRepository==null)
					iEMERGENCY_RULESRepository= new EMERGENCY_RULESRepository();
				return iEMERGENCY_RULESRepository;
			}
			set
			{
				iEMERGENCY_RULESRepository= value;
			}
		}
		#endregion

		#region 100 数据接口 IEMERGENCY_TALENT_POOLRepository
		IEMERGENCY_TALENT_POOLRepository iEMERGENCY_TALENT_POOLRepository;
		public IEMERGENCY_TALENT_POOLRepository IEMERGENCY_TALENT_POOLRepository
		{
		 
			get 
			{
				if(iEMERGENCY_TALENT_POOLRepository==null)
					iEMERGENCY_TALENT_POOLRepository= new EMERGENCY_TALENT_POOLRepository();
				return iEMERGENCY_TALENT_POOLRepository;
			}
			set
			{
				iEMERGENCY_TALENT_POOLRepository= value;
			}
		}
		#endregion

		#region 101 数据接口 IEMERGENCY_VIECHLERepository
		IEMERGENCY_VIECHLERepository iEMERGENCY_VIECHLERepository;
		public IEMERGENCY_VIECHLERepository IEMERGENCY_VIECHLERepository
		{
		 
			get 
			{
				if(iEMERGENCY_VIECHLERepository==null)
					iEMERGENCY_VIECHLERepository= new EMERGENCY_VIECHLERepository();
				return iEMERGENCY_VIECHLERepository;
			}
			set
			{
				iEMERGENCY_VIECHLERepository= value;
			}
		}
		#endregion

		#region 102 数据接口 IENFORCEMENT_BDATARepository
		IENFORCEMENT_BDATARepository iENFORCEMENT_BDATARepository;
		public IENFORCEMENT_BDATARepository IENFORCEMENT_BDATARepository
		{
		 
			get 
			{
				if(iENFORCEMENT_BDATARepository==null)
					iENFORCEMENT_BDATARepository= new ENFORCEMENT_BDATARepository();
				return iENFORCEMENT_BDATARepository;
			}
			set
			{
				iENFORCEMENT_BDATARepository= value;
			}
		}
		#endregion

		#region 103 数据接口 IENFORCEMENT_BDATA_ONLINERepository
		IENFORCEMENT_BDATA_ONLINERepository iENFORCEMENT_BDATA_ONLINERepository;
		public IENFORCEMENT_BDATA_ONLINERepository IENFORCEMENT_BDATA_ONLINERepository
		{
		 
			get 
			{
				if(iENFORCEMENT_BDATA_ONLINERepository==null)
					iENFORCEMENT_BDATA_ONLINERepository= new ENFORCEMENT_BDATA_ONLINERepository();
				return iENFORCEMENT_BDATA_ONLINERepository;
			}
			set
			{
				iENFORCEMENT_BDATA_ONLINERepository= value;
			}
		}
		#endregion

		#region 104 数据接口 IENFORCEMENT_FILERepository
		IENFORCEMENT_FILERepository iENFORCEMENT_FILERepository;
		public IENFORCEMENT_FILERepository IENFORCEMENT_FILERepository
		{
		 
			get 
			{
				if(iENFORCEMENT_FILERepository==null)
					iENFORCEMENT_FILERepository= new ENFORCEMENT_FILERepository();
				return iENFORCEMENT_FILERepository;
			}
			set
			{
				iENFORCEMENT_FILERepository= value;
			}
		}
		#endregion

		#region 105 数据接口 IFIVET_INFORepository
		IFIVET_INFORepository iFIVET_INFORepository;
		public IFIVET_INFORepository IFIVET_INFORepository
		{
		 
			get 
			{
				if(iFIVET_INFORepository==null)
					iFIVET_INFORepository= new FIVET_INFORepository();
				return iFIVET_INFORepository;
			}
			set
			{
				iFIVET_INFORepository= value;
			}
		}
		#endregion

		#region 106 数据接口 IFIVET_INFO_FILERepository
		IFIVET_INFO_FILERepository iFIVET_INFO_FILERepository;
		public IFIVET_INFO_FILERepository IFIVET_INFO_FILERepository
		{
		 
			get 
			{
				if(iFIVET_INFO_FILERepository==null)
					iFIVET_INFO_FILERepository= new FIVET_INFO_FILERepository();
				return iFIVET_INFO_FILERepository;
			}
			set
			{
				iFIVET_INFO_FILERepository= value;
			}
		}
		#endregion

		#region 107 数据接口 IFIVET_INFO_PHOTORepository
		IFIVET_INFO_PHOTORepository iFIVET_INFO_PHOTORepository;
		public IFIVET_INFO_PHOTORepository IFIVET_INFO_PHOTORepository
		{
		 
			get 
			{
				if(iFIVET_INFO_PHOTORepository==null)
					iFIVET_INFO_PHOTORepository= new FIVET_INFO_PHOTORepository();
				return iFIVET_INFO_PHOTORepository;
			}
			set
			{
				iFIVET_INFO_PHOTORepository= value;
			}
		}
		#endregion

		#region 108 数据接口 IFIVET_INFO_TYPERepository
		IFIVET_INFO_TYPERepository iFIVET_INFO_TYPERepository;
		public IFIVET_INFO_TYPERepository IFIVET_INFO_TYPERepository
		{
		 
			get 
			{
				if(iFIVET_INFO_TYPERepository==null)
					iFIVET_INFO_TYPERepository= new FIVET_INFO_TYPERepository();
				return iFIVET_INFO_TYPERepository;
			}
			set
			{
				iFIVET_INFO_TYPERepository= value;
			}
		}
		#endregion

		#region 109 数据接口 IFIVET_INFO_VIDEORepository
		IFIVET_INFO_VIDEORepository iFIVET_INFO_VIDEORepository;
		public IFIVET_INFO_VIDEORepository IFIVET_INFO_VIDEORepository
		{
		 
			get 
			{
				if(iFIVET_INFO_VIDEORepository==null)
					iFIVET_INFO_VIDEORepository= new FIVET_INFO_VIDEORepository();
				return iFIVET_INFO_VIDEORepository;
			}
			set
			{
				iFIVET_INFO_VIDEORepository= value;
			}
		}
		#endregion

		#region 110 数据接口 IFLOODPOINTRepository
		IFLOODPOINTRepository iFLOODPOINTRepository;
		public IFLOODPOINTRepository IFLOODPOINTRepository
		{
		 
			get 
			{
				if(iFLOODPOINTRepository==null)
					iFLOODPOINTRepository= new FLOODPOINTRepository();
				return iFLOODPOINTRepository;
			}
			set
			{
				iFLOODPOINTRepository= value;
			}
		}
		#endregion

		#region 111 数据接口 IFLOW_BASERepository
		IFLOW_BASERepository iFLOW_BASERepository;
		public IFLOW_BASERepository IFLOW_BASERepository
		{
		 
			get 
			{
				if(iFLOW_BASERepository==null)
					iFLOW_BASERepository= new FLOW_BASERepository();
				return iFLOW_BASERepository;
			}
			set
			{
				iFLOW_BASERepository= value;
			}
		}
		#endregion

		#region 112 数据接口 IFLOW_JOBRepository
		IFLOW_JOBRepository iFLOW_JOBRepository;
		public IFLOW_JOBRepository IFLOW_JOBRepository
		{
		 
			get 
			{
				if(iFLOW_JOBRepository==null)
					iFLOW_JOBRepository= new FLOW_JOBRepository();
				return iFLOW_JOBRepository;
			}
			set
			{
				iFLOW_JOBRepository= value;
			}
		}
		#endregion

		#region 113 数据接口 IFLOW_STEPRepository
		IFLOW_STEPRepository iFLOW_STEPRepository;
		public IFLOW_STEPRepository IFLOW_STEPRepository
		{
		 
			get 
			{
				if(iFLOW_STEPRepository==null)
					iFLOW_STEPRepository= new FLOW_STEPRepository();
				return iFLOW_STEPRepository;
			}
			set
			{
				iFLOW_STEPRepository= value;
			}
		}
		#endregion

		#region 114 数据接口 IGATE_BDATA_CARDRepository
		IGATE_BDATA_CARDRepository iGATE_BDATA_CARDRepository;
		public IGATE_BDATA_CARDRepository IGATE_BDATA_CARDRepository
		{
		 
			get 
			{
				if(iGATE_BDATA_CARDRepository==null)
					iGATE_BDATA_CARDRepository= new GATE_BDATA_CARDRepository();
				return iGATE_BDATA_CARDRepository;
			}
			set
			{
				iGATE_BDATA_CARDRepository= value;
			}
		}
		#endregion

		#region 115 数据接口 IGATE_BDATA_CLIENTRepository
		IGATE_BDATA_CLIENTRepository iGATE_BDATA_CLIENTRepository;
		public IGATE_BDATA_CLIENTRepository IGATE_BDATA_CLIENTRepository
		{
		 
			get 
			{
				if(iGATE_BDATA_CLIENTRepository==null)
					iGATE_BDATA_CLIENTRepository= new GATE_BDATA_CLIENTRepository();
				return iGATE_BDATA_CLIENTRepository;
			}
			set
			{
				iGATE_BDATA_CLIENTRepository= value;
			}
		}
		#endregion

		#region 116 数据接口 IGATE_BDATA_DICRepository
		IGATE_BDATA_DICRepository iGATE_BDATA_DICRepository;
		public IGATE_BDATA_DICRepository IGATE_BDATA_DICRepository
		{
		 
			get 
			{
				if(iGATE_BDATA_DICRepository==null)
					iGATE_BDATA_DICRepository= new GATE_BDATA_DICRepository();
				return iGATE_BDATA_DICRepository;
			}
			set
			{
				iGATE_BDATA_DICRepository= value;
			}
		}
		#endregion

		#region 117 数据接口 IGATE_BDATA_GATERepository
		IGATE_BDATA_GATERepository iGATE_BDATA_GATERepository;
		public IGATE_BDATA_GATERepository IGATE_BDATA_GATERepository
		{
		 
			get 
			{
				if(iGATE_BDATA_GATERepository==null)
					iGATE_BDATA_GATERepository= new GATE_BDATA_GATERepository();
				return iGATE_BDATA_GATERepository;
			}
			set
			{
				iGATE_BDATA_GATERepository= value;
			}
		}
		#endregion

		#region 118 数据接口 IGATE_BDATA_LIMITRepository
		IGATE_BDATA_LIMITRepository iGATE_BDATA_LIMITRepository;
		public IGATE_BDATA_LIMITRepository IGATE_BDATA_LIMITRepository
		{
		 
			get 
			{
				if(iGATE_BDATA_LIMITRepository==null)
					iGATE_BDATA_LIMITRepository= new GATE_BDATA_LIMITRepository();
				return iGATE_BDATA_LIMITRepository;
			}
			set
			{
				iGATE_BDATA_LIMITRepository= value;
			}
		}
		#endregion

		#region 119 数据接口 IGATE_BDATA_SKYLIGHTRepository
		IGATE_BDATA_SKYLIGHTRepository iGATE_BDATA_SKYLIGHTRepository;
		public IGATE_BDATA_SKYLIGHTRepository IGATE_BDATA_SKYLIGHTRepository
		{
		 
			get 
			{
				if(iGATE_BDATA_SKYLIGHTRepository==null)
					iGATE_BDATA_SKYLIGHTRepository= new GATE_BDATA_SKYLIGHTRepository();
				return iGATE_BDATA_SKYLIGHTRepository;
			}
			set
			{
				iGATE_BDATA_SKYLIGHTRepository= value;
			}
		}
		#endregion

		#region 120 数据接口 IGATE_BDATA_TOOLRepository
		IGATE_BDATA_TOOLRepository iGATE_BDATA_TOOLRepository;
		public IGATE_BDATA_TOOLRepository IGATE_BDATA_TOOLRepository
		{
		 
			get 
			{
				if(iGATE_BDATA_TOOLRepository==null)
					iGATE_BDATA_TOOLRepository= new GATE_BDATA_TOOLRepository();
				return iGATE_BDATA_TOOLRepository;
			}
			set
			{
				iGATE_BDATA_TOOLRepository= value;
			}
		}
		#endregion

		#region 121 数据接口 IGATE_DEPT_MAPRepository
		IGATE_DEPT_MAPRepository iGATE_DEPT_MAPRepository;
		public IGATE_DEPT_MAPRepository IGATE_DEPT_MAPRepository
		{
		 
			get 
			{
				if(iGATE_DEPT_MAPRepository==null)
					iGATE_DEPT_MAPRepository= new GATE_DEPT_MAPRepository();
				return iGATE_DEPT_MAPRepository;
			}
			set
			{
				iGATE_DEPT_MAPRepository= value;
			}
		}
		#endregion

		#region 122 数据接口 IGATE_GATEMNG_AUTHHISTORYRepository
		IGATE_GATEMNG_AUTHHISTORYRepository iGATE_GATEMNG_AUTHHISTORYRepository;
		public IGATE_GATEMNG_AUTHHISTORYRepository IGATE_GATEMNG_AUTHHISTORYRepository
		{
		 
			get 
			{
				if(iGATE_GATEMNG_AUTHHISTORYRepository==null)
					iGATE_GATEMNG_AUTHHISTORYRepository= new GATE_GATEMNG_AUTHHISTORYRepository();
				return iGATE_GATEMNG_AUTHHISTORYRepository;
			}
			set
			{
				iGATE_GATEMNG_AUTHHISTORYRepository= value;
			}
		}
		#endregion

		#region 123 数据接口 IGATE_GATEMNG_AUTHORIZATIONRepository
		IGATE_GATEMNG_AUTHORIZATIONRepository iGATE_GATEMNG_AUTHORIZATIONRepository;
		public IGATE_GATEMNG_AUTHORIZATIONRepository IGATE_GATEMNG_AUTHORIZATIONRepository
		{
		 
			get 
			{
				if(iGATE_GATEMNG_AUTHORIZATIONRepository==null)
					iGATE_GATEMNG_AUTHORIZATIONRepository= new GATE_GATEMNG_AUTHORIZATIONRepository();
				return iGATE_GATEMNG_AUTHORIZATIONRepository;
			}
			set
			{
				iGATE_GATEMNG_AUTHORIZATIONRepository= value;
			}
		}
		#endregion

		#region 124 数据接口 IGATE_GATEMNG_CARDLISTRepository
		IGATE_GATEMNG_CARDLISTRepository iGATE_GATEMNG_CARDLISTRepository;
		public IGATE_GATEMNG_CARDLISTRepository IGATE_GATEMNG_CARDLISTRepository
		{
		 
			get 
			{
				if(iGATE_GATEMNG_CARDLISTRepository==null)
					iGATE_GATEMNG_CARDLISTRepository= new GATE_GATEMNG_CARDLISTRepository();
				return iGATE_GATEMNG_CARDLISTRepository;
			}
			set
			{
				iGATE_GATEMNG_CARDLISTRepository= value;
			}
		}
		#endregion

		#region 125 数据接口 IGATE_GATEMNG_INGATERepository
		IGATE_GATEMNG_INGATERepository iGATE_GATEMNG_INGATERepository;
		public IGATE_GATEMNG_INGATERepository IGATE_GATEMNG_INGATERepository
		{
		 
			get 
			{
				if(iGATE_GATEMNG_INGATERepository==null)
					iGATE_GATEMNG_INGATERepository= new GATE_GATEMNG_INGATERepository();
				return iGATE_GATEMNG_INGATERepository;
			}
			set
			{
				iGATE_GATEMNG_INGATERepository= value;
			}
		}
		#endregion

		#region 126 数据接口 IGATE_GATEMNG_INOUTRepository
		IGATE_GATEMNG_INOUTRepository iGATE_GATEMNG_INOUTRepository;
		public IGATE_GATEMNG_INOUTRepository IGATE_GATEMNG_INOUTRepository
		{
		 
			get 
			{
				if(iGATE_GATEMNG_INOUTRepository==null)
					iGATE_GATEMNG_INOUTRepository= new GATE_GATEMNG_INOUTRepository();
				return iGATE_GATEMNG_INOUTRepository;
			}
			set
			{
				iGATE_GATEMNG_INOUTRepository= value;
			}
		}
		#endregion

		#region 127 数据接口 IGATE_GATEMNG_INOUTHISRepository
		IGATE_GATEMNG_INOUTHISRepository iGATE_GATEMNG_INOUTHISRepository;
		public IGATE_GATEMNG_INOUTHISRepository IGATE_GATEMNG_INOUTHISRepository
		{
		 
			get 
			{
				if(iGATE_GATEMNG_INOUTHISRepository==null)
					iGATE_GATEMNG_INOUTHISRepository= new GATE_GATEMNG_INOUTHISRepository();
				return iGATE_GATEMNG_INOUTHISRepository;
			}
			set
			{
				iGATE_GATEMNG_INOUTHISRepository= value;
			}
		}
		#endregion

		#region 128 数据接口 IGATE_GATEMNG_LASTCARDLISTRepository
		IGATE_GATEMNG_LASTCARDLISTRepository iGATE_GATEMNG_LASTCARDLISTRepository;
		public IGATE_GATEMNG_LASTCARDLISTRepository IGATE_GATEMNG_LASTCARDLISTRepository
		{
		 
			get 
			{
				if(iGATE_GATEMNG_LASTCARDLISTRepository==null)
					iGATE_GATEMNG_LASTCARDLISTRepository= new GATE_GATEMNG_LASTCARDLISTRepository();
				return iGATE_GATEMNG_LASTCARDLISTRepository;
			}
			set
			{
				iGATE_GATEMNG_LASTCARDLISTRepository= value;
			}
		}
		#endregion

		#region 129 数据接口 IGATE_GATEMNG_LASTSTATERepository
		IGATE_GATEMNG_LASTSTATERepository iGATE_GATEMNG_LASTSTATERepository;
		public IGATE_GATEMNG_LASTSTATERepository IGATE_GATEMNG_LASTSTATERepository
		{
		 
			get 
			{
				if(iGATE_GATEMNG_LASTSTATERepository==null)
					iGATE_GATEMNG_LASTSTATERepository= new GATE_GATEMNG_LASTSTATERepository();
				return iGATE_GATEMNG_LASTSTATERepository;
			}
			set
			{
				iGATE_GATEMNG_LASTSTATERepository= value;
			}
		}
		#endregion

		#region 130 数据接口 IGATE_GATEMNG_LONGDISHISTORYRepository
		IGATE_GATEMNG_LONGDISHISTORYRepository iGATE_GATEMNG_LONGDISHISTORYRepository;
		public IGATE_GATEMNG_LONGDISHISTORYRepository IGATE_GATEMNG_LONGDISHISTORYRepository
		{
		 
			get 
			{
				if(iGATE_GATEMNG_LONGDISHISTORYRepository==null)
					iGATE_GATEMNG_LONGDISHISTORYRepository= new GATE_GATEMNG_LONGDISHISTORYRepository();
				return iGATE_GATEMNG_LONGDISHISTORYRepository;
			}
			set
			{
				iGATE_GATEMNG_LONGDISHISTORYRepository= value;
			}
		}
		#endregion

		#region 131 数据接口 IGATE_GATEMNG_STATERepository
		IGATE_GATEMNG_STATERepository iGATE_GATEMNG_STATERepository;
		public IGATE_GATEMNG_STATERepository IGATE_GATEMNG_STATERepository
		{
		 
			get 
			{
				if(iGATE_GATEMNG_STATERepository==null)
					iGATE_GATEMNG_STATERepository= new GATE_GATEMNG_STATERepository();
				return iGATE_GATEMNG_STATERepository;
			}
			set
			{
				iGATE_GATEMNG_STATERepository= value;
			}
		}
		#endregion

		#region 132 数据接口 IGATE_GATEMNG_WARNINGRepository
		IGATE_GATEMNG_WARNINGRepository iGATE_GATEMNG_WARNINGRepository;
		public IGATE_GATEMNG_WARNINGRepository IGATE_GATEMNG_WARNINGRepository
		{
		 
			get 
			{
				if(iGATE_GATEMNG_WARNINGRepository==null)
					iGATE_GATEMNG_WARNINGRepository= new GATE_GATEMNG_WARNINGRepository();
				return iGATE_GATEMNG_WARNINGRepository;
			}
			set
			{
				iGATE_GATEMNG_WARNINGRepository= value;
			}
		}
		#endregion

		#region 133 数据接口 IGATE_JOB_PLANRepository
		IGATE_JOB_PLANRepository iGATE_JOB_PLANRepository;
		public IGATE_JOB_PLANRepository IGATE_JOB_PLANRepository
		{
		 
			get 
			{
				if(iGATE_JOB_PLANRepository==null)
					iGATE_JOB_PLANRepository= new GATE_JOB_PLANRepository();
				return iGATE_JOB_PLANRepository;
			}
			set
			{
				iGATE_JOB_PLANRepository= value;
			}
		}
		#endregion

		#region 134 数据接口 IGATE_SEND_MSGRepository
		IGATE_SEND_MSGRepository iGATE_SEND_MSGRepository;
		public IGATE_SEND_MSGRepository IGATE_SEND_MSGRepository
		{
		 
			get 
			{
				if(iGATE_SEND_MSGRepository==null)
					iGATE_SEND_MSGRepository= new GATE_SEND_MSGRepository();
				return iGATE_SEND_MSGRepository;
			}
			set
			{
				iGATE_SEND_MSGRepository= value;
			}
		}
		#endregion

		#region 135 数据接口 IGATE_SEND_PHONENORepository
		IGATE_SEND_PHONENORepository iGATE_SEND_PHONENORepository;
		public IGATE_SEND_PHONENORepository IGATE_SEND_PHONENORepository
		{
		 
			get 
			{
				if(iGATE_SEND_PHONENORepository==null)
					iGATE_SEND_PHONENORepository= new GATE_SEND_PHONENORepository();
				return iGATE_SEND_PHONENORepository;
			}
			set
			{
				iGATE_SEND_PHONENORepository= value;
			}
		}
		#endregion

		#region 136 数据接口 IHEART_BROADCASTRepository
		IHEART_BROADCASTRepository iHEART_BROADCASTRepository;
		public IHEART_BROADCASTRepository IHEART_BROADCASTRepository
		{
		 
			get 
			{
				if(iHEART_BROADCASTRepository==null)
					iHEART_BROADCASTRepository= new HEART_BROADCASTRepository();
				return iHEART_BROADCASTRepository;
			}
			set
			{
				iHEART_BROADCASTRepository= value;
			}
		}
		#endregion

		#region 137 数据接口 IHEART_BROADCAST_HISRepository
		IHEART_BROADCAST_HISRepository iHEART_BROADCAST_HISRepository;
		public IHEART_BROADCAST_HISRepository IHEART_BROADCAST_HISRepository
		{
		 
			get 
			{
				if(iHEART_BROADCAST_HISRepository==null)
					iHEART_BROADCAST_HISRepository= new HEART_BROADCAST_HISRepository();
				return iHEART_BROADCAST_HISRepository;
			}
			set
			{
				iHEART_BROADCAST_HISRepository= value;
			}
		}
		#endregion

		#region 138 数据接口 IHEART_DG_DIS_PHONERepository
		IHEART_DG_DIS_PHONERepository iHEART_DG_DIS_PHONERepository;
		public IHEART_DG_DIS_PHONERepository IHEART_DG_DIS_PHONERepository
		{
		 
			get 
			{
				if(iHEART_DG_DIS_PHONERepository==null)
					iHEART_DG_DIS_PHONERepository= new HEART_DG_DIS_PHONERepository();
				return iHEART_DG_DIS_PHONERepository;
			}
			set
			{
				iHEART_DG_DIS_PHONERepository= value;
			}
		}
		#endregion

		#region 139 数据接口 IHEART_DG_VOLTAGE_SENDRepository
		IHEART_DG_VOLTAGE_SENDRepository iHEART_DG_VOLTAGE_SENDRepository;
		public IHEART_DG_VOLTAGE_SENDRepository IHEART_DG_VOLTAGE_SENDRepository
		{
		 
			get 
			{
				if(iHEART_DG_VOLTAGE_SENDRepository==null)
					iHEART_DG_VOLTAGE_SENDRepository= new HEART_DG_VOLTAGE_SENDRepository();
				return iHEART_DG_VOLTAGE_SENDRepository;
			}
			set
			{
				iHEART_DG_VOLTAGE_SENDRepository= value;
			}
		}
		#endregion

		#region 140 数据接口 IHEART_DG_WAVERepository
		IHEART_DG_WAVERepository iHEART_DG_WAVERepository;
		public IHEART_DG_WAVERepository IHEART_DG_WAVERepository
		{
		 
			get 
			{
				if(iHEART_DG_WAVERepository==null)
					iHEART_DG_WAVERepository= new HEART_DG_WAVERepository();
				return iHEART_DG_WAVERepository;
			}
			set
			{
				iHEART_DG_WAVERepository= value;
			}
		}
		#endregion

		#region 141 数据接口 IHEART_DG_WAVE_HEADRepository
		IHEART_DG_WAVE_HEADRepository iHEART_DG_WAVE_HEADRepository;
		public IHEART_DG_WAVE_HEADRepository IHEART_DG_WAVE_HEADRepository
		{
		 
			get 
			{
				if(iHEART_DG_WAVE_HEADRepository==null)
					iHEART_DG_WAVE_HEADRepository= new HEART_DG_WAVE_HEADRepository();
				return iHEART_DG_WAVE_HEADRepository;
			}
			set
			{
				iHEART_DG_WAVE_HEADRepository= value;
			}
		}
		#endregion

		#region 142 数据接口 IHEART_DG_WEBRepository
		IHEART_DG_WEBRepository iHEART_DG_WEBRepository;
		public IHEART_DG_WEBRepository IHEART_DG_WEBRepository
		{
		 
			get 
			{
				if(iHEART_DG_WEBRepository==null)
					iHEART_DG_WEBRepository= new HEART_DG_WEBRepository();
				return iHEART_DG_WEBRepository;
			}
			set
			{
				iHEART_DG_WEBRepository= value;
			}
		}
		#endregion

		#region 143 数据接口 IHEART_MESSAGERepository
		IHEART_MESSAGERepository iHEART_MESSAGERepository;
		public IHEART_MESSAGERepository IHEART_MESSAGERepository
		{
		 
			get 
			{
				if(iHEART_MESSAGERepository==null)
					iHEART_MESSAGERepository= new HEART_MESSAGERepository();
				return iHEART_MESSAGERepository;
			}
			set
			{
				iHEART_MESSAGERepository= value;
			}
		}
		#endregion

		#region 144 数据接口 IHEART_RECENT_SARepository
		IHEART_RECENT_SARepository iHEART_RECENT_SARepository;
		public IHEART_RECENT_SARepository IHEART_RECENT_SARepository
		{
		 
			get 
			{
				if(iHEART_RECENT_SARepository==null)
					iHEART_RECENT_SARepository= new HEART_RECENT_SARepository();
				return iHEART_RECENT_SARepository;
			}
			set
			{
				iHEART_RECENT_SARepository= value;
			}
		}
		#endregion

		#region 145 数据接口 IHIK_PIC_INFORepository
		IHIK_PIC_INFORepository iHIK_PIC_INFORepository;
		public IHIK_PIC_INFORepository IHIK_PIC_INFORepository
		{
		 
			get 
			{
				if(iHIK_PIC_INFORepository==null)
					iHIK_PIC_INFORepository= new HIK_PIC_INFORepository();
				return iHIK_PIC_INFORepository;
			}
			set
			{
				iHIK_PIC_INFORepository= value;
			}
		}
		#endregion

		#region 146 数据接口 IHRAIL_BALLASTRepository
		IHRAIL_BALLASTRepository iHRAIL_BALLASTRepository;
		public IHRAIL_BALLASTRepository IHRAIL_BALLASTRepository
		{
		 
			get 
			{
				if(iHRAIL_BALLASTRepository==null)
					iHRAIL_BALLASTRepository= new HRAIL_BALLASTRepository();
				return iHRAIL_BALLASTRepository;
			}
			set
			{
				iHRAIL_BALLASTRepository= value;
			}
		}
		#endregion

		#region 147 数据接口 IHRAIL_CROSSINGRepository
		IHRAIL_CROSSINGRepository iHRAIL_CROSSINGRepository;
		public IHRAIL_CROSSINGRepository IHRAIL_CROSSINGRepository
		{
		 
			get 
			{
				if(iHRAIL_CROSSINGRepository==null)
					iHRAIL_CROSSINGRepository= new HRAIL_CROSSINGRepository();
				return iHRAIL_CROSSINGRepository;
			}
			set
			{
				iHRAIL_CROSSINGRepository= value;
			}
		}
		#endregion

		#region 148 数据接口 IHRAIL_CURVERepository
		IHRAIL_CURVERepository iHRAIL_CURVERepository;
		public IHRAIL_CURVERepository IHRAIL_CURVERepository
		{
		 
			get 
			{
				if(iHRAIL_CURVERepository==null)
					iHRAIL_CURVERepository= new HRAIL_CURVERepository();
				return iHRAIL_CURVERepository;
			}
			set
			{
				iHRAIL_CURVERepository= value;
			}
		}
		#endregion

		#region 149 数据接口 IHRAIL_DEPT_STATIONRepository
		IHRAIL_DEPT_STATIONRepository iHRAIL_DEPT_STATIONRepository;
		public IHRAIL_DEPT_STATIONRepository IHRAIL_DEPT_STATIONRepository
		{
		 
			get 
			{
				if(iHRAIL_DEPT_STATIONRepository==null)
					iHRAIL_DEPT_STATIONRepository= new HRAIL_DEPT_STATIONRepository();
				return iHRAIL_DEPT_STATIONRepository;
			}
			set
			{
				iHRAIL_DEPT_STATIONRepository= value;
			}
		}
		#endregion

		#region 150 数据接口 IHRAIL_LINEUNITRepository
		IHRAIL_LINEUNITRepository iHRAIL_LINEUNITRepository;
		public IHRAIL_LINEUNITRepository IHRAIL_LINEUNITRepository
		{
		 
			get 
			{
				if(iHRAIL_LINEUNITRepository==null)
					iHRAIL_LINEUNITRepository= new HRAIL_LINEUNITRepository();
				return iHRAIL_LINEUNITRepository;
			}
			set
			{
				iHRAIL_LINEUNITRepository= value;
			}
		}
		#endregion

		#region 151 数据接口 IHRAIL_PARA_JOBITEMRepository
		IHRAIL_PARA_JOBITEMRepository iHRAIL_PARA_JOBITEMRepository;
		public IHRAIL_PARA_JOBITEMRepository IHRAIL_PARA_JOBITEMRepository
		{
		 
			get 
			{
				if(iHRAIL_PARA_JOBITEMRepository==null)
					iHRAIL_PARA_JOBITEMRepository= new HRAIL_PARA_JOBITEMRepository();
				return iHRAIL_PARA_JOBITEMRepository;
			}
			set
			{
				iHRAIL_PARA_JOBITEMRepository= value;
			}
		}
		#endregion

		#region 152 数据接口 IHRAIL_PARA_PROITEMRepository
		IHRAIL_PARA_PROITEMRepository iHRAIL_PARA_PROITEMRepository;
		public IHRAIL_PARA_PROITEMRepository IHRAIL_PARA_PROITEMRepository
		{
		 
			get 
			{
				if(iHRAIL_PARA_PROITEMRepository==null)
					iHRAIL_PARA_PROITEMRepository= new HRAIL_PARA_PROITEMRepository();
				return iHRAIL_PARA_PROITEMRepository;
			}
			set
			{
				iHRAIL_PARA_PROITEMRepository= value;
			}
		}
		#endregion

		#region 153 数据接口 IHRAIL_PARA_PROITEM_SCORERepository
		IHRAIL_PARA_PROITEM_SCORERepository iHRAIL_PARA_PROITEM_SCORERepository;
		public IHRAIL_PARA_PROITEM_SCORERepository IHRAIL_PARA_PROITEM_SCORERepository
		{
		 
			get 
			{
				if(iHRAIL_PARA_PROITEM_SCORERepository==null)
					iHRAIL_PARA_PROITEM_SCORERepository= new HRAIL_PARA_PROITEM_SCORERepository();
				return iHRAIL_PARA_PROITEM_SCORERepository;
			}
			set
			{
				iHRAIL_PARA_PROITEM_SCORERepository= value;
			}
		}
		#endregion

		#region 154 数据接口 IHRAIL_PLANRepository
		IHRAIL_PLANRepository iHRAIL_PLANRepository;
		public IHRAIL_PLANRepository IHRAIL_PLANRepository
		{
		 
			get 
			{
				if(iHRAIL_PLANRepository==null)
					iHRAIL_PLANRepository= new HRAIL_PLANRepository();
				return iHRAIL_PLANRepository;
			}
			set
			{
				iHRAIL_PLANRepository= value;
			}
		}
		#endregion

		#region 155 数据接口 IHRAIL_PLAN_EMPRepository
		IHRAIL_PLAN_EMPRepository iHRAIL_PLAN_EMPRepository;
		public IHRAIL_PLAN_EMPRepository IHRAIL_PLAN_EMPRepository
		{
		 
			get 
			{
				if(iHRAIL_PLAN_EMPRepository==null)
					iHRAIL_PLAN_EMPRepository= new HRAIL_PLAN_EMPRepository();
				return iHRAIL_PLAN_EMPRepository;
			}
			set
			{
				iHRAIL_PLAN_EMPRepository= value;
			}
		}
		#endregion

		#region 156 数据接口 IHRAIL_PLAN_FILERepository
		IHRAIL_PLAN_FILERepository iHRAIL_PLAN_FILERepository;
		public IHRAIL_PLAN_FILERepository IHRAIL_PLAN_FILERepository
		{
		 
			get 
			{
				if(iHRAIL_PLAN_FILERepository==null)
					iHRAIL_PLAN_FILERepository= new HRAIL_PLAN_FILERepository();
				return iHRAIL_PLAN_FILERepository;
			}
			set
			{
				iHRAIL_PLAN_FILERepository= value;
			}
		}
		#endregion

		#region 157 数据接口 IHRAIL_PLAN_FLOWRepository
		IHRAIL_PLAN_FLOWRepository iHRAIL_PLAN_FLOWRepository;
		public IHRAIL_PLAN_FLOWRepository IHRAIL_PLAN_FLOWRepository
		{
		 
			get 
			{
				if(iHRAIL_PLAN_FLOWRepository==null)
					iHRAIL_PLAN_FLOWRepository= new HRAIL_PLAN_FLOWRepository();
				return iHRAIL_PLAN_FLOWRepository;
			}
			set
			{
				iHRAIL_PLAN_FLOWRepository= value;
			}
		}
		#endregion

		#region 158 数据接口 IHRAIL_PLAN_ITEMRepository
		IHRAIL_PLAN_ITEMRepository iHRAIL_PLAN_ITEMRepository;
		public IHRAIL_PLAN_ITEMRepository IHRAIL_PLAN_ITEMRepository
		{
		 
			get 
			{
				if(iHRAIL_PLAN_ITEMRepository==null)
					iHRAIL_PLAN_ITEMRepository= new HRAIL_PLAN_ITEMRepository();
				return iHRAIL_PLAN_ITEMRepository;
			}
			set
			{
				iHRAIL_PLAN_ITEMRepository= value;
			}
		}
		#endregion

		#region 159 数据接口 IHRAIL_PLAN_LOCRepository
		IHRAIL_PLAN_LOCRepository iHRAIL_PLAN_LOCRepository;
		public IHRAIL_PLAN_LOCRepository IHRAIL_PLAN_LOCRepository
		{
		 
			get 
			{
				if(iHRAIL_PLAN_LOCRepository==null)
					iHRAIL_PLAN_LOCRepository= new HRAIL_PLAN_LOCRepository();
				return iHRAIL_PLAN_LOCRepository;
			}
			set
			{
				iHRAIL_PLAN_LOCRepository= value;
			}
		}
		#endregion

		#region 160 数据接口 IHRAIL_PLAN_MATERIALRepository
		IHRAIL_PLAN_MATERIALRepository iHRAIL_PLAN_MATERIALRepository;
		public IHRAIL_PLAN_MATERIALRepository IHRAIL_PLAN_MATERIALRepository
		{
		 
			get 
			{
				if(iHRAIL_PLAN_MATERIALRepository==null)
					iHRAIL_PLAN_MATERIALRepository= new HRAIL_PLAN_MATERIALRepository();
				return iHRAIL_PLAN_MATERIALRepository;
			}
			set
			{
				iHRAIL_PLAN_MATERIALRepository= value;
			}
		}
		#endregion

		#region 161 数据接口 IHRAIL_PLAN_PROBLEMRepository
		IHRAIL_PLAN_PROBLEMRepository iHRAIL_PLAN_PROBLEMRepository;
		public IHRAIL_PLAN_PROBLEMRepository IHRAIL_PLAN_PROBLEMRepository
		{
		 
			get 
			{
				if(iHRAIL_PLAN_PROBLEMRepository==null)
					iHRAIL_PLAN_PROBLEMRepository= new HRAIL_PLAN_PROBLEMRepository();
				return iHRAIL_PLAN_PROBLEMRepository;
			}
			set
			{
				iHRAIL_PLAN_PROBLEMRepository= value;
			}
		}
		#endregion

		#region 162 数据接口 IHRAIL_PLAN_TOOLRepository
		IHRAIL_PLAN_TOOLRepository iHRAIL_PLAN_TOOLRepository;
		public IHRAIL_PLAN_TOOLRepository IHRAIL_PLAN_TOOLRepository
		{
		 
			get 
			{
				if(iHRAIL_PLAN_TOOLRepository==null)
					iHRAIL_PLAN_TOOLRepository= new HRAIL_PLAN_TOOLRepository();
				return iHRAIL_PLAN_TOOLRepository;
			}
			set
			{
				iHRAIL_PLAN_TOOLRepository= value;
			}
		}
		#endregion

		#region 163 数据接口 IHRAIL_PLAN_YEARRepository
		IHRAIL_PLAN_YEARRepository iHRAIL_PLAN_YEARRepository;
		public IHRAIL_PLAN_YEARRepository IHRAIL_PLAN_YEARRepository
		{
		 
			get 
			{
				if(iHRAIL_PLAN_YEARRepository==null)
					iHRAIL_PLAN_YEARRepository= new HRAIL_PLAN_YEARRepository();
				return iHRAIL_PLAN_YEARRepository;
			}
			set
			{
				iHRAIL_PLAN_YEARRepository= value;
			}
		}
		#endregion

		#region 164 数据接口 IHRAIL_PROBLEMRepository
		IHRAIL_PROBLEMRepository iHRAIL_PROBLEMRepository;
		public IHRAIL_PROBLEMRepository IHRAIL_PROBLEMRepository
		{
		 
			get 
			{
				if(iHRAIL_PROBLEMRepository==null)
					iHRAIL_PROBLEMRepository= new HRAIL_PROBLEMRepository();
				return iHRAIL_PROBLEMRepository;
			}
			set
			{
				iHRAIL_PROBLEMRepository= value;
			}
		}
		#endregion

		#region 165 数据接口 IHRAIL_PROBLEM_DNYRepository
		IHRAIL_PROBLEM_DNYRepository iHRAIL_PROBLEM_DNYRepository;
		public IHRAIL_PROBLEM_DNYRepository IHRAIL_PROBLEM_DNYRepository
		{
		 
			get 
			{
				if(iHRAIL_PROBLEM_DNYRepository==null)
					iHRAIL_PROBLEM_DNYRepository= new HRAIL_PROBLEM_DNYRepository();
				return iHRAIL_PROBLEM_DNYRepository;
			}
			set
			{
				iHRAIL_PROBLEM_DNYRepository= value;
			}
		}
		#endregion

		#region 166 数据接口 IHRAIL_PROBLEM_FILERepository
		IHRAIL_PROBLEM_FILERepository iHRAIL_PROBLEM_FILERepository;
		public IHRAIL_PROBLEM_FILERepository IHRAIL_PROBLEM_FILERepository
		{
		 
			get 
			{
				if(iHRAIL_PROBLEM_FILERepository==null)
					iHRAIL_PROBLEM_FILERepository= new HRAIL_PROBLEM_FILERepository();
				return iHRAIL_PROBLEM_FILERepository;
			}
			set
			{
				iHRAIL_PROBLEM_FILERepository= value;
			}
		}
		#endregion

		#region 167 数据接口 IHRAIL_RAILRepository
		IHRAIL_RAILRepository iHRAIL_RAILRepository;
		public IHRAIL_RAILRepository IHRAIL_RAILRepository
		{
		 
			get 
			{
				if(iHRAIL_RAILRepository==null)
					iHRAIL_RAILRepository= new HRAIL_RAILRepository();
				return iHRAIL_RAILRepository;
			}
			set
			{
				iHRAIL_RAILRepository= value;
			}
		}
		#endregion

		#region 168 数据接口 IHRAIL_SLOPERepository
		IHRAIL_SLOPERepository iHRAIL_SLOPERepository;
		public IHRAIL_SLOPERepository IHRAIL_SLOPERepository
		{
		 
			get 
			{
				if(iHRAIL_SLOPERepository==null)
					iHRAIL_SLOPERepository= new HRAIL_SLOPERepository();
				return iHRAIL_SLOPERepository;
			}
			set
			{
				iHRAIL_SLOPERepository= value;
			}
		}
		#endregion

		#region 169 数据接口 IHRAIL_STARTMILERepository
		IHRAIL_STARTMILERepository iHRAIL_STARTMILERepository;
		public IHRAIL_STARTMILERepository IHRAIL_STARTMILERepository
		{
		 
			get 
			{
				if(iHRAIL_STARTMILERepository==null)
					iHRAIL_STARTMILERepository= new HRAIL_STARTMILERepository();
				return iHRAIL_STARTMILERepository;
			}
			set
			{
				iHRAIL_STARTMILERepository= value;
			}
		}
		#endregion

		#region 170 数据接口 IHRAIL_STATIONRepository
		IHRAIL_STATIONRepository iHRAIL_STATIONRepository;
		public IHRAIL_STATIONRepository IHRAIL_STATIONRepository
		{
		 
			get 
			{
				if(iHRAIL_STATIONRepository==null)
					iHRAIL_STATIONRepository= new HRAIL_STATIONRepository();
				return iHRAIL_STATIONRepository;
			}
			set
			{
				iHRAIL_STATIONRepository= value;
			}
		}
		#endregion

		#region 171 数据接口 IHRAIL_TQIRepository
		IHRAIL_TQIRepository iHRAIL_TQIRepository;
		public IHRAIL_TQIRepository IHRAIL_TQIRepository
		{
		 
			get 
			{
				if(iHRAIL_TQIRepository==null)
					iHRAIL_TQIRepository= new HRAIL_TQIRepository();
				return iHRAIL_TQIRepository;
			}
			set
			{
				iHRAIL_TQIRepository= value;
			}
		}
		#endregion

		#region 172 数据接口 IHRAIL_TRACKRepository
		IHRAIL_TRACKRepository iHRAIL_TRACKRepository;
		public IHRAIL_TRACKRepository IHRAIL_TRACKRepository
		{
		 
			get 
			{
				if(iHRAIL_TRACKRepository==null)
					iHRAIL_TRACKRepository= new HRAIL_TRACKRepository();
				return iHRAIL_TRACKRepository;
			}
			set
			{
				iHRAIL_TRACKRepository= value;
			}
		}
		#endregion

		#region 173 数据接口 IHRAIL_TURNOUTRepository
		IHRAIL_TURNOUTRepository iHRAIL_TURNOUTRepository;
		public IHRAIL_TURNOUTRepository IHRAIL_TURNOUTRepository
		{
		 
			get 
			{
				if(iHRAIL_TURNOUTRepository==null)
					iHRAIL_TURNOUTRepository= new HRAIL_TURNOUTRepository();
				return iHRAIL_TURNOUTRepository;
			}
			set
			{
				iHRAIL_TURNOUTRepository= value;
			}
		}
		#endregion

		#region 174 数据接口 IHRAIL_UNIT_VALRepository
		IHRAIL_UNIT_VALRepository iHRAIL_UNIT_VALRepository;
		public IHRAIL_UNIT_VALRepository IHRAIL_UNIT_VALRepository
		{
		 
			get 
			{
				if(iHRAIL_UNIT_VALRepository==null)
					iHRAIL_UNIT_VALRepository= new HRAIL_UNIT_VALRepository();
				return iHRAIL_UNIT_VALRepository;
			}
			set
			{
				iHRAIL_UNIT_VALRepository= value;
			}
		}
		#endregion

		#region 175 数据接口 IHRAIL_UNIT_VAL_DETAILRepository
		IHRAIL_UNIT_VAL_DETAILRepository iHRAIL_UNIT_VAL_DETAILRepository;
		public IHRAIL_UNIT_VAL_DETAILRepository IHRAIL_UNIT_VAL_DETAILRepository
		{
		 
			get 
			{
				if(iHRAIL_UNIT_VAL_DETAILRepository==null)
					iHRAIL_UNIT_VAL_DETAILRepository= new HRAIL_UNIT_VAL_DETAILRepository();
				return iHRAIL_UNIT_VAL_DETAILRepository;
			}
			set
			{
				iHRAIL_UNIT_VAL_DETAILRepository= value;
			}
		}
		#endregion

		#region 176 数据接口 IJOB_JOB_PLANRepository
		IJOB_JOB_PLANRepository iJOB_JOB_PLANRepository;
		public IJOB_JOB_PLANRepository IJOB_JOB_PLANRepository
		{
		 
			get 
			{
				if(iJOB_JOB_PLANRepository==null)
					iJOB_JOB_PLANRepository= new JOB_JOB_PLANRepository();
				return iJOB_JOB_PLANRepository;
			}
			set
			{
				iJOB_JOB_PLANRepository= value;
			}
		}
		#endregion

		#region 177 数据接口 IJOB_MSG_BATCHREPLYRepository
		IJOB_MSG_BATCHREPLYRepository iJOB_MSG_BATCHREPLYRepository;
		public IJOB_MSG_BATCHREPLYRepository IJOB_MSG_BATCHREPLYRepository
		{
		 
			get 
			{
				if(iJOB_MSG_BATCHREPLYRepository==null)
					iJOB_MSG_BATCHREPLYRepository= new JOB_MSG_BATCHREPLYRepository();
				return iJOB_MSG_BATCHREPLYRepository;
			}
			set
			{
				iJOB_MSG_BATCHREPLYRepository= value;
			}
		}
		#endregion

		#region 178 数据接口 IJOB_MSG_BATCHSENDRepository
		IJOB_MSG_BATCHSENDRepository iJOB_MSG_BATCHSENDRepository;
		public IJOB_MSG_BATCHSENDRepository IJOB_MSG_BATCHSENDRepository
		{
		 
			get 
			{
				if(iJOB_MSG_BATCHSENDRepository==null)
					iJOB_MSG_BATCHSENDRepository= new JOB_MSG_BATCHSENDRepository();
				return iJOB_MSG_BATCHSENDRepository;
			}
			set
			{
				iJOB_MSG_BATCHSENDRepository= value;
			}
		}
		#endregion

		#region 179 数据接口 IJOB_MSG_BATCHSENDPHOTORepository
		IJOB_MSG_BATCHSENDPHOTORepository iJOB_MSG_BATCHSENDPHOTORepository;
		public IJOB_MSG_BATCHSENDPHOTORepository IJOB_MSG_BATCHSENDPHOTORepository
		{
		 
			get 
			{
				if(iJOB_MSG_BATCHSENDPHOTORepository==null)
					iJOB_MSG_BATCHSENDPHOTORepository= new JOB_MSG_BATCHSENDPHOTORepository();
				return iJOB_MSG_BATCHSENDPHOTORepository;
			}
			set
			{
				iJOB_MSG_BATCHSENDPHOTORepository= value;
			}
		}
		#endregion

		#region 180 数据接口 IJOB_PLANRepository
		IJOB_PLANRepository iJOB_PLANRepository;
		public IJOB_PLANRepository IJOB_PLANRepository
		{
		 
			get 
			{
				if(iJOB_PLANRepository==null)
					iJOB_PLANRepository= new JOB_PLANRepository();
				return iJOB_PLANRepository;
			}
			set
			{
				iJOB_PLANRepository= value;
			}
		}
		#endregion

		#region 181 数据接口 IJOB_PLAN_ADDPASSENGER_TESTRepository
		IJOB_PLAN_ADDPASSENGER_TESTRepository iJOB_PLAN_ADDPASSENGER_TESTRepository;
		public IJOB_PLAN_ADDPASSENGER_TESTRepository IJOB_PLAN_ADDPASSENGER_TESTRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_ADDPASSENGER_TESTRepository==null)
					iJOB_PLAN_ADDPASSENGER_TESTRepository= new JOB_PLAN_ADDPASSENGER_TESTRepository();
				return iJOB_PLAN_ADDPASSENGER_TESTRepository;
			}
			set
			{
				iJOB_PLAN_ADDPASSENGER_TESTRepository= value;
			}
		}
		#endregion

		#region 182 数据接口 IJOB_PLAN_APPROVALRepository
		IJOB_PLAN_APPROVALRepository iJOB_PLAN_APPROVALRepository;
		public IJOB_PLAN_APPROVALRepository IJOB_PLAN_APPROVALRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_APPROVALRepository==null)
					iJOB_PLAN_APPROVALRepository= new JOB_PLAN_APPROVALRepository();
				return iJOB_PLAN_APPROVALRepository;
			}
			set
			{
				iJOB_PLAN_APPROVALRepository= value;
			}
		}
		#endregion

		#region 183 数据接口 IJOB_PLAN_BYTIMRepository
		IJOB_PLAN_BYTIMRepository iJOB_PLAN_BYTIMRepository;
		public IJOB_PLAN_BYTIMRepository IJOB_PLAN_BYTIMRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_BYTIMRepository==null)
					iJOB_PLAN_BYTIMRepository= new JOB_PLAN_BYTIMRepository();
				return iJOB_PLAN_BYTIMRepository;
			}
			set
			{
				iJOB_PLAN_BYTIMRepository= value;
			}
		}
		#endregion

		#region 184 数据接口 IJOB_PLAN_CONTROLRepository
		IJOB_PLAN_CONTROLRepository iJOB_PLAN_CONTROLRepository;
		public IJOB_PLAN_CONTROLRepository IJOB_PLAN_CONTROLRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_CONTROLRepository==null)
					iJOB_PLAN_CONTROLRepository= new JOB_PLAN_CONTROLRepository();
				return iJOB_PLAN_CONTROLRepository;
			}
			set
			{
				iJOB_PLAN_CONTROLRepository= value;
			}
		}
		#endregion

		#region 185 数据接口 IJOB_PLAN_DELINGHA_FILLRepository
		IJOB_PLAN_DELINGHA_FILLRepository iJOB_PLAN_DELINGHA_FILLRepository;
		public IJOB_PLAN_DELINGHA_FILLRepository IJOB_PLAN_DELINGHA_FILLRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_DELINGHA_FILLRepository==null)
					iJOB_PLAN_DELINGHA_FILLRepository= new JOB_PLAN_DELINGHA_FILLRepository();
				return iJOB_PLAN_DELINGHA_FILLRepository;
			}
			set
			{
				iJOB_PLAN_DELINGHA_FILLRepository= value;
			}
		}
		#endregion

		#region 186 数据接口 IJOB_PLAN_DELINGHA_FILL_DETAILRepository
		IJOB_PLAN_DELINGHA_FILL_DETAILRepository iJOB_PLAN_DELINGHA_FILL_DETAILRepository;
		public IJOB_PLAN_DELINGHA_FILL_DETAILRepository IJOB_PLAN_DELINGHA_FILL_DETAILRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_DELINGHA_FILL_DETAILRepository==null)
					iJOB_PLAN_DELINGHA_FILL_DETAILRepository= new JOB_PLAN_DELINGHA_FILL_DETAILRepository();
				return iJOB_PLAN_DELINGHA_FILL_DETAILRepository;
			}
			set
			{
				iJOB_PLAN_DELINGHA_FILL_DETAILRepository= value;
			}
		}
		#endregion

		#region 187 数据接口 IJOB_PLAN_DELINGHA_MONTHRepository
		IJOB_PLAN_DELINGHA_MONTHRepository iJOB_PLAN_DELINGHA_MONTHRepository;
		public IJOB_PLAN_DELINGHA_MONTHRepository IJOB_PLAN_DELINGHA_MONTHRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_DELINGHA_MONTHRepository==null)
					iJOB_PLAN_DELINGHA_MONTHRepository= new JOB_PLAN_DELINGHA_MONTHRepository();
				return iJOB_PLAN_DELINGHA_MONTHRepository;
			}
			set
			{
				iJOB_PLAN_DELINGHA_MONTHRepository= value;
			}
		}
		#endregion

		#region 188 数据接口 IJOB_PLAN_DELINGHA_WEEKRepository
		IJOB_PLAN_DELINGHA_WEEKRepository iJOB_PLAN_DELINGHA_WEEKRepository;
		public IJOB_PLAN_DELINGHA_WEEKRepository IJOB_PLAN_DELINGHA_WEEKRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_DELINGHA_WEEKRepository==null)
					iJOB_PLAN_DELINGHA_WEEKRepository= new JOB_PLAN_DELINGHA_WEEKRepository();
				return iJOB_PLAN_DELINGHA_WEEKRepository;
			}
			set
			{
				iJOB_PLAN_DELINGHA_WEEKRepository= value;
			}
		}
		#endregion

		#region 189 数据接口 IJOB_PLAN_EQUIPMENTRepository
		IJOB_PLAN_EQUIPMENTRepository iJOB_PLAN_EQUIPMENTRepository;
		public IJOB_PLAN_EQUIPMENTRepository IJOB_PLAN_EQUIPMENTRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_EQUIPMENTRepository==null)
					iJOB_PLAN_EQUIPMENTRepository= new JOB_PLAN_EQUIPMENTRepository();
				return iJOB_PLAN_EQUIPMENTRepository;
			}
			set
			{
				iJOB_PLAN_EQUIPMENTRepository= value;
			}
		}
		#endregion

		#region 190 数据接口 IJOB_PLAN_LINERepository
		IJOB_PLAN_LINERepository iJOB_PLAN_LINERepository;
		public IJOB_PLAN_LINERepository IJOB_PLAN_LINERepository
		{
		 
			get 
			{
				if(iJOB_PLAN_LINERepository==null)
					iJOB_PLAN_LINERepository= new JOB_PLAN_LINERepository();
				return iJOB_PLAN_LINERepository;
			}
			set
			{
				iJOB_PLAN_LINERepository= value;
			}
		}
		#endregion

		#region 191 数据接口 IJOB_PLAN_LINE_EQUIANDTIMRepository
		IJOB_PLAN_LINE_EQUIANDTIMRepository iJOB_PLAN_LINE_EQUIANDTIMRepository;
		public IJOB_PLAN_LINE_EQUIANDTIMRepository IJOB_PLAN_LINE_EQUIANDTIMRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_LINE_EQUIANDTIMRepository==null)
					iJOB_PLAN_LINE_EQUIANDTIMRepository= new JOB_PLAN_LINE_EQUIANDTIMRepository();
				return iJOB_PLAN_LINE_EQUIANDTIMRepository;
			}
			set
			{
				iJOB_PLAN_LINE_EQUIANDTIMRepository= value;
			}
		}
		#endregion

		#region 192 数据接口 IJOB_PLAN_LOOKOUTRepository
		IJOB_PLAN_LOOKOUTRepository iJOB_PLAN_LOOKOUTRepository;
		public IJOB_PLAN_LOOKOUTRepository IJOB_PLAN_LOOKOUTRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_LOOKOUTRepository==null)
					iJOB_PLAN_LOOKOUTRepository= new JOB_PLAN_LOOKOUTRepository();
				return iJOB_PLAN_LOOKOUTRepository;
			}
			set
			{
				iJOB_PLAN_LOOKOUTRepository= value;
			}
		}
		#endregion

		#region 193 数据接口 IJOB_PLAN_MEMBERPHONE_MAPRepository
		IJOB_PLAN_MEMBERPHONE_MAPRepository iJOB_PLAN_MEMBERPHONE_MAPRepository;
		public IJOB_PLAN_MEMBERPHONE_MAPRepository IJOB_PLAN_MEMBERPHONE_MAPRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_MEMBERPHONE_MAPRepository==null)
					iJOB_PLAN_MEMBERPHONE_MAPRepository= new JOB_PLAN_MEMBERPHONE_MAPRepository();
				return iJOB_PLAN_MEMBERPHONE_MAPRepository;
			}
			set
			{
				iJOB_PLAN_MEMBERPHONE_MAPRepository= value;
			}
		}
		#endregion

		#region 194 数据接口 IJOB_PLAN_OLDRepository
		IJOB_PLAN_OLDRepository iJOB_PLAN_OLDRepository;
		public IJOB_PLAN_OLDRepository IJOB_PLAN_OLDRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_OLDRepository==null)
					iJOB_PLAN_OLDRepository= new JOB_PLAN_OLDRepository();
				return iJOB_PLAN_OLDRepository;
			}
			set
			{
				iJOB_PLAN_OLDRepository= value;
			}
		}
		#endregion

		#region 195 数据接口 IJOB_PLAN_PHONE_USERRepository
		IJOB_PLAN_PHONE_USERRepository iJOB_PLAN_PHONE_USERRepository;
		public IJOB_PLAN_PHONE_USERRepository IJOB_PLAN_PHONE_USERRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_PHONE_USERRepository==null)
					iJOB_PLAN_PHONE_USERRepository= new JOB_PLAN_PHONE_USERRepository();
				return iJOB_PLAN_PHONE_USERRepository;
			}
			set
			{
				iJOB_PLAN_PHONE_USERRepository= value;
			}
		}
		#endregion

		#region 196 数据接口 IJOB_PLAN_SAFERepository
		IJOB_PLAN_SAFERepository iJOB_PLAN_SAFERepository;
		public IJOB_PLAN_SAFERepository IJOB_PLAN_SAFERepository
		{
		 
			get 
			{
				if(iJOB_PLAN_SAFERepository==null)
					iJOB_PLAN_SAFERepository= new JOB_PLAN_SAFERepository();
				return iJOB_PLAN_SAFERepository;
			}
			set
			{
				iJOB_PLAN_SAFERepository= value;
			}
		}
		#endregion

		#region 197 数据接口 IJOB_PLAN_TRAINRepository
		IJOB_PLAN_TRAINRepository iJOB_PLAN_TRAINRepository;
		public IJOB_PLAN_TRAINRepository IJOB_PLAN_TRAINRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_TRAINRepository==null)
					iJOB_PLAN_TRAINRepository= new JOB_PLAN_TRAINRepository();
				return iJOB_PLAN_TRAINRepository;
			}
			set
			{
				iJOB_PLAN_TRAINRepository= value;
			}
		}
		#endregion

		#region 198 数据接口 IJOB_PLAN_TYPERepository
		IJOB_PLAN_TYPERepository iJOB_PLAN_TYPERepository;
		public IJOB_PLAN_TYPERepository IJOB_PLAN_TYPERepository
		{
		 
			get 
			{
				if(iJOB_PLAN_TYPERepository==null)
					iJOB_PLAN_TYPERepository= new JOB_PLAN_TYPERepository();
				return iJOB_PLAN_TYPERepository;
			}
			set
			{
				iJOB_PLAN_TYPERepository= value;
			}
		}
		#endregion

		#region 199 数据接口 IJOB_PLAN_UPDOWNRepository
		IJOB_PLAN_UPDOWNRepository iJOB_PLAN_UPDOWNRepository;
		public IJOB_PLAN_UPDOWNRepository IJOB_PLAN_UPDOWNRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_UPDOWNRepository==null)
					iJOB_PLAN_UPDOWNRepository= new JOB_PLAN_UPDOWNRepository();
				return iJOB_PLAN_UPDOWNRepository;
			}
			set
			{
				iJOB_PLAN_UPDOWNRepository= value;
			}
		}
		#endregion

		#region 200 数据接口 IJOB_PLAN_UPDOWNHISRepository
		IJOB_PLAN_UPDOWNHISRepository iJOB_PLAN_UPDOWNHISRepository;
		public IJOB_PLAN_UPDOWNHISRepository IJOB_PLAN_UPDOWNHISRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_UPDOWNHISRepository==null)
					iJOB_PLAN_UPDOWNHISRepository= new JOB_PLAN_UPDOWNHISRepository();
				return iJOB_PLAN_UPDOWNHISRepository;
			}
			set
			{
				iJOB_PLAN_UPDOWNHISRepository= value;
			}
		}
		#endregion

		#region 201 数据接口 IJOB_PLAN_WARNPHONESETRepository
		IJOB_PLAN_WARNPHONESETRepository iJOB_PLAN_WARNPHONESETRepository;
		public IJOB_PLAN_WARNPHONESETRepository IJOB_PLAN_WARNPHONESETRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_WARNPHONESETRepository==null)
					iJOB_PLAN_WARNPHONESETRepository= new JOB_PLAN_WARNPHONESETRepository();
				return iJOB_PLAN_WARNPHONESETRepository;
			}
			set
			{
				iJOB_PLAN_WARNPHONESETRepository= value;
			}
		}
		#endregion

		#region 202 数据接口 IJOB_PLAN_WARNPOSSETRepository
		IJOB_PLAN_WARNPOSSETRepository iJOB_PLAN_WARNPOSSETRepository;
		public IJOB_PLAN_WARNPOSSETRepository IJOB_PLAN_WARNPOSSETRepository
		{
		 
			get 
			{
				if(iJOB_PLAN_WARNPOSSETRepository==null)
					iJOB_PLAN_WARNPOSSETRepository= new JOB_PLAN_WARNPOSSETRepository();
				return iJOB_PLAN_WARNPOSSETRepository;
			}
			set
			{
				iJOB_PLAN_WARNPOSSETRepository= value;
			}
		}
		#endregion

		#region 203 数据接口 IJOB_PLANCONTROL_COMMANDRepository
		IJOB_PLANCONTROL_COMMANDRepository iJOB_PLANCONTROL_COMMANDRepository;
		public IJOB_PLANCONTROL_COMMANDRepository IJOB_PLANCONTROL_COMMANDRepository
		{
		 
			get 
			{
				if(iJOB_PLANCONTROL_COMMANDRepository==null)
					iJOB_PLANCONTROL_COMMANDRepository= new JOB_PLANCONTROL_COMMANDRepository();
				return iJOB_PLANCONTROL_COMMANDRepository;
			}
			set
			{
				iJOB_PLANCONTROL_COMMANDRepository= value;
			}
		}
		#endregion

		#region 204 数据接口 IJOB_WARNRepository
		IJOB_WARNRepository iJOB_WARNRepository;
		public IJOB_WARNRepository IJOB_WARNRepository
		{
		 
			get 
			{
				if(iJOB_WARNRepository==null)
					iJOB_WARNRepository= new JOB_WARNRepository();
				return iJOB_WARNRepository;
			}
			set
			{
				iJOB_WARNRepository= value;
			}
		}
		#endregion

		#region 205 数据接口 ILEDGER_BIGEQUI_TECHPARAMRepository
		ILEDGER_BIGEQUI_TECHPARAMRepository iLEDGER_BIGEQUI_TECHPARAMRepository;
		public ILEDGER_BIGEQUI_TECHPARAMRepository ILEDGER_BIGEQUI_TECHPARAMRepository
		{
		 
			get 
			{
				if(iLEDGER_BIGEQUI_TECHPARAMRepository==null)
					iLEDGER_BIGEQUI_TECHPARAMRepository= new LEDGER_BIGEQUI_TECHPARAMRepository();
				return iLEDGER_BIGEQUI_TECHPARAMRepository;
			}
			set
			{
				iLEDGER_BIGEQUI_TECHPARAMRepository= value;
			}
		}
		#endregion

		#region 206 数据接口 ILEDGER_DICT_INTERPHONERepository
		ILEDGER_DICT_INTERPHONERepository iLEDGER_DICT_INTERPHONERepository;
		public ILEDGER_DICT_INTERPHONERepository ILEDGER_DICT_INTERPHONERepository
		{
		 
			get 
			{
				if(iLEDGER_DICT_INTERPHONERepository==null)
					iLEDGER_DICT_INTERPHONERepository= new LEDGER_DICT_INTERPHONERepository();
				return iLEDGER_DICT_INTERPHONERepository;
			}
			set
			{
				iLEDGER_DICT_INTERPHONERepository= value;
			}
		}
		#endregion

		#region 207 数据接口 ILEDGER_DICT_LARGEMACHINERYRepository
		ILEDGER_DICT_LARGEMACHINERYRepository iLEDGER_DICT_LARGEMACHINERYRepository;
		public ILEDGER_DICT_LARGEMACHINERYRepository ILEDGER_DICT_LARGEMACHINERYRepository
		{
		 
			get 
			{
				if(iLEDGER_DICT_LARGEMACHINERYRepository==null)
					iLEDGER_DICT_LARGEMACHINERYRepository= new LEDGER_DICT_LARGEMACHINERYRepository();
				return iLEDGER_DICT_LARGEMACHINERYRepository;
			}
			set
			{
				iLEDGER_DICT_LARGEMACHINERYRepository= value;
			}
		}
		#endregion

		#region 208 数据接口 ILEDGER_DICT_MACHINETOOLRepository
		ILEDGER_DICT_MACHINETOOLRepository iLEDGER_DICT_MACHINETOOLRepository;
		public ILEDGER_DICT_MACHINETOOLRepository ILEDGER_DICT_MACHINETOOLRepository
		{
		 
			get 
			{
				if(iLEDGER_DICT_MACHINETOOLRepository==null)
					iLEDGER_DICT_MACHINETOOLRepository= new LEDGER_DICT_MACHINETOOLRepository();
				return iLEDGER_DICT_MACHINETOOLRepository;
			}
			set
			{
				iLEDGER_DICT_MACHINETOOLRepository= value;
			}
		}
		#endregion

		#region 209 数据接口 ILEDGER_DICT_MECHANICALVEHICLERepository
		ILEDGER_DICT_MECHANICALVEHICLERepository iLEDGER_DICT_MECHANICALVEHICLERepository;
		public ILEDGER_DICT_MECHANICALVEHICLERepository ILEDGER_DICT_MECHANICALVEHICLERepository
		{
		 
			get 
			{
				if(iLEDGER_DICT_MECHANICALVEHICLERepository==null)
					iLEDGER_DICT_MECHANICALVEHICLERepository= new LEDGER_DICT_MECHANICALVEHICLERepository();
				return iLEDGER_DICT_MECHANICALVEHICLERepository;
			}
			set
			{
				iLEDGER_DICT_MECHANICALVEHICLERepository= value;
			}
		}
		#endregion

		#region 210 数据接口 ILEDGER_DICT_ROADVEHICLERepository
		ILEDGER_DICT_ROADVEHICLERepository iLEDGER_DICT_ROADVEHICLERepository;
		public ILEDGER_DICT_ROADVEHICLERepository ILEDGER_DICT_ROADVEHICLERepository
		{
		 
			get 
			{
				if(iLEDGER_DICT_ROADVEHICLERepository==null)
					iLEDGER_DICT_ROADVEHICLERepository= new LEDGER_DICT_ROADVEHICLERepository();
				return iLEDGER_DICT_ROADVEHICLERepository;
			}
			set
			{
				iLEDGER_DICT_ROADVEHICLERepository= value;
			}
		}
		#endregion

		#region 211 数据接口 ILEDGER_DICT_TRAFFICVEHICLERepository
		ILEDGER_DICT_TRAFFICVEHICLERepository iLEDGER_DICT_TRAFFICVEHICLERepository;
		public ILEDGER_DICT_TRAFFICVEHICLERepository ILEDGER_DICT_TRAFFICVEHICLERepository
		{
		 
			get 
			{
				if(iLEDGER_DICT_TRAFFICVEHICLERepository==null)
					iLEDGER_DICT_TRAFFICVEHICLERepository= new LEDGER_DICT_TRAFFICVEHICLERepository();
				return iLEDGER_DICT_TRAFFICVEHICLERepository;
			}
			set
			{
				iLEDGER_DICT_TRAFFICVEHICLERepository= value;
			}
		}
		#endregion

		#region 212 数据接口 ILEDGER_INTERPHONERepository
		ILEDGER_INTERPHONERepository iLEDGER_INTERPHONERepository;
		public ILEDGER_INTERPHONERepository ILEDGER_INTERPHONERepository
		{
		 
			get 
			{
				if(iLEDGER_INTERPHONERepository==null)
					iLEDGER_INTERPHONERepository= new LEDGER_INTERPHONERepository();
				return iLEDGER_INTERPHONERepository;
			}
			set
			{
				iLEDGER_INTERPHONERepository= value;
			}
		}
		#endregion

		#region 213 数据接口 ILEDGER_LARGE_MACHINERYRepository
		ILEDGER_LARGE_MACHINERYRepository iLEDGER_LARGE_MACHINERYRepository;
		public ILEDGER_LARGE_MACHINERYRepository ILEDGER_LARGE_MACHINERYRepository
		{
		 
			get 
			{
				if(iLEDGER_LARGE_MACHINERYRepository==null)
					iLEDGER_LARGE_MACHINERYRepository= new LEDGER_LARGE_MACHINERYRepository();
				return iLEDGER_LARGE_MACHINERYRepository;
			}
			set
			{
				iLEDGER_LARGE_MACHINERYRepository= value;
			}
		}
		#endregion

		#region 214 数据接口 ILEDGER_LEVELCROSS_INFORepository
		ILEDGER_LEVELCROSS_INFORepository iLEDGER_LEVELCROSS_INFORepository;
		public ILEDGER_LEVELCROSS_INFORepository ILEDGER_LEVELCROSS_INFORepository
		{
		 
			get 
			{
				if(iLEDGER_LEVELCROSS_INFORepository==null)
					iLEDGER_LEVELCROSS_INFORepository= new LEDGER_LEVELCROSS_INFORepository();
				return iLEDGER_LEVELCROSS_INFORepository;
			}
			set
			{
				iLEDGER_LEVELCROSS_INFORepository= value;
			}
		}
		#endregion

		#region 215 数据接口 ILEDGER_LEVELCROSS_PIPE_LINERepository
		ILEDGER_LEVELCROSS_PIPE_LINERepository iLEDGER_LEVELCROSS_PIPE_LINERepository;
		public ILEDGER_LEVELCROSS_PIPE_LINERepository ILEDGER_LEVELCROSS_PIPE_LINERepository
		{
		 
			get 
			{
				if(iLEDGER_LEVELCROSS_PIPE_LINERepository==null)
					iLEDGER_LEVELCROSS_PIPE_LINERepository= new LEDGER_LEVELCROSS_PIPE_LINERepository();
				return iLEDGER_LEVELCROSS_PIPE_LINERepository;
			}
			set
			{
				iLEDGER_LEVELCROSS_PIPE_LINERepository= value;
			}
		}
		#endregion

		#region 216 数据接口 ILEDGER_LEVELCROSS_REPAIR_LINERepository
		ILEDGER_LEVELCROSS_REPAIR_LINERepository iLEDGER_LEVELCROSS_REPAIR_LINERepository;
		public ILEDGER_LEVELCROSS_REPAIR_LINERepository ILEDGER_LEVELCROSS_REPAIR_LINERepository
		{
		 
			get 
			{
				if(iLEDGER_LEVELCROSS_REPAIR_LINERepository==null)
					iLEDGER_LEVELCROSS_REPAIR_LINERepository= new LEDGER_LEVELCROSS_REPAIR_LINERepository();
				return iLEDGER_LEVELCROSS_REPAIR_LINERepository;
			}
			set
			{
				iLEDGER_LEVELCROSS_REPAIR_LINERepository= value;
			}
		}
		#endregion

		#region 217 数据接口 ILEDGER_MACHINE_TOOLRepository
		ILEDGER_MACHINE_TOOLRepository iLEDGER_MACHINE_TOOLRepository;
		public ILEDGER_MACHINE_TOOLRepository ILEDGER_MACHINE_TOOLRepository
		{
		 
			get 
			{
				if(iLEDGER_MACHINE_TOOLRepository==null)
					iLEDGER_MACHINE_TOOLRepository= new LEDGER_MACHINE_TOOLRepository();
				return iLEDGER_MACHINE_TOOLRepository;
			}
			set
			{
				iLEDGER_MACHINE_TOOLRepository= value;
			}
		}
		#endregion

		#region 218 数据接口 ILEDGER_MECHANICAL_VEHICLERepository
		ILEDGER_MECHANICAL_VEHICLERepository iLEDGER_MECHANICAL_VEHICLERepository;
		public ILEDGER_MECHANICAL_VEHICLERepository ILEDGER_MECHANICAL_VEHICLERepository
		{
		 
			get 
			{
				if(iLEDGER_MECHANICAL_VEHICLERepository==null)
					iLEDGER_MECHANICAL_VEHICLERepository= new LEDGER_MECHANICAL_VEHICLERepository();
				return iLEDGER_MECHANICAL_VEHICLERepository;
			}
			set
			{
				iLEDGER_MECHANICAL_VEHICLERepository= value;
			}
		}
		#endregion

		#region 219 数据接口 ILEDGER_RAIL_MATERIALRepository
		ILEDGER_RAIL_MATERIALRepository iLEDGER_RAIL_MATERIALRepository;
		public ILEDGER_RAIL_MATERIALRepository ILEDGER_RAIL_MATERIALRepository
		{
		 
			get 
			{
				if(iLEDGER_RAIL_MATERIALRepository==null)
					iLEDGER_RAIL_MATERIALRepository= new LEDGER_RAIL_MATERIALRepository();
				return iLEDGER_RAIL_MATERIALRepository;
			}
			set
			{
				iLEDGER_RAIL_MATERIALRepository= value;
			}
		}
		#endregion

		#region 220 数据接口 ILEDGER_RAILCAR_TECHPARAMRepository
		ILEDGER_RAILCAR_TECHPARAMRepository iLEDGER_RAILCAR_TECHPARAMRepository;
		public ILEDGER_RAILCAR_TECHPARAMRepository ILEDGER_RAILCAR_TECHPARAMRepository
		{
		 
			get 
			{
				if(iLEDGER_RAILCAR_TECHPARAMRepository==null)
					iLEDGER_RAILCAR_TECHPARAMRepository= new LEDGER_RAILCAR_TECHPARAMRepository();
				return iLEDGER_RAILCAR_TECHPARAMRepository;
			}
			set
			{
				iLEDGER_RAILCAR_TECHPARAMRepository= value;
			}
		}
		#endregion

		#region 221 数据接口 ILEDGER_ROAD_VEHICLERepository
		ILEDGER_ROAD_VEHICLERepository iLEDGER_ROAD_VEHICLERepository;
		public ILEDGER_ROAD_VEHICLERepository ILEDGER_ROAD_VEHICLERepository
		{
		 
			get 
			{
				if(iLEDGER_ROAD_VEHICLERepository==null)
					iLEDGER_ROAD_VEHICLERepository= new LEDGER_ROAD_VEHICLERepository();
				return iLEDGER_ROAD_VEHICLERepository;
			}
			set
			{
				iLEDGER_ROAD_VEHICLERepository= value;
			}
		}
		#endregion

		#region 222 数据接口 ILEDGER_SMALLEQUI_TECHPARAMRepository
		ILEDGER_SMALLEQUI_TECHPARAMRepository iLEDGER_SMALLEQUI_TECHPARAMRepository;
		public ILEDGER_SMALLEQUI_TECHPARAMRepository ILEDGER_SMALLEQUI_TECHPARAMRepository
		{
		 
			get 
			{
				if(iLEDGER_SMALLEQUI_TECHPARAMRepository==null)
					iLEDGER_SMALLEQUI_TECHPARAMRepository= new LEDGER_SMALLEQUI_TECHPARAMRepository();
				return iLEDGER_SMALLEQUI_TECHPARAMRepository;
			}
			set
			{
				iLEDGER_SMALLEQUI_TECHPARAMRepository= value;
			}
		}
		#endregion

		#region 223 数据接口 ILEDGER_TRAFFIC_VEHICLESRepository
		ILEDGER_TRAFFIC_VEHICLESRepository iLEDGER_TRAFFIC_VEHICLESRepository;
		public ILEDGER_TRAFFIC_VEHICLESRepository ILEDGER_TRAFFIC_VEHICLESRepository
		{
		 
			get 
			{
				if(iLEDGER_TRAFFIC_VEHICLESRepository==null)
					iLEDGER_TRAFFIC_VEHICLESRepository= new LEDGER_TRAFFIC_VEHICLESRepository();
				return iLEDGER_TRAFFIC_VEHICLESRepository;
			}
			set
			{
				iLEDGER_TRAFFIC_VEHICLESRepository= value;
			}
		}
		#endregion

		#region 224 数据接口 ILKJ_ALLOW_SPEEDRepository
		ILKJ_ALLOW_SPEEDRepository iLKJ_ALLOW_SPEEDRepository;
		public ILKJ_ALLOW_SPEEDRepository ILKJ_ALLOW_SPEEDRepository
		{
		 
			get 
			{
				if(iLKJ_ALLOW_SPEEDRepository==null)
					iLKJ_ALLOW_SPEEDRepository= new LKJ_ALLOW_SPEEDRepository();
				return iLKJ_ALLOW_SPEEDRepository;
			}
			set
			{
				iLKJ_ALLOW_SPEEDRepository= value;
			}
		}
		#endregion

		#region 225 数据接口 ILKJ_BRIDGERepository
		ILKJ_BRIDGERepository iLKJ_BRIDGERepository;
		public ILKJ_BRIDGERepository ILKJ_BRIDGERepository
		{
		 
			get 
			{
				if(iLKJ_BRIDGERepository==null)
					iLKJ_BRIDGERepository= new LKJ_BRIDGERepository();
				return iLKJ_BRIDGERepository;
			}
			set
			{
				iLKJ_BRIDGERepository= value;
			}
		}
		#endregion

		#region 226 数据接口 ILKJ_BROKEN_CHAINRepository
		ILKJ_BROKEN_CHAINRepository iLKJ_BROKEN_CHAINRepository;
		public ILKJ_BROKEN_CHAINRepository ILKJ_BROKEN_CHAINRepository
		{
		 
			get 
			{
				if(iLKJ_BROKEN_CHAINRepository==null)
					iLKJ_BROKEN_CHAINRepository= new LKJ_BROKEN_CHAINRepository();
				return iLKJ_BROKEN_CHAINRepository;
			}
			set
			{
				iLKJ_BROKEN_CHAINRepository= value;
			}
		}
		#endregion

		#region 227 数据接口 ILKJ_CROSSINGRepository
		ILKJ_CROSSINGRepository iLKJ_CROSSINGRepository;
		public ILKJ_CROSSINGRepository ILKJ_CROSSINGRepository
		{
		 
			get 
			{
				if(iLKJ_CROSSINGRepository==null)
					iLKJ_CROSSINGRepository= new LKJ_CROSSINGRepository();
				return iLKJ_CROSSINGRepository;
			}
			set
			{
				iLKJ_CROSSINGRepository= value;
			}
		}
		#endregion

		#region 228 数据接口 ILKJ_CURVERepository
		ILKJ_CURVERepository iLKJ_CURVERepository;
		public ILKJ_CURVERepository ILKJ_CURVERepository
		{
		 
			get 
			{
				if(iLKJ_CURVERepository==null)
					iLKJ_CURVERepository= new LKJ_CURVERepository();
				return iLKJ_CURVERepository;
			}
			set
			{
				iLKJ_CURVERepository= value;
			}
		}
		#endregion

		#region 229 数据接口 ILKJ_LINE_NAMERepository
		ILKJ_LINE_NAMERepository iLKJ_LINE_NAMERepository;
		public ILKJ_LINE_NAMERepository ILKJ_LINE_NAMERepository
		{
		 
			get 
			{
				if(iLKJ_LINE_NAMERepository==null)
					iLKJ_LINE_NAMERepository= new LKJ_LINE_NAMERepository();
				return iLKJ_LINE_NAMERepository;
			}
			set
			{
				iLKJ_LINE_NAMERepository= value;
			}
		}
		#endregion

		#region 230 数据接口 ILKJ_MAIN_TRACK_MILEAGERepository
		ILKJ_MAIN_TRACK_MILEAGERepository iLKJ_MAIN_TRACK_MILEAGERepository;
		public ILKJ_MAIN_TRACK_MILEAGERepository ILKJ_MAIN_TRACK_MILEAGERepository
		{
		 
			get 
			{
				if(iLKJ_MAIN_TRACK_MILEAGERepository==null)
					iLKJ_MAIN_TRACK_MILEAGERepository= new LKJ_MAIN_TRACK_MILEAGERepository();
				return iLKJ_MAIN_TRACK_MILEAGERepository;
			}
			set
			{
				iLKJ_MAIN_TRACK_MILEAGERepository= value;
			}
		}
		#endregion

		#region 231 数据接口 ILKJ_ROAD_FORKRepository
		ILKJ_ROAD_FORKRepository iLKJ_ROAD_FORKRepository;
		public ILKJ_ROAD_FORKRepository ILKJ_ROAD_FORKRepository
		{
		 
			get 
			{
				if(iLKJ_ROAD_FORKRepository==null)
					iLKJ_ROAD_FORKRepository= new LKJ_ROAD_FORKRepository();
				return iLKJ_ROAD_FORKRepository;
			}
			set
			{
				iLKJ_ROAD_FORKRepository= value;
			}
		}
		#endregion

		#region 232 数据接口 ILKJ_SLOPERepository
		ILKJ_SLOPERepository iLKJ_SLOPERepository;
		public ILKJ_SLOPERepository ILKJ_SLOPERepository
		{
		 
			get 
			{
				if(iLKJ_SLOPERepository==null)
					iLKJ_SLOPERepository= new LKJ_SLOPERepository();
				return iLKJ_SLOPERepository;
			}
			set
			{
				iLKJ_SLOPERepository= value;
			}
		}
		#endregion

		#region 233 数据接口 ILKJ_STATIONRepository
		ILKJ_STATIONRepository iLKJ_STATIONRepository;
		public ILKJ_STATIONRepository ILKJ_STATIONRepository
		{
		 
			get 
			{
				if(iLKJ_STATIONRepository==null)
					iLKJ_STATIONRepository= new LKJ_STATIONRepository();
				return iLKJ_STATIONRepository;
			}
			set
			{
				iLKJ_STATIONRepository= value;
			}
		}
		#endregion

		#region 234 数据接口 ILKJ_TRACKRepository
		ILKJ_TRACKRepository iLKJ_TRACKRepository;
		public ILKJ_TRACKRepository ILKJ_TRACKRepository
		{
		 
			get 
			{
				if(iLKJ_TRACKRepository==null)
					iLKJ_TRACKRepository= new LKJ_TRACKRepository();
				return iLKJ_TRACKRepository;
			}
			set
			{
				iLKJ_TRACKRepository= value;
			}
		}
		#endregion

		#region 235 数据接口 ILKJ_TUNNELRepository
		ILKJ_TUNNELRepository iLKJ_TUNNELRepository;
		public ILKJ_TUNNELRepository ILKJ_TUNNELRepository
		{
		 
			get 
			{
				if(iLKJ_TUNNELRepository==null)
					iLKJ_TUNNELRepository= new LKJ_TUNNELRepository();
				return iLKJ_TUNNELRepository;
			}
			set
			{
				iLKJ_TUNNELRepository= value;
			}
		}
		#endregion

		#region 236 数据接口 IMATERIAL_BDATE_DICRepository
		IMATERIAL_BDATE_DICRepository iMATERIAL_BDATE_DICRepository;
		public IMATERIAL_BDATE_DICRepository IMATERIAL_BDATE_DICRepository
		{
		 
			get 
			{
				if(iMATERIAL_BDATE_DICRepository==null)
					iMATERIAL_BDATE_DICRepository= new MATERIAL_BDATE_DICRepository();
				return iMATERIAL_BDATE_DICRepository;
			}
			set
			{
				iMATERIAL_BDATE_DICRepository= value;
			}
		}
		#endregion

		#region 237 数据接口 IMATERIAL_BDATE_MATERIALNAMERepository
		IMATERIAL_BDATE_MATERIALNAMERepository iMATERIAL_BDATE_MATERIALNAMERepository;
		public IMATERIAL_BDATE_MATERIALNAMERepository IMATERIAL_BDATE_MATERIALNAMERepository
		{
		 
			get 
			{
				if(iMATERIAL_BDATE_MATERIALNAMERepository==null)
					iMATERIAL_BDATE_MATERIALNAMERepository= new MATERIAL_BDATE_MATERIALNAMERepository();
				return iMATERIAL_BDATE_MATERIALNAMERepository;
			}
			set
			{
				iMATERIAL_BDATE_MATERIALNAMERepository= value;
			}
		}
		#endregion

		#region 238 数据接口 IMATERIAL_INOUT_BILLRepository
		IMATERIAL_INOUT_BILLRepository iMATERIAL_INOUT_BILLRepository;
		public IMATERIAL_INOUT_BILLRepository IMATERIAL_INOUT_BILLRepository
		{
		 
			get 
			{
				if(iMATERIAL_INOUT_BILLRepository==null)
					iMATERIAL_INOUT_BILLRepository= new MATERIAL_INOUT_BILLRepository();
				return iMATERIAL_INOUT_BILLRepository;
			}
			set
			{
				iMATERIAL_INOUT_BILLRepository= value;
			}
		}
		#endregion

		#region 239 数据接口 IMATERIAL_INOUT_BILL_DETAILRepository
		IMATERIAL_INOUT_BILL_DETAILRepository iMATERIAL_INOUT_BILL_DETAILRepository;
		public IMATERIAL_INOUT_BILL_DETAILRepository IMATERIAL_INOUT_BILL_DETAILRepository
		{
		 
			get 
			{
				if(iMATERIAL_INOUT_BILL_DETAILRepository==null)
					iMATERIAL_INOUT_BILL_DETAILRepository= new MATERIAL_INOUT_BILL_DETAILRepository();
				return iMATERIAL_INOUT_BILL_DETAILRepository;
			}
			set
			{
				iMATERIAL_INOUT_BILL_DETAILRepository= value;
			}
		}
		#endregion

		#region 240 数据接口 IMATERIAL_MATERIALMNGRepository
		IMATERIAL_MATERIALMNGRepository iMATERIAL_MATERIALMNGRepository;
		public IMATERIAL_MATERIALMNGRepository IMATERIAL_MATERIALMNGRepository
		{
		 
			get 
			{
				if(iMATERIAL_MATERIALMNGRepository==null)
					iMATERIAL_MATERIALMNGRepository= new MATERIAL_MATERIALMNGRepository();
				return iMATERIAL_MATERIALMNGRepository;
			}
			set
			{
				iMATERIAL_MATERIALMNGRepository= value;
			}
		}
		#endregion

		#region 241 数据接口 IMATERIAL_MONSURPRUSRepository
		IMATERIAL_MONSURPRUSRepository iMATERIAL_MONSURPRUSRepository;
		public IMATERIAL_MONSURPRUSRepository IMATERIAL_MONSURPRUSRepository
		{
		 
			get 
			{
				if(iMATERIAL_MONSURPRUSRepository==null)
					iMATERIAL_MONSURPRUSRepository= new MATERIAL_MONSURPRUSRepository();
				return iMATERIAL_MONSURPRUSRepository;
			}
			set
			{
				iMATERIAL_MONSURPRUSRepository= value;
			}
		}
		#endregion

		#region 242 数据接口 IOIL_BDATA_CURVERepository
		IOIL_BDATA_CURVERepository iOIL_BDATA_CURVERepository;
		public IOIL_BDATA_CURVERepository IOIL_BDATA_CURVERepository
		{
		 
			get 
			{
				if(iOIL_BDATA_CURVERepository==null)
					iOIL_BDATA_CURVERepository= new OIL_BDATA_CURVERepository();
				return iOIL_BDATA_CURVERepository;
			}
			set
			{
				iOIL_BDATA_CURVERepository= value;
			}
		}
		#endregion

		#region 243 数据接口 IOIL_BDATA_DEVICERepository
		IOIL_BDATA_DEVICERepository iOIL_BDATA_DEVICERepository;
		public IOIL_BDATA_DEVICERepository IOIL_BDATA_DEVICERepository
		{
		 
			get 
			{
				if(iOIL_BDATA_DEVICERepository==null)
					iOIL_BDATA_DEVICERepository= new OIL_BDATA_DEVICERepository();
				return iOIL_BDATA_DEVICERepository;
			}
			set
			{
				iOIL_BDATA_DEVICERepository= value;
			}
		}
		#endregion

		#region 244 数据接口 IOIL_BDATA_OPRepository
		IOIL_BDATA_OPRepository iOIL_BDATA_OPRepository;
		public IOIL_BDATA_OPRepository IOIL_BDATA_OPRepository
		{
		 
			get 
			{
				if(iOIL_BDATA_OPRepository==null)
					iOIL_BDATA_OPRepository= new OIL_BDATA_OPRepository();
				return iOIL_BDATA_OPRepository;
			}
			set
			{
				iOIL_BDATA_OPRepository= value;
			}
		}
		#endregion

		#region 245 数据接口 IOIL_RECORD_CHECKRepository
		IOIL_RECORD_CHECKRepository iOIL_RECORD_CHECKRepository;
		public IOIL_RECORD_CHECKRepository IOIL_RECORD_CHECKRepository
		{
		 
			get 
			{
				if(iOIL_RECORD_CHECKRepository==null)
					iOIL_RECORD_CHECKRepository= new OIL_RECORD_CHECKRepository();
				return iOIL_RECORD_CHECKRepository;
			}
			set
			{
				iOIL_RECORD_CHECKRepository= value;
			}
		}
		#endregion

		#region 246 数据接口 IOIL_RECORD_OILRepository
		IOIL_RECORD_OILRepository iOIL_RECORD_OILRepository;
		public IOIL_RECORD_OILRepository IOIL_RECORD_OILRepository
		{
		 
			get 
			{
				if(iOIL_RECORD_OILRepository==null)
					iOIL_RECORD_OILRepository= new OIL_RECORD_OILRepository();
				return iOIL_RECORD_OILRepository;
			}
			set
			{
				iOIL_RECORD_OILRepository= value;
			}
		}
		#endregion

		#region 247 数据接口 IPHONEDICRepository
		IPHONEDICRepository iPHONEDICRepository;
		public IPHONEDICRepository IPHONEDICRepository
		{
		 
			get 
			{
				if(iPHONEDICRepository==null)
					iPHONEDICRepository= new PHONEDICRepository();
				return iPHONEDICRepository;
			}
			set
			{
				iPHONEDICRepository= value;
			}
		}
		#endregion

		#region 248 数据接口 IPROTECTEDNET_BDATA_DEVICERepository
		IPROTECTEDNET_BDATA_DEVICERepository iPROTECTEDNET_BDATA_DEVICERepository;
		public IPROTECTEDNET_BDATA_DEVICERepository IPROTECTEDNET_BDATA_DEVICERepository
		{
		 
			get 
			{
				if(iPROTECTEDNET_BDATA_DEVICERepository==null)
					iPROTECTEDNET_BDATA_DEVICERepository= new PROTECTEDNET_BDATA_DEVICERepository();
				return iPROTECTEDNET_BDATA_DEVICERepository;
			}
			set
			{
				iPROTECTEDNET_BDATA_DEVICERepository= value;
			}
		}
		#endregion

		#region 249 数据接口 IPROTECTEDNET_RECORD_CHECKRepository
		IPROTECTEDNET_RECORD_CHECKRepository iPROTECTEDNET_RECORD_CHECKRepository;
		public IPROTECTEDNET_RECORD_CHECKRepository IPROTECTEDNET_RECORD_CHECKRepository
		{
		 
			get 
			{
				if(iPROTECTEDNET_RECORD_CHECKRepository==null)
					iPROTECTEDNET_RECORD_CHECKRepository= new PROTECTEDNET_RECORD_CHECKRepository();
				return iPROTECTEDNET_RECORD_CHECKRepository;
			}
			set
			{
				iPROTECTEDNET_RECORD_CHECKRepository= value;
			}
		}
		#endregion

		#region 250 数据接口 IPROTECTEDNET_RECORD_WARNRepository
		IPROTECTEDNET_RECORD_WARNRepository iPROTECTEDNET_RECORD_WARNRepository;
		public IPROTECTEDNET_RECORD_WARNRepository IPROTECTEDNET_RECORD_WARNRepository
		{
		 
			get 
			{
				if(iPROTECTEDNET_RECORD_WARNRepository==null)
					iPROTECTEDNET_RECORD_WARNRepository= new PROTECTEDNET_RECORD_WARNRepository();
				return iPROTECTEDNET_RECORD_WARNRepository;
			}
			set
			{
				iPROTECTEDNET_RECORD_WARNRepository= value;
			}
		}
		#endregion

		#region 251 数据接口 IPROTECTEDNET_VIDEO_FILERepository
		IPROTECTEDNET_VIDEO_FILERepository iPROTECTEDNET_VIDEO_FILERepository;
		public IPROTECTEDNET_VIDEO_FILERepository IPROTECTEDNET_VIDEO_FILERepository
		{
		 
			get 
			{
				if(iPROTECTEDNET_VIDEO_FILERepository==null)
					iPROTECTEDNET_VIDEO_FILERepository= new PROTECTEDNET_VIDEO_FILERepository();
				return iPROTECTEDNET_VIDEO_FILERepository;
			}
			set
			{
				iPROTECTEDNET_VIDEO_FILERepository= value;
			}
		}
		#endregion

		#region 252 数据接口 IRAIL_BDATA_HOSTRepository
		IRAIL_BDATA_HOSTRepository iRAIL_BDATA_HOSTRepository;
		public IRAIL_BDATA_HOSTRepository IRAIL_BDATA_HOSTRepository
		{
		 
			get 
			{
				if(iRAIL_BDATA_HOSTRepository==null)
					iRAIL_BDATA_HOSTRepository= new RAIL_BDATA_HOSTRepository();
				return iRAIL_BDATA_HOSTRepository;
			}
			set
			{
				iRAIL_BDATA_HOSTRepository= value;
			}
		}
		#endregion

		#region 253 数据接口 IRAIL_BDATA_POINTRepository
		IRAIL_BDATA_POINTRepository iRAIL_BDATA_POINTRepository;
		public IRAIL_BDATA_POINTRepository IRAIL_BDATA_POINTRepository
		{
		 
			get 
			{
				if(iRAIL_BDATA_POINTRepository==null)
					iRAIL_BDATA_POINTRepository= new RAIL_BDATA_POINTRepository();
				return iRAIL_BDATA_POINTRepository;
			}
			set
			{
				iRAIL_BDATA_POINTRepository= value;
			}
		}
		#endregion

		#region 254 数据接口 IRAIL_BDATA_SENDPHONENORepository
		IRAIL_BDATA_SENDPHONENORepository iRAIL_BDATA_SENDPHONENORepository;
		public IRAIL_BDATA_SENDPHONENORepository IRAIL_BDATA_SENDPHONENORepository
		{
		 
			get 
			{
				if(iRAIL_BDATA_SENDPHONENORepository==null)
					iRAIL_BDATA_SENDPHONENORepository= new RAIL_BDATA_SENDPHONENORepository();
				return iRAIL_BDATA_SENDPHONENORepository;
			}
			set
			{
				iRAIL_BDATA_SENDPHONENORepository= value;
			}
		}
		#endregion

		#region 255 数据接口 IRAIL_CARRIERBDATA_POINTRepository
		IRAIL_CARRIERBDATA_POINTRepository iRAIL_CARRIERBDATA_POINTRepository;
		public IRAIL_CARRIERBDATA_POINTRepository IRAIL_CARRIERBDATA_POINTRepository
		{
		 
			get 
			{
				if(iRAIL_CARRIERBDATA_POINTRepository==null)
					iRAIL_CARRIERBDATA_POINTRepository= new RAIL_CARRIERBDATA_POINTRepository();
				return iRAIL_CARRIERBDATA_POINTRepository;
			}
			set
			{
				iRAIL_CARRIERBDATA_POINTRepository= value;
			}
		}
		#endregion

		#region 256 数据接口 IRAIL_CARRIERBDATA_SECTIONRepository
		IRAIL_CARRIERBDATA_SECTIONRepository iRAIL_CARRIERBDATA_SECTIONRepository;
		public IRAIL_CARRIERBDATA_SECTIONRepository IRAIL_CARRIERBDATA_SECTIONRepository
		{
		 
			get 
			{
				if(iRAIL_CARRIERBDATA_SECTIONRepository==null)
					iRAIL_CARRIERBDATA_SECTIONRepository= new RAIL_CARRIERBDATA_SECTIONRepository();
				return iRAIL_CARRIERBDATA_SECTIONRepository;
			}
			set
			{
				iRAIL_CARRIERBDATA_SECTIONRepository= value;
			}
		}
		#endregion

		#region 257 数据接口 IRAIL_CARRIERDEVICE_STATUSRepository
		IRAIL_CARRIERDEVICE_STATUSRepository iRAIL_CARRIERDEVICE_STATUSRepository;
		public IRAIL_CARRIERDEVICE_STATUSRepository IRAIL_CARRIERDEVICE_STATUSRepository
		{
		 
			get 
			{
				if(iRAIL_CARRIERDEVICE_STATUSRepository==null)
					iRAIL_CARRIERDEVICE_STATUSRepository= new RAIL_CARRIERDEVICE_STATUSRepository();
				return iRAIL_CARRIERDEVICE_STATUSRepository;
			}
			set
			{
				iRAIL_CARRIERDEVICE_STATUSRepository= value;
			}
		}
		#endregion

		#region 258 数据接口 IRAIL_CARRIERDEVICE_WARNRepository
		IRAIL_CARRIERDEVICE_WARNRepository iRAIL_CARRIERDEVICE_WARNRepository;
		public IRAIL_CARRIERDEVICE_WARNRepository IRAIL_CARRIERDEVICE_WARNRepository
		{
		 
			get 
			{
				if(iRAIL_CARRIERDEVICE_WARNRepository==null)
					iRAIL_CARRIERDEVICE_WARNRepository= new RAIL_CARRIERDEVICE_WARNRepository();
				return iRAIL_CARRIERDEVICE_WARNRepository;
			}
			set
			{
				iRAIL_CARRIERDEVICE_WARNRepository= value;
			}
		}
		#endregion

		#region 259 数据接口 IRAIL_CARRIERRECORD_POINTRepository
		IRAIL_CARRIERRECORD_POINTRepository iRAIL_CARRIERRECORD_POINTRepository;
		public IRAIL_CARRIERRECORD_POINTRepository IRAIL_CARRIERRECORD_POINTRepository
		{
		 
			get 
			{
				if(iRAIL_CARRIERRECORD_POINTRepository==null)
					iRAIL_CARRIERRECORD_POINTRepository= new RAIL_CARRIERRECORD_POINTRepository();
				return iRAIL_CARRIERRECORD_POINTRepository;
			}
			set
			{
				iRAIL_CARRIERRECORD_POINTRepository= value;
			}
		}
		#endregion

		#region 260 数据接口 IRAIL_CARRIERRECORD_WARNRepository
		IRAIL_CARRIERRECORD_WARNRepository iRAIL_CARRIERRECORD_WARNRepository;
		public IRAIL_CARRIERRECORD_WARNRepository IRAIL_CARRIERRECORD_WARNRepository
		{
		 
			get 
			{
				if(iRAIL_CARRIERRECORD_WARNRepository==null)
					iRAIL_CARRIERRECORD_WARNRepository= new RAIL_CARRIERRECORD_WARNRepository();
				return iRAIL_CARRIERRECORD_WARNRepository;
			}
			set
			{
				iRAIL_CARRIERRECORD_WARNRepository= value;
			}
		}
		#endregion

		#region 261 数据接口 IRAIL_CARRIERRECORD_WARN_FINALRepository
		IRAIL_CARRIERRECORD_WARN_FINALRepository iRAIL_CARRIERRECORD_WARN_FINALRepository;
		public IRAIL_CARRIERRECORD_WARN_FINALRepository IRAIL_CARRIERRECORD_WARN_FINALRepository
		{
		 
			get 
			{
				if(iRAIL_CARRIERRECORD_WARN_FINALRepository==null)
					iRAIL_CARRIERRECORD_WARN_FINALRepository= new RAIL_CARRIERRECORD_WARN_FINALRepository();
				return iRAIL_CARRIERRECORD_WARN_FINALRepository;
			}
			set
			{
				iRAIL_CARRIERRECORD_WARN_FINALRepository= value;
			}
		}
		#endregion

		#region 262 数据接口 IRAIL_CARRIERSECTION_LASTWARNRepository
		IRAIL_CARRIERSECTION_LASTWARNRepository iRAIL_CARRIERSECTION_LASTWARNRepository;
		public IRAIL_CARRIERSECTION_LASTWARNRepository IRAIL_CARRIERSECTION_LASTWARNRepository
		{
		 
			get 
			{
				if(iRAIL_CARRIERSECTION_LASTWARNRepository==null)
					iRAIL_CARRIERSECTION_LASTWARNRepository= new RAIL_CARRIERSECTION_LASTWARNRepository();
				return iRAIL_CARRIERSECTION_LASTWARNRepository;
			}
			set
			{
				iRAIL_CARRIERSECTION_LASTWARNRepository= value;
			}
		}
		#endregion

		#region 263 数据接口 IRAIL_CARRIERSECTION_WARNRepository
		IRAIL_CARRIERSECTION_WARNRepository iRAIL_CARRIERSECTION_WARNRepository;
		public IRAIL_CARRIERSECTION_WARNRepository IRAIL_CARRIERSECTION_WARNRepository
		{
		 
			get 
			{
				if(iRAIL_CARRIERSECTION_WARNRepository==null)
					iRAIL_CARRIERSECTION_WARNRepository= new RAIL_CARRIERSECTION_WARNRepository();
				return iRAIL_CARRIERSECTION_WARNRepository;
			}
			set
			{
				iRAIL_CARRIERSECTION_WARNRepository= value;
			}
		}
		#endregion

		#region 264 数据接口 IRAIL_CARRIERWAVE_LOGRepository
		IRAIL_CARRIERWAVE_LOGRepository iRAIL_CARRIERWAVE_LOGRepository;
		public IRAIL_CARRIERWAVE_LOGRepository IRAIL_CARRIERWAVE_LOGRepository
		{
		 
			get 
			{
				if(iRAIL_CARRIERWAVE_LOGRepository==null)
					iRAIL_CARRIERWAVE_LOGRepository= new RAIL_CARRIERWAVE_LOGRepository();
				return iRAIL_CARRIERWAVE_LOGRepository;
			}
			set
			{
				iRAIL_CARRIERWAVE_LOGRepository= value;
			}
		}
		#endregion

		#region 265 数据接口 IRAIL_CARRIERWAVE_POINTRepository
		IRAIL_CARRIERWAVE_POINTRepository iRAIL_CARRIERWAVE_POINTRepository;
		public IRAIL_CARRIERWAVE_POINTRepository IRAIL_CARRIERWAVE_POINTRepository
		{
		 
			get 
			{
				if(iRAIL_CARRIERWAVE_POINTRepository==null)
					iRAIL_CARRIERWAVE_POINTRepository= new RAIL_CARRIERWAVE_POINTRepository();
				return iRAIL_CARRIERWAVE_POINTRepository;
			}
			set
			{
				iRAIL_CARRIERWAVE_POINTRepository= value;
			}
		}
		#endregion

		#region 266 数据接口 IRAIL_COMMRepository
		IRAIL_COMMRepository iRAIL_COMMRepository;
		public IRAIL_COMMRepository IRAIL_COMMRepository
		{
		 
			get 
			{
				if(iRAIL_COMMRepository==null)
					iRAIL_COMMRepository= new RAIL_COMMRepository();
				return iRAIL_COMMRepository;
			}
			set
			{
				iRAIL_COMMRepository= value;
			}
		}
		#endregion

		#region 267 数据接口 IRAIL_DEVICE_RECORDRepository
		IRAIL_DEVICE_RECORDRepository iRAIL_DEVICE_RECORDRepository;
		public IRAIL_DEVICE_RECORDRepository IRAIL_DEVICE_RECORDRepository
		{
		 
			get 
			{
				if(iRAIL_DEVICE_RECORDRepository==null)
					iRAIL_DEVICE_RECORDRepository= new RAIL_DEVICE_RECORDRepository();
				return iRAIL_DEVICE_RECORDRepository;
			}
			set
			{
				iRAIL_DEVICE_RECORDRepository= value;
			}
		}
		#endregion

		#region 268 数据接口 IRAIL_RECORD_HOSTRepository
		IRAIL_RECORD_HOSTRepository iRAIL_RECORD_HOSTRepository;
		public IRAIL_RECORD_HOSTRepository IRAIL_RECORD_HOSTRepository
		{
		 
			get 
			{
				if(iRAIL_RECORD_HOSTRepository==null)
					iRAIL_RECORD_HOSTRepository= new RAIL_RECORD_HOSTRepository();
				return iRAIL_RECORD_HOSTRepository;
			}
			set
			{
				iRAIL_RECORD_HOSTRepository= value;
			}
		}
		#endregion

		#region 269 数据接口 IRAIL_RECORD_POINTRepository
		IRAIL_RECORD_POINTRepository iRAIL_RECORD_POINTRepository;
		public IRAIL_RECORD_POINTRepository IRAIL_RECORD_POINTRepository
		{
		 
			get 
			{
				if(iRAIL_RECORD_POINTRepository==null)
					iRAIL_RECORD_POINTRepository= new RAIL_RECORD_POINTRepository();
				return iRAIL_RECORD_POINTRepository;
			}
			set
			{
				iRAIL_RECORD_POINTRepository= value;
			}
		}
		#endregion

		#region 270 数据接口 IRAIL_RECORD_SAMPWARNRepository
		IRAIL_RECORD_SAMPWARNRepository iRAIL_RECORD_SAMPWARNRepository;
		public IRAIL_RECORD_SAMPWARNRepository IRAIL_RECORD_SAMPWARNRepository
		{
		 
			get 
			{
				if(iRAIL_RECORD_SAMPWARNRepository==null)
					iRAIL_RECORD_SAMPWARNRepository= new RAIL_RECORD_SAMPWARNRepository();
				return iRAIL_RECORD_SAMPWARNRepository;
			}
			set
			{
				iRAIL_RECORD_SAMPWARNRepository= value;
			}
		}
		#endregion

		#region 271 数据接口 IRAIL_RECORD_WARNRepository
		IRAIL_RECORD_WARNRepository iRAIL_RECORD_WARNRepository;
		public IRAIL_RECORD_WARNRepository IRAIL_RECORD_WARNRepository
		{
		 
			get 
			{
				if(iRAIL_RECORD_WARNRepository==null)
					iRAIL_RECORD_WARNRepository= new RAIL_RECORD_WARNRepository();
				return iRAIL_RECORD_WARNRepository;
			}
			set
			{
				iRAIL_RECORD_WARNRepository= value;
			}
		}
		#endregion

		#region 272 数据接口 IRAIL_SECTION_LINERepository
		IRAIL_SECTION_LINERepository iRAIL_SECTION_LINERepository;
		public IRAIL_SECTION_LINERepository IRAIL_SECTION_LINERepository
		{
		 
			get 
			{
				if(iRAIL_SECTION_LINERepository==null)
					iRAIL_SECTION_LINERepository= new RAIL_SECTION_LINERepository();
				return iRAIL_SECTION_LINERepository;
			}
			set
			{
				iRAIL_SECTION_LINERepository= value;
			}
		}
		#endregion

		#region 273 数据接口 IRAIL_SOUNDBDATA_POINTRepository
		IRAIL_SOUNDBDATA_POINTRepository iRAIL_SOUNDBDATA_POINTRepository;
		public IRAIL_SOUNDBDATA_POINTRepository IRAIL_SOUNDBDATA_POINTRepository
		{
		 
			get 
			{
				if(iRAIL_SOUNDBDATA_POINTRepository==null)
					iRAIL_SOUNDBDATA_POINTRepository= new RAIL_SOUNDBDATA_POINTRepository();
				return iRAIL_SOUNDBDATA_POINTRepository;
			}
			set
			{
				iRAIL_SOUNDBDATA_POINTRepository= value;
			}
		}
		#endregion

		#region 274 数据接口 IRAIL_SOUNDBDATA_SECTIONRepository
		IRAIL_SOUNDBDATA_SECTIONRepository iRAIL_SOUNDBDATA_SECTIONRepository;
		public IRAIL_SOUNDBDATA_SECTIONRepository IRAIL_SOUNDBDATA_SECTIONRepository
		{
		 
			get 
			{
				if(iRAIL_SOUNDBDATA_SECTIONRepository==null)
					iRAIL_SOUNDBDATA_SECTIONRepository= new RAIL_SOUNDBDATA_SECTIONRepository();
				return iRAIL_SOUNDBDATA_SECTIONRepository;
			}
			set
			{
				iRAIL_SOUNDBDATA_SECTIONRepository= value;
			}
		}
		#endregion

		#region 275 数据接口 IRAIL_SOUNDDEVICE_LASTWARNRepository
		IRAIL_SOUNDDEVICE_LASTWARNRepository iRAIL_SOUNDDEVICE_LASTWARNRepository;
		public IRAIL_SOUNDDEVICE_LASTWARNRepository IRAIL_SOUNDDEVICE_LASTWARNRepository
		{
		 
			get 
			{
				if(iRAIL_SOUNDDEVICE_LASTWARNRepository==null)
					iRAIL_SOUNDDEVICE_LASTWARNRepository= new RAIL_SOUNDDEVICE_LASTWARNRepository();
				return iRAIL_SOUNDDEVICE_LASTWARNRepository;
			}
			set
			{
				iRAIL_SOUNDDEVICE_LASTWARNRepository= value;
			}
		}
		#endregion

		#region 276 数据接口 IRAIL_SOUNDDEVICE_WARNRepository
		IRAIL_SOUNDDEVICE_WARNRepository iRAIL_SOUNDDEVICE_WARNRepository;
		public IRAIL_SOUNDDEVICE_WARNRepository IRAIL_SOUNDDEVICE_WARNRepository
		{
		 
			get 
			{
				if(iRAIL_SOUNDDEVICE_WARNRepository==null)
					iRAIL_SOUNDDEVICE_WARNRepository= new RAIL_SOUNDDEVICE_WARNRepository();
				return iRAIL_SOUNDDEVICE_WARNRepository;
			}
			set
			{
				iRAIL_SOUNDDEVICE_WARNRepository= value;
			}
		}
		#endregion

		#region 277 数据接口 IRAIL_SOUNDRECEIVE_ORIDATARepository
		IRAIL_SOUNDRECEIVE_ORIDATARepository iRAIL_SOUNDRECEIVE_ORIDATARepository;
		public IRAIL_SOUNDRECEIVE_ORIDATARepository IRAIL_SOUNDRECEIVE_ORIDATARepository
		{
		 
			get 
			{
				if(iRAIL_SOUNDRECEIVE_ORIDATARepository==null)
					iRAIL_SOUNDRECEIVE_ORIDATARepository= new RAIL_SOUNDRECEIVE_ORIDATARepository();
				return iRAIL_SOUNDRECEIVE_ORIDATARepository;
			}
			set
			{
				iRAIL_SOUNDRECEIVE_ORIDATARepository= value;
			}
		}
		#endregion

		#region 278 数据接口 IRAIL_SOUNDRECORD_LASTWARNRepository
		IRAIL_SOUNDRECORD_LASTWARNRepository iRAIL_SOUNDRECORD_LASTWARNRepository;
		public IRAIL_SOUNDRECORD_LASTWARNRepository IRAIL_SOUNDRECORD_LASTWARNRepository
		{
		 
			get 
			{
				if(iRAIL_SOUNDRECORD_LASTWARNRepository==null)
					iRAIL_SOUNDRECORD_LASTWARNRepository= new RAIL_SOUNDRECORD_LASTWARNRepository();
				return iRAIL_SOUNDRECORD_LASTWARNRepository;
			}
			set
			{
				iRAIL_SOUNDRECORD_LASTWARNRepository= value;
			}
		}
		#endregion

		#region 279 数据接口 IRAIL_SOUNDRECORD_POINTRepository
		IRAIL_SOUNDRECORD_POINTRepository iRAIL_SOUNDRECORD_POINTRepository;
		public IRAIL_SOUNDRECORD_POINTRepository IRAIL_SOUNDRECORD_POINTRepository
		{
		 
			get 
			{
				if(iRAIL_SOUNDRECORD_POINTRepository==null)
					iRAIL_SOUNDRECORD_POINTRepository= new RAIL_SOUNDRECORD_POINTRepository();
				return iRAIL_SOUNDRECORD_POINTRepository;
			}
			set
			{
				iRAIL_SOUNDRECORD_POINTRepository= value;
			}
		}
		#endregion

		#region 280 数据接口 IRAIL_SOUNDRECORD_WARNRepository
		IRAIL_SOUNDRECORD_WARNRepository iRAIL_SOUNDRECORD_WARNRepository;
		public IRAIL_SOUNDRECORD_WARNRepository IRAIL_SOUNDRECORD_WARNRepository
		{
		 
			get 
			{
				if(iRAIL_SOUNDRECORD_WARNRepository==null)
					iRAIL_SOUNDRECORD_WARNRepository= new RAIL_SOUNDRECORD_WARNRepository();
				return iRAIL_SOUNDRECORD_WARNRepository;
			}
			set
			{
				iRAIL_SOUNDRECORD_WARNRepository= value;
			}
		}
		#endregion

		#region 281 数据接口 IRAIL_SOUNDRECORD_WARN_FINALRepository
		IRAIL_SOUNDRECORD_WARN_FINALRepository iRAIL_SOUNDRECORD_WARN_FINALRepository;
		public IRAIL_SOUNDRECORD_WARN_FINALRepository IRAIL_SOUNDRECORD_WARN_FINALRepository
		{
		 
			get 
			{
				if(iRAIL_SOUNDRECORD_WARN_FINALRepository==null)
					iRAIL_SOUNDRECORD_WARN_FINALRepository= new RAIL_SOUNDRECORD_WARN_FINALRepository();
				return iRAIL_SOUNDRECORD_WARN_FINALRepository;
			}
			set
			{
				iRAIL_SOUNDRECORD_WARN_FINALRepository= value;
			}
		}
		#endregion

		#region 282 数据接口 IRAIL_SOUNDSECTION_LASTWARNRepository
		IRAIL_SOUNDSECTION_LASTWARNRepository iRAIL_SOUNDSECTION_LASTWARNRepository;
		public IRAIL_SOUNDSECTION_LASTWARNRepository IRAIL_SOUNDSECTION_LASTWARNRepository
		{
		 
			get 
			{
				if(iRAIL_SOUNDSECTION_LASTWARNRepository==null)
					iRAIL_SOUNDSECTION_LASTWARNRepository= new RAIL_SOUNDSECTION_LASTWARNRepository();
				return iRAIL_SOUNDSECTION_LASTWARNRepository;
			}
			set
			{
				iRAIL_SOUNDSECTION_LASTWARNRepository= value;
			}
		}
		#endregion

		#region 283 数据接口 IRAIL_SOUNDSECTION_WARNRepository
		IRAIL_SOUNDSECTION_WARNRepository iRAIL_SOUNDSECTION_WARNRepository;
		public IRAIL_SOUNDSECTION_WARNRepository IRAIL_SOUNDSECTION_WARNRepository
		{
		 
			get 
			{
				if(iRAIL_SOUNDSECTION_WARNRepository==null)
					iRAIL_SOUNDSECTION_WARNRepository= new RAIL_SOUNDSECTION_WARNRepository();
				return iRAIL_SOUNDSECTION_WARNRepository;
			}
			set
			{
				iRAIL_SOUNDSECTION_WARNRepository= value;
			}
		}
		#endregion

		#region 284 数据接口 IRAIL_SOUNDWAVE_LOGRepository
		IRAIL_SOUNDWAVE_LOGRepository iRAIL_SOUNDWAVE_LOGRepository;
		public IRAIL_SOUNDWAVE_LOGRepository IRAIL_SOUNDWAVE_LOGRepository
		{
		 
			get 
			{
				if(iRAIL_SOUNDWAVE_LOGRepository==null)
					iRAIL_SOUNDWAVE_LOGRepository= new RAIL_SOUNDWAVE_LOGRepository();
				return iRAIL_SOUNDWAVE_LOGRepository;
			}
			set
			{
				iRAIL_SOUNDWAVE_LOGRepository= value;
			}
		}
		#endregion

		#region 285 数据接口 IRAILCAR_BDATARepository
		IRAILCAR_BDATARepository iRAILCAR_BDATARepository;
		public IRAILCAR_BDATARepository IRAILCAR_BDATARepository
		{
		 
			get 
			{
				if(iRAILCAR_BDATARepository==null)
					iRAILCAR_BDATARepository= new RAILCAR_BDATARepository();
				return iRAILCAR_BDATARepository;
			}
			set
			{
				iRAILCAR_BDATARepository= value;
			}
		}
		#endregion

		#region 286 数据接口 IRAILCAR_BDATA_ONLINERepository
		IRAILCAR_BDATA_ONLINERepository iRAILCAR_BDATA_ONLINERepository;
		public IRAILCAR_BDATA_ONLINERepository IRAILCAR_BDATA_ONLINERepository
		{
		 
			get 
			{
				if(iRAILCAR_BDATA_ONLINERepository==null)
					iRAILCAR_BDATA_ONLINERepository= new RAILCAR_BDATA_ONLINERepository();
				return iRAILCAR_BDATA_ONLINERepository;
			}
			set
			{
				iRAILCAR_BDATA_ONLINERepository= value;
			}
		}
		#endregion

		#region 287 数据接口 IRAILCAR_FILERepository
		IRAILCAR_FILERepository iRAILCAR_FILERepository;
		public IRAILCAR_FILERepository IRAILCAR_FILERepository
		{
		 
			get 
			{
				if(iRAILCAR_FILERepository==null)
					iRAILCAR_FILERepository= new RAILCAR_FILERepository();
				return iRAILCAR_FILERepository;
			}
			set
			{
				iRAILCAR_FILERepository= value;
			}
		}
		#endregion

		#region 288 数据接口 IRAIN_DEVICERepository
		IRAIN_DEVICERepository iRAIN_DEVICERepository;
		public IRAIN_DEVICERepository IRAIN_DEVICERepository
		{
		 
			get 
			{
				if(iRAIN_DEVICERepository==null)
					iRAIN_DEVICERepository= new RAIN_DEVICERepository();
				return iRAIN_DEVICERepository;
			}
			set
			{
				iRAIN_DEVICERepository= value;
			}
		}
		#endregion

		#region 289 数据接口 IRAIN_DEVICE_PLANLOGRepository
		IRAIN_DEVICE_PLANLOGRepository iRAIN_DEVICE_PLANLOGRepository;
		public IRAIN_DEVICE_PLANLOGRepository IRAIN_DEVICE_PLANLOGRepository
		{
		 
			get 
			{
				if(iRAIN_DEVICE_PLANLOGRepository==null)
					iRAIN_DEVICE_PLANLOGRepository= new RAIN_DEVICE_PLANLOGRepository();
				return iRAIN_DEVICE_PLANLOGRepository;
			}
			set
			{
				iRAIN_DEVICE_PLANLOGRepository= value;
			}
		}
		#endregion

		#region 290 数据接口 IRAIN_FLOOD_LABOURRepository
		IRAIN_FLOOD_LABOURRepository iRAIN_FLOOD_LABOURRepository;
		public IRAIN_FLOOD_LABOURRepository IRAIN_FLOOD_LABOURRepository
		{
		 
			get 
			{
				if(iRAIN_FLOOD_LABOURRepository==null)
					iRAIN_FLOOD_LABOURRepository= new RAIN_FLOOD_LABOURRepository();
				return iRAIN_FLOOD_LABOURRepository;
			}
			set
			{
				iRAIN_FLOOD_LABOURRepository= value;
			}
		}
		#endregion

		#region 291 数据接口 IRAIN_FLOOD_RESERVE_PLANRepository
		IRAIN_FLOOD_RESERVE_PLANRepository iRAIN_FLOOD_RESERVE_PLANRepository;
		public IRAIN_FLOOD_RESERVE_PLANRepository IRAIN_FLOOD_RESERVE_PLANRepository
		{
		 
			get 
			{
				if(iRAIN_FLOOD_RESERVE_PLANRepository==null)
					iRAIN_FLOOD_RESERVE_PLANRepository= new RAIN_FLOOD_RESERVE_PLANRepository();
				return iRAIN_FLOOD_RESERVE_PLANRepository;
			}
			set
			{
				iRAIN_FLOOD_RESERVE_PLANRepository= value;
			}
		}
		#endregion

		#region 292 数据接口 IRAIN_FLOOD_STOCKRepository
		IRAIN_FLOOD_STOCKRepository iRAIN_FLOOD_STOCKRepository;
		public IRAIN_FLOOD_STOCKRepository IRAIN_FLOOD_STOCKRepository
		{
		 
			get 
			{
				if(iRAIN_FLOOD_STOCKRepository==null)
					iRAIN_FLOOD_STOCKRepository= new RAIN_FLOOD_STOCKRepository();
				return iRAIN_FLOOD_STOCKRepository;
			}
			set
			{
				iRAIN_FLOOD_STOCKRepository= value;
			}
		}
		#endregion

		#region 293 数据接口 IRAIN_FLOOD_STOCK_PHOTORepository
		IRAIN_FLOOD_STOCK_PHOTORepository iRAIN_FLOOD_STOCK_PHOTORepository;
		public IRAIN_FLOOD_STOCK_PHOTORepository IRAIN_FLOOD_STOCK_PHOTORepository
		{
		 
			get 
			{
				if(iRAIN_FLOOD_STOCK_PHOTORepository==null)
					iRAIN_FLOOD_STOCK_PHOTORepository= new RAIN_FLOOD_STOCK_PHOTORepository();
				return iRAIN_FLOOD_STOCK_PHOTORepository;
			}
			set
			{
				iRAIN_FLOOD_STOCK_PHOTORepository= value;
			}
		}
		#endregion

		#region 294 数据接口 IRAIN_PLANRepository
		IRAIN_PLANRepository iRAIN_PLANRepository;
		public IRAIN_PLANRepository IRAIN_PLANRepository
		{
		 
			get 
			{
				if(iRAIN_PLANRepository==null)
					iRAIN_PLANRepository= new RAIN_PLANRepository();
				return iRAIN_PLANRepository;
			}
			set
			{
				iRAIN_PLANRepository= value;
			}
		}
		#endregion

		#region 295 数据接口 IRAIN_PLAN_WARNRepository
		IRAIN_PLAN_WARNRepository iRAIN_PLAN_WARNRepository;
		public IRAIN_PLAN_WARNRepository IRAIN_PLAN_WARNRepository
		{
		 
			get 
			{
				if(iRAIN_PLAN_WARNRepository==null)
					iRAIN_PLAN_WARNRepository= new RAIN_PLAN_WARNRepository();
				return iRAIN_PLAN_WARNRepository;
			}
			set
			{
				iRAIN_PLAN_WARNRepository= value;
			}
		}
		#endregion

		#region 296 数据接口 IRAIN_SECTION_LINERepository
		IRAIN_SECTION_LINERepository iRAIN_SECTION_LINERepository;
		public IRAIN_SECTION_LINERepository IRAIN_SECTION_LINERepository
		{
		 
			get 
			{
				if(iRAIN_SECTION_LINERepository==null)
					iRAIN_SECTION_LINERepository= new RAIN_SECTION_LINERepository();
				return iRAIN_SECTION_LINERepository;
			}
			set
			{
				iRAIN_SECTION_LINERepository= value;
			}
		}
		#endregion

		#region 297 数据接口 IREPAIR_ACCOUNTRepository
		IREPAIR_ACCOUNTRepository iREPAIR_ACCOUNTRepository;
		public IREPAIR_ACCOUNTRepository IREPAIR_ACCOUNTRepository
		{
		 
			get 
			{
				if(iREPAIR_ACCOUNTRepository==null)
					iREPAIR_ACCOUNTRepository= new REPAIR_ACCOUNTRepository();
				return iREPAIR_ACCOUNTRepository;
			}
			set
			{
				iREPAIR_ACCOUNTRepository= value;
			}
		}
		#endregion

		#region 298 数据接口 IREPAIR_OVERRUNRepository
		IREPAIR_OVERRUNRepository iREPAIR_OVERRUNRepository;
		public IREPAIR_OVERRUNRepository IREPAIR_OVERRUNRepository
		{
		 
			get 
			{
				if(iREPAIR_OVERRUNRepository==null)
					iREPAIR_OVERRUNRepository= new REPAIR_OVERRUNRepository();
				return iREPAIR_OVERRUNRepository;
			}
			set
			{
				iREPAIR_OVERRUNRepository= value;
			}
		}
		#endregion

		#region 299 数据接口 IRESCUE_LINERepository
		IRESCUE_LINERepository iRESCUE_LINERepository;
		public IRESCUE_LINERepository IRESCUE_LINERepository
		{
		 
			get 
			{
				if(iRESCUE_LINERepository==null)
					iRESCUE_LINERepository= new RESCUE_LINERepository();
				return iRESCUE_LINERepository;
			}
			set
			{
				iRESCUE_LINERepository= value;
			}
		}
		#endregion

		#region 300 数据接口 IRESCUE_LINE_INFORepository
		IRESCUE_LINE_INFORepository iRESCUE_LINE_INFORepository;
		public IRESCUE_LINE_INFORepository IRESCUE_LINE_INFORepository
		{
		 
			get 
			{
				if(iRESCUE_LINE_INFORepository==null)
					iRESCUE_LINE_INFORepository= new RESCUE_LINE_INFORepository();
				return iRESCUE_LINE_INFORepository;
			}
			set
			{
				iRESCUE_LINE_INFORepository= value;
			}
		}
		#endregion

		#region 301 数据接口 IRESCUE_LINE_PHOTORepository
		IRESCUE_LINE_PHOTORepository iRESCUE_LINE_PHOTORepository;
		public IRESCUE_LINE_PHOTORepository IRESCUE_LINE_PHOTORepository
		{
		 
			get 
			{
				if(iRESCUE_LINE_PHOTORepository==null)
					iRESCUE_LINE_PHOTORepository= new RESCUE_LINE_PHOTORepository();
				return iRESCUE_LINE_PHOTORepository;
			}
			set
			{
				iRESCUE_LINE_PHOTORepository= value;
			}
		}
		#endregion

		#region 302 数据接口 IRESCUE_LINE_PORTRepository
		IRESCUE_LINE_PORTRepository iRESCUE_LINE_PORTRepository;
		public IRESCUE_LINE_PORTRepository IRESCUE_LINE_PORTRepository
		{
		 
			get 
			{
				if(iRESCUE_LINE_PORTRepository==null)
					iRESCUE_LINE_PORTRepository= new RESCUE_LINE_PORTRepository();
				return iRESCUE_LINE_PORTRepository;
			}
			set
			{
				iRESCUE_LINE_PORTRepository= value;
			}
		}
		#endregion

		#region 303 数据接口 IROADBED_ITEM_PARARepository
		IROADBED_ITEM_PARARepository iROADBED_ITEM_PARARepository;
		public IROADBED_ITEM_PARARepository IROADBED_ITEM_PARARepository
		{
		 
			get 
			{
				if(iROADBED_ITEM_PARARepository==null)
					iROADBED_ITEM_PARARepository= new ROADBED_ITEM_PARARepository();
				return iROADBED_ITEM_PARARepository;
			}
			set
			{
				iROADBED_ITEM_PARARepository= value;
			}
		}
		#endregion

		#region 304 数据接口 IROADBED_KEYDISEASE_EVALUATERepository
		IROADBED_KEYDISEASE_EVALUATERepository iROADBED_KEYDISEASE_EVALUATERepository;
		public IROADBED_KEYDISEASE_EVALUATERepository IROADBED_KEYDISEASE_EVALUATERepository
		{
		 
			get 
			{
				if(iROADBED_KEYDISEASE_EVALUATERepository==null)
					iROADBED_KEYDISEASE_EVALUATERepository= new ROADBED_KEYDISEASE_EVALUATERepository();
				return iROADBED_KEYDISEASE_EVALUATERepository;
			}
			set
			{
				iROADBED_KEYDISEASE_EVALUATERepository= value;
			}
		}
		#endregion

		#region 305 数据接口 IROADBED_KEYDISEASE_PRORepository
		IROADBED_KEYDISEASE_PRORepository iROADBED_KEYDISEASE_PRORepository;
		public IROADBED_KEYDISEASE_PRORepository IROADBED_KEYDISEASE_PRORepository
		{
		 
			get 
			{
				if(iROADBED_KEYDISEASE_PRORepository==null)
					iROADBED_KEYDISEASE_PRORepository= new ROADBED_KEYDISEASE_PRORepository();
				return iROADBED_KEYDISEASE_PRORepository;
			}
			set
			{
				iROADBED_KEYDISEASE_PRORepository= value;
			}
		}
		#endregion

		#region 306 数据接口 IROADBED_KEYDISEASE_PRO_HISRepository
		IROADBED_KEYDISEASE_PRO_HISRepository iROADBED_KEYDISEASE_PRO_HISRepository;
		public IROADBED_KEYDISEASE_PRO_HISRepository IROADBED_KEYDISEASE_PRO_HISRepository
		{
		 
			get 
			{
				if(iROADBED_KEYDISEASE_PRO_HISRepository==null)
					iROADBED_KEYDISEASE_PRO_HISRepository= new ROADBED_KEYDISEASE_PRO_HISRepository();
				return iROADBED_KEYDISEASE_PRO_HISRepository;
			}
			set
			{
				iROADBED_KEYDISEASE_PRO_HISRepository= value;
			}
		}
		#endregion

		#region 307 数据接口 IROADBED_KEYDISEASE_REPORTRepository
		IROADBED_KEYDISEASE_REPORTRepository iROADBED_KEYDISEASE_REPORTRepository;
		public IROADBED_KEYDISEASE_REPORTRepository IROADBED_KEYDISEASE_REPORTRepository
		{
		 
			get 
			{
				if(iROADBED_KEYDISEASE_REPORTRepository==null)
					iROADBED_KEYDISEASE_REPORTRepository= new ROADBED_KEYDISEASE_REPORTRepository();
				return iROADBED_KEYDISEASE_REPORTRepository;
			}
			set
			{
				iROADBED_KEYDISEASE_REPORTRepository= value;
			}
		}
		#endregion

		#region 308 数据接口 IRULE_BASE_DEPTRepository
		IRULE_BASE_DEPTRepository iRULE_BASE_DEPTRepository;
		public IRULE_BASE_DEPTRepository IRULE_BASE_DEPTRepository
		{
		 
			get 
			{
				if(iRULE_BASE_DEPTRepository==null)
					iRULE_BASE_DEPTRepository= new RULE_BASE_DEPTRepository();
				return iRULE_BASE_DEPTRepository;
			}
			set
			{
				iRULE_BASE_DEPTRepository= value;
			}
		}
		#endregion

		#region 309 数据接口 IRULE_BDATE_DICRepository
		IRULE_BDATE_DICRepository iRULE_BDATE_DICRepository;
		public IRULE_BDATE_DICRepository IRULE_BDATE_DICRepository
		{
		 
			get 
			{
				if(iRULE_BDATE_DICRepository==null)
					iRULE_BDATE_DICRepository= new RULE_BDATE_DICRepository();
				return iRULE_BDATE_DICRepository;
			}
			set
			{
				iRULE_BDATE_DICRepository= value;
			}
		}
		#endregion

		#region 310 数据接口 IRULE_DOCRepository
		IRULE_DOCRepository iRULE_DOCRepository;
		public IRULE_DOCRepository IRULE_DOCRepository
		{
		 
			get 
			{
				if(iRULE_DOCRepository==null)
					iRULE_DOCRepository= new RULE_DOCRepository();
				return iRULE_DOCRepository;
			}
			set
			{
				iRULE_DOCRepository= value;
			}
		}
		#endregion

		#region 311 数据接口 IRULE_DOC_ITEMRepository
		IRULE_DOC_ITEMRepository iRULE_DOC_ITEMRepository;
		public IRULE_DOC_ITEMRepository IRULE_DOC_ITEMRepository
		{
		 
			get 
			{
				if(iRULE_DOC_ITEMRepository==null)
					iRULE_DOC_ITEMRepository= new RULE_DOC_ITEMRepository();
				return iRULE_DOC_ITEMRepository;
			}
			set
			{
				iRULE_DOC_ITEMRepository= value;
			}
		}
		#endregion

		#region 312 数据接口 IRULE_DOC_KEYWORDRepository
		IRULE_DOC_KEYWORDRepository iRULE_DOC_KEYWORDRepository;
		public IRULE_DOC_KEYWORDRepository IRULE_DOC_KEYWORDRepository
		{
		 
			get 
			{
				if(iRULE_DOC_KEYWORDRepository==null)
					iRULE_DOC_KEYWORDRepository= new RULE_DOC_KEYWORDRepository();
				return iRULE_DOC_KEYWORDRepository;
			}
			set
			{
				iRULE_DOC_KEYWORDRepository= value;
			}
		}
		#endregion

		#region 313 数据接口 IRULE_KEYWORDRepository
		IRULE_KEYWORDRepository iRULE_KEYWORDRepository;
		public IRULE_KEYWORDRepository IRULE_KEYWORDRepository
		{
		 
			get 
			{
				if(iRULE_KEYWORDRepository==null)
					iRULE_KEYWORDRepository= new RULE_KEYWORDRepository();
				return iRULE_KEYWORDRepository;
			}
			set
			{
				iRULE_KEYWORDRepository= value;
			}
		}
		#endregion

		#region 314 数据接口 IRULE_PARA_SCORERepository
		IRULE_PARA_SCORERepository iRULE_PARA_SCORERepository;
		public IRULE_PARA_SCORERepository IRULE_PARA_SCORERepository
		{
		 
			get 
			{
				if(iRULE_PARA_SCORERepository==null)
					iRULE_PARA_SCORERepository= new RULE_PARA_SCORERepository();
				return iRULE_PARA_SCORERepository;
			}
			set
			{
				iRULE_PARA_SCORERepository= value;
			}
		}
		#endregion

		#region 315 数据接口 IRULE_PARSE_MARKUPRepository
		IRULE_PARSE_MARKUPRepository iRULE_PARSE_MARKUPRepository;
		public IRULE_PARSE_MARKUPRepository IRULE_PARSE_MARKUPRepository
		{
		 
			get 
			{
				if(iRULE_PARSE_MARKUPRepository==null)
					iRULE_PARSE_MARKUPRepository= new RULE_PARSE_MARKUPRepository();
				return iRULE_PARSE_MARKUPRepository;
			}
			set
			{
				iRULE_PARSE_MARKUPRepository= value;
			}
		}
		#endregion

		#region 316 数据接口 IRULE_PARSE_MARKUP_MATCHRepository
		IRULE_PARSE_MARKUP_MATCHRepository iRULE_PARSE_MARKUP_MATCHRepository;
		public IRULE_PARSE_MARKUP_MATCHRepository IRULE_PARSE_MARKUP_MATCHRepository
		{
		 
			get 
			{
				if(iRULE_PARSE_MARKUP_MATCHRepository==null)
					iRULE_PARSE_MARKUP_MATCHRepository= new RULE_PARSE_MARKUP_MATCHRepository();
				return iRULE_PARSE_MARKUP_MATCHRepository;
			}
			set
			{
				iRULE_PARSE_MARKUP_MATCHRepository= value;
			}
		}
		#endregion

		#region 317 数据接口 IRULE_PARSE_RESULTRepository
		IRULE_PARSE_RESULTRepository iRULE_PARSE_RESULTRepository;
		public IRULE_PARSE_RESULTRepository IRULE_PARSE_RESULTRepository
		{
		 
			get 
			{
				if(iRULE_PARSE_RESULTRepository==null)
					iRULE_PARSE_RESULTRepository= new RULE_PARSE_RESULTRepository();
				return iRULE_PARSE_RESULTRepository;
			}
			set
			{
				iRULE_PARSE_RESULTRepository= value;
			}
		}
		#endregion

		#region 318 数据接口 IRULE_PARSE_RESULT_REPORTRepository
		IRULE_PARSE_RESULT_REPORTRepository iRULE_PARSE_RESULT_REPORTRepository;
		public IRULE_PARSE_RESULT_REPORTRepository IRULE_PARSE_RESULT_REPORTRepository
		{
		 
			get 
			{
				if(iRULE_PARSE_RESULT_REPORTRepository==null)
					iRULE_PARSE_RESULT_REPORTRepository= new RULE_PARSE_RESULT_REPORTRepository();
				return iRULE_PARSE_RESULT_REPORTRepository;
			}
			set
			{
				iRULE_PARSE_RESULT_REPORTRepository= value;
			}
		}
		#endregion

		#region 319 数据接口 IRULE_PROBLEMRepository
		IRULE_PROBLEMRepository iRULE_PROBLEMRepository;
		public IRULE_PROBLEMRepository IRULE_PROBLEMRepository
		{
		 
			get 
			{
				if(iRULE_PROBLEMRepository==null)
					iRULE_PROBLEMRepository= new RULE_PROBLEMRepository();
				return iRULE_PROBLEMRepository;
			}
			set
			{
				iRULE_PROBLEMRepository= value;
			}
		}
		#endregion

		#region 320 数据接口 IRULE_PROBLEM_BLAMERepository
		IRULE_PROBLEM_BLAMERepository iRULE_PROBLEM_BLAMERepository;
		public IRULE_PROBLEM_BLAMERepository IRULE_PROBLEM_BLAMERepository
		{
		 
			get 
			{
				if(iRULE_PROBLEM_BLAMERepository==null)
					iRULE_PROBLEM_BLAMERepository= new RULE_PROBLEM_BLAMERepository();
				return iRULE_PROBLEM_BLAMERepository;
			}
			set
			{
				iRULE_PROBLEM_BLAMERepository= value;
			}
		}
		#endregion

		#region 321 数据接口 IRULE_PROBLEM_KEYWORDRepository
		IRULE_PROBLEM_KEYWORDRepository iRULE_PROBLEM_KEYWORDRepository;
		public IRULE_PROBLEM_KEYWORDRepository IRULE_PROBLEM_KEYWORDRepository
		{
		 
			get 
			{
				if(iRULE_PROBLEM_KEYWORDRepository==null)
					iRULE_PROBLEM_KEYWORDRepository= new RULE_PROBLEM_KEYWORDRepository();
				return iRULE_PROBLEM_KEYWORDRepository;
			}
			set
			{
				iRULE_PROBLEM_KEYWORDRepository= value;
			}
		}
		#endregion

		#region 322 数据接口 IRULE_PROBLEM_POSTRepository
		IRULE_PROBLEM_POSTRepository iRULE_PROBLEM_POSTRepository;
		public IRULE_PROBLEM_POSTRepository IRULE_PROBLEM_POSTRepository
		{
		 
			get 
			{
				if(iRULE_PROBLEM_POSTRepository==null)
					iRULE_PROBLEM_POSTRepository= new RULE_PROBLEM_POSTRepository();
				return iRULE_PROBLEM_POSTRepository;
			}
			set
			{
				iRULE_PROBLEM_POSTRepository= value;
			}
		}
		#endregion

		#region 323 数据接口 IRULE_PROBLEM_PUBLISH_CONFIGERRepository
		IRULE_PROBLEM_PUBLISH_CONFIGERRepository iRULE_PROBLEM_PUBLISH_CONFIGERRepository;
		public IRULE_PROBLEM_PUBLISH_CONFIGERRepository IRULE_PROBLEM_PUBLISH_CONFIGERRepository
		{
		 
			get 
			{
				if(iRULE_PROBLEM_PUBLISH_CONFIGERRepository==null)
					iRULE_PROBLEM_PUBLISH_CONFIGERRepository= new RULE_PROBLEM_PUBLISH_CONFIGERRepository();
				return iRULE_PROBLEM_PUBLISH_CONFIGERRepository;
			}
			set
			{
				iRULE_PROBLEM_PUBLISH_CONFIGERRepository= value;
			}
		}
		#endregion

		#region 324 数据接口 IRULE_PROBLEM_PUNISHRepository
		IRULE_PROBLEM_PUNISHRepository iRULE_PROBLEM_PUNISHRepository;
		public IRULE_PROBLEM_PUNISHRepository IRULE_PROBLEM_PUNISHRepository
		{
		 
			get 
			{
				if(iRULE_PROBLEM_PUNISHRepository==null)
					iRULE_PROBLEM_PUNISHRepository= new RULE_PROBLEM_PUNISHRepository();
				return iRULE_PROBLEM_PUNISHRepository;
			}
			set
			{
				iRULE_PROBLEM_PUNISHRepository= value;
			}
		}
		#endregion

		#region 325 数据接口 IRULE_RESULT_CENSUSRepository
		IRULE_RESULT_CENSUSRepository iRULE_RESULT_CENSUSRepository;
		public IRULE_RESULT_CENSUSRepository IRULE_RESULT_CENSUSRepository
		{
		 
			get 
			{
				if(iRULE_RESULT_CENSUSRepository==null)
					iRULE_RESULT_CENSUSRepository= new RULE_RESULT_CENSUSRepository();
				return iRULE_RESULT_CENSUSRepository;
			}
			set
			{
				iRULE_RESULT_CENSUSRepository= value;
			}
		}
		#endregion

		#region 326 数据接口 IRULE_RESULT_PROTREND_TMPRepository
		IRULE_RESULT_PROTREND_TMPRepository iRULE_RESULT_PROTREND_TMPRepository;
		public IRULE_RESULT_PROTREND_TMPRepository IRULE_RESULT_PROTREND_TMPRepository
		{
		 
			get 
			{
				if(iRULE_RESULT_PROTREND_TMPRepository==null)
					iRULE_RESULT_PROTREND_TMPRepository= new RULE_RESULT_PROTREND_TMPRepository();
				return iRULE_RESULT_PROTREND_TMPRepository;
			}
			set
			{
				iRULE_RESULT_PROTREND_TMPRepository= value;
			}
		}
		#endregion

		#region 327 数据接口 ISCRIPT_SECTION_BRIDGETUNNELRepository
		ISCRIPT_SECTION_BRIDGETUNNELRepository iSCRIPT_SECTION_BRIDGETUNNELRepository;
		public ISCRIPT_SECTION_BRIDGETUNNELRepository ISCRIPT_SECTION_BRIDGETUNNELRepository
		{
		 
			get 
			{
				if(iSCRIPT_SECTION_BRIDGETUNNELRepository==null)
					iSCRIPT_SECTION_BRIDGETUNNELRepository= new SCRIPT_SECTION_BRIDGETUNNELRepository();
				return iSCRIPT_SECTION_BRIDGETUNNELRepository;
			}
			set
			{
				iSCRIPT_SECTION_BRIDGETUNNELRepository= value;
			}
		}
		#endregion

		#region 328 数据接口 ISCRIPTS_LEADER_MONITORERepository
		ISCRIPTS_LEADER_MONITORERepository iSCRIPTS_LEADER_MONITORERepository;
		public ISCRIPTS_LEADER_MONITORERepository ISCRIPTS_LEADER_MONITORERepository
		{
		 
			get 
			{
				if(iSCRIPTS_LEADER_MONITORERepository==null)
					iSCRIPTS_LEADER_MONITORERepository= new SCRIPTS_LEADER_MONITORERepository();
				return iSCRIPTS_LEADER_MONITORERepository;
			}
			set
			{
				iSCRIPTS_LEADER_MONITORERepository= value;
			}
		}
		#endregion

		#region 329 数据接口 ISCRIPTS_MEMBER_ONLINERepository
		ISCRIPTS_MEMBER_ONLINERepository iSCRIPTS_MEMBER_ONLINERepository;
		public ISCRIPTS_MEMBER_ONLINERepository ISCRIPTS_MEMBER_ONLINERepository
		{
		 
			get 
			{
				if(iSCRIPTS_MEMBER_ONLINERepository==null)
					iSCRIPTS_MEMBER_ONLINERepository= new SCRIPTS_MEMBER_ONLINERepository();
				return iSCRIPTS_MEMBER_ONLINERepository;
			}
			set
			{
				iSCRIPTS_MEMBER_ONLINERepository= value;
			}
		}
		#endregion

		#region 330 数据接口 ISCRIPTS_SECTION_BADSIGNALRepository
		ISCRIPTS_SECTION_BADSIGNALRepository iSCRIPTS_SECTION_BADSIGNALRepository;
		public ISCRIPTS_SECTION_BADSIGNALRepository ISCRIPTS_SECTION_BADSIGNALRepository
		{
		 
			get 
			{
				if(iSCRIPTS_SECTION_BADSIGNALRepository==null)
					iSCRIPTS_SECTION_BADSIGNALRepository= new SCRIPTS_SECTION_BADSIGNALRepository();
				return iSCRIPTS_SECTION_BADSIGNALRepository;
			}
			set
			{
				iSCRIPTS_SECTION_BADSIGNALRepository= value;
			}
		}
		#endregion

		#region 331 数据接口 ISCRIPTS_SECTION_FLOOD_PHOTORepository
		ISCRIPTS_SECTION_FLOOD_PHOTORepository iSCRIPTS_SECTION_FLOOD_PHOTORepository;
		public ISCRIPTS_SECTION_FLOOD_PHOTORepository ISCRIPTS_SECTION_FLOOD_PHOTORepository
		{
		 
			get 
			{
				if(iSCRIPTS_SECTION_FLOOD_PHOTORepository==null)
					iSCRIPTS_SECTION_FLOOD_PHOTORepository= new SCRIPTS_SECTION_FLOOD_PHOTORepository();
				return iSCRIPTS_SECTION_FLOOD_PHOTORepository;
			}
			set
			{
				iSCRIPTS_SECTION_FLOOD_PHOTORepository= value;
			}
		}
		#endregion

		#region 332 数据接口 ISCRIPTS_SECTION_FLOOD_PIC_TESTRepository
		ISCRIPTS_SECTION_FLOOD_PIC_TESTRepository iSCRIPTS_SECTION_FLOOD_PIC_TESTRepository;
		public ISCRIPTS_SECTION_FLOOD_PIC_TESTRepository ISCRIPTS_SECTION_FLOOD_PIC_TESTRepository
		{
		 
			get 
			{
				if(iSCRIPTS_SECTION_FLOOD_PIC_TESTRepository==null)
					iSCRIPTS_SECTION_FLOOD_PIC_TESTRepository= new SCRIPTS_SECTION_FLOOD_PIC_TESTRepository();
				return iSCRIPTS_SECTION_FLOOD_PIC_TESTRepository;
			}
			set
			{
				iSCRIPTS_SECTION_FLOOD_PIC_TESTRepository= value;
			}
		}
		#endregion

		#region 333 数据接口 ISCRIPTS_SECTION_LINERepository
		ISCRIPTS_SECTION_LINERepository iSCRIPTS_SECTION_LINERepository;
		public ISCRIPTS_SECTION_LINERepository ISCRIPTS_SECTION_LINERepository
		{
		 
			get 
			{
				if(iSCRIPTS_SECTION_LINERepository==null)
					iSCRIPTS_SECTION_LINERepository= new SCRIPTS_SECTION_LINERepository();
				return iSCRIPTS_SECTION_LINERepository;
			}
			set
			{
				iSCRIPTS_SECTION_LINERepository= value;
			}
		}
		#endregion

		#region 334 数据接口 ISCRIPTS_SECTION_OTHER_PHOTORepository
		ISCRIPTS_SECTION_OTHER_PHOTORepository iSCRIPTS_SECTION_OTHER_PHOTORepository;
		public ISCRIPTS_SECTION_OTHER_PHOTORepository ISCRIPTS_SECTION_OTHER_PHOTORepository
		{
		 
			get 
			{
				if(iSCRIPTS_SECTION_OTHER_PHOTORepository==null)
					iSCRIPTS_SECTION_OTHER_PHOTORepository= new SCRIPTS_SECTION_OTHER_PHOTORepository();
				return iSCRIPTS_SECTION_OTHER_PHOTORepository;
			}
			set
			{
				iSCRIPTS_SECTION_OTHER_PHOTORepository= value;
			}
		}
		#endregion

		#region 335 数据接口 ISCRIPTS_SECTION_ROAD_LINERepository
		ISCRIPTS_SECTION_ROAD_LINERepository iSCRIPTS_SECTION_ROAD_LINERepository;
		public ISCRIPTS_SECTION_ROAD_LINERepository ISCRIPTS_SECTION_ROAD_LINERepository
		{
		 
			get 
			{
				if(iSCRIPTS_SECTION_ROAD_LINERepository==null)
					iSCRIPTS_SECTION_ROAD_LINERepository= new SCRIPTS_SECTION_ROAD_LINERepository();
				return iSCRIPTS_SECTION_ROAD_LINERepository;
			}
			set
			{
				iSCRIPTS_SECTION_ROAD_LINERepository= value;
			}
		}
		#endregion

		#region 336 数据接口 ISCRIPTS_SECTION_ROADMOTORRepository
		ISCRIPTS_SECTION_ROADMOTORRepository iSCRIPTS_SECTION_ROADMOTORRepository;
		public ISCRIPTS_SECTION_ROADMOTORRepository ISCRIPTS_SECTION_ROADMOTORRepository
		{
		 
			get 
			{
				if(iSCRIPTS_SECTION_ROADMOTORRepository==null)
					iSCRIPTS_SECTION_ROADMOTORRepository= new SCRIPTS_SECTION_ROADMOTORRepository();
				return iSCRIPTS_SECTION_ROADMOTORRepository;
			}
			set
			{
				iSCRIPTS_SECTION_ROADMOTORRepository= value;
			}
		}
		#endregion

		#region 337 数据接口 ISCRIPTS_SECTION_TRACKRepository
		ISCRIPTS_SECTION_TRACKRepository iSCRIPTS_SECTION_TRACKRepository;
		public ISCRIPTS_SECTION_TRACKRepository ISCRIPTS_SECTION_TRACKRepository
		{
		 
			get 
			{
				if(iSCRIPTS_SECTION_TRACKRepository==null)
					iSCRIPTS_SECTION_TRACKRepository= new SCRIPTS_SECTION_TRACKRepository();
				return iSCRIPTS_SECTION_TRACKRepository;
			}
			set
			{
				iSCRIPTS_SECTION_TRACKRepository= value;
			}
		}
		#endregion

		#region 338 数据接口 ISCRIPTS_SECTION_TRACK_INFORepository
		ISCRIPTS_SECTION_TRACK_INFORepository iSCRIPTS_SECTION_TRACK_INFORepository;
		public ISCRIPTS_SECTION_TRACK_INFORepository ISCRIPTS_SECTION_TRACK_INFORepository
		{
		 
			get 
			{
				if(iSCRIPTS_SECTION_TRACK_INFORepository==null)
					iSCRIPTS_SECTION_TRACK_INFORepository= new SCRIPTS_SECTION_TRACK_INFORepository();
				return iSCRIPTS_SECTION_TRACK_INFORepository;
			}
			set
			{
				iSCRIPTS_SECTION_TRACK_INFORepository= value;
			}
		}
		#endregion

		#region 339 数据接口 ISCRIPTS_SECTION_TYPECROSSRepository
		ISCRIPTS_SECTION_TYPECROSSRepository iSCRIPTS_SECTION_TYPECROSSRepository;
		public ISCRIPTS_SECTION_TYPECROSSRepository ISCRIPTS_SECTION_TYPECROSSRepository
		{
		 
			get 
			{
				if(iSCRIPTS_SECTION_TYPECROSSRepository==null)
					iSCRIPTS_SECTION_TYPECROSSRepository= new SCRIPTS_SECTION_TYPECROSSRepository();
				return iSCRIPTS_SECTION_TYPECROSSRepository;
			}
			set
			{
				iSCRIPTS_SECTION_TYPECROSSRepository= value;
			}
		}
		#endregion

		#region 340 数据接口 ISCRIPTS_SECTION_TYPEFLOODRepository
		ISCRIPTS_SECTION_TYPEFLOODRepository iSCRIPTS_SECTION_TYPEFLOODRepository;
		public ISCRIPTS_SECTION_TYPEFLOODRepository ISCRIPTS_SECTION_TYPEFLOODRepository
		{
		 
			get 
			{
				if(iSCRIPTS_SECTION_TYPEFLOODRepository==null)
					iSCRIPTS_SECTION_TYPEFLOODRepository= new SCRIPTS_SECTION_TYPEFLOODRepository();
				return iSCRIPTS_SECTION_TYPEFLOODRepository;
			}
			set
			{
				iSCRIPTS_SECTION_TYPEFLOODRepository= value;
			}
		}
		#endregion

		#region 341 数据接口 ISCRIPTS_SECTION_TYPEOTHERRepository
		ISCRIPTS_SECTION_TYPEOTHERRepository iSCRIPTS_SECTION_TYPEOTHERRepository;
		public ISCRIPTS_SECTION_TYPEOTHERRepository ISCRIPTS_SECTION_TYPEOTHERRepository
		{
		 
			get 
			{
				if(iSCRIPTS_SECTION_TYPEOTHERRepository==null)
					iSCRIPTS_SECTION_TYPEOTHERRepository= new SCRIPTS_SECTION_TYPEOTHERRepository();
				return iSCRIPTS_SECTION_TYPEOTHERRepository;
			}
			set
			{
				iSCRIPTS_SECTION_TYPEOTHERRepository= value;
			}
		}
		#endregion

		#region 342 数据接口 ISCRIPTS_SECTION_TYPEOTHERINFORepository
		ISCRIPTS_SECTION_TYPEOTHERINFORepository iSCRIPTS_SECTION_TYPEOTHERINFORepository;
		public ISCRIPTS_SECTION_TYPEOTHERINFORepository ISCRIPTS_SECTION_TYPEOTHERINFORepository
		{
		 
			get 
			{
				if(iSCRIPTS_SECTION_TYPEOTHERINFORepository==null)
					iSCRIPTS_SECTION_TYPEOTHERINFORepository= new SCRIPTS_SECTION_TYPEOTHERINFORepository();
				return iSCRIPTS_SECTION_TYPEOTHERINFORepository;
			}
			set
			{
				iSCRIPTS_SECTION_TYPEOTHERINFORepository= value;
			}
		}
		#endregion

		#region 343 数据接口 ISCRIPTS_SPECIAL_FLAGRepository
		ISCRIPTS_SPECIAL_FLAGRepository iSCRIPTS_SPECIAL_FLAGRepository;
		public ISCRIPTS_SPECIAL_FLAGRepository ISCRIPTS_SPECIAL_FLAGRepository
		{
		 
			get 
			{
				if(iSCRIPTS_SPECIAL_FLAGRepository==null)
					iSCRIPTS_SPECIAL_FLAGRepository= new SCRIPTS_SPECIAL_FLAGRepository();
				return iSCRIPTS_SPECIAL_FLAGRepository;
			}
			set
			{
				iSCRIPTS_SPECIAL_FLAGRepository= value;
			}
		}
		#endregion

		#region 344 数据接口 ISCRIPTS_STATION_CHECKRepository
		ISCRIPTS_STATION_CHECKRepository iSCRIPTS_STATION_CHECKRepository;
		public ISCRIPTS_STATION_CHECKRepository ISCRIPTS_STATION_CHECKRepository
		{
		 
			get 
			{
				if(iSCRIPTS_STATION_CHECKRepository==null)
					iSCRIPTS_STATION_CHECKRepository= new SCRIPTS_STATION_CHECKRepository();
				return iSCRIPTS_STATION_CHECKRepository;
			}
			set
			{
				iSCRIPTS_STATION_CHECKRepository= value;
			}
		}
		#endregion

		#region 345 数据接口 ISNOW_BDATA_DEVICERepository
		ISNOW_BDATA_DEVICERepository iSNOW_BDATA_DEVICERepository;
		public ISNOW_BDATA_DEVICERepository ISNOW_BDATA_DEVICERepository
		{
		 
			get 
			{
				if(iSNOW_BDATA_DEVICERepository==null)
					iSNOW_BDATA_DEVICERepository= new SNOW_BDATA_DEVICERepository();
				return iSNOW_BDATA_DEVICERepository;
			}
			set
			{
				iSNOW_BDATA_DEVICERepository= value;
			}
		}
		#endregion

		#region 346 数据接口 ISNOW_BDATA_WARNSTANDARDRepository
		ISNOW_BDATA_WARNSTANDARDRepository iSNOW_BDATA_WARNSTANDARDRepository;
		public ISNOW_BDATA_WARNSTANDARDRepository ISNOW_BDATA_WARNSTANDARDRepository
		{
		 
			get 
			{
				if(iSNOW_BDATA_WARNSTANDARDRepository==null)
					iSNOW_BDATA_WARNSTANDARDRepository= new SNOW_BDATA_WARNSTANDARDRepository();
				return iSNOW_BDATA_WARNSTANDARDRepository;
			}
			set
			{
				iSNOW_BDATA_WARNSTANDARDRepository= value;
			}
		}
		#endregion

		#region 347 数据接口 ISNOW_RECORD_HISRepository
		ISNOW_RECORD_HISRepository iSNOW_RECORD_HISRepository;
		public ISNOW_RECORD_HISRepository ISNOW_RECORD_HISRepository
		{
		 
			get 
			{
				if(iSNOW_RECORD_HISRepository==null)
					iSNOW_RECORD_HISRepository= new SNOW_RECORD_HISRepository();
				return iSNOW_RECORD_HISRepository;
			}
			set
			{
				iSNOW_RECORD_HISRepository= value;
			}
		}
		#endregion

		#region 348 数据接口 ISNOW_SECTION_LINERepository
		ISNOW_SECTION_LINERepository iSNOW_SECTION_LINERepository;
		public ISNOW_SECTION_LINERepository ISNOW_SECTION_LINERepository
		{
		 
			get 
			{
				if(iSNOW_SECTION_LINERepository==null)
					iSNOW_SECTION_LINERepository= new SNOW_SECTION_LINERepository();
				return iSNOW_SECTION_LINERepository;
			}
			set
			{
				iSNOW_SECTION_LINERepository= value;
			}
		}
		#endregion

		#region 349 数据接口 ISNOW_VIDEO_FILERepository
		ISNOW_VIDEO_FILERepository iSNOW_VIDEO_FILERepository;
		public ISNOW_VIDEO_FILERepository ISNOW_VIDEO_FILERepository
		{
		 
			get 
			{
				if(iSNOW_VIDEO_FILERepository==null)
					iSNOW_VIDEO_FILERepository= new SNOW_VIDEO_FILERepository();
				return iSNOW_VIDEO_FILERepository;
			}
			set
			{
				iSNOW_VIDEO_FILERepository= value;
			}
		}
		#endregion

		#region 350 数据接口 ISYS_DEPTRepository
		ISYS_DEPTRepository iSYS_DEPTRepository;
		public ISYS_DEPTRepository ISYS_DEPTRepository
		{
		 
			get 
			{
				if(iSYS_DEPTRepository==null)
					iSYS_DEPTRepository= new SYS_DEPTRepository();
				return iSYS_DEPTRepository;
			}
			set
			{
				iSYS_DEPTRepository= value;
			}
		}
		#endregion

		#region 351 数据接口 ISYS_INTELLIGENCE_DICRepository
		ISYS_INTELLIGENCE_DICRepository iSYS_INTELLIGENCE_DICRepository;
		public ISYS_INTELLIGENCE_DICRepository ISYS_INTELLIGENCE_DICRepository
		{
		 
			get 
			{
				if(iSYS_INTELLIGENCE_DICRepository==null)
					iSYS_INTELLIGENCE_DICRepository= new SYS_INTELLIGENCE_DICRepository();
				return iSYS_INTELLIGENCE_DICRepository;
			}
			set
			{
				iSYS_INTELLIGENCE_DICRepository= value;
			}
		}
		#endregion

		#region 352 数据接口 ISYS_MEMBERRepository
		ISYS_MEMBERRepository iSYS_MEMBERRepository;
		public ISYS_MEMBERRepository ISYS_MEMBERRepository
		{
		 
			get 
			{
				if(iSYS_MEMBERRepository==null)
					iSYS_MEMBERRepository= new SYS_MEMBERRepository();
				return iSYS_MEMBERRepository;
			}
			set
			{
				iSYS_MEMBERRepository= value;
			}
		}
		#endregion

		#region 353 数据接口 ISYS_MENURepository
		ISYS_MENURepository iSYS_MENURepository;
		public ISYS_MENURepository ISYS_MENURepository
		{
		 
			get 
			{
				if(iSYS_MENURepository==null)
					iSYS_MENURepository= new SYS_MENURepository();
				return iSYS_MENURepository;
			}
			set
			{
				iSYS_MENURepository= value;
			}
		}
		#endregion

		#region 354 数据接口 ISYS_MENU_HELPCONTENTRepository
		ISYS_MENU_HELPCONTENTRepository iSYS_MENU_HELPCONTENTRepository;
		public ISYS_MENU_HELPCONTENTRepository ISYS_MENU_HELPCONTENTRepository
		{
		 
			get 
			{
				if(iSYS_MENU_HELPCONTENTRepository==null)
					iSYS_MENU_HELPCONTENTRepository= new SYS_MENU_HELPCONTENTRepository();
				return iSYS_MENU_HELPCONTENTRepository;
			}
			set
			{
				iSYS_MENU_HELPCONTENTRepository= value;
			}
		}
		#endregion

		#region 355 数据接口 ISYS_MENUOPTRepository
		ISYS_MENUOPTRepository iSYS_MENUOPTRepository;
		public ISYS_MENUOPTRepository ISYS_MENUOPTRepository
		{
		 
			get 
			{
				if(iSYS_MENUOPTRepository==null)
					iSYS_MENUOPTRepository= new SYS_MENUOPTRepository();
				return iSYS_MENUOPTRepository;
			}
			set
			{
				iSYS_MENUOPTRepository= value;
			}
		}
		#endregion

		#region 356 数据接口 ISYS_POSLEVEL_DICRepository
		ISYS_POSLEVEL_DICRepository iSYS_POSLEVEL_DICRepository;
		public ISYS_POSLEVEL_DICRepository ISYS_POSLEVEL_DICRepository
		{
		 
			get 
			{
				if(iSYS_POSLEVEL_DICRepository==null)
					iSYS_POSLEVEL_DICRepository= new SYS_POSLEVEL_DICRepository();
				return iSYS_POSLEVEL_DICRepository;
			}
			set
			{
				iSYS_POSLEVEL_DICRepository= value;
			}
		}
		#endregion

		#region 357 数据接口 ISYS_ROLERepository
		ISYS_ROLERepository iSYS_ROLERepository;
		public ISYS_ROLERepository ISYS_ROLERepository
		{
		 
			get 
			{
				if(iSYS_ROLERepository==null)
					iSYS_ROLERepository= new SYS_ROLERepository();
				return iSYS_ROLERepository;
			}
			set
			{
				iSYS_ROLERepository= value;
			}
		}
		#endregion

		#region 358 数据接口 ISYS_ROLE_MENU_MAPRepository
		ISYS_ROLE_MENU_MAPRepository iSYS_ROLE_MENU_MAPRepository;
		public ISYS_ROLE_MENU_MAPRepository ISYS_ROLE_MENU_MAPRepository
		{
		 
			get 
			{
				if(iSYS_ROLE_MENU_MAPRepository==null)
					iSYS_ROLE_MENU_MAPRepository= new SYS_ROLE_MENU_MAPRepository();
				return iSYS_ROLE_MENU_MAPRepository;
			}
			set
			{
				iSYS_ROLE_MENU_MAPRepository= value;
			}
		}
		#endregion

		#region 359 数据接口 ISYS_ROLE_MENUOPT_MAPRepository
		ISYS_ROLE_MENUOPT_MAPRepository iSYS_ROLE_MENUOPT_MAPRepository;
		public ISYS_ROLE_MENUOPT_MAPRepository ISYS_ROLE_MENUOPT_MAPRepository
		{
		 
			get 
			{
				if(iSYS_ROLE_MENUOPT_MAPRepository==null)
					iSYS_ROLE_MENUOPT_MAPRepository= new SYS_ROLE_MENUOPT_MAPRepository();
				return iSYS_ROLE_MENUOPT_MAPRepository;
			}
			set
			{
				iSYS_ROLE_MENUOPT_MAPRepository= value;
			}
		}
		#endregion

		#region 360 数据接口 ISYS_STATIONMEMBER_NORepository
		ISYS_STATIONMEMBER_NORepository iSYS_STATIONMEMBER_NORepository;
		public ISYS_STATIONMEMBER_NORepository ISYS_STATIONMEMBER_NORepository
		{
		 
			get 
			{
				if(iSYS_STATIONMEMBER_NORepository==null)
					iSYS_STATIONMEMBER_NORepository= new SYS_STATIONMEMBER_NORepository();
				return iSYS_STATIONMEMBER_NORepository;
			}
			set
			{
				iSYS_STATIONMEMBER_NORepository= value;
			}
		}
		#endregion

		#region 361 数据接口 ISYS_USERRepository
		ISYS_USERRepository iSYS_USERRepository;
		public ISYS_USERRepository ISYS_USERRepository
		{
		 
			get 
			{
				if(iSYS_USERRepository==null)
					iSYS_USERRepository= new SYS_USERRepository();
				return iSYS_USERRepository;
			}
			set
			{
				iSYS_USERRepository= value;
			}
		}
		#endregion

		#region 362 数据接口 ISYS_USER_DEFAULTMENURepository
		ISYS_USER_DEFAULTMENURepository iSYS_USER_DEFAULTMENURepository;
		public ISYS_USER_DEFAULTMENURepository ISYS_USER_DEFAULTMENURepository
		{
		 
			get 
			{
				if(iSYS_USER_DEFAULTMENURepository==null)
					iSYS_USER_DEFAULTMENURepository= new SYS_USER_DEFAULTMENURepository();
				return iSYS_USER_DEFAULTMENURepository;
			}
			set
			{
				iSYS_USER_DEFAULTMENURepository= value;
			}
		}
		#endregion

		#region 363 数据接口 ISYS_USER_PHONE_DICRepository
		ISYS_USER_PHONE_DICRepository iSYS_USER_PHONE_DICRepository;
		public ISYS_USER_PHONE_DICRepository ISYS_USER_PHONE_DICRepository
		{
		 
			get 
			{
				if(iSYS_USER_PHONE_DICRepository==null)
					iSYS_USER_PHONE_DICRepository= new SYS_USER_PHONE_DICRepository();
				return iSYS_USER_PHONE_DICRepository;
			}
			set
			{
				iSYS_USER_PHONE_DICRepository= value;
			}
		}
		#endregion

		#region 364 数据接口 ISYS_USER_ROLE_MAPRepository
		ISYS_USER_ROLE_MAPRepository iSYS_USER_ROLE_MAPRepository;
		public ISYS_USER_ROLE_MAPRepository ISYS_USER_ROLE_MAPRepository
		{
		 
			get 
			{
				if(iSYS_USER_ROLE_MAPRepository==null)
					iSYS_USER_ROLE_MAPRepository= new SYS_USER_ROLE_MAPRepository();
				return iSYS_USER_ROLE_MAPRepository;
			}
			set
			{
				iSYS_USER_ROLE_MAPRepository= value;
			}
		}
		#endregion

		#region 365 数据接口 ISYS_USERLOGINRepository
		ISYS_USERLOGINRepository iSYS_USERLOGINRepository;
		public ISYS_USERLOGINRepository ISYS_USERLOGINRepository
		{
		 
			get 
			{
				if(iSYS_USERLOGINRepository==null)
					iSYS_USERLOGINRepository= new SYS_USERLOGINRepository();
				return iSYS_USERLOGINRepository;
			}
			set
			{
				iSYS_USERLOGINRepository= value;
			}
		}
		#endregion

		#region 366 数据接口 IT_ASS_BOUNDRepository
		IT_ASS_BOUNDRepository iT_ASS_BOUNDRepository;
		public IT_ASS_BOUNDRepository IT_ASS_BOUNDRepository
		{
		 
			get 
			{
				if(iT_ASS_BOUNDRepository==null)
					iT_ASS_BOUNDRepository= new T_ASS_BOUNDRepository();
				return iT_ASS_BOUNDRepository;
			}
			set
			{
				iT_ASS_BOUNDRepository= value;
			}
		}
		#endregion

		#region 367 数据接口 IT_ASS_BRIDGERepository
		IT_ASS_BRIDGERepository iT_ASS_BRIDGERepository;
		public IT_ASS_BRIDGERepository IT_ASS_BRIDGERepository
		{
		 
			get 
			{
				if(iT_ASS_BRIDGERepository==null)
					iT_ASS_BRIDGERepository= new T_ASS_BRIDGERepository();
				return iT_ASS_BRIDGERepository;
			}
			set
			{
				iT_ASS_BRIDGERepository= value;
			}
		}
		#endregion

		#region 368 数据接口 IT_ASS_BROKENCHAINRepository
		IT_ASS_BROKENCHAINRepository iT_ASS_BROKENCHAINRepository;
		public IT_ASS_BROKENCHAINRepository IT_ASS_BROKENCHAINRepository
		{
		 
			get 
			{
				if(iT_ASS_BROKENCHAINRepository==null)
					iT_ASS_BROKENCHAINRepository= new T_ASS_BROKENCHAINRepository();
				return iT_ASS_BROKENCHAINRepository;
			}
			set
			{
				iT_ASS_BROKENCHAINRepository= value;
			}
		}
		#endregion

		#region 369 数据接口 IT_ASS_COMBINEDRAWRepository
		IT_ASS_COMBINEDRAWRepository iT_ASS_COMBINEDRAWRepository;
		public IT_ASS_COMBINEDRAWRepository IT_ASS_COMBINEDRAWRepository
		{
		 
			get 
			{
				if(iT_ASS_COMBINEDRAWRepository==null)
					iT_ASS_COMBINEDRAWRepository= new T_ASS_COMBINEDRAWRepository();
				return iT_ASS_COMBINEDRAWRepository;
			}
			set
			{
				iT_ASS_COMBINEDRAWRepository= value;
			}
		}
		#endregion

		#region 370 数据接口 IT_ASS_COMPMAINT_PLANRepository
		IT_ASS_COMPMAINT_PLANRepository iT_ASS_COMPMAINT_PLANRepository;
		public IT_ASS_COMPMAINT_PLANRepository IT_ASS_COMPMAINT_PLANRepository
		{
		 
			get 
			{
				if(iT_ASS_COMPMAINT_PLANRepository==null)
					iT_ASS_COMPMAINT_PLANRepository= new T_ASS_COMPMAINT_PLANRepository();
				return iT_ASS_COMPMAINT_PLANRepository;
			}
			set
			{
				iT_ASS_COMPMAINT_PLANRepository= value;
			}
		}
		#endregion

		#region 371 数据接口 IT_ASS_COMPMAINT_PLAN_DETAILRepository
		IT_ASS_COMPMAINT_PLAN_DETAILRepository iT_ASS_COMPMAINT_PLAN_DETAILRepository;
		public IT_ASS_COMPMAINT_PLAN_DETAILRepository IT_ASS_COMPMAINT_PLAN_DETAILRepository
		{
		 
			get 
			{
				if(iT_ASS_COMPMAINT_PLAN_DETAILRepository==null)
					iT_ASS_COMPMAINT_PLAN_DETAILRepository= new T_ASS_COMPMAINT_PLAN_DETAILRepository();
				return iT_ASS_COMPMAINT_PLAN_DETAILRepository;
			}
			set
			{
				iT_ASS_COMPMAINT_PLAN_DETAILRepository= value;
			}
		}
		#endregion

		#region 372 数据接口 IT_ASS_CURVERepository
		IT_ASS_CURVERepository iT_ASS_CURVERepository;
		public IT_ASS_CURVERepository IT_ASS_CURVERepository
		{
		 
			get 
			{
				if(iT_ASS_CURVERepository==null)
					iT_ASS_CURVERepository= new T_ASS_CURVERepository();
				return iT_ASS_CURVERepository;
			}
			set
			{
				iT_ASS_CURVERepository= value;
			}
		}
		#endregion

		#region 373 数据接口 IT_ASS_EMPRepository
		IT_ASS_EMPRepository iT_ASS_EMPRepository;
		public IT_ASS_EMPRepository IT_ASS_EMPRepository
		{
		 
			get 
			{
				if(iT_ASS_EMPRepository==null)
					iT_ASS_EMPRepository= new T_ASS_EMPRepository();
				return iT_ASS_EMPRepository;
			}
			set
			{
				iT_ASS_EMPRepository= value;
			}
		}
		#endregion

		#region 374 数据接口 IT_ASS_EQU_DATA_TEMPRepository
		IT_ASS_EQU_DATA_TEMPRepository iT_ASS_EQU_DATA_TEMPRepository;
		public IT_ASS_EQU_DATA_TEMPRepository IT_ASS_EQU_DATA_TEMPRepository
		{
		 
			get 
			{
				if(iT_ASS_EQU_DATA_TEMPRepository==null)
					iT_ASS_EQU_DATA_TEMPRepository= new T_ASS_EQU_DATA_TEMPRepository();
				return iT_ASS_EQU_DATA_TEMPRepository;
			}
			set
			{
				iT_ASS_EQU_DATA_TEMPRepository= value;
			}
		}
		#endregion

		#region 375 数据接口 IT_ASS_FLOWRepository
		IT_ASS_FLOWRepository iT_ASS_FLOWRepository;
		public IT_ASS_FLOWRepository IT_ASS_FLOWRepository
		{
		 
			get 
			{
				if(iT_ASS_FLOWRepository==null)
					iT_ASS_FLOWRepository= new T_ASS_FLOWRepository();
				return iT_ASS_FLOWRepository;
			}
			set
			{
				iT_ASS_FLOWRepository= value;
			}
		}
		#endregion

		#region 376 数据接口 IT_ASS_FLOW_INSTANCERepository
		IT_ASS_FLOW_INSTANCERepository iT_ASS_FLOW_INSTANCERepository;
		public IT_ASS_FLOW_INSTANCERepository IT_ASS_FLOW_INSTANCERepository
		{
		 
			get 
			{
				if(iT_ASS_FLOW_INSTANCERepository==null)
					iT_ASS_FLOW_INSTANCERepository= new T_ASS_FLOW_INSTANCERepository();
				return iT_ASS_FLOW_INSTANCERepository;
			}
			set
			{
				iT_ASS_FLOW_INSTANCERepository= value;
			}
		}
		#endregion

		#region 377 数据接口 IT_ASS_FLOW_PROCESSRepository
		IT_ASS_FLOW_PROCESSRepository iT_ASS_FLOW_PROCESSRepository;
		public IT_ASS_FLOW_PROCESSRepository IT_ASS_FLOW_PROCESSRepository
		{
		 
			get 
			{
				if(iT_ASS_FLOW_PROCESSRepository==null)
					iT_ASS_FLOW_PROCESSRepository= new T_ASS_FLOW_PROCESSRepository();
				return iT_ASS_FLOW_PROCESSRepository;
			}
			set
			{
				iT_ASS_FLOW_PROCESSRepository= value;
			}
		}
		#endregion

		#region 378 数据接口 IT_ASS_FLOW_ROLERepository
		IT_ASS_FLOW_ROLERepository iT_ASS_FLOW_ROLERepository;
		public IT_ASS_FLOW_ROLERepository IT_ASS_FLOW_ROLERepository
		{
		 
			get 
			{
				if(iT_ASS_FLOW_ROLERepository==null)
					iT_ASS_FLOW_ROLERepository= new T_ASS_FLOW_ROLERepository();
				return iT_ASS_FLOW_ROLERepository;
			}
			set
			{
				iT_ASS_FLOW_ROLERepository= value;
			}
		}
		#endregion

		#region 379 数据接口 IT_ASS_FLOW_STEPRepository
		IT_ASS_FLOW_STEPRepository iT_ASS_FLOW_STEPRepository;
		public IT_ASS_FLOW_STEPRepository IT_ASS_FLOW_STEPRepository
		{
		 
			get 
			{
				if(iT_ASS_FLOW_STEPRepository==null)
					iT_ASS_FLOW_STEPRepository= new T_ASS_FLOW_STEPRepository();
				return iT_ASS_FLOW_STEPRepository;
			}
			set
			{
				iT_ASS_FLOW_STEPRepository= value;
			}
		}
		#endregion

		#region 380 数据接口 IT_ASS_FLOW_USER_ROLERepository
		IT_ASS_FLOW_USER_ROLERepository iT_ASS_FLOW_USER_ROLERepository;
		public IT_ASS_FLOW_USER_ROLERepository IT_ASS_FLOW_USER_ROLERepository
		{
		 
			get 
			{
				if(iT_ASS_FLOW_USER_ROLERepository==null)
					iT_ASS_FLOW_USER_ROLERepository= new T_ASS_FLOW_USER_ROLERepository();
				return iT_ASS_FLOW_USER_ROLERepository;
			}
			set
			{
				iT_ASS_FLOW_USER_ROLERepository= value;
			}
		}
		#endregion

		#region 381 数据接口 IT_ASS_GJC_AVESCORERepository
		IT_ASS_GJC_AVESCORERepository iT_ASS_GJC_AVESCORERepository;
		public IT_ASS_GJC_AVESCORERepository IT_ASS_GJC_AVESCORERepository
		{
		 
			get 
			{
				if(iT_ASS_GJC_AVESCORERepository==null)
					iT_ASS_GJC_AVESCORERepository= new T_ASS_GJC_AVESCORERepository();
				return iT_ASS_GJC_AVESCORERepository;
			}
			set
			{
				iT_ASS_GJC_AVESCORERepository= value;
			}
		}
		#endregion

		#region 382 数据接口 IT_ASS_LINEDRAWRepository
		IT_ASS_LINEDRAWRepository iT_ASS_LINEDRAWRepository;
		public IT_ASS_LINEDRAWRepository IT_ASS_LINEDRAWRepository
		{
		 
			get 
			{
				if(iT_ASS_LINEDRAWRepository==null)
					iT_ASS_LINEDRAWRepository= new T_ASS_LINEDRAWRepository();
				return iT_ASS_LINEDRAWRepository;
			}
			set
			{
				iT_ASS_LINEDRAWRepository= value;
			}
		}
		#endregion

		#region 383 数据接口 IT_ASS_MATERIALRepository
		IT_ASS_MATERIALRepository iT_ASS_MATERIALRepository;
		public IT_ASS_MATERIALRepository IT_ASS_MATERIALRepository
		{
		 
			get 
			{
				if(iT_ASS_MATERIALRepository==null)
					iT_ASS_MATERIALRepository= new T_ASS_MATERIALRepository();
				return iT_ASS_MATERIALRepository;
			}
			set
			{
				iT_ASS_MATERIALRepository= value;
			}
		}
		#endregion

		#region 384 数据接口 IT_ASS_PARA_DYN_SCORERepository
		IT_ASS_PARA_DYN_SCORERepository iT_ASS_PARA_DYN_SCORERepository;
		public IT_ASS_PARA_DYN_SCORERepository IT_ASS_PARA_DYN_SCORERepository
		{
		 
			get 
			{
				if(iT_ASS_PARA_DYN_SCORERepository==null)
					iT_ASS_PARA_DYN_SCORERepository= new T_ASS_PARA_DYN_SCORERepository();
				return iT_ASS_PARA_DYN_SCORERepository;
			}
			set
			{
				iT_ASS_PARA_DYN_SCORERepository= value;
			}
		}
		#endregion

		#region 385 数据接口 IT_ASS_PARA_LEVEL_SCORERepository
		IT_ASS_PARA_LEVEL_SCORERepository iT_ASS_PARA_LEVEL_SCORERepository;
		public IT_ASS_PARA_LEVEL_SCORERepository IT_ASS_PARA_LEVEL_SCORERepository
		{
		 
			get 
			{
				if(iT_ASS_PARA_LEVEL_SCORERepository==null)
					iT_ASS_PARA_LEVEL_SCORERepository= new T_ASS_PARA_LEVEL_SCORERepository();
				return iT_ASS_PARA_LEVEL_SCORERepository;
			}
			set
			{
				iT_ASS_PARA_LEVEL_SCORERepository= value;
			}
		}
		#endregion

		#region 386 数据接口 IT_ASS_PARA_PLACERepository
		IT_ASS_PARA_PLACERepository iT_ASS_PARA_PLACERepository;
		public IT_ASS_PARA_PLACERepository IT_ASS_PARA_PLACERepository
		{
		 
			get 
			{
				if(iT_ASS_PARA_PLACERepository==null)
					iT_ASS_PARA_PLACERepository= new T_ASS_PARA_PLACERepository();
				return iT_ASS_PARA_PLACERepository;
			}
			set
			{
				iT_ASS_PARA_PLACERepository= value;
			}
		}
		#endregion

		#region 387 数据接口 IT_ASS_PARA_PRO_CTRLRepository
		IT_ASS_PARA_PRO_CTRLRepository iT_ASS_PARA_PRO_CTRLRepository;
		public IT_ASS_PARA_PRO_CTRLRepository IT_ASS_PARA_PRO_CTRLRepository
		{
		 
			get 
			{
				if(iT_ASS_PARA_PRO_CTRLRepository==null)
					iT_ASS_PARA_PRO_CTRLRepository= new T_ASS_PARA_PRO_CTRLRepository();
				return iT_ASS_PARA_PRO_CTRLRepository;
			}
			set
			{
				iT_ASS_PARA_PRO_CTRLRepository= value;
			}
		}
		#endregion

		#region 388 数据接口 IT_ASS_PARA_PRO_TYPERepository
		IT_ASS_PARA_PRO_TYPERepository iT_ASS_PARA_PRO_TYPERepository;
		public IT_ASS_PARA_PRO_TYPERepository IT_ASS_PARA_PRO_TYPERepository
		{
		 
			get 
			{
				if(iT_ASS_PARA_PRO_TYPERepository==null)
					iT_ASS_PARA_PRO_TYPERepository= new T_ASS_PARA_PRO_TYPERepository();
				return iT_ASS_PARA_PRO_TYPERepository;
			}
			set
			{
				iT_ASS_PARA_PRO_TYPERepository= value;
			}
		}
		#endregion

		#region 389 数据接口 IT_ASS_PARA_SCORERepository
		IT_ASS_PARA_SCORERepository iT_ASS_PARA_SCORERepository;
		public IT_ASS_PARA_SCORERepository IT_ASS_PARA_SCORERepository
		{
		 
			get 
			{
				if(iT_ASS_PARA_SCORERepository==null)
					iT_ASS_PARA_SCORERepository= new T_ASS_PARA_SCORERepository();
				return iT_ASS_PARA_SCORERepository;
			}
			set
			{
				iT_ASS_PARA_SCORERepository= value;
			}
		}
		#endregion

		#region 390 数据接口 IT_ASS_PARAREPORT_TEMPRepository
		IT_ASS_PARAREPORT_TEMPRepository iT_ASS_PARAREPORT_TEMPRepository;
		public IT_ASS_PARAREPORT_TEMPRepository IT_ASS_PARAREPORT_TEMPRepository
		{
		 
			get 
			{
				if(iT_ASS_PARAREPORT_TEMPRepository==null)
					iT_ASS_PARAREPORT_TEMPRepository= new T_ASS_PARAREPORT_TEMPRepository();
				return iT_ASS_PARAREPORT_TEMPRepository;
			}
			set
			{
				iT_ASS_PARAREPORT_TEMPRepository= value;
			}
		}
		#endregion

		#region 391 数据接口 IT_ASS_PLAN_CONSTRUCTIONRepository
		IT_ASS_PLAN_CONSTRUCTIONRepository iT_ASS_PLAN_CONSTRUCTIONRepository;
		public IT_ASS_PLAN_CONSTRUCTIONRepository IT_ASS_PLAN_CONSTRUCTIONRepository
		{
		 
			get 
			{
				if(iT_ASS_PLAN_CONSTRUCTIONRepository==null)
					iT_ASS_PLAN_CONSTRUCTIONRepository= new T_ASS_PLAN_CONSTRUCTIONRepository();
				return iT_ASS_PLAN_CONSTRUCTIONRepository;
			}
			set
			{
				iT_ASS_PLAN_CONSTRUCTIONRepository= value;
			}
		}
		#endregion

		#region 392 数据接口 IT_ASS_PLAN_DAILYRepository
		IT_ASS_PLAN_DAILYRepository iT_ASS_PLAN_DAILYRepository;
		public IT_ASS_PLAN_DAILYRepository IT_ASS_PLAN_DAILYRepository
		{
		 
			get 
			{
				if(iT_ASS_PLAN_DAILYRepository==null)
					iT_ASS_PLAN_DAILYRepository= new T_ASS_PLAN_DAILYRepository();
				return iT_ASS_PLAN_DAILYRepository;
			}
			set
			{
				iT_ASS_PLAN_DAILYRepository= value;
			}
		}
		#endregion

		#region 393 数据接口 IT_ASS_PLAN_DATA_TEMPRepository
		IT_ASS_PLAN_DATA_TEMPRepository iT_ASS_PLAN_DATA_TEMPRepository;
		public IT_ASS_PLAN_DATA_TEMPRepository IT_ASS_PLAN_DATA_TEMPRepository
		{
		 
			get 
			{
				if(iT_ASS_PLAN_DATA_TEMPRepository==null)
					iT_ASS_PLAN_DATA_TEMPRepository= new T_ASS_PLAN_DATA_TEMPRepository();
				return iT_ASS_PLAN_DATA_TEMPRepository;
			}
			set
			{
				iT_ASS_PLAN_DATA_TEMPRepository= value;
			}
		}
		#endregion

		#region 394 数据接口 IT_ASS_PLAN_FLOWRepository
		IT_ASS_PLAN_FLOWRepository iT_ASS_PLAN_FLOWRepository;
		public IT_ASS_PLAN_FLOWRepository IT_ASS_PLAN_FLOWRepository
		{
		 
			get 
			{
				if(iT_ASS_PLAN_FLOWRepository==null)
					iT_ASS_PLAN_FLOWRepository= new T_ASS_PLAN_FLOWRepository();
				return iT_ASS_PLAN_FLOWRepository;
			}
			set
			{
				iT_ASS_PLAN_FLOWRepository= value;
			}
		}
		#endregion

		#region 395 数据接口 IT_ASS_PLAN_LOCATERepository
		IT_ASS_PLAN_LOCATERepository iT_ASS_PLAN_LOCATERepository;
		public IT_ASS_PLAN_LOCATERepository IT_ASS_PLAN_LOCATERepository
		{
		 
			get 
			{
				if(iT_ASS_PLAN_LOCATERepository==null)
					iT_ASS_PLAN_LOCATERepository= new T_ASS_PLAN_LOCATERepository();
				return iT_ASS_PLAN_LOCATERepository;
			}
			set
			{
				iT_ASS_PLAN_LOCATERepository= value;
			}
		}
		#endregion

		#region 396 数据接口 IT_ASS_PLAN_MATERIALRepository
		IT_ASS_PLAN_MATERIALRepository iT_ASS_PLAN_MATERIALRepository;
		public IT_ASS_PLAN_MATERIALRepository IT_ASS_PLAN_MATERIALRepository
		{
		 
			get 
			{
				if(iT_ASS_PLAN_MATERIALRepository==null)
					iT_ASS_PLAN_MATERIALRepository= new T_ASS_PLAN_MATERIALRepository();
				return iT_ASS_PLAN_MATERIALRepository;
			}
			set
			{
				iT_ASS_PLAN_MATERIALRepository= value;
			}
		}
		#endregion

		#region 397 数据接口 IT_ASS_PLAN_MEMBERRepository
		IT_ASS_PLAN_MEMBERRepository iT_ASS_PLAN_MEMBERRepository;
		public IT_ASS_PLAN_MEMBERRepository IT_ASS_PLAN_MEMBERRepository
		{
		 
			get 
			{
				if(iT_ASS_PLAN_MEMBERRepository==null)
					iT_ASS_PLAN_MEMBERRepository= new T_ASS_PLAN_MEMBERRepository();
				return iT_ASS_PLAN_MEMBERRepository;
			}
			set
			{
				iT_ASS_PLAN_MEMBERRepository= value;
			}
		}
		#endregion

		#region 398 数据接口 IT_ASS_PLAN_MONTHRepository
		IT_ASS_PLAN_MONTHRepository iT_ASS_PLAN_MONTHRepository;
		public IT_ASS_PLAN_MONTHRepository IT_ASS_PLAN_MONTHRepository
		{
		 
			get 
			{
				if(iT_ASS_PLAN_MONTHRepository==null)
					iT_ASS_PLAN_MONTHRepository= new T_ASS_PLAN_MONTHRepository();
				return iT_ASS_PLAN_MONTHRepository;
			}
			set
			{
				iT_ASS_PLAN_MONTHRepository= value;
			}
		}
		#endregion

		#region 399 数据接口 IT_ASS_PLAN_PROBLEMRepository
		IT_ASS_PLAN_PROBLEMRepository iT_ASS_PLAN_PROBLEMRepository;
		public IT_ASS_PLAN_PROBLEMRepository IT_ASS_PLAN_PROBLEMRepository
		{
		 
			get 
			{
				if(iT_ASS_PLAN_PROBLEMRepository==null)
					iT_ASS_PLAN_PROBLEMRepository= new T_ASS_PLAN_PROBLEMRepository();
				return iT_ASS_PLAN_PROBLEMRepository;
			}
			set
			{
				iT_ASS_PLAN_PROBLEMRepository= value;
			}
		}
		#endregion

		#region 400 数据接口 IT_ASS_PLAN_PROJECTRepository
		IT_ASS_PLAN_PROJECTRepository iT_ASS_PLAN_PROJECTRepository;
		public IT_ASS_PLAN_PROJECTRepository IT_ASS_PLAN_PROJECTRepository
		{
		 
			get 
			{
				if(iT_ASS_PLAN_PROJECTRepository==null)
					iT_ASS_PLAN_PROJECTRepository= new T_ASS_PLAN_PROJECTRepository();
				return iT_ASS_PLAN_PROJECTRepository;
			}
			set
			{
				iT_ASS_PLAN_PROJECTRepository= value;
			}
		}
		#endregion

		#region 401 数据接口 IT_ASS_PLAN_REPAIRRepository
		IT_ASS_PLAN_REPAIRRepository iT_ASS_PLAN_REPAIRRepository;
		public IT_ASS_PLAN_REPAIRRepository IT_ASS_PLAN_REPAIRRepository
		{
		 
			get 
			{
				if(iT_ASS_PLAN_REPAIRRepository==null)
					iT_ASS_PLAN_REPAIRRepository= new T_ASS_PLAN_REPAIRRepository();
				return iT_ASS_PLAN_REPAIRRepository;
			}
			set
			{
				iT_ASS_PLAN_REPAIRRepository= value;
			}
		}
		#endregion

		#region 402 数据接口 IT_ASS_PLAN_TOOLRepository
		IT_ASS_PLAN_TOOLRepository iT_ASS_PLAN_TOOLRepository;
		public IT_ASS_PLAN_TOOLRepository IT_ASS_PLAN_TOOLRepository
		{
		 
			get 
			{
				if(iT_ASS_PLAN_TOOLRepository==null)
					iT_ASS_PLAN_TOOLRepository= new T_ASS_PLAN_TOOLRepository();
				return iT_ASS_PLAN_TOOLRepository;
			}
			set
			{
				iT_ASS_PLAN_TOOLRepository= value;
			}
		}
		#endregion

		#region 403 数据接口 IT_ASS_PLAN_UNIT_PRO_STATRepository
		IT_ASS_PLAN_UNIT_PRO_STATRepository iT_ASS_PLAN_UNIT_PRO_STATRepository;
		public IT_ASS_PLAN_UNIT_PRO_STATRepository IT_ASS_PLAN_UNIT_PRO_STATRepository
		{
		 
			get 
			{
				if(iT_ASS_PLAN_UNIT_PRO_STATRepository==null)
					iT_ASS_PLAN_UNIT_PRO_STATRepository= new T_ASS_PLAN_UNIT_PRO_STATRepository();
				return iT_ASS_PLAN_UNIT_PRO_STATRepository;
			}
			set
			{
				iT_ASS_PLAN_UNIT_PRO_STATRepository= value;
			}
		}
		#endregion

		#region 404 数据接口 IT_ASS_PLAN_WEEKRepository
		IT_ASS_PLAN_WEEKRepository iT_ASS_PLAN_WEEKRepository;
		public IT_ASS_PLAN_WEEKRepository IT_ASS_PLAN_WEEKRepository
		{
		 
			get 
			{
				if(iT_ASS_PLAN_WEEKRepository==null)
					iT_ASS_PLAN_WEEKRepository= new T_ASS_PLAN_WEEKRepository();
				return iT_ASS_PLAN_WEEKRepository;
			}
			set
			{
				iT_ASS_PLAN_WEEKRepository= value;
			}
		}
		#endregion

		#region 405 数据接口 IT_ASS_PROBLEMRepository
		IT_ASS_PROBLEMRepository iT_ASS_PROBLEMRepository;
		public IT_ASS_PROBLEMRepository IT_ASS_PROBLEMRepository
		{
		 
			get 
			{
				if(iT_ASS_PROBLEMRepository==null)
					iT_ASS_PROBLEMRepository= new T_ASS_PROBLEMRepository();
				return iT_ASS_PROBLEMRepository;
			}
			set
			{
				iT_ASS_PROBLEMRepository= value;
			}
		}
		#endregion

		#region 406 数据接口 IT_ASS_PROBLEM_HISRepository
		IT_ASS_PROBLEM_HISRepository iT_ASS_PROBLEM_HISRepository;
		public IT_ASS_PROBLEM_HISRepository IT_ASS_PROBLEM_HISRepository
		{
		 
			get 
			{
				if(iT_ASS_PROBLEM_HISRepository==null)
					iT_ASS_PROBLEM_HISRepository= new T_ASS_PROBLEM_HISRepository();
				return iT_ASS_PROBLEM_HISRepository;
			}
			set
			{
				iT_ASS_PROBLEM_HISRepository= value;
			}
		}
		#endregion

		#region 407 数据接口 IT_ASS_PROBLEM_LJRepository
		IT_ASS_PROBLEM_LJRepository iT_ASS_PROBLEM_LJRepository;
		public IT_ASS_PROBLEM_LJRepository IT_ASS_PROBLEM_LJRepository
		{
		 
			get 
			{
				if(iT_ASS_PROBLEM_LJRepository==null)
					iT_ASS_PROBLEM_LJRepository= new T_ASS_PROBLEM_LJRepository();
				return iT_ASS_PROBLEM_LJRepository;
			}
			set
			{
				iT_ASS_PROBLEM_LJRepository= value;
			}
		}
		#endregion

		#region 408 数据接口 IT_ASS_PROBLEM_ORIRepository
		IT_ASS_PROBLEM_ORIRepository iT_ASS_PROBLEM_ORIRepository;
		public IT_ASS_PROBLEM_ORIRepository IT_ASS_PROBLEM_ORIRepository
		{
		 
			get 
			{
				if(iT_ASS_PROBLEM_ORIRepository==null)
					iT_ASS_PROBLEM_ORIRepository= new T_ASS_PROBLEM_ORIRepository();
				return iT_ASS_PROBLEM_ORIRepository;
			}
			set
			{
				iT_ASS_PROBLEM_ORIRepository= value;
			}
		}
		#endregion

		#region 409 数据接口 IT_ASS_PROBLEM_TEMPRepository
		IT_ASS_PROBLEM_TEMPRepository iT_ASS_PROBLEM_TEMPRepository;
		public IT_ASS_PROBLEM_TEMPRepository IT_ASS_PROBLEM_TEMPRepository
		{
		 
			get 
			{
				if(iT_ASS_PROBLEM_TEMPRepository==null)
					iT_ASS_PROBLEM_TEMPRepository= new T_ASS_PROBLEM_TEMPRepository();
				return iT_ASS_PROBLEM_TEMPRepository;
			}
			set
			{
				iT_ASS_PROBLEM_TEMPRepository= value;
			}
		}
		#endregion

		#region 410 数据接口 IT_ASS_PROJECTRepository
		IT_ASS_PROJECTRepository iT_ASS_PROJECTRepository;
		public IT_ASS_PROJECTRepository IT_ASS_PROJECTRepository
		{
		 
			get 
			{
				if(iT_ASS_PROJECTRepository==null)
					iT_ASS_PROJECTRepository= new T_ASS_PROJECTRepository();
				return iT_ASS_PROJECTRepository;
			}
			set
			{
				iT_ASS_PROJECTRepository= value;
			}
		}
		#endregion

		#region 411 数据接口 IT_ASS_REPEAT_PROBLEMRepository
		IT_ASS_REPEAT_PROBLEMRepository iT_ASS_REPEAT_PROBLEMRepository;
		public IT_ASS_REPEAT_PROBLEMRepository IT_ASS_REPEAT_PROBLEMRepository
		{
		 
			get 
			{
				if(iT_ASS_REPEAT_PROBLEMRepository==null)
					iT_ASS_REPEAT_PROBLEMRepository= new T_ASS_REPEAT_PROBLEMRepository();
				return iT_ASS_REPEAT_PROBLEMRepository;
			}
			set
			{
				iT_ASS_REPEAT_PROBLEMRepository= value;
			}
		}
		#endregion

		#region 412 数据接口 IT_ASS_REPEAT_PRODETAILRepository
		IT_ASS_REPEAT_PRODETAILRepository iT_ASS_REPEAT_PRODETAILRepository;
		public IT_ASS_REPEAT_PRODETAILRepository IT_ASS_REPEAT_PRODETAILRepository
		{
		 
			get 
			{
				if(iT_ASS_REPEAT_PRODETAILRepository==null)
					iT_ASS_REPEAT_PRODETAILRepository= new T_ASS_REPEAT_PRODETAILRepository();
				return iT_ASS_REPEAT_PRODETAILRepository;
			}
			set
			{
				iT_ASS_REPEAT_PRODETAILRepository= value;
			}
		}
		#endregion

		#region 413 数据接口 IT_ASS_SECURITY_OFFERRepository
		IT_ASS_SECURITY_OFFERRepository iT_ASS_SECURITY_OFFERRepository;
		public IT_ASS_SECURITY_OFFERRepository IT_ASS_SECURITY_OFFERRepository
		{
		 
			get 
			{
				if(iT_ASS_SECURITY_OFFERRepository==null)
					iT_ASS_SECURITY_OFFERRepository= new T_ASS_SECURITY_OFFERRepository();
				return iT_ASS_SECURITY_OFFERRepository;
			}
			set
			{
				iT_ASS_SECURITY_OFFERRepository= value;
			}
		}
		#endregion

		#region 414 数据接口 IT_ASS_STATIONRepository
		IT_ASS_STATIONRepository iT_ASS_STATIONRepository;
		public IT_ASS_STATIONRepository IT_ASS_STATIONRepository
		{
		 
			get 
			{
				if(iT_ASS_STATIONRepository==null)
					iT_ASS_STATIONRepository= new T_ASS_STATIONRepository();
				return iT_ASS_STATIONRepository;
			}
			set
			{
				iT_ASS_STATIONRepository= value;
			}
		}
		#endregion

		#region 415 数据接口 IT_ASS_STATIONSTAIRSRepository
		IT_ASS_STATIONSTAIRSRepository iT_ASS_STATIONSTAIRSRepository;
		public IT_ASS_STATIONSTAIRSRepository IT_ASS_STATIONSTAIRSRepository
		{
		 
			get 
			{
				if(iT_ASS_STATIONSTAIRSRepository==null)
					iT_ASS_STATIONSTAIRSRepository= new T_ASS_STATIONSTAIRSRepository();
				return iT_ASS_STATIONSTAIRSRepository;
			}
			set
			{
				iT_ASS_STATIONSTAIRSRepository= value;
			}
		}
		#endregion

		#region 416 数据接口 IT_ASS_TEMREPAIR_PLANRepository
		IT_ASS_TEMREPAIR_PLANRepository iT_ASS_TEMREPAIR_PLANRepository;
		public IT_ASS_TEMREPAIR_PLANRepository IT_ASS_TEMREPAIR_PLANRepository
		{
		 
			get 
			{
				if(iT_ASS_TEMREPAIR_PLANRepository==null)
					iT_ASS_TEMREPAIR_PLANRepository= new T_ASS_TEMREPAIR_PLANRepository();
				return iT_ASS_TEMREPAIR_PLANRepository;
			}
			set
			{
				iT_ASS_TEMREPAIR_PLANRepository= value;
			}
		}
		#endregion

		#region 417 数据接口 IT_ASS_TEMREPAIR_PLAN_DETAILRepository
		IT_ASS_TEMREPAIR_PLAN_DETAILRepository iT_ASS_TEMREPAIR_PLAN_DETAILRepository;
		public IT_ASS_TEMREPAIR_PLAN_DETAILRepository IT_ASS_TEMREPAIR_PLAN_DETAILRepository
		{
		 
			get 
			{
				if(iT_ASS_TEMREPAIR_PLAN_DETAILRepository==null)
					iT_ASS_TEMREPAIR_PLAN_DETAILRepository= new T_ASS_TEMREPAIR_PLAN_DETAILRepository();
				return iT_ASS_TEMREPAIR_PLAN_DETAILRepository;
			}
			set
			{
				iT_ASS_TEMREPAIR_PLAN_DETAILRepository= value;
			}
		}
		#endregion

		#region 418 数据接口 IT_ASS_TOOLINFORepository
		IT_ASS_TOOLINFORepository iT_ASS_TOOLINFORepository;
		public IT_ASS_TOOLINFORepository IT_ASS_TOOLINFORepository
		{
		 
			get 
			{
				if(iT_ASS_TOOLINFORepository==null)
					iT_ASS_TOOLINFORepository= new T_ASS_TOOLINFORepository();
				return iT_ASS_TOOLINFORepository;
			}
			set
			{
				iT_ASS_TOOLINFORepository= value;
			}
		}
		#endregion

		#region 419 数据接口 IT_ASS_TQIRepository
		IT_ASS_TQIRepository iT_ASS_TQIRepository;
		public IT_ASS_TQIRepository IT_ASS_TQIRepository
		{
		 
			get 
			{
				if(iT_ASS_TQIRepository==null)
					iT_ASS_TQIRepository= new T_ASS_TQIRepository();
				return iT_ASS_TQIRepository;
			}
			set
			{
				iT_ASS_TQIRepository= value;
			}
		}
		#endregion

		#region 420 数据接口 IT_ASS_TQI_AVESCORERepository
		IT_ASS_TQI_AVESCORERepository iT_ASS_TQI_AVESCORERepository;
		public IT_ASS_TQI_AVESCORERepository IT_ASS_TQI_AVESCORERepository
		{
		 
			get 
			{
				if(iT_ASS_TQI_AVESCORERepository==null)
					iT_ASS_TQI_AVESCORERepository= new T_ASS_TQI_AVESCORERepository();
				return iT_ASS_TQI_AVESCORERepository;
			}
			set
			{
				iT_ASS_TQI_AVESCORERepository= value;
			}
		}
		#endregion

		#region 421 数据接口 IT_ASS_TQI_DETAILRepository
		IT_ASS_TQI_DETAILRepository iT_ASS_TQI_DETAILRepository;
		public IT_ASS_TQI_DETAILRepository IT_ASS_TQI_DETAILRepository
		{
		 
			get 
			{
				if(iT_ASS_TQI_DETAILRepository==null)
					iT_ASS_TQI_DETAILRepository= new T_ASS_TQI_DETAILRepository();
				return iT_ASS_TQI_DETAILRepository;
			}
			set
			{
				iT_ASS_TQI_DETAILRepository= value;
			}
		}
		#endregion

		#region 422 数据接口 IT_ASS_TQI_PARARepository
		IT_ASS_TQI_PARARepository iT_ASS_TQI_PARARepository;
		public IT_ASS_TQI_PARARepository IT_ASS_TQI_PARARepository
		{
		 
			get 
			{
				if(iT_ASS_TQI_PARARepository==null)
					iT_ASS_TQI_PARARepository= new T_ASS_TQI_PARARepository();
				return iT_ASS_TQI_PARARepository;
			}
			set
			{
				iT_ASS_TQI_PARARepository= value;
			}
		}
		#endregion

		#region 423 数据接口 IT_ASS_TQI_PARA2Repository
		IT_ASS_TQI_PARA2Repository iT_ASS_TQI_PARA2Repository;
		public IT_ASS_TQI_PARA2Repository IT_ASS_TQI_PARA2Repository
		{
		 
			get 
			{
				if(iT_ASS_TQI_PARA2Repository==null)
					iT_ASS_TQI_PARA2Repository= new T_ASS_TQI_PARA2Repository();
				return iT_ASS_TQI_PARA2Repository;
			}
			set
			{
				iT_ASS_TQI_PARA2Repository= value;
			}
		}
		#endregion

		#region 424 数据接口 IT_ASS_TRACKRepository
		IT_ASS_TRACKRepository iT_ASS_TRACKRepository;
		public IT_ASS_TRACKRepository IT_ASS_TRACKRepository
		{
		 
			get 
			{
				if(iT_ASS_TRACKRepository==null)
					iT_ASS_TRACKRepository= new T_ASS_TRACKRepository();
				return iT_ASS_TRACKRepository;
			}
			set
			{
				iT_ASS_TRACKRepository= value;
			}
		}
		#endregion

		#region 425 数据接口 IT_ASS_TRACK_VALRepository
		IT_ASS_TRACK_VALRepository iT_ASS_TRACK_VALRepository;
		public IT_ASS_TRACK_VALRepository IT_ASS_TRACK_VALRepository
		{
		 
			get 
			{
				if(iT_ASS_TRACK_VALRepository==null)
					iT_ASS_TRACK_VALRepository= new T_ASS_TRACK_VALRepository();
				return iT_ASS_TRACK_VALRepository;
			}
			set
			{
				iT_ASS_TRACK_VALRepository= value;
			}
		}
		#endregion

		#region 426 数据接口 IT_ASS_TRACK_VAL_DETAILRepository
		IT_ASS_TRACK_VAL_DETAILRepository iT_ASS_TRACK_VAL_DETAILRepository;
		public IT_ASS_TRACK_VAL_DETAILRepository IT_ASS_TRACK_VAL_DETAILRepository
		{
		 
			get 
			{
				if(iT_ASS_TRACK_VAL_DETAILRepository==null)
					iT_ASS_TRACK_VAL_DETAILRepository= new T_ASS_TRACK_VAL_DETAILRepository();
				return iT_ASS_TRACK_VAL_DETAILRepository;
			}
			set
			{
				iT_ASS_TRACK_VAL_DETAILRepository= value;
			}
		}
		#endregion

		#region 427 数据接口 IT_ASS_TUNNELRepository
		IT_ASS_TUNNELRepository iT_ASS_TUNNELRepository;
		public IT_ASS_TUNNELRepository IT_ASS_TUNNELRepository
		{
		 
			get 
			{
				if(iT_ASS_TUNNELRepository==null)
					iT_ASS_TUNNELRepository= new T_ASS_TUNNELRepository();
				return iT_ASS_TUNNELRepository;
			}
			set
			{
				iT_ASS_TUNNELRepository= value;
			}
		}
		#endregion

		#region 428 数据接口 IT_ASS_TURNOUTRepository
		IT_ASS_TURNOUTRepository iT_ASS_TURNOUTRepository;
		public IT_ASS_TURNOUTRepository IT_ASS_TURNOUTRepository
		{
		 
			get 
			{
				if(iT_ASS_TURNOUTRepository==null)
					iT_ASS_TURNOUTRepository= new T_ASS_TURNOUTRepository();
				return iT_ASS_TURNOUTRepository;
			}
			set
			{
				iT_ASS_TURNOUTRepository= value;
			}
		}
		#endregion

		#region 429 数据接口 IT_ASS_TURNOUT_VALRepository
		IT_ASS_TURNOUT_VALRepository iT_ASS_TURNOUT_VALRepository;
		public IT_ASS_TURNOUT_VALRepository IT_ASS_TURNOUT_VALRepository
		{
		 
			get 
			{
				if(iT_ASS_TURNOUT_VALRepository==null)
					iT_ASS_TURNOUT_VALRepository= new T_ASS_TURNOUT_VALRepository();
				return iT_ASS_TURNOUT_VALRepository;
			}
			set
			{
				iT_ASS_TURNOUT_VALRepository= value;
			}
		}
		#endregion

		#region 430 数据接口 IT_ASS_TURNOUT_VAL_DETAILRepository
		IT_ASS_TURNOUT_VAL_DETAILRepository iT_ASS_TURNOUT_VAL_DETAILRepository;
		public IT_ASS_TURNOUT_VAL_DETAILRepository IT_ASS_TURNOUT_VAL_DETAILRepository
		{
		 
			get 
			{
				if(iT_ASS_TURNOUT_VAL_DETAILRepository==null)
					iT_ASS_TURNOUT_VAL_DETAILRepository= new T_ASS_TURNOUT_VAL_DETAILRepository();
				return iT_ASS_TURNOUT_VAL_DETAILRepository;
			}
			set
			{
				iT_ASS_TURNOUT_VAL_DETAILRepository= value;
			}
		}
		#endregion

		#region 431 数据接口 IT_ASS_UNITRepository
		IT_ASS_UNITRepository iT_ASS_UNITRepository;
		public IT_ASS_UNITRepository IT_ASS_UNITRepository
		{
		 
			get 
			{
				if(iT_ASS_UNITRepository==null)
					iT_ASS_UNITRepository= new T_ASS_UNITRepository();
				return iT_ASS_UNITRepository;
			}
			set
			{
				iT_ASS_UNITRepository= value;
			}
		}
		#endregion

		#region 432 数据接口 IT_ASS_UNIT_TQIRepository
		IT_ASS_UNIT_TQIRepository iT_ASS_UNIT_TQIRepository;
		public IT_ASS_UNIT_TQIRepository IT_ASS_UNIT_TQIRepository
		{
		 
			get 
			{
				if(iT_ASS_UNIT_TQIRepository==null)
					iT_ASS_UNIT_TQIRepository= new T_ASS_UNIT_TQIRepository();
				return iT_ASS_UNIT_TQIRepository;
			}
			set
			{
				iT_ASS_UNIT_TQIRepository= value;
			}
		}
		#endregion

		#region 433 数据接口 IT_ASS_UNIT_VALRepository
		IT_ASS_UNIT_VALRepository iT_ASS_UNIT_VALRepository;
		public IT_ASS_UNIT_VALRepository IT_ASS_UNIT_VALRepository
		{
		 
			get 
			{
				if(iT_ASS_UNIT_VALRepository==null)
					iT_ASS_UNIT_VALRepository= new T_ASS_UNIT_VALRepository();
				return iT_ASS_UNIT_VALRepository;
			}
			set
			{
				iT_ASS_UNIT_VALRepository= value;
			}
		}
		#endregion

		#region 434 数据接口 IT_ASS_UNIT_VAL_DETAILRepository
		IT_ASS_UNIT_VAL_DETAILRepository iT_ASS_UNIT_VAL_DETAILRepository;
		public IT_ASS_UNIT_VAL_DETAILRepository IT_ASS_UNIT_VAL_DETAILRepository
		{
		 
			get 
			{
				if(iT_ASS_UNIT_VAL_DETAILRepository==null)
					iT_ASS_UNIT_VAL_DETAILRepository= new T_ASS_UNIT_VAL_DETAILRepository();
				return iT_ASS_UNIT_VAL_DETAILRepository;
			}
			set
			{
				iT_ASS_UNIT_VAL_DETAILRepository= value;
			}
		}
		#endregion

		#region 435 数据接口 IT_ASS_UNIT625Repository
		IT_ASS_UNIT625Repository iT_ASS_UNIT625Repository;
		public IT_ASS_UNIT625Repository IT_ASS_UNIT625Repository
		{
		 
			get 
			{
				if(iT_ASS_UNIT625Repository==null)
					iT_ASS_UNIT625Repository= new T_ASS_UNIT625Repository();
				return iT_ASS_UNIT625Repository;
			}
			set
			{
				iT_ASS_UNIT625Repository= value;
			}
		}
		#endregion

		#region 436 数据接口 IT_ASS_UNIT625_VALRepository
		IT_ASS_UNIT625_VALRepository iT_ASS_UNIT625_VALRepository;
		public IT_ASS_UNIT625_VALRepository IT_ASS_UNIT625_VALRepository
		{
		 
			get 
			{
				if(iT_ASS_UNIT625_VALRepository==null)
					iT_ASS_UNIT625_VALRepository= new T_ASS_UNIT625_VALRepository();
				return iT_ASS_UNIT625_VALRepository;
			}
			set
			{
				iT_ASS_UNIT625_VALRepository= value;
			}
		}
		#endregion

		#region 437 数据接口 IT_ASS_UNIT625_VAL_DETAILRepository
		IT_ASS_UNIT625_VAL_DETAILRepository iT_ASS_UNIT625_VAL_DETAILRepository;
		public IT_ASS_UNIT625_VAL_DETAILRepository IT_ASS_UNIT625_VAL_DETAILRepository
		{
		 
			get 
			{
				if(iT_ASS_UNIT625_VAL_DETAILRepository==null)
					iT_ASS_UNIT625_VAL_DETAILRepository= new T_ASS_UNIT625_VAL_DETAILRepository();
				return iT_ASS_UNIT625_VAL_DETAILRepository;
			}
			set
			{
				iT_ASS_UNIT625_VAL_DETAILRepository= value;
			}
		}
		#endregion

		#region 438 数据接口 IT_BOOTRECINFORepository
		IT_BOOTRECINFORepository iT_BOOTRECINFORepository;
		public IT_BOOTRECINFORepository IT_BOOTRECINFORepository
		{
		 
			get 
			{
				if(iT_BOOTRECINFORepository==null)
					iT_BOOTRECINFORepository= new T_BOOTRECINFORepository();
				return iT_BOOTRECINFORepository;
			}
			set
			{
				iT_BOOTRECINFORepository= value;
			}
		}
		#endregion

		#region 439 数据接口 IT_CARLASTOBDRepository
		IT_CARLASTOBDRepository iT_CARLASTOBDRepository;
		public IT_CARLASTOBDRepository IT_CARLASTOBDRepository
		{
		 
			get 
			{
				if(iT_CARLASTOBDRepository==null)
					iT_CARLASTOBDRepository= new T_CARLASTOBDRepository();
				return iT_CARLASTOBDRepository;
			}
			set
			{
				iT_CARLASTOBDRepository= value;
			}
		}
		#endregion

		#region 440 数据接口 IT_CAROBDRepository
		IT_CAROBDRepository iT_CAROBDRepository;
		public IT_CAROBDRepository IT_CAROBDRepository
		{
		 
			get 
			{
				if(iT_CAROBDRepository==null)
					iT_CAROBDRepository= new T_CAROBDRepository();
				return iT_CAROBDRepository;
			}
			set
			{
				iT_CAROBDRepository= value;
			}
		}
		#endregion

		#region 441 数据接口 IT_CHK_CURVERepository
		IT_CHK_CURVERepository iT_CHK_CURVERepository;
		public IT_CHK_CURVERepository IT_CHK_CURVERepository
		{
		 
			get 
			{
				if(iT_CHK_CURVERepository==null)
					iT_CHK_CURVERepository= new T_CHK_CURVERepository();
				return iT_CHK_CURVERepository;
			}
			set
			{
				iT_CHK_CURVERepository= value;
			}
		}
		#endregion

		#region 442 数据接口 IT_CHK_CURVE_ITEMSRepository
		IT_CHK_CURVE_ITEMSRepository iT_CHK_CURVE_ITEMSRepository;
		public IT_CHK_CURVE_ITEMSRepository IT_CHK_CURVE_ITEMSRepository
		{
		 
			get 
			{
				if(iT_CHK_CURVE_ITEMSRepository==null)
					iT_CHK_CURVE_ITEMSRepository= new T_CHK_CURVE_ITEMSRepository();
				return iT_CHK_CURVE_ITEMSRepository;
			}
			set
			{
				iT_CHK_CURVE_ITEMSRepository= value;
			}
		}
		#endregion

		#region 443 数据接口 IT_CHK_DICRepository
		IT_CHK_DICRepository iT_CHK_DICRepository;
		public IT_CHK_DICRepository IT_CHK_DICRepository
		{
		 
			get 
			{
				if(iT_CHK_DICRepository==null)
					iT_CHK_DICRepository= new T_CHK_DICRepository();
				return iT_CHK_DICRepository;
			}
			set
			{
				iT_CHK_DICRepository= value;
			}
		}
		#endregion

		#region 444 数据接口 IT_CHK_DISEASE_ITEMSRepository
		IT_CHK_DISEASE_ITEMSRepository iT_CHK_DISEASE_ITEMSRepository;
		public IT_CHK_DISEASE_ITEMSRepository IT_CHK_DISEASE_ITEMSRepository
		{
		 
			get 
			{
				if(iT_CHK_DISEASE_ITEMSRepository==null)
					iT_CHK_DISEASE_ITEMSRepository= new T_CHK_DISEASE_ITEMSRepository();
				return iT_CHK_DISEASE_ITEMSRepository;
			}
			set
			{
				iT_CHK_DISEASE_ITEMSRepository= value;
			}
		}
		#endregion

		#region 445 数据接口 IT_CHK_DISEASE_STANDARDRepository
		IT_CHK_DISEASE_STANDARDRepository iT_CHK_DISEASE_STANDARDRepository;
		public IT_CHK_DISEASE_STANDARDRepository IT_CHK_DISEASE_STANDARDRepository
		{
		 
			get 
			{
				if(iT_CHK_DISEASE_STANDARDRepository==null)
					iT_CHK_DISEASE_STANDARDRepository= new T_CHK_DISEASE_STANDARDRepository();
				return iT_CHK_DISEASE_STANDARDRepository;
			}
			set
			{
				iT_CHK_DISEASE_STANDARDRepository= value;
			}
		}
		#endregion

		#region 446 数据接口 IT_CHK_LINERepository
		IT_CHK_LINERepository iT_CHK_LINERepository;
		public IT_CHK_LINERepository IT_CHK_LINERepository
		{
		 
			get 
			{
				if(iT_CHK_LINERepository==null)
					iT_CHK_LINERepository= new T_CHK_LINERepository();
				return iT_CHK_LINERepository;
			}
			set
			{
				iT_CHK_LINERepository= value;
			}
		}
		#endregion

		#region 447 数据接口 IT_CHK_LINE_ITEMSRepository
		IT_CHK_LINE_ITEMSRepository iT_CHK_LINE_ITEMSRepository;
		public IT_CHK_LINE_ITEMSRepository IT_CHK_LINE_ITEMSRepository
		{
		 
			get 
			{
				if(iT_CHK_LINE_ITEMSRepository==null)
					iT_CHK_LINE_ITEMSRepository= new T_CHK_LINE_ITEMSRepository();
				return iT_CHK_LINE_ITEMSRepository;
			}
			set
			{
				iT_CHK_LINE_ITEMSRepository= value;
			}
		}
		#endregion

		#region 448 数据接口 IT_CHK_MEDIA_ITEMSRepository
		IT_CHK_MEDIA_ITEMSRepository iT_CHK_MEDIA_ITEMSRepository;
		public IT_CHK_MEDIA_ITEMSRepository IT_CHK_MEDIA_ITEMSRepository
		{
		 
			get 
			{
				if(iT_CHK_MEDIA_ITEMSRepository==null)
					iT_CHK_MEDIA_ITEMSRepository= new T_CHK_MEDIA_ITEMSRepository();
				return iT_CHK_MEDIA_ITEMSRepository;
			}
			set
			{
				iT_CHK_MEDIA_ITEMSRepository= value;
			}
		}
		#endregion

		#region 449 数据接口 IT_CHK_TURNOUTRepository
		IT_CHK_TURNOUTRepository iT_CHK_TURNOUTRepository;
		public IT_CHK_TURNOUTRepository IT_CHK_TURNOUTRepository
		{
		 
			get 
			{
				if(iT_CHK_TURNOUTRepository==null)
					iT_CHK_TURNOUTRepository= new T_CHK_TURNOUTRepository();
				return iT_CHK_TURNOUTRepository;
			}
			set
			{
				iT_CHK_TURNOUTRepository= value;
			}
		}
		#endregion

		#region 450 数据接口 IT_CHK_TURNOUT_DIAMOND_ITEMSRepository
		IT_CHK_TURNOUT_DIAMOND_ITEMSRepository iT_CHK_TURNOUT_DIAMOND_ITEMSRepository;
		public IT_CHK_TURNOUT_DIAMOND_ITEMSRepository IT_CHK_TURNOUT_DIAMOND_ITEMSRepository
		{
		 
			get 
			{
				if(iT_CHK_TURNOUT_DIAMOND_ITEMSRepository==null)
					iT_CHK_TURNOUT_DIAMOND_ITEMSRepository= new T_CHK_TURNOUT_DIAMOND_ITEMSRepository();
				return iT_CHK_TURNOUT_DIAMOND_ITEMSRepository;
			}
			set
			{
				iT_CHK_TURNOUT_DIAMOND_ITEMSRepository= value;
			}
		}
		#endregion

		#region 451 数据接口 IT_CHK_TURNOUT_DOUBLE_ITEMSRepository
		IT_CHK_TURNOUT_DOUBLE_ITEMSRepository iT_CHK_TURNOUT_DOUBLE_ITEMSRepository;
		public IT_CHK_TURNOUT_DOUBLE_ITEMSRepository IT_CHK_TURNOUT_DOUBLE_ITEMSRepository
		{
		 
			get 
			{
				if(iT_CHK_TURNOUT_DOUBLE_ITEMSRepository==null)
					iT_CHK_TURNOUT_DOUBLE_ITEMSRepository= new T_CHK_TURNOUT_DOUBLE_ITEMSRepository();
				return iT_CHK_TURNOUT_DOUBLE_ITEMSRepository;
			}
			set
			{
				iT_CHK_TURNOUT_DOUBLE_ITEMSRepository= value;
			}
		}
		#endregion

		#region 452 数据接口 IT_CHK_TURNOUT_ITEMSRepository
		IT_CHK_TURNOUT_ITEMSRepository iT_CHK_TURNOUT_ITEMSRepository;
		public IT_CHK_TURNOUT_ITEMSRepository IT_CHK_TURNOUT_ITEMSRepository
		{
		 
			get 
			{
				if(iT_CHK_TURNOUT_ITEMSRepository==null)
					iT_CHK_TURNOUT_ITEMSRepository= new T_CHK_TURNOUT_ITEMSRepository();
				return iT_CHK_TURNOUT_ITEMSRepository;
			}
			set
			{
				iT_CHK_TURNOUT_ITEMSRepository= value;
			}
		}
		#endregion

		#region 453 数据接口 IT_CHK_TURNOUT_MOVPOINT_ITEMSRepository
		IT_CHK_TURNOUT_MOVPOINT_ITEMSRepository iT_CHK_TURNOUT_MOVPOINT_ITEMSRepository;
		public IT_CHK_TURNOUT_MOVPOINT_ITEMSRepository IT_CHK_TURNOUT_MOVPOINT_ITEMSRepository
		{
		 
			get 
			{
				if(iT_CHK_TURNOUT_MOVPOINT_ITEMSRepository==null)
					iT_CHK_TURNOUT_MOVPOINT_ITEMSRepository= new T_CHK_TURNOUT_MOVPOINT_ITEMSRepository();
				return iT_CHK_TURNOUT_MOVPOINT_ITEMSRepository;
			}
			set
			{
				iT_CHK_TURNOUT_MOVPOINT_ITEMSRepository= value;
			}
		}
		#endregion

		#region 454 数据接口 IT_CHK_TURNOUT_SLIP_ITEMSRepository
		IT_CHK_TURNOUT_SLIP_ITEMSRepository iT_CHK_TURNOUT_SLIP_ITEMSRepository;
		public IT_CHK_TURNOUT_SLIP_ITEMSRepository IT_CHK_TURNOUT_SLIP_ITEMSRepository
		{
		 
			get 
			{
				if(iT_CHK_TURNOUT_SLIP_ITEMSRepository==null)
					iT_CHK_TURNOUT_SLIP_ITEMSRepository= new T_CHK_TURNOUT_SLIP_ITEMSRepository();
				return iT_CHK_TURNOUT_SLIP_ITEMSRepository;
			}
			set
			{
				iT_CHK_TURNOUT_SLIP_ITEMSRepository= value;
			}
		}
		#endregion

		#region 455 数据接口 IT_CHK_VISCHECK_ITEMSRepository
		IT_CHK_VISCHECK_ITEMSRepository iT_CHK_VISCHECK_ITEMSRepository;
		public IT_CHK_VISCHECK_ITEMSRepository IT_CHK_VISCHECK_ITEMSRepository
		{
		 
			get 
			{
				if(iT_CHK_VISCHECK_ITEMSRepository==null)
					iT_CHK_VISCHECK_ITEMSRepository= new T_CHK_VISCHECK_ITEMSRepository();
				return iT_CHK_VISCHECK_ITEMSRepository;
			}
			set
			{
				iT_CHK_VISCHECK_ITEMSRepository= value;
			}
		}
		#endregion

		#region 456 数据接口 IT_CHK_VISUAL_ITEMSRepository
		IT_CHK_VISUAL_ITEMSRepository iT_CHK_VISUAL_ITEMSRepository;
		public IT_CHK_VISUAL_ITEMSRepository IT_CHK_VISUAL_ITEMSRepository
		{
		 
			get 
			{
				if(iT_CHK_VISUAL_ITEMSRepository==null)
					iT_CHK_VISUAL_ITEMSRepository= new T_CHK_VISUAL_ITEMSRepository();
				return iT_CHK_VISUAL_ITEMSRepository;
			}
			set
			{
				iT_CHK_VISUAL_ITEMSRepository= value;
			}
		}
		#endregion

		#region 457 数据接口 IT_CHK_WIDENING_VALUERepository
		IT_CHK_WIDENING_VALUERepository iT_CHK_WIDENING_VALUERepository;
		public IT_CHK_WIDENING_VALUERepository IT_CHK_WIDENING_VALUERepository
		{
		 
			get 
			{
				if(iT_CHK_WIDENING_VALUERepository==null)
					iT_CHK_WIDENING_VALUERepository= new T_CHK_WIDENING_VALUERepository();
				return iT_CHK_WIDENING_VALUERepository;
			}
			set
			{
				iT_CHK_WIDENING_VALUERepository= value;
			}
		}
		#endregion

		#region 458 数据接口 IT_CHKPOSRepository
		IT_CHKPOSRepository iT_CHKPOSRepository;
		public IT_CHKPOSRepository IT_CHKPOSRepository
		{
		 
			get 
			{
				if(iT_CHKPOSRepository==null)
					iT_CHKPOSRepository= new T_CHKPOSRepository();
				return iT_CHKPOSRepository;
			}
			set
			{
				iT_CHKPOSRepository= value;
			}
		}
		#endregion

		#region 459 数据接口 IT_CUSTOM_STATIONRepository
		IT_CUSTOM_STATIONRepository iT_CUSTOM_STATIONRepository;
		public IT_CUSTOM_STATIONRepository IT_CUSTOM_STATIONRepository
		{
		 
			get 
			{
				if(iT_CUSTOM_STATIONRepository==null)
					iT_CUSTOM_STATIONRepository= new T_CUSTOM_STATIONRepository();
				return iT_CUSTOM_STATIONRepository;
			}
			set
			{
				iT_CUSTOM_STATIONRepository= value;
			}
		}
		#endregion

		#region 460 数据接口 IT_CZ_CCRepository
		IT_CZ_CCRepository iT_CZ_CCRepository;
		public IT_CZ_CCRepository IT_CZ_CCRepository
		{
		 
			get 
			{
				if(iT_CZ_CCRepository==null)
					iT_CZ_CCRepository= new T_CZ_CCRepository();
				return iT_CZ_CCRepository;
			}
			set
			{
				iT_CZ_CCRepository= value;
			}
		}
		#endregion

		#region 461 数据接口 IT_CZ_FREQ_TEMPRepository
		IT_CZ_FREQ_TEMPRepository iT_CZ_FREQ_TEMPRepository;
		public IT_CZ_FREQ_TEMPRepository IT_CZ_FREQ_TEMPRepository
		{
		 
			get 
			{
				if(iT_CZ_FREQ_TEMPRepository==null)
					iT_CZ_FREQ_TEMPRepository= new T_CZ_FREQ_TEMPRepository();
				return iT_CZ_FREQ_TEMPRepository;
			}
			set
			{
				iT_CZ_FREQ_TEMPRepository= value;
			}
		}
		#endregion

		#region 462 数据接口 IT_CZ_GJRepository
		IT_CZ_GJRepository iT_CZ_GJRepository;
		public IT_CZ_GJRepository IT_CZ_GJRepository
		{
		 
			get 
			{
				if(iT_CZ_GJRepository==null)
					iT_CZ_GJRepository= new T_CZ_GJRepository();
				return iT_CZ_GJRepository;
			}
			set
			{
				iT_CZ_GJRepository= value;
			}
		}
		#endregion

		#region 463 数据接口 IT_CZ_JCHRepository
		IT_CZ_JCHRepository iT_CZ_JCHRepository;
		public IT_CZ_JCHRepository IT_CZ_JCHRepository
		{
		 
			get 
			{
				if(iT_CZ_JCHRepository==null)
					iT_CZ_JCHRepository= new T_CZ_JCHRepository();
				return iT_CZ_JCHRepository;
			}
			set
			{
				iT_CZ_JCHRepository= value;
			}
		}
		#endregion

		#region 464 数据接口 IT_CZ_NLINENORepository
		IT_CZ_NLINENORepository iT_CZ_NLINENORepository;
		public IT_CZ_NLINENORepository IT_CZ_NLINENORepository
		{
		 
			get 
			{
				if(iT_CZ_NLINENORepository==null)
					iT_CZ_NLINENORepository= new T_CZ_NLINENORepository();
				return iT_CZ_NLINENORepository;
			}
			set
			{
				iT_CZ_NLINENORepository= value;
			}
		}
		#endregion

		#region 465 数据接口 IT_CZ_PHONERepository
		IT_CZ_PHONERepository iT_CZ_PHONERepository;
		public IT_CZ_PHONERepository IT_CZ_PHONERepository
		{
		 
			get 
			{
				if(iT_CZ_PHONERepository==null)
					iT_CZ_PHONERepository= new T_CZ_PHONERepository();
				return iT_CZ_PHONERepository;
			}
			set
			{
				iT_CZ_PHONERepository= value;
			}
		}
		#endregion

		#region 466 数据接口 IT_CZ_TBLRepository
		IT_CZ_TBLRepository iT_CZ_TBLRepository;
		public IT_CZ_TBLRepository IT_CZ_TBLRepository
		{
		 
			get 
			{
				if(iT_CZ_TBLRepository==null)
					iT_CZ_TBLRepository= new T_CZ_TBLRepository();
				return iT_CZ_TBLRepository;
			}
			set
			{
				iT_CZ_TBLRepository= value;
			}
		}
		#endregion

		#region 467 数据接口 IT_CZ_TDWID_TEMPRepository
		IT_CZ_TDWID_TEMPRepository iT_CZ_TDWID_TEMPRepository;
		public IT_CZ_TDWID_TEMPRepository IT_CZ_TDWID_TEMPRepository
		{
		 
			get 
			{
				if(iT_CZ_TDWID_TEMPRepository==null)
					iT_CZ_TDWID_TEMPRepository= new T_CZ_TDWID_TEMPRepository();
				return iT_CZ_TDWID_TEMPRepository;
			}
			set
			{
				iT_CZ_TDWID_TEMPRepository= value;
			}
		}
		#endregion

		#region 468 数据接口 IT_CZ_TJ_TEMPRepository
		IT_CZ_TJ_TEMPRepository iT_CZ_TJ_TEMPRepository;
		public IT_CZ_TJ_TEMPRepository IT_CZ_TJ_TEMPRepository
		{
		 
			get 
			{
				if(iT_CZ_TJ_TEMPRepository==null)
					iT_CZ_TJ_TEMPRepository= new T_CZ_TJ_TEMPRepository();
				return iT_CZ_TJ_TEMPRepository;
			}
			set
			{
				iT_CZ_TJ_TEMPRepository= value;
			}
		}
		#endregion

		#region 469 数据接口 IT_CZ_WARPRepository
		IT_CZ_WARPRepository iT_CZ_WARPRepository;
		public IT_CZ_WARPRepository IT_CZ_WARPRepository
		{
		 
			get 
			{
				if(iT_CZ_WARPRepository==null)
					iT_CZ_WARPRepository= new T_CZ_WARPRepository();
				return iT_CZ_WARPRepository;
			}
			set
			{
				iT_CZ_WARPRepository= value;
			}
		}
		#endregion

		#region 470 数据接口 IT_CZ_WARP_TEMPRepository
		IT_CZ_WARP_TEMPRepository iT_CZ_WARP_TEMPRepository;
		public IT_CZ_WARP_TEMPRepository IT_CZ_WARP_TEMPRepository
		{
		 
			get 
			{
				if(iT_CZ_WARP_TEMPRepository==null)
					iT_CZ_WARP_TEMPRepository= new T_CZ_WARP_TEMPRepository();
				return iT_CZ_WARP_TEMPRepository;
			}
			set
			{
				iT_CZ_WARP_TEMPRepository= value;
			}
		}
		#endregion

		#region 471 数据接口 IT_GIS_LINERepository
		IT_GIS_LINERepository iT_GIS_LINERepository;
		public IT_GIS_LINERepository IT_GIS_LINERepository
		{
		 
			get 
			{
				if(iT_GIS_LINERepository==null)
					iT_GIS_LINERepository= new T_GIS_LINERepository();
				return iT_GIS_LINERepository;
			}
			set
			{
				iT_GIS_LINERepository= value;
			}
		}
		#endregion

		#region 472 数据接口 IT_GIS_LINE_TESTRepository
		IT_GIS_LINE_TESTRepository iT_GIS_LINE_TESTRepository;
		public IT_GIS_LINE_TESTRepository IT_GIS_LINE_TESTRepository
		{
		 
			get 
			{
				if(iT_GIS_LINE_TESTRepository==null)
					iT_GIS_LINE_TESTRepository= new T_GIS_LINE_TESTRepository();
				return iT_GIS_LINE_TESTRepository;
			}
			set
			{
				iT_GIS_LINE_TESTRepository= value;
			}
		}
		#endregion

		#region 473 数据接口 IT_GIS_LINE_TEST_NOPWDRepository
		IT_GIS_LINE_TEST_NOPWDRepository iT_GIS_LINE_TEST_NOPWDRepository;
		public IT_GIS_LINE_TEST_NOPWDRepository IT_GIS_LINE_TEST_NOPWDRepository
		{
		 
			get 
			{
				if(iT_GIS_LINE_TEST_NOPWDRepository==null)
					iT_GIS_LINE_TEST_NOPWDRepository= new T_GIS_LINE_TEST_NOPWDRepository();
				return iT_GIS_LINE_TEST_NOPWDRepository;
			}
			set
			{
				iT_GIS_LINE_TEST_NOPWDRepository= value;
			}
		}
		#endregion

		#region 474 数据接口 IT_GIS_STATIONRepository
		IT_GIS_STATIONRepository iT_GIS_STATIONRepository;
		public IT_GIS_STATIONRepository IT_GIS_STATIONRepository
		{
		 
			get 
			{
				if(iT_GIS_STATIONRepository==null)
					iT_GIS_STATIONRepository= new T_GIS_STATIONRepository();
				return iT_GIS_STATIONRepository;
			}
			set
			{
				iT_GIS_STATIONRepository= value;
			}
		}
		#endregion

		#region 475 数据接口 IT_GIS_STATION_TESTRepository
		IT_GIS_STATION_TESTRepository iT_GIS_STATION_TESTRepository;
		public IT_GIS_STATION_TESTRepository IT_GIS_STATION_TESTRepository
		{
		 
			get 
			{
				if(iT_GIS_STATION_TESTRepository==null)
					iT_GIS_STATION_TESTRepository= new T_GIS_STATION_TESTRepository();
				return iT_GIS_STATION_TESTRepository;
			}
			set
			{
				iT_GIS_STATION_TESTRepository= value;
			}
		}
		#endregion

		#region 476 数据接口 IT_GWBASERepository
		IT_GWBASERepository iT_GWBASERepository;
		public IT_GWBASERepository IT_GWBASERepository
		{
		 
			get 
			{
				if(iT_GWBASERepository==null)
					iT_GWBASERepository= new T_GWBASERepository();
				return iT_GWBASERepository;
			}
			set
			{
				iT_GWBASERepository= value;
			}
		}
		#endregion

		#region 477 数据接口 IT_GWBASE_SECTION_LINERepository
		IT_GWBASE_SECTION_LINERepository iT_GWBASE_SECTION_LINERepository;
		public IT_GWBASE_SECTION_LINERepository IT_GWBASE_SECTION_LINERepository
		{
		 
			get 
			{
				if(iT_GWBASE_SECTION_LINERepository==null)
					iT_GWBASE_SECTION_LINERepository= new T_GWBASE_SECTION_LINERepository();
				return iT_GWBASE_SECTION_LINERepository;
			}
			set
			{
				iT_GWBASE_SECTION_LINERepository= value;
			}
		}
		#endregion

		#region 478 数据接口 IT_GWBASE_TESTRepository
		IT_GWBASE_TESTRepository iT_GWBASE_TESTRepository;
		public IT_GWBASE_TESTRepository IT_GWBASE_TESTRepository
		{
		 
			get 
			{
				if(iT_GWBASE_TESTRepository==null)
					iT_GWBASE_TESTRepository= new T_GWBASE_TESTRepository();
				return iT_GWBASE_TESTRepository;
			}
			set
			{
				iT_GWBASE_TESTRepository= value;
			}
		}
		#endregion

		#region 479 数据接口 IT_GWDETAILRepository
		IT_GWDETAILRepository iT_GWDETAILRepository;
		public IT_GWDETAILRepository IT_GWDETAILRepository
		{
		 
			get 
			{
				if(iT_GWDETAILRepository==null)
					iT_GWDETAILRepository= new T_GWDETAILRepository();
				return iT_GWDETAILRepository;
			}
			set
			{
				iT_GWDETAILRepository= value;
			}
		}
		#endregion

		#region 480 数据接口 IT_GWTRANSETRepository
		IT_GWTRANSETRepository iT_GWTRANSETRepository;
		public IT_GWTRANSETRepository IT_GWTRANSETRepository
		{
		 
			get 
			{
				if(iT_GWTRANSETRepository==null)
					iT_GWTRANSETRepository= new T_GWTRANSETRepository();
				return iT_GWTRANSETRepository;
			}
			set
			{
				iT_GWTRANSETRepository= value;
			}
		}
		#endregion

		#region 481 数据接口 IT_JOB_LINERepository
		IT_JOB_LINERepository iT_JOB_LINERepository;
		public IT_JOB_LINERepository IT_JOB_LINERepository
		{
		 
			get 
			{
				if(iT_JOB_LINERepository==null)
					iT_JOB_LINERepository= new T_JOB_LINERepository();
				return iT_JOB_LINERepository;
			}
			set
			{
				iT_JOB_LINERepository= value;
			}
		}
		#endregion

		#region 482 数据接口 IT_LKJ_FLOW_ATTACHRepository
		IT_LKJ_FLOW_ATTACHRepository iT_LKJ_FLOW_ATTACHRepository;
		public IT_LKJ_FLOW_ATTACHRepository IT_LKJ_FLOW_ATTACHRepository
		{
		 
			get 
			{
				if(iT_LKJ_FLOW_ATTACHRepository==null)
					iT_LKJ_FLOW_ATTACHRepository= new T_LKJ_FLOW_ATTACHRepository();
				return iT_LKJ_FLOW_ATTACHRepository;
			}
			set
			{
				iT_LKJ_FLOW_ATTACHRepository= value;
			}
		}
		#endregion

		#region 483 数据接口 IT_LKJ_FLOW_DOCRepository
		IT_LKJ_FLOW_DOCRepository iT_LKJ_FLOW_DOCRepository;
		public IT_LKJ_FLOW_DOCRepository IT_LKJ_FLOW_DOCRepository
		{
		 
			get 
			{
				if(iT_LKJ_FLOW_DOCRepository==null)
					iT_LKJ_FLOW_DOCRepository= new T_LKJ_FLOW_DOCRepository();
				return iT_LKJ_FLOW_DOCRepository;
			}
			set
			{
				iT_LKJ_FLOW_DOCRepository= value;
			}
		}
		#endregion

		#region 484 数据接口 IT_LKJ_FLOW_FEEDBACKRepository
		IT_LKJ_FLOW_FEEDBACKRepository iT_LKJ_FLOW_FEEDBACKRepository;
		public IT_LKJ_FLOW_FEEDBACKRepository IT_LKJ_FLOW_FEEDBACKRepository
		{
		 
			get 
			{
				if(iT_LKJ_FLOW_FEEDBACKRepository==null)
					iT_LKJ_FLOW_FEEDBACKRepository= new T_LKJ_FLOW_FEEDBACKRepository();
				return iT_LKJ_FLOW_FEEDBACKRepository;
			}
			set
			{
				iT_LKJ_FLOW_FEEDBACKRepository= value;
			}
		}
		#endregion

		#region 485 数据接口 IT_LKJ_FLOW_INFORepository
		IT_LKJ_FLOW_INFORepository iT_LKJ_FLOW_INFORepository;
		public IT_LKJ_FLOW_INFORepository IT_LKJ_FLOW_INFORepository
		{
		 
			get 
			{
				if(iT_LKJ_FLOW_INFORepository==null)
					iT_LKJ_FLOW_INFORepository= new T_LKJ_FLOW_INFORepository();
				return iT_LKJ_FLOW_INFORepository;
			}
			set
			{
				iT_LKJ_FLOW_INFORepository= value;
			}
		}
		#endregion

		#region 486 数据接口 IT_LKJ_FLOW_MESSAGERepository
		IT_LKJ_FLOW_MESSAGERepository iT_LKJ_FLOW_MESSAGERepository;
		public IT_LKJ_FLOW_MESSAGERepository IT_LKJ_FLOW_MESSAGERepository
		{
		 
			get 
			{
				if(iT_LKJ_FLOW_MESSAGERepository==null)
					iT_LKJ_FLOW_MESSAGERepository= new T_LKJ_FLOW_MESSAGERepository();
				return iT_LKJ_FLOW_MESSAGERepository;
			}
			set
			{
				iT_LKJ_FLOW_MESSAGERepository= value;
			}
		}
		#endregion

		#region 487 数据接口 IT_LKJ_FLOW_REFERENCERepository
		IT_LKJ_FLOW_REFERENCERepository iT_LKJ_FLOW_REFERENCERepository;
		public IT_LKJ_FLOW_REFERENCERepository IT_LKJ_FLOW_REFERENCERepository
		{
		 
			get 
			{
				if(iT_LKJ_FLOW_REFERENCERepository==null)
					iT_LKJ_FLOW_REFERENCERepository= new T_LKJ_FLOW_REFERENCERepository();
				return iT_LKJ_FLOW_REFERENCERepository;
			}
			set
			{
				iT_LKJ_FLOW_REFERENCERepository= value;
			}
		}
		#endregion

		#region 488 数据接口 IT_LKJ_FLOW_ROLERepository
		IT_LKJ_FLOW_ROLERepository iT_LKJ_FLOW_ROLERepository;
		public IT_LKJ_FLOW_ROLERepository IT_LKJ_FLOW_ROLERepository
		{
		 
			get 
			{
				if(iT_LKJ_FLOW_ROLERepository==null)
					iT_LKJ_FLOW_ROLERepository= new T_LKJ_FLOW_ROLERepository();
				return iT_LKJ_FLOW_ROLERepository;
			}
			set
			{
				iT_LKJ_FLOW_ROLERepository= value;
			}
		}
		#endregion

		#region 489 数据接口 IT_LKJ_FLOW_STEPINFORepository
		IT_LKJ_FLOW_STEPINFORepository iT_LKJ_FLOW_STEPINFORepository;
		public IT_LKJ_FLOW_STEPINFORepository IT_LKJ_FLOW_STEPINFORepository
		{
		 
			get 
			{
				if(iT_LKJ_FLOW_STEPINFORepository==null)
					iT_LKJ_FLOW_STEPINFORepository= new T_LKJ_FLOW_STEPINFORepository();
				return iT_LKJ_FLOW_STEPINFORepository;
			}
			set
			{
				iT_LKJ_FLOW_STEPINFORepository= value;
			}
		}
		#endregion

		#region 490 数据接口 IT_LKJ_FLOW_USERROLERepository
		IT_LKJ_FLOW_USERROLERepository iT_LKJ_FLOW_USERROLERepository;
		public IT_LKJ_FLOW_USERROLERepository IT_LKJ_FLOW_USERROLERepository
		{
		 
			get 
			{
				if(iT_LKJ_FLOW_USERROLERepository==null)
					iT_LKJ_FLOW_USERROLERepository= new T_LKJ_FLOW_USERROLERepository();
				return iT_LKJ_FLOW_USERROLERepository;
			}
			set
			{
				iT_LKJ_FLOW_USERROLERepository= value;
			}
		}
		#endregion

		#region 491 数据接口 IT_LKJ_LINESTATIONRepository
		IT_LKJ_LINESTATIONRepository iT_LKJ_LINESTATIONRepository;
		public IT_LKJ_LINESTATIONRepository IT_LKJ_LINESTATIONRepository
		{
		 
			get 
			{
				if(iT_LKJ_LINESTATIONRepository==null)
					iT_LKJ_LINESTATIONRepository= new T_LKJ_LINESTATIONRepository();
				return iT_LKJ_LINESTATIONRepository;
			}
			set
			{
				iT_LKJ_LINESTATIONRepository= value;
			}
		}
		#endregion

		#region 492 数据接口 IT_LKJ_ROLEFLOWRepository
		IT_LKJ_ROLEFLOWRepository iT_LKJ_ROLEFLOWRepository;
		public IT_LKJ_ROLEFLOWRepository IT_LKJ_ROLEFLOWRepository
		{
		 
			get 
			{
				if(iT_LKJ_ROLEFLOWRepository==null)
					iT_LKJ_ROLEFLOWRepository= new T_LKJ_ROLEFLOWRepository();
				return iT_LKJ_ROLEFLOWRepository;
			}
			set
			{
				iT_LKJ_ROLEFLOWRepository= value;
			}
		}
		#endregion

		#region 493 数据接口 IT_LKJ_S1Repository
		IT_LKJ_S1Repository iT_LKJ_S1Repository;
		public IT_LKJ_S1Repository IT_LKJ_S1Repository
		{
		 
			get 
			{
				if(iT_LKJ_S1Repository==null)
					iT_LKJ_S1Repository= new T_LKJ_S1Repository();
				return iT_LKJ_S1Repository;
			}
			set
			{
				iT_LKJ_S1Repository= value;
			}
		}
		#endregion

		#region 494 数据接口 IT_LKJ_S1_HISRepository
		IT_LKJ_S1_HISRepository iT_LKJ_S1_HISRepository;
		public IT_LKJ_S1_HISRepository IT_LKJ_S1_HISRepository
		{
		 
			get 
			{
				if(iT_LKJ_S1_HISRepository==null)
					iT_LKJ_S1_HISRepository= new T_LKJ_S1_HISRepository();
				return iT_LKJ_S1_HISRepository;
			}
			set
			{
				iT_LKJ_S1_HISRepository= value;
			}
		}
		#endregion

		#region 495 数据接口 IT_LKJ_S10Repository
		IT_LKJ_S10Repository iT_LKJ_S10Repository;
		public IT_LKJ_S10Repository IT_LKJ_S10Repository
		{
		 
			get 
			{
				if(iT_LKJ_S10Repository==null)
					iT_LKJ_S10Repository= new T_LKJ_S10Repository();
				return iT_LKJ_S10Repository;
			}
			set
			{
				iT_LKJ_S10Repository= value;
			}
		}
		#endregion

		#region 496 数据接口 IT_LKJ_S10_HISRepository
		IT_LKJ_S10_HISRepository iT_LKJ_S10_HISRepository;
		public IT_LKJ_S10_HISRepository IT_LKJ_S10_HISRepository
		{
		 
			get 
			{
				if(iT_LKJ_S10_HISRepository==null)
					iT_LKJ_S10_HISRepository= new T_LKJ_S10_HISRepository();
				return iT_LKJ_S10_HISRepository;
			}
			set
			{
				iT_LKJ_S10_HISRepository= value;
			}
		}
		#endregion

		#region 497 数据接口 IT_LKJ_S11Repository
		IT_LKJ_S11Repository iT_LKJ_S11Repository;
		public IT_LKJ_S11Repository IT_LKJ_S11Repository
		{
		 
			get 
			{
				if(iT_LKJ_S11Repository==null)
					iT_LKJ_S11Repository= new T_LKJ_S11Repository();
				return iT_LKJ_S11Repository;
			}
			set
			{
				iT_LKJ_S11Repository= value;
			}
		}
		#endregion

		#region 498 数据接口 IT_LKJ_S11_HISRepository
		IT_LKJ_S11_HISRepository iT_LKJ_S11_HISRepository;
		public IT_LKJ_S11_HISRepository IT_LKJ_S11_HISRepository
		{
		 
			get 
			{
				if(iT_LKJ_S11_HISRepository==null)
					iT_LKJ_S11_HISRepository= new T_LKJ_S11_HISRepository();
				return iT_LKJ_S11_HISRepository;
			}
			set
			{
				iT_LKJ_S11_HISRepository= value;
			}
		}
		#endregion

		#region 499 数据接口 IT_LKJ_S12Repository
		IT_LKJ_S12Repository iT_LKJ_S12Repository;
		public IT_LKJ_S12Repository IT_LKJ_S12Repository
		{
		 
			get 
			{
				if(iT_LKJ_S12Repository==null)
					iT_LKJ_S12Repository= new T_LKJ_S12Repository();
				return iT_LKJ_S12Repository;
			}
			set
			{
				iT_LKJ_S12Repository= value;
			}
		}
		#endregion

		#region 500 数据接口 IT_LKJ_S12_HISRepository
		IT_LKJ_S12_HISRepository iT_LKJ_S12_HISRepository;
		public IT_LKJ_S12_HISRepository IT_LKJ_S12_HISRepository
		{
		 
			get 
			{
				if(iT_LKJ_S12_HISRepository==null)
					iT_LKJ_S12_HISRepository= new T_LKJ_S12_HISRepository();
				return iT_LKJ_S12_HISRepository;
			}
			set
			{
				iT_LKJ_S12_HISRepository= value;
			}
		}
		#endregion

		#region 501 数据接口 IT_LKJ_S13Repository
		IT_LKJ_S13Repository iT_LKJ_S13Repository;
		public IT_LKJ_S13Repository IT_LKJ_S13Repository
		{
		 
			get 
			{
				if(iT_LKJ_S13Repository==null)
					iT_LKJ_S13Repository= new T_LKJ_S13Repository();
				return iT_LKJ_S13Repository;
			}
			set
			{
				iT_LKJ_S13Repository= value;
			}
		}
		#endregion

		#region 502 数据接口 IT_LKJ_S13_HISRepository
		IT_LKJ_S13_HISRepository iT_LKJ_S13_HISRepository;
		public IT_LKJ_S13_HISRepository IT_LKJ_S13_HISRepository
		{
		 
			get 
			{
				if(iT_LKJ_S13_HISRepository==null)
					iT_LKJ_S13_HISRepository= new T_LKJ_S13_HISRepository();
				return iT_LKJ_S13_HISRepository;
			}
			set
			{
				iT_LKJ_S13_HISRepository= value;
			}
		}
		#endregion

		#region 503 数据接口 IT_LKJ_S2Repository
		IT_LKJ_S2Repository iT_LKJ_S2Repository;
		public IT_LKJ_S2Repository IT_LKJ_S2Repository
		{
		 
			get 
			{
				if(iT_LKJ_S2Repository==null)
					iT_LKJ_S2Repository= new T_LKJ_S2Repository();
				return iT_LKJ_S2Repository;
			}
			set
			{
				iT_LKJ_S2Repository= value;
			}
		}
		#endregion

		#region 504 数据接口 IT_LKJ_S2_HISRepository
		IT_LKJ_S2_HISRepository iT_LKJ_S2_HISRepository;
		public IT_LKJ_S2_HISRepository IT_LKJ_S2_HISRepository
		{
		 
			get 
			{
				if(iT_LKJ_S2_HISRepository==null)
					iT_LKJ_S2_HISRepository= new T_LKJ_S2_HISRepository();
				return iT_LKJ_S2_HISRepository;
			}
			set
			{
				iT_LKJ_S2_HISRepository= value;
			}
		}
		#endregion

		#region 505 数据接口 IT_LKJ_S3Repository
		IT_LKJ_S3Repository iT_LKJ_S3Repository;
		public IT_LKJ_S3Repository IT_LKJ_S3Repository
		{
		 
			get 
			{
				if(iT_LKJ_S3Repository==null)
					iT_LKJ_S3Repository= new T_LKJ_S3Repository();
				return iT_LKJ_S3Repository;
			}
			set
			{
				iT_LKJ_S3Repository= value;
			}
		}
		#endregion

		#region 506 数据接口 IT_LKJ_S3_HISRepository
		IT_LKJ_S3_HISRepository iT_LKJ_S3_HISRepository;
		public IT_LKJ_S3_HISRepository IT_LKJ_S3_HISRepository
		{
		 
			get 
			{
				if(iT_LKJ_S3_HISRepository==null)
					iT_LKJ_S3_HISRepository= new T_LKJ_S3_HISRepository();
				return iT_LKJ_S3_HISRepository;
			}
			set
			{
				iT_LKJ_S3_HISRepository= value;
			}
		}
		#endregion

		#region 507 数据接口 IT_LKJ_S4Repository
		IT_LKJ_S4Repository iT_LKJ_S4Repository;
		public IT_LKJ_S4Repository IT_LKJ_S4Repository
		{
		 
			get 
			{
				if(iT_LKJ_S4Repository==null)
					iT_LKJ_S4Repository= new T_LKJ_S4Repository();
				return iT_LKJ_S4Repository;
			}
			set
			{
				iT_LKJ_S4Repository= value;
			}
		}
		#endregion

		#region 508 数据接口 IT_LKJ_S4_HISRepository
		IT_LKJ_S4_HISRepository iT_LKJ_S4_HISRepository;
		public IT_LKJ_S4_HISRepository IT_LKJ_S4_HISRepository
		{
		 
			get 
			{
				if(iT_LKJ_S4_HISRepository==null)
					iT_LKJ_S4_HISRepository= new T_LKJ_S4_HISRepository();
				return iT_LKJ_S4_HISRepository;
			}
			set
			{
				iT_LKJ_S4_HISRepository= value;
			}
		}
		#endregion

		#region 509 数据接口 IT_LKJ_S5Repository
		IT_LKJ_S5Repository iT_LKJ_S5Repository;
		public IT_LKJ_S5Repository IT_LKJ_S5Repository
		{
		 
			get 
			{
				if(iT_LKJ_S5Repository==null)
					iT_LKJ_S5Repository= new T_LKJ_S5Repository();
				return iT_LKJ_S5Repository;
			}
			set
			{
				iT_LKJ_S5Repository= value;
			}
		}
		#endregion

		#region 510 数据接口 IT_LKJ_S5_HISRepository
		IT_LKJ_S5_HISRepository iT_LKJ_S5_HISRepository;
		public IT_LKJ_S5_HISRepository IT_LKJ_S5_HISRepository
		{
		 
			get 
			{
				if(iT_LKJ_S5_HISRepository==null)
					iT_LKJ_S5_HISRepository= new T_LKJ_S5_HISRepository();
				return iT_LKJ_S5_HISRepository;
			}
			set
			{
				iT_LKJ_S5_HISRepository= value;
			}
		}
		#endregion

		#region 511 数据接口 IT_LKJ_S6Repository
		IT_LKJ_S6Repository iT_LKJ_S6Repository;
		public IT_LKJ_S6Repository IT_LKJ_S6Repository
		{
		 
			get 
			{
				if(iT_LKJ_S6Repository==null)
					iT_LKJ_S6Repository= new T_LKJ_S6Repository();
				return iT_LKJ_S6Repository;
			}
			set
			{
				iT_LKJ_S6Repository= value;
			}
		}
		#endregion

		#region 512 数据接口 IT_LKJ_S6_HISRepository
		IT_LKJ_S6_HISRepository iT_LKJ_S6_HISRepository;
		public IT_LKJ_S6_HISRepository IT_LKJ_S6_HISRepository
		{
		 
			get 
			{
				if(iT_LKJ_S6_HISRepository==null)
					iT_LKJ_S6_HISRepository= new T_LKJ_S6_HISRepository();
				return iT_LKJ_S6_HISRepository;
			}
			set
			{
				iT_LKJ_S6_HISRepository= value;
			}
		}
		#endregion

		#region 513 数据接口 IT_LKJ_S7Repository
		IT_LKJ_S7Repository iT_LKJ_S7Repository;
		public IT_LKJ_S7Repository IT_LKJ_S7Repository
		{
		 
			get 
			{
				if(iT_LKJ_S7Repository==null)
					iT_LKJ_S7Repository= new T_LKJ_S7Repository();
				return iT_LKJ_S7Repository;
			}
			set
			{
				iT_LKJ_S7Repository= value;
			}
		}
		#endregion

		#region 514 数据接口 IT_LKJ_S7_HISRepository
		IT_LKJ_S7_HISRepository iT_LKJ_S7_HISRepository;
		public IT_LKJ_S7_HISRepository IT_LKJ_S7_HISRepository
		{
		 
			get 
			{
				if(iT_LKJ_S7_HISRepository==null)
					iT_LKJ_S7_HISRepository= new T_LKJ_S7_HISRepository();
				return iT_LKJ_S7_HISRepository;
			}
			set
			{
				iT_LKJ_S7_HISRepository= value;
			}
		}
		#endregion

		#region 515 数据接口 IT_LKJ_S8Repository
		IT_LKJ_S8Repository iT_LKJ_S8Repository;
		public IT_LKJ_S8Repository IT_LKJ_S8Repository
		{
		 
			get 
			{
				if(iT_LKJ_S8Repository==null)
					iT_LKJ_S8Repository= new T_LKJ_S8Repository();
				return iT_LKJ_S8Repository;
			}
			set
			{
				iT_LKJ_S8Repository= value;
			}
		}
		#endregion

		#region 516 数据接口 IT_LKJ_S8_HISRepository
		IT_LKJ_S8_HISRepository iT_LKJ_S8_HISRepository;
		public IT_LKJ_S8_HISRepository IT_LKJ_S8_HISRepository
		{
		 
			get 
			{
				if(iT_LKJ_S8_HISRepository==null)
					iT_LKJ_S8_HISRepository= new T_LKJ_S8_HISRepository();
				return iT_LKJ_S8_HISRepository;
			}
			set
			{
				iT_LKJ_S8_HISRepository= value;
			}
		}
		#endregion

		#region 517 数据接口 IT_LKJ_S9Repository
		IT_LKJ_S9Repository iT_LKJ_S9Repository;
		public IT_LKJ_S9Repository IT_LKJ_S9Repository
		{
		 
			get 
			{
				if(iT_LKJ_S9Repository==null)
					iT_LKJ_S9Repository= new T_LKJ_S9Repository();
				return iT_LKJ_S9Repository;
			}
			set
			{
				iT_LKJ_S9Repository= value;
			}
		}
		#endregion

		#region 518 数据接口 IT_LKJ_S9_HISRepository
		IT_LKJ_S9_HISRepository iT_LKJ_S9_HISRepository;
		public IT_LKJ_S9_HISRepository IT_LKJ_S9_HISRepository
		{
		 
			get 
			{
				if(iT_LKJ_S9_HISRepository==null)
					iT_LKJ_S9_HISRepository= new T_LKJ_S9_HISRepository();
				return iT_LKJ_S9_HISRepository;
			}
			set
			{
				iT_LKJ_S9_HISRepository= value;
			}
		}
		#endregion

		#region 519 数据接口 IT_LKJ_ST1Repository
		IT_LKJ_ST1Repository iT_LKJ_ST1Repository;
		public IT_LKJ_ST1Repository IT_LKJ_ST1Repository
		{
		 
			get 
			{
				if(iT_LKJ_ST1Repository==null)
					iT_LKJ_ST1Repository= new T_LKJ_ST1Repository();
				return iT_LKJ_ST1Repository;
			}
			set
			{
				iT_LKJ_ST1Repository= value;
			}
		}
		#endregion

		#region 520 数据接口 IT_LKJ_ST1_HISRepository
		IT_LKJ_ST1_HISRepository iT_LKJ_ST1_HISRepository;
		public IT_LKJ_ST1_HISRepository IT_LKJ_ST1_HISRepository
		{
		 
			get 
			{
				if(iT_LKJ_ST1_HISRepository==null)
					iT_LKJ_ST1_HISRepository= new T_LKJ_ST1_HISRepository();
				return iT_LKJ_ST1_HISRepository;
			}
			set
			{
				iT_LKJ_ST1_HISRepository= value;
			}
		}
		#endregion

		#region 521 数据接口 IT_LKJ_STARELTIONRepository
		IT_LKJ_STARELTIONRepository iT_LKJ_STARELTIONRepository;
		public IT_LKJ_STARELTIONRepository IT_LKJ_STARELTIONRepository
		{
		 
			get 
			{
				if(iT_LKJ_STARELTIONRepository==null)
					iT_LKJ_STARELTIONRepository= new T_LKJ_STARELTIONRepository();
				return iT_LKJ_STARELTIONRepository;
			}
			set
			{
				iT_LKJ_STARELTIONRepository= value;
			}
		}
		#endregion

		#region 522 数据接口 IT_LKJ_SYSTABLERepository
		IT_LKJ_SYSTABLERepository iT_LKJ_SYSTABLERepository;
		public IT_LKJ_SYSTABLERepository IT_LKJ_SYSTABLERepository
		{
		 
			get 
			{
				if(iT_LKJ_SYSTABLERepository==null)
					iT_LKJ_SYSTABLERepository= new T_LKJ_SYSTABLERepository();
				return iT_LKJ_SYSTABLERepository;
			}
			set
			{
				iT_LKJ_SYSTABLERepository= value;
			}
		}
		#endregion

		#region 523 数据接口 IT_LKJ_VERSIONNUMRepository
		IT_LKJ_VERSIONNUMRepository iT_LKJ_VERSIONNUMRepository;
		public IT_LKJ_VERSIONNUMRepository IT_LKJ_VERSIONNUMRepository
		{
		 
			get 
			{
				if(iT_LKJ_VERSIONNUMRepository==null)
					iT_LKJ_VERSIONNUMRepository= new T_LKJ_VERSIONNUMRepository();
				return iT_LKJ_VERSIONNUMRepository;
			}
			set
			{
				iT_LKJ_VERSIONNUMRepository= value;
			}
		}
		#endregion

		#region 524 数据接口 IT_LKJ_WIRINGDIAGRAMRepository
		IT_LKJ_WIRINGDIAGRAMRepository iT_LKJ_WIRINGDIAGRAMRepository;
		public IT_LKJ_WIRINGDIAGRAMRepository IT_LKJ_WIRINGDIAGRAMRepository
		{
		 
			get 
			{
				if(iT_LKJ_WIRINGDIAGRAMRepository==null)
					iT_LKJ_WIRINGDIAGRAMRepository= new T_LKJ_WIRINGDIAGRAMRepository();
				return iT_LKJ_WIRINGDIAGRAMRepository;
			}
			set
			{
				iT_LKJ_WIRINGDIAGRAMRepository= value;
			}
		}
		#endregion

		#region 525 数据接口 IT_LKJ_WORKPROCESSRepository
		IT_LKJ_WORKPROCESSRepository iT_LKJ_WORKPROCESSRepository;
		public IT_LKJ_WORKPROCESSRepository IT_LKJ_WORKPROCESSRepository
		{
		 
			get 
			{
				if(iT_LKJ_WORKPROCESSRepository==null)
					iT_LKJ_WORKPROCESSRepository= new T_LKJ_WORKPROCESSRepository();
				return iT_LKJ_WORKPROCESSRepository;
			}
			set
			{
				iT_LKJ_WORKPROCESSRepository= value;
			}
		}
		#endregion

		#region 526 数据接口 IT_LKJ_WORKPROCESS_HISRepository
		IT_LKJ_WORKPROCESS_HISRepository iT_LKJ_WORKPROCESS_HISRepository;
		public IT_LKJ_WORKPROCESS_HISRepository IT_LKJ_WORKPROCESS_HISRepository
		{
		 
			get 
			{
				if(iT_LKJ_WORKPROCESS_HISRepository==null)
					iT_LKJ_WORKPROCESS_HISRepository= new T_LKJ_WORKPROCESS_HISRepository();
				return iT_LKJ_WORKPROCESS_HISRepository;
			}
			set
			{
				iT_LKJ_WORKPROCESS_HISRepository= value;
			}
		}
		#endregion

		#region 527 数据接口 IT_MOBILEFILERepository
		IT_MOBILEFILERepository iT_MOBILEFILERepository;
		public IT_MOBILEFILERepository IT_MOBILEFILERepository
		{
		 
			get 
			{
				if(iT_MOBILEFILERepository==null)
					iT_MOBILEFILERepository= new T_MOBILEFILERepository();
				return iT_MOBILEFILERepository;
			}
			set
			{
				iT_MOBILEFILERepository= value;
			}
		}
		#endregion

		#region 528 数据接口 IT_MOBILEFILE_TODOWNRepository
		IT_MOBILEFILE_TODOWNRepository iT_MOBILEFILE_TODOWNRepository;
		public IT_MOBILEFILE_TODOWNRepository IT_MOBILEFILE_TODOWNRepository
		{
		 
			get 
			{
				if(iT_MOBILEFILE_TODOWNRepository==null)
					iT_MOBILEFILE_TODOWNRepository= new T_MOBILEFILE_TODOWNRepository();
				return iT_MOBILEFILE_TODOWNRepository;
			}
			set
			{
				iT_MOBILEFILE_TODOWNRepository= value;
			}
		}
		#endregion

		#region 529 数据接口 IT_MOBILELASTPOSRepository
		IT_MOBILELASTPOSRepository iT_MOBILELASTPOSRepository;
		public IT_MOBILELASTPOSRepository IT_MOBILELASTPOSRepository
		{
		 
			get 
			{
				if(iT_MOBILELASTPOSRepository==null)
					iT_MOBILELASTPOSRepository= new T_MOBILELASTPOSRepository();
				return iT_MOBILELASTPOSRepository;
			}
			set
			{
				iT_MOBILELASTPOSRepository= value;
			}
		}
		#endregion

		#region 530 数据接口 IT_MOBILEROUTERepository
		IT_MOBILEROUTERepository iT_MOBILEROUTERepository;
		public IT_MOBILEROUTERepository IT_MOBILEROUTERepository
		{
		 
			get 
			{
				if(iT_MOBILEROUTERepository==null)
					iT_MOBILEROUTERepository= new T_MOBILEROUTERepository();
				return iT_MOBILEROUTERepository;
			}
			set
			{
				iT_MOBILEROUTERepository= value;
			}
		}
		#endregion

		#region 531 数据接口 IT_MOBILEROUTE_HISRepository
		IT_MOBILEROUTE_HISRepository iT_MOBILEROUTE_HISRepository;
		public IT_MOBILEROUTE_HISRepository IT_MOBILEROUTE_HISRepository
		{
		 
			get 
			{
				if(iT_MOBILEROUTE_HISRepository==null)
					iT_MOBILEROUTE_HISRepository= new T_MOBILEROUTE_HISRepository();
				return iT_MOBILEROUTE_HISRepository;
			}
			set
			{
				iT_MOBILEROUTE_HISRepository= value;
			}
		}
		#endregion

		#region 532 数据接口 IT_OILPOSRepository
		IT_OILPOSRepository iT_OILPOSRepository;
		public IT_OILPOSRepository IT_OILPOSRepository
		{
		 
			get 
			{
				if(iT_OILPOSRepository==null)
					iT_OILPOSRepository= new T_OILPOSRepository();
				return iT_OILPOSRepository;
			}
			set
			{
				iT_OILPOSRepository= value;
			}
		}
		#endregion

		#region 533 数据接口 IT_RAINRepository
		IT_RAINRepository iT_RAINRepository;
		public IT_RAINRepository IT_RAINRepository
		{
		 
			get 
			{
				if(iT_RAINRepository==null)
					iT_RAINRepository= new T_RAINRepository();
				return iT_RAINRepository;
			}
			set
			{
				iT_RAINRepository= value;
			}
		}
		#endregion

		#region 534 数据接口 IT_RAIN_SMSRepository
		IT_RAIN_SMSRepository iT_RAIN_SMSRepository;
		public IT_RAIN_SMSRepository IT_RAIN_SMSRepository
		{
		 
			get 
			{
				if(iT_RAIN_SMSRepository==null)
					iT_RAIN_SMSRepository= new T_RAIN_SMSRepository();
				return iT_RAIN_SMSRepository;
			}
			set
			{
				iT_RAIN_SMSRepository= value;
			}
		}
		#endregion

		#region 535 数据接口 IT_RAINWARNRepository
		IT_RAINWARNRepository iT_RAINWARNRepository;
		public IT_RAINWARNRepository IT_RAINWARNRepository
		{
		 
			get 
			{
				if(iT_RAINWARNRepository==null)
					iT_RAINWARNRepository= new T_RAINWARNRepository();
				return iT_RAINWARNRepository;
			}
			set
			{
				iT_RAINWARNRepository= value;
			}
		}
		#endregion

		#region 536 数据接口 IT_REALRAINDATARepository
		IT_REALRAINDATARepository iT_REALRAINDATARepository;
		public IT_REALRAINDATARepository IT_REALRAINDATARepository
		{
		 
			get 
			{
				if(iT_REALRAINDATARepository==null)
					iT_REALRAINDATARepository= new T_REALRAINDATARepository();
				return iT_REALRAINDATARepository;
			}
			set
			{
				iT_REALRAINDATARepository= value;
			}
		}
		#endregion

		#region 537 数据接口 IT_SGJHWARNRepository
		IT_SGJHWARNRepository iT_SGJHWARNRepository;
		public IT_SGJHWARNRepository IT_SGJHWARNRepository
		{
		 
			get 
			{
				if(iT_SGJHWARNRepository==null)
					iT_SGJHWARNRepository= new T_SGJHWARNRepository();
				return iT_SGJHWARNRepository;
			}
			set
			{
				iT_SGJHWARNRepository= value;
			}
		}
		#endregion

		#region 538 数据接口 IT_SGJHWARNTMPRepository
		IT_SGJHWARNTMPRepository iT_SGJHWARNTMPRepository;
		public IT_SGJHWARNTMPRepository IT_SGJHWARNTMPRepository
		{
		 
			get 
			{
				if(iT_SGJHWARNTMPRepository==null)
					iT_SGJHWARNTMPRepository= new T_SGJHWARNTMPRepository();
				return iT_SGJHWARNTMPRepository;
			}
			set
			{
				iT_SGJHWARNTMPRepository= value;
			}
		}
		#endregion

		#region 539 数据接口 IT_VEHICLELOCATIONRepository
		IT_VEHICLELOCATIONRepository iT_VEHICLELOCATIONRepository;
		public IT_VEHICLELOCATIONRepository IT_VEHICLELOCATIONRepository
		{
		 
			get 
			{
				if(iT_VEHICLELOCATIONRepository==null)
					iT_VEHICLELOCATIONRepository= new T_VEHICLELOCATIONRepository();
				return iT_VEHICLELOCATIONRepository;
			}
			set
			{
				iT_VEHICLELOCATIONRepository= value;
			}
		}
		#endregion

		#region 540 数据接口 IT_WATERRepository
		IT_WATERRepository iT_WATERRepository;
		public IT_WATERRepository IT_WATERRepository
		{
		 
			get 
			{
				if(iT_WATERRepository==null)
					iT_WATERRepository= new T_WATERRepository();
				return iT_WATERRepository;
			}
			set
			{
				iT_WATERRepository= value;
			}
		}
		#endregion

		#region 541 数据接口 IT_WATER_DEVICERepository
		IT_WATER_DEVICERepository iT_WATER_DEVICERepository;
		public IT_WATER_DEVICERepository IT_WATER_DEVICERepository
		{
		 
			get 
			{
				if(iT_WATER_DEVICERepository==null)
					iT_WATER_DEVICERepository= new T_WATER_DEVICERepository();
				return iT_WATER_DEVICERepository;
			}
			set
			{
				iT_WATER_DEVICERepository= value;
			}
		}
		#endregion

		#region 542 数据接口 IT_WATER_WARNRepository
		IT_WATER_WARNRepository iT_WATER_WARNRepository;
		public IT_WATER_WARNRepository IT_WATER_WARNRepository
		{
		 
			get 
			{
				if(iT_WATER_WARNRepository==null)
					iT_WATER_WARNRepository= new T_WATER_WARNRepository();
				return iT_WATER_WARNRepository;
			}
			set
			{
				iT_WATER_WARNRepository= value;
			}
		}
		#endregion

		#region 543 数据接口 ITASK_CARDRepository
		ITASK_CARDRepository iTASK_CARDRepository;
		public ITASK_CARDRepository ITASK_CARDRepository
		{
		 
			get 
			{
				if(iTASK_CARDRepository==null)
					iTASK_CARDRepository= new TASK_CARDRepository();
				return iTASK_CARDRepository;
			}
			set
			{
				iTASK_CARDRepository= value;
			}
		}
		#endregion

		#region 544 数据接口 ITASK_CONSTITLERepository
		ITASK_CONSTITLERepository iTASK_CONSTITLERepository;
		public ITASK_CONSTITLERepository ITASK_CONSTITLERepository
		{
		 
			get 
			{
				if(iTASK_CONSTITLERepository==null)
					iTASK_CONSTITLERepository= new TASK_CONSTITLERepository();
				return iTASK_CONSTITLERepository;
			}
			set
			{
				iTASK_CONSTITLERepository= value;
			}
		}
		#endregion

		#region 545 数据接口 ITASK_CONSTRUCTIONRepository
		ITASK_CONSTRUCTIONRepository iTASK_CONSTRUCTIONRepository;
		public ITASK_CONSTRUCTIONRepository ITASK_CONSTRUCTIONRepository
		{
		 
			get 
			{
				if(iTASK_CONSTRUCTIONRepository==null)
					iTASK_CONSTRUCTIONRepository= new TASK_CONSTRUCTIONRepository();
				return iTASK_CONSTRUCTIONRepository;
			}
			set
			{
				iTASK_CONSTRUCTIONRepository= value;
			}
		}
		#endregion

		#region 546 数据接口 ITASK_DAMAGE_RAILRepository
		ITASK_DAMAGE_RAILRepository iTASK_DAMAGE_RAILRepository;
		public ITASK_DAMAGE_RAILRepository ITASK_DAMAGE_RAILRepository
		{
		 
			get 
			{
				if(iTASK_DAMAGE_RAILRepository==null)
					iTASK_DAMAGE_RAILRepository= new TASK_DAMAGE_RAILRepository();
				return iTASK_DAMAGE_RAILRepository;
			}
			set
			{
				iTASK_DAMAGE_RAILRepository= value;
			}
		}
		#endregion

		#region 547 数据接口 ITASK_FLOORRepository
		ITASK_FLOORRepository iTASK_FLOORRepository;
		public ITASK_FLOORRepository ITASK_FLOORRepository
		{
		 
			get 
			{
				if(iTASK_FLOORRepository==null)
					iTASK_FLOORRepository= new TASK_FLOORRepository();
				return iTASK_FLOORRepository;
			}
			set
			{
				iTASK_FLOORRepository= value;
			}
		}
		#endregion

		#region 548 数据接口 ITASK_GBH_RAILRepository
		ITASK_GBH_RAILRepository iTASK_GBH_RAILRepository;
		public ITASK_GBH_RAILRepository ITASK_GBH_RAILRepository
		{
		 
			get 
			{
				if(iTASK_GBH_RAILRepository==null)
					iTASK_GBH_RAILRepository= new TASK_GBH_RAILRepository();
				return iTASK_GBH_RAILRepository;
			}
			set
			{
				iTASK_GBH_RAILRepository= value;
			}
		}
		#endregion

		#region 549 数据接口 ITASK_LAY_LINEROADRepository
		ITASK_LAY_LINEROADRepository iTASK_LAY_LINEROADRepository;
		public ITASK_LAY_LINEROADRepository ITASK_LAY_LINEROADRepository
		{
		 
			get 
			{
				if(iTASK_LAY_LINEROADRepository==null)
					iTASK_LAY_LINEROADRepository= new TASK_LAY_LINEROADRepository();
				return iTASK_LAY_LINEROADRepository;
			}
			set
			{
				iTASK_LAY_LINEROADRepository= value;
			}
		}
		#endregion

		#region 550 数据接口 ITASK_PLANRepository
		ITASK_PLANRepository iTASK_PLANRepository;
		public ITASK_PLANRepository ITASK_PLANRepository
		{
		 
			get 
			{
				if(iTASK_PLANRepository==null)
					iTASK_PLANRepository= new TASK_PLANRepository();
				return iTASK_PLANRepository;
			}
			set
			{
				iTASK_PLANRepository= value;
			}
		}
		#endregion

		#region 551 数据接口 ITASK_PLAN_MATERIALRepository
		ITASK_PLAN_MATERIALRepository iTASK_PLAN_MATERIALRepository;
		public ITASK_PLAN_MATERIALRepository ITASK_PLAN_MATERIALRepository
		{
		 
			get 
			{
				if(iTASK_PLAN_MATERIALRepository==null)
					iTASK_PLAN_MATERIALRepository= new TASK_PLAN_MATERIALRepository();
				return iTASK_PLAN_MATERIALRepository;
			}
			set
			{
				iTASK_PLAN_MATERIALRepository= value;
			}
		}
		#endregion

		#region 552 数据接口 ITASK_PLAN_PROBLEMRepository
		ITASK_PLAN_PROBLEMRepository iTASK_PLAN_PROBLEMRepository;
		public ITASK_PLAN_PROBLEMRepository ITASK_PLAN_PROBLEMRepository
		{
		 
			get 
			{
				if(iTASK_PLAN_PROBLEMRepository==null)
					iTASK_PLAN_PROBLEMRepository= new TASK_PLAN_PROBLEMRepository();
				return iTASK_PLAN_PROBLEMRepository;
			}
			set
			{
				iTASK_PLAN_PROBLEMRepository= value;
			}
		}
		#endregion

		#region 553 数据接口 ITASK_PLAN_TOOLRepository
		ITASK_PLAN_TOOLRepository iTASK_PLAN_TOOLRepository;
		public ITASK_PLAN_TOOLRepository ITASK_PLAN_TOOLRepository
		{
		 
			get 
			{
				if(iTASK_PLAN_TOOLRepository==null)
					iTASK_PLAN_TOOLRepository= new TASK_PLAN_TOOLRepository();
				return iTASK_PLAN_TOOLRepository;
			}
			set
			{
				iTASK_PLAN_TOOLRepository= value;
			}
		}
		#endregion

		#region 554 数据接口 ITASK_RAILRepository
		ITASK_RAILRepository iTASK_RAILRepository;
		public ITASK_RAILRepository ITASK_RAILRepository
		{
		 
			get 
			{
				if(iTASK_RAILRepository==null)
					iTASK_RAILRepository= new TASK_RAILRepository();
				return iTASK_RAILRepository;
			}
			set
			{
				iTASK_RAILRepository= value;
			}
		}
		#endregion

		#region 555 数据接口 ITASK_RAILCOUNTRepository
		ITASK_RAILCOUNTRepository iTASK_RAILCOUNTRepository;
		public ITASK_RAILCOUNTRepository ITASK_RAILCOUNTRepository
		{
		 
			get 
			{
				if(iTASK_RAILCOUNTRepository==null)
					iTASK_RAILCOUNTRepository= new TASK_RAILCOUNTRepository();
				return iTASK_RAILCOUNTRepository;
			}
			set
			{
				iTASK_RAILCOUNTRepository= value;
			}
		}
		#endregion

		#region 556 数据接口 ITASK_RECOVER_STUFFRepository
		ITASK_RECOVER_STUFFRepository iTASK_RECOVER_STUFFRepository;
		public ITASK_RECOVER_STUFFRepository ITASK_RECOVER_STUFFRepository
		{
		 
			get 
			{
				if(iTASK_RECOVER_STUFFRepository==null)
					iTASK_RECOVER_STUFFRepository= new TASK_RECOVER_STUFFRepository();
				return iTASK_RECOVER_STUFFRepository;
			}
			set
			{
				iTASK_RECOVER_STUFFRepository= value;
			}
		}
		#endregion

		#region 557 数据接口 ITASK_REPLACE_RAILRepository
		ITASK_REPLACE_RAILRepository iTASK_REPLACE_RAILRepository;
		public ITASK_REPLACE_RAILRepository ITASK_REPLACE_RAILRepository
		{
		 
			get 
			{
				if(iTASK_REPLACE_RAILRepository==null)
					iTASK_REPLACE_RAILRepository= new TASK_REPLACE_RAILRepository();
				return iTASK_REPLACE_RAILRepository;
			}
			set
			{
				iTASK_REPLACE_RAILRepository= value;
			}
		}
		#endregion

		#region 558 数据接口 ITASK_REPLACE_TIERepository
		ITASK_REPLACE_TIERepository iTASK_REPLACE_TIERepository;
		public ITASK_REPLACE_TIERepository ITASK_REPLACE_TIERepository
		{
		 
			get 
			{
				if(iTASK_REPLACE_TIERepository==null)
					iTASK_REPLACE_TIERepository= new TASK_REPLACE_TIERepository();
				return iTASK_REPLACE_TIERepository;
			}
			set
			{
				iTASK_REPLACE_TIERepository= value;
			}
		}
		#endregion

		#region 559 数据接口 ITASK_SLIGHT_FROGRepository
		ITASK_SLIGHT_FROGRepository iTASK_SLIGHT_FROGRepository;
		public ITASK_SLIGHT_FROGRepository ITASK_SLIGHT_FROGRepository
		{
		 
			get 
			{
				if(iTASK_SLIGHT_FROGRepository==null)
					iTASK_SLIGHT_FROGRepository= new TASK_SLIGHT_FROGRepository();
				return iTASK_SLIGHT_FROGRepository;
			}
			set
			{
				iTASK_SLIGHT_FROGRepository= value;
			}
		}
		#endregion

		#region 560 数据接口 ITASK_SLIGHT_JRAILRepository
		ITASK_SLIGHT_JRAILRepository iTASK_SLIGHT_JRAILRepository;
		public ITASK_SLIGHT_JRAILRepository ITASK_SLIGHT_JRAILRepository
		{
		 
			get 
			{
				if(iTASK_SLIGHT_JRAILRepository==null)
					iTASK_SLIGHT_JRAILRepository= new TASK_SLIGHT_JRAILRepository();
				return iTASK_SLIGHT_JRAILRepository;
			}
			set
			{
				iTASK_SLIGHT_JRAILRepository= value;
			}
		}
		#endregion

		#region 561 数据接口 ITASK_SLIGHT_OUTLINERepository
		ITASK_SLIGHT_OUTLINERepository iTASK_SLIGHT_OUTLINERepository;
		public ITASK_SLIGHT_OUTLINERepository ITASK_SLIGHT_OUTLINERepository
		{
		 
			get 
			{
				if(iTASK_SLIGHT_OUTLINERepository==null)
					iTASK_SLIGHT_OUTLINERepository= new TASK_SLIGHT_OUTLINERepository();
				return iTASK_SLIGHT_OUTLINERepository;
			}
			set
			{
				iTASK_SLIGHT_OUTLINERepository= value;
			}
		}
		#endregion

		#region 562 数据接口 ITASK_SLIGHT_OUTLINE_FILERepository
		ITASK_SLIGHT_OUTLINE_FILERepository iTASK_SLIGHT_OUTLINE_FILERepository;
		public ITASK_SLIGHT_OUTLINE_FILERepository ITASK_SLIGHT_OUTLINE_FILERepository
		{
		 
			get 
			{
				if(iTASK_SLIGHT_OUTLINE_FILERepository==null)
					iTASK_SLIGHT_OUTLINE_FILERepository= new TASK_SLIGHT_OUTLINE_FILERepository();
				return iTASK_SLIGHT_OUTLINE_FILERepository;
			}
			set
			{
				iTASK_SLIGHT_OUTLINE_FILERepository= value;
			}
		}
		#endregion

		#region 563 数据接口 ITASK_SLIGHT_RAILRepository
		ITASK_SLIGHT_RAILRepository iTASK_SLIGHT_RAILRepository;
		public ITASK_SLIGHT_RAILRepository ITASK_SLIGHT_RAILRepository
		{
		 
			get 
			{
				if(iTASK_SLIGHT_RAILRepository==null)
					iTASK_SLIGHT_RAILRepository= new TASK_SLIGHT_RAILRepository();
				return iTASK_SLIGHT_RAILRepository;
			}
			set
			{
				iTASK_SLIGHT_RAILRepository= value;
			}
		}
		#endregion

		#region 564 数据接口 ITASK_SLIGHT_RAILP43Repository
		ITASK_SLIGHT_RAILP43Repository iTASK_SLIGHT_RAILP43Repository;
		public ITASK_SLIGHT_RAILP43Repository ITASK_SLIGHT_RAILP43Repository
		{
		 
			get 
			{
				if(iTASK_SLIGHT_RAILP43Repository==null)
					iTASK_SLIGHT_RAILP43Repository= new TASK_SLIGHT_RAILP43Repository();
				return iTASK_SLIGHT_RAILP43Repository;
			}
			set
			{
				iTASK_SLIGHT_RAILP43Repository= value;
			}
		}
		#endregion

		#region 565 数据接口 ITASK_SLIGHT_RAILP50Repository
		ITASK_SLIGHT_RAILP50Repository iTASK_SLIGHT_RAILP50Repository;
		public ITASK_SLIGHT_RAILP50Repository ITASK_SLIGHT_RAILP50Repository
		{
		 
			get 
			{
				if(iTASK_SLIGHT_RAILP50Repository==null)
					iTASK_SLIGHT_RAILP50Repository= new TASK_SLIGHT_RAILP50Repository();
				return iTASK_SLIGHT_RAILP50Repository;
			}
			set
			{
				iTASK_SLIGHT_RAILP50Repository= value;
			}
		}
		#endregion

		#region 566 数据接口 ITASK_SLIGHT_RAILP60Repository
		ITASK_SLIGHT_RAILP60Repository iTASK_SLIGHT_RAILP60Repository;
		public ITASK_SLIGHT_RAILP60Repository ITASK_SLIGHT_RAILP60Repository
		{
		 
			get 
			{
				if(iTASK_SLIGHT_RAILP60Repository==null)
					iTASK_SLIGHT_RAILP60Repository= new TASK_SLIGHT_RAILP60Repository();
				return iTASK_SLIGHT_RAILP60Repository;
			}
			set
			{
				iTASK_SLIGHT_RAILP60Repository= value;
			}
		}
		#endregion

		#region 567 数据接口 ITASK_SVGRepository
		ITASK_SVGRepository iTASK_SVGRepository;
		public ITASK_SVGRepository ITASK_SVGRepository
		{
		 
			get 
			{
				if(iTASK_SVGRepository==null)
					iTASK_SVGRepository= new TASK_SVGRepository();
				return iTASK_SVGRepository;
			}
			set
			{
				iTASK_SVGRepository= value;
			}
		}
		#endregion

		#region 568 数据接口 ITASK_TOOLINFORepository
		ITASK_TOOLINFORepository iTASK_TOOLINFORepository;
		public ITASK_TOOLINFORepository ITASK_TOOLINFORepository
		{
		 
			get 
			{
				if(iTASK_TOOLINFORepository==null)
					iTASK_TOOLINFORepository= new TASK_TOOLINFORepository();
				return iTASK_TOOLINFORepository;
			}
			set
			{
				iTASK_TOOLINFORepository= value;
			}
		}
		#endregion

		#region 569 数据接口 ITASK_UNLOAD_RAILRepository
		ITASK_UNLOAD_RAILRepository iTASK_UNLOAD_RAILRepository;
		public ITASK_UNLOAD_RAILRepository ITASK_UNLOAD_RAILRepository
		{
		 
			get 
			{
				if(iTASK_UNLOAD_RAILRepository==null)
					iTASK_UNLOAD_RAILRepository= new TASK_UNLOAD_RAILRepository();
				return iTASK_UNLOAD_RAILRepository;
			}
			set
			{
				iTASK_UNLOAD_RAILRepository= value;
			}
		}
		#endregion

		#region 570 数据接口 ITASK_UNLOAD_STONERepository
		ITASK_UNLOAD_STONERepository iTASK_UNLOAD_STONERepository;
		public ITASK_UNLOAD_STONERepository ITASK_UNLOAD_STONERepository
		{
		 
			get 
			{
				if(iTASK_UNLOAD_STONERepository==null)
					iTASK_UNLOAD_STONERepository= new TASK_UNLOAD_STONERepository();
				return iTASK_UNLOAD_STONERepository;
			}
			set
			{
				iTASK_UNLOAD_STONERepository= value;
			}
		}
		#endregion

		#region 571 数据接口 ITASK_UNLOAD_TIERepository
		ITASK_UNLOAD_TIERepository iTASK_UNLOAD_TIERepository;
		public ITASK_UNLOAD_TIERepository ITASK_UNLOAD_TIERepository
		{
		 
			get 
			{
				if(iTASK_UNLOAD_TIERepository==null)
					iTASK_UNLOAD_TIERepository= new TASK_UNLOAD_TIERepository();
				return iTASK_UNLOAD_TIERepository;
			}
			set
			{
				iTASK_UNLOAD_TIERepository= value;
			}
		}
		#endregion

		#region 572 数据接口 ITASK_WORKLOADRepository
		ITASK_WORKLOADRepository iTASK_WORKLOADRepository;
		public ITASK_WORKLOADRepository ITASK_WORKLOADRepository
		{
		 
			get 
			{
				if(iTASK_WORKLOADRepository==null)
					iTASK_WORKLOADRepository= new TASK_WORKLOADRepository();
				return iTASK_WORKLOADRepository;
			}
			set
			{
				iTASK_WORKLOADRepository= value;
			}
		}
		#endregion

		#region 573 数据接口 ITEMPERATURE_SECTION_LINERepository
		ITEMPERATURE_SECTION_LINERepository iTEMPERATURE_SECTION_LINERepository;
		public ITEMPERATURE_SECTION_LINERepository ITEMPERATURE_SECTION_LINERepository
		{
		 
			get 
			{
				if(iTEMPERATURE_SECTION_LINERepository==null)
					iTEMPERATURE_SECTION_LINERepository= new TEMPERATURE_SECTION_LINERepository();
				return iTEMPERATURE_SECTION_LINERepository;
			}
			set
			{
				iTEMPERATURE_SECTION_LINERepository= value;
			}
		}
		#endregion

		#region 574 数据接口 ITOOL_BDATE_DICRepository
		ITOOL_BDATE_DICRepository iTOOL_BDATE_DICRepository;
		public ITOOL_BDATE_DICRepository ITOOL_BDATE_DICRepository
		{
		 
			get 
			{
				if(iTOOL_BDATE_DICRepository==null)
					iTOOL_BDATE_DICRepository= new TOOL_BDATE_DICRepository();
				return iTOOL_BDATE_DICRepository;
			}
			set
			{
				iTOOL_BDATE_DICRepository= value;
			}
		}
		#endregion

		#region 575 数据接口 ITOOL_BDATE_STOREHOURSERepository
		ITOOL_BDATE_STOREHOURSERepository iTOOL_BDATE_STOREHOURSERepository;
		public ITOOL_BDATE_STOREHOURSERepository ITOOL_BDATE_STOREHOURSERepository
		{
		 
			get 
			{
				if(iTOOL_BDATE_STOREHOURSERepository==null)
					iTOOL_BDATE_STOREHOURSERepository= new TOOL_BDATE_STOREHOURSERepository();
				return iTOOL_BDATE_STOREHOURSERepository;
			}
			set
			{
				iTOOL_BDATE_STOREHOURSERepository= value;
			}
		}
		#endregion

		#region 576 数据接口 ITOOL_BDATE_TOOLNAMERepository
		ITOOL_BDATE_TOOLNAMERepository iTOOL_BDATE_TOOLNAMERepository;
		public ITOOL_BDATE_TOOLNAMERepository ITOOL_BDATE_TOOLNAMERepository
		{
		 
			get 
			{
				if(iTOOL_BDATE_TOOLNAMERepository==null)
					iTOOL_BDATE_TOOLNAMERepository= new TOOL_BDATE_TOOLNAMERepository();
				return iTOOL_BDATE_TOOLNAMERepository;
			}
			set
			{
				iTOOL_BDATE_TOOLNAMERepository= value;
			}
		}
		#endregion

		#region 577 数据接口 ITOOL_INOUTMNG_INFORepository
		ITOOL_INOUTMNG_INFORepository iTOOL_INOUTMNG_INFORepository;
		public ITOOL_INOUTMNG_INFORepository ITOOL_INOUTMNG_INFORepository
		{
		 
			get 
			{
				if(iTOOL_INOUTMNG_INFORepository==null)
					iTOOL_INOUTMNG_INFORepository= new TOOL_INOUTMNG_INFORepository();
				return iTOOL_INOUTMNG_INFORepository;
			}
			set
			{
				iTOOL_INOUTMNG_INFORepository= value;
			}
		}
		#endregion

		#region 578 数据接口 ITOOL_JOB_PLANRepository
		ITOOL_JOB_PLANRepository iTOOL_JOB_PLANRepository;
		public ITOOL_JOB_PLANRepository ITOOL_JOB_PLANRepository
		{
		 
			get 
			{
				if(iTOOL_JOB_PLANRepository==null)
					iTOOL_JOB_PLANRepository= new TOOL_JOB_PLANRepository();
				return iTOOL_JOB_PLANRepository;
			}
			set
			{
				iTOOL_JOB_PLANRepository= value;
			}
		}
		#endregion

		#region 579 数据接口 ITOOL_JOB_PLAN_IMPORTRepository
		ITOOL_JOB_PLAN_IMPORTRepository iTOOL_JOB_PLAN_IMPORTRepository;
		public ITOOL_JOB_PLAN_IMPORTRepository ITOOL_JOB_PLAN_IMPORTRepository
		{
		 
			get 
			{
				if(iTOOL_JOB_PLAN_IMPORTRepository==null)
					iTOOL_JOB_PLAN_IMPORTRepository= new TOOL_JOB_PLAN_IMPORTRepository();
				return iTOOL_JOB_PLAN_IMPORTRepository;
			}
			set
			{
				iTOOL_JOB_PLAN_IMPORTRepository= value;
			}
		}
		#endregion

		#region 580 数据接口 ITOOL_PHONE_USERRepository
		ITOOL_PHONE_USERRepository iTOOL_PHONE_USERRepository;
		public ITOOL_PHONE_USERRepository ITOOL_PHONE_USERRepository
		{
		 
			get 
			{
				if(iTOOL_PHONE_USERRepository==null)
					iTOOL_PHONE_USERRepository= new TOOL_PHONE_USERRepository();
				return iTOOL_PHONE_USERRepository;
			}
			set
			{
				iTOOL_PHONE_USERRepository= value;
			}
		}
		#endregion

		#region 581 数据接口 ITOOL_TOOLMNG_INOUTRepository
		ITOOL_TOOLMNG_INOUTRepository iTOOL_TOOLMNG_INOUTRepository;
		public ITOOL_TOOLMNG_INOUTRepository ITOOL_TOOLMNG_INOUTRepository
		{
		 
			get 
			{
				if(iTOOL_TOOLMNG_INOUTRepository==null)
					iTOOL_TOOLMNG_INOUTRepository= new TOOL_TOOLMNG_INOUTRepository();
				return iTOOL_TOOLMNG_INOUTRepository;
			}
			set
			{
				iTOOL_TOOLMNG_INOUTRepository= value;
			}
		}
		#endregion

		#region 582 数据接口 ITOOL_UPDOWN_LINERepository
		ITOOL_UPDOWN_LINERepository iTOOL_UPDOWN_LINERepository;
		public ITOOL_UPDOWN_LINERepository ITOOL_UPDOWN_LINERepository
		{
		 
			get 
			{
				if(iTOOL_UPDOWN_LINERepository==null)
					iTOOL_UPDOWN_LINERepository= new TOOL_UPDOWN_LINERepository();
				return iTOOL_UPDOWN_LINERepository;
			}
			set
			{
				iTOOL_UPDOWN_LINERepository= value;
			}
		}
		#endregion

		#region 583 数据接口 ITOOL_USERepository
		ITOOL_USERepository iTOOL_USERepository;
		public ITOOL_USERepository ITOOL_USERepository
		{
		 
			get 
			{
				if(iTOOL_USERepository==null)
					iTOOL_USERepository= new TOOL_USERepository();
				return iTOOL_USERepository;
			}
			set
			{
				iTOOL_USERepository= value;
			}
		}
		#endregion

		#region 584 数据接口 ITOOL_VIRTUAL_JOB_PLANRepository
		ITOOL_VIRTUAL_JOB_PLANRepository iTOOL_VIRTUAL_JOB_PLANRepository;
		public ITOOL_VIRTUAL_JOB_PLANRepository ITOOL_VIRTUAL_JOB_PLANRepository
		{
		 
			get 
			{
				if(iTOOL_VIRTUAL_JOB_PLANRepository==null)
					iTOOL_VIRTUAL_JOB_PLANRepository= new TOOL_VIRTUAL_JOB_PLANRepository();
				return iTOOL_VIRTUAL_JOB_PLANRepository;
			}
			set
			{
				iTOOL_VIRTUAL_JOB_PLANRepository= value;
			}
		}
		#endregion

		#region 585 数据接口 ITOOL_VIRTUAL_UPDOWN_LINERepository
		ITOOL_VIRTUAL_UPDOWN_LINERepository iTOOL_VIRTUAL_UPDOWN_LINERepository;
		public ITOOL_VIRTUAL_UPDOWN_LINERepository ITOOL_VIRTUAL_UPDOWN_LINERepository
		{
		 
			get 
			{
				if(iTOOL_VIRTUAL_UPDOWN_LINERepository==null)
					iTOOL_VIRTUAL_UPDOWN_LINERepository= new TOOL_VIRTUAL_UPDOWN_LINERepository();
				return iTOOL_VIRTUAL_UPDOWN_LINERepository;
			}
			set
			{
				iTOOL_VIRTUAL_UPDOWN_LINERepository= value;
			}
		}
		#endregion

		#region 586 数据接口 ITOOL_VIRTUAL_USERepository
		ITOOL_VIRTUAL_USERepository iTOOL_VIRTUAL_USERepository;
		public ITOOL_VIRTUAL_USERepository ITOOL_VIRTUAL_USERepository
		{
		 
			get 
			{
				if(iTOOL_VIRTUAL_USERepository==null)
					iTOOL_VIRTUAL_USERepository= new TOOL_VIRTUAL_USERepository();
				return iTOOL_VIRTUAL_USERepository;
			}
			set
			{
				iTOOL_VIRTUAL_USERepository= value;
			}
		}
		#endregion

		#region 587 数据接口 ITOOL_VIRTUAL_WARMRepository
		ITOOL_VIRTUAL_WARMRepository iTOOL_VIRTUAL_WARMRepository;
		public ITOOL_VIRTUAL_WARMRepository ITOOL_VIRTUAL_WARMRepository
		{
		 
			get 
			{
				if(iTOOL_VIRTUAL_WARMRepository==null)
					iTOOL_VIRTUAL_WARMRepository= new TOOL_VIRTUAL_WARMRepository();
				return iTOOL_VIRTUAL_WARMRepository;
			}
			set
			{
				iTOOL_VIRTUAL_WARMRepository= value;
			}
		}
		#endregion

		#region 588 数据接口 ITOOL_WARMRepository
		ITOOL_WARMRepository iTOOL_WARMRepository;
		public ITOOL_WARMRepository ITOOL_WARMRepository
		{
		 
			get 
			{
				if(iTOOL_WARMRepository==null)
					iTOOL_WARMRepository= new TOOL_WARMRepository();
				return iTOOL_WARMRepository;
			}
			set
			{
				iTOOL_WARMRepository= value;
			}
		}
		#endregion

		#region 589 数据接口 ITURNOUT_BASERepository
		ITURNOUT_BASERepository iTURNOUT_BASERepository;
		public ITURNOUT_BASERepository ITURNOUT_BASERepository
		{
		 
			get 
			{
				if(iTURNOUT_BASERepository==null)
					iTURNOUT_BASERepository= new TURNOUT_BASERepository();
				return iTURNOUT_BASERepository;
			}
			set
			{
				iTURNOUT_BASERepository= value;
			}
		}
		#endregion

		#region 590 数据接口 ITURNOUT_BDATE_DICRepository
		ITURNOUT_BDATE_DICRepository iTURNOUT_BDATE_DICRepository;
		public ITURNOUT_BDATE_DICRepository ITURNOUT_BDATE_DICRepository
		{
		 
			get 
			{
				if(iTURNOUT_BDATE_DICRepository==null)
					iTURNOUT_BDATE_DICRepository= new TURNOUT_BDATE_DICRepository();
				return iTURNOUT_BDATE_DICRepository;
			}
			set
			{
				iTURNOUT_BDATE_DICRepository= value;
			}
		}
		#endregion

		#region 591 数据接口 ITURNOUT_BRANCHRepository
		ITURNOUT_BRANCHRepository iTURNOUT_BRANCHRepository;
		public ITURNOUT_BRANCHRepository ITURNOUT_BRANCHRepository
		{
		 
			get 
			{
				if(iTURNOUT_BRANCHRepository==null)
					iTURNOUT_BRANCHRepository= new TURNOUT_BRANCHRepository();
				return iTURNOUT_BRANCHRepository;
			}
			set
			{
				iTURNOUT_BRANCHRepository= value;
			}
		}
		#endregion

		#region 592 数据接口 ITURNOUT_HIS_BRANCHRepository
		ITURNOUT_HIS_BRANCHRepository iTURNOUT_HIS_BRANCHRepository;
		public ITURNOUT_HIS_BRANCHRepository ITURNOUT_HIS_BRANCHRepository
		{
		 
			get 
			{
				if(iTURNOUT_HIS_BRANCHRepository==null)
					iTURNOUT_HIS_BRANCHRepository= new TURNOUT_HIS_BRANCHRepository();
				return iTURNOUT_HIS_BRANCHRepository;
			}
			set
			{
				iTURNOUT_HIS_BRANCHRepository= value;
			}
		}
		#endregion

		#region 593 数据接口 ITURNOUT_HIS_PARTRepository
		ITURNOUT_HIS_PARTRepository iTURNOUT_HIS_PARTRepository;
		public ITURNOUT_HIS_PARTRepository ITURNOUT_HIS_PARTRepository
		{
		 
			get 
			{
				if(iTURNOUT_HIS_PARTRepository==null)
					iTURNOUT_HIS_PARTRepository= new TURNOUT_HIS_PARTRepository();
				return iTURNOUT_HIS_PARTRepository;
			}
			set
			{
				iTURNOUT_HIS_PARTRepository= value;
			}
		}
		#endregion

		#region 594 数据接口 ITURNOUT_HIS_PICRepository
		ITURNOUT_HIS_PICRepository iTURNOUT_HIS_PICRepository;
		public ITURNOUT_HIS_PICRepository ITURNOUT_HIS_PICRepository
		{
		 
			get 
			{
				if(iTURNOUT_HIS_PICRepository==null)
					iTURNOUT_HIS_PICRepository= new TURNOUT_HIS_PICRepository();
				return iTURNOUT_HIS_PICRepository;
			}
			set
			{
				iTURNOUT_HIS_PICRepository= value;
			}
		}
		#endregion

		#region 595 数据接口 ITURNOUT_HIS_RAILRepository
		ITURNOUT_HIS_RAILRepository iTURNOUT_HIS_RAILRepository;
		public ITURNOUT_HIS_RAILRepository ITURNOUT_HIS_RAILRepository
		{
		 
			get 
			{
				if(iTURNOUT_HIS_RAILRepository==null)
					iTURNOUT_HIS_RAILRepository= new TURNOUT_HIS_RAILRepository();
				return iTURNOUT_HIS_RAILRepository;
			}
			set
			{
				iTURNOUT_HIS_RAILRepository= value;
			}
		}
		#endregion

		#region 596 数据接口 ITURNOUT_HISTORYRepository
		ITURNOUT_HISTORYRepository iTURNOUT_HISTORYRepository;
		public ITURNOUT_HISTORYRepository ITURNOUT_HISTORYRepository
		{
		 
			get 
			{
				if(iTURNOUT_HISTORYRepository==null)
					iTURNOUT_HISTORYRepository= new TURNOUT_HISTORYRepository();
				return iTURNOUT_HISTORYRepository;
			}
			set
			{
				iTURNOUT_HISTORYRepository= value;
			}
		}
		#endregion

		#region 597 数据接口 ITURNOUT_PARTRepository
		ITURNOUT_PARTRepository iTURNOUT_PARTRepository;
		public ITURNOUT_PARTRepository ITURNOUT_PARTRepository
		{
		 
			get 
			{
				if(iTURNOUT_PARTRepository==null)
					iTURNOUT_PARTRepository= new TURNOUT_PARTRepository();
				return iTURNOUT_PARTRepository;
			}
			set
			{
				iTURNOUT_PARTRepository= value;
			}
		}
		#endregion

		#region 598 数据接口 ITURNOUT_PICRepository
		ITURNOUT_PICRepository iTURNOUT_PICRepository;
		public ITURNOUT_PICRepository ITURNOUT_PICRepository
		{
		 
			get 
			{
				if(iTURNOUT_PICRepository==null)
					iTURNOUT_PICRepository= new TURNOUT_PICRepository();
				return iTURNOUT_PICRepository;
			}
			set
			{
				iTURNOUT_PICRepository= value;
			}
		}
		#endregion

		#region 599 数据接口 ITURNOUT_RAILRepository
		ITURNOUT_RAILRepository iTURNOUT_RAILRepository;
		public ITURNOUT_RAILRepository ITURNOUT_RAILRepository
		{
		 
			get 
			{
				if(iTURNOUT_RAILRepository==null)
					iTURNOUT_RAILRepository= new TURNOUT_RAILRepository();
				return iTURNOUT_RAILRepository;
			}
			set
			{
				iTURNOUT_RAILRepository= value;
			}
		}
		#endregion

		#region 600 数据接口 ITYPEFLOOD_PHOTORepository
		ITYPEFLOOD_PHOTORepository iTYPEFLOOD_PHOTORepository;
		public ITYPEFLOOD_PHOTORepository ITYPEFLOOD_PHOTORepository
		{
		 
			get 
			{
				if(iTYPEFLOOD_PHOTORepository==null)
					iTYPEFLOOD_PHOTORepository= new TYPEFLOOD_PHOTORepository();
				return iTYPEFLOOD_PHOTORepository;
			}
			set
			{
				iTYPEFLOOD_PHOTORepository= value;
			}
		}
		#endregion

		#region 601 数据接口 IVEHICLELOC_BDATA_LOCOMOTIVERepository
		IVEHICLELOC_BDATA_LOCOMOTIVERepository iVEHICLELOC_BDATA_LOCOMOTIVERepository;
		public IVEHICLELOC_BDATA_LOCOMOTIVERepository IVEHICLELOC_BDATA_LOCOMOTIVERepository
		{
		 
			get 
			{
				if(iVEHICLELOC_BDATA_LOCOMOTIVERepository==null)
					iVEHICLELOC_BDATA_LOCOMOTIVERepository= new VEHICLELOC_BDATA_LOCOMOTIVERepository();
				return iVEHICLELOC_BDATA_LOCOMOTIVERepository;
			}
			set
			{
				iVEHICLELOC_BDATA_LOCOMOTIVERepository= value;
			}
		}
		#endregion

		#region 602 数据接口 IVIDEO_BDATA_DEVICERepository
		IVIDEO_BDATA_DEVICERepository iVIDEO_BDATA_DEVICERepository;
		public IVIDEO_BDATA_DEVICERepository IVIDEO_BDATA_DEVICERepository
		{
		 
			get 
			{
				if(iVIDEO_BDATA_DEVICERepository==null)
					iVIDEO_BDATA_DEVICERepository= new VIDEO_BDATA_DEVICERepository();
				return iVIDEO_BDATA_DEVICERepository;
			}
			set
			{
				iVIDEO_BDATA_DEVICERepository= value;
			}
		}
		#endregion

		#region 603 数据接口 IVIDEO_FILERepository
		IVIDEO_FILERepository iVIDEO_FILERepository;
		public IVIDEO_FILERepository IVIDEO_FILERepository
		{
		 
			get 
			{
				if(iVIDEO_FILERepository==null)
					iVIDEO_FILERepository= new VIDEO_FILERepository();
				return iVIDEO_FILERepository;
			}
			set
			{
				iVIDEO_FILERepository= value;
			}
		}
		#endregion

		#region 604 数据接口 IWEATHER_PROVINCE_FORECASTRepository
		IWEATHER_PROVINCE_FORECASTRepository iWEATHER_PROVINCE_FORECASTRepository;
		public IWEATHER_PROVINCE_FORECASTRepository IWEATHER_PROVINCE_FORECASTRepository
		{
		 
			get 
			{
				if(iWEATHER_PROVINCE_FORECASTRepository==null)
					iWEATHER_PROVINCE_FORECASTRepository= new WEATHER_PROVINCE_FORECASTRepository();
				return iWEATHER_PROVINCE_FORECASTRepository;
			}
			set
			{
				iWEATHER_PROVINCE_FORECASTRepository= value;
			}
		}
		#endregion

		#region 605 数据接口 IWEATHER_PROVINCE_HOURFORECASTRepository
		IWEATHER_PROVINCE_HOURFORECASTRepository iWEATHER_PROVINCE_HOURFORECASTRepository;
		public IWEATHER_PROVINCE_HOURFORECASTRepository IWEATHER_PROVINCE_HOURFORECASTRepository
		{
		 
			get 
			{
				if(iWEATHER_PROVINCE_HOURFORECASTRepository==null)
					iWEATHER_PROVINCE_HOURFORECASTRepository= new WEATHER_PROVINCE_HOURFORECASTRepository();
				return iWEATHER_PROVINCE_HOURFORECASTRepository;
			}
			set
			{
				iWEATHER_PROVINCE_HOURFORECASTRepository= value;
			}
		}
		#endregion

		#region 606 数据接口 IWINDRepository
		IWINDRepository iWINDRepository;
		public IWINDRepository IWINDRepository
		{
		 
			get 
			{
				if(iWINDRepository==null)
					iWINDRepository= new WINDRepository();
				return iWINDRepository;
			}
			set
			{
				iWINDRepository= value;
			}
		}
		#endregion

		#region 607 数据接口 IWIND_BASEINFORepository
		IWIND_BASEINFORepository iWIND_BASEINFORepository;
		public IWIND_BASEINFORepository IWIND_BASEINFORepository
		{
		 
			get 
			{
				if(iWIND_BASEINFORepository==null)
					iWIND_BASEINFORepository= new WIND_BASEINFORepository();
				return iWIND_BASEINFORepository;
			}
			set
			{
				iWIND_BASEINFORepository= value;
			}
		}
		#endregion

		#region 608 数据接口 IWIND_DAYRPTRepository
		IWIND_DAYRPTRepository iWIND_DAYRPTRepository;
		public IWIND_DAYRPTRepository IWIND_DAYRPTRepository
		{
		 
			get 
			{
				if(iWIND_DAYRPTRepository==null)
					iWIND_DAYRPTRepository= new WIND_DAYRPTRepository();
				return iWIND_DAYRPTRepository;
			}
			set
			{
				iWIND_DAYRPTRepository= value;
			}
		}
		#endregion

		#region 609 数据接口 IWIND_DIRECTIONRepository
		IWIND_DIRECTIONRepository iWIND_DIRECTIONRepository;
		public IWIND_DIRECTIONRepository IWIND_DIRECTIONRepository
		{
		 
			get 
			{
				if(iWIND_DIRECTIONRepository==null)
					iWIND_DIRECTIONRepository= new WIND_DIRECTIONRepository();
				return iWIND_DIRECTIONRepository;
			}
			set
			{
				iWIND_DIRECTIONRepository= value;
			}
		}
		#endregion

		#region 610 数据接口 IWIND_GRADINGRepository
		IWIND_GRADINGRepository iWIND_GRADINGRepository;
		public IWIND_GRADINGRepository IWIND_GRADINGRepository
		{
		 
			get 
			{
				if(iWIND_GRADINGRepository==null)
					iWIND_GRADINGRepository= new WIND_GRADINGRepository();
				return iWIND_GRADINGRepository;
			}
			set
			{
				iWIND_GRADINGRepository= value;
			}
		}
		#endregion

		#region 611 数据接口 IWIND_MONRPTRepository
		IWIND_MONRPTRepository iWIND_MONRPTRepository;
		public IWIND_MONRPTRepository IWIND_MONRPTRepository
		{
		 
			get 
			{
				if(iWIND_MONRPTRepository==null)
					iWIND_MONRPTRepository= new WIND_MONRPTRepository();
				return iWIND_MONRPTRepository;
			}
			set
			{
				iWIND_MONRPTRepository= value;
			}
		}
		#endregion

		#region 612 数据接口 IWIND_SECTION_LINERepository
		IWIND_SECTION_LINERepository iWIND_SECTION_LINERepository;
		public IWIND_SECTION_LINERepository IWIND_SECTION_LINERepository
		{
		 
			get 
			{
				if(iWIND_SECTION_LINERepository==null)
					iWIND_SECTION_LINERepository= new WIND_SECTION_LINERepository();
				return iWIND_SECTION_LINERepository;
			}
			set
			{
				iWIND_SECTION_LINERepository= value;
			}
		}
		#endregion

		#region 613 数据接口 IWIND_WARNRepository
		IWIND_WARNRepository iWIND_WARNRepository;
		public IWIND_WARNRepository IWIND_WARNRepository
		{
		 
			get 
			{
				if(iWIND_WARNRepository==null)
					iWIND_WARNRepository= new WIND_WARNRepository();
				return iWIND_WARNRepository;
			}
			set
			{
				iWIND_WARNRepository= value;
			}
		}
		#endregion

		#region 614 数据接口 IWIND_WARN_STANDARDRepository
		IWIND_WARN_STANDARDRepository iWIND_WARN_STANDARDRepository;
		public IWIND_WARN_STANDARDRepository IWIND_WARN_STANDARDRepository
		{
		 
			get 
			{
				if(iWIND_WARN_STANDARDRepository==null)
					iWIND_WARN_STANDARDRepository= new WIND_WARN_STANDARDRepository();
				return iWIND_WARN_STANDARDRepository;
			}
			set
			{
				iWIND_WARN_STANDARDRepository= value;
			}
		}
		#endregion

		#region 615 数据接口 IWIND_YEARRPTRepository
		IWIND_YEARRPTRepository iWIND_YEARRPTRepository;
		public IWIND_YEARRPTRepository IWIND_YEARRPTRepository
		{
		 
			get 
			{
				if(iWIND_YEARRPTRepository==null)
					iWIND_YEARRPTRepository= new WIND_YEARRPTRepository();
				return iWIND_YEARRPTRepository;
			}
			set
			{
				iWIND_YEARRPTRepository= value;
			}
		}
		#endregion

		#region 616 数据接口 IWUFENG_BIAOZHUNRepository
		IWUFENG_BIAOZHUNRepository iWUFENG_BIAOZHUNRepository;
		public IWUFENG_BIAOZHUNRepository IWUFENG_BIAOZHUNRepository
		{
		 
			get 
			{
				if(iWUFENG_BIAOZHUNRepository==null)
					iWUFENG_BIAOZHUNRepository= new WUFENG_BIAOZHUNRepository();
				return iWUFENG_BIAOZHUNRepository;
			}
			set
			{
				iWUFENG_BIAOZHUNRepository= value;
			}
		}
		#endregion

		#region 617 数据接口 IWUFENG_CHEZHANRepository
		IWUFENG_CHEZHANRepository iWUFENG_CHEZHANRepository;
		public IWUFENG_CHEZHANRepository IWUFENG_CHEZHANRepository
		{
		 
			get 
			{
				if(iWUFENG_CHEZHANRepository==null)
					iWUFENG_CHEZHANRepository= new WUFENG_CHEZHANRepository();
				return iWUFENG_CHEZHANRepository;
			}
			set
			{
				iWUFENG_CHEZHANRepository= value;
			}
		}
		#endregion

		#region 618 数据接口 IWUFENG_DANYUANRepository
		IWUFENG_DANYUANRepository iWUFENG_DANYUANRepository;
		public IWUFENG_DANYUANRepository IWUFENG_DANYUANRepository
		{
		 
			get 
			{
				if(iWUFENG_DANYUANRepository==null)
					iWUFENG_DANYUANRepository= new WUFENG_DANYUANRepository();
				return iWUFENG_DANYUANRepository;
			}
			set
			{
				iWUFENG_DANYUANRepository= value;
			}
		}
		#endregion

		#region 619 数据接口 IWUFENG_DANYUAN_LISHIRepository
		IWUFENG_DANYUAN_LISHIRepository iWUFENG_DANYUAN_LISHIRepository;
		public IWUFENG_DANYUAN_LISHIRepository IWUFENG_DANYUAN_LISHIRepository
		{
		 
			get 
			{
				if(iWUFENG_DANYUAN_LISHIRepository==null)
					iWUFENG_DANYUAN_LISHIRepository= new WUFENG_DANYUAN_LISHIRepository();
				return iWUFENG_DANYUAN_LISHIRepository;
			}
			set
			{
				iWUFENG_DANYUAN_LISHIRepository= value;
			}
		}
		#endregion

		#region 620 数据接口 IWUFENG_DAOCHARepository
		IWUFENG_DAOCHARepository iWUFENG_DAOCHARepository;
		public IWUFENG_DAOCHARepository IWUFENG_DAOCHARepository
		{
		 
			get 
			{
				if(iWUFENG_DAOCHARepository==null)
					iWUFENG_DAOCHARepository= new WUFENG_DAOCHARepository();
				return iWUFENG_DAOCHARepository;
			}
			set
			{
				iWUFENG_DAOCHARepository= value;
			}
		}
		#endregion

		#region 621 数据接口 IWUFENG_JILURepository
		IWUFENG_JILURepository iWUFENG_JILURepository;
		public IWUFENG_JILURepository IWUFENG_JILURepository
		{
		 
			get 
			{
				if(iWUFENG_JILURepository==null)
					iWUFENG_JILURepository= new WUFENG_JILURepository();
				return iWUFENG_JILURepository;
			}
			set
			{
				iWUFENG_JILURepository= value;
			}
		}
		#endregion

		#region 622 数据接口 IWUFENG_XIANMINGRepository
		IWUFENG_XIANMINGRepository iWUFENG_XIANMINGRepository;
		public IWUFENG_XIANMINGRepository IWUFENG_XIANMINGRepository
		{
		 
			get 
			{
				if(iWUFENG_XIANMINGRepository==null)
					iWUFENG_XIANMINGRepository= new WUFENG_XIANMINGRepository();
				return iWUFENG_XIANMINGRepository;
			}
			set
			{
				iWUFENG_XIANMINGRepository= value;
			}
		}
		#endregion

    }

}