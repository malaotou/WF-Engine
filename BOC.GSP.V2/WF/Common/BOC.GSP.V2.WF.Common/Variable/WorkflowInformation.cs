using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BOC.GSP.V2.WF.Common.Variable
{
    public class WorkflowInformation
    {
        /// <summary>
        /// 发起工作流的应用ID
        /// </summary>
        [DataMember]
        public int ApplicationId { get; set; }
        /// <summary>
        /// 发起工作流的用户ID（在发起流程的应用系统中的Id）
        /// </summary>
        [DataMember]
        public string AppUserId { get; set; }
        /// <summary>
        /// 发起工作流的用户组ID
        /// </summary>
        [DataMember]
        public string AppGroupId { get; set; }
        /// <summary>
        /// 工作流定义ID
        /// </summary>
        [DataMember]
        public Guid WFDefineId { get; set; }

        /// <summary>
        /// 待办任务标题
        /// </summary>
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        /// 工作流实例ID
        /// </summary>
        [DataMember]
        public Guid WFInstanceId { get; set; }
        /// <summary>
        /// 启动工作流的相关参数
        /// </summary>
        [DataMember]
        public string Parameter { get; set; }
        /// <summary>
        /// WorkflowApplication 执行产生的ID
        /// </summary>
        public Guid WFApplicationId { get; set; }

        JObject _JObjParemeter = null;
        public JObject JObjParemeter
        {
            get
            {
                if (_JObjParemeter == null)
                {
                    _JObjParemeter = JObject.Parse(this.Parameter);
                }
                return _JObjParemeter;
            }
        }
    }
}
