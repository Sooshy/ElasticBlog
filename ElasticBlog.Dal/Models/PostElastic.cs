using System;
using ElasticBlog.Common.Models;

namespace ElasticBlog.Dal.Models
{
    public class PostElastic
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string PostText { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}