//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eCommerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DauGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DauGia()
        {
            this.CT_LoaiDauGia = new HashSet<CT_LoaiDauGia>();
            this.CT_TrangThai = new HashSet<CT_TrangThai>();
            this.HinhAnhs = new HashSet<HinhAnh>();
            this.MucNangs = new HashSet<MucNang>();
            this.ThongBaos = new HashSet<ThongBao>();
            this.YeuThiches = new HashSet<YeuThich>();
        }
    
        public int MaDauGia { get; set; }
        public int MaNguoiBan { get; set; }
        public Nullable<int> MaNguoiMua { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
        public int GiaBanDau { get; set; }
        public int MucNangToiThieu { get; set; }
        public Nullable<int> GiaCuoi { get; set; }
        public System.DateTime NgayBatDau { get; set; }
        public System.DateTime NgayKetThuc { get; set; }
        public string ViTri { get; set; }
        public Nullable<System.DateTime> NgayThanhToan { get; set; }
        public System.DateTime NgayDang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_LoaiDauGia> CT_LoaiDauGia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_TrangThai> CT_TrangThai { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual NguoiDung NguoiDung1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HinhAnh> HinhAnhs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MucNang> MucNangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongBao> ThongBaos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YeuThich> YeuThiches { get; set; }
    }
}
