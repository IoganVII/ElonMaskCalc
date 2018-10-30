using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EM.Calc.Tests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {
            //arrange
            var calc = new EM.Calc.Core.Calc();
            var sum = 10.2;
            //act
            var result = calc.Sum(new[] { 5.2, 3, 2 });
            //assert
            Assert.AreEqual(sum, result);
        }

        [TestMethod]
        public void TestSub()
        {
            //arrange
            var calc = new EM.Calc.Core.Calc();
            var sub = 2;
            //act
            var result = calc.Sub(new[] { 10, 5, 3 });
            //assert
            Assert.AreEqual(sub, result);
        }

        [TestMethod]
        public void TestPow()
        {
            //arrange
            var calc = new EM.Calc.Core.Calc();
            var pow = 19683;
            //act
            var result = calc.Pow(new[] { 3, 3, 3 });
            //assert
            Assert.AreEqual(pow, result);
        }
    }
}
