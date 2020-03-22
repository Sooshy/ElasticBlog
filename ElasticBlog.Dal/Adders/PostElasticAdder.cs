using System.Threading.Tasks;
using AutoMapper;
using ElasticBlog.Common;
using ElasticBlog.Common.Interfaces.Dal;
using ElasticBlog.Common.Models;
using ElasticBlog.Dal.Models;
using Elasticsearch.Net;
using Microsoft.Extensions.Configuration;

namespace ElasticBlog.Dal.Adders
{
    public class PostElasticAdder : IElasticAdder<Post>
    {
        private readonly IMapper _mapper;
        private readonly ElasticConnect _elasticConnect;
        private readonly string _indexName;
        public PostElasticAdder(ElasticConnect elasticConnect, IConfiguration configuration, ConfigurationKeys configurationKeys, IMapper mapper)
        {
            _mapper = mapper;
            _indexName = configuration.GetSection(configurationKeys.ElasticConfig).Get<ElasticConnectionSettings>().PostsIndex;
            _elasticConnect = elasticConnect;
        }
        public async Task Add(Post data)
        {
            var postElastic = _mapper.Map<PostElastic>(data);
            await _elasticConnect.ElasticClient.IndexAsync(postElastic, i => i.Index(_indexName).Refresh(Refresh.WaitFor));
        }
    }
}