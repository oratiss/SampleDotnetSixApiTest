using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace BasicApi.Test.Middlewares
{
    public class RollBackMiddleware
    {
        private readonly RequestDelegate _next;

        public RollBackMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
