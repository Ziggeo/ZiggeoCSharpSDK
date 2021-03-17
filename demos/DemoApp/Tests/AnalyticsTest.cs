using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Xunit;
using Xunit.Abstractions;

namespace ZiggeoDemoApp.Tests
{
    public class AnalyticsTest
    {
        // System Under Test
        private readonly Ziggeo _ziggeo;
        private readonly ITestOutputHelper output;
        
        public AnalyticsTest(ITestOutputHelper output)
        {
            this.output = output;
            _ziggeo = new Ziggeo(Config.ApiKey, Config.PrivateKey, Config.EncryptionKey);
        }

        // [Fact(Skip = "assdasdas")]
        [Theory]
        [InlineData("device_views_by_os", true)]
        [InlineData("device_views_by_date", false)]
        [InlineData("total_plays_by_country", true)]
        [InlineData("full_plays_by_country", false)]
        [InlineData("total_plays_by_hour", true)]
        [InlineData("total_plays_by_browser", false)]
        [InlineData("full_plays_by_browser", false)]
        [InlineData("wrond_query_type", false)]
        [InlineData("wrond_query_type", true)]
        public async Task getAnalyticsData(string query, bool fromDate)
        {
            DateTime aDay = DateTime.Now;
            TimeSpan aMonth = new System.TimeSpan(30, 0, 0, 0); 
            DateTime from = aDay.Subtract(aMonth);
            String errorMessage = null;
            long unixTimeFrom = ((DateTimeOffset) from).ToUnixTimeMilliseconds(); 
            //  query The query you want to run.
            // It can be one of the following: device_views_by_os, device_views_by_date, total_plays_by_country,
            // full_plays_by_country, total_plays_by_hour, full_plays_by_hour, total_plays_by_browser, full_plays_by_browser 
            Dictionary<string, string> dataQuery = new Dictionary<string, string>();
            dataQuery["query"] = query;
            
            if (fromDate)
            {
                dataQuery["date"] = unixTimeFrom.ToString();
            }
            else
            {
                dataQuery["from"] = unixTimeFrom.ToString();
                dataQuery["to"] = ((DateTimeOffset) aDay).ToUnixTimeMilliseconds().ToString();
            }

            try
            {
                JObject data = _ziggeo.analytics().get(dataQuery);
                output.WriteLine("Response: {0}", data);
                Assert.NotNull(data);
            }
            catch (System.Net.WebException e)
            {
                errorMessage = e.Message;
                output.WriteLine("Error Message {0}", e.Message);
            }
            await Task.Delay(1000);
            switch (query)
            {
                // JObect analytics -> "" -> { "os":"Mac OS X 10.16.0","event_count": 6} or NULL
                case("device_views_by_os"): 
                // JObect analytics -> "" -> { "type":"desktop", "date": 20210212, "event_count": 6} or NULL
                case("device_views_by_date"):
                // JObect analytics -> key -> { "country":"Country Name", "event_count": 6} or NULL
                case("total_plays_by_country"):
                // JObect analytics -> key -> { country, event_count} or NULL
                case("full_plays_by_country"):
                // JObect analytics -> key -> { "date": 20210212, hour:"19", "event_count": 2} or NULL
                case("total_plays_by_hour"):
                // JObect analytics -> key -> { device_os, device_browser} or NULL
                case("total_plays_by_browser"):
                // JObect analytics[] OR null
                case("full_plays_by_browser"):
                    Assert.Null(errorMessage);
                    break;
                default:
                    Assert.NotNull(errorMessage);
                    return;
            }

        }

        // [MemberData(TestData)] <- We can add it before out test method
        // public static IEnumerable<object[]> TestData()
        // {
        //     yield return new object[] {"OK", new decimal() {10, 15}};
        // }
    }
}
