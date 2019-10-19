using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public interface IContactViewModelService
    {
        Task<ContactViewModel> CreateContactAsync(ContactViewModel contactViewModel);
    }
}