using AntDesign;

using EasyNotice.Dingtalk;

using Flurl.Http;

using Microsoft.AspNetCore.Components.WebAssembly.Http;

using Org.BouncyCastle.Asn1.Crmf;


using RestSharp;

using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

using static System.Net.WebRequestMethods;

namespace ANTBlazor
{
    public class ChartService : IChartService
    {
        public async Task<string> GetSO()
        {


          //  // create request object
          //  var request = new HttpRequestMessage(HttpMethod.Post, "https://jsonplaceholder.typicode.com/posts");

          //  // set request body
          //  var message2 = new
          //  {
          //      userId = 1,
          //      id = 1,
          //      title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
          //      body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
          //  };
          //  request.Content = new StringContent(JsonSerializer.Serialize(message2), Encoding.UTF8, "application/json");

          //  // add authorization header
          //  //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "my-token");

          //  // add custom http header
          //  request.Headers.Add("My-Custom-Header", "foobar");

          //  // send request
          //  using var response = await HttpClient.SendAsync(request);

          //  // convert response data to Article object
          //var  article = await response.Content.ReadFromJsonAsync<Article>();





            //string url = $"https://xizhi.qqoq.net/XZ375e1d6fb7f77722b95d07a80c4fe67a.send?title=\"白天\"&content=\"内容\"";

            //var rs = await url.GetAsync();


            //string url = $"https://xizhi.qqoq.net/XZ375e1d6fb7f77722b95d07a80c4fe67a.send?title=\"白天\"&content=\"内容\"";

            //var rs = await url.PostAsync();



            var message = new
            {
                msgtype = "markdown",
                markdown = new
                {
                    title = "这个是设置的关键词",
                    text = $"新订单：有新订单，请及时处理"
                }
            };

            string webHook = "https://oapi.dingtalk.com/robot/send?access_token=dd9371044f8fa37f87d0e2d6aa7779e9e0fe5726fa37d512d07c153829a526ab";
            string Secret = "SEC85ac2fe0afe69b9d7b74ab53e9858521247477bfa564668a98eac07ae4d5344e";
            var requestUrl = DingTalkHelper.GetRequestUrl(webHook, Secret);
            var res = await requestUrl
              .WithHeader("Host", "oapi.dingtalk.com")
                .WithHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.6045.160 Safari/537.36")
              .WithHeader("Accept", "application/json")
              .WithHeader("Access-Control-Allow-Origin", "*")
                  .WithHeader("access_token", "dd9371044f8fa37f87d0e2d6aa7779e9e0fe5726fa37d512d07c153829a526ab")
                      .WithHeader("timestamp", "1701846212301")
                         .WithHeader("Origin", "https://oapi.dingtalk.com")
                            .WithHeader("Access-Control-Allow-Methods", "GET,POST,PUT,PATCH,DELETE,HEAD,OPTIONS")
                             .WithHeader("Access-Control-Allow-Headers", "origin,Content-Length,Content-Type,Authorization")
                         .WithHeader("Referer", "https://oapi.dingtalk.com")
                           .WithHeader("sign", "1H%2fBN1tJBXBQ57mWJUQdNHQLxJFPkcWSZhfSkhno1Dc%3d")
                         

              .PostJsonAsync(message);






            return "";
        }
    }
    public interface IChartService
    {
        Task<string> GetSO();
    }
}
