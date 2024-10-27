using DIDemoLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
                .ConfigureServices(services =>
                {
                    services
                        .AddTransient<IMessages, Messages>()
                        .AddTransient<Form1>();
                });

            var host = builder.Build();
            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;

            try
            {
                ApplicationConfiguration.Initialize();

                var form = services.GetRequiredService<Form1>();
                Application.Run(form);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured: {ex.Message}");
            }
        }
    }
}