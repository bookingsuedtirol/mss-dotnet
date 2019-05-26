using System.Threading.Tasks;
using Xunit;

namespace MssNet.Tests
{
    public class MssClientTest
    {
        [Fact]
        public async Task SendRequest_GivenInvalidRequest_ShouldThrowMssException()
        {
            var mssClient = new FailureMssClient();
            var exception = await Assert.ThrowsAsync<MssException>(() => mssClient.SendRequest(req =>
            {
                req.Header.Method = "getRoomList"; 
                return req;
            }));

            Assert.Equal("Invalid request.", exception.Message);
        }

        [Fact]
        public void SendRequest_GivenValidRequest_ShouldReturnResponse()
        {
            var mssClient = new SuccessMssClient();
            var response = mssClient.SendRequest(request =>
            {
                request.Header.Method = "getRoomList";
                request.Request.Search = new Models.Request.Search
                {
                    Lang = Models.Request.Languages.German,
                    Id = "9002",
                    IdOfChannel = "hgv",
                };
                return request;
            }).Result;
            Assert.NotNull(response);

            var header = response.Header;
            var error = header.Error;
            Assert.Equal(0, error.Code);
            Assert.Equal("OK", error.Message);
        }
    }
}
