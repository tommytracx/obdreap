using OBDReap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace OBDReapTestProject
{
    
    
    /// <summary>
    ///This is a test class for OBD_SensorsTest and is intended
    ///to contain all OBD_SensorsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OBD_SensorsTest
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
        ///A test for ParseOutBits
        ///</summary>
        [TestMethod()]
        [DeploymentItem("OBDReap.exe")]
        public void ParseOutBitsTest()
        {
            OBD_Accessor.Sensors target = new OBD_Accessor.Sensors(); // TODO: Initialize to an appropriate value
            int value = 2730;
            bool[] expected = new bool[]{false,true, false, true, false, true, false, true, false, true, false, true ,false, false, false, false, false }; //101010101010
            bool[] actual;
            string s = "";
            string d="";
            foreach(bool b in expected) { if (b) s+="1"; else s+="0";}
            foreach (bool b in expected) { if (b) d+= "1"; else d += "0"; }

            actual = target.ParseOutBits(value);
            Assert.AreEqual(s, d);            
        }
    }
}
