using BOC.GSP.V2.WF.Common.Utility;
using BOC.GSP.V2.WF.Common.Variable;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.EntityFramework.Plus;

namespace BOC.GSP.V2.WF.DAL.Service
{
    public class WFService
    {
        private WFEntities conn;
        public WFService() : base()
        {
            conn = new WFEntities();

        }

        /// <summary>
        /// 创建任务
        /// </summary>
        /// <param name="task">Task信息</param>
        /// <returns></returns>
        public int CreateTask(Task task)
        {
            conn.Tasks.Add(task);
            return conn.SaveChanges();
        }
        public WFInstance GetWFInstance(Guid? wfInstanceId)
        {
            return conn.WFInstances.Where(item => item.Id == wfInstanceId).First();
        }

        public void UpdateTaskStatus(Guid taskId, byte newStatus)
        {
            conn.Tasks.Where(t => t.Id == taskId).Update(x => new Task() { Status = newStatus });
        }

        public void UpdateTaskResult(Guid taskId, string result)
        {
            conn.Tasks.Where(t => t.Id == taskId).Update(x => new Task()
            {
                Result = result
            });
        }


        public Task GetTaskById(Guid taskId)
        {
            return conn.Tasks.First(item => item.Id == taskId);
        }




        /// <summary>
        /// 在首签生效模式下，取消其其他人的
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="taskid"></param>
        public void CancelOtherTask(Guid? parentId, Guid taskid)
        {
            conn.Tasks.Where(t => t.ParentId.Value.Equals(parentId.Value)
                                    && t.Id != taskid
                                    && t.Status != 3)
                                    .Update(x => new Task() { Status = 4 });
        }

        /// <summary>
        /// 用于并行审批检查所有节点审批完成
        /// </summary>
        /// <param name="parentid">相同父节点</param>
        /// <returns></returns>
        public bool isAllParallTaskFinish(Guid? parentid)
        {
            var tasks = conn.Tasks.Where(t => t.ParentId.Value == parentid && t.Status != 3);
            if (tasks.Count() == 0)
            {
                return true;
            }
            else return false;
        }

        public void UndoMyTask(Guid? taskid, string userid)
        {

        }

        /// <summary>
        /// 获取我的任务信息
        /// </summary>
        /// <param name="taskid">任务编号</param>
        /// <param name="userid">用户ID</param>
        /// <returns></returns>
        public async Task<Task> GetMyPendingTask(Guid? taskid, string userid)
        {

            if (taskid == null)
            {
                return await conn.Tasks.Where(t => t.Id == taskid.Value && t.UserId == userid)
                                            .DeferredFirstOrDefault().ExecuteAsync();
            }
            else
            {
                return await conn.Tasks.Where(t => t.UserId == userid)
                                            .DeferredFirstOrDefault().ExecuteAsync();
            }

        }

        /// <summary>
        /// 获取子任务，有上一操作人创建的任务
        /// </summary>
        /// <param name="taskid"></param>
        /// <returns></returns>
        public List<Task> GetChildTaskByTaskId(Guid taskid)
        {
            return conn.Tasks.Where(item => item.ParentId == taskid).ToList();
        }

        /// <summary>
        /// 获取流程实例信息
        /// </summary>
        /// <param name="taskid">任务ID</param>
        /// <param name="wfInstanceid">实例ID</param>
        /// <param name="userid">用户ID</param>
        /// <returns></returns>
        public async Task<WFInstance> GetWFInstance(Guid? taskid, Guid? wfInstanceid, string userid)
        {

            //根据流程实例ID查询
            if (taskid == null && wfInstanceid != null)
            {
                return await conn.WFInstances.Where(inst => inst.Id == wfInstanceid).DeferredFirst().ExecuteAsync();
            }
            //综合双键查询
            else if (taskid != null && wfInstanceid != null)
            {
                return await conn.WFInstances.Where(wf => wf.Id == wfInstanceid && wf.Id == (conn.Tasks.Where(t => t.Id == taskid).First().WFInstanceId)).DeferredFirst().ExecuteAsync();
            }
            //Task id 查询
            else if (taskid != null && wfInstanceid == null)
            {
                return await conn.WFInstances.Where(wf => wf.Id == (conn.Tasks.Where(t => t.Id == taskid).First().WFInstanceId)).DeferredFirst().ExecuteAsync();
            }
            return null;
        }


        /// <summary>
        /// Undo 并签
        /// </summary>
        /// <returns></returns>
        public void UndoParallel(Task task, string userid)
        {
            // 判断是否是最后人，走不同的处理逻辑
            if (IsLastApprover(task, userid))
            {
                // WorkFlowHelper.
            }


        }
        /// <summary>
        /// Undo 首签
        /// </summary>
        /// <param name="taskid"></param>
        /// <returns></returns>
        public void UndoPickFirst(Task task)
        {

        }
        /// <summary>
        /// Undo 顺签
        /// </summary>
        /// <param name="taskid"></param>
        /// <returns></returns>
        public void UndoFlowAlone(Task task)
        {

        }

