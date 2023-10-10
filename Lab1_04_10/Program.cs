using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zad1_04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool programOn = true;

            while (programOn == true)
            {
                Console.WriteLine("1. Sprawdż czy liczba jest parzysta i nieparzysta");
                Console.WriteLine("2. Liczby parzyste");
                Console.WriteLine("3. Oblicz silnie");
                Console.WriteLine("4. Zgadnij liczbę");
                Console.WriteLine("5. Zamiana jednostek");
                Console.WriteLine("6. Zakończ działanie programu");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CheckIfEven();
                        break;
                    case "2":
                        DisplayEvenNumbers();
                        break;
                    case "3":
                        ObliczSilnie();
                        break;
                    case "4":
                        GuessGame();
                        break;
                    case "5":
                        ZamianaJednostek();
                        break;
                    case "6":
                        programOn = false;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Wybierz ponownie.");
                        break; 

                }
            }
        }

        public static void CheckIfEven() // Zadanie 1
        {
            Console.WriteLine("Podaj liczbę: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("{0} jest liczba parzysta.", num);
            }
            else
            {
                Console.WriteLine("{0} jest liczba nieparzysta.", num);
            }

            Console.ReadKey();
        }

        public static void DisplayEvenNumbers() // Zadanie 2
        {
            Console.WriteLine("Podaj liczbę końcową zbioru: ");
            int liczba = int.Parse(Console.ReadLine());

            for (int i = 2; i <= liczba; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        public static void ObliczSilnie() // Zadanie 4
        {
            Console.WriteLine("Podaj liczbę której silnię chesz obliczyć: ");
            int liczba = int.Parse(Console.ReadLine());

            int silnia = 1;

            for (int i = 1; i <= liczba; i++)
            {
                silnia *= i;
            }

            Console.WriteLine("Silnia wynosi: {0}", silnia);
            Console.ReadKey();
        }

        public static void ZamianaJednostek() // Zadanie 5
        {
            Console.WriteLine("Jakie jednostki chesz zamienić?");
            Console.WriteLine("1. Stopnie Farenheita na Celsjusza.");
            Console.WriteLine("2. Mile morskie na metry.");
            int wybór = int.Parse(Console.ReadLine());

            switch (wybór)
            {
                case 1:
                    Console.WriteLine("Temperatura w stopniach Fahrenheita:");
                    double fahrenheit = double.Parse(Console.ReadLine()); ;
                    double celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("Temperatura w stopniach Celsjusza:" + celsius);
                    break;
                case 2:
                    Console.WriteLine("Podaj odległość w milach morskich: ");
                    int mile = int.Parse(Console.ReadLine());
                    int metry = 1852 * mile;
                    Console.WriteLine("{0} mil morskich to {1} metrów", mile, metry);

                    break;
            }
           
            Console.ReadKey();
        }

        public static void GuessGame() // Zadanie 5
        {
            Console.WriteLine("Podaj liczbę końcową zbioru do losowania: ");
            int zakres = int.Parse(Console.ReadLine());
            int guess;

            Console.WriteLine("Losowanie liczby...");
            Random rnd = new Random();
            int rndInt = rnd.Next(0, zakres + 1);
            Thread.Sleep(1000);
            Console.WriteLine("Liczba wylosowana");

            do
            {

                Console.WriteLine("Twoja odpowiedź: ");
                guess = int.Parse(Console.ReadLine());

                if (guess == rndInt)
                {
                    Console.WriteLine("Brawo ^^! Wylosowana liczba to {0}", rndInt);
                }
                else
                {
                    Console.WriteLine("Błędna odpowiedż :(.");

                    if (guess > rndInt)
                    {
                        Console.WriteLine("Spróbuj wybrać mniejszą liczbę.");
                    }
                    else
                    {
                        Console.WriteLine("Spróbuj wybrać wiekszą liczbę.");
                    }

                }
            } while (guess != rndInt);

            Console.ReadKey();
        }

    } 
}

