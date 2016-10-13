using BOC.GSP.V2.WF.Common.Models;
using BOC.GSP.V2.WF.Common.Variable;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOC.GSP.V2.WF.DAL.Repository
{
    public class ActivityRepository
    {
        public static Activity GetNextAct(Activity activity)
        {
            ////return conn.Tasks.Where(item => item.ParentId == taskid).ToList();
            //var sqlStr = "select top 1  * from  Activitys  where   ProcessID=@processid and ParentID=@ActivityId ";
            //using (var conn = Database.DbService())
            //{
            //    var res = conn.Query<Activity>(sqlStr, new { processid = activity.ProcessID, ActivityId = activity.ActivityID });
            //    if (res.Count() > 0)
            //    { return res.Single(); }
            //    else
            //    {
            //        return null;
            //    }

            //}

            // 更改为使用存储过程，存储过程更增加ActRule 
            using (var conn = Database.DbService())
            {
                DynamicParameters dp = new DynamicParameters();
                dp.Add("@processid", activity.ProcessID);
                dp.Add("@ActivityId", activity.ActivityID);
                var rtn = conn.QueryMultiple("wf_GetNextActivity", dp,
                                        null,
                                        null, CommandType.StoredProcedure);
                var Activity = rtn.Read<Activity>().SingleOrDefault();
                return Activity;

            }
        }

        public static bool Continue(ActivityPara para)
        {
            bool Continue = true;
            using (var conn = Database.DbService())
            {
                // @ACTID INT,
                // @PROCID UNIQUEIDENTIFIER,
                // @PROCINSTANCEID UNIQUEIDENTIFIER,
                // @RTN BIT OUTPUT
                DynamicParameters dp = new DynamicParameters();
                dp.Add("@RTN", dbType: DbType.Byte, direction: ParameterDirection.Output);

                dp.Add("@ACTID", para.ActId);

                dp.Add("@PROCID", para.ProcessID);

                dp.Add("@PROCINSTANCEID", para.ProcessInstanceId);
                conn.Query("wf_chkBranchMergeAble", dp,
                                        null,
                                        true,
                                        null, CommandType.StoredProcedure);
                //Continue =
                var a = dp.Get<object>("@RTN");
                if (a.ToString() != "1")
                {
                    Continue = false;
                }
            }
            return Continue;

        }

        public static void CreateTrack(ActivityTracking activityTracking)
        {
            using (var conn = Database.DbService())
            {
                conn.Insert(activityTracking);
            }
        }

        public static Activity GetInitiatorActivity(Guid processID)
        {
            ////return conn.Tasks.Where(item => item.ParentId == taskid).ToList();
            var sqlStr = @"select * from Activitys where ParentID is null and ProcessID = @ProcessID";
            using (var conn = Database.DbService())
            {
                var res = conn.Query<Activity>(sqlStr, new { ProcessID = processID }).SingleOrDefault();
                return res;
            }
        }
        public static Activity GetActivityByTypeCode(int activityTypeCode, Guid processId)
        {
            var sqlStr = @"select * from Activitys where ActType=1 and ProcessID = @ProcessID";
            using (var conn = Database.DbService())
            {
                var res = conn.Query<Activity>(sqlStr, new { ProcessID = processId }).SingleOrDefault();
                return res;
            }
        }
        public static Activity GetActivityById(int activityId, Guid processId)
        {
            var sqlStr = @"select * from Activitys where ID=@activityId and ProcessID = @ProcessID";
            using (var conn = Database.DbService())
            {
                var res = conn.Query<Activity>(sqlStr, new { ProcessID = processId, activityId = activityId }).SingleOrDefault();
                return res;
            }
        }
        public static Activity GetActivityByActivityId(Guid activityId, Guid processId)
        {
            var sqlStr = @"select * from Activitys where ActivityID=@activityId and ProcessID = @ProcessID";
            using (var conn = Database.DbService())
            {
                var res = conn.Query<Activity>(sqlStr, new { ProcessID = processId, activityId = activityId }).SingleOrDefault();
                return res;
            }
        }
        public static List<Activity> GetNextActivityByActivityId(int actvityId, Guid processId, int actionType)
        {
            var sqlStr = @"select a2.* from Activitys a
                            inner join line l
                            on a.ID=l.startid
                            inner join Activitys a2
                            on l.finishid=a2.ID  
                            where a.ProcessID=@ProcessID 
                            and a.ID =  @activityId 
                            and l.lineAction=@LineAction";
            using (var conn = Database.DbService())
            {
                var res = conn.Query<Activity>(sqlStr, new { ProcessID = processId, activityId = actvityId, LineAction = actionType }).ToList<Activity>();
                return res;
            }
        }

        public static List<string> GetApprover(string objectType, string objectid)
        {
            string sqlStr = string.Empty;
            //User
            if (objectType == "0")
            {
                sqlStr = "select top 3 domainid from Systemuser where userid=@ObjId";
            }
            else //Role
            {
                sqlStr = @"  select top 3 u.domainid from DeptRoleUser r
                              inner join Systemuser u
                              on r.userid = u.userid
                               where r.roleid =@ObjId";
            }
            using (var conn = Database.DbService())
            {
                var res = conn.Query<string>(sqlStr, new { ObjId = objectid }).ToList();
                return res;
            }
        }
    }
}
