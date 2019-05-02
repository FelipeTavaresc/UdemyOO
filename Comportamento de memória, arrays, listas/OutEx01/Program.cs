using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);

            Console.ReadKey();
        }
    }
}
