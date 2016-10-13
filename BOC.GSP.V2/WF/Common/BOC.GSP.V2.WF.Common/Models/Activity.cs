namespace BOC.GSP.V2.WF.Common.Models
{
    using Dapper;
    using System;
    using System.Collections.Generic;


    [Table("Activitys")]
    public partial class Activity
    {
        [Key]
        public int ID { get; set; }

        [Key]
        public Guid ProcessID { get; set; }

        [Key]
        public string ActivityName { get; set; }

        public string ActivityDescr { get; set; }

        public int? ApproveType { get; set; }
        public string ApproveObjectType { get; set; }
        public String ApproveObjectCode { get; set; }
        public int? ActType { get; set; }

        public Guid? ParentID { get; set; }

        public bool? isEnd { get; set; }


        public string ApproveRole { get; set; }

        [Key]

        public Guid ActivityID { get; set; }

        [Key]
        public int SeqID { get; set; }
    }
}
