using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB4.Classes;

namespace LAB4
{
    public partial class ImageForm : Form, IImage
    {
        public ImageForm()
        {
            InitializeComponent();
        }

        public void Display(Graphics g)
        {
            throw new NotImplementedException();
        }

        public void draw()
        {
            throw new NotImplementedException();
        }

        void IImage.Move(Point vector)
        {
            throw new NotImplementedException();
        }
    }
}
