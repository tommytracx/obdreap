# Introduction #

This is code pulled from PyObd that helps us to understand what code is matched with what number


# Details #

```

SENSORS = [
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

```