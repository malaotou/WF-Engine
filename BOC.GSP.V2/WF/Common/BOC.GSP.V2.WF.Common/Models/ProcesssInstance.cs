namespace BOC.GSP.V2.WF.Common.Models
{
    using Dapper;
    using System;
    using System.Collections.Generic;

    [Table("ProcesssInstance")]
    public class ProcesssInstance
    {

        [Key]
        public int ID { get; set; }


        public Guid ProcessID { get; set; }


        public string Title { get; set; }


        public string URL { get; set; }

        public Guid? ProcessInstanceID { get; set; }

        public Guid? RuntimeInstanceID { get; set; }
        public string Initiator { get; set; }


        public int Status { get; set; }


        public string Parameters { get; set; }
        public string Processor { get; set; }

        public Guid? BatchNo { get; set; }
        public string BusinessData { get; set; }
    }
}
