using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace goruntuisleme4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog sas = new OpenFileDialog();
            sas.Filter = "resimler|*.bmp|All Files|*.*";
            if (sas.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {

                return;

            }
            pictureBox1.ImageLocation = sas.FileName;


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap gri = griYap(image);
            pictureBox2.Image = gri;
        }

        private Bitmap griYap(Bitmap bmp)

        {
            for (int i =0; i < bmp.Height - 1; i++)
            {
                for (int j = 0; j< bmp.Height - 1; j++)
                {
                    int deger = (bmp.GetPixel(j, i).R + bmp.GetPixel(j, i).G + bmp.GetPixel(j, i).B) / 3;
                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);
                    bmp.SetPixel(j, i, renk);
                }



            }


            return bmp;



    }   }
}
