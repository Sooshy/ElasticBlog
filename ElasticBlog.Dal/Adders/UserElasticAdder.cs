using System.Threading.Tasks;
using ElasticBlog.Common.Interfaces.Dal;
using ElasticBlog.Common.Models;

namespace ElasticBlog.Dal.Adders
{
    public class UserElasticAdder : IElasticAdder<User>
    {
        public Task Add(User data)
        {
            throw new System.NotImplementedException();
        }
    }
}