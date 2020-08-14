namespace SaaS__05__AC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SaaS__Message
    {
        [Key]
        public Guid ID_ { get; set; }

        public Guid? ID____SaaS__Message__Modele { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public string Message { get; set; }

        [StringLength(50)]
        public string Destinataire { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date__Envoi { get; set; }

        public TimeSpan? Heure__Envoi { get; set; }

        public virtual SaaS__Message__Modele SaaS__Message__Modele { get; set; }
    }
}
