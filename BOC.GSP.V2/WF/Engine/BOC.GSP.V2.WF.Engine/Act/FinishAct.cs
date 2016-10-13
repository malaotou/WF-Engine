using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using BOC.GSP.V2.WF.Common.Variable;
using BOC.GSP.V2.WF.DAL.Repository;
using BOC.GSP.V2.WF.Common.Models;

namespace BOC.GSP.V2.WF.Engine.Act
{

    public sealed class FinishAct : CodeActivity
    {
        // 定义一个字符串类型的活动输入参数
        public InArgument<ActivityPara> Para { get; set; }

        // 如果活动返回值，则从 CodeActivity<TResult>
        // 并从 Execute 方法返回该值。
        protected override void Execute(CodeActivityContext context)
        {
            //Create Finish Task
            ActivityPara para = Para.Get<ActivityPara>(context);
            var currentActivity = ActivityRepository.GetActivityById(para.ActId, para.ProcessID);
            WorkListRepository.CreateWorkList(new WorkList
            {
                CreateTime = DateTime.Now,
                ActivityID = currentActivity.ActivityID,
                ActivityInstanceID = this.Id,
                ProcessID = para.ProcessID,
                Status = 2,
                Title = currentActivity.ActivityName,
                ProcessInstanceID = para.ProcessInstanceId,
                UserID = para.ADUser,
                ID = Guid.NewGuid(),
                ParentID=para.ParentId,
                //BookMark = TaskBookmark,
                //上一级审批或拒绝信息
                Remark = para.Remark,
                RuntimeInstanceID = context.WorkflowInstanceId,
                FinishTime = DateTime.Now
            });

            ProcessRepository.FinishProcess(para.ProcessInstanceId);


        }
    }
}
