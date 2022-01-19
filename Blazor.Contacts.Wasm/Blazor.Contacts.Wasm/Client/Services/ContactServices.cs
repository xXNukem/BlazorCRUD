using Blazor.Contacts.Wasm.Shared;
using System.Net.Http.Json;

namespace Blazor.Contacts.Wasm.Client.Services
{
    public class ContactServices : IContactServices
    {

        private readonly HttpClient _httpClient;

        public ContactServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task DeleteContact(int id)
        {
            await _httpClient.DeleteAsync($"api/contacts/{id}");
        }

        public async Task<IEnumerable<Contact>> GetAll()
        {
           return await _httpClient.GetFromJsonAsync<IEnumerable<Contact>>($"api/contacts");
        }

        public async Task<Contact> GetDetails(int id)
        {
            return await _httpClient.GetFromJsonAsync<Contact>($"api/contacts/{id}");
        }

        public async Task SaveContact(Contact contact)
        {
            if(contact.id == 0)
            {
                //insert
                await _httpClient.PostAsJsonAsync<Contact>($"api/contacts", contact);
            }
            else
            {
                //update
                await _httpClient.PutAsJsonAsync<Contact>($"api/contacts/{contact.id}", contact);
            }
        }
    }
}
