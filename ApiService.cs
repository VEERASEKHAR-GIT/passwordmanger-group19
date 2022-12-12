using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using PasswodManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PasswodManager
{
    public class ApiService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;

        public List<PasswordItem> listOfItems { get; private set; }


            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return listOfItems;
        }

     
        public async Task SaveTodoItemAsync(PasswordPostModel item)
        {
            Uri uri = new Uri(string.Format("https://pocketbase-abby.fly.dev/api/collections/secrets/records", string.Empty));

            try
            {
                string json = JsonSerializer.Serialize<PasswordPostModel>(item, _serializerOptions);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;

                response = await _client.PostAsync(uri, content);
            }
            catch (Exception ex)
            {

            }
        }

        public async Task<bool> createUser(string email, string pass)
        {
            Uri uri = new Uri(string.Format("https://pocketbase-abby.fly.dev/api/collections/users/records", string.Empty));

            try
            {
                var loginModel = new LoginModel();
                loginModel.email = email;
                loginModel.password = pass;
                loginModel.passwordConfirm = pass;
                string json = JsonSerializer.Serialize<LoginModel>(loginModel, _serializerOptions);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;

                response = await _client.PostAsync(uri, content);
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }


        public async Task<String> loginUser(string email, string pass)
        {
            Uri uri = new Uri(string.Format("https://pocketbase-abby.fly.dev/api/collections/users/auth-with-password", string.Empty));

            try

            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
