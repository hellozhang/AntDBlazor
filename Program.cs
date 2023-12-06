using ANTBlazor;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IChartService, ChartService>();
//builder.Services.AddEasyNotice(config =>
//{
//    config.IntervalSeconds = 10;//同一标题的消息，10秒内只能发一条，避免短时间内大量发送重复消息
//    config.UseDingTalk(option =>
//    {
//        option.WebHook = "https://oapi.dingtalk.com/robot/send?access_token=dd9371044f8fa37f87d0e2d6aa7779e9e0fe5726fa37d512d07c153829a526ab";//通知地址
//        option.Secret = "SEC85ac2fe0afe69b9d7b74ab53e9858521247477bfa564668a98eac07ae4d5344e";//签名校验
//    });
//});










await builder.Build().RunAsync();
