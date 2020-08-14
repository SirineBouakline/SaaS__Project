namespace SaaS__05__AC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbModel : DbContext
    {
        public DbModel()
            : base("name=DbModel")
        {
        }

        public virtual DbSet<SaaS__Abonnement> SaaS__Abonnement { get; set; }
        public virtual DbSet<SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif> SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif { get; set; }
        public virtual DbSet<SaaS__Entreprise> SaaS__Entreprise { get; set; }
        public virtual DbSet<SaaS__Entreprise__Contact> SaaS__Entreprise__Contact { get; set; }
        public virtual DbSet<SaaS__Fonctionnalite> SaaS__Fonctionnalite { get; set; }
        public virtual DbSet<SaaS__Message> SaaS__Message { get; set; }
        public virtual DbSet<SaaS__Message__Modele> SaaS__Message__Modele { get; set; }
        public virtual DbSet<SaaS__Message__Type> SaaS__Message__Type { get; set; }
        public virtual DbSet<SaaS__Tarif> SaaS__Tarif { get; set; }
        public virtual DbSet<SaaS__Utilisateur> SaaS__Utilisateur { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SaaS__Abonnement>()
                .HasMany(e => e.SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif)
                .WithOptional(e => e.SaaS__Abonnement)
                .HasForeignKey(e => e.ID____SaaS__Abonnement)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SaaS__Abonnement>()
                .HasMany(e => e.SaaS__Fonctionnalite)
                .WithOptional(e => e.SaaS__Abonnement)
                .HasForeignKey(e => e.ID____SaaS__Abonnement)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SaaS__Entreprise>()
                .HasMany(e => e.SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif)
                .WithOptional(e => e.SaaS__Entreprise)
                .HasForeignKey(e => e.ID____SaaS__Entreprise)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SaaS__Entreprise>()
                .HasMany(e => e.SaaS__Entreprise__Contact)
                .WithOptional(e => e.SaaS__Entreprise)
                .HasForeignKey(e => e.ID____SaaS__Entreprise)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SaaS__Entreprise>()
                .HasMany(e => e.SaaS__Utilisateur)
                .WithOptional(e => e.SaaS__Entreprise)
                .HasForeignKey(e => e.ID____SaaS__Entreprise);

            modelBuilder.Entity<SaaS__Message__Modele>()
                .HasMany(e => e.SaaS__Message)
                .WithOptional(e => e.SaaS__Message__Modele)
                .HasForeignKey(e => e.ID____SaaS__Message__Modele);

            modelBuilder.Entity<SaaS__Message__Type>()
                .HasMany(e => e.SaaS__Message__Modele)
                .WithOptional(e => e.SaaS__Message__Type)
                .HasForeignKey(e => e.ID____SaaS__Message__Type);

            modelBuilder.Entity<SaaS__Tarif>()
                .Property(e => e.Tarif__Forfaitaire__Mensuel)
                .HasPrecision(18, 3);

            modelBuilder.Entity<SaaS__Tarif>()
                .Property(e => e.Tarif__Par__Utilisateur__Annuel)
                .HasPrecision(18, 3);

            modelBuilder.Entity<SaaS__Tarif>()
                .HasMany(e => e.SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif)
                .WithOptional(e => e.SaaS__Tarif)
                .HasForeignKey(e => e.ID____SaaS__Tarif)
                .WillCascadeOnDelete();
        }
    }
}
