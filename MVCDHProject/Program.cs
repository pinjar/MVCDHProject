using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using MVCDHProject.Models;


namespace MVCDHProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //builder.Services.AddControllersWithViews();
            builder.Services.AddControllersWithViews(configure =>
            {
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                configure.Filters.Add(new AuthorizeFilter(policy));
            });

            builder.Services.AddScoped<ICustomerDAL, CustomerSqlDAL>();

            builder.Services.AddDbContext<MVCCoreDbContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("ConStr")));

            //builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<MVCCoreDbContext>();
            builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<MVCCoreDbContext>().AddDefaultTokenProviders();

            builder.Services.AddAuthentication()
                .AddGoogle(options =>
                {
                    options.ClientId = "710489140871-aeqsmb3uemkpmipqqi1ok8tfcaa9bshg.apps.googleusercontent.com";
                    options.ClientSecret = "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";
                })
                .AddFacebook(options =>
                {
                    options.AppId = "1183763202992376";
                    options.AppSecret = "fb4887db78ed61e37635773f3c3fcd77";
                });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                //app.UseStatusCodePages();
                //app.UseStatusCodePagesWithRedirects("/ClientError/{0}");
                app.UseStatusCodePagesWithReExecute("/ClientError/{0}");
                app.UseExceptionHandler("/ServerError");
                app.UseHsts();
            }


            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
