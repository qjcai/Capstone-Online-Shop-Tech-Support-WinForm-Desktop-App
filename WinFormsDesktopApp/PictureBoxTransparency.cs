using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDesktopApp
{
    public class TransparentPictureBox : PictureBox
    {
        public TransparentPictureBox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (Image != null)
            {
                var imageAttr = new ImageAttributes();
                var matrix = new ColorMatrix(new float[][]
                {
                    new float[] {1,  0,  0,  0, 0},        // red scaling factor of 2
                    new float[] {0,  1,  0,  0, 0},        // green scaling factor of 1
                    new float[] {0,  0,  1,  0, 0},        // blue scaling factor of 1
                    new float[] {0,  0,  0, 32/255f, 0},        // alpha scaling factor of 1
                    new float[] {0,  0,  0,  0, 1}    // three translations of 0.1
            });
                imageAttr.SetColorMatrix(matrix);
                pe.Graphics.DrawImage(Image, ClientRectangle, 0, 0, Image.Width, Image.Height, GraphicsUnit.Pixel, imageAttr);
            }
            base.OnPaint(pe);
        }
    }
}
