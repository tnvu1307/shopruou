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
    
    public partial class taikhoan
    {
        public int id { get; set; }
        public string tk { get; set; }
        public string matKhau { get; set; }
        public string hoTen { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> ngaySinh { get; set; }
        public Nullable<int> ltk { get; set; }
    
        public virtual loaiTK loaiTK { get; set; }
    }
}
