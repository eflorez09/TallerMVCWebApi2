using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAsyncRepository<T>
    {
        Task<T> AddAsync(T entity);
    }
}