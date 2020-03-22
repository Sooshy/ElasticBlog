using System.Threading.Tasks;
using ElasticBlog.Common.Interfaces;
using ElasticBlog.Common.Interfaces.Bl;

namespace ElasticBlog.Bl.User
{
    public class UserAdderLogic : IAdderLogic<Common.Models.User>
    {
        public Task Add(Common.Models.User data)
        {
            throw new System.NotImplementedException();
        }
    }
}