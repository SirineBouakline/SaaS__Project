namespace SaaS__05.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif
    {
        [Key]
        public Guid ID_ { get; set; }

        public Guid? ID____SaaS__Entreprise { get; set; }

        public Guid? ID____SaaS__Abonnement { get; set; }

        public Guid? ID____SaaS__Tarif { get; set; }

        public DateTime? Date_Debut { get; set; }

        public DateTime? Date_Fin { get; set; }

        public virtual SaaS__Abonnement SaaS__Abonnement { get; set; }

        public virtual SaaS__Entreprise SaaS__Entreprise { get; set; }

        public virtual SaaS__Tarif SaaS__Tarif { get; set; }
    }
}
