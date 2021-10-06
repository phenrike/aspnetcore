using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

public class MyMiddleware
{
    private readonly RequestDelegate _next;

    public MyMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        Console.WriteLine("\n\r   ~~~~~~~~ Before ~~~~~~~~  \n\r");

        await _next(httpContext);

        Console.WriteLine("\n\r   ~~~~~~~~  After ~~~~~~~~  \n\r");
    }
}