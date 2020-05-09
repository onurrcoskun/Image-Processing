using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sepia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("C:\\Users\\Onur\\Downloads\\image.jpg");
            pictureBox1.Image = Image.FromFile("C:\\Users\\Onur\\Downloads\\image.jpg");

            int width = bmp.Width;
            int height = bmp.Height;
            Color p;

            for(int y=0;y<height;y++)
            {
                for(int x=0; x < height; x++)
                {
                    p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb =(int)(0.272  * r + 0.534 * g + 0.131* b);

                    if(tr>255)
                    {
                        r = 255;
                    }
                    else
                    {
                        r = tr;
                    }
                    if (tg > 255)
                    {


                        g = 255;
                    }
                    else
                    {
                        g = tg;
                    }
                    if (tb > 255)
                    {
                        b = 255;
                    }
                    else
                    {
                        b = tb;
                    }
                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));

                }
            }
            pictureBox2.Image = bmp;

            bmp.Save("C:\\Users\\Onur\\Downloads\\Sepia.jpg");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
