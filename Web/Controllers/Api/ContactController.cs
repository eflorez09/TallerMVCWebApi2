using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web.Models;
using Web.Services;

namespace Web.Controllers.Api
{
    public class ContactController : ControllerBase
    {
        private readonly IContactViewModelService _contactViewModelService;

        public ContactController(IContactViewModelService contactViewModelService)
        {
            _contactViewModelService = contactViewModelService;
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactViewModel contact)
        {
            if (ModelState.IsValid)
            {
                contact = await _contactViewModelService.CreateContactAsync(contact);
                return Ok(contact);
            }

            return BadRequest(ModelState);
        }
    }
}