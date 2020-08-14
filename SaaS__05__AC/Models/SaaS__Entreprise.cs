namespace SaaS__05__AC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SaaS__Entreprise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaaS__Entreprise()
        {
            SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif = new HashSet<SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif>();
            SaaS__Entreprise__Contact = new HashSet<SaaS__Entreprise__Contact>();
            SaaS__Utilisateur = new HashSet<SaaS__Utilisateur>();
        }

        [Key]
        public Guid ID_ { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Addresse { get; set; }

        [StringLength(50)]
        public string Num__Telephone { get; set; }

        [StringLength(50)]
        public string Code__TVA { get; set; }

        [StringLength(50)]
        public string RNE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif> SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaaS__Entreprise__Contact> SaaS__Entreprise__Contact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaaS__Utilisateur> SaaS__Utilisateur { get; set; }
    }
}
