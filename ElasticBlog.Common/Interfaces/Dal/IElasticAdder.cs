using System.Threading.Tasks;

namespace ElasticBlog.Common.Interfaces.Dal
{
    public interface IElasticAdder<in T>
    {
        Task Add(T data);
    }
}