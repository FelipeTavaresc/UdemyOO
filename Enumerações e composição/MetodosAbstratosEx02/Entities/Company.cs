using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstratosEx02.Entities
{
    class Company : TaxPlayer
    {
        public int NumberOfEemployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberOfEemployees) : base(name, anualIncome)
        {
            NumberOfEemployees = numberOfEemployees;
        }

        public override double Tax()
        {
            if (NumberOfEemployees > 10)
            {
                return AnualIncome / 100 * 14;
            }
            else
            {
                return AnualIncome / 100 * 16;
            }

    }
}
