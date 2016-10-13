using BOC.GSP.V2.WF.Common.Models;
using BOC.GSP.V2.WF.Common.Utility;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BOC.GSP.V2.WF.WCFService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    public class FunctionCallService : IFunctionCallService
    {
        public string[] CallFunction(FunctionCallPara para)
        {

            // 参数空，返回错误-待处理
            if (para != null)
            {
                if (!string.IsNullOrEmpty(para.BusinessData) && !string.IsNullOrEmpty(para.ConfigData))
                {
                    JObject businessData = JObject.Parse(para.BusinessData);
                    JObject config = JObject.Parse(para.ConfigData);
                    //if (!string.IsNullOrEmpty(para.RuntimeData)){
                    //    JObject runtimePara = JObject.Parse(para.RuntimeData);
                    //}


                    JToken functionName = config.GetValue("functionName");


                    JToken functionPara = config.GetValue("parameter");


                    JToken newToken = JObject.FromObject(functionPara);
                    var realFunctionPara = newToken.DeepClone();
                    Utility.ProcessJTokent(newToken, businessData, ref realFunctionPara);
                    var a = realFunctionPara;

                    var approvers = typeof(FunctionCallService).GetMethod(functionName.Value<string>()).Invoke(null, new[] { realFunctionPara.ToString() });
                    return ((List<string>)approvers).ToArray();
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

        public static List<string> GetApprover(string JsonString)
        {

            List<string> approvers = new List<string>();
            approvers.Add("U1");
            approvers.Add("U2");
            approvers.Add("U3");
            return approvers;
        }

    }
}
