using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;
using Xunit.Abstractions;

namespace ZiggeoDemoApp.Tests
{
    public class AuthTest
    {
        // System Under Test
        private readonly Ziggeo _ziggeo;
        private readonly string _authToken;
        private readonly ITestOutputHelper output;
        
        public AuthTest(ITestOutputHelper output)
        {
            this.output = output;
            _authToken = Config.AuthToken;
            _ziggeo = new Ziggeo(Config.ApiKey, Config.PrivateKey, Config.EncryptionKey);
        }

        // [Fact(Skip = "assdasdas")]
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void get(bool wrongToken)
        {
            string errorMessage = null;
            string _apiToken = wrongToken ? this._authToken + "_WRONG_TOKEN" : this._authToken;
            try
            {
                JObject data = _ziggeo.authtokens().get(_apiToken);
                output.WriteLine("Response: {0}", data);
                Assert.NotNull(data);
            }
            catch (System.Net.WebException e)
            {
                errorMessage = e.Message;
                output.WriteLine("Error Message {0}", e.Message);
            }

            if (wrongToken) 
                Assert.NotNull(errorMessage);
            else 
                Assert.Null(errorMessage);
        }
        
        [Theory]
        [InlineData("Default")]
        public void updateApplication(String name)
        {
            Dictionary<string, string> dataQuery = new Dictionary<string, string>()
            {
                {"name", name},
                {"volatile", "false"},
                {"auth_token_required_for_create", "true"},
                {"auth_token_required_for_update", "false"},
                {"auth_token_required_for_read", "false"},
                {"auth_token_required_for_destroy", "true"},
                {"client_can_index_videos", "true"},
                {"client_cannot_access_unaccepted_videos", "false"},
                {"enable_video_subpages", "false"},
            };
            string errorMessage = null;
            try
            {
                JObject data = _ziggeo.application().update(dataQuery);
                output.WriteLine("Response: {0}", data);
                Assert.NotNull(data);
            }
            catch (System.Net.WebException e)
            {
                errorMessage = e.Message;
                output.WriteLine("Error Message {0}", e.Message);
            }
            Assert.Null(errorMessage);
        }

        [Theory]
        [InlineData("year")]
        [InlineData("month")]
        [InlineData(null)]
        [InlineData("invalid")]
        public void getStats(string period)
        {
            string errorMessage = null;
            Dictionary<string, string> dataQuery = new Dictionary<string, string>();
            if (period != null)
            {
                dataQuery["period"] = period;
            }
            
            try
            {
                JObject data = _ziggeo.application().get_stats(dataQuery);
                output.WriteLine("Response: {0}", data);
                Assert.NotNull(data);
            }
            catch (System.Net.WebException e)
            {
                errorMessage = e.Message;
                output.WriteLine("Error Message {0}", e.Message);
            }
            if (period == "invalise")
                Assert.NotNull(errorMessage);
            else
                Assert.Null(errorMessage);
        }
    }
}
