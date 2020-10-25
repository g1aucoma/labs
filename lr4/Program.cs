using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace lr4
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input3.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N = Convert.ToInt32(Console.ReadLine());
            String str_all = Console.ReadLine();
            string[] str_elem = str_all.Split(' ');

            double[] mas = new double[N];
            for (int i = 0; i < N; i++)
            {
                mas[i] = Convert.ToDouble(str_elem[i]);
            }

            double s = 0, sa = 0;
            for (int i = 0; i < N; i++)
            {
                s += mas[i];
            }
            sa = 1.0f * s / N;

            int count = 0;
            double sum = 0, max = 0;
            for(int i = 0; i < N; i++)
            {
                if (mas[i] > sa)
                    count++;
                if (mas[i] < sa)
                    sum += mas[i];
                if (mas[i] > max)
                    max = mas[i];
            }
            Console.WriteLine(count);
            Console.WriteLine(sum);
            Console.WriteLine(max);

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
