using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Zad2
{
    public class IncomeTransaction : Transaction
    {
        
        public override void ProcessTransaction()
        {
            Account.TotalIncome += Amount;
        }
    }
}
