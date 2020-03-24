using System.Threading.Tasks;

namespace ElasticBlog.Common.Interfaces.Bl
{
    public interface IUpdaterLogic<in T> where T : IUpdateModel
    {
        Task Update(T data);
    }
}