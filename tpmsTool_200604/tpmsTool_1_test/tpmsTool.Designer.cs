namespace tpmsTool_1_test
{
    partial class tpmsTest
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.sFlashCheck = new System.Windows.Forms.Button();
            this.rfmExCheck = new System.Windows.Forms.Button();
            this.rfmInCheck = new System.Windows.Forms.Button();
            this.gps1Check = new System.Windows.Forms.Button();
            this.gps2Check = new System.Windows.Forms.Button();
            this.ledCheck = new System.Windows.Forms.Button();
            this.modemCheck = new System.Windows.Forms.Button();
            this.iccidCheck = new System.Windows.Forms.Button();
            this.rssiCheck = new System.Windows.Forms.Button();
            this.mdnCheck = new System.Windows.Forms.Button();
            this.regCheck = new System.Windows.Forms.Button();
            this.checkComplete = new System.Windows.Forms.Button();
            this.pwrOff = new System.Windows.Forms.Button();
            this.testMode_Resp = new System.Windows.Forms.Label();
            this.sFlash_Resp = new System.Windows.Forms.Label();
            this.rfmEx_Resp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnUartConnect = new System.Windows.Forms.Button();
            this.btnUartDisconnect = new System.Windows.Forms.Button();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.close = new System.Windows.Forms.Button();
            this.rfmIn_Resp = new System.Windows.Forms.Label();
            this.gps1_Resp = new System.Windows.Forms.Label();
            this.gps2_Resp = new System.Windows.Forms.Label();
            this.led_Resp = new System.Windows.Forms.Label();
            this.modem_Resp = new System.Windows.Forms.Label();
            this.iccid_Resp = new System.Windows.Forms.Label();
            this.rssi_Resp = new System.Windows.Forms.Label();
            this.mdn_Resp = new System.Windows.Forms.Label();
            this.reg_Resp = new System.Windows.Forms.Label();
            this.complete_Resp = new System.Windows.Forms.Label();
            this.pwrOff_Resp = new System.Windows.Forms.Label();
            this.ledSuccess = new System.Windows.Forms.Button();
            this.ledFail = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.IMEI_txt_Box = new System.Windows.Forms.TextBox();
            this.SN_txt_Box = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnIMEI = new System.Windows.Forms.Button();
            this.productNumb = new System.Windows.Forms.NumericUpDown();
            this.btnCompare = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.resultForm = new System.Windows.Forms.Button();
            this.btnTestInit = new System.Windows.Forms.Button();
            this.btnTestStop = new System.Windows.Forms.Button();
            this.btnTestStart = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.testModeCheck = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_cmd = new System.Windows.Forms.TextBox();
            this.button_cmd = new System.Windows.Forms.Button();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.OpenDlg = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnComClear = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productNumb)).BeginInit();
            this.gbControl.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // sFlashCheck
            // 
            this.sFlashCheck.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sFlashCheck.Location = new System.Drawing.Point(8, 89);
            this.sFlashCheck.Name = "sFlashCheck";
            this.sFlashCheck.Size = new System.Drawing.Size(218, 34);
            this.sFlashCheck.TabIndex = 1;
            this.sFlashCheck.Text = "2. sFlash 초기화";
            this.sFlashCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sFlashCheck.UseVisualStyleBackColor = true;
            // 
            // rfmExCheck
            // 
            this.rfmExCheck.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rfmExCheck.Location = new System.Drawing.Point(8, 129);
            this.rfmExCheck.Name = "rfmExCheck";
            this.rfmExCheck.Size = new System.Drawing.Size(218, 34);
            this.rfmExCheck.TabIndex = 2;
            this.rfmExCheck.Text = "3. RF 485port";
            this.rfmExCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rfmExCheck.UseVisualStyleBackColor = true;
            // 
            // rfmInCheck
            // 
            this.rfmInCheck.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rfmInCheck.Location = new System.Drawing.Point(8, 169);
            this.rfmInCheck.Name = "rfmInCheck";
            this.rfmInCheck.Size = new System.Drawing.Size(218, 34);
            this.rfmInCheck.TabIndex = 3;
            this.rfmInCheck.Text = "4. RF 내부";
            this.rfmInCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rfmInCheck.UseVisualStyleBackColor = true;
            // 
            // gps1Check
            // 
            this.gps1Check.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gps1Check.Location = new System.Drawing.Point(8, 209);
            this.gps1Check.Name = "gps1Check";
            this.gps1Check.Size = new System.Drawing.Size(218, 34);
            this.gps1Check.TabIndex = 4;
            this.gps1Check.Text = "5. GPS 환경";
            this.gps1Check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gps1Check.UseVisualStyleBackColor = true;
            // 
            // gps2Check
            // 
            this.gps2Check.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gps2Check.Location = new System.Drawing.Point(8, 249);
            this.gps2Check.Name = "gps2Check";
            this.gps2Check.Size = new System.Drawing.Size(218, 34);
            this.gps2Check.TabIndex = 5;
            this.gps2Check.Text = "6. GPS 공통";
            this.gps2Check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gps2Check.UseVisualStyleBackColor = true;
            // 
            // ledCheck
            // 
            this.ledCheck.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ledCheck.Location = new System.Drawing.Point(8, 289);
            this.ledCheck.Name = "ledCheck";
            this.ledCheck.Size = new System.Drawing.Size(218, 34);
            this.ledCheck.TabIndex = 6;
            this.ledCheck.Text = "7. LED 정상작동";
            this.ledCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledCheck.UseVisualStyleBackColor = true;
            // 
            // modemCheck
            // 
            this.modemCheck.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.modemCheck.Location = new System.Drawing.Point(8, 329);
            this.modemCheck.Name = "modemCheck";
            this.modemCheck.Size = new System.Drawing.Size(218, 34);
            this.modemCheck.TabIndex = 7;
            this.modemCheck.Text = "8. MODEM TEST 연결";
            this.modemCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modemCheck.UseVisualStyleBackColor = true;
            // 
            // iccidCheck
            // 
            this.iccidCheck.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iccidCheck.Location = new System.Drawing.Point(8, 369);
            this.iccidCheck.Name = "iccidCheck";
            this.iccidCheck.Size = new System.Drawing.Size(218, 34);
            this.iccidCheck.TabIndex = 8;
            this.iccidCheck.Text = "9. MODEM ICCID 체크";
            this.iccidCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iccidCheck.UseVisualStyleBackColor = true;
            // 
            // rssiCheck
            // 
            this.rssiCheck.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rssiCheck.Location = new System.Drawing.Point(8, 409);
            this.rssiCheck.Name = "rssiCheck";
            this.rssiCheck.Size = new System.Drawing.Size(218, 34);
            this.rssiCheck.TabIndex = 9;
            this.rssiCheck.Text = "10. MODEM RSSI 체크";
            this.rssiCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rssiCheck.UseVisualStyleBackColor = true;
            // 
            // mdnCheck
            // 
            this.mdnCheck.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mdnCheck.Location = new System.Drawing.Point(8, 449);
            this.mdnCheck.Name = "mdnCheck";
            this.mdnCheck.Size = new System.Drawing.Size(218, 34);
            this.mdnCheck.TabIndex = 10;
            this.mdnCheck.Text = "11. MODEM MDN 체크";
            this.mdnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mdnCheck.UseVisualStyleBackColor = true;
            // 
            // regCheck
            // 
            this.regCheck.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.regCheck.Location = new System.Drawing.Point(8, 489);
            this.regCheck.Name = "regCheck";
            this.regCheck.Size = new System.Drawing.Size(218, 34);
            this.regCheck.TabIndex = 11;
            this.regCheck.Text = "12. MODEM REG 체크";
            this.regCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regCheck.UseVisualStyleBackColor = true;
            // 
            // checkComplete
            // 
            this.checkComplete.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkComplete.Location = new System.Drawing.Point(8, 569);
            this.checkComplete.Name = "checkComplete";
            this.checkComplete.Size = new System.Drawing.Size(218, 34);
            this.checkComplete.TabIndex = 12;
            this.checkComplete.Text = "14. 검사완료 및 초기화";
            this.checkComplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkComplete.UseVisualStyleBackColor = true;
            this.checkComplete.Click += new System.EventHandler(this.checkComplete_Click);
            // 
            // pwrOff
            // 
            this.pwrOff.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwrOff.Location = new System.Drawing.Point(8, 529);
            this.pwrOff.Name = "pwrOff";
            this.pwrOff.Size = new System.Drawing.Size(218, 34);
            this.pwrOff.TabIndex = 13;
            this.pwrOff.Text = "13. 세트 전원 종료";
            this.pwrOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pwrOff.UseVisualStyleBackColor = true;
            // 
            // testMode_Resp
            // 
            this.testMode_Resp.AutoSize = true;
            this.testMode_Resp.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.testMode_Resp.Location = new System.Drawing.Point(232, 57);
            this.testMode_Resp.Name = "testMode_Resp";
            this.testMode_Resp.Size = new System.Drawing.Size(19, 19);
            this.testMode_Resp.TabIndex = 14;
            this.testMode_Resp.Text = "-";
            // 
            // sFlash_Resp
            // 
            this.sFlash_Resp.AutoSize = true;
            this.sFlash_Resp.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sFlash_Resp.Location = new System.Drawing.Point(232, 97);
            this.sFlash_Resp.Name = "sFlash_Resp";
            this.sFlash_Resp.Size = new System.Drawing.Size(19, 19);
            this.sFlash_Resp.TabIndex = 15;
            this.sFlash_Resp.Text = "-";
            // 
            // rfmEx_Resp
            // 
            this.rfmEx_Resp.AutoSize = true;
            this.rfmEx_Resp.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rfmEx_Resp.Location = new System.Drawing.Point(232, 137);
            this.rfmEx_Resp.Name = "rfmEx_Resp";
            this.rfmEx_Resp.Size = new System.Drawing.Size(19, 19);
            this.rfmEx_Resp.TabIndex = 16;
            this.rfmEx_Resp.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.btnUartConnect);
            this.groupBox1.Controls.Add(this.btnUartDisconnect);
            this.groupBox1.Controls.Add(this.cbComPort);
            this.groupBox1.Controls.Add(this.close);
            this.groupBox1.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(962, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 89);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox2.Location = new System.Drawing.Point(25, 23);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 17);
            this.checkBox2.TabIndex = 39;
            this.checkBox2.Text = "자동 연결";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnUartConnect
            // 
            this.btnUartConnect.Location = new System.Drawing.Point(25, 53);
            this.btnUartConnect.Name = "btnUartConnect";
            this.btnUartConnect.Size = new System.Drawing.Size(55, 23);
            this.btnUartConnect.TabIndex = 3;
            this.btnUartConnect.Text = "연결";
            this.btnUartConnect.UseVisualStyleBackColor = true;
            this.btnUartConnect.Click += new System.EventHandler(this.btnUartConnect_Click);
            // 
            // btnUartDisconnect
            // 
            this.btnUartDisconnect.Location = new System.Drawing.Point(86, 53);
            this.btnUartDisconnect.Name = "btnUartDisconnect";
            this.btnUartDisconnect.Size = new System.Drawing.Size(55, 23);
            this.btnUartDisconnect.TabIndex = 4;
            this.btnUartDisconnect.Text = "해제";
            this.btnUartDisconnect.UseVisualStyleBackColor = true;
            this.btnUartDisconnect.Click += new System.EventHandler(this.btnUartDisconnect_Click);
            // 
            // cbComPort
            // 
            this.cbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(110, 21);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(92, 21);
            this.cbComPort.TabIndex = 5;
            this.cbComPort.Click += new System.EventHandler(this.cbComPort_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(147, 53);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(55, 23);
            this.close.TabIndex = 6;
            this.close.Text = "종료";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // rfmIn_Resp
            // 
            this.rfmIn_Resp.AutoSize = true;
            this.rfmIn_Resp.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rfmIn_Resp.Location = new System.Drawing.Point(232, 177);
            this.rfmIn_Resp.Name = "rfmIn_Resp";
            this.rfmIn_Resp.Size = new System.Drawing.Size(19, 19);
            this.rfmIn_Resp.TabIndex = 18;
            this.rfmIn_Resp.Text = "-";
            // 
            // gps1_Resp
            // 
            this.gps1_Resp.AutoSize = true;
            this.gps1_Resp.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gps1_Resp.Location = new System.Drawing.Point(232, 217);
            this.gps1_Resp.Name = "gps1_Resp";
            this.gps1_Resp.Size = new System.Drawing.Size(19, 19);
            this.gps1_Resp.TabIndex = 19;
            this.gps1_Resp.Text = "-";
            // 
            // gps2_Resp
            // 
            this.gps2_Resp.AutoSize = true;
            this.gps2_Resp.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gps2_Resp.Location = new System.Drawing.Point(232, 257);
            this.gps2_Resp.Name = "gps2_Resp";
            this.gps2_Resp.Size = new System.Drawing.Size(19, 19);
            this.gps2_Resp.TabIndex = 20;
            this.gps2_Resp.Text = "-";
            // 
            // led_Resp
            // 
            this.led_Resp.AutoSize = true;
            this.led_Resp.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.led_Resp.Location = new System.Drawing.Point(354, 297);
            this.led_Resp.Name = "led_Resp";
            this.led_Resp.Size = new System.Drawing.Size(19, 19);
            this.led_Resp.TabIndex = 21;
            this.led_Resp.Text = "-";
            // 
            // modem_Resp
            // 
            this.modem_Resp.AutoSize = true;
            this.modem_Resp.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.modem_Resp.Location = new System.Drawing.Point(232, 337);
            this.modem_Resp.Name = "modem_Resp";
            this.modem_Resp.Size = new System.Drawing.Size(19, 19);
            this.modem_Resp.TabIndex = 22;
            this.modem_Resp.Text = "-";
            // 
            // iccid_Resp
            // 
            this.iccid_Resp.AutoSize = true;
            this.iccid_Resp.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iccid_Resp.Location = new System.Drawing.Point(232, 377);
            this.iccid_Resp.Name = "iccid_Resp";
            this.iccid_Resp.Size = new System.Drawing.Size(19, 19);
            this.iccid_Resp.TabIndex = 23;
            this.iccid_Resp.Text = "-";
            // 
            // rssi_Resp
            // 
            this.rssi_Resp.AutoSize = true;
            this.rssi_Resp.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rssi_Resp.Location = new System.Drawing.Point(232, 417);
            this.rssi_Resp.Name = "rssi_Resp";
            this.rssi_Resp.Size = new System.Drawing.Size(19, 19);
            this.rssi_Resp.TabIndex = 24;
            this.rssi_Resp.Text = "-";
            // 
            // mdn_Resp
            // 
            this.mdn_Resp.AutoSize = true;
            this.mdn_Resp.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mdn_Resp.Location = new System.Drawing.Point(232, 457);
            this.mdn_Resp.Name = "mdn_Resp";
            this.mdn_Resp.Size = new System.Drawing.Size(19, 19);
            this.mdn_Resp.TabIndex = 25;
            this.mdn_Resp.Text = "-";
            // 
            // reg_Resp
            // 
            this.reg_Resp.AutoSize = true;
            this.reg_Resp.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reg_Resp.Location = new System.Drawing.Point(232, 497);
            this.reg_Resp.Name = "reg_Resp";
            this.reg_Resp.Size = new System.Drawing.Size(19, 19);
            this.reg_Resp.TabIndex = 26;
            this.reg_Resp.Text = "-";
            // 
            // complete_Resp
            // 
            this.complete_Resp.AutoSize = true;
            this.complete_Resp.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.complete_Resp.Location = new System.Drawing.Point(232, 580);
            this.complete_Resp.Name = "complete_Resp";
            this.complete_Resp.Size = new System.Drawing.Size(19, 19);
            this.complete_Resp.TabIndex = 27;
            this.complete_Resp.Text = "-";
            // 
            // pwrOff_Resp
            // 
            this.pwrOff_Resp.AutoSize = true;
            this.pwrOff_Resp.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwrOff_Resp.Location = new System.Drawing.Point(232, 537);
            this.pwrOff_Resp.Name = "pwrOff_Resp";
            this.pwrOff_Resp.Size = new System.Drawing.Size(19, 19);
            this.pwrOff_Resp.TabIndex = 28;
            this.pwrOff_Resp.Text = "-";
            // 
            // ledSuccess
            // 
            this.ledSuccess.Enabled = false;
            this.ledSuccess.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ledSuccess.Location = new System.Drawing.Point(232, 289);
            this.ledSuccess.Name = "ledSuccess";
            this.ledSuccess.Size = new System.Drawing.Size(55, 34);
            this.ledSuccess.TabIndex = 29;
            this.ledSuccess.Text = "성공";
            this.ledSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledSuccess.UseVisualStyleBackColor = true;
            this.ledSuccess.Click += new System.EventHandler(this.ledSuccess_Click);
            // 
            // ledFail
            // 
            this.ledFail.Enabled = false;
            this.ledFail.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ledFail.Location = new System.Drawing.Point(293, 289);
            this.ledFail.Name = "ledFail";
            this.ledFail.Size = new System.Drawing.Size(55, 34);
            this.ledFail.TabIndex = 30;
            this.ledFail.Text = "실패";
            this.ledFail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledFail.UseVisualStyleBackColor = true;
            this.ledFail.Click += new System.EventHandler(this.ledFail_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("돋움", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Status.Location = new System.Drawing.Point(8, 13);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(167, 24);
            this.Status.TabIndex = 31;
            this.Status.Text = "Device Status";
            // 
            // IMEI_txt_Box
            // 
            this.IMEI_txt_Box.Location = new System.Drawing.Point(25, 65);
            this.IMEI_txt_Box.Name = "IMEI_txt_Box";
            this.IMEI_txt_Box.Size = new System.Drawing.Size(177, 22);
            this.IMEI_txt_Box.TabIndex = 32;
            this.IMEI_txt_Box.Text = "IMEI";
            this.IMEI_txt_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SN_txt_Box
            // 
            this.SN_txt_Box.Location = new System.Drawing.Point(25, 93);
            this.SN_txt_Box.Name = "SN_txt_Box";
            this.SN_txt_Box.Size = new System.Drawing.Size(177, 22);
            this.SN_txt_Box.TabIndex = 33;
            this.SN_txt_Box.Text = "S/N";
            this.SN_txt_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.btnIMEI);
            this.groupBox2.Controls.Add(this.productNumb);
            this.groupBox2.Controls.Add(this.btnCompare);
            this.groupBox2.Controls.Add(this.IMEI_txt_Box);
            this.groupBox2.Controls.Add(this.SN_txt_Box);
            this.groupBox2.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(726, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 154);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox1.Location = new System.Drawing.Point(25, 17);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 17);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "다음 번호 자동 넘김";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnIMEI
            // 
            this.btnIMEI.Location = new System.Drawing.Point(117, 121);
            this.btnIMEI.Name = "btnIMEI";
            this.btnIMEI.Size = new System.Drawing.Size(85, 22);
            this.btnIMEI.TabIndex = 37;
            this.btnIMEI.Text = "IMEI";
            this.btnIMEI.UseVisualStyleBackColor = true;
            this.btnIMEI.Click += new System.EventHandler(this.btnIMEI_Click);
            // 
            // productNumb
            // 
            this.productNumb.Cursor = System.Windows.Forms.Cursors.Default;
            this.productNumb.Location = new System.Drawing.Point(25, 37);
            this.productNumb.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.productNumb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productNumb.Name = "productNumb";
            this.productNumb.Size = new System.Drawing.Size(177, 22);
            this.productNumb.TabIndex = 35;
            this.productNumb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.productNumb.ThousandsSeparator = true;
            this.productNumb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(25, 121);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(85, 22);
            this.btnCompare.TabIndex = 34;
            this.btnCompare.Text = "생산번호";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 30);
            this.button2.TabIndex = 35;
            this.button2.Text = "내보내기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 34;
            this.button1.Text = "가져오기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.resultForm);
            this.gbControl.Controls.Add(this.btnTestInit);
            this.gbControl.Controls.Add(this.btnTestStop);
            this.gbControl.Controls.Add(this.btnTestStart);
            this.gbControl.Enabled = false;
            this.gbControl.Location = new System.Drawing.Point(490, 414);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(230, 142);
            this.gbControl.TabIndex = 83;
            this.gbControl.TabStop = false;
            // 
            // resultForm
            // 
            this.resultForm.Location = new System.Drawing.Point(6, 108);
            this.resultForm.Name = "resultForm";
            this.resultForm.Size = new System.Drawing.Size(218, 25);
            this.resultForm.TabIndex = 8;
            this.resultForm.Text = "결과 창";
            this.resultForm.UseVisualStyleBackColor = true;
            this.resultForm.Click += new System.EventHandler(this.resultForm_Click);
            // 
            // btnTestInit
            // 
            this.btnTestInit.Location = new System.Drawing.Point(7, 77);
            this.btnTestInit.Name = "btnTestInit";
            this.btnTestInit.Size = new System.Drawing.Size(217, 25);
            this.btnTestInit.TabIndex = 6;
            this.btnTestInit.Text = "테스트 초기화";
            this.btnTestInit.UseVisualStyleBackColor = true;
            this.btnTestInit.Click += new System.EventHandler(this.btnTestInit_Click);
            // 
            // btnTestStop
            // 
            this.btnTestStop.Enabled = false;
            this.btnTestStop.Location = new System.Drawing.Point(7, 47);
            this.btnTestStop.Name = "btnTestStop";
            this.btnTestStop.Size = new System.Drawing.Size(217, 25);
            this.btnTestStop.TabIndex = 5;
            this.btnTestStop.Text = "자동 테스트 정지";
            this.btnTestStop.UseVisualStyleBackColor = true;
            this.btnTestStop.Click += new System.EventHandler(this.btnTestStop_Click);
            // 
            // btnTestStart
            // 
            this.btnTestStart.Location = new System.Drawing.Point(7, 17);
            this.btnTestStart.Name = "btnTestStart";
            this.btnTestStart.Size = new System.Drawing.Size(217, 25);
            this.btnTestStart.TabIndex = 1;
            this.btnTestStart.Text = "자동 테스트 시작";
            this.btnTestStart.UseVisualStyleBackColor = true;
            this.btnTestStart.Click += new System.EventHandler(this.btnTestStart_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "가져오기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.testModeCheck);
            this.groupBox3.Controls.Add(this.Status);
            this.groupBox3.Controls.Add(this.ledFail);
            this.groupBox3.Controls.Add(this.ledSuccess);
            this.groupBox3.Controls.Add(this.pwrOff_Resp);
            this.groupBox3.Controls.Add(this.complete_Resp);
            this.groupBox3.Controls.Add(this.reg_Resp);
            this.groupBox3.Controls.Add(this.mdn_Resp);
            this.groupBox3.Controls.Add(this.rssi_Resp);
            this.groupBox3.Controls.Add(this.iccid_Resp);
            this.groupBox3.Controls.Add(this.modem_Resp);
            this.groupBox3.Controls.Add(this.led_Resp);
            this.groupBox3.Controls.Add(this.gps2_Resp);
            this.groupBox3.Controls.Add(this.gps1_Resp);
            this.groupBox3.Controls.Add(this.rfmIn_Resp);
            this.groupBox3.Controls.Add(this.rfmEx_Resp);
            this.groupBox3.Controls.Add(this.sFlash_Resp);
            this.groupBox3.Controls.Add(this.testMode_Resp);
            this.groupBox3.Controls.Add(this.pwrOff);
            this.groupBox3.Controls.Add(this.checkComplete);
            this.groupBox3.Controls.Add(this.regCheck);
            this.groupBox3.Controls.Add(this.mdnCheck);
            this.groupBox3.Controls.Add(this.rssiCheck);
            this.groupBox3.Controls.Add(this.iccidCheck);
            this.groupBox3.Controls.Add(this.modemCheck);
            this.groupBox3.Controls.Add(this.ledCheck);
            this.groupBox3.Controls.Add(this.gps2Check);
            this.groupBox3.Controls.Add(this.gps1Check);
            this.groupBox3.Controls.Add(this.rfmInCheck);
            this.groupBox3.Controls.Add(this.rfmExCheck);
            this.groupBox3.Controls.Add(this.sFlashCheck);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 616);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            // 
            // testModeCheck
            // 
            this.testModeCheck.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.testModeCheck.Location = new System.Drawing.Point(8, 49);
            this.testModeCheck.Name = "testModeCheck";
            this.testModeCheck.Size = new System.Drawing.Size(218, 34);
            this.testModeCheck.TabIndex = 32;
            this.testModeCheck.Text = "1. 테스트 모드";
            this.testModeCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testModeCheck.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(1035, 392);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(70, 22);
            this.button_clear.TabIndex = 88;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_cmd
            // 
            this.textBox_cmd.Location = new System.Drawing.Point(490, 393);
            this.textBox_cmd.Name = "textBox_cmd";
            this.textBox_cmd.Size = new System.Drawing.Size(466, 21);
            this.textBox_cmd.TabIndex = 87;
            this.textBox_cmd.TextChanged += new System.EventHandler(this.textBox_cmd_TextChanged);
            this.textBox_cmd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_cmd_KeyDown);
            // 
            // button_cmd
            // 
            this.button_cmd.Location = new System.Drawing.Point(1107, 392);
            this.button_cmd.Name = "button_cmd";
            this.button_cmd.Size = new System.Drawing.Size(85, 22);
            this.button_cmd.TabIndex = 86;
            this.button_cmd.Text = "Enter";
            this.button_cmd.UseVisualStyleBackColor = true;
            this.button_cmd.Click += new System.EventHandler(this.button_cmd_Click);
            // 
            // textBox_msg
            // 
            this.textBox_msg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_msg.Location = new System.Drawing.Point(490, 12);
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.ReadOnly = true;
            this.textBox_msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_msg.Size = new System.Drawing.Size(702, 375);
            this.textBox_msg.TabIndex = 89;
            // 
            // OpenDlg
            // 
            this.OpenDlg.FileName = "openFileDialog1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(726, 569);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 52);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "엑셀";
            // 
            // btnComClear
            // 
            this.btnComClear.Location = new System.Drawing.Point(962, 392);
            this.btnComClear.Name = "btnComClear";
            this.btnComClear.Size = new System.Drawing.Size(70, 22);
            this.btnComClear.TabIndex = 90;
            this.btnComClear.Text = "ComClear";
            this.btnComClear.UseVisualStyleBackColor = true;
            this.btnComClear.Click += new System.EventHandler(this.btnComClear_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(490, 556);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 65);
            this.groupBox5.TabIndex = 91;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "인증서";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(117, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 30);
            this.button4.TabIndex = 10;
            this.button4.Text = "내보내기";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tpmsTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 634);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnComClear);
            this.Controls.Add(this.button_cmd);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.textBox_msg);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox_cmd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "tpmsTest";
            this.Text = "tmpsTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tpmsTest_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productNumb)).EndInit();
            this.gbControl.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnUartConnect;
        public System.Windows.Forms.Button btnUartDisconnect;
        public System.Windows.Forms.ComboBox cbComPort;
        public System.Windows.Forms.Button close;
        public System.Windows.Forms.GroupBox gbControl;
        public System.Windows.Forms.Button btnTestInit;
        public System.Windows.Forms.Button btnTestStop;
        public System.Windows.Forms.Button btnTestStart;
        public System.Windows.Forms.Button sFlashCheck;
        public System.Windows.Forms.Button rfmExCheck;
        public System.Windows.Forms.Button rfmInCheck;
        public System.Windows.Forms.Button gps1Check;
        public System.Windows.Forms.Button gps2Check;
        public System.Windows.Forms.Button ledCheck;
        public System.Windows.Forms.Button modemCheck;
        public System.Windows.Forms.Button iccidCheck;
        public System.Windows.Forms.Button rssiCheck;
        public System.Windows.Forms.Button mdnCheck;
        public System.Windows.Forms.Button regCheck;
        public System.Windows.Forms.Button checkComplete;
        public System.Windows.Forms.Button pwrOff;
        public System.Windows.Forms.Label testMode_Resp;
        public System.Windows.Forms.Label sFlash_Resp;
        public System.Windows.Forms.Label rfmEx_Resp;
        public System.Windows.Forms.Label rfmIn_Resp;
        public System.Windows.Forms.Label gps1_Resp;
        public System.Windows.Forms.Label gps2_Resp;
        public System.Windows.Forms.Label led_Resp;
        public System.Windows.Forms.Label modem_Resp;
        public System.Windows.Forms.Label iccid_Resp;
        public System.Windows.Forms.Label rssi_Resp;
        public System.Windows.Forms.Label mdn_Resp;
        public System.Windows.Forms.Label reg_Resp;
        public System.Windows.Forms.Label complete_Resp;
        public System.Windows.Forms.Label pwrOff_Resp;
        public System.Windows.Forms.Button resultForm;
        public System.Windows.Forms.Button ledSuccess;
        public System.Windows.Forms.Button ledFail;
        public System.Windows.Forms.Button testModeCheck;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_cmd;
        private System.Windows.Forms.Button button_cmd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox_msg;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label Status;
        private System.Windows.Forms.OpenFileDialog OpenDlg;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox IMEI_txt_Box;
        public System.Windows.Forms.TextBox SN_txt_Box;
        public System.Windows.Forms.Button btnCompare;
        public System.Windows.Forms.NumericUpDown productNumb;
        public System.Windows.Forms.Button btnIMEI;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnComClear;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Button button4;
    }
}

