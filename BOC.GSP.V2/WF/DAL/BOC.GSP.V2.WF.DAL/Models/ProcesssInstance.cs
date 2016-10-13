namespace BOC.GSP.V2.WF.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcesssInstance")]
    public partial class ProcesssInstance
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ProcessID { get; set; }

        [StringLength(100)]
        public string Tiltle { get; set; }

        [StringLength(100)]
        public string URL { get; set; }

        public Guid? ProcessInstanceID { get; set; }

        [StringLength(100)]
        public string Initiator { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        [Column(TypeName = "text")]
        public string Parameters { get; set; }
    }
}
