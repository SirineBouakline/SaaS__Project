namespace SaaS__05.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SaaS__Message__Modele
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaaS__Message__Modele()
        {
            SaaS__Message = new HashSet<SaaS__Message>();
        }

        [Key]
        public Guid ID_ { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public string Description { get; set; }

        public Guid? ID____SaaS__Message__Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaaS__Message> SaaS__Message { get; set; }

        public virtual SaaS__Message__Type SaaS__Message__Type { get; set; }
    }
}
