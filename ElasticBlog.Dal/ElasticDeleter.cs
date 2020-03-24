using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ElasticBlog.Common.Interfaces.Dal;

namespace ElasticBlog.Dal
{
    public class ElasticDeleter : IElasticDeleter
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}