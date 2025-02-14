using LAB4;
using LAB4.Classes;
using Serilog;

public static class Program
{


    [STAThread]
    static void Main()
    {

        Server server = new Server();
        Proxy proxy = new(server, @"C:\\Users\\glkru\\source\\repos\\Gandoler\\LAB4WinFrom\\LAB4\\Log\\myapp.log");

        Application.Run(new PictureForm(proxy, @"C:\\Users\\glkru\\source\\repos\\Gandoler\\LAB4WinFrom\\LAB4\\test.jpg"));
    }
}
