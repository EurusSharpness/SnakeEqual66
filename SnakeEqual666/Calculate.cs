using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SnakeEqual666
{
    class Calculate
    {
        readonly List<int> numbers;
        readonly List<List<int>> Faild;
        public Calculate()
        {
            numbers = new List<int>(); // Init the list.
            Faild = new List<List<int>>();
        }
        public void Run()
        {
            Random r = new Random();
            bool flag = false, repeat = false;
            do
            {
                numbers.Clear(); // Clear the list after each failuer.
                numbers.AddRange(Enumerable.Range(1, 9).OrderBy(index => r.Next()).Take(9)); // Fill the list with numbers from 1->9 in random order
                foreach(List<int> list in Faild)
                    if (numbers.SequenceEqual(list))
                    {
                        flag = true;
                        break;
                    }
                repeat = !flag && !CheckAnswer();
                if (repeat)
                    Faild.Add(numbers);
            } while (repeat);
             // Write to file if needed //
/*          string s = "";
            foreach (int x in numbers)
                s += x + " ";
            s += '\n';
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("helo.txt", true))
            {
                file.WriteLine(s);
            }*/
        }

        private bool CheckAnswer() // No need to do a thing here.
        {
            double d = (((((((((((double)numbers[0] + 13.0) * (double)numbers[1]) / (double)numbers[2]) + (double)numbers[3]) + 12.0) * (double)numbers[4]) - (double)numbers[5]) - 11 + (double)numbers[6]) * (double)numbers[7]) / (double)numbers[8]) - 10;
            return d == 66.000000;
        }
        public void Draw(Graphics g) // Custom this one because its SHIIIIIIIIIIIIIT, but it works though.
        {
            g.DrawString("" + numbers[0], new Font("", 16), Brushes.Blue, 10, 50 / 4);
            g.DrawString("" + numbers[1], new Font("", 16), Brushes.Blue, 10, 50 * 4 + 50 / 4);
            g.DrawString("" + numbers[2], new Font("", 16), Brushes.Blue, 50 + 10, 50 * 5 + 50 / 4);
            g.DrawString("" + numbers[3], new Font("", 16), Brushes.Blue, 100 + 10, 50 * 4 + 50 / 4);
            g.DrawString("" + numbers[4], new Font("", 16), Brushes.Blue, 100 + 10, 50 / 4);
            g.DrawString("" + numbers[5], new Font("", 16), Brushes.Blue, 200 + 10, 50 / 4);
            g.DrawString("" + numbers[6], new Font("", 16), Brushes.Blue, 200 + 10, 50 * 4 + 50 / 4);
            g.DrawString("" + numbers[7], new Font("", 16), Brushes.Blue, 250 + 10, 50 * 5 + 50 / 4);
            g.DrawString("" + numbers[8], new Font("", 16), Brushes.Blue, 300 + 10, 50 * 4 + 50 / 4);
        }
    }
}

