namespace SaaS__05.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SaaS__Tarif
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaaS__Tarif()
        {
            SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif = new HashSet<SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif>();
        }

        [Key]
        public Guid ID_ { get; set; }

        public Guid? ID____SaaS__Abonnement { get; set; }

        public decimal? Tarif_Forfaitaire_Mensuel { get; set; }

        public decimal? Tarif_Forfaitaire_Annuel { get; set; }

        public decimal? Tarif_Par_Utilisateur_Annuel { get; set; }

        public decimal? Tarif_Par_Utilisateur_Mensuel { get; set; }

        public DateTime? Date_Debut { get; set; }

        public DateTime? Date_Fin { get; set; }

        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif> SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif { get; set; }
    }
}
