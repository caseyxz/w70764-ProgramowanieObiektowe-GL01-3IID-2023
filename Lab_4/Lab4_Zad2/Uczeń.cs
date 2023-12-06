using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Zad2
{
    public class Uczeń : Osoba
    {
        public override bool CanGoAloneToHome()
        {
            if (GetAge() >= 12 ) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void GetEducationInfo()
        {
            throw new NotImplementedException();
        }

        public override void GetFullName()
        {
            throw new NotImplementedException();
        }
    }
}
