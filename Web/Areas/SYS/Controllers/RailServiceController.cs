using Common;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace SxShWeb.Areas.SYS.Controllers
{
    public class RailServiceController : ApiController
    {
        //
        // GET: /SYS/RailService/
        #region UI层与Service之间操作的上下文
        protected OperContext oc = OperContext.CurrentContext;
        #endregion

        //[HttpPost]
        //public async Task AddRailDeviceStatus(RAIL_DEVICE device)
        //{
        //    try
        //    {
        //        // RAIL_DEVICE model = oc.
        //        oc.BllSession.IRAIL_DEVICEService.AddEntity(device);
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

    }
}
