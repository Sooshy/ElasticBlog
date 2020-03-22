using System;
using System.Threading.Tasks;
using ElasticBlog.Common.Interfaces;
using ElasticBlog.Common.Interfaces.Bl;
using ElasticBlog.Common.Interfaces.Dal;
using ElasticBlog.Common.Models;

namespace ElasticBlog.Bl.Post
{
    public class PostAdderLogic : IAdderLogic<Common.Models.Post>
    {
        private readonly IElasticAdder<Common.Models.Post> _elasticAdder;

        public PostAdderLogic(IElasticAdder<Common.Models.Post> elasticAdder)
        {
            _elasticAdder = elasticAdder;
        }
        public async Task Add(Common.Models.Post data)
        {
            data.Id = Guid.NewGuid().ToString();
            await _elasticAdder.Add(data);
        }
    }
}