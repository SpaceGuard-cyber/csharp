//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demolast
{
    using System;
    using System.Collections.Generic;
    
    public partial class fitness_clubs
    {
        public int id_fitness_club { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string number { get; set; }
        public string waterpool { get; set; }
        public string start_work { get; set; }
        public string web_site { get; set; }
        public Nullable<int> id_lessons { get; set; }
        public Nullable<int> id_types { get; set; }
    
        public virtual lessons lessons { get; set; }
        public virtual types_sport types_sport { get; set; }
    }
}
