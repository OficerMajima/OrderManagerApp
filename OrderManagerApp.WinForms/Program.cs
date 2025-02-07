using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderManagerApp.Domain;
using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Domain.Repositories;
using OrderManagerApp.WinForms.Forms;
using OrderManagerApp.WinForms.Interfaces;
using OrderManagerApp.Presenter.Interfaces;
using OrderManagerApp.Presenter.Presenters;

namespace OrderManagement.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();

            ApplicationConfiguration.Initialize();

            Application.Run(host.Services.GetRequiredService<OrderPaymentView>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((services) =>
                {
                    services.AddDbContext<OrderManagerDbContext>();
                    services.AddTransient<IOrderRepository, OrderRepository>();
                    services.AddTransient<IMoneyArrivalRepository, MoneyArrivalRepository>();
                    services.AddTransient<IPaymentRepository, PaymentRepository>();

                    services.AddTransient<IOrderPaymentView, OrderPaymentView>();
                    services.AddTransient<OrderPaymentView>();
                    services.AddTransient<IOrderPaymentPresenter, OrderPaymentPresenter>();
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