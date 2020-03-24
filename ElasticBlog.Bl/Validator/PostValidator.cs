using ElasticBlog.Common;
using ElasticBlog.Common.Interfaces.Bl;

namespace ElasticBlog.Bl.Validator
{
    public class PostValidator : IValidator<Common.Models.Post>
    {
        public bool Validate(Common.Models.Post data)
        {
            throw new System.NotImplementedException();
        }
    }
}