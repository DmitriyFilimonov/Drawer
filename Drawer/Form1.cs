using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawer
{
    public partial class Form1 : Form
    {
        Bitmap mainBitmap;
        Graphics graphics;
        Pen pen;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = mainBitmap;
            mainBitmap.SetPixel(50, 56, Color.Red);
            mainBitmap.SetPixel(51, 56, Color.Red);
            mainBitmap.SetPixel(50, 57, Color.Red);
            mainBitmap.SetPixel(51, 57, Color.Red);
        }
    }
}
