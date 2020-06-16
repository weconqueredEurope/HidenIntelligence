namespace HidenIntelligence.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            BinhLuans = new HashSet<BinhLuan>();
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            DonNhapHangs = new HashSet<DonNhapHang>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSP { get; set; }

        [StringLength(255)]
        public string TenSP { get; set; }

        public double? DonGia { get; set; }

        public string MoTa { get; set; }

        public string HinhAnh1 { get; set; }

        public string HinhAnh2 { get; set; }

        public string HinhAnh3 { get; set; }

        public int? LuotXem { get; set; }

        public int? LuotBinhChon { get; set; }

        public int? SoLuotMua { get; set; }

        public int? MaNCC { get; set; }

        public int? MaLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonNhapHang> DonNhapHangs { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual TheLoaiSP TheLoaiSP { get; set; }
    }
}
