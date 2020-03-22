using System;
using System.Runtime.InteropServices.ComTypes;

namespace ElasticBlog.Common.Models
{
    public class Post
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