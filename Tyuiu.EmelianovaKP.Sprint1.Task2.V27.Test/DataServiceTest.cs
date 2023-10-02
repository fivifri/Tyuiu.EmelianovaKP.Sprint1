using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint1.Task2.V27.Lib;

namespace Tyuiu.EmelianovaKP.Sprint1.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(20, ds.CalculateSquarePerimetr(5));
        }
    }
}
