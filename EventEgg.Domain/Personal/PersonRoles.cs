using System;
using System.Collections.Generic;

namespace EventEgg.Domain.Personal
{
    public class PersonalRoles
    {
        public virtual int Id { get; set; }
        public virtual Guid UserId { get; set; }
        public virtual Guid RoleId { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }
     
        
        public virtual IList<PersonalDetail> PersonDetail { get; set; }
    }
}