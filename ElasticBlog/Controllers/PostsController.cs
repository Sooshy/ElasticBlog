using System.Threading.Tasks;
using ElasticBlog.Common.Interfaces.Bl;
using ElasticBlog.Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace ElasticBlog.Controllers
{
    public class PostsController : Controller
    {
        private readonly IAdderLogic<Post> _postAdderLogic;

        public PostsController(IAdderLogic<Post> postAdderLogic)
        {
            _postAdderLogic = postAdderLogic;
        }
        [Route("api/[controller]/AddPost")]
        [HttpPost]
        public async Task<IActionResult> AddPost([FromBody]Post post)
        {
            await _postAdderLogic.Add(post);
            return Ok();
        }

        public Task<IActionResult> DeletePost()
        {
            throw new System.NotImplementedException();
        }

        public Task<IActionResult> UpdatePost()
        {
            throw new System.NotImplementedException();
        }

        public Task<IActionResult> SearchPost()
        {
            throw new System.NotImplementedException();
        }
    }
}