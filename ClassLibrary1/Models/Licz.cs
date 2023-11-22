using System.Xml.Linq;

namespace ClassLibrary1.Models
{
    public class Licz
    {
        private int sum = 0;
        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }

        public void Add(int num)
        {
            sum += num;
        }
        public void Substract(int num)
        {
            sum -= num;
        }

        public Licz() { }
        public Licz(int sum)
        {
            this.sum = sum;
        }
    }
}