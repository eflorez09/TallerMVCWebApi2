using Core.Entities;
using Core.Interfaces;
using System.Threading.Tasks;

namespace Core.Services
{
    public class ContactService : IContactService
    {
        private readonly IAsyncRepository<Contact> _contactRepository;

        public ContactService(IAsyncRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<Contact> Add(Contact contact)
        {
            return await _contactRepository.AddAsync(contact);
        }
    }
}