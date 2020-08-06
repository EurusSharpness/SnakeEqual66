using System.Drawing;

namespace SnakeEqual666
{
    class Main
    {
        Background bg;
        Calculate cal;
        System.Diagnostics.Stopwatch watch; // Calcuualte the time between each run, just for fun.
        public Main()
        {
            bg = new Background();
            cal = new Calculate();
            watch = new System.Diagnostics.Stopwatch();

            again();
        }
        public void again()
        {
            watch.Reset();
            watch.Start();
            cal.Run();
            watch.Stop();
        }
        public void Draw(Graphics g)
        {
            bg.Draw(g);
            cal.Draw(g);
            g.DrawString("Time: " + watch.ElapsedMilliseconds + "ms", new Font("", 12), Brushes.Blue, 355, 210);
        }
    }
}
