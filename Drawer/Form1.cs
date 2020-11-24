using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawer
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Graphics _graphics;
        Pen _pen;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            _graphics = Graphics.FromImage(_mainBitmap);
            _pen = new Pen(Color.Red, 10);
            //pictureBox1.Image = _mainBitmap;
            
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point _oldPoint = e.Location;
            _oldPoint.X++;
            _graphics.DrawLine(_pen, _oldPoint, e.Location);
            pictureBox1.Image = _mainBitmap;
        }
    }
}
