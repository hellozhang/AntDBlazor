using Flurl.Http;
using RestSharp;
namespace ANTBlazor
{
    public class ChartService : IChartService
    {
        HttpClient _http;
        public ChartService(HttpClient http)
        {
            _http = http;
        }
        public async Task<string> AddRecord()
        {
            var row = new
            {
                records = new[]
                {
                    new {
                         fields= new
                         {
                              Name= "QWE33",
                              Code="10902",
                              StartDate="2023-11-02",
                              StartValue= "1.09",
                              CurrentValue=" 1.2"
                          }
                    }
                },
                fieldKey = "name"
            };
            string requestUrl = "https://api.vika.cn/fusion/v1/datasheets/dst1CSXS5xqdZJHTLZ/records?viewId=viweVLj1Hwwqs&fieldKey=name";
            var res = await requestUrl
                .WithHeader("Authorization", "Bearer uskKX37HkZuodf8VkY7CiQ1")
                .WithHeader("Accept", "application/json")
                .PostJsonAsync(row);
            var s = res.GetStringAsync();
            return res.ToString();
        }
    }
    public interface IChartService
    {
        Task<string> AddRecord();
    }
}
