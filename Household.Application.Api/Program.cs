using Microsoft.Extensions.Hosting;
using Household.Application.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

public class Program {

    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>
      Host.CreateDefaultBuilder(args)
          .ConfigureWebHostDefaults(webBuilder =>
          {
              webBuilder.ConfigureKestrel(options =>
              {
                  options.RequestHeaderEncodingSelector = encoding =>
                  {
                      return encoding switch
                      {
                          "Host" => System.Text.Encoding.Latin1,
                          _ => System.Text.Encoding.UTF8,
                      };
                  };
              });
              webBuilder.UseStartup<Startup>();
          });
}

//https://learn.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-5.0