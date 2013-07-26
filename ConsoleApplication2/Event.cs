//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Event
    {
        public Event()
        {
            this.EventAssociations = new HashSet<EventAssociation>();
            this.EventCategories = new HashSet<EventCategory>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> AssociationId { get; set; }
        public Nullable<System.Guid> OrganizerId { get; set; }
        public Nullable<System.Guid> VenueId { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> CityId { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Description { get; set; }
        public Nullable<int> AttendeeNumber { get; set; }
        public byte Status { get; set; }
        public string Url { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime LastModifieldDate { get; set; }
    
        public virtual Association Association { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<EventAssociation> EventAssociations { get; set; }
        public virtual ICollection<EventCategory> EventCategories { get; set; }
        public virtual Organizer Organizer { get; set; }
        public virtual Venue Venue { get; set; }
    }
}
