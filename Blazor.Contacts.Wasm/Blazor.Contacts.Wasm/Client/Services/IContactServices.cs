using Blazor.Contacts.Wasm.Shared;

namespace Blazor.Contacts.Wasm.Client.Services
{
    public interface IContactServices
    {
        Task SaveContact(Contact contact);
        Task DeleteContact(int id);
        Task <IEnumerable <Contact>> GetAll();
        Task<Contact> GetDetails(int id);
    }
}
