using Microsoft.Extensions.DependencyInjection;
using TimeManagement.Data;
using TimeManagement.Data.BL;
using TimeManagement.Data.DL;

namespace TimeManagement.UI
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var services = new ServiceCollection();
			ConfigureServices(services);
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			using (var serviceProvider = services.BuildServiceProvider())
			{
				var form = serviceProvider.GetRequiredService<MainForm>();
				Application.Run(form);
			}
		}

		private static void ConfigureServices(ServiceCollection services)
		{
			services.AddScoped<MainForm>();
			services.AddSingleton<SqlHelper>(new SqlHelper(".\\sqlexpress", "Af791013@"));

			//DL
			services.AddScoped<CustomerDL>();
			services.AddScoped<StuffDL>();
			services.AddScoped<ProcessDL>();
			services.AddScoped<ProcessEventDL>();

			//BL
			services.AddScoped<CustomerBL>();
			services.AddScoped<StuffBL>();
			services.AddScoped<ProcessEventBL>();


			//Forms
			services.AddScoped<FrmCustomers>();
			services.AddScoped<FrmCustomerSet>();
			services.AddScoped<FrmStuffes>();
			services.AddScoped<FrmStuffSet>();
		}
	}
}