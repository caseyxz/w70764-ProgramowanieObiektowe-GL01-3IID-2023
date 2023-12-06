using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Models;

namespace TestProject1
{
    public class LiczTest
    {
        private Licz licz = new(0);

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ShouldCreateObject()
        {
            Assert.NotNull(licz);
        }

        [Test]
        [TestCase(2, 5, 7)]
        [TestCase(5, 6, 11)]
        public void AddTest(int num1, int num2, int expected)
        {
            licz.Add(num1);
            licz.Add(num2);
            Assert.That(licz.Value, Is.EqualTo(expected));
        }
        [Test]
        [TestCase(2, 5, -7)]
        [TestCase(5, 6, -11)]
        public void SubstractTest(int num1, int num2, int expected)
        {
            licz.Substract(num1);
            licz.Substract(num2);
            Assert.That(licz.Value, Is.EqualTo(expected));
        }



    }
}
