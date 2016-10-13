using BOC.GSP.V2.WF.Common.Variable;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOC.GSP.V2.WF.Common.Models;
using System.Collections.Concurrent;
using BOC.GSP.V2.WF.Common.Utility;

namespace BOC.GSP.V2.WF.DAL.Repository
{
    public class ProcessRepository
    {
        public static Guid CreateProcInstance(string userid, Guid ProcessID, out StoreprocResult result)
        {
            DynamicParameters dp = new DynamicParameters();
            result = new StoreprocResult();
            byte rtnResult = 0;
            string rtnMessage = string.Empty;
            Guid rtnId = new Guid();

            #region Parameter
            dp.Add("@Result", dbType: DbType.Byte, direction: ParameterDirection.Output);
            dp.Add("@Message", dbType: DbType.String, direction: ParameterDirection.Output, size: 1000);
            dp.Add("@ID", dbType: DbType.Guid, direction: ParameterDirection.Output);

            //Input Parameters
            dp.Add("@processid", "A8CCBAA1-B980-4790-ACF3-DBDF725FB3CE");

            if (!string.IsNullOrEmpty("malei"))
                dp.Add("@UserId", "malei");
            #endregion
            using (var conn = Database.DbService())
            {
                conn.Query("wf_CreateProcessInstance", dp,
                                        null,
                                        true,
                                        null, CommandType.StoredProcedure);
                rtnResult = dp.Get<byte>("@Result");
                rtnMessage = dp.Get<string>("@Message");
                rtnId = dp.Get<Guid>("@ID");
            }
            result.message = rtnMessage;
            result.retult = rtnResult;
            return rtnId;

        }

        public static Process GetProcessInfo(Guid instanceId)
        {
            var sqlStr = @" select * from Process  where ProcessID =@ProcessID and EnableStatus=1";
            using (var conn = Database.DbService())
            {
                return conn.Query<Process>(sqlStr, new { ProcessID = instanceId }).SingleOrDefault();
            }
        }

        public static List<Process> GetProcesses()
        {
            var sqlStr = @"  SELECT  * from Process where enablestatus =1";
            using (var conn = Database.DbService())
            {
                var pList = conn.Query<Process>(sqlStr).ToList();
                return pList;
            }
        }

        public static ProcesssInstance GetProcessInstance(Guid instanceId)
        {
            var sqlStr = @"  SELECT  * From ProcesssInstance where  ProcessInstanceID=@Id";
            using (var conn = Database.DbService())
            {
                return conn.Query<ProcesssInstance>(sqlStr, new { Id = instanceId }).SingleOrDefault();
            }
        }
        public static ProcesssInstance GetProcessInstanceByWorkItemId(Guid workid)
        {
            var sqlStr = @"select p.* from ProcesssInstance p
                            inner join WorkList w
                            on p.ProcessInstanceID =w.ProcessInstanceID
                            where w.ID=@ID";
            using (var conn = Database.DbService())
            {
                return conn.Query<ProcesssInstance>(sqlStr, new { Id = workid }).SingleOrDefault();
            }
        }


        public static void UpdateInstanceId(int id, Guid instanceid)
        {
            var sqlStr = @"  update  ProcesssInstance set ProcessInstanceID=@ProcessInstanceID ,status=1
                        where ID=@ID";
            using (var conn = Database.DbService())
            {
                conn.Execute(sqlStr, new { @ProcessInstanceID = instanceid, ID = id });
            }
        }

        public static void UpdateInstanceStatus(Guid instanceId, int status)
        {
            var sqlStr = string.Format(@"  update  ProcesssInstance set status={0}
                        where ProcessInstanceID=@ProcessInstanceID", status);
            using (var conn = Database.DbService())
            {
                conn.Execute(sqlStr, new { @ProcessInstanceID = instanceId });
            }
        }

        public static void FinishProcess(Guid InstanceID)
        {
            var sqlStr = @"  update  ProcesssInstance set FinishTime=getdate() ,status=2
                        where ProcessInstanceID=@ProcessInstanceID";
            using (var conn = Database.DbService())
            {
                conn.Execute(sqlStr, new { @ProcessInstanceID = InstanceID });
            }
        }

        public static void CreateProcessInstance(ProcesssInstance instance)
        {
            using (var conn = Database.DbService())
            {
                conn.Insert(instance);
            }
        }
    }
}
