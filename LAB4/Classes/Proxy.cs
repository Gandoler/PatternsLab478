using Serilog

namespace LAB4.Classes;

internal class Proxy : IImageServer
{
    readonly IImageServer _imageServer;

    public Proxy(IImageServer imageServer)
    {
        _imageServer = imageServer;
    }

    public Image GetImage(string path)
    {
        _imageServer.GetImage(path);
    }

    public void LogMove(Point point)
    {
     Log.Information($"user Move window to {point.ToString()}")       
    }
}

