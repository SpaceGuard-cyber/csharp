//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo2
{
    using System;
    using System.Collections.Generic;
    
    public partial class client
    {
        public int id_client { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int id_club { get; set; }
    
        public virtual fintess_clubs fintess_clubs { get; set; }
    }
}
