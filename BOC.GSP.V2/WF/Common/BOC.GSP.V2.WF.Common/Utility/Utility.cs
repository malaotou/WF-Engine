using BOC.GSP.V2.WF.Common.Models;
using BOC.GSP.V2.WF.Common.Variable;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace BOC.GSP.V2.WF.Common.Utility
{
    public static class Utility
    {
        static Utility()
        {
            Applications = new ConcurrentDictionary<int, ApplicationInformation>();
        }
        public static string SqlWorkflowInstanceStore
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["SqlWorkflowInstanceStore"].ConnectionString;
            }
        }
        /// <summary>
        /// 全部外部系统信息
        /// 此字典在此字典在Service.GSPWF启动时初始化
        /// 全局变量
        /// </summary>
        public static ConcurrentDictionary<int, ApplicationInformation> Applications
        {
            get;
            private set;
        }
        public static string ConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["GSPWFConnection"].ConnectionString;
            }
        }

        /// <summary>
        /// Json String To Entity
        /// </summary>
        /// <typeparam name="T">需要反序列化的类</typeparam>
        /// <param name="Json">Json String</param>
        /// <returns></returns>
        public static T SerializToEntity<T>(string Json)
        {
            try
            {
                StringReader sReader = new StringReader(Json);
                JsonReader jsonReader = new JsonTextReader(sReader);
                JsonSerializer jsonserializer = new JsonSerializer();
                T dbPara = jsonserializer.Deserialize<T>(jsonReader);
                return dbPara;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        /// <summary>
        /// 实体序列化为Json String
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="instance">实例</param>
        /// <returns></returns>
        public static string SerializToJson<T>(this T instance)
        {
            try
            {
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(T));
                using (MemoryStream ms = new MemoryStream())
                {
                    js.WriteObject(ms, instance);
                    ms.Flush();
                    ms.Seek(0, SeekOrigin.Begin);
                    StreamReader sr = new StreamReader(ms);
                    return sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                return String.Empty;
            }
        }

        public async static Task<List<String>> CallFunction(FunctionCallPara para)
        {
            var businessData = para.BusinessData;
            var configData = para.ConfigData;
            JObject bData = JObject.Parse(businessData);
            JObject cData = JObject.Parse(configData);



            //HttpRequestMessage request = new HttpRequestMessage();
            //MediaTypeFormatter[] formatter = new MediaTypeFormatter[] { new JsonMediaTypeFormatter() };

            //var content = request.CreateContent<Customer>(obj, MediaTypeHeaderValue.Parse("application/json"), formatter, new FormatterSelector());
            //HttpResponseMessage response = client.PostAsync(this.url, content).Result;
            //return response.Content.ToString();

            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            //client.BaseAddress = new Uri(System.Configuration.ConfigurationManager.AppSettings[""]);
            //HttpContent content=new Form
            HttpResponseMessage response = await client.PostAsJsonAsync("api/products", para);
            return null;
        }
        public static string SerializeToString(dynamic data)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(data);
        }
        public static void ProcessJTokent(JToken configToken, JObject dataObject, ref JToken configCopy)
        {
            if (configToken.Children().Count() > 0)
            {
                foreach (var item in configToken)
                {
                    if (item.Children().Count() > 0)
                    {
                        ProcessJTokent(item, dataObject, ref configCopy);
                    }
                    else
                    {
                        JToken t = dataObject.SelectToken(item.Path);
                        // Find the ConfigPath
                        var configPath = item.ToObject<string>();
                        // Find the Value
                        if (configPath.StartsWith("@"))
                        {
                            var dataValue = dataObject.SelectToken(configPath.Substring(1));
                            configCopy.SelectToken(item.Path).Replace(JToken.FromObject(dataValue.ToObject<string>()));
                        }

                    }
                }
            }
            else
            {
                //Find the Config Path
                var configPath = configToken.ToObject<string>();
                if (configPath.StartsWith("@"))
                {
                    // Find the value
                    var dataValue = dataObject.SelectToken(configPath.Substring(1));
                    configCopy.SelectToken(configToken.Path).Replace(JToken.FromObject(dataValue.ToObject<string>()));
                }

            }

        }

    }
}
