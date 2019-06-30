using System;
using ColorSliders.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorSliders.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RgbConstructorTest()
        {
            //arrange
            byte r = 0;
            byte g = 128;
            byte b = 255;

            //act
            RGB color = new RGB(r, g, b);

            //assert
            Assert.AreEqual(r, color.Red,"Red value error.");
            Assert.AreEqual(g, color.Green,"Red value error.");
            Assert.AreEqual(b, color.Blue,"Red value error.");
        }
    }
}
