namespace HidenIntelligence.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonNhapHang")]
    public partial class DonNhapHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDNH { get; set; }

        public int? MaNCC { get; set; }

        public int? MaSP { get; set; }

        public decimal? DonGiaNhap { get; set; }

        public int? SoLuongNhap { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
