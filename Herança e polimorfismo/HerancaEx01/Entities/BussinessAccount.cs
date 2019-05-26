using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEx01.Entities
{
    class BussinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BussinessAccount()
        {
        }

        public BussinessAccount(int number, string holder, double balance, double loanLimite)
            :base(number, holder, balance)
        {
            LoanLimit = loanLimite;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
