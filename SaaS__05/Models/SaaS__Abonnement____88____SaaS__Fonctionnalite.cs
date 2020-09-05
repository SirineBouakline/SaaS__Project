namespace SaaS__05.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SaaS__Abonnement____88____SaaS__Fonctionnalite
    {
        [Key]
        public Guid ID_ { get; set; }

        public Guid? ID____SaaS__Abonnement { get; set; }

        public Guid? ID____SaaS__Fonctionnalite { get; set; }

        public virtual SaaS__Abonnement SaaS__Abonnement { get; set; }

        public virtual SaaS__Fonctionnalite SaaS__Fonctionnalite { get; set; }
    }
}
