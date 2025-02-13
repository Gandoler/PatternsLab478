using System;
using System.Drawing;
using System.Windows.Forms;

public interface IImageProxy
{
    void LoadImage();
    void Move(Point newPosition);
}

public class ImageProxy : PictureBox, IImageProxy
{
    private string imagePath = "TestImage.jpg";
    private bool isLoaded = false;
    private Image realImage;

    public ImageProxy()
    {
        this.BorderStyle = BorderStyle.FixedSingle;
        this.BackColor = Color.Transparent;
        this.SizeMode = PictureBoxSizeMode.StretchImage;
        this.MouseDown += ImageProxy_MouseDown;
        this.DoubleClick += ImageProxy_DoubleClick;
        LoadImageSize();
    }

    private void LoadImageSize()
    {
        if (System.IO.File.Exists(imagePath))
        {
            using (Image img = Image.FromFile(imagePath))
            {
                this.Size = img.Size;
            }
        }
        else
        {
            this.Size = new Size(100, 100); // Default size if image not found
        }
    }

    public void LoadImage()
    {
        if (!isLoaded && System.IO.File.Exists(imagePath))
        {
            realImage = Image.FromFile(imagePath);
            this.Image = realImage;
            isLoaded = true;
        }
    }

    private void ImageProxy_DoubleClick(object sender, EventArgs e)
    {
        LoadImage();
    }

    private Point mouseDownLocation;

    private void ImageProxy_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            mouseDownLocation = e.Location;
            this.MouseMove += ImageProxy_MouseMove;
            this.MouseUp += ImageProxy_MouseUp;
        }
    }

    private void ImageProxy_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            Move(new Point(this.Left + e.X - mouseDownLocation.X, this.Top + e.Y - mouseDownLocation.Y));
        }
    }

    public void Move(Point newPosition)
    {
        this.Left = newPosition.X;
        this.Top = newPosition.Y;
    }

    private void ImageProxy_MouseUp(object sender, MouseEventArgs e)
    {
        this.MouseMove -= ImageProxy_MouseMove;
        this.MouseUp -= ImageProxy_MouseUp;
    }
}

public class MainForm : Form
{
    public MainForm()
    {
        this.Text = "Proxy Pattern Graphic Editor";
        this.Size = new Size(800, 600);

        IImageProxy imageProxy = new ImageProxy();
        ((Control)imageProxy).Location = new Point(50, 50);
        this.Controls.Add((Control)imageProxy);
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }
}
