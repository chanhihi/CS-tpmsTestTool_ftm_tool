using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tpmsTool_1_test
{
    public class tpms_Handler
    {
        // tmpsTest Instance
        tpmsTest MF = null;

        public tpms_Handler(tpmsTest form_handler)
        {
            // tmpsTest Handler 
            MF = form_handler;

            // btn Handler
            button_mouse_add_event(MF.testModeCheck);
            button_mouse_add_event(MF.sFlashCheck);
            button_mouse_add_event(MF.rfmExCheck);
            button_mouse_add_event(MF.rfmInCheck);
            button_mouse_add_event(MF.gps1Check);
            button_mouse_add_event(MF.gps2Check);
            button_mouse_add_event(MF.ledCheck);
            //button_mouse_add_event(MF.ledSuccess);
            //button_mouse_add_event(MF.ledFail);
            button_mouse_add_event(MF.modemCheck);
            button_mouse_add_event(MF.iccidCheck);
            button_mouse_add_event(MF.rssiCheck);
            button_mouse_add_event(MF.mdnCheck);
            button_mouse_add_event(MF.regCheck);
            button_mouse_add_event(MF.checkComplete);
            button_mouse_add_event(MF.pwrOff);
        }
        public static void initialize_excel_parameter()
        {
            tpms_LOG.init_log_param();
        }
        public void button_mouse_add_event(Button btn)
        {
            button_mouse_downed(btn);
            button_mouse_clicked(btn);
        }

        public void button_mouse_downed(Button btn)
        {
            btn.MouseDown += new MouseEventHandler((EventHandler)delegate (object sender, EventArgs args) { LB_MOUSE_DOWN(sender, args, btn); });
        }

        public void button_mouse_clicked(Button btn)
        {
            btn.MouseClick += new MouseEventHandler((EventHandler)delegate (object sender, EventArgs args) { LB_MOUSE_CLICK(sender, args, btn); });
        }

        public void LB_MOUSE_DOWN(object sender, EventArgs e, Button btn)
        {
            //btn.BorderStyle = BorderStyle.Fixed3D;
            btn.BackColor = Color.LightGoldenrodYellow;
        }

        public void LB_MOUSE_CLICK(object sender, EventArgs e, Button btn)
        {
            if (tpms_PARAM.bAutoTestOn)
                btn.BackColor = Color.DarkOrange;
            else
                btn.BackColor = Color.Gold;

            switch (btn.Name)
            {
                case "testModeCheck":
                    tpms_CMD.CTYPE = tpms_CMD.CmdType.TEST_MODE;
                    MF.Send(tpms_CMD.CmdMsg[(int)tpms_CMD.CTYPE]);
                    //MF.WaitTimer_Start((int)tpms_CMD.WaitType.TEST_MODE_WAIT);
                    //MF.CmdWaitTimerStart();
                    break;

                case "sFlashCheck":
                    tpms_CMD.CTYPE = tpms_CMD.CmdType.SFLASH;
                    MF.Send(tpms_CMD.CmdMsg[(int)tpms_CMD.CTYPE]);
                    //MF.WaitTimer_Start((int)tpms_CMD.WaitType.SFLASH_WAIT);
                    //MF.CmdWaitTimerStart();                    
                    break;

                case "rfmExCheck":
                    tpms_CMD.CTYPE = tpms_CMD.CmdType.RF_EX;
                    MF.Send(tpms_CMD.CmdMsg[(int)tpms_CMD.CTYPE]);

                    //MF.WaitTimer_Start((int)tpms_CMD.WaitType.RF_EX_WAIT);
                    //MF.CmdWaitTimerStart();
                    break;

                case "rfmInCheck":
                    tpms_CMD.CTYPE = tpms_CMD.CmdType.RF_IN;
                    MF.Send(tpms_CMD.CmdMsg[(int)tpms_CMD.CTYPE]);
                    MF.WaitTimer_Start((int)tpms_CMD.WaitType.RF_IN_WAIT);
                    MF.CmdWaitTimerStart();
                    break;

                case "gps1Check":
                    tpms_CMD.CTYPE = tpms_CMD.CmdType.GPS_1;
                    MF.Send(tpms_CMD.CmdMsg[(int)tpms_CMD.CTYPE]);
                    MF.WaitTimer_Start((int)tpms_CMD.WaitType.GPS_1_WAIT);
                    MF.CmdWaitTimerStart();
                    break;

                case "gps2Check":
                    tpms_CMD.CTYPE = tpms_CMD.CmdType.GPS_2;
                    MF.Send(tpms_CMD.CmdMsg[(int)tpms_CMD.CTYPE]);
                    MF.WaitTimer_Start((int)tpms_CMD.WaitType.GPS_2_WAIT);
                    MF.CmdWaitTimerStart();
                    break;

                case "ledCheck":
                    tpms_CMD.CTYPE = tpms_CMD.CmdType.LED;
                    MF.Send(tpms_CMD.CmdMsg[(int)tpms_CMD.CTYPE]);
                    MF.WaitTimer_Start((int)tpms_CMD.WaitType.LED_WAIT);
                    MF.CmdWaitTimerStart();

                    MF.ledSuccess.Enabled = true;
                    MF.ledSuccess.BackColor = tpms_PARAM.btnBackColor;
                    MF.ledFail.Enabled = true;
                    MF.ledFail.BackColor = tpms_PARAM.btnBackColor;
                    break;

                case "modemCheck":
                    tpms_CMD.CTYPE = tpms_CMD.CmdType.MODEM_TEST;
                    MF.Send(tpms_CMD.CmdMsg[(int)tpms_CMD.CTYPE]);
                    MF.WaitTimer_Start((int)tpms_CMD.WaitType.MODEM_TEST_WAIT);
                    MF.CmdWaitTimerStart();
                    break;
                case "iccidCheck":
                    tpms_CMD.CTYPE = tpms_CMD.CmdType.MODEM_ICCID;
                    MF.Send(tpms_CMD.CmdMsg[(int)tpms_CMD.CTYPE]);
                    MF.WaitTimer_Start((int)tpms_CMD.WaitType.MODEM_ICCID_WAIT);
                    MF.CmdWaitTimerStart();
                    break;
                case "rssiCheck":
                    tpms_CMD.CTYPE = tpms_CMD.CmdType.MODEM_RSSI;
                    MF.Send(tpms_CMD.CmdMsg[(int)tpms_CMD.CTYPE]);
                    MF.WaitTimer_Start((int)tpms_CMD.WaitType.MODEM_RSSI_WAIT);
                    MF.CmdWaitTimerStart();
                    break;
                case "mdnCheck":
                    tpms_CMD.CTYPE = tpms_CMD.CmdType.MODEM_MDN;
                    MF.Send(tpms_CMD.CmdMsg[(int)tpms_CMD.CTYPE]);
                    MF.WaitTimer_Start((int)tpms_CMD.WaitType.MODEM_MDN_WAIT);
                    MF.CmdWaitTimerStart();
                    break;
                case "regCheck":
                    tpms_CMD.CTYPE = tpms_CMD.CmdType.MODEM_REG;
                    MF.Send(tpms_CMD.CmdMsg[(int)tpms_CMD.CTYPE]);
                    MF.WaitTimer_Start((int)tpms_CMD.WaitType.MODEM_REG_WAIT);
                    MF.CmdWaitTimerStart();
                    break;
                case "checkComplete":
                    tpms_CMD.CTYPE = tpms_CMD.CmdType.COMPLETE;
                    MF.Send(tpms_CMD.CmdMsg[(int)tpms_CMD.CTYPE]);
                    MF.WaitTimer_Start((int)tpms_CMD.WaitType.COMPLETE_WAIT);
                    MF.CmdWaitTimerStart();
                    break;

                case "pwrOff":
                    tpms_CMD.CTYPE = tpms_CMD.CmdType.PWR_OFF;
                    MF.Send(tpms_CMD.CmdMsg[(int)tpms_CMD.CTYPE]);
                    MF.WaitTimer_Start((int)tpms_CMD.WaitType.PWR_OFF_WAIT);
                    MF.CmdWaitTimerStart();
                    break;

                default:
                    //DEBUG_MSG.PRT_RED(MF.rbShell, "Unknown Command", true);
                    break;
            }
        }

        public void initialize_label_parameter()
        {
            MF.testModeCheck.BackColor = tpms_PARAM.lbBackColor;
            MF.testMode_Resp.Text = "-";

            MF.sFlashCheck.BackColor = tpms_PARAM.lbBackColor;
            MF.sFlash_Resp.Text = "-";

            MF.rfmExCheck.BackColor = tpms_PARAM.lbBackColor;
            MF.rfmEx_Resp.Text = "-";

            MF.rfmInCheck.BackColor = tpms_PARAM.lbBackColor;
            MF.rfmIn_Resp.Text = "-";

            MF.gps1Check.BackColor = tpms_PARAM.lbBackColor;
            MF.gps1_Resp.Text = "-";

            MF.gps2Check.BackColor = tpms_PARAM.lbBackColor;
            MF.gps2_Resp.Text = "-";

            MF.ledCheck.BackColor = tpms_PARAM.lbBackColor;
            MF.ledSuccess.BackColor = tpms_PARAM.lbBackColor;
            MF.ledFail.BackColor = tpms_PARAM.lbBackColor;
            MF.led_Resp.Text = "-";

            MF.modemCheck.BackColor = tpms_PARAM.lbBackColor;
            MF.modem_Resp.Text = "-";

            MF.iccidCheck.BackColor = tpms_PARAM.lbBackColor;
            MF.iccid_Resp.Text = "-";

            MF.rssiCheck.BackColor = tpms_PARAM.lbBackColor;
            MF.rssi_Resp.Text = "-";

            MF.mdnCheck.BackColor = tpms_PARAM.lbBackColor;
            MF.mdn_Resp.Text = "-";

            MF.regCheck.BackColor = tpms_PARAM.lbBackColor;
            MF.reg_Resp.Text = "-";

            MF.checkComplete.BackColor = tpms_PARAM.lbBackColor;
            MF.complete_Resp.Text = "-";

            MF.pwrOff.BackColor = tpms_PARAM.lbBackColor;
            MF.pwrOff_Resp.Text = "-";

        }

        public void initialize_button_parameter()
        {

            MF.ledSuccess.Enabled = false;
            MF.ledSuccess.BackColor = tpms_PARAM.btnBackColor;

            MF.ledFail.Enabled = false;
            MF.ledFail.BackColor = tpms_PARAM.btnBackColor;


            MF.btnTestStart.Enabled = true;
        }

        public void Initialize_excel_parameter()
        {
            tpms_LOG.init_log_param();
        }

        public delegate void addTXT(string s);
        public void txtScroll(string s)
        {
            MF.textBox_msg.AppendText(s);
            MF.textBox_msg.ScrollToCaret();
        }
        public string msgCounting;
        public void rx_data_proc(string msg)
        {
            addTXT at = txtScroll;
            msgCounting += msg;
            //at(msg + "\r\n");
            //MF.textBox_msg.Text += (msg + "\r\n");
            at("\r\n\r\n\r\n");
            at(msgCounting + "\r\n");
            //MF.textBox_msg.Text += (msgCounting + "\r\n");
            string[] tok = msgCounting.Split(',');
            string prefix = tok[0];

            //MF.textBox_msg.AppendText("tok1: " + tok[0] + "\r\n");
            //MF.textBox_msg.AppendText("tok2: " + tok[1] + "\r\n");
            //MF.textBox_msg.ScrollToCaret();

            if (msg != "")
            {
                byte outbyte;
                bool canConvert;

                try
                {
                    canConvert = byte.TryParse(msg.Substring(0, 2), out outbyte);
                }
                catch
                {
                    canConvert = false;
                }

                if ((msg.Substring(0, 1) == "$") || (msg.Substring(0, 1) == "-") || (canConvert == true))
                {
                    //MF.textBox_msg.AppendText(msg);
                }
            }

            switch (prefix)
            {
                // $FTM,ON
                // $FTM,OFF
                case "$FTM":
                    if (tok.Length == 2)
                    {
                        MF.CmdWaitTimerStop();

                        if (tok[1] == "off")
                        {
                            MF.groupBox3.Enabled = false;
                        }
                        else if (tok[1] == "OK")
                        {
                            // ToDo
                            msgCounting = null;

                            at("Waiting for Device Initialize\r\n");
                            MF.Status.Text = "TestMode On\r\n";
                            MF.testMode_Resp.Text = "TestMode Checking...";


                            tpmsTest.Delay(1000);

                            at("Test Mode Device Checking Complete!\r\n");

                            MF.testMode_Resp.Text = "TestMode Check Complete";

                            MF.testModeCheck.BackColor = Color.LightGreen;



                            tpmsTest.Delay(300);

                            tpms_LOG.r_test_mode = true;
                            MF.CmdWaitTimerStart();

                            if (tpms_PARAM.bAutoTestOn)
                                this.LB_MOUSE_CLICK(this, null, MF.sFlashCheck);
                        }
                    }
                    break;

                case "$SFLASH":
                    if (tok.Length == 2)
                    {
                        MF.CmdWaitTimerStop();

                        if (tok[1] == "OK")
                        {
                            msgCounting = null;

                            at("sFlash RX...TX... Initializeing...\r\n");
                            MF.Status.Text = "sflash Mode On\r\n";
                            MF.sFlash_Resp.Text = "sFlash Checking...";

                            tpmsTest.Delay(1000);

                            MF.sFlash_Resp.Text = "sFlash Check Complete";
                            at("sFlash RX...TX... Checking Complete!...\r\n");
                            MF.sFlashCheck.BackColor = Color.LightGreen;
                            tpmsTest.Delay(200);

                            tpms_LOG.r_sflash = 77;
                            tpms_LOG.r_sflash_rx = 11;
                            MF.CmdWaitTimerStart();

                            if (tpms_PARAM.bAutoTestOn)
                                this.LB_MOUSE_CLICK(this, null, MF.rfmExCheck);
                        }
                    }
                    break;

                case "$RFM_EX":
                    if (tok.Length == 2)
                    {
                        MF.CmdWaitTimerStop();

                        if (tok[1] == "OK")
                        {
                            msgCounting = null;

                            at("rfm_ex port... Initializeing...\r\n");
                            MF.Status.Text = "rfm_ex Mode On\r\n";
                            MF.rfmEx_Resp.Text = "rfmEx_Resp Checking...";

                            tpmsTest.Delay(1000);

                            MF.rfmEx_Resp.Text = "rfmEx_Resp Check Complete";
                            at("rfm_ex port... Checking Complete!...\r\n");
                            MF.rfmExCheck.BackColor = Color.LightGreen;
                            tpmsTest.Delay(400);

                            tpms_LOG.r_rf_ex = true;
                            MF.CmdWaitTimerStart();

                            if (tpms_PARAM.bAutoTestOn)
                                this.LB_MOUSE_CLICK(this, null, MF.rfmInCheck);
                        }
                    }
                    break;
                    
                case "$RFM_IN":
                    if (tok.Length == 2)
                    {
                        if (tok[1] == "OK")
                        {
                            msgCounting = null;

                            at("rfm_in port... Initializeing...\r\n");
                            MF.Status.Text = "rfm_ex Mode On\r\n";
                            MF.rfmIn_Resp.Text = "rfmIn_Resp Checking...";

                            tpmsTest.Delay(1000);

                            MF.rfmIn_Resp.Text = "rfmIn_Resp Check Complete";
                            at("rfm_in port... Checking Complete!...\r\n");
                            MF.rfmInCheck.BackColor = Color.LightGreen;
                            tpmsTest.Delay(300);

                            tpms_LOG.r_rf_in = true;
                            MF.CmdWaitTimerStart();

                            if (tpms_PARAM.bAutoTestOn)
                                this.LB_MOUSE_CLICK(this, null, MF.gps1Check);
                        }
                    }
                    break;

                case "$GPS":
                    if (tok.Length == 2)
                    {
                        if (tok[1] == "OK")
                        {
                            msgCounting = null;

                            at("gps port... Initializeing...\r\n");
                            MF.Status.Text = "gps1 Mode On\r\n";
                            MF.gps1_Resp.Text = "gps1 Checking...";

                            tpmsTest.Delay(1000);

                            MF.gps1_Resp.Text = "gps1 Check Complete";
                            at("gps port... Checking Complete!...\r\n");
                            MF.gps1Check.BackColor = Color.LightGreen;
                            tpmsTest.Delay(200);

                            tpms_LOG.r_gps = true;
                            MF.CmdWaitTimerStart();

                            if (tpms_PARAM.bAutoTestOn)
                                this.LB_MOUSE_CLICK(this, null, MF.gps2Check);
                        }
                        if (tok[1] == "gps2")
                        {
                            msgCounting = null;

                            at("gps2 port... Initializeing...\r\n");
                            MF.Status.Text = "gps2 Mode On\r\n";
                            MF.gps2_Resp.Text = "gps2 Checking...";

                            tpmsTest.Delay(1000);

                            MF.gps2_Resp.Text = "gps2 Check Complete";
                            at("gps2 port... Checking Complete!...\r\n");
                            MF.gps2Check.BackColor = Color.LightGreen;
                            tpmsTest.Delay(200);

                            tpms_LOG.r_gps_snr = 50;
                            MF.CmdWaitTimerStart();

                            if (tpms_PARAM.bAutoTestOn)
                                this.LB_MOUSE_CLICK(this, null, MF.ledCheck);
                        }
                    }
                    break;

                case "$LED":
                    if (tok.Length == 2)
                    {
                        if (tok[1] == "OK")
                        {
                            msgCounting = null;

                            at("led port... Initializeing...\r\n");
                            MF.Status.Text = "led Mode On\r\n";
                            MF.led_Resp.Text = "led Checking..";
                            at("Please Check left side Success/Fail...\r\n");


                            tpmsTest.Delay(1000);

                            at("led port... Checking Complete!...\r\n");
                            MF.ledCheck.BackColor = Color.LightGreen;
                            tpmsTest.Delay(400);
                            MF.CmdWaitTimerStart();
                            if (tpms_PARAM.bAutoTestOn)
                                this.LB_MOUSE_CLICK(this, null, MF.modemCheck);

                            MF.ledSuccess.Enabled = true;
                            MF.ledSuccess.BackColor = tpms_PARAM.btnBackColor;
                            MF.ledFail.Enabled = true;
                            MF.ledFail.BackColor = tpms_PARAM.btnBackColor;
                        }
                    }
                    break;
                case "$MODEM":
                    if (tok.Length == 2)
                    {
                        if (tok[1] == "VER")
                        {
                            msgCounting = null;

                            at("modem port... Initializeing...\r\n");
                            MF.Status.Text = "modem Mode On\r\n";
                            MF.modem_Resp.Text = "modem Checking...";

                            tpmsTest.Delay(1000);

                            MF.modem_Resp.Text = "modem Check Complete";
                            at("modem port... Checking Complete!...\r\n");
                            MF.modemCheck.BackColor = Color.LightGreen;
                            tpmsTest.Delay(300);

                            tpms_LOG.r_modem_ver = true;
                            MF.CmdWaitTimerStart();

                            if (tpms_PARAM.bAutoTestOn)
                                this.LB_MOUSE_CLICK(this, null, MF.iccidCheck);
                        }
                        if (tok[1] == "ICCID")
                        {
                            msgCounting = null;

                            at("modem_iccid port... Initializeing...\r\n");
                            MF.Status.Text = "modem_iccid Mode On\r\n";
                            MF.iccid_Resp.Text = "modem_iccid Checking...";

                            tpmsTest.Delay(1000);

                            MF.iccid_Resp.Text = "modem_iccid Check Complete";
                            at("modem_iccid port... Checking Complete!...\r\n");
                            MF.iccidCheck.BackColor = Color.LightGreen;
                            tpmsTest.Delay(200);

                            tpms_LOG.r_modem_iccid = 7777777;
                            MF.CmdWaitTimerStart();

                            if (tpms_PARAM.bAutoTestOn)
                                this.LB_MOUSE_CLICK(this, null, MF.rssiCheck);
                        }
                        if (tok[1] == "RSSI")
                        {
                            msgCounting = null;

                            at("modem_rssi port... Initializeing...\r\n");
                            MF.Status.Text = "modem_rssi Mode On\r\n";
                            MF.rssi_Resp.Text = "modem_rssi Checking...";

                            tpmsTest.Delay(1000);

                            MF.rssi_Resp.Text = "modem_rssi Check Complete";
                            at("modem_rssi port... Checking Complete!...\r\n");
                            MF.rssiCheck.BackColor = Color.LightGreen;
                            tpmsTest.Delay(400);

                            tpms_LOG.r_modem_rssi = 9999999;
                            MF.CmdWaitTimerStart();

                            if (tpms_PARAM.bAutoTestOn)
                                this.LB_MOUSE_CLICK(this, null, MF.mdnCheck);
                        }
                        if (tok[1] == "MDN")
                        {
                            msgCounting = null;

                            at("modem_mdn port... Initializeing...\r\n");
                            MF.Status.Text = "modem_mdn Mode On\r\n";
                            MF.mdn_Resp.Text = "modem_mdn Checking...";

                            tpmsTest.Delay(1000);

                            MF.mdn_Resp.Text = "modem_mdn Check Complete";
                            at("modem_mdn port... Checking Complete!...\r\n");
                            MF.mdnCheck.BackColor = Color.LightGreen;
                            tpmsTest.Delay(300);

                            tpms_LOG.r_modem_mdn = true;
                            MF.CmdWaitTimerStart();

                            if (tpms_PARAM.bAutoTestOn)
                                this.LB_MOUSE_CLICK(this, null, MF.regCheck);
                        }
                        if (tok[1] == "REG")
                        {
                            msgCounting = null;

                            at("modem_reg port... Initializeing...\r\n");
                            MF.Status.Text = "modem_reg Mode On\r\n";
                            MF.reg_Resp.Text = "modem_reg Checking...";

                            tpmsTest.Delay(1000);

                            MF.reg_Resp.Text = "modem_reg Check Complete";
                            at("modem_reg port... Checking Complete!...\r\n");
                            MF.regCheck.BackColor = Color.LightGreen;
                            tpmsTest.Delay(300);

                            tpms_LOG.r_modem_reg = true;
                            MF.CmdWaitTimerStart();

                            //if (tpms_PARAM.bAutoTestOn)
                            //   this.LB_MOUSE_CLICK(this, null, MF.checkComplete);
                        }
                    }
                    break;

                case "$CFG_INIT":
                    if (tok.Length == 2)
                    {
                        if (tok[1] == "OK")
                        {
                            msgCounting = null;

                            at("complete\r\n");
                            MF.Status.Text = "complete Mode On\r\n";
                            MF.reg_Resp.Text = "Complete";

                            tpmsTest.Delay(1000);
                            MF.regCheck.BackColor = Color.LightGreen;
                            tpmsTest.Delay(500);
                        }
                    }
                    break;

                // $pwr,off
                case "$PWR":
                    if (tok.Length == 2)
                    {
                        MF.CmdWaitTimerStop();

                        if (tok[1] == "OFF")
                        {
                            msgCounting = null;

                            at("SET OFF\r\n");
                            MF.Status.Text = "SET OFF\r\n";
                            MF.pwrOff_Resp.Text = "SET OFF";

                            tpms_LOG.r_cfginit = true;

                            

                            tpms_LOG.r_check_all = true;

                            tpmsTest.Delay(1000);


                            MF.pwrOff.BackColor = Color.LightGreen;
                        }

                    }
                    break;
                default:
                    break;
            }
        }
    }
}