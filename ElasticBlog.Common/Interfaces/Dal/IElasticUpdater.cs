using System.Threading.Tasks;

namespace ElasticBlog.Common.Interfaces.Dal
{
    public interface IElasticUpdater<in T>
    {
        Task Update(T data);
    }
}