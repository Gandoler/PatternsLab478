using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4.Classes
{
    public interface IImageServer
    {

        Size GetImageSize(string path);
        Image GetImage(string path);
        void LogMove(Point vector);


    }
}
