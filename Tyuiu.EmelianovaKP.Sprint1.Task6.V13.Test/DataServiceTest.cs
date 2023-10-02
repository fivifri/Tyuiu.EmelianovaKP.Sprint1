using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint1.Task6.V13.Lib;

namespace Tyuiu.EmelianovaKP.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            Assert.AreEqual(true, ds.CheckWordsAlphabet("abcdefg"));
        }
    }
}
