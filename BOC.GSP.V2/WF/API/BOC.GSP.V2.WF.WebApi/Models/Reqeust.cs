using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BOC.GSP.V2.WF.WebApi.Models
{
    public class Reqeust
    {
        // 获取的代办任务ID
        public Guid? WorkListId { get; set; }

        public Guid? ProcessId { get; set; }
        public Guid? InstanceId { get; set; }

        // 执行的用户信息，暂时从接口获取
        public string UserId { get; set; }

        // 执行的指令,自动模式
        public string Command { get; set; }

        // 1 同意进入下一步，不同意，返回上一步。
        public int Action { get; set; }


        #region 手动指定信息
        //手工指定审批人信息
        public List<String> Approvers { get; set; }

        //手工指定执行路径，手工模式
        public string Line { get; set; }

        public string Remark { get; set; }

        public bool isManual { get; set; }

        public dynamic Body { get; set; }
        #endregion


    }
}