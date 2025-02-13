using Microsoft.Extensions.DependencyInjection;
using Robin.InputFileProcessor;

namespace Robin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var robin = serviceProvider.GetRequiredService<Robin>();
            Application.Run(robin);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Robin>();
            services.AddSingleton<IInputFileProcessor, InputCSVFileProcessor>();
            services.AddSingleton<ScriptReviewGridManager>();      
        }
    }
}