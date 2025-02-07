using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Domain.Repositories;
using OrderManagerApp.Presenter.Interfaces;
using OrderManagerApp.Presenter.Presenters;
using OrderManagerApp.WinForms.Forms;

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

            //Application.Run(host.Services.GetRequiredService<IViewOrderPayment>());
            try
            {
                await host.Services.GetRequiredService<IOrderPaymentPresenter>().Run();
            }
            catch (Exception erx)
            {

            }
            
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