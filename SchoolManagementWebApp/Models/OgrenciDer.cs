//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagementWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OgrenciDer
    {
        public int Id { get; set; }
        public Nullable<int> DersId { get; set; }
        public Nullable<int> OgrenciId { get; set; }
    
        public virtual Der Der { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
    }
}
