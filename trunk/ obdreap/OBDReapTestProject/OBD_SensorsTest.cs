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
        [TestInitialize()]
        public void MyTestInitialize()
        {
        }
        //
        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            
        }
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

        /// <summary>
        ///A test for Vehicle_Speed
        ///</summary>
        [TestMethod()]
        public void Vehicle_SpeedTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = new OBD.Sensors.ReturnSet();            
            OBD.Sensors.ReturnSet actual;
            actual = target.Vehicle_Speed();
            System.Console.WriteLine(actual.result,actual.RawValue);
            Assert.AreNotEqual("", actual.result);            
        }

        /// <summary>
        ///A test for Timing_Advance
        ///</summary>
        [TestMethod()]
        public void Timing_AdvanceTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Timing_Advance();
            Assert.AreNotEqual(expected, actual);            
        }

        /// <summary>
        ///A test for Time_Since_Engine_Start
        ///</summary>
        [TestMethod()]
        public void Time_Since_Engine_StartTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Time_Since_Engine_Start();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Throttle_Position
        ///</summary>
        [TestMethod()]
        public void Throttle_PositionTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Throttle_Position();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

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
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Status_Since_DTC_Cleared
        ///</summary>
        [TestMethod()]
        public void Status_Since_DTC_ClearedTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Status_Since_DTC_Cleared();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Short_Term_Fuel_Trim_2
        ///</summary>
        [TestMethod()]
        public void Short_Term_Fuel_Trim_2Test()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Short_Term_Fuel_Trim_2();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Short_Term_Fuel_Trim_1
        ///</summary>
        [TestMethod()]
        public void Short_Term_Fuel_Trim_1Test()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Short_Term_Fuel_Trim_1();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Secondary_Air_Status
        ///</summary>
        [TestMethod()]
        public void Secondary_Air_StatusTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Secondary_Air_Status();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ParseOutBits
        ///</summary>
        [TestMethod()]
        [DeploymentItem("OBDReap.exe")]
        public void ParseOutBitsTest1()
        {
            OBD_Accessor.Sensors target = new OBD_Accessor.Sensors(); // TODO: Initialize to an appropriate value
            int value = 0; // TODO: Initialize to an appropriate value
            bool[] expected = null; // TODO: Initialize to an appropriate value
            bool[] actual;
            actual = target.ParseOutBits(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OBD_Designation
        ///</summary>
        [TestMethod()]
        public void OBD_DesignationTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.OBD_Designation();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for O2_Sensor_2_4
        ///</summary>
        [TestMethod()]
        public void O2_Sensor_2_4Test()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.O2_Sensor_2_4();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for O2_Sensor_2_3
        ///</summary>
        [TestMethod()]
        public void O2_Sensor_2_3Test()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.O2_Sensor_2_3();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for O2_Sensor_2_2
        ///</summary>
        [TestMethod()]
        public void O2_Sensor_2_2Test()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.O2_Sensor_2_2();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for O2_Sensor_2_1
        ///</summary>
        [TestMethod()]
        public void O2_Sensor_2_1Test()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.O2_Sensor_2_1();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for O2_Sensor_1_4
        ///</summary>
        [TestMethod()]
        public void O2_Sensor_1_4Test()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.O2_Sensor_1_4();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for O2_Sensor_1_3
        ///</summary>
        [TestMethod()]
        public void O2_Sensor_1_3Test()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.O2_Sensor_1_3();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for O2_Sensor_1_2
        ///</summary>
        [TestMethod()]
        public void O2_Sensor_1_2Test()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.O2_Sensor_1_2();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for O2_Sensor_1_1
        ///</summary>
        [TestMethod()]
        public void O2_Sensor_1_1Test()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.O2_Sensor_1_1();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Long_Term_Fuel_Trim_2
        ///</summary>
        [TestMethod()]
        public void Long_Term_Fuel_Trim_2Test()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Long_Term_Fuel_Trim_2();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Long_Term_Fuel_Trim_1
        ///</summary>
        [TestMethod()]
        public void Long_Term_Fuel_Trim_1Test()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Long_Term_Fuel_Trim_1();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Location_of_O2_sensors_2
        ///</summary>
        [TestMethod()]
        public void Location_of_O2_sensors_2Test()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Location_of_O2_sensors_2();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Location_of_O2_sensors_1
        ///</summary>
        [TestMethod()]
        public void Location_of_O2_sensors_1Test()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Location_of_O2_sensors_1();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Intake_Manifold_Pressure
        ///</summary>
        [TestMethod()]
        public void Intake_Manifold_PressureTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Intake_Manifold_Pressure();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Intake_Air_Temp
        ///</summary>
        [TestMethod()]
        public void Intake_Air_TempTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Intake_Air_Temp();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HexToInt
        ///</summary>
        [TestMethod()]
        public void HexToIntTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            string hex = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.HexToInt(hex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetCmd
        ///</summary>
        [TestMethod()]
        [DeploymentItem("OBDReap.exe")]
        public void GetCmdTest()
        {
            OBD_Accessor.Sensors target = new OBD_Accessor.Sensors(); // TODO: Initialize to an appropriate value
            string pid = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetCmd(pid);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fuel_System_Status
        ///</summary>
        [TestMethod()]
        public void Fuel_System_StatusTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Fuel_System_Status();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fuel_Rail_Pressure
        ///</summary>
        [TestMethod()]
        public void Fuel_Rail_PressureTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Fuel_Rail_Pressure();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Engine_Run_with_MIL_on
        ///</summary>
        [TestMethod()]
        public void Engine_Run_with_MIL_onTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Engine_Run_with_MIL_on();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Engine_RPM
        ///</summary>
        [TestMethod()]
        public void Engine_RPMTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Engine_RPM();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DTC_Causing_Freeze_Frame
        ///</summary>
        [TestMethod()]
        public void DTC_Causing_Freeze_FrameTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.DTC_Causing_Freeze_Frame();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Coolant_Temperature
        ///</summary>
        [TestMethod()]
        public void Coolant_TemperatureTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Coolant_Temperature();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Calculated_Load_Value
        ///</summary>
        [TestMethod()]
        public void Calculated_Load_ValueTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Calculated_Load_Value();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BitString
        ///</summary>
        [TestMethod()]
        [DeploymentItem("OBDReap.exe")]
        public void BitStringTest()
        {
            OBD_Accessor.Sensors target = new OBD_Accessor.Sensors(); // TODO: Initialize to an appropriate value
            bool[] bBits = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.BitString(bBits);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Aux_input_status
        ///</summary>
        [TestMethod()]
        public void Aux_input_statusTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Aux_input_status();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Air_Flow_Rate_MAF
        ///</summary>
        [TestMethod()]
        public void Air_Flow_Rate_MAFTest()
        {
            OBD.Sensors target = new OBD.Sensors(); // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet expected = null; // TODO: Initialize to an appropriate value
            OBD.Sensors.ReturnSet actual;
            actual = target.Air_Flow_Rate_MAF();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Sensors Constructor
        ///</summary>
        [TestMethod()]
        public void OBD_SensorsConstructorTest()
        {
            OBD.Sensors target = new OBD.Sensors();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for MaintainConnection
        ///</summary>
        [TestMethod()]
        [DeploymentItem("OBDReap.exe")]
        public void MaintainConnectionTest()
        {
            OBD_Accessor.Sensors target = new OBD_Accessor.Sensors(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.MaintainConnection();
            Assert.AreEqual(expected, actual);            
        }
    }
}
