using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AdventCodeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        #region Test
        [TestMethod]
        private void testApp()
        {
            GetAllDepths();
            var result = CalculateLifeSupportRating();
            Assert.AreEqual(result, 5410338);
        }
        #endregion
    }
}
