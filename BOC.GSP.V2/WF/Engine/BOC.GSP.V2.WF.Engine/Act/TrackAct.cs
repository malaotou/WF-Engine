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

    public sealed class TrackAct : CodeActivity
    {
        // 定义一个字符串类型的活动输入参数
        public InArgument<ActivityPara> Para { get; set; }

        // 如果活动返回值，则从 CodeActivity<TResult>
        // 并从 Execute 方法返回该值。
        protected override void Execute(CodeActivityContext context)
        {
            // 获取 Text 输入参数的运行时值
            //string text = context.GetValue(this.Text);
            ActivityPara taskPara = Para.Get<ActivityPara>(context);
            // 获得当前的Activity
            var currentActivity = ActivityRepository.GetActivityById(taskPara.ActId, taskPara.ProcessID);

            //创建 Activity 记录
            ActivityRepository.CreateTrack(new ActivityTracking {
                ActivityID= currentActivity.ActivityID,
                ProcessID=taskPara.ProcessID,
                ProcessInstanceID=taskPara.ProcessInstanceId
            });
        }
    }
}
