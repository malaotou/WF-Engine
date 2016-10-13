using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOC.GSP.V2.WF.Common.Variable
{
    /// <summary>
    /// 工作里节点参数
    /// </summary>
    public class ActivityPara
    {
        public int ActId { get; set; }
        public Guid ProcessID { get; set; }
        public int ActType { get; set; }
        public int ExecType { get; set; }
        public List<NextActivity> NextAct { get; set; }

        public Guid ParentId { get; set; }

        public string ADUser { get; set; }
        public string Remark { get; set; }

        public Guid ProcessInstanceId { get; set; }

        public Guid RunTimeInstanceId { get; set; }

        public Guid WorkListid { get; set; }
        public int ActionResult { get; set; }
        public int? Action { get; set; }

        public dynamic Body { get; set; }
        public virtual ActivityPara clone()
        {
            return (ActivityPara)this.MemberwiseClone();
        }
        public List<String> Approvers { get; set; }
    }
    public class NextActivity
    {
        public int NextActId { get; set; }
        public string NextActName { get; set; }
        public int NextActExecType { get; set; }
        public int ApproveType { get; set; }
    }
}
