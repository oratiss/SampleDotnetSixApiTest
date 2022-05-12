using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BasicApi.Test.Abstractions;
using Xunit;
using Xunit.Abstractions;

namespace BasicApi.Test.Customers
{
    public class CustomerTest : BaseTestServiceProvider
    {
        private HttpClient? _client;

        public CustomerTest()
        {
            
            var application = new BaseTestServiceProvider().WithWebHostBuilder(builder =>
            {
                Server.PreserveExecutionContext = true;
            });

            _client = application.CreateClient();
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