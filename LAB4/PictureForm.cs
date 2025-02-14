using LAB4.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class PictureForm : Form
    {
        private readonly IImageServer _imageServer;
        private readonly string _fileName;
        Image? image;
        public PictureForm(IImageServer imageServer, string Filename)
        {
            InitializeComponent();
            _fileName = Filename;
            _imageServer = imageServer;

            //получаем размер бокса при инициализации
            this.PictureBox.Size = _imageServer.GetImageSize(_fileName);
            //назначаем слушателей
            this.PictureBox.DoubleClick += PictureBox_DoubleClick;
            this.PictureBox.MouseUp += PictureBox_MouseUp;

        }

        private void PictureBox_MouseUp(object? sender, MouseEventArgs e)
        {
            Point location = this.PictureBox.Location;
            _imageServer.LogMove(location);
        }

        private void PictureBox_DoubleClick(object? sender, EventArgs e)
        {
            image = _imageServer.GetImage(_fileName);
            this.PictureBox.Image = image;
        }
      

    }
}
