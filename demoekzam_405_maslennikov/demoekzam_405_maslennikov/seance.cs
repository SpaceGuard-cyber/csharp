//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demoekzam_405_maslennikov
{
    using System;
    using System.Collections.Generic;
    
    public partial class seance
    {
        public int id_seance { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public Nullable<int> id_cinema { get; set; }
        public Nullable<int> number_zal { get; set; }
        public string type_seance { get; set; }
        public Nullable<int> id_film { get; set; }
    
        public virtual cinema cinema { get; set; }
        public virtual film film { get; set; }
    }
}
