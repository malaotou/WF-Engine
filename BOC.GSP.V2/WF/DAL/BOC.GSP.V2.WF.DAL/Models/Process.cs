namespace BOC.GSP.V2.WF.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Process")]
    public partial class Process
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string ProcessName { get; set; }

        [StringLength(1000)]
        public string ProcessDescr { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ProcessID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Version { get; set; }
    }
}
