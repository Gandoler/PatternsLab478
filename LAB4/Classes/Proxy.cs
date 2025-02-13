using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4.Classes
{
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

        public void LogMove(Point vector)

        {
            throw new NotImplementedException();
        }
    }
}
