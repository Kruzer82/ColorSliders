using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColorSliders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSliders.Model.Tests
{
    [TestClass()]
    public class LastColorDALTests
    {
        [TestMethod()]
        public void WriteReadLastColorRandomTest()
        {
            //arrange
            Random rand = new Random();
            int numberOfTests = 2000;
            RGB inputColor;
            RGB outputColor;

            //act
            for (int i = 0; i < numberOfTests; i++)
            {
                inputColor = new RGB(Convert.ToByte(rand.Next(256)), Convert.ToByte(rand.Next(256)), Convert.ToByte(rand.Next(256)));

                LastColorDAL.WriteLastRGB(inputColor);
                outputColor = LastColorDAL.ReadLastRGB();

                //assert
                Assert.AreEqual(inputColor.Red, outputColor.Red, "Red");
                Assert.AreEqual(inputColor.Green, outputColor.Green, "Green");
                Assert.AreEqual(inputColor.Blue, outputColor.Blue, "Blue");
            }
        }

    }
}