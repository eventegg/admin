using System;

namespace EventEgg.Service.Models
{
    public class ArticleContentViewModel
    {
        public Guid Id { get; set; }
        public Guid ArticleId { get; set; }
        public string ContentText { get; set; }
        public string HtmlType { get; set; }
        public byte Status { get; set; }
        public byte DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public ArticleViewModel Article { get; set; }
    }
}