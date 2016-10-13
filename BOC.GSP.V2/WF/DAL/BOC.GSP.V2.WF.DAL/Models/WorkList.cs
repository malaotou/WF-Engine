namespace BOC.GSP.V2.WF.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkList")]
    public partial class WorkList
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        [StringLength(100)]
        public string WorkURL { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? ParentID { get; set; }

        public Guid? ProcessID { get; set; }

        public Guid? ProcessInstanceID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ActivityID { get; set; }

        public Guid? ActivityInstanceID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string UserID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }
    }
}
