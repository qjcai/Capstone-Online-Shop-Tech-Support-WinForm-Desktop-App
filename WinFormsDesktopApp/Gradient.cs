using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDesktopApp
{
    // Custom Panel control for gradient backgound because theres no built-in ones
    internal class Gradient : Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set;}
        public float Angle { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Brush object
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.Angle);

            // Gets grpahic object
            Graphics graphics = e.Graphics;

            // Fills the panel's rectangle
            graphics.FillRectangle(brush, this.ClientRectangle);

            // Calls OnPaint to handle additional paintings
            base.OnPaint(e);
        }
    }
}
