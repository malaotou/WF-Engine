using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.Activities.Statements;
using BOC.GSP.V2.WF.Common.Variable;
using System.Activities.DurableInstancing;
using System.Threading;
using BOC.GSP.V2.WF.DAL.Repository;

namespace BOC.GSP.V2.WF.Engine
{
    public static class Instance
    {
        public static bool Run(Dictionary<string, object> para, out string msg)
        {
            bool rtn = true;
            msg = string.Empty;
            try
            {
                var ProcessID = ((ActivityPara)para["para"]).ProcessID;
                var process = ProcessRepository.GetProcessInfo(ProcessID);
                if (process == null)
                {
                    msg = "找不到流程定义 ProcessID：" + ProcessID.ToString();
                    return false;
                }
                WorkflowApplication wfApp = Singleton.GetInstance(para).CreateApp();
                wfApp.Extensions.Add(new InstanceRunTimeInfo { });
                wfApp.Run();
            }
            catch (Exception ex)
            {
                rtn = false;
                msg = "流程发起错误：" + ex.Message;
            }
            return rtn;
        }
        public static bool Continue(ActivityPara para, out string msg)
        {
            bool rtn = true;
            msg = string.Empty;
            try
            {
                //Check 当前流程状态
                var Instance = ProcessRepository.GetProcessInstanceByWorkItemId(para.WorkListid);
                if (Instance == null)
                {
                    msg = "指定的流程不存在：InstanceId:" + Instance.ProcessInstanceID.ToString();
                    return false;
                }
                // 正在运行中
                if (Instance.Status == 1)
                {
                    WorkflowApplication wfApp = Singleton.GetInstance().CreateApp();
                    wfApp.Load(para.RunTimeInstanceId);
                    wfApp.ResumeBookmark("Bookmark_Task", para);
                    wfApp.Persist(new TimeSpan(0, 5, 30));
                    return true;
                }
                // 已经完成
                else if (Instance.Status == 2)
                {
                    rtn = false;
                    msg = "流程已经完成!";
                }
                // 取消
                else if (Instance.Status == 3)
                {
                    rtn = false;
                    msg = "流程已经取消!";
                }
                // 暂停
                else if (Instance.Status == 4)
                {
                    rtn = false;
                    msg = "流程已经暂停!";
                }

            }
            catch (WorkflowApplicationCompletedException ex)
            {
                // 流程已经完成
                rtn = false;
                msg = "流程错误!";
            }
            return rtn;
        }

        /// <summary>
        /// 取消当前工作流
        /// </summary>
        /// <param name="para">取消参数</param>
        /// <param name="msg">返回处理消息，错误消息</param>
        /// <returns>成功失败标识</returns>
        public static bool Cancel(ActivityPara para, out string msg)
        {
            bool rtn = true;
            msg = string.Empty;
            try
            {
                var Instance = ProcessRepository.GetProcessInstance(para.ProcessInstanceId);
                if (Instance == null)
                {
                    msg = "指定的流程不存在：InstanceId:" + para.ProcessInstanceId.ToString();
                    return false;
                }
                if (Instance.Status == (int)WFStatus.Processing)
                {
                    ProcessRepository.UpdateInstanceStatus(para.ProcessInstanceId, (int)WFStatus.Canceled);
                    WorkflowApplication wfApp = Singleton.GetInstance().CreateApp();
                    wfApp.Cancel();
                }
                else if (Instance.Status == (int)WFStatus.Canceled)
                {
                    rtn = false;
                    msg = "流程已经取消!";
                }
                else if (Instance.Status == (int)WFStatus.Finished)
                {
                    rtn = false;
                    msg = "流程已经结束!";
                }
                else if (Instance.Status == (int)WFStatus.Paused)
                {
                    rtn = false;
                    msg = "流程已经暂停!";
                }
            }
            catch (Exception ex)
            {
                msg = "流程处理错误!";
            }

            return rtn;

        }
        /// <summary>
        /// 暂停工作流
        /// </summary>
        /// <param name="wfid"></param>
        public static bool Pause(ActivityPara para, out string msg)
        {
            bool rtn = true;
            msg = string.Empty;

            try
            {
                var Instance = ProcessRepository.GetProcessInstance(para.ProcessInstanceId);
                if (Instance == null)
                {
                    msg = "指定的流程不存在：InstanceId:" + para.ProcessInstanceId.ToString();
                    return false;
                }
                if (Instance.Status == (int)WFStatus.Processing)
                {
                    ProcessRepository.UpdateInstanceStatus(para.ProcessInstanceId, (int)WFStatus.Paused);
                }
                else if (Instance.Status == (int)WFStatus.Canceled)
                {
                    rtn = false;
                    msg = "流程已经取消!";
                }
                else if (Instance.Status == (int)WFStatus.Finished)
                {
                    rtn = false;
                    msg = "流程已经结束!";
                }
                else if (Instance.Status == (int)WFStatus.Paused)
                {
                    msg = "流程已经暂停!";
                }
            }
            catch (Exception ex)
            {
                rtn = false;
                msg = "流程处理错误!";
            }
            return rtn;
        }
        /// <summary>
        /// 继续暂停的工作流
        /// </summary>
        /// <param name="wfid"></param>
        public static bool Resume(ActivityPara para, out string msg)
        {
            bool rtn = true;
            msg = string.Empty;
            try
            {
                var Instance = ProcessRepository.GetProcessInstance(para.ProcessInstanceId);
                if (Instance == null)
                {
                    msg = "指定的流程不存在：InstanceId:" + para.ProcessInstanceId.ToString();
                    return false;
                }
                if (Instance.Status == (int)WFStatus.Paused)
                {
                    ProcessRepository.UpdateInstanceStatus(para.ProcessInstanceId, (int)WFStatus.Processing);
                }
                else if (Instance.Status == (int)WFStatus.Canceled)
                {
                    rtn = false;
                    msg = "流程已经取消!";
                }
                else if (Instance.Status == (int)WFStatus.Finished)
                {
                    rtn = false;
                    msg = "流程已经结束!";
                }
                else if (Instance.Status == (int)WFStatus.Processing)
                {
                    msg = "流程已经恢复!";
                }
            }
            catch (Exception ex)
            {
                rtn = false;
                msg = "流程处理错误!";
            }
            return rtn;
        }
    }
}
