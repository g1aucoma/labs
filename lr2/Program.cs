using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
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

            double a, b, c, s;
            
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            if ((a < 1) || (b < 1) || (c < 1) || (a > 1000) || (b > 1000) || (c > 1000))
                Console.WriteLine("ERROR");
            else
            {
                double p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine(String.Format("{0:0.000}", s));
            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();

        }
    }
}
