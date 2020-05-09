using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goruntuisleme
{
    class islem
    {

        public Bitmap negative (Bitmap bitmap)
        {
            Bitmap sonuc = new Bitmap(bitmap.Width, bitmap.Height);
            Color ilk_renk, ikinci_renk;
            int r, g, b;
            for(int i=0;i<bitmap.Width;i++)

            {
                for(int j=0;j<bitmap.Height;j++)
                {
                    ilk_renk = bitmap.GetPixel(i, j);
                    r = 255 - ilk_renk.R;
                    g = 255 - ilk_renk.G;
                    b = 255 - ilk_renk.B;
                    ikinci_renk = Color.FromArgb(r, g, b);
                    sonuc.SetPixel(i, j, ikinci_renk);
                }
            }
            return sonuc;
        }
    }
}
