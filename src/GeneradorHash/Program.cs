//using Microsoft.VisualBasic.Logging;
using Serilog;

namespace GeneradorHash
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Inicialiar Serilog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("logs\\log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            try 
            {
                Log.Information("La aplicacion se esta iniciando.");

                // Configurar la aplicación para usar el tema oscuro
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                ApplicationConfiguration.Initialize();
                Log.Information("La Aplicacion a iniciado satisfactoriamente.");
                Application.Run(new fmrGeneradorHash());                
            }
            catch(Exception ex)
            {
                Log.Error(ex, "Error critico en la aplicacion");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}