using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace BOC.GSP.V2.WF.WebApi.Helper
{
    public static class HttpHelper
    {
        public static HttpError Response(string message)
        {
            HttpError err = new HttpError(message);
            return err;
        }
    }
}