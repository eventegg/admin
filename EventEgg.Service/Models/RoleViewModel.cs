using System;
using EventEgg.Service.Interfaces;

namespace EventEgg.Service.Models
{
    public class RoleViewModel : IViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region Implementation of IViewModel

        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

        #endregion
    }
}
