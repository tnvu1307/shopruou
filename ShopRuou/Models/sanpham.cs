//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopRuou.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class sanpham
    {
        public int maSP { get; set; }
        public int maloaiSP { get; set; }
        public int maNSX { get; set; }
        public int maTT { get; set; }
        public int soluongton { get; set; }
        public int soluongbanduoc { get; set; }
        public int soluongxem { get; set; }
        public System.DateTime ngaynhap { get; set; }
    
        public virtual chitietSP chitietSP { get; set; }
        public virtual loaiSP loaiSP { get; set; }
        public virtual nhasanxuat nhasanxuat { get; set; }
        public virtual tinhtrang tinhtrang { get; set; }
    }
}
