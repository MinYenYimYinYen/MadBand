using MadBand.Application.Interfaces;
using MadBand.Persistance;
using MadBand.WebApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System.Reflection;
using MadBand.Application.Infrastructure.AutoMapper;
using MediatR;
using MediatR.Pipeline;
using MadBand.Application.Infrastructure;
using CommonCode;

namespace MadBand.WebApp
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.Configure<CookiePolicyOptions>(options =>
			{
				// This lambda determines whether user consent for non-essential cookies is needed for a given request.
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});


			// Add DbContext using SQL Server Provider
			services.AddDbContext<MadBandDbContext>(options =>
					options.UseSqlServer(Configuration.GetConnectionString("MadBandDb")));

			#region Northwind Emulation
			// Add Automapper
			services.AddAutoMapper(new Assembly[] { typeof(AutoMapperProfile).GetTypeInfo().Assembly });

			// Add framework services.


			// Add Mediatr
			services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>));
			services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehavior<,>));
			services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
			services.AddMediatR();

			#endregion

			#region My DI
			//services.AddTransient(typeof(IMadBandDbContext), typeof(MadBandDbContext));

			#endregion




			services.AddDefaultIdentity<IdentityUser>()
					.AddDefaultUI(UIFramework.Bootstrap4)
					.AddEntityFrameworkStores<MadBandDbContext>();

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseDatabaseErrorPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseCookiePolicy();

			app.UseAuthentication();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
									name: "default",
									template: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
