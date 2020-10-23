using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int n, t;
            double x, y;

            n = Convert.ToInt32(Console.ReadLine());
            t = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            int i, znam = 1, stepxy = 1, stepsin = 3;
            double chisl, j = 0;

            if (t == 0)
            {
                for (i = 1; i <= n ; i++)
                {
                    if (i % 2 == 0)
                        chisl = Math.Pow(Math.Sin(Math.Pow(x, stepxy)), stepsin);
                    else
                        chisl = -Math.Pow(Math.Sin(Math.Pow(y, stepxy)), stepsin);
                    j = j + (chisl / (znam * (znam + 2)));
                    znam += 2;
                    stepxy += 1;
                    stepsin += 2;
                }

            }
            if (t == 1)
            {
                i = 1;
                while(i <= n)
                {
                    if (i % 2 == 0)
                        chisl = Math.Pow(Math.Sin(Math.Pow(x, stepxy)), stepsin);
                    else
                        chisl = -Math.Pow(Math.Sin(Math.Pow(y, stepxy)), stepsin);
                    j = j + (chisl / (znam * (znam + 2)));
                    znam += 2;
                    stepxy += 1;
                    stepsin += 2;
                    i++;
                }

            }
            if (t == 2)
            {
                i = 1;
                do
                {
                    if (i % 2 == 0)
                        chisl = Math.Pow(Math.Sin(Math.Pow(x, stepxy)), stepsin);
                    else
                        chisl = -Math.Pow(Math.Sin(Math.Pow(y, stepxy)), stepsin);
                    j = j + (chisl / (znam * (znam + 2)));
                    znam += 2;
                    stepxy += 1;
                    stepsin += 2;
                    i++;
                } while (i <= n);

            }

            Console.WriteLine(String.Format("{0:0.0000000}", j));

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();

        }
    }
}
