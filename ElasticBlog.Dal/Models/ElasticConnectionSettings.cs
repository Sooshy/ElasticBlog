using System.Collections;
using System.Collections.Generic;

namespace ElasticBlog.Dal.Models
{
    public class ElasticConnectionSettings
    {
        public IList<string> Uris { get; set; }
        public string PostsIndex { get; set; }
        public string UsersIndex { get; set; }
    }
}