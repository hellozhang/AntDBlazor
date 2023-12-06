
using EasyNotice;

using Microsoft.AspNetCore.Components;

namespace AntDesign.Pro.Template.Pages.Dashboard.Workplace {
  public partial class Index {

        [Inject] public IDingtalkProvider _dingtalkProvider { get; set; }

        [Inject] public IEmailProvider emailProvider { get; set; }

        protected override async void OnInitialized()
        {

        }
        protected override async Task OnInitializedAsync() {
   
            emailProvider.SendAsync("测试", new Exception("1"));
            _dingtalkProvider.SendActionCardAsync("MASA Framework", "NET下一代微服务开发框架，内嵌分布式运行时——Dapr云原生最佳实践，能够快速实现分布式、微服务、DDD、SaaS等现代化应用开发", "MASA", "https://www.masastack.com/?bd_vid=7933115264263957354");
        }
    }
}