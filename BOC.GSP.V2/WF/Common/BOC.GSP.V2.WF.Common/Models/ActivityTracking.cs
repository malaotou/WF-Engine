using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace BOC.GSP.V2.WF.Common.Models
{
    [Table("ActivityTracking")]
    public class ActivityTracking
    {
        [Key]
        public int ID { get; set; }
        public Guid ActivityID { get; set; }
        public Guid ProcessInstanceID { get; set; }
        public Guid ProcessID { get; set; }
    }
}
