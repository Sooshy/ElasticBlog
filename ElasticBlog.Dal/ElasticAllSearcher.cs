using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ElasticBlog.Common.Interfaces.Dal;

namespace ElasticBlog.Dal
{
    public class ElasticAllSearcher<TResult> : IElasticSearcher<TResult, string>
    {
        public Task<IEnumerable<TResult>> Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}