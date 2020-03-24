using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ElasticBlog.Common.Interfaces.Dal;

namespace ElasticBlog.Dal
{
    public class ElasticUpdater<T> : IElasticUpdater<T>
    {
        public Task Update(T data)
        {
            throw new NotImplementedException();
        }
    }
}