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
    
    public partial class Role
    {
        public Role()
        {
            this.Permissions = new HashSet<Permission>();
            this.PersonRoles = new HashSet<PersonRole>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<PersonRole> PersonRoles { get; set; }
    }
}