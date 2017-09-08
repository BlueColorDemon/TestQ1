using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace IQGT_Web.Utils
{
    public class CommonJson
    {
        /// <summary>
        ///  用camel命名法 转化为JSON数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string camelJson(object model)
        {
            var setting = new JsonSerializerSettings() { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            string result = JsonConvert.SerializeObject(model, new JsonSerializerSettings() { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            return result;
        }

        /// <summary>
        ///  用camel命名法 转化对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static object camelObject(object model)
        {
            string json = CommonJson.camelJson(model);
            var result = JsonConvert.DeserializeObject(json);

            return result;
        }

        /// <summary>
        /// 用camel命名法 ActionResult
        /// </summary>
        public class JsonCamelCaseResult : ActionResult
        {
            public JsonCamelCaseResult(object data, JsonRequestBehavior jsonRequestBehavior)
            {
                Data = data;
                JsonRequestBehavior = jsonRequestBehavior;
            }

            public Encoding ContentEncoding { get; set; }

            public string ContentType { get; set; }

            public object Data { get; set; }

            public JsonRequestBehavior JsonRequestBehavior { get; set; }

            public override void ExecuteResult(ControllerContext context)
            {
                if (context == null)
                {
                    throw new ArgumentNullException("context");
                }
                if (JsonRequestBehavior == JsonRequestBehavior.DenyGet && String.Equals(context.HttpContext.Request.HttpMethod, "GET", StringComparison.OrdinalIgnoreCase))
                {
                    throw new InvalidOperationException("This request has been blocked because sensitive information could be disclosed to third party web sites when this is used in a GET request. To allow GET requests, set JsonRequestBehavior to AllowGet.");
                }

                var response = context.HttpContext.Response;

                response.ContentType = !String.IsNullOrEmpty(ContentType) ? ContentType : "application/json";
                if (ContentEncoding != null)
                {
                    response.ContentEncoding = ContentEncoding;
                }
                if (Data == null)
                    return;

                var jsonSerializerSettings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };
                response.Write(JsonConvert.SerializeObject(Data, jsonSerializerSettings));
            }
        }


    }
}
