using AutoMapper;
using ElasticBlog.Common.Models;
using ElasticBlog.Dal.Models;

namespace ElasticBlog.Mappings
{
    public class ModelMapping : Profile
    {
        public ModelMapping()
        {
            CreateMap<User, UserElastic>();
            CreateMap<Post, PostElastic>();
        }
    }
}