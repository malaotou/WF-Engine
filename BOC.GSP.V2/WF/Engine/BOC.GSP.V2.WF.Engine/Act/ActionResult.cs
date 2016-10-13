using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace BOC.GSP.V2.WF.Engine.Act
{

    public sealed class ActionResult : CodeActivity
    {
        // 定义一个字符串类型的活动输入参数
        public InArgument<string> Text { get; set; }

        // 如果活动返回值，则从 CodeActivity<TResult>
        // 并从 Execute 方法返回该值。
        protected override void Execute(CodeActivityContext context)
        {
            // 获取 Text 输入参数的运行时值

            // 依据当前规则检查下一步的处理规则OutCome，该节点是审批通过还是审批不通过
            string text = context.GetValue(this.Text);
        }
    }
}
