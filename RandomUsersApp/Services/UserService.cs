using System.Text.Json;
using System.Net.Http.Json;
using System.Net.Http.Headers;

using RandomUsersApp.Models;
using RandomUsersApp.Helpers;

namespace RandomUsersApp.Services
{
    public class UserService : IUserService
    {
        HttpClient client;

        private static JsonSerializerOptions options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };

        public UserService()
        {
            client = new HttpClient();

            client.BaseAddress = new Uri(Constants.RandomDataServer);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IEnumerable<User>?> GetUsers()
        {
            var response = await client.GetAsync(Constants.UsersEndpoint);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<IEnumerable<User>>(options);

            return default;
        }
    }
}
