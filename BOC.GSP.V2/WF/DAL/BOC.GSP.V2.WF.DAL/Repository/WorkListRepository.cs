using BOC.GSP.V2.WF.Common.Models;
using BOC.GSP.V2.WF.Common.Utility;
using Dapper;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOC.GSP.V2.WF.Common.Variable;

namespace BOC.GSP.V2.WF.DAL.Repository
{
    public class WorkListRepository
    {
       

        public static List<WorkList> GetWorkListByUser(string userid, out string res)
        {
            bool rtn = true;
            res = string.Empty;
            var sql = @"select w.*,p.Title as Name from ProcesssInstance p inner join WorkList w
                        on p.ProcessID = w.ProcessID and p.ProcessInstanceID = w.ProcessInstanceID
                        where w.Status =0 and w.userid=@ID";
            using (var conn = Database.DbService())
            {
                return conn.Query<WorkList>(sql, new { ID = userid }).ToList();
            }
        }
        public static void CreateNextWrokList(WorkList worklist)
        {
            var sql = @"UPDATE TOP(1) WorkList
                            SET ISENABLE=1
                            WHERE ProcessID=@ProcessID
                            and ActivityID=@ActivityID
                            and ProcessInstanceID=@ProcessInstanceID
                            and isenable=0";
            using (var conn = Database.DbService())
            {
                conn.Query(sql, new { ProcessID = worklist.ProcessID, ActivityID = worklist.ActivityID, ProcessInstanceID = worklist.ProcessInstanceID });
            }
        }

        public static WorkList GetWorkListById(Guid worklistid)
        {
            var sql = @"select * from WorkList where ID=@Id";
            using (var conn = Database.DbService())
            {
                return conn.Query<WorkList>(sql, new { Id = worklistid }).SingleOrDefault();
            }
        }


        #region 查询方法
        public static WorkList GetMyWorkListbyItemId(string userid, Guid workListId, out string res)
        {
            bool rtn = true;
            res = string.Empty;
            var sql = @"select p.Title as Folio,w.* from WorkList w
                        inner join ProcesssInstance p
                        on w.ProcessInstanceID=p.ProcessInstanceID
                        where w.ID=@ID
                        and w.UserID=@UserID and and w.[status]=1";
            using (var conn = Database.DbService())
            {
                return conn.Query<WorkList>(sql, new { ID = workListId, UserID = userid }).SingleOrDefault();
            }
        }
        public static List<WorkList> GetMyWorkList(string userid, out string res)
        {
            bool rtn = true;
            res = string.Empty;
            var sql = @"select p.Title as Folio,w.* from WorkList w
                        inner join ProcesssInstance p
                        on w.ProcessInstanceID=p.ProcessInstanceID
                        where w.UserID=@UserID and w.[status]=1 and isEnable=1";
            using (var conn = Database.DbService())
            {
                return conn.Query<WorkList>(sql, new { ID = userid, UserID = userid }).ToList();
            }
        }
        #endregion

        public static void CreateWorkList(WorkList worllist)
        {
            try
            {
                using (var conn = Database.DbService())
                {
                    conn.Insert<Guid>(worllist);

                }
            }
            catch (Exception ex) { }

        }
        public static void UpdateWorkListStatus(WorkList worllist)
        {
            try
            {
                using (var conn = Database.DbService())
                {
                    conn.Execute("Update WorkList set Status=2,FinishTime=getdate(),Remark=@Remark Where ID=@ID", worllist);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public static void UpdateWorkListResult(WorkList worllist)
        {
            using (var conn = Database.DbService())
            {
                conn.Execute("Update WorkList set Result=@result Where ID=@ID", worllist);
            }
        }

        public static void CancelOtherTask(WorkList myTask)
        {
            // throw new NotImplementedException();
            //var sql = "Update WorkList Set Status=3 where ActivityId=@aid and processid=@pid and activityInstanceid!=@acid";
            var sql = "Update WorkList Set Status=3 ,CancelTime=getdate() where RuntimeInstanceID=@RuntimeInstanceID and  ID<>@ID and status=1";

            using (var conn = Database.DbService())
            {
                conn.Execute(sql, new { RuntimeInstanceID = myTask.RuntimeInstanceID, ID = myTask.ID });
            }

        }

        public static bool isAllParallTaskFinish(WorkList myTask)
        {
            //throw new NotImplementedException();

            bool rtn = true;
            var sql = "select * from WorkList where processid=@processid and activityid=@activityid and ProcessInstanceID=@ProcessInstanceID and status in (1,0)";
            using (var conn = Database.DbService())
            {
                var result = conn.Query<WorkList>(sql, new { processid = myTask.ProcessID, activityid = myTask.ActivityID, ProcessInstanceID = myTask.ProcessInstanceID });
                if (result.Count() > 0)
                {
                    rtn = false;
                }
            }
            return rtn;
        }

        public static WorkList GetParentItem(WorkList item)
        {
            //throw new NotImplementedException();
            var sql = "select * from Worklist where ID=@id";
            using (var conn = Database.DbService())
            {
                return conn.QueryFirstOrDefault<WorkList>(sql, new { id = item.ParentID });
            }


        }
        public static List<WorkList> GetWorkList()
        {
            //throw new NotImplementedException();
            var sql = @"select p.Title as folio,w.* from WorkList w
                    inner join ProcesssInstance p
                    on w.ProcessInstanceID = p.ProcessInstanceID
                     where w.Status = 1
                    and w.isEnable = 1";
            using (var conn = Database.DbService())
            {
                return conn.Query<WorkList>(sql).ToList();
            }
        }


        public static WorkListRunTimeInfo getRunTimeInfo(Guid wid)
        {
            using (var conn = Database.DbService())
            {
                DynamicParameters dp = new DynamicParameters();
                dp.Add("@ID", wid);

                var rtn = conn.QueryMultiple("wf_GetRunTimeInfo", dp,
                                        null,
                                        null, CommandType.StoredProcedure);
                var WorkItem = rtn.ReadFirstOrDefault<WorkList>();
                var instance = rtn.ReadFirstOrDefault<ProcesssInstance>();
                var curentActivity = rtn.ReadFirstOrDefault<Activity>();
                WorkListRunTimeInfo result = new WorkListRunTimeInfo();
                result.processInstance = instance;
                result.WorkItem = WorkItem;
                result.CurrentActivity = curentActivity;
                return result;
            }
        }

        public static bool IsAllTaskFinish(WorkList myTask)
        {
            bool rtn = true;
            var sql = @"select * from WorkList 
                        where processid=@processid 
                        and activityid=@activityid 
                        and ProcessInstanceID=@ProcessInstanceID 
                        and status not in (2,3) and isEnable=1";
            using (var conn = Database.DbService())
            {
                var result = conn.Query<WorkList>(sql, new { processid = myTask.ProcessID, activityid = myTask.ActivityID, ProcessInstanceID = myTask.ProcessInstanceID });
                if (result.Count() > 0)
                {
                    rtn = false;
                }
            }
            return rtn;
        }

    }
}
