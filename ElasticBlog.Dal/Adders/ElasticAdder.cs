using System.Threading.Tasks;
using AutoMapper;
using ElasticBlog.Common.Interfaces.Dal;

namespace ElasticBlog.Dal.Adders
{
    public class ElasticAdder<T> : IElasticAdder<T>
    {
        public ElasticAdder(string indexName, ElasticConnect elasticConnect, IMapper mapper)
        {
            throw new System.NotImplementedException();
        }

        public Task Add(T data)
        {
            throw new System.NotImplementedException();
        }
    }
}