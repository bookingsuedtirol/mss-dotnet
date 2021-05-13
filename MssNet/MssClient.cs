using System;
using MssNet.Xml;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MssNet
{
    public class MssClient : IDisposable
    {
        private HttpClient _httpClient;

        public MssClient(MssClientSettings settings)
        {
            Settings = settings;
            _httpClient = new HttpClient();
        }

        public MssClient(MssClientSettings settings, HttpClient httpClient)
        {
            Settings = settings;
            _httpClient = httpClient;
        }

        private MssClientSettings Settings { get; set; }
        private XmlSerializer XmlSerializer { get; } = new XmlSerializer();
        private XmlDeserializer XmlDeserializer { get; } = new XmlDeserializer();
        protected virtual HttpClient HttpClient { get { return _httpClient; } }

        public async Task<Models.Response.Root> SendRequest(Func<Models.Request.Root, Models.Request.Root> requestFunc)
        {
            var request = requestFunc(MssClientHelper.CreateRequestWithDefaults(Settings));
            var xmlContent = ParseRequest(request);
            var httpContent = PrepareHttpContent(xmlContent);
            var httpResponse = await Post(httpContent);
            var responseAsString = await httpResponse.Content.ReadAsStringAsync();
            var response = ParseResponse(responseAsString);

            var header = response.Header;
            var error = header.Error;
            if (error.Code > 0)
                throw new MssException(error.Message);

            return response;
        }

        private string ParseRequest(Models.Request.Root request)
        {
            return XmlSerializer.SerializeObject(request);
        }

        private HttpContent PrepareHttpContent(string xmlContent)
        {
            return new StringContent(xmlContent, Encoding.UTF8, "application/xml");
        }

        private Task<HttpResponseMessage> Post(HttpContent content)
        {
            return HttpClient.PostAsync("https://easychannel.it/mss/mss_service.php", content);
        }

        private Models.Response.Root ParseResponse(string responseAsString)
        {
            return XmlDeserializer.Deserialize<Models.Response.Root>(responseAsString);
        }

        public void Dispose()
        {
            if (_httpClient != null)
            {
                _httpClient.Dispose();
                _httpClient = null;
            }
        }
    }
}
