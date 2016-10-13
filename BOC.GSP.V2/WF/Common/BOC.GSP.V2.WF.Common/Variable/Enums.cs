using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOC.GSP.V2.WF.Common.Variable
{
    public enum Status
    {
        Error = 0,
        Sucess = 1,
        Warn = 2
    }
    /// <summary>
    /// 处理类型
    /// </summary>
    public enum PickType
    {
        /// <summary>
        /// 顺签
        /// </summary>
        Parallel = 0,
        /// <summary>
        /// 一签生效
        /// </summary>
        PickFirst = 1,
        /// <summary>
        /// 并签
        /// </summary>
        FlowAlone = 2
    }

    public enum FlowType
    {
        /// <summary>
        /// 并签
        /// </summary>
        Parallel = 0,
        /// <summary>
        /// 一签生效
        /// </summary>
        PickFirst = 1,
        /// <summary>
        /// 顺签
        /// </summary>
        FlowAlone = 2
    }

    public enum HandleType
    {
        /// <summary>
        /// 审批拒绝不通过
        /// </summary>
        Deny = 0,

        /// <summary>
        /// 审批通过/下一步
        /// </summary>
        Submit = 1,

        /// <summary>
        /// 发起人取消流程发起
        /// </summary>
       // Cancel = 3,

        /// <summary>
        /// 撤销上次操作，重来。
        /// 如果一人一个节点，则返回自己节点。
        /// 如果是会签节点，则返回自己处理结果内容，重新审批。
        /// </summary>
        //Undo = 2
    }

    public enum WFStatus
    {
        // 初始化
        Init = 0,
        // 处理中
        Processing = 1,
        // 处理完成
        Finished = 2,
        // 取消
        Canceled = 3,
        // 暂停
        Paused = 4

    }
}
