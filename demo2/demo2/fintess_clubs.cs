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
    
    public partial class fintess_clubs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fintess_clubs()
        {
            this.client = new HashSet<client>();
        }
    
        public int id_fitness_club { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string number { get; set; }
        public string waterpool { get; set; }
        public Nullable<System.DateTime> start_work { get; set; }
        public string web_site { get; set; }
        public int id_lessons { get; set; }
        public int id_types { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<client> client { get; set; }
        public virtual lessons lessons { get; set; }
        public virtual types_sport types_sport { get; set; }
    }
}
