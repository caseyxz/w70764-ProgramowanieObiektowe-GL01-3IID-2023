using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Zad2
{
    public class ExpenseTransaction : Transaction
    {
        public override void ProcessTransaction()
        {
            Account.TotalExpense += Amount;
        }
    }
}
