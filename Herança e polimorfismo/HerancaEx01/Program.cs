using HerancaEx01.Entities;
using System;

namespace HerancaEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account acc = new Account(101, "Alex", 0.0);
            //BussinessAccount bacc = new BussinessAccount(1002, "Maria", 0.0, 500.00);

            ////UPCASTING

            //Account acc1 = bacc;
            //Account acc2 = new BussinessAccount(1003, "Bob", 0.0, 200.00);
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING

            //BussinessAccount acc4 = (BussinessAccount)acc3;
            //acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3;

            //if (acc3 is BussinessAccount)
            //{
            //    //BusinessAccount acc5 = (BusinessAccount)acc3;
            //    BussinessAccount acc5 = acc3 as BussinessAccount;
            //    acc5.Loan(200.00);
            //    Console.WriteLine("Loan!");
            //}

            //if (acc3 is SavingsAccount)
            //{
            //    //SavingsAccount acc5 = (SavingsAccount)acc3;
            //    SavingsAccount acc5 = acc3 as SavingsAccount;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("Update!");
            //}

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            Console.ReadKey();
        }
    }
}
