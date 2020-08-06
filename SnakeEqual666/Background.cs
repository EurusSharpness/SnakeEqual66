using System.Drawing;
using System.Linq.Expressions;

namespace SnakeEqual666
{
    class Background
    {
        private readonly int width = 50;
        private readonly int height = 50;
        public const int NumberOfRows = 5, NumberOfColums = 6;
        public Background()
        {
        }

        public void Draw(Graphics g) // Make it look more pretty.
        {
            // Draw the boxes, 50x50 each one.
            for (int i = 0; i <= NumberOfRows; i++)
            {
                for (int j = 0; j <= NumberOfColums; j++)
                {
                    if (j == (NumberOfColums / 2) && i == NumberOfRows)
                        continue;
                    if (j % 2 == 0)
                        g.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(new Point(width * j, i * height), new Size(width, height)));
                    if (i == 0 && j == NumberOfColums / 2)
                        g.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(new Point(width * j, i * height), new Size(width, height)));
                    if (i == NumberOfRows && j % 2 == 1)
                        g.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(new Point(width * j, i * height), new Size(width, height)));
                }
            }

            // + 13 * : + + 12 * - -11 + * / - 10 = 66
            // First col
            g.DrawString("+", new Font("", 16), Brushes.Black, 15, height + height / 4);
            g.DrawString("13", new Font("", 16), Brushes.Black, 5, height * 2 + height / 4);
            g.DrawString("x", new Font("", 16), Brushes.Black, 15, height * 3 + height / 4);
            g.DrawString(":", new Font("", 16), Brushes.Black, 15, height * 5 + height / 4);

            //3rd col
            g.DrawString("+", new Font("", 16), Brushes.Black, width * 2 + 15, height * 5 + height / 4);
            g.DrawString("+", new Font("", 16), Brushes.Black, width * 2 + 15, height * 3 + height / 4);
            g.DrawString("12", new Font("", 16), Brushes.Black, width * 2 + 5, height * 2 + height / 4);
            g.DrawString("x", new Font("", 16), Brushes.Black, width * 2 + 15, height + height / 4);

            //4th col
            g.DrawString("-", new Font("", 16), Brushes.Black, width * 3 + 15, height / 4);

            //5th col
            g.DrawString("-", new Font("", 16), Brushes.Black, width * 4 + 15, height + height / 4);
            g.DrawString("11", new Font("", 16), Brushes.Black, width * 4 + 15, height * 2 + height / 4);
            g.DrawString("+", new Font("", 16), Brushes.Black, width * 4 + 15, height * 3 + height / 4);
            g.DrawString("x", new Font("", 16), Brushes.Black, width * 4 + 15, height * 5 + height / 4);


            //7th col
            g.DrawString(":", new Font("", 16), Brushes.Black, width * 6 + 15, height * 5 + height / 4);
            g.DrawString("-", new Font("", 16), Brushes.Black, width * 6 + 15, height * 3 + height / 4);
            g.DrawString("10", new Font("", 16), Brushes.Black, width * 6 + 5, height * 2 + height / 4);
            g.DrawString("=", new Font("", 16), Brushes.Black, width * 6 + 15, height + height / 4);
            g.DrawString("66", new Font("", 16), Brushes.Black, width * 6 + 5, height / 4);
        }
    }
}
