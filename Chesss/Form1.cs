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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawChessBoard();
        }
        private void DrawChessBoard()
        {
            Point p = new Point(30,30);
            bool f = false;
            char a = 'a';
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    ChessSquare cs = new ChessSquare();
                    cs.Left = p.X;
                    cs.Top = p.Y;
                    if(f)
                        cs.SetColor(Color.Black);
                    else
                        cs.SetColor(Color.White);
                    this.Controls.Add(cs);
                    p=new Point(p.X+new ChessSquare().Size.Width,p.Y);
                    f = !f;
                }
                f = !f;
                p = new Point(new ChessSquare().Size.Width, p.Y+ new ChessSquare().Size.Height);
            }
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            char a = 'a';
            PointF p2 = new Point(Convert.ToInt32(new ChessSquare().Size.Width-10 * 1.5), 20);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 0)
                    {
                        Graphics g = e.Graphics;
                        g.DrawString((a++).ToString(), new Font("Times New Roman", 10), Brushes.Black, p2.X+20, p2.Y-10);
                        p2 = new PointF(p2.X + new ChessSquare().Size.Width, p2.Y);
                    }
                    else
                    {
                        Graphics g = e.Graphics;
                        g.DrawString((j + 1).ToString(), new Font("Times New Roman", 10), Brushes.Black, p2.X, p2.Y-10);
                        p2 = new PointF(p2.X, p2.Y + new ChessSquare().Size.Height);
                    }
                }
                p2 = new PointF(new ChessSquare().Size.Width / 2, p2.Y + new ChessSquare().Size.Height);
            }
        }
    }
}
