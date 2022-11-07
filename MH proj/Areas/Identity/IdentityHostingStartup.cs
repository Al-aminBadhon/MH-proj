using System;
using MH_proj.Areas.Identity.Data;
using MH_proj.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(MH_proj.Areas.Identity.IdentityHostingStartup))]
namespace MH_proj.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MH_projDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MH_projDBContextConnection")));

                services.AddDefaultIdentity<CrewUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MH_projDBContext>();
            });
        }
    }
}