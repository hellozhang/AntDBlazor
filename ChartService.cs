using AntDesign;
using EasyNotice.Dingtalk;

using Flurl.Http;
using Org.BouncyCastle.Asn1.Crmf;


using RestSharp;

namespace ANTBlazor
{
    public class ChartService:IChartService
    {
        public async Task<string> GetSO()
        {
















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
              .WithHeader("Accept", "application/json")
              .WithHeader("Access-Control-Allow-Origin", "*")
                  .WithHeader("access_token", "dd9371044f8fa37f87d0e2d6aa7779e9e0fe5726fa37d512d07c153829a526ab")
                      .WithHeader("timestamp", "1701846212301")
                         .WithHeader("Origin", "https://oapi.dingtalk.com")
                         .WithHeader("Referer", "https://oapi.dingtalk.com")
                           .WithHeader("sign", "1H%2fBN1tJBXBQ57mWJUQdNHQLxJFPkcWSZhfSkhno1Dc%3d")
              .PostJsonAsync(message).ReceiveString();









            return "";
        }
    }
    public interface IChartService
    {
        Task<string> GetSO();
    }
}
