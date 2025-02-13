using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Domain.Repositories;
using OrderManagerApp.WinForms.Interfaces;
using OrderManagerApp.WinForms.Presenters;
using OrderManagerApp.WinForms.Forms;
using OrderManagerApp.Domain;
using Microsoft.Extensions.Logging;

namespace OrderManagement.WinForms
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();

            ApplicationConfiguration.Initialize();

            await host.Services.GetRequiredService<IOrderPaymentPresenter>().Run();
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((services) =>
                {
                    services.AddSingleton<IViewOrderPayment, OrderPaymentView>();
                    services.AddTransient<IViewPayForm, PayForm>();
                    services.AddTransient<IOrderPaymentPresenter, OrderPaymentPresenter>();
                    services.AddTransient<IOrderRepository, OrderRepository>();
                    services.AddTransient<IPaymentRepository, PaymentRepository>();
                    services.AddTransient<IMoneyArrivalRepository, MoneyArrivalRepository>();
                    services.AddLogging(config =>
                    {
                        config.AddConsole();
                        config.AddDebug();
                    });
                })
                .ConfigureAppConfiguration(builder =>
                {
                    builder.AddInMemoryCollection(new Dictionary<string, string?>
                      {
                            {"DefaultConnection",
                            System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString},
                      });
                });
        }
    }
}