using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MssNet.Tests
{
    public class FailureHttpClient : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if ("https://easychannel.it/mss/mss_service.php" == request.RequestUri.ToString())
                return Task.FromResult(new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent("<root><header><error><code>1</code><message>Invalid request.</message></error><result_id>e2b34c8ba3291facf86dcdee69dcd986</result_id><source>hgv_crm</source><paging><count>0</count><total>0</total></paging><time>61.02 ms</time></header></root>") } );

            return null;
        }
    }
}
