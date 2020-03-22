using System.Threading.Tasks;

namespace ElasticBlog.Common.Interfaces.Bl
{
    public interface IAdderLogic<in T>
    {
        Task Add(T data);
    }
}