using System.Net.Http;

namespace MssNet.Tests
{
    public class FailureMssClient : MssClient
    {
        public FailureMssClient() : base(null)
        {
        }

        public FailureMssClient(MssClientSettings settings) : base(settings)
        {
        }

        protected override HttpClient HttpClient => new HttpClient(new FailureHttpClient());
    }
}
