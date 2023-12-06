using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Zad2
{
    public abstract class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public abstract void ProcessTransaction();
    }
}
