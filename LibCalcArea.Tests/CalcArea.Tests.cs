using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibCalcArea.Tests
{
    [TestClass]
    public class CalcAreaTests
    {
        [TestMethod]
        public void RightTriangaleTest()
        {
            int a = 6;
            int b = 8;
            int c = 10;

            int expected = 24;

            CalcArea calc = new CalcArea();
            double actual = calc.Areatriangle(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CasualTriangaleTest()
        {
            int a = 5;
            int b = 3;
            int c = 6;

            double expected = 7.48331477354788277116;

            CalcArea calc = new CalcArea();
            double actual = calc.Areatriangle(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CircleAreaTest()
        {
            int r = 4;

            double expected = 50.26548245743669;

            CalcArea calc = new CalcArea();
            double actual = calc.Areacircle(r);

            Assert.AreEqual(expected, actual);
        }
    }
}