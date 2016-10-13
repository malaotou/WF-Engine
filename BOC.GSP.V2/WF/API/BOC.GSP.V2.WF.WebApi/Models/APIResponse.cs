using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BOC.GSP.V2.WF.WebApi.Models
{
    public class APIResponse
    {
        public APIResponse()
        {
            this.status = 1;
        }
        private int status;
        private string message;

        /// <summary>0 为正常，1 为异常。
        /// </summary>
        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        /// <summary>
        /// 异常消息内容
        /// </summary>
        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        /// <summary>
        /// 返回消息信息
        /// </summary>
        public dynamic body
        {
            get;
            set;

        }

    }
}