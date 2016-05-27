using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tenta_MVC_Up3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta_MVC_Up3.Models.Tests
{
    [TestClass()]
    public class SpeedTests
    {
        [TestMethod()]
        public void GetCurrentSpeedTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCurrentSpeedTest_CorrectInputs()
        {
            Speed speed = new Speed();
            var actual = speed.GetCurrentSpeed(4.5, 3.2);
            var expected = 1.40625d;
            Assert.AreEqual(expected, actual, "Correct inputs test.");
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void GetCurrentSpeedTest_NegativeNumbersInput()
        {
            Speed speed = new Speed();
            var actual = speed.GetCurrentSpeed(-5, -2);
            
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void GetCurrentSpeedTest_InputZero()
        {
            Speed speed = new Speed();
            speed.GetCurrentSpeed(5, 0);
            
        }
    }
}
/*
 Possible input:
 4.5 and 3.2
 -5 and -2
  5 and 0 
     */