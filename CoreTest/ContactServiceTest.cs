using Core.Entities;
using Core.Interfaces;
using Core.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CoreTest
{
    public class ContactServiceTest
    {
        private Mock<IAsyncRepository<Contact>> _contactRepository;

        public ContactServiceTest()
        {
            _contactRepository = new Mock<IAsyncRepository<Contact>>();
        }

        [Fact]
        public async Task CreateContactTest()
        {
            Contact contact = new Contact
            {
                Name = "Elver Florez",
                Email = "elver@mail.com",
                Phone = "3123456789",
                Message = "Hola",
                RegistrationDate = DateTime.Now
            };

            ContactService contactService = new ContactService(_contactRepository.Object);
            await contactService.Add(contact);

            _contactRepository.Verify(x => x.AddAsync(contact));
        }
    }
}