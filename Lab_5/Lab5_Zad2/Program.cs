using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            account.AddTransaction(new IncomeTransaction { Amount = 1000, TransactionDate = DateTime.Now });
            account.AddTransaction(new ExpenseTransaction { Amount = 500, TransactionDate = DateTime.Now });
            account.AddTransaction(new IncomeTransaction { Amount = 2000, TransactionDate = DateTime.Now });

            account.DisplaySummary();
        }
    }
}
