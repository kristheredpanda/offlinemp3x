using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class SpotifySeekBar : TrackBar
    {
        public SpotifySeekBar()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.TickStyle = TickStyle.None;
            this.Height = 20; // Slim height
        }

        protected override void OnValueChanged(EventArgs e)
        {
            base.OnValueChanged(e);
            this.Invalidate(); // Forces the control to redraw with the new thumb position
        }

        private bool _showThumb = true;
        public bool ShowThumb
        {
            get { return _showThumb; }
            set { _showThumb = value; Invalidate(); } // Repaint when changed
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Colors
            Color barColor = Color.FromArgb(83, 83, 83); // Dark Gray
            Color thumbColor = Color.White;
            Color progressColor = Color.FromArgb(30, 215, 96); // Spotify Green

            // Dimensions
            int barHeight = 4;
            int thumbRadius = 5;
            Rectangle rect = new Rectangle(5, (this.Height / 2) - (barHeight / 2), this.Width - 10, barHeight);

            // Calculate progress
            float percent = (float)(this.Value - this.Minimum) / (this.Maximum - this.Minimum);
            int filledWidth = (int)(percent * (this.Width - 10));

            // Use SmoothingMode.AntiAlias for smooth edges
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw Background Bar
            using (SolidBrush brush = new SolidBrush(barColor))
            {
                g.FillRectangle(brush, rect);
            }

            // Draw Progress Bar
            using (SolidBrush brush = new SolidBrush(progressColor))
            {
                g.FillRectangle(brush, 5, (this.Height / 2) - (barHeight / 2), filledWidth, barHeight);
            }

            if (_showThumb)
            {
                using (SolidBrush thumbBrush = new SolidBrush(thumbColor))
                {
                    g.FillEllipse(thumbBrush, (int)((double)this.Value / this.Maximum * (this.Width - thumbRadius)), (this.Height / 2) - (thumbRadius + (float)0.5), thumbRadius * 2, thumbRadius * 2);
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            // Update value based on click position
            UpdateValueFromMouse(e.X);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                UpdateValueFromMouse(e.X);
            }
        }

        private void UpdateValueFromMouse(int mouseX)
        {
            // Convert Mouse Pixel to Value (assuming horizontal)
            float percent = (float)mouseX / this.Width;
            int newValue = (int)(percent * (this.Maximum - this.Minimum));
            this.Value = Math.Max(this.Minimum, Math.Min(this.Maximum, newValue));
            this.Invalidate(); // Crucial for redraw
        }
    }
}
