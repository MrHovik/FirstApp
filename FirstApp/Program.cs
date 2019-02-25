using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n;
            n = Convert.ToInt32 (Console.ReadLine ());
            a = Convert.ToInt32(Console.ReadLine());
            Math.BinPow (a, n);
            Console.WriteLine($"");
            Console.ReadKey();
        }
    }
}
