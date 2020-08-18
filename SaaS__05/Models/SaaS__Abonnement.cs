namespace SaaS__05.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SaaS__Abonnement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaaS__Abonnement()
        {
            SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif = new HashSet<SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif>();
            SaaS__Fonctionnalite = new HashSet<SaaS__Fonctionnalite>();
        }

        [Key]
        public Guid ID_ { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif> SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaaS__Fonctionnalite> SaaS__Fonctionnalite { get; set; }
    }
}
