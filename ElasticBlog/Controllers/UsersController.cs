using System.Threading.Tasks;
using ElasticBlog.Common.Interfaces.Bl;
using ElasticBlog.Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace ElasticBlog.Controllers
{
    public class UsersController : Controller
    {
        private readonly IAdderLogic<User> _userAdderLogic;

        public UsersController(IAdderLogic<User> userAdderLogic)
        {
            _userAdderLogic = userAdderLogic;
        }

        public Task<IActionResult> AddUser()
        {
            throw new System.NotImplementedException();
        }

        public Task<IActionResult> DeleteUser()
        {
            throw new System.NotImplementedException();
        }
    }
}