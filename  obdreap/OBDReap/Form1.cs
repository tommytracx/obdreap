using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OBDReap
{
    public partial class Form1 : Form
    {
        public OBD.Sensors.ReturnSet strRes;
        public OBD.Sensors obd;
        public String[] ports;
        public bool bLoop = true;
        public Form1()
        {
            InitializeComponent();
            ports = System.IO.Ports.SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            
            
            obd = new OBD.Sensors(this);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bLoop = true;
            while (bLoop)
            {
                strRes = obd.Vehicle_Speed();
                if (strRes.result != "")
                {
                    textBox1.Text = strRes.result;
                }
                Application.DoEvents();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bLoop = false;
            toolStripStatusLabel1.Text = "Halted!";
            //obd.sp.Close();
            //obd.sp = null;
        }
    }
    
    public class OBD
    {
       
        /// <summary>
        /// 
        /// </summary>
        public class Sensors
        {
            String readIn = "";
            Form1 frm;
            public Sensors() { }
            public Sensors(Form1 frm)
            {
                this.frm = frm;                
            }

            ~Sensors()
            {
                if (sp != null)
                {
                    sp.Close();
                    sp = null;
                }
            }

            String[] ports =
                System.IO.Ports.SerialPort.GetPortNames();
            public System.IO.Ports.SerialPort sp=null;
            public class ReturnSet
            {
                public String result;
                public int RawValue;
                public String modifier;
                public String name;
            }
            /// <summary>
            /// Maintains the connection.
            /// 
            /// We want the connection to fail if it doesn't exist but also to follow that old maxim.
            /// "If at first you don't succeed, try, try again" Rudyard Kipling (i think)
            /// </summary>
            /// <returns></returns>
            private int MaintainConnection()
            {
                string selItem = frm.comboBox1.SelectedItem.ToString();
                if (sp == null)
                {
                    if (selItem == string.Empty)
                        selItem = "COM4";
                    sp = new System.IO.Ports.SerialPort(selItem, 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
                    sp.ReadTimeout = 1000;
                    sp.Open();
                    sp.WriteLine("atz");
                    sp.WriteLine("ate0");
                }
                
                return -1;
            }
            private int GetCmd(String pid)
            {
                MaintainConnection();
                try
                {
                    sp.WriteLine(pid);
                    readIn = sp.ReadLine();

                    //sp.Close();
                }
                catch (TimeoutException exp)
                {
                    System.Diagnostics.Debug.WriteLine(exp.Message);
                    frm.toolStripStatusLabel1.Text="Timeout but trying again ...";
                    readIn = "0";
                }
                
                return HexToInt(readIn);
            }
            //based off Python code PyObd            
            //Sensor("\(.+?\)", "\(.+?\)", \(.+?\),"\(.+?\),
            /*
             * public ReturnSet \1 () { 
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd(\2);
                ret.result =ret.RawValue;
                return ret;
                }
             * */
            public int HexToInt(String hex) { return int.Parse(hex, System.Globalization.NumberStyles.HexNumber); }

            private bool[] ParseOutBits(int value)
            {
                bool[] flags = new bool[17];                
                for(int i=16; i != 0; i--)
                {                    
                    flags[i] = (value & (int)Math.Pow(2,i))> 1  ?  true :  false;                                        
                }
                return flags;
            }
            private String BitString(bool[] bBits)
            {
                String s="";
                foreach(bool b in bBits) { if (b) s+="1"; else s+="0";}
                return s;
            }
            public ReturnSet Supported_PIDs()
            {                
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0100");
                ret.result =BitString( ParseOutBits(ret.RawValue)); 
                ret.name = "          Supported PIDs";
                return ret;
            }
            public ReturnSet Status_Since_DTC_Cleared()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0101");
                ret.result = ret.RawValue.ToString();
                ret.name = "Status Since DTC Cleared";
                return ret;
            }
            public ReturnSet DTC_Causing_Freeze_Frame()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0102");
                ret.result = "";
                ret.name = "DTC Causing Freeze Frame";
                return ret;
            }
            public ReturnSet Fuel_System_Status()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0103");
                ret.result = "";
                ret.name = "      Fuel System Status";
                return ret;
            }
            public ReturnSet Calculated_Load_Value()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0104");
                ret.result = "";
                ret.name = "   Calculated Load Value";
                return ret;
            }
            public ReturnSet Coolant_Temperature()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0105");
                ret.result = "";
                ret.name = "     Coolant Temperature";
                return ret;
            }
            public ReturnSet Short_Term_Fuel_Trim_1()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0106");
                ret.result = "";
                ret.name = "    Short Term Fuel Trim";
                return ret;
            }
            public ReturnSet Long_Term_Fuel_Trim_1()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0107");
                ret.result = "";
                ret.name = "     Long Term Fuel Trim";
                return ret;
            }
            public ReturnSet Short_Term_Fuel_Trim_2()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0108");
                ret.result = "";
                ret.name = "    Short Term Fuel Trim";
                return ret;
            }
            public ReturnSet Long_Term_Fuel_Trim_2()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0109");
                ret.result = "";
                ret.name = "     Long Term Fuel Trim";
                return ret;
            }
            public ReturnSet Fuel_Rail_Pressure()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("010A");
                ret.result = "";
                ret.name = "      Fuel Rail Pressure";
                return ret;
            }
            public ReturnSet Intake_Manifold_Pressure()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("010B");
                ret.result = "";
                ret.name = "Intake Manifold Pressure";
                return ret;
            }
            public ReturnSet Engine_RPM()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("010C");
                ret.result = "";
                ret.name = "              Engine RPM";
                return ret;
            }
            public ReturnSet Vehicle_Speed()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("010D");
                ret.result = String.Format("{0} MPH?",ret.RawValue/1.609);
                ret.name = "           Vehicle Speed";
                return ret;
            }
            public ReturnSet Timing_Advance()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("010E");
                ret.result = "";
                ret.name = "          Timing Advance";
                return ret;
            }
            public ReturnSet Intake_Air_Temp()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("010F");
                ret.result = "";
                ret.name = "         Intake Air Temp";
                return ret;
            }
            public ReturnSet Air_Flow_Rate_MAF()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0110");
                ret.result = "";
                ret.name = "     Air Flow Rate (MAF)";
                return ret;
            }
            public ReturnSet Throttle_Position()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0111");
                ret.result = "";
                ret.name = "       Throttle Position";
                return ret;
            }
            public ReturnSet Secondary_Air_Status()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0112");
                ret.result = "";
                ret.name = "    Secondary Air Status";
                return ret;
            }
            public ReturnSet Location_of_O2_sensors_1()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0113");
                ret.result = "";
                ret.name = "  Location of O2 sensors";
                return ret;
            }
            public ReturnSet O2_Sensor_1_1()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0114");
                ret.result = "";
                ret.name = "        O2 Sensor: 1 - 1";
                return ret;
            }
            public ReturnSet O2_Sensor_1_2()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0115");
                ret.result = "";
                ret.name = "        O2 Sensor: 1 - 2";
                return ret;
            }
            public ReturnSet O2_Sensor_1_3()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0116");
                ret.result = "";
                ret.name = "        O2 Sensor: 1 - 3";
                return ret;
            }
            public ReturnSet O2_Sensor_1_4()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0117");
                ret.result = "";
                ret.name = "        O2 Sensor: 1 - 4";
                return ret;
            }
            public ReturnSet O2_Sensor_2_1()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0118");
                ret.result = "";
                ret.name = "        O2 Sensor: 2 - 1";
                return ret;
            }
            public ReturnSet O2_Sensor_2_2()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("0119");
                ret.result = "";
                ret.name = "        O2 Sensor: 2 - 2";
                return ret;
            }
            public ReturnSet O2_Sensor_2_3()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("011A");
                ret.result = "";
                ret.name = "        O2 Sensor: 2 - 3";
                return ret;
            }
            public ReturnSet O2_Sensor_2_4()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("011B");
                ret.result = "";
                ret.name = "        O2 Sensor: 2 - 4";
                return ret;
            }
            public ReturnSet OBD_Designation()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("011C");
                ret.result = "";
                ret.name = "         OBD Designation";
                return ret;
            }
            public ReturnSet Location_of_O2_sensors_2()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("011D");
                ret.result = "";
                ret.name = "  Location of O2 sensors";
                return ret;
            }
            public ReturnSet Aux_input_status()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("011E");
                ret.result = "";
                ret.name = "        Aux input status";
                return ret;
            }
            public ReturnSet Time_Since_Engine_Start()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("011F");
                ret.result = "";
                ret.name = " Time Since Engine Start";
                return ret;
            }
            public ReturnSet Engine_Run_with_MIL_on()
            {
                ReturnSet ret = new ReturnSet();
                ret.RawValue = GetCmd("014E");
                ret.result = "";
                ret.name = "  Engine Run with MIL on";
                return ret;
            }
            /*
             * SENSORS = [
    Sensor("          Supported PIDs", "0100", hex_to_bitstring  ,""       ),    
    Sensor("Status Since DTC Cleared", "0101", dtc_decrypt       ,""       ),    
    Sensor("DTC Causing Freeze Frame", "0102", cpass             ,""       ),    
    Sensor("      Fuel System Status", "0103", cpass             ,""       ),
    Sensor("   Calculated Load Value", "0104", percent_scale     ,""       ),    
    Sensor("     Coolant Temperature", "0105", temp              ,"C"      ),
    Sensor("    Short Term Fuel Trim", "0106", fuel_trim_percent ,"%"      ),
    Sensor("     Long Term Fuel Trim", "0107", fuel_trim_percent ,"%"      ),
    Sensor("    Short Term Fuel Trim", "0108", fuel_trim_percent ,"%"      ),
    Sensor("     Long Term Fuel Trim", "0109", fuel_trim_percent ,"%"      ),
    Sensor("      Fuel Rail Pressure", "010A", cpass             ,""       ),
    Sensor("Intake Manifold Pressure", "010B", intake_m_pres     ,"psi"    ),
    Sensor("              Engine RPM", "010C", rpm               ,""       ),
    Sensor("           Vehicle Speed", "010D", speed             ,"MPH"    ),
    Sensor("          Timing Advance", "010E", timing_advance    ,"degrees"),
    Sensor("         Intake Air Temp", "010F", temp              ,"C"      ),
    Sensor("     Air Flow Rate (MAF)", "0110", maf               ,"lb/min" ),
    Sensor("       Throttle Position", "0111", throttle_pos      ,"%"      ),
    Sensor("    Secondary Air Status", "0112", cpass             ,""       ),
    Sensor("  Location of O2 sensors", "0113", cpass             ,""       ),
    Sensor("        O2 Sensor: 1 - 1", "0114", fuel_trim_percent ,"%"      ),
    Sensor("        O2 Sensor: 1 - 2", "0115", fuel_trim_percent ,"%"      ),
    Sensor("        O2 Sensor: 1 - 3", "0116", fuel_trim_percent ,"%"      ),
    Sensor("        O2 Sensor: 1 - 4", "0117", fuel_trim_percent ,"%"      ),
    Sensor("        O2 Sensor: 2 - 1", "0118", fuel_trim_percent ,"%"      ),
    Sensor("        O2 Sensor: 2 - 2", "0119", fuel_trim_percent ,"%"      ),
    Sensor("        O2 Sensor: 2 - 3", "011A", fuel_trim_percent ,"%"      ),
    Sensor("        O2 Sensor: 2 - 4", "011B", fuel_trim_percent ,"%"      ),
    Sensor("         OBD Designation", "011C", cpass             ,""       ),
    Sensor("  Location of O2 sensors", "011D", cpass             ,""       ),
    Sensor("        Aux input status", "011E", cpass             ,""       ),
    Sensor(" Time Since Engine Start", "011F", sec_to_min        ,"min"    ),
    Sensor("  Engine Run with MIL on", "014E", sec_to_min        ,"min"    ),

    ]
             * */
        }

        public void TranslateCode()
        {

        }

    }

}
