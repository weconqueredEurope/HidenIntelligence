namespace HidenIntelligence.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BinhLuan")]
    public partial class BinhLuan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBL { get; set; }

        public int? MaSP { get; set; }

        [StringLength(100)]
        public string TenKH { get; set; }

        public string NoiDungBL { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
