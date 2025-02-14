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
        private bool _isDragging = false;
        private Point _startPoint;

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


            //для передвижения
            this.PictureBox.MouseMove += PictureForm_MouseMove;
            this.PictureBox.MouseDown += PictureForm_MouseDown;

        }

        private void PictureForm_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = true;
                _startPoint = e.Location;
            }
        }

        private void PictureForm_MouseMove(object? sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                int newX = PictureBox.Left + (e.X - _startPoint.X);
                int newY = PictureBox.Top + (e.Y - _startPoint.Y);
                PictureBox.Location = new Point(newX, newY);
            }
        }

        private void PictureBox_MouseUp(object? sender, MouseEventArgs e)
        {
            _isDragging = false;
            Point location = this.PictureBox.Location;
            _imageServer.LogMove(location);
        }

        private void PictureBox_DoubleClick(object? sender, EventArgs e)
        {
            image = _imageServer.GetImage();
            this.PictureBox.Image = image;
        }
      

    }
}
