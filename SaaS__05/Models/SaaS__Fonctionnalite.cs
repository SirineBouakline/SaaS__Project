namespace SaaS__05.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SaaS__Fonctionnalite
    {
        [Key]
        public Guid ID_ { get; set; }

        public Guid? ID____SaaS__Abonnement { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        public virtual SaaS__Abonnement SaaS__Abonnement { get; set; }
    }
}
