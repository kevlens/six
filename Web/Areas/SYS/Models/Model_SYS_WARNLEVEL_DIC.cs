using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.ModelExt;
using SxShWeb.Areas.ViewModels;

namespace SxShWeb.Areas.Models
{
    public partial class Model_SYS_WARNLEVEL_DIC
    {
        public static List<VIEW_SYS_WARNLEVEL_DIC> GetWarnLevelDic()
        {
            return oc.BllSession.ISYS_WARNLEVEL_DICService.Entities.OrderBy(u => u.DIC_ORDER)
                .Select(u => new VIEW_SYS_WARNLEVEL_DIC
                {
                    DIC_ID = u.DIC_ID,
                    DIC_NAME = u.DIC_NAME
                }).ToList();
        }
    }
}