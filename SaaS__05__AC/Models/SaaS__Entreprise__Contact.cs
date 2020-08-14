namespace SaaS__05__AC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SaaS__Entreprise__Contact
    {
        [Key]
        public Guid ID_ { get; set; }

        public Guid? ID____SaaS__Entreprise { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(50)]
        public string Prenom { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Tel1 { get; set; }

        [StringLength(50)]
        public string Tel2 { get; set; }

        public virtual SaaS__Entreprise SaaS__Entreprise { get; set; }
    }
}
