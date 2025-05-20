using System;
using System.Drawing;
using System.Windows.Forms;

namespace Airline.UI.Controls
{
    public class ModernButton : Button
    {
        private Color _borderColor = Color.LightGray;
        private int _borderRadius = 10;
        private int _borderSize = 1;
        private Color _hoverBackColor = Color.FromArgb(220, 235, 255); // Light blue

        private Color _defaultBackColor;
        private Color _defaultForeColor;

        public ModernButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = _borderSize;
            FlatAppearance.BorderColor = _borderColor;
            _defaultBackColor = BackColor;
            _defaultForeColor = ForeColor;
            BackColor = Color.White;
            ForeColor = Color.Black;
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            var rect = ClientRectangle;
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, _borderRadius, _borderRadius, 180, 90);
                path.AddArc(rect.Right - _borderRadius, rect.Y, _borderRadius, _borderRadius, 270, 90);
                path.AddArc(rect.Right - _borderRadius, rect.Bottom - _borderRadius, _borderRadius, _borderRadius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - _borderRadius, _borderRadius, _borderRadius, 90, 90);
                path.CloseAllFigures();
                Region = new Region(path);
                using (var pen = new Pen(_borderColor, _borderSize))
                {
                    pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    pevent.Graphics.DrawPath(pen, path);
                }
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _defaultBackColor = BackColor;
            _defaultForeColor = ForeColor;
            BackColor = _hoverBackColor;
            ForeColor = Color.Black;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = _defaultBackColor;
            ForeColor = _defaultForeColor;
        }
    }
}