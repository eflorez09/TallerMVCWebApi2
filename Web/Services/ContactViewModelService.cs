using Core.Entities;
using Microsoft.Extensions.Logging;
using Core.Interfaces;
using System.Threading.Tasks;
using Web.Models;
using System;

namespace Web.Services
{
    public class ContactViewModelService : IContactViewModelService
    {
        private readonly ILogger<ContactViewModelService> _logger;
        private readonly IAsyncRepository<Contact> _contactRepository;

        public ContactViewModelService(ILoggerFactory loggerFactory, IAsyncRepository<Contact> contactRepository)
        {
            _logger = loggerFactory.CreateLogger<ContactViewModelService>();
            _contactRepository = contactRepository;
        }

        public async Task<ContactViewModel> CreateContactAsync(ContactViewModel contactViewModel)
        {
            Contact contact = new Contact
            {
                Name = contactViewModel.Name,
                Email = contactViewModel.Email,
                Phone = contactViewModel.Phone,
                Message = contactViewModel.Message,
                RegistrationDate = DateTime.Now
            };

            contact = await _contactRepository.AddAsync(contact);

            return contactViewModel;
        }
    }
}