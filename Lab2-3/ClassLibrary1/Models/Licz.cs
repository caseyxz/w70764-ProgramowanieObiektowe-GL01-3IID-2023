using System.Xml.Linq;

namespace ClassLibrary1.Models
{
    public class Licz
    {
        private int _value = 0;
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public void Add(int num)
        {
            _value += num;
        }
        public void Substract(int num)
        {
            _value -= num;
        }

        public Licz() { }
        public Licz(int sum)
        {
            this._value = sum;
        }
    }
}