//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Chi_tiet_hoa_don
    {
        public int Ma_HD { get; set; }
        public int Ma_SP { get; set; }
        public string Kich_thuoc { get; set; }
        public int Soluong_SP { get; set; }
        public double Gia { get; set; }
    
        public virtual Hoa_don Hoa_don { get; set; }
        public virtual San_pham San_pham { get; set; }
    }
}
