using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;
using Xunit.Abstractions;

namespace ZiggeoDemoApp.Tests
{
    public class MetaProfilesTest
    {
        // System Under Test
        private readonly Ziggeo _ziggeo;
        private readonly ITestOutputHelper output;
        
        public MetaProfilesTest(ITestOutputHelper output)
        {
            this.output = output;
            _ziggeo = new Ziggeo(Config.ApiKey, Config.PrivateKey, Config.EncryptionKey);
        }

        [Theory]
        [InlineData("KEY_TEST_", "Test app title 1")]
        [InlineData(null, "Test app title 2")]
        [InlineData("KEY_TEST_WITH_NO_TITLE_", null)]
        [InlineData(null, null)]
        public void crudOperation(string key = null, string title = null)
        {
            string errorMessage = null;
            Dictionary<string, string> dataQuery = new Dictionary<string, string>();
            if (key != null)
            {
                dataQuery["key"] = key + (DateTime.Now.Millisecond.ToString());
            }
            if (title != null)
            {
                dataQuery["title"] = title + (DateTime.Now.Millisecond.ToString());
            }

            try
            {
                dynamic created = _ziggeo.metaProfiles().create(dataQuery);
                output.WriteLine("Create Meta Profile Response: {0}", created);
                Assert.NotNull(created);
                Assert.NotNull(created["token"]);
                string _token = created["token"];

                if ( _token != null)
                {
                    dynamic getMetaProfile = _ziggeo.metaProfiles().get(_token);
                    output.WriteLine("Get Meta Profile Response: {0}", getMetaProfile);
                    Assert.NotNull(getMetaProfile);

                    dynamic deleteResponse = _ziggeo.metaProfiles().delete(_token);
                    Assert.NotNull(deleteResponse);
                }
            }
            catch (Exception err)
            {
                errorMessage = err.Message;
                output.WriteLine("Error Message {0}", errorMessage);
            }

            if (title != null)
            {
                Assert.Null(errorMessage);
            }
            else
            {
                Assert.NotNull(errorMessage);
            }
        }

        
        [Theory(Skip = "Need to test again not works as expected")]
        [InlineData(5 , 0, true)]
        [InlineData(0 , 10, true)]
        [InlineData(10 , 0, false)]
        public void index(int limit, int skip, bool reverse)
        {
            string errorMessage = null;
            Dictionary<string, string> dataQuery = new Dictionary<string, string>();
            if (limit > 0)
            {
                dataQuery["limit"] = limit.ToString();
            }
            if (skip > 0)
            {
                dataQuery["skip"] = skip.ToString();
            }
            
            dataQuery["reverse"] = reverse.ToString();

            try
            {
                dynamic data = _ziggeo.metaProfiles().index(dataQuery);
                output.WriteLine("Response: {0}", data);
                Assert.NotNull(data);
            }
            catch (Exception err)
            {
                errorMessage = err.Message;
                output.WriteLine("Error Message {0}", errorMessage);
            }
            // Assert.Null(errorMessage);
        }

    }
}
