using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using haromszog;

namespace TestProjectHaromszog
{
    [TestClass]
    public class Terulet
    {
        [TestMethod]
        [DataRow(10, 10, 10, 43.3)]
        [DataRow(2, 9, 8, 7.3)]
        [DataRow(9823, 121, 9811, 590989.3)]
        public void TeruletCorrect(double a, double b, double c, double expected)
        {
            Haromszog h = new Haromszog(a, b, c);
            double result = h.terulet();
            Assert.AreEqual(Math.Round(result, 1), expected);
        }

        [TestMethod]
        [DataRow(10, 10, 10, 43.3)]
        [DataRow(2, 9, 8, 20)]
        [DataRow(9823, 121, 9811, 0)]
        public void TeruletIncorrect(double a, double b, double c, double expected)
        {
            Haromszog h = new Haromszog(a, b, c);
            double result = h.terulet();
            Assert.AreNotEqual(result, expected);
        }
    }
}
