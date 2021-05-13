using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MssNet.Tests
{
    public class SuccessHttpClient : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if ("https://easychannel.it/mss/mss_service.php" == request.RequestUri.ToString())
                return Task.FromResult(new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent("<root><header><error><code>0</code><message>OK</message></error><result_id>e2b34c8ba3291facf86dcdee69dcd986</result_id><source>hgv_crm</source><paging><count>1</count><total>1</total></paging><time>61.02 ms</time></header><result><hotel><id>9002</id><id_lts /><bookable>1</bookable><channel><channel_id>hgv</channel_id><room_description><room><room_id>25722</room_id><room_type>1</room_type><room_code>testzimm</room_code><room_lts_id /></room><room><room_id>25723</room_id><room_type>1</room_type><room_code>EZK</room_code><room_lts_id /></room><room><room_id>25724</room_id><room_type>1</room_type><room_code>DZ</room_code><room_lts_id /></room><room><room_id>25725</room_id><room_type>1</room_type><room_code>DBZ</room_code><room_lts_id /></room></room_description></channel></hotel></result><debug /></root>") } );

            return null;
        }
    }
}
