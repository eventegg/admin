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
    
    public partial class ImageGallery
    {
        public System.Guid Id { get; set; }
        public System.Guid GalleryId { get; set; }
        public System.Guid ImageId { get; set; }
        public int DisplayOrder { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime LastModifieldDate { get; set; }
    
        public virtual Gallery Gallery { get; set; }
        public virtual Image Image { get; set; }
    }
}
