using Blazorise;
using Blazorise.Icons.Material;
using Blazorise.Material;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using System.Net.Http;

namespace Covignite
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddRazorPages();
			services.AddHttpContextAccessor();
			services.AddServerSideBlazor();

			services.AddBlazorise(options =>
			{
				options.ChangeTextOnKeyPress = true; // optional
			})
			.AddMaterialProviders()
			.AddMaterialIcons();


			//This below also need to use the HTTP from server side blazor.
			services.AddResponseCompression(opts =>
			{
				opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
					new[] { "application/octet-stream" });
			});

			// Server Side Blazor doesn't register HttpClient by default
			if (!services.Any(x => x.ServiceType == typeof(HttpClient)))
			{
				// Setup HttpClient for server side in a client side compatible fashion
				services.AddScoped<HttpClient>(s =>
				{
					// Creating the URI helper needs to wait until the JS Runtime is initialized, so defer it.
					var uriHelper = s.GetRequiredService<NavigationManager>();
					return new HttpClient
					{
						BaseAddress = new Uri(uriHelper.BaseUri)
					};
				});
			}
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseRouting();

			app.ApplicationServices
				.UseMaterialProviders()
				.UseMaterialIcons();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
				endpoints.MapBlazorHub();
				endpoints.MapFallbackToPage("/_Host");
			});
		}
	}
}
