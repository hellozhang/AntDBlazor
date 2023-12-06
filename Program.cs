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
//    config.IntervalSeconds = 10;//ͬһ�������Ϣ��10����ֻ�ܷ�һ���������ʱ���ڴ��������ظ���Ϣ
//    config.UseDingTalk(option =>
//    {
//        option.WebHook = "https://oapi.dingtalk.com/robot/send?access_token=dd9371044f8fa37f87d0e2d6aa7779e9e0fe5726fa37d512d07c153829a526ab";//֪ͨ��ַ
//        option.Secret = "SEC85ac2fe0afe69b9d7b74ab53e9858521247477bfa564668a98eac07ae4d5344e";//ǩ��У��
//    });
//});










await builder.Build().RunAsync();
