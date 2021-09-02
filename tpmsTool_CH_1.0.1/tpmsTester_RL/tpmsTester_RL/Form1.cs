using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace tpmsTester_RL
{
    public partial class tpmsTester : Form
    {
        public SerialPort Serial = new SerialPort();    //시리얼 통신 변수
        delegate void SetTextCallBack(string opt);
        
        public System.IO.Ports.Parity Parity;
        public System.IO.Ports.StopBits StopBit;

        public string msgAccumulate;
        public string byteAccumulate;

        public string[] cmdTemp = new string[10];
        public static int keyTemp = 0;
        public static int dataRow = 0;

        public static bool DebuggingCheck = false;
        public static bool autoScroll = true;

        public static int stampIndex = 1;
        public tpmsTester()
        {
            InitializeComponent();
            ComPortDisplay();
            Serial.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceived);
            debuggingLogo.Image = imageList1.Images[1];
        }
        private void SerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string recv_str = "";
            int i_recv_size = Serial.BytesToRead;
            byte[] b_tmp_buf = new byte[i_recv_size];
            Serial.Read(b_tmp_buf, 0, i_recv_size);
            recv_str += Encoding.Default.GetString(b_tmp_buf);
            this.BeginInvoke(new SetTextCallBack(DisplayData), new object[] { recv_str });
            recv_str = null;
        }
        public delegate void addTXT(string s);
        public void txtScroll(string s)
        {
            textBox_msg.AppendText(s);
            textBox_msg.ScrollToCaret();
        }
        public static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }
        private void DisplayData(string str)
        {       
            RXdataProcess(str);
            textBox_msg.ScrollToCaret();
        }

        private void ComPortDisplay()
        {
            if (!Serial.IsOpen)
            {
                cbComPort.Items.Clear();
                string[] ports = System.IO.Ports.SerialPort.GetPortNames();

                foreach (string port in ports)
                {
                    cbComPort.Items.Add(port);
                }

                btnUartConnect.Enabled = false;
                btnUartDisconnect.Enabled = false;

                if (ports.Length > 0)
                {
                    btnUartConnect.Enabled = true;

                    try
                    {
                        cbComPort.SelectedIndex = 0;

                        int idx = cbComPort.FindStringExact(Properties.Settings.Default.ComPort);
                        if (idx >= 0)
                            cbComPort.SelectedIndex = idx;
                    }
                    catch { }
                }
            }
        }
        public string ByteSubstring(string Data, int StartIndex, int ByteLength)
        {
            String str = "";

            byte[] TEMP = Encoding.Default.GetBytes(Data);

            str = Encoding.Default.GetString(TEMP, StartIndex, ByteLength);

            return str;
        }
        private double StringToDouble(string str)
        {
            double strDouble;
            if (double.TryParse(str, out strDouble))
            {
                strDouble = Convert.ToDouble(str);
            }
            return strDouble;
        }
        private int StringToInt(string str)
        {
            int strInt;
            if (int.TryParse(str, out strInt))
            {
                strInt = Convert.ToInt32(str);
            }
            return strInt;
        }
        private string StringHexToDec(string str)
        {
            string strDec = Convert.ToInt32(str, 16).ToString();
            return strDec;
        }
        private sbyte StringHexToSbyte(string str)
        {
            unchecked
            {
                sbyte strSbyte = (sbyte)StringToInt(StringHexToDec(str));
                return strSbyte;
            }
        }
        
        public void RXdataProcess(string msg)
        {
            /* Callback Rx data Process */
            TesterParameter tp = new TesterParameter();
            FabricationParameter fp = new FabricationParameter();

            addTXT addTXT = txtScroll;
            msgAccumulate += msg;

            if (DebuggingCheck == true)
            {
                addTXT("\r\n");       
            }

            if (msgAccumulate[0].ToString() == "[")
            {
                if (msgAccumulate.Length >= 3)
                {
                    try
                    {
                        /* String Byte Substring  */
                        int len = 1;

                        tp.firmware_identifier = ByteSubstring(msgAccumulate, len, tp.fimware_identifier_byte);
                        len = len + tp.fimware_identifier_byte;

                        tp.tire_sensor_id = ByteSubstring(msgAccumulate, len, tp.tire_sensor_id_byte);
                        len = len + tp.tire_sensor_id_byte;

                        tp.firmware_version = ByteSubstring(msgAccumulate, len, tp.firmware_version_byte);
                        len = len + tp.firmware_version_byte;

                        tp.derivative_description = ByteSubstring(msgAccumulate, len, tp.derivative_description_byte);
                        len = len + tp.derivative_description_byte;

                        tp.pressure = ByteSubstring(msgAccumulate, len, tp.pressure_byte);
                        len = len + tp.pressure_byte;

                        tp.acceleration_z_axis = ByteSubstring(msgAccumulate, len, tp.acceleration_z_axis_byte);
                        len = len + tp.acceleration_z_axis_byte;

                        tp.acceleration_x_axis = ByteSubstring(msgAccumulate, len, tp.acceleration_x_axis_byte);
                        len = len + tp.acceleration_x_axis_byte;

                        tp.voltage = ByteSubstring(msgAccumulate, len, tp.voltage_byte);
                        len = len + tp.voltage_byte;

                        tp.temperature = ByteSubstring(msgAccumulate, len, tp.temperature_byte);
                        len = len + tp.temperature_byte;

                        tp.receiver_firmware_version = ByteSubstring(msgAccumulate, len, tp.receiver_firmware_version_byte);
                        len = len + tp.receiver_firmware_version_byte;

                        tp.sensor_frame_data = ByteSubstring(msgAccumulate, len, tp.sensor_frame_data_count_two_byte);
                        len = len + tp.sensor_frame_data_count_two_byte;

                        tp.counter = ByteSubstring(msgAccumulate, len, tp.counter_byte);
                        len = len + tp.counter_byte;

                        tp.error_check_crc = ByteSubstring(msgAccumulate, len, tp.error_check_crc_byte);
                        len = len + tp.error_check_crc_byte;

                        tp.rssi = ByteSubstring(msgAccumulate, len, tp.rssi_byte);
                        len = len + tp.rssi_byte;

                        /*Debugging Message Split (/) */
                        if (DebuggingCheck == true)
                        {
                            addTXT("[" + DateTime.Now + "]");
                            addTXT(tp.firmware_identifier);
                            addTXT("/");
                            addTXT(tp.tire_sensor_id);
                            addTXT("/");
                            addTXT(tp.firmware_version);
                            addTXT("/");
                            addTXT(tp.derivative_description);
                            addTXT("/");
                            addTXT(tp.pressure);
                            addTXT("/");
                            addTXT(tp.acceleration_z_axis);
                            addTXT("/");
                            addTXT(tp.acceleration_x_axis);
                            addTXT("/");
                            addTXT(tp.voltage);
                            addTXT("/");
                            addTXT(tp.temperature);
                            addTXT("/");
                            addTXT(tp.sensor_frame_data);
                            addTXT("/");
                            addTXT(tp.receiver_firmware_version);       // counter 2byte
                            addTXT("/");
                            addTXT(tp.counter);
                            addTXT("/");
                            addTXT(tp.error_check_crc);
                            addTXT("/");
                            addTXT(tp.rssi);
                        }
                        /*Fabricating*/
                        fp.full_data = msgAccumulate.Trim();
                        fp.pressure = string.Format("{0:f1}", StringToInt(StringHexToDec(tp.pressure)) / 100);
                        fp.acceleration_x_axis = string.Format("{0:f3}", (0.333 * StringToDouble(StringHexToDec(tp.acceleration_x_axis)) - (80.333)));
                        fp.acceleration_z_axis = string.Format("{0:f2}", (StringToDouble(StringHexToDec(tp.acceleration_z_axis))) - (211.0));
                        fp.voltage = (StringToDouble(StringHexToDec(tp.voltage)) + 122) / 100.0;
                        fp.temperature = string.Format("{0:f1}", StringToInt(StringHexToDec(tp.temperature)) - 55);
                        fp.counter = StringHexToDec(tp.counter);
                        fp.sensor_frame_data = string.Format("{0:D1}", StringHexToDec(tp.sensor_frame_data));
                        fp.rssi = StringHexToSbyte(tp.rssi);

                        TimeSpan elapsed = DateTime.Now - TimeStampElasped(tp.tire_sensor_id);                        
                        fp.msPeriod = string.Format("{0:f0}", elapsed.TotalMilliseconds);
                        


                        /*Version Control*/
                        fp.derivative_description = string.Format("{0:D1}", StringHexToSbyte(tp.derivative_description));
                        if (fp.derivative_description[0] == '1')
                            fp.derivative_description = (fp.derivative_description[0] + "." + fp.derivative_description[1] + "." + fp.derivative_description[2]);
                        else
                            fp.derivative_description = "-";
                        fp.receiver_firmware_version = string.Format("{0:D1}", StringHexToSbyte(tp.receiver_firmware_version));
                        if (fp.receiver_firmware_version[0] == '1')
                            fp.receiver_firmware_version = (fp.receiver_firmware_version[0] + "." + fp.receiver_firmware_version[1] + "." + fp.receiver_firmware_version[2]);
                        else
                            fp.receiver_firmware_version = "-";
                    }

                    catch
                    {
                        MessageBox.Show("String Error");
                    }
                    finally
                    {
                        dgvFirst.Rows.Add();

                        dgvFirst[0, dataRow].Value = fp.counter;
                        dgvFirst[1, dataRow].Value = DateTime.Now.ToString("MM/dd  hh:mm:ss");
                        //dgvFirst[2, dataRow].Value = tp.firmware_identifier;
                        dgvFirst[2, dataRow].Value = fp.full_data;
                        dgvFirst[3, dataRow].Value = tp.tire_sensor_id;
                        dgvFirst[4, dataRow].Value = tp.firmware_version;
                        dgvFirst[5, dataRow].Value = fp.derivative_description;
                        dgvFirst[6, dataRow].Value = fp.receiver_firmware_version;
                        dgvFirst[7, dataRow].Value = fp.pressure;
                        dgvFirst[8, dataRow].Value = fp.acceleration_z_axis;
                        dgvFirst[9, dataRow].Value = fp.acceleration_x_axis;
                        dgvFirst[10, dataRow].Value = fp.voltage;                            //fp
                        dgvFirst[11, dataRow].Value = fp.temperature;                       //fp
                        dgvFirst[12, dataRow].Value = fp.sensor_frame_data;
                        dgvFirst[13, dataRow].Value = tp.error_check_crc;
                        dgvFirst[14, dataRow].Value = fp.rssi;                              //fp
                        dgvFirst[15, dataRow].Value = fp.msPeriod;

                        dataRow++;

                        if (autoScroll)
                            dgvFirst.FirstDisplayedScrollingRowIndex = dgvFirst.Rows.Count - 1;



                        msgAccumulate = null;
                    }
                }
            }
            else
            {
                msgAccumulate = null;
            }

        }
        public DateTime TimeStampElasped(string id)
        {
            int result = 0;
            if (TimeStamp.StampID.Exists(x => x.TireID == id))
            {
                 result = TimeStamp.StampID.FindIndex(1, x => x.TireID == id);

                if (result != 0)
                {
                    try
                    {
                        TimeStamp.StampID[result].TireID = id;
                        return TimeStamp.StampID[result].Stamp;
                    }
                    catch
                    {
                        MessageBox.Show("액세스가 거부 됐습니다.");
                    }
                    finally
                    {
                        TimeStamp.StampID[result].Stamp = DateTime.Now;
                    }
                }
            }            
            else
            {
                TimeStamp.StampID.Add(new TimeStamp());
                TimeStamp.StampID[stampIndex].TireID = id;
                TimeStamp.StampID[stampIndex].Stamp = DateTime.Now;
                stampIndex++;
            }
            return TimeStamp.StampID[result].Stamp;
        }

        private void btnUartConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.Serial.IsOpen)
                {
                    this.Serial.PortName = cbComPort.Text;
                    this.Serial.BaudRate = 115200;
                    this.Serial.DataBits = 8;
                    this.Parity = System.IO.Ports.Parity.None;
                    this.StopBit = System.IO.Ports.StopBits.None;
                    this.Serial.Open();

                    btnUartDisconnect.Enabled = true;
                    btnUartConnect.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Already Open it");
                }
            }
            catch
            {
            }
        }
        private void btnUartDisconnect_Click(object sender, EventArgs e)
        {
            this.Serial.Close();
            btnUartConnect.Enabled = true;
            btnUartDisconnect.Enabled = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbComPort_Click(object sender, EventArgs e)
        {
            cbComPort.Items.Clear();
            foreach (string comport in System.IO.Ports.SerialPort.GetPortNames())
            {
                this.cbComPort.Items.Add(comport);
            }
        }

        public bool Send(string txMsg)
        {
            if ((txMsg == "") || (txMsg.Length <= 0))
                return false;

            if (!Serial.IsOpen)
                return false;

            try
            {
                Serial.Write(txMsg + "\n");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Send(byte[] txMsg, int len)
        {
            if (len <= 0)
                return false;

            if (!Serial.IsOpen)
                return false;

            try
            {
                Serial.Write(txMsg, 0, len);
                return true;
            }
            catch
            {
                return false;
            }
        }


        private void dataClear_Click(object sender, EventArgs e)
        {
            dataRow = 0;
            dgvFirst.Rows.Clear();
        }

        private void button_cmd_Click(object sender, EventArgs e)
        {
            string comport_str = "";
            if (Serial.IsOpen)
            {
                comport_str = textBox_cmd.Text;
                this.textBox_msg.AppendText(comport_str + "\r\n");
                textBox_msg.ScrollToCaret();
                Send(comport_str);
                if (cmdTemp[0] != null)
                {
                    for (int i = 9; i != 0; i--)
                    {
                        cmdTemp[i] = cmdTemp[i - 1];
                    }
                }
                cmdTemp[0] = textBox_cmd.Text;
                keyTemp = 0;
                textBox_cmd.Text = null;
            }
            else
            {
                MessageBox.Show("SERIAL PORT CONNECTION FAIL");
            }
            return;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_msg.Text = null;
        }
        private void sendCMD()
        {
            try
            {
                button_cmd_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Timeout" + ex);
            }
        }

        private void textBox_cmd_KeyDown(object sender, KeyEventArgs e)
        {
            if (Serial.IsOpen)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Thread tBcmd = new Thread(sendCMD);
                    tBcmd.Start();
                    if (!tBcmd.Join(TimeSpan.FromSeconds(10)))
                    {
                        tBcmd.Abort();
                    }
                }
                if (e.KeyCode == Keys.Up)
                {
                    textBox_cmd.Text = cmdTemp[keyTemp];
                    if (keyTemp != 9) keyTemp++;
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (keyTemp != 0) keyTemp--;
                    textBox_cmd.Text = cmdTemp[keyTemp];
                }
            }
            else
            {
                MessageBox.Show("SERIAL PORT CONNECTION FAIL");
            }
            return;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnUartDisconnect_Click(null, null);
        }

        private void btnComClear_Click(object sender, EventArgs e)
        {
            msgAccumulate = "";
            byteAccumulate = "";
        }

        private void dgvFirst_Scroll(object sender, ScrollEventArgs e)
        {
            if ((int)e.Type == 1 || (int)e.Type == 3)
                autoScroll = true;
            else autoScroll = false;
        }

        private void dgvFirst_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            autoScroll = false;
        }

        private void dataSave_Click(object sender, EventArgs e)
        {            
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = "./";
                saveFileDialog.Filter = "csv file (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                var filecontent = string.Empty;
                var filepath = string.Empty;
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = saveFileDialog.FileName;

                    var filestream = saveFileDialog.OpenFile();

                    using (StreamWriter streamWriter = new StreamWriter(filestream))
                    {
                        for (int i = 0; i < dgvFirst.Columns.Count; i++)
                        {
                            streamWriter.Write(dgvFirst.Columns[i].HeaderText);
                            if (i != dgvFirst.Columns.Count)
                            {
                                streamWriter.Write(",");
                            }
                        }
                        streamWriter.Write(streamWriter.NewLine);

                        foreach (DataGridViewRow dr in dgvFirst.Rows)
                        {
                            for (int i = 0; i < dgvFirst.Columns.Count; i++)
                            {
                                streamWriter.Write(dr.Cells[i].Value);

                                if (i != dgvFirst.Columns.Count)
                                {
                                    streamWriter.Write(",");
                                }
                            }
                            streamWriter.Write(streamWriter.NewLine);
                        }
                        streamWriter.Flush();
                        streamWriter.Close();
                    }


                }

            }
            catch
            {                
                MessageBox.Show("로그를 저장하지 못했습니다.\n 액세스가 거부 되었습니다.","ERROR!",0,MessageBoxIcon.Error);
            }
        }

        private void debuggingBtn_Click(object sender, EventArgs e)
        {
            if (DebuggingCheck)
            {
                DebuggingCheck = false;
                textBox_msg.AppendText("\r\nDebugging Message Mode OFF! \r\n");
                debuggingLogo.Image = imageList1.Images[1];
                debuggingLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
            else
            {
                DebuggingCheck = true;
                textBox_msg.AppendText("\r\nDebugging Message Mode ON! \r\n");
                debuggingLogo.Image = imageList1.Images[0];
                debuggingLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
        }
    }
}