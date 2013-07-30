using System;
namespace EventEgg.Service.Interfaces
{
    interface IViewModel
    {
        DateTime CreatedDate { get; set; }
        DateTime LastModifiedDate { get; set; }
    }
}
