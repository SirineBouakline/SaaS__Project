namespace SaaS__05.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SaaS__Fonctionnalite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaaS__Fonctionnalite()
        {
            SaaS__Abonnement____88____SaaS__Fonctionnalite = new HashSet<SaaS__Abonnement____88____SaaS__Fonctionnalite>();
        }

        [Key]
        public Guid ID_ { get; set; }

        public Guid? ID____SaaS__Abonnement__Module { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaaS__Abonnement____88____SaaS__Fonctionnalite> SaaS__Abonnement____88____SaaS__Fonctionnalite { get; set; }

        public virtual SaaS__Abonnement__Module SaaS__Abonnement__Module { get; set; }
    }
}
