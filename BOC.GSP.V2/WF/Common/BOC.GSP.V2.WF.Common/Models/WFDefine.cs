namespace BOC.GSP.V2.WF.Common.Models
{
    using Dapper;
    using System;
    using System.Collections.Generic;


    [Table("WFDefine")]
    public partial class WFDefine
    {
        [Key]
        public Guid Id { get; set; }


        public string Name { get; set; }

        public string Version { get; set; }

        public string Content { get; set; }
        public string UserId { get; set; }

        public byte Status { get; set; }
        public string WFLocalAssemblyFilePath { get; set; }

        public DateTime CreateTime { get; set; }

        public string Description { get; set; }
    }
}
