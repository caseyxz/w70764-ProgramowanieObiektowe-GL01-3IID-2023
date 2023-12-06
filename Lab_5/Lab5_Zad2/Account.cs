using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Zad2
{
    public class Account
    {
        private List<Transaction> transactions = new List<Transaction>();

        public static decimal TotalIncome { get;  set; }
        public static decimal TotalExpense { get;  set; }

        public void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
            transaction.ProcessTransaction();
        }

        public void DisplaySummary()
        {
            Console.WriteLine($"Ogólna suma dochodów: {TotalIncome:C}");
            Console.WriteLine($"Ogólna suma wydatków: {TotalExpense:C}");
        }
    }
}
