using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace Endpoin_Service
{
    public static class GetBacked
    {
        [FunctionName("GetBacked")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = "getbackend/name/{name}")]HttpRequestMessage req, string name, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, "Hello " + name);
        }
    }
}
