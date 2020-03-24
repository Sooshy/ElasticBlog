using System.Threading.Tasks;

namespace ElasticBlog.Common.Interfaces.Dal
{
    public interface IElasticDeleter
    {
        Task Delete(string id);
    }
}