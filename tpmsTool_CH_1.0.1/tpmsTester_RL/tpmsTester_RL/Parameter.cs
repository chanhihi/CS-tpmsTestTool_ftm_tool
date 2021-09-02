using System;
using System.Collections.Generic;

namespace tpmsTester_RL
{
    class TesterParameter
    {
        public string firmware_identifier = string.Empty;
        public int fimware_identifier_byte = 9;

        public string tire_sensor_id = string.Empty;
        public int tire_sensor_id_byte = 4 * 2;

        public string firmware_version = string.Empty;
        public int firmware_version_byte = 1 * 2;

        public string derivative_description = string.Empty;
        public int derivative_description_byte = 1 * 2;

        public string pressure = string.Empty;
        public int pressure_byte = 2 * 2;

        public string acceleration_z_axis = string.Empty;
        public int acceleration_z_axis_byte = 2 * 2;

        public string acceleration_x_axis = string.Empty;
        public int acceleration_x_axis_byte = 2 * 2;

        public string voltage = string.Empty;
        public int voltage_byte = 1 * 2;

        public string temperature = string.Empty;
        public int temperature_byte = 1 * 2;

        public string receiver_firmware_version = string.Empty;
        public int receiver_firmware_version_byte = 2 * 2;

        public string sensor_frame_data = string.Empty;
        public int sensor_frame_data_count_two_byte = 2 * 2;

        public string counter = string.Empty;
        public int counter_byte = 2 * 2;

        public string error_check_crc = string.Empty;
        public int error_check_crc_byte = 1 * 2;

        public string rssi = string.Empty;
        public int rssi_byte = 1 * 2;
    }
    class FabricationParameter
    {
        public string full_data = string.Empty;
        public string firmware_identifier = string.Empty;
        public string tire_sensor_id = string.Empty;
        public string firmware_version = string.Empty;
        public string derivative_description = string.Empty;
        public string pressure = string.Empty;
        public string acceleration_z_axis = string.Empty;
        public string acceleration_x_axis = string.Empty;
        public double voltage = 0;
        public string temperature = string.Empty;
        public string receiver_firmware_version = string.Empty;
        public string sensor_frame_data = string.Empty;
        public sbyte rssi = 0;
        public string error_check_crc = string.Empty;
        public string counter = string.Empty;
        public string msPeriod = string.Empty;
    }

    class TimeStamp
    {
        public static List<TimeStamp> StampID = new List<TimeStamp> {
                new TimeStamp
                {
                    TireID = null,
                    Stamp = DateTime.Now,
                },
                new TimeStamp{},
            };
        public string TireID { get; set; }
        public DateTime Stamp { get; set; }
    }

}