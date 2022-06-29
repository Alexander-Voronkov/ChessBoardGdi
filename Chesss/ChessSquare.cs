using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chesss
{
    public partial class ChessSquare : UserControl
    {
        Color c;
        public ChessSquare()
        {
            InitializeComponent();
            Size = new Size(30, 30);
        }
        public void SetColor(Color c)
        {
            this.c = c;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(c);
            g.Dispose();
        }

        private void ChessSquare_MouseEnter(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.DrawRectangle(Pens.Tomato,0,0,Size.Width,Size.Height);
            g.Dispose();
        }

        private void ChessSquare_MouseLeave(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(c);
        }
    }
}
