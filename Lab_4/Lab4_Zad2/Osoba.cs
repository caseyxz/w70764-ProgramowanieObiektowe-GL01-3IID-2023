using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Zad2
{
    public abstract class Osoba
    {
        public String FirstName;
        public String LastName;
        public String Pesel;

        public void SetLastName(String Nazwisko)
        {
            this.LastName = Nazwisko;
        }      
        public void SetPesel(String Pesel)
        {
            this.Pesel = Pesel;
        }
        public void SetFirstName(String Imię)
        {
            this.FirstName = Imię;
        }
        public int GetAge()
        {
            // Sprawdzenie długości numeru PESEL
            if (Pesel.Length != 11)
            {
                Console.WriteLine("Błędny numer PESEL.");
                return -1; // Zwracamy -1, aby oznaczyć błąd
            }
            int rokUrodzenia = int.Parse(Pesel.Substring(0, 2));
            int miesiacUrodzenia = int.Parse(Pesel.Substring(2, 2));
            int dzienUrodzenia = int.Parse(Pesel.Substring(4, 2));

            // Sprawdzenie stulecia i ustawienie właściwego roku
            if (miesiacUrodzenia > 12)
            {
                rokUrodzenia += 2000;
                miesiacUrodzenia -= 20;
            }
            else
            {
                rokUrodzenia += 1900;
            }

            // Pobranie aktualnej daty
            DateTime aktualnaData = DateTime.Now;

            // Obliczenie wieku
            int wiek = aktualnaData.Year - rokUrodzenia;

            // Korekta wieku, jeśli jeszcze nie urodziła się aktualnie w danym roku
            if (aktualnaData.Month < miesiacUrodzenia || (aktualnaData.Month == miesiacUrodzenia && aktualnaData.Day < dzienUrodzenia))
            {
                wiek--;
            }

            return wiek;
        }
    
        public char GetGender()
        {
            // Sprawdzenie długości numeru PESEL
            if (Pesel.Length != 11)
            {
                Console.WriteLine("Błędny numer PESEL.");
                return '?';
            }

            // Pobranie cyfry oznaczającej płeć z numeru PESEL
            int cyfraPlec = int.Parse(Pesel.Substring(9, 1));

            // Określenie płci na podstawie cyfry
            char gender = (cyfraPlec % 2 == 0) ? 'K' : 'M';

            return gender;
        }
        public abstract void GetEducationInfo();
        public abstract void GetFullName();
        public abstract bool CanGoAloneToHome();
    }
}
