using Core.Interfaces;
using System.Threading.Tasks;

namespace Data.Catalog
{
    public class EfRepository<T> : IAsyncRepository<T>
    {
        protected readonly CatalogContext _dbContext;

        public EfRepository(CatalogContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<T> AddAsync(T entity)
        {
            _dbContext.Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }
    }
}