        private bool IsLastApprover(Task taskinfo, string userid)
        {
            //检索存在多少未处理任务
            var records = conn.Tasks.Where(item => item.WWFActivityId == taskinfo.WWFActivityId && item.Status != 3 && item.WFInstanceId == taskinfo.WFInstanceId);
            //多个任务未处理，则定不是最后一人
            if (records.Count() > 1)
            {
                return false;
            }
            //单人，判定人信息为当前操作人。
            else if (records.Count() == 1)
            {
                if (records.ToArray()[0].UserId == userid)
                {
                    return true;
                }
            }
            return false;
        }


        public List<GetApplicationList_Result> getApplicationInfo()
        {

            ObjectResult<GetApplicationList_Result> resultList = conn.GetApplicationList();
            List<GetApplicationList_Result> rtn = (from r in resultList select r).ToList();
            return rtn;
            //list = (from a in resultlist select a).Tolist();
        }

        public void GetUnstartedFlow(ConcurrentQueue<WFInfo> Queue)
        {
            ObjectResult<GetUnstartedFlow_Result> result = conn.GetUnstartedFlow(Environment.MachineName, Utility.BatchCount);
            result.ToList().ForEach(item =>
            {
                Queue.Enqueue(new WFInfo()
                {
                    AppUserId = item.AppUserId,
                    Parameter = item.Parameter,
                    WFDefineContent = item.Content,
                    ApplicationId = item.ApplicationId,
                    WFInstanceId = item.Id,
                    WFDefineId = item.WFDefineId,
                    WFLocalAssemblyFilePath = item.WFLocalAssemblyFilePath
                });
            });
        }

        public void GetWaitTask(ConcurrentQueue<TaskInfo> Queue)
        {
            ObjectResult<GetWaitTask_Result> result = conn.GetWaitTask(Environment.MachineName, Utility.BatchCount);
            result.ToList().ForEach(item =>
            {
                Queue.Enqueue(new TaskInfo()
                {
                    AppUserId = item.TaskAppGroupId,
                    AppGroupId = item.TaskAppGroupId,
                    ApplicationId = item.ApplicationId,
                    Bookmark = item.Bookmark,
                    Parameter = item.TaskParameter,
                    Result = item.Result,
                    WFInstanceId = item.WFInstanceId,
                    TaskId = item.TaskId,
                    Instance = new WFInfo()
                    {
                        AppUserId = item.AppUserId,
                        AppGroupId = item.AppGroupId,
                        ApplicationId = item.ApplicationId,
                        Parameter = item.Parameter,
                        WFDefineContent = item.WFDefineContent,
                        WFApplicationId = item.WWFApplicationId.Value,
                        WFInstanceId = item.WFInstanceId,
                        WFDefineId = item.WFDefineId,
                        WFLocalAssemblyFilePath = item.WFLocalAssemblyFilePath
                    },
                    RetryTimes = 0,
                    ScheduleTime = DateTime.Now
                });
            });
        }

        public void GetWorkflowResume(ConcurrentQueue<TaskInfo> Queue)
        {
            ObjectResult<GetWorkflowResume_Result> result = conn.GetWorkflowResume(Environment.MachineName, Utility.BatchCount);
            result.ToList().ForEach(item =>
            {
                Queue.Enqueue(new TaskInfo()
                {
                    Instance = new WFInfo()
                    {
                        AppUserId = item.AppUserId,
                        AppGroupId = item.AppGroupId,
                        ApplicationId = item.ApplicationId,
                        Parameter = item.Parameter,
                        WFDefineContent = item.WFDefineContent,
                        WFApplicationId = item.WWFApplicationId.Value,
                        WFDefineId = item.WFDefineId,
                        WFInstanceId = item.WFInstanceId,
                        WFLocalAssemblyFilePath = item.WFLocalAssemblyFilePath,
                    },
                    AppUserId = item.TaskAppUserId,
                    AppGroupId = item.TaskAppGrouId,
                    ApplicationId = item.TaskApplicationId,
                    Bookmark = item.Bookmark,
                    Parameter = item.TaskParameter,
                    // Result = reader["Result"].ToString(),
                    WFInstanceId = item.WFInstanceId,
                    RetryTimes = 0,
                    ScheduleTime = DateTime.Now
                });
            });

        }

        public void MarkWorkflowComplete(Guid wwfApplicationId)
        {
            conn.MarkWorkflowComplete(wwfApplicationId);
        }
        public void UpdateWWFApplicationId(Guid wfInstanceId, Guid wfApplicationId)
        {
            conn.UpdateWWFApplicationId(wfInstanceId, wfApplicationId);
        }
    }
}