namespace BOC.GSP.V2.WF.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Activitys")]
    public partial class Activity
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ProcessID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string ActivityName { get; set; }

        [StringLength(1000)]
        public string ActivityDescr { get; set; }

        public int? ApproveType { get; set; }

        public Guid? ParentID { get; set; }

        public bool? isEnd { get; set; }

        [StringLength(50)]
        public string ApproveRole { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid ActivityID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SeqID { get; set; }
    }
}
