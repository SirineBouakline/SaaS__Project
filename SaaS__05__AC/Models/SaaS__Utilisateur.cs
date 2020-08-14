namespace SaaS__05__AC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SaaS__Utilisateur
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
        public string Password { get; set; }

        [StringLength(50)]
        public string Num__Telephone { get; set; }

        public int? Delais__Grace { get; set; }

        public bool? isAdmin { get; set; }

        public bool? isSuperAdmin { get; set; }

        public virtual SaaS__Entreprise SaaS__Entreprise { get; set; }
    }
}
