using System;
using System.Collections.Generic;
using EventEgg.Service.Interfaces;

namespace EventEgg.Service.Models
{
    public class ArticleViewModel : IViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string MainKeywords { get; set; }
        public string OtherKeywords { get; set; }
        public int TableNameId { get; set; }
        public int TableNameRowId { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public IList<ArticleContentViewModel> Contents { get; set; }
    }
}
