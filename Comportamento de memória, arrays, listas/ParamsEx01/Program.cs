using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Sum(10, 20, 30, 40);
            Console.WriteLine("Result: " + result);

            Console.ReadKey();
        }
    }
}
