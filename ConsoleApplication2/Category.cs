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
    
    public partial class Category
    {
        public Category()
        {
            this.AssocitationCategories = new HashSet<AssocitationCategory>();
            this.EventCategories = new HashSet<EventCategory>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ParentId { get; set; }
        public string Name { get; set; }
        public byte Status { get; set; }
        public System.DateTime LastModifieldDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual ICollection<AssocitationCategory> AssocitationCategories { get; set; }
        public virtual ICollection<EventCategory> EventCategories { get; set; }
    }
}
