using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace formui {
    class Network {
        private readonly string _apiUrl;
        private readonly IProgress<int> _progress;
        private static readonly HttpClient httpClient = new HttpClient();

        /**
         * Network;
         */
        public Network(string apiUrl, IProgress<int>? progress) {
            _apiUrl = apiUrl ?? throw new ArgumentNullException(nameof(apiUrl));
            _progress = progress;
        }

        /**
         * Public fonksiyonlar;
         */

        public async Task<dynamic> Login(string username, string password) {
            var formData = new Dictionary<string, string> {
                {"username", username },
                {"password", password }
            };
            return await SendFormDataAsync(formData, _apiUrl + "/auth/login");
        }
        public async Task<dynamic> Register(string username, string password, string email) {
            var formData = new Dictionary<string, string> {
                {"username", username },
                {"password", password },
                {"email", email },
                {"phone", "4444444444" },
            };
            return await SendFormDataAsync(formData, _apiUrl + "/auth/register");
        }
        public async Task<dynamic> CheckToken() {
            var formData = new Dictionary<string, string> { };
            return await SendFormDataAsync(formData, _apiUrl + "/auth");
        }

        public async Task<dynamic> SendFile(string filePath) {
            return await UploadFileAsync(filePath);
        }
        public async Task<dynamic> SendString(string text) {
            var formData = new Dictionary<string, string>
        {
            { "text", text },
        };
            return await SendFormDataAsync(formData, _apiUrl + "/textSum");
        }


        /**
         * Private fonksiyonlar;
         */

        /**
         * Send Form Data, Post requesti yolluyor.
         * -
         * Dosya yükleme ve ilerlemeyi izleme;
         * İlk önce dosya yükleniyor, dosya yüklemesi tamamlandıktan sonra farklı bir requestle sonuç listelenecek.
         */
        private static async Task<dynamic> SendFormDataAsync(Dictionary<string, string> formData, string url) {
            // formData'yı FormUrlEncodedContent formatına çeviriyoruz
            var encodedContent = new FormUrlEncodedContent(formData);
            var request = new HttpRequestMessage(HttpMethod.Post, url) {
                Content = encodedContent
            };

            // Eğer token kayıtlıysa header'a ekliyoruz
            string? token = Registery.LoadToken();
            if (!String.IsNullOrEmpty(token)) {
                request.Headers.Add("Authorization", "Bearer " + token);
            }

            var response = await httpClient.SendAsync(request);

            var responseContent = await response.Content.ReadAsStringAsync();

            // JSON verisini dynamic tipine deserialize ediyoruz
            var jsonContent = JsonConvert.DeserializeObject<dynamic>(responseContent) ?? throw new InvalidOperationException("Deserialization failed, result is null.");
            if (!response.IsSuccessStatusCode) jsonContent.haveError = true;

            return jsonContent;
        }

        // Dosya yükleme işlemini başlatan asenkron metod
        private async Task<dynamic> UploadFileAsync(string filePath) {

            var formData = new MultipartFormDataContent();
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var fileContent = new StreamContent(fileStream);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
            formData.Add(fileContent, "file", Path.GetFileName(filePath));
            return await SendFileWithProgressAsync(httpClient, _apiUrl + "/fileSum", formData);
        }

        // Dosyayı asenkron olarak gönderirken ilerlemeyi izleme
        private async Task<dynamic> SendFileWithProgressAsync(HttpClient client, string apiUrl, MultipartFormDataContent formData) {
            var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
            var progressStream = new ProgressableStream(await formData.ReadAsStreamAsync(), _progress);
            request.Content = formData;
            // Eğer token kayıtlıysa header'a ekliyoruz
            string? token = Registery.LoadToken();
            if (!String.IsNullOrEmpty(token)) {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine("Dosya başarıyla yüklendi.");
            var responseContent = await response.Content.ReadAsStringAsync();

            // JSON verisini dynamic tipine deserialize ediyoruz
            return JsonConvert.DeserializeObject<dynamic>(responseContent) ?? throw new InvalidOperationException("Deserialization failed, result is null.");

        }
    }
}