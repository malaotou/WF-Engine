
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOC.GSP.V2.WF.Common.Models
{
    [Table("WorkList")]
    public class WorkList
    {
        [Key]
        public Guid ID { get; set; }

        public string WorkURL { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ParentID { get; set; }
        public Guid? ProcessID { get; set; }

        public Guid? ProcessInstanceID { get; set; }
        public Guid? RuntimeInstanceID { get; set; }

        public string BookMark { get; set; }

        public Guid ActivityID { get; set; }

        public string ActivityInstanceID { get; set; }


        public string UserID { get; set; }

        public DateTime? FinishTime { get; set; }

        public string Title { get; set; }
        [NotMapped]
        public string Folio { get; set; }

        public int Status { get; set; }
        public string Result { get; set; }

        //上一节点审批人意见
        public string Remark { get; set; }

        public bool IsEnable
        {
            get
            {
                return isEnable;
            }

            set
            {
                isEnable = value;
            }
        }

        private bool isEnable;
        public WorkList()
        {
            this.isEnable = true;
        }
    }
}
