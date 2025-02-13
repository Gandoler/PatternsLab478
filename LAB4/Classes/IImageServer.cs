using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4.Classes
{
    internal interface IImageServer
    {
        Image GetImage(string path);
        void LogMove(Point vector);


    }
}
