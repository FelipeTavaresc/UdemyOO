using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresEx04
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 999.00, 10);

            p.Nome = "TV";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco.ToString("F2", CultureInfo.InstalledUICulture));
        }
    }
}
