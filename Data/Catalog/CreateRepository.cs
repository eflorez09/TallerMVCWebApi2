using Core.Entities;
using Core.Interfaces;
using Data.Catalog;
using System.Threading.Tasks;

namespace Data
{
    public class CreateRepository : EfRepository<Contact>, IContactRepository
    {
        public CreateRepository(CatalogContext dbContext) : base(dbContext)
        {
        }

        public Task<Contact> CreateContactAsync(Contact contact)
        {
            _dbContext.Contacts.Add(contact);
            _dbContext.SaveChangesAsync();

            return Task.FromResult(contact);
        }
    }
}