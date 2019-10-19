using Core.Entities;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IContactRepository : IAsyncRepository<Contact>
    {
        Task<Contact> CreateContactAsync(Contact contact);
    }
}