﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PBL_3Entities : DbContext
    {
        public PBL_3Entities()
            : base("name=PBL_3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ca_lam_viec> Ca_lam_viec { get; set; }
        public virtual DbSet<Chi_tiet_hoa_don> Chi_tiet_hoa_don { get; set; }
        public virtual DbSet<Hoa_don> Hoa_don { get; set; }
        public virtual DbSet<Khach_hang> Khach_hang { get; set; }
        public virtual DbSet<Ma_loai> Ma_loai { get; set; }
        public virtual DbSet<Nhan_vien> Nhan_vien { get; set; }
        public virtual DbSet<Phan_cong> Phan_cong { get; set; }
        public virtual DbSet<San_pham> San_pham { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tai_khoan> Tai_khoan { get; set; }
    }
}