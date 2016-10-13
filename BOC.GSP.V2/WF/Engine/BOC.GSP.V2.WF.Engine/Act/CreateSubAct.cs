using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using BOC.GSP.V2.WF.Common.Variable;
using System.Threading.Tasks;
using BOC.GSP.V2.WF.DAL.Repository;
using System.Threading;

namespace BOC.GSP.V2.WF.Engine.Act
{

    public sealed class CreateSubAct : CodeActivity
    {
        public InOutArgument<ActivityPara> para { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            ActivityPara taskPara = para.Get<ActivityPara>(context);

            // 如果所有父节点已经运行完成，确保所有父节点运行完成。
            if (ActivityRepository.Continue(taskPara))
            {
                // 获取下一步审批信息，作为下一流程运行参数。
                Dictionary<string, object> nextPara = new Dictionary<string, object>();
                nextPara.Add("para", taskPara);
                Task t = Task.Factory.StartNew(() =>
                {
                    string res = string.Empty;
                    bool rtn = Instance.Run(nextPara, out res);
                    if (rtn == false)
                    {
                        Thread.Sleep(new TimeSpan(0, 0, 5));
                        if (!Instance.Run(nextPara, out res))
                        {
                            throw new WorkflowApplicationException("子流程尝试重新启动失败");
                        }
                    }


                });
            }

        }
    }
}
