﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FrontMarcassin.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MarcassinEntities : DbContext
    {
        public MarcassinEntities()
            : base("name=MarcassinEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Badge> Badges { get; set; }
        public virtual DbSet<Competence> Competences { get; set; }
        public virtual DbSet<Competence_Niveau_Interne> Competence_Niveau_Interne { get; set; }
        public virtual DbSet<Departement> Departements { get; set; }
        public virtual DbSet<Employe> Employes { get; set; }
        public virtual DbSet<Entreprise> Entreprises { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Like> Likes { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Niveau> Niveaux { get; set; }
        public virtual DbSet<Pay> Pays { get; set; }
        public virtual DbSet<Reunion> Reunions { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TraductionCompetence> TraductionCompetences { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<Ville> Villes { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Service_Traduction> Service_Traduction { get; set; }
        public virtual DbSet<TraductionBadge> TraductionBadges { get; set; }
        public virtual DbSet<TraductionPay> TraductionPays { get; set; }
    }
}
