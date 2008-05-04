using OBDReap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace OBDReapTestProject
{
    
    
    /// <summary>
    ///This is a test class for OBDReap_SensorsTest and is intended
    ///to contain all OBDReap_SensorsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OBDReap_SensorsTest
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
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Supported_PIDs
        ///</summary>
        [TestMethod()]
        public void Supported_PIDsTest()
        {            
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Supported_PIDs();
            Assert.AreEqual("2730", actual.result);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
        


    }
}
