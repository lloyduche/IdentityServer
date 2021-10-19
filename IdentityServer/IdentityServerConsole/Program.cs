using IdentityModel.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace IdentityServerConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var discoveryDocumentHttpClient = new HttpClient())
            {
                var discoveryDocument = await discoveryDocumentHttpClient.GetDiscoveryDocumentAsync("https://localhost:5001");
                Console.WriteLine(discoveryDocument.TokenEndpoint);
            }
        }
    }
}
