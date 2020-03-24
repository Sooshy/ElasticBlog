using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElasticBlog.Common.Interfaces.Dal
{
    public interface IElasticSearcher<TResult, in TCondition>
    {
        Task<IEnumerable<TResult>> Search(TCondition search);
    }
}