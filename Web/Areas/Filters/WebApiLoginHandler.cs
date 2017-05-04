using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Common;
using Model;
using Web.Areas.Models;

namespace Web.Areas.Filters
{
    public class WebApiLoginHandler : DelegatingHandler
    {

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            int matchHeaderCount = request.Headers.Count((item) =>
           {
               if ("keyword".Equals(item.Key))
               {
                   foreach (var str in item.Value)
                   {
                       if ("SxSh".Equals(str))
                       {
                           return true;
                       }
                   }
               }
               return false;
           });
            if (matchHeaderCount > 0)
            {
                return base.SendAsync(request, cancellationToken);
            }
            else
            {
                if (!Model_SYS_USER.IsLogin())
                {
                    AjaxMsgModel amm = new AjaxMsgModel
                    {
                        BackUrl = "/Home/Login?msg=noLogin",
                        Data = null,
                        Msg = Message.NotLogin,
                        Statu = AjaxStatu.nologin
                    };
                    var response = request.CreateResponse(System.Net.HttpStatusCode.OK, amm);
                    //var response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
                    var task = new TaskCompletionSource<HttpResponseMessage>();
                    task.SetResult(response);
                    return task.Task;
                }
                return base.SendAsync(request, cancellationToken);
            }
        }

    }
}