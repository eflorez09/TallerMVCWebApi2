using Core.Entities;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IContactService
    {
        Task<Contact> Add(Contact contact);
    }
}