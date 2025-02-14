using Serilog;

namespace LAB4.Classes;

internal class Proxy : IImageServer
{
    readonly IImageServer _imageServer;
    private readonly string _logerPath;

    public Proxy(IImageServer imageServer, string LogerPath)
    {
        _logerPath = LogerPath;
        Log.Logger = new LoggerConfiguration()
         .WriteTo.Async(a => a.File(_logerPath,
             rollingInterval: RollingInterval.Month))
         .CreateLogger();

        Serilog.Log.Information("App start");
        _imageServer = imageServer;
    }

    public Image GetImage(string path)
    {
        Log.Information($"Пользователь запросил картинку по пути {path}");
        return _imageServer.GetImage(path);
    }

    public Size GetImageSize(string path)
    {
        Log.Information($"Пользователь запросил размер картинки по пути {path}");
        return _imageServer.GetImageSize(path);

    }

    public void LogMove(Point location)
    {
        Log.Information($"Пользователь сдвинул PictureBox в {location.ToString}");    
    }
}

