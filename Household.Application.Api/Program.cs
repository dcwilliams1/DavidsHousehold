using Household.Application.Service;
using Household.Application.Service.Interface;
using Household.Supplements.Domain.Model.Entity;
using Household.SharedKernel.EntityFramework;
using Household.SharedKernel.Data.Repository;
using Microsoft.Extensions.Hosting;
using Household.Application.Api;
using Microsoft.AspNetCore.Hosting;

public class Program {

    public static void Main()
    {

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
