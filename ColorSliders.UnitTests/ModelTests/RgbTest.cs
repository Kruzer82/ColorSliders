using System;
using ColorSliders.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorSliders.UnitTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void RgbConstructorRandomValuesTest()
        {
            //arrange
            Random rand = new Random();
            int numberOfTests = 20000;
            RGB color;
            byte r;
            byte g;
            byte b;
            //act
            for (int i = 0; i < numberOfTests; i++)
            {
                r = Convert.ToByte(rand.Next(256));
                g = Convert.ToByte(rand.Next(256));
                b = Convert.ToByte(rand.Next(256));

                color = new RGB(r, g, b);

                //assert
                Assert.AreEqual(r, color.Red, "Red value error.");
                Assert.AreEqual(g, color.Green, "Green value error.");
                Assert.AreEqual(b, color.Blue, "Blue value error.");
            }

            
        }
    }
}
