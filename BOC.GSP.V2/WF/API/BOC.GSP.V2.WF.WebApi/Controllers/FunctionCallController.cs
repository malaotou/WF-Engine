using BOC.GSP.V2.WF.Common.Models;
using BOC.GSP.V2.WF.Common.Utility;
using BOC.GSP.V2.WF.WebApi.Helper;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BOC.GSP.V2.WF.WebApi.Controllers
{
    [RoutePrefix("api/functionCall")]
    public class FunctionCallController : ApiController
    {
        /// <summary>
        ///  通过动态解析执行相关的方法，并获取相关用户数据。
        /// </summary>
        /// <param name="data">业务数据-JSON</param>
        /// <param name="para">通过配置生成的系统参数-JSON</param>
        /// <param name="para2">流程运行参数，如发起人等-JSON</param>
        /// <returns></returns>
        [Route("run")]
        [HttpPost]
        public HttpResponseMessage DynamicFunctionCall(FunctionCallPara para)
        //[FromBody]string businessdata, [FromBody]string configPara, [FromBody]string processPara)
        {
            try
            {
                // 参数空，返回错误-待处理
                JObject businessData = JObject.Parse(para.BusinessData);
                JObject config = JObject.Parse(para.ConfigData);
                JObject runtimePara = JObject.Parse(para.RuntimeData);
                JToken functionName = config.GetValue("functionName");
                JToken functionPara = config.GetValue("parameter");
                var realFunctionPara = functionPara.DeepClone();
                Utility.ProcessJTokent(functionPara, businessData, ref realFunctionPara);
                var approvers = typeof(RemoteAPIFunctionCallHelper).GetMethod(functionName.Value<string>()).Invoke(null, new[] { realFunctionPara.ToString(), "" });
                if (approvers != null)
                {
                    if (((List<String>)approvers).Count == 0)
                    {
                        //返回错误
                        HttpError err = new HttpError("未找到审批人!");
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, err);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, (List<String>)approvers);
                    }
                }
                else
                {
                    //返回错误
                    HttpError err = new HttpError("未找到审批人!");
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, err);
                }

            }
            catch (Exception ex)
            {
                HttpError err = new HttpError("获取审批人发生错误!");
                return Request.CreateResponse(HttpStatusCode.InternalServerError, err);
            }
        }
    }
}
