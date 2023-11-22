using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Osoba
    {
        private String FirstName { get; set; }   
        private String LastName { get; set; }
        private int Age { get; set; }

        public Samochód samochód;
        public String FullName => $"{FirstName}{LastName}";
        public Osoba(String firstname, String lastname, int age) 
        { 
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }  

        public bool IsAnAdult()
        {
            if (Age >= 18) { return true; } 
            else { return false; }
        }

        public void ChangeLastname(String newLastName) => LastName = newLastName;
        public void SetCarDetails(String marka, String model, int rok)
        {
            samochód = new(marka, model, rok);
        }

        public void GetCarDetails()
        {
            Console.WriteLine($"Informacje o samochodzie: " +
                $"Marka - {samochód.marka}," +
                $"Model  - {samochód.model}," +
                $"Rok Produkcji - {samochód.rokProdukcji}");
        }
    }
}
