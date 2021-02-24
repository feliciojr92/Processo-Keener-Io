using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProcessoKeenerIO.Areas.Identity.Data;
using ProcessoKeenerIO.Data;

[assembly: HostingStartup(typeof(ProcessoKeenerIO.Areas.Identity.IdentityHostingStartup))]
namespace ProcessoKeenerIO.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ProcessoDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ProcessoDbContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<ProcessoDbContext>();
            });
        }
    }
}