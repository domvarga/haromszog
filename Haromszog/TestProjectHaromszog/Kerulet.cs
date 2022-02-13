using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using haromszog;

namespace TestProjectHaromszog
{
    [TestClass]
    public class Kerulet
    {
        [TestMethod]
        [DataRow(10, 10, 10, 30)]
        [DataRow(2, 9, 8, 19)]
        [DataRow(9823, 121, 9811, 19755)]
        public void KeruletCorrect(double a, double b, double c, double expected)
        {
            Haromszog h = new Haromszog(a, b, c);
            double result = h.kerulet();
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow(10, 10, 10, 30.000001)]
        [DataRow(2, 9, 8, 20)]
        [DataRow(9823, 121, 9811, 0)]
        public void KeruletIncorrect(double a, double b, double c, double expected)
        {
            Haromszog h = new Haromszog(a, b, c);
            double result = h.kerulet();
            Assert.AreNotEqual(result, expected);
        }
    }
}
