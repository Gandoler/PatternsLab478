using Serilog;

public static class Program
{


    [STAThread]
    static void Main()
    {
        Log.Logger = new LoggerConfiguration()
           .WriteTo.Async(a => a.File(@"C:\Users\glkru\source\repos\Gandoler\LAB4WinFrom\LAB4\Log\Proxylog.log",
               rollingInterval: RollingInterval.Month))
           .CreateLogger();

        Serilog.Log.Information("App start");

        Application.Run(new MainForm());
    }
}
