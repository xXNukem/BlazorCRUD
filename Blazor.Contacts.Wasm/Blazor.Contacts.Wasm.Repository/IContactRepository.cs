using Blazor.Contacts.Wasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Contacts.Wasm.Repository
{
    public interface IContactRepository
    {
        Task<bool> InsertContact(Contact contact);
        Task<bool> DeleteContact(int id);

        Task<bool?> UpdateContact(Contact contact);
        Task<IEnumerable<Contact>> GetAllContacts();
        Task<Contact> GetDetails(int id);
    }
}
