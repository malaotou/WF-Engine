using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using BOC.GSP.V2.WF.Common.Variable;
using BOC.GSP.V2.WF.DAL.Repository;
using BOC.GSP.V2.WF.Common.Models;
using BOC.GSP.V2.WF.Common.Utility;

namespace BOC.GSP.V2.WF.Engine.Act
{

    public sealed class InitiatorAct : CodeActivity
    {
        // 定义一个字符串类型的活动输入参数
        public InOutArgument<ActivityPara> activityPara { get; set; }

        // 如果活动返回值，则从 CodeActivity<TResult>
        // 并从 Execute 方法返回该值。
        protected override void Execute(CodeActivityContext context)
        {
            ActivityPara para = activityPara.Get<ActivityPara>(context);
            try
            {
                //获取运行时信息
                var runTimeInfo = context.GetExtension<InstanceRunTimeInfo>();
                var currentActivity = ActivityRepository.GetActivityByTypeCode(para.ActType, para.ProcessID);
                para.ActId = currentActivity.ID;

                #region 处理Body
                string businessData = para.Body;

                #endregion


                //默认处理下一节点，否则处理拒绝/退回节点
                int actionType = 1;
                if (para.Action != null)
                {
                    if (para.Action.Value == 0)
                    {
                        actionType = 0;
                    }
                }
                //获取下一节点数据；
                var nextActivity = ActivityRepository.GetNextActivityByActivityId(currentActivity.ID, para.ProcessID, actionType);
                List<NextActivity> acts = new List<NextActivity>();
                Guid workId = Guid.NewGuid();
                //用于处理多节点流程问题，或去以下所有节点。
                if (nextActivity.Count > 0)
                {
                    foreach (Common.Models.Activity act in nextActivity)
                    {
                        NextActivity activity = new NextActivity();
                        activity.NextActId = act.ID;
                        activity.NextActName = act.ActivityName;
                        activity.NextActExecType = activity.NextActExecType;
                        activity.ApproveType = activity.ApproveType;
                        acts.Add(activity);
                    }
                    para.NextAct = acts;
                    para.ParentId = workId;
                }

                Guid instanceId = Guid.NewGuid();
                runTimeInfo.ProcessId = para.ProcessID;
                // 发起节点
                if (para.ActType == 1)
                {
                    instanceId = Guid.NewGuid();
                    runTimeInfo.InstanceId = instanceId;
                    para.ProcessInstanceId = instanceId;
                }
                else
                {
                    instanceId = runTimeInfo.InstanceId;
                }
                ProcessRepository.CreateProcessInstance(new ProcesssInstance
                {
                    ProcessID = para.ProcessID,
                    ProcessInstanceID = instanceId,
                    Initiator = para.ADUser,
                    RuntimeInstanceID = context.WorkflowInstanceId,
                    Status = 1,
                    Title = para.Remark,
                    BusinessData = businessData
                });
                // 用于处理直接分派任务,下一步直接结束处理操作
                if (para.Approvers != null)
                {
                    foreach (string name in para.Approvers)
                    {
                        WorkListRepository.CreateWorkList(new WorkList
                        {
                            CreateTime = DateTime.Now,
                            ActivityID = currentActivity.ActivityID,
                            ActivityInstanceID = this.Id,
                            ProcessID = para.ProcessID,
                            Status = 1,
                            Title = currentActivity.ActivityName,
                            ProcessInstanceID = para.ProcessInstanceId,
                            UserID = name,
                            ParentID = para.ParentId,

                            //BookMark = TaskBookmark,
                            //上一级审批或拒绝信息
                            //Remark = para.Remark,
                            RuntimeInstanceID = context.WorkflowInstanceId,
                            FinishTime = DateTime.Now
                        });
                    }
                }
                //创建发起人的代办任务，并标识为完成。
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
                    ID = workId,
                    //BookMark = TaskBookmark,
                    //上一级审批或拒绝信息
                    Remark = para.Remark,
                    RuntimeInstanceID = context.WorkflowInstanceId,
                    FinishTime = DateTime.Now
                });

                //context.SetValue(activityPara, para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                context.SetValue(activityPara, para);
            }


        }
    }
}
