using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4.Classes
{
    internal class Server : IImageServer
    {
        private Image? _image;
         
        
        public Image GetImage()
        {
            if (_image == null)
                _image = new Bitmap(2,2);

            return _image;
        }

        public Size GetImageSize(string path)
        {
            try
            {
                _image = Image.FromFile(path);
                return _image.Size;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка загрузки изображения: {ex.Message}");
                return new Size(0, 0);
            }
        }

        public void LogMove(Point vector)
        {
           
        }
    }
}
