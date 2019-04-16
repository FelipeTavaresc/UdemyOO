using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresEx02
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 999.00, 10);

            p.SetNome("T");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco().ToString("F2", CultureInfo.InstalledUICulture));
        }
    }
}
