using GreatestCommonDivisor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GCD_Test_Project
{


    /// <summary>
    ///This is a test class for GCDAlgorithmsTest and is intended
    ///to contain all GCDAlgorithmsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GCDAlgorithmsTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes

        #endregion


        /// <summary>
        ///A test for FindGCDEuclid
        ///</summary>
        [TestMethod()]
        public void FindGCDEuclidTest()
        {
            int a = 2806; 
            int b = 345; 
            int expected = 23; 
            int actual;
            actual = GCDAlgorithms.FindGCDEuclid(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindGCDEuclidTest1()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int expected = 86;
            int actual = GCDAlgorithms.FindGCDEuclid(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindGCDEuclidTest2()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int d = 430;
            int expected = 86;
            int actual = GCDAlgorithms.FindGCDEuclid(a, b, c, d);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindGCDEuclidTest3()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int d = 430;
            int e = 258;
            int expected = 86;
            int actual = GCDAlgorithms.FindGCDEuclid(a, b, c, d, e);
            Assert.AreEqual(expected, actual);
        }
    }
}
