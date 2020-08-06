using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeEqual666
{
    public partial class Form1 : Form
    {
        Main main;
        public Form1()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            main = new Main();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Math_SankeQuiz = 66";
            ClientSize = new Size(9 * 50 + 1, 6 * 50 + 1);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            main.Draw(e.Graphics);
        }

        private void Invalidator(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.again();
        }
    }
}
