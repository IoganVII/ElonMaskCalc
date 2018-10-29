﻿using System;
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
            var sum = 10;
            //act
            var result = calc.Sum(new[] { 5, 3, 2 });
            //assert
            Assert.AreEqual(sum, result);
        }
    }
}