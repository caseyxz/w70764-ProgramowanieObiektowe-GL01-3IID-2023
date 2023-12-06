using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Samochód
    {
        public String marka { get;  }
        public String model { get;  }
        public int rokProdukcji { get; }

        private double prędkość;
        private int przebieg;
        private Silnik stanSilnika;
        private enum Silnik
        {
            ON,
            OFF,
            CHECK_ENGINE
        };

        public Samochód(String marka, String model, int rok)
        {
            this.marka = marka;
            this.model = model;
            this.rokProdukcji = rok;
            this.prędkość = 0;
            this.przebieg = 0;
            this.stanSilnika = Silnik.OFF;
        }
        public void UstawTempomat(int zadanaPredkosc)
        {
            SprawdzStanSilnika();
            prędkość = zadanaPredkosc;

        }
        public void ZwiekszPredkosc()
        {
            SprawdzStanSilnika();
            prędkość += 5;
        }

        public void ZmniejszPredkosc()
        {
            SprawdzStanSilnika();
            prędkość -= 5;
        }

        private void SprawdzStanSilnika()
        {
            if (stanSilnika != Silnik.ON)
            {
                throw new InvalidOperationException("Silnik nie jest uruchomiony");
            }
        }
        public void UruchomSilnik()
        {
            if (stanSilnika == Silnik.CHECK_ENGINE)
            {
                throw new InvalidOperationException("Nie można uruchomić silnika z powodu awarii");
            }

            stanSilnika = Silnik.ON;
        }

        public void ZatrzymajSilnik()
        {
            stanSilnika = Silnik.OFF;
        }

        public double PrzejedzDystans(int dystans)
        {
            SprawdzStanSilnika();

            if (dystans < 0)
            {
                throw new ArgumentException("Dystans musi być nieujemny");
            }

            przebieg += dystans;

            if (przebieg > 10000)
            {
                stanSilnika = Silnik.CHECK_ENGINE;
                throw new InvalidOperationException("Awaria silnika (Check Engine)! Nie można kontynuować jazdy.");
            }

            return dystans / (double)prędkość;
        }

        private void NaprawSilnik()
        {
            stanSilnika = Silnik.ON;
        }
    }
}
