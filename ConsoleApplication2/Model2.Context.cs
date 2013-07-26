﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CoreEventEggDbEntities2 : DbContext
    {
        public CoreEventEggDbEntities2()
            : base("name=CoreEventEggDbEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ArticleContent> ArticleContents { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<ImageGallery> ImageGalleries { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<TableName> TableNames { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Association> Associations { get; set; }
        public DbSet<AssocitationCategory> AssocitationCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<EventAssociation> EventAssociations { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<EventAsset> EventAssets { get; set; }
        public DbSet<Events1> Events1 { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PersonRole> PersonRoles { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<ProcessPermission> ProcessPermissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Events2> Events2 { get; set; }
        public DbSet<RoleStatu> RoleStatus { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}
