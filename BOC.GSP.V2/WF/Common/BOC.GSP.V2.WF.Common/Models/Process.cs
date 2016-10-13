namespace BOC.GSP.V2.WF.Common.Models
{
    using Dapper;
    using System;
    using System.Collections.Generic;

    [Table("Process")]
    public partial class Process
    {
        [Key]
        public int ID { get; set; }

        [Key]
        public string ProcessName { get; set; }

        public string ProcessDescr { get; set; }

        [Key]
        public Guid ProcessID { get; set; }

        public string Version { get; set; }

        public Guid DefineID { get; set; }
    }
}
