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
    
    public partial class San_pham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public San_pham()
        {
            this.Chi_tiet_hoa_don = new HashSet<Chi_tiet_hoa_don>();
        }
    
        public int Ma_SP { get; set; }
        public string Ten_SP { get; set; }
        public double Don_gia { get; set; }
        public int Ma_loai { get; set; }
        public Nullable<bool> Trang_thai { get; set; }
        public byte[] Hinh_anh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chi_tiet_hoa_don> Chi_tiet_hoa_don { get; set; }
        public virtual Ma_loai Ma_loai1 { get; set; }
    }
}
