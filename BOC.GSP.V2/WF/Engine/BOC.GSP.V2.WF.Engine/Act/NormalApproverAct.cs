using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using BOC.GSP.V2.WF.Common.Variable;
using BOC.GSP.V2.WF.DAL.Repository;
using BOC.GSP.V2.WF.Common.Models;
using System.Web;
using System.Net;
using BOC.GSP.V2.WF.Common.Utility;

namespace BOC.GSP.V2.WF.Engine.Act
{

    public sealed class NormalApproverAct : NativeActivity
    {
        const string Bookmark = "Bookmark_Task";
        // 定义一个字符串类型的活动输入参数
        public InArgument<ActivityPara> Para { get; set; }

        /// <summary>
        /// 获取或设置一个值，该值指示活动是否会使工作流进入空闲状态
        /// </summary>
        protected override bool CanInduceIdle
        {
            get
            {
                return true;
            }
        }
        protected override async void Execute(NativeActivityContext context)
        {
            ActivityPara para = Para.Get<ActivityPara>(context);
            var runTimeInfo = context.GetExtension<InstanceRunTimeInfo>();
            var currentActivity = ActivityRepository.GetActivityById(para.ActId, para.ProcessID);
            para.ActType = currentActivity.ActType.Value;
            var currentProcess = ProcessRepository.GetProcessInstance(para.ProcessInstanceId);
            int actionType = 1;
            if (para.Action != null)
            {
                if (para.Action.Value == 0)
                {
                    actionType = 0;
                }
            }

            //获取下一节点数据；
            var nextActivity = ActivityRepository.GetNextActivityByActivityId(para.ActId, para.ProcessID, actionType);
            
            List<string> Approvers = null;
            //获取当前节点审批人信息
            if (para.Approvers != null)
            {
                Approvers = para.Approvers;
            }
            else
            {
                //审批直接到人
                if (currentActivity.ApproveObjectType == "0")
                {

                }
                //审批直接到角色
                else if (currentActivity.ApproveObjectType == "1")
                {
                    // 暂行方案
                    Approvers = ActivityRepository.GetApprover(currentActivity.ApproveObjectType, currentActivity.ApproveObjectCode);
                }
                else if (currentActivity.ApproveObjectType == "2")
                {
                    //System.Net
                    FunctionCallPara funcationPara = new FunctionCallPara();
                    // 配置数据
                    funcationPara.ConfigData = currentActivity.ApproveObjectCode;
                    // 表单数据
                    funcationPara.BusinessData = currentProcess.BusinessData;
                    // 流程数据暂无处理

                    var url = await Utility.CallFunction(funcationPara);
                }

            }


            List<NextActivity> acts = new List<NextActivity>();
            //更新相关参数
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
            }
            // 并签，或一签生效，顺签逻辑？
            var isEnable = true;

            //非结束节点，否则直接过
            if (currentActivity.ActType != 2)
            {
                foreach (string name in Approvers)
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
                        Remark = para.Remark,
                        RuntimeInstanceID = context.WorkflowInstanceId,
                        //FinishTime = DateTime.Now,
                        BookMark = Bookmark,
                        IsEnable = isEnable
                    });
                    // 设置一个可审批人，暂定随意设置
                    if (currentActivity.ApproveType == 2)
                    {
                        isEnable = false;
                    }
                }
                // 依据规则获取审批人信息
                para.Approvers = null;
                context.CreateBookmark(Bookmark, new BookmarkCallback(BookMarkCallBack), BookmarkOptions.MultipleResume);
            }

        }

        private void BookMarkCallBack(NativeActivityContext context, Bookmark bookmark, object value)
        {
            // 从UserInput 获取参数信息

            //审批当前节点。
            ActivityPara para = Para.Get<ActivityPara>(context);

            // 用户输入参数信息
            ActivityPara userPara = (ActivityPara)value;
            //var id = Guid.NewGuid();
            // 根据任务ID 获取代办任务信息
            var worklist = WorkListRepository.GetWorkListById(userPara.WorkListid);
            para.ParentId = worklist.ID;
            // 获取当前Activity 节点信息
            var currentActivity = ActivityRepository.GetActivityByActivityId(worklist.ActivityID, worklist.ProcessID.Value);
            // 更新代办状态状态为已经处理
            WorkListRepository.UpdateWorkListStatus(new WorkList
            {
                FinishTime = DateTime.Now,
                ID = worklist.ID,
                Remark = para.Remark,
                // 更新人信息需增加。
                Status = 2
            });
            para.Remark = string.Empty;
            //判断客户端操作，如果审批通过，则进入下一环节，否则按照Action 进入Action环节。

            // Action =1 则进入下一环节审批人，否则进入回退处理环节。
            if (userPara.Action.Value == 1)
            {
                // 如顺序，则更新下一审批人代办状态为有效。 顺序
                if (currentActivity.ApproveType == 2)
                {
                    WorkListRepository.CreateNextWrokList(worklist);
                }
                //一签生效
                else if (currentActivity.ApproveType == 0)
                {
                    para.ActionResult = userPara.Action.Value;
                    WorkListRepository.CancelOtherTask(worklist);
                    context.RemoveBookmark(Bookmark);
                }
                //检查所有当前节点是否都已经完成，完成则删除书签，继续执行。
                if (WorkListRepository.IsAllTaskFinish(worklist))
                {
                    para.ActionResult = userPara.Action.Value;
                    context.RemoveBookmark(Bookmark);
                }
            }
            // 审批被拒绝，则ActionResult 确定为拒绝
            else
            {
                para.ActionResult = userPara.Action.Value;
                context.RemoveBookmark(Bookmark);
            }

        }
    }
}
