using Microsoft.Extensions.DependencyInjection;
using OrderManagerApp.Domain;
using OrderManagerApp.WinForms.Forms;

namespace OrderManagement.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<OrderManagerDbContext>();


            ApplicationConfiguration.Initialize();

            Application.Run(new OrderPaymentView());
        }
    }
}