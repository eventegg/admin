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
    
    public partial class Permission
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> RoleId { get; set; }
        public Nullable<System.Guid> ProcessId { get; set; }
        public Nullable<byte> CrudProcessType { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
