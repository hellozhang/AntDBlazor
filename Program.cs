using ANTBlazor;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://oapi.dingtalk.com/") });
builder.Services.AddScoped<IChartService, ChartService>();

builder.Services.AddMemoryCache(options =>  // 1、添加内存缓存中间件（一般用于粘性会话或单机缓存）
{
    options.SizeLimit = 100;                                    // 缓存的最大大小为100份
    options.ExpirationScanFrequency = TimeSpan.FromSeconds(2);  // 两秒钟查找一次过期项
    options.CompactionPercentage = 0.2;                         // 缓存满了时候压缩20%的优先级较低的数据
    options.TrackStatistics = false;          // 设置是否跟踪内存缓存统计信息。 默认已禁用
    options.TrackLinkedCacheEntries = false;  // 设置是否跟踪链接条目。 默认已禁用
});

//builder.Services.AddHttpClient("WebAPI",
//        client => client.BaseAddress = new Uri("https://www.example.com/base"))
//    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

//builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>()
//    .CreateClient("WebAPI"));
//using Microsoft.AspNetCore.Components.WebAssembly.Authentication

//builder.HostEnvironment.BaseAddress
//builder.Services.AddEasyNotice(config =>
//{
//    config.IntervalSeconds = 10;//同一标题的消息，10秒内只能发一条，避免短时间内大量发送重复消息
//    config.UseDingTalk(option =>
//    {
//        option.WebHook = "https://oapi.dingtalk.com/robot/send?access_token=dd9371044f8fa37f87d0e2d6aa7779e9e0fe5726fa37d512d07c153829a526ab";//通知地址
//        option.Secret = "SEC85ac2fe0afe69b9d7b74ab53e9858521247477bfa564668a98eac07ae4d5344e";//签名校验
//    });
//                                                          //});

//var message2 = new
//{
//    userId = 1,
//    id = 1,
//    title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
//    body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
//};
//var requestUrl = "https://jsonplaceholder.typicode.com/posts";
////var res = await requestUrl
////  .WithHeader("Host", "jsonplaceholder.typicode.com")
////    .WithHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.6045.160 Safari/537.36")
////  .WithHeader("Accept", "application/json")
////  .WithHeader("Access-Control-Allow-Origin", "*")
////             .WithHeader("Origin", "https://jsonplaceholder.typicode.com")
////           .WithHeader("Referer", "https://jsonplaceholder.typicode.com")
////                .WithHeader("Access-Control-Allow-Methods", "GET,POST,PUT,PATCH,DELETE,HEAD,OPTIONS")
////                 .WithHeader("Access-Control-Allow-Headers", "origin,Content-Length,Content-Type,Authorization")
////  .PostJsonAsync(message2);




await builder.Build().RunAsync();
