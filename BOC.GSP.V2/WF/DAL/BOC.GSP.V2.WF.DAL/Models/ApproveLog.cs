namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApproveLog")]
    public partial class ApproveLog
    {
        public Guid? ID { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string User { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }
    }
}
