using Xunit;

namespace MssNet.Tests
{
    public class MssClientHelperTest
    {
        [Fact]
        public void CreateRequestWithDefaults_ShouldSetVersion()
        {
            var request = MssClientHelper.CreateRequestWithDefaults(null);
            Assert.Equal("2.0", request.Version);
        }

        [Fact]
        public void CreateRequestWithDefaults_GivenClientSettings_ShouldSetCredentials()
        {
            var clientSettings = new MssClientSettings("myUser", "secret", "mySource");
            var request = MssClientHelper.CreateRequestWithDefaults(clientSettings);

            var header = request.Header;
            var credentials = header.Credentials;
            Assert.Equal("myUser", credentials.User);
            Assert.Equal("secret", credentials.Password);
            Assert.Equal("mySource", credentials.Source);
        }
        
        [Fact]
        public void CreateRequestWithDefaults_GivenNullRequest_ShouldSetDefaultRequestWithLanguage()
        {
            var request = MssClientHelper.CreateRequestWithDefaults(null);

            Assert.NotNull(request.Request);
            Assert.NotNull(request.Request.Search);
            Assert.Equal("de", request.Request.Search.Lang);
        }
    }
}
