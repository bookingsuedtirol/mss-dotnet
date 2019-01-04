using System.Net.Http;

namespace MssNet.Tests
{
    public class SuccessMssClient : MssClient
    {
        public SuccessMssClient() : base(null)
        {
        }

        public SuccessMssClient(MssClientSettings settings) : base(settings)
        {
        }

        protected override HttpClient HttpClient => new HttpClient(new SuccessHttpClient());
    }
}
