using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BasicApi.Test.Abstractions;
using BasicApi.Test.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Xunit.Abstractions;

namespace BasicApi.Test.Customers
{
    public class CustomerTest : BaseTestServiceProvider
    {
        private HttpClient? _client;

        public CustomerTest()
        {
            
            var applicationFactory = new BaseTestServiceProvider().WithWebHostBuilder(builder =>
            {
                builder.Configure(app =>
                {
                    app.UseMiddleware<RollBackMiddleware>();
                });

                Server.PreserveExecutionContext = true;
            });

            _client = applicationFactory.CreateClient();
        }

        [Fact]
        public async Task Initial_test()
        {
            var someCustomer = this.CreateSomeCustomer();
            var jsonContent = JsonContent.Create(someCustomer);

            try
            {
                var response = await _client?.PostAsync("api/Customers", jsonContent);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }




        }
    }
}