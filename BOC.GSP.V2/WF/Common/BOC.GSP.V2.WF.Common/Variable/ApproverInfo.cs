using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOC.GSP.V2.WF.Common.Variable
{
    public class ApproverInfo
    {
        /// <summary>
        /// 审批人顺序Id
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 审批人的唯一标识
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 用户角色
        /// </summary>
        public string Role { get; set; }

        //处理状态
        public bool FinishStatus { get; set; }
    }
}
