using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JsonClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkClass>();
        }
    }

    public class BenchmarkClass
    {
        private static HttpClient HttpClient = new HttpClient();

        [Benchmark]
        public static async Task SendSmallRequestToServer()
        {
            var req = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5001/small");
            req.Content = new StringContent(JsonConvert.SerializeObject(Shared.SmallRequest.Create()), Encoding.UTF8, "application/json");

            var result = await HttpClient.SendAsync(req).ConfigureAwait(false);

            var resultString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

            var model = JsonConvert.DeserializeObject<SmallResponse>(resultString);
        }

        [Benchmark]
        public static async Task SendHugeRequestToServer()
        {
            var req = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5001/huge");
            req.Content = new StringContent(JsonConvert.SerializeObject(Shared.HugeRequest.Create()), Encoding.UTF8, "application/json");

            var result = await HttpClient.SendAsync(req).ConfigureAwait(false);

            var resultString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

            var model = JsonConvert.DeserializeObject<HugeResponse>(resultString);
        }
    }
}
