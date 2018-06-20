using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    class Program
    {
        static int Fibonachi(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

        static void Main(string[] args)
        {
            int x = Fibonachi(8);
            Console.WriteLine(x);
            Console.WriteLine(Fibonachi(4));
            Console.WriteLine(Fibonachi(6));
            Console.ReadKey();
        }

    }
}