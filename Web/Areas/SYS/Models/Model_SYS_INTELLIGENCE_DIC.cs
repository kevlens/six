using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.ModelExt;
using SxShWeb.Areas.ViewModels;


namespace SxShWeb.Areas.Models
{
    public partial class Model_SYS_INTELLIGENCE_DIC
    {
        #region 获取资质
        public static List<VIEW_SYS_INTELLIGENCE_DIC> GetIntelligenceDic()
        {
            return oc.BllSession.ISYS_INTELLIGENCE_DICService.Entities.OrderBy(u => u.DIC_ORDER)
                .Select(u=>new VIEW_SYS_INTELLIGENCE_DIC { 
                  DIC_ID=u.DIC_ID,
                  DIC_NAME=u.DIC_NAME
                }).ToList();
        }
        #endregion
    }
}