using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEx03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int nQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Quarto[] vect = new Quarto[10];

            for (int i = 1; i <= nQuartos; i++)
            {
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                vect[numeroQuarto] = new Quarto { Nome = nome, Email = email };
                Console.WriteLine();
            }

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ":" + vect[i]);
                }
            }

           

            Console.ReadKey();
        }

        
    }
}
