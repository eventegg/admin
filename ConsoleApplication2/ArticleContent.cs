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
    
    public partial class ArticleContent
    {
        public System.Guid Id { get; set; }
        public System.Guid ArticleId { get; set; }
        public string ContentText { get; set; }
        public string HtmlType { get; set; }
        public byte Status { get; set; }
        public byte DisplayOrder { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime LastModifieldDate { get; set; }
    
        public virtual Article Article { get; set; }
    }
}