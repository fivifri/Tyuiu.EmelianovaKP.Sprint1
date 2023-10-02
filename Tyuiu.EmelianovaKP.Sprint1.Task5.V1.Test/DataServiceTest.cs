using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint1.Task5.V1.Lib;

namespace Tyuiu.EmelianovaKP.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            Assert.AreEqual(6, ds.DistanceBetweenDots(1, 2, 5, 6));
        }
    }
}
