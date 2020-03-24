using System;
using ElasticBlog.Common;
using ElasticBlog.Common.Interfaces.Bl;

namespace ElasticBlog.Bl.Validator
{
    public class UserValidator :IValidator<Common.Models.User>
    {
        public bool Validate(Common.Models.User data)
        {
            throw new NotImplementedException();
        }
    }
}