using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace TesteConexao
{
    public class Communication
    {
        private readonly HttpClient _httpClient;

        public Communication()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetResponseAsync(string user, string password, string url)
        {
            ConfigureBasicAuth(user, password);

            return await SendRequestAsync(HttpMethod.Get, url);
        }

        public async Task<string> PostResponseAsync(string url, string jsonPayload)
        {
            return await SendRequestAsync(HttpMethod.Post, url, jsonPayload);
        }

        public async Task<string> PostResponseWithCredentialsAsync(string user, string password, string url)
        {
            var requestDto = new { email = user, senha = password };
            return await SendRequestAsync(HttpMethod.Post, url, requestDto);
        }

        private void ConfigureBasicAuth(string user, string password)
        {
            var byteArray = Encoding.ASCII.GetBytes($"{user}:{password}");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }

        private async Task<string> SendRequestAsync(HttpMethod method, string url, object payload = null)
        {
            using var requestMessage = new HttpRequestMessage(method, url);

            if (payload != null)
                SetJsonContent(requestMessage, payload);

            try
            {
                var response = await _httpClient.SendAsync(requestMessage);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                throw new Exception($"Erro na solicitação HTTP: {e.Message}", e);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro inesperado: {e.Message}", e);
            }
        }

        private void SetJsonContent(HttpRequestMessage requestMessage, object data)
        {
            var content = JsonConvert.SerializeObject(data, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            });
            requestMessage.Content = new StringContent(content, Encoding.UTF8, "application/json");
        }
    }
}
