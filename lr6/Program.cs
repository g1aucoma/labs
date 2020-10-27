﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr6
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG

            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"shar_output.txt");
            var new_in = new StreamReader(@"shar_input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

#endif

            Shar s = new Shar();
            s.Load();
            s.Info();

#if !DEBUG

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();

#else
            Console.ReadKey();
#endif

        }
    }
}
