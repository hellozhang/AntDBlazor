using ANTBlazor;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://oapi.dingtalk.com/") });
builder.Services.AddScoped<IChartService, ChartService>();

builder.Services.AddMemoryCache(options =>  // 1������ڴ滺���м����һ������ճ�ԻỰ�򵥻����棩
{
    options.SizeLimit = 100;                                    // ���������СΪ100��
    options.ExpirationScanFrequency = TimeSpan.FromSeconds(2);  // �����Ӳ���һ�ι�����
    options.CompactionPercentage = 0.2;                         // ��������ʱ��ѹ��20%�����ȼ��ϵ͵�����
    options.TrackStatistics = false;          // �����Ƿ�����ڴ滺��ͳ����Ϣ�� Ĭ���ѽ���
    options.TrackLinkedCacheEntries = false;  // �����Ƿ����������Ŀ�� Ĭ���ѽ���
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
//    config.IntervalSeconds = 10;//ͬһ�������Ϣ��10����ֻ�ܷ�һ���������ʱ���ڴ��������ظ���Ϣ
//    config.UseDingTalk(option =>
//    {
//        option.WebHook = "https://oapi.dingtalk.com/robot/send?access_token=dd9371044f8fa37f87d0e2d6aa7779e9e0fe5726fa37d512d07c153829a526ab";//֪ͨ��ַ
//        option.Secret = "SEC85ac2fe0afe69b9d7b74ab53e9858521247477bfa564668a98eac07ae4d5344e";//ǩ��У��
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
