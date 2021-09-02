namespace tpmsTester_RL
{
    partial class tpmsTester
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tpmsTester));
            this.SerialPort = new System.Windows.Forms.GroupBox();
            this.btnUartConnect = new System.Windows.Forms.Button();
            this.btnUartDisconnect = new System.Windows.Forms.Button();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.close = new System.Windows.Forms.Button();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.GroupBox();
            this.dataSave = new System.Windows.Forms.Button();
            this.dataClear = new System.Windows.Forms.Button();
            this.textBox_cmd = new System.Windows.Forms.TextBox();
            this.btnBuffClear = new System.Windows.Forms.Button();
            this.button_cmd = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabCon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvFirst = new System.Windows.Forms.DataGridView();
            this.dgvtCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtTireID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtLibVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtSensorVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtReceiverVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtZaxis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtXaxis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtVolt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtFrameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtCrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtRssi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.debuggingLogo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SerialPort.SuspendLayout();
            this.data.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabCon.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirst)).BeginInit();
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.Controls.Add(this.btnUartConnect);
            this.SerialPort.Controls.Add(this.btnUartDisconnect);
            this.SerialPort.Controls.Add(this.cbComPort);
            this.SerialPort.Controls.Add(this.close);
            this.SerialPort.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SerialPort.Location = new System.Drawing.Point(1557, 25);
            this.SerialPort.Name = "SerialPort";
            this.SerialPort.Size = new System.Drawing.Size(151, 145);
            this.SerialPort.TabIndex = 18;
            this.SerialPort.TabStop = false;
            this.SerialPort.Text = "SerialPort";
            // 
            // btnUartConnect
            // 
            this.btnUartConnect.Location = new System.Drawing.Point(10, 48);
            this.btnUartConnect.Name = "btnUartConnect";
            this.btnUartConnect.Size = new System.Drawing.Size(135, 25);
            this.btnUartConnect.TabIndex = 1;
            this.btnUartConnect.Text = "연결";
            this.btnUartConnect.UseVisualStyleBackColor = true;
            this.btnUartConnect.Click += new System.EventHandler(this.btnUartConnect_Click);
            // 
            // btnUartDisconnect
            // 
            this.btnUartDisconnect.Enabled = false;
            this.btnUartDisconnect.Location = new System.Drawing.Point(10, 79);
            this.btnUartDisconnect.Name = "btnUartDisconnect";
            this.btnUartDisconnect.Size = new System.Drawing.Size(135, 25);
            this.btnUartDisconnect.TabIndex = 2;
            this.btnUartDisconnect.Text = "해제";
            this.btnUartDisconnect.UseVisualStyleBackColor = true;
            this.btnUartDisconnect.Click += new System.EventHandler(this.btnUartDisconnect_Click);
            // 
            // cbComPort
            // 
            this.cbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(10, 21);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(135, 21);
            this.cbComPort.TabIndex = 0;
            this.cbComPort.Click += new System.EventHandler(this.cbComPort_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(10, 110);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(135, 25);
            this.close.TabIndex = 0;
            this.close.Text = "종료";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // textBox_msg
            // 
            this.textBox_msg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_msg.Location = new System.Drawing.Point(9, 668);
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.ReadOnly = true;
            this.textBox_msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_msg.Size = new System.Drawing.Size(1538, 42);
            this.textBox_msg.TabIndex = 6;
            this.textBox_msg.Text = "\r\n          우측 로고 버튼 클릭시 Debug Message를 확인 하실 수 있습니다.\r\n ";
            // 
            // data
            // 
            this.data.Controls.Add(this.dataSave);
            this.data.Controls.Add(this.dataClear);
            this.data.Location = new System.Drawing.Point(1557, 176);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(151, 90);
            this.data.TabIndex = 91;
            this.data.TabStop = false;
            this.data.Text = "Data";
            // 
            // dataSave
            // 
            this.dataSave.Location = new System.Drawing.Point(10, 52);
            this.dataSave.Name = "dataSave";
            this.dataSave.Size = new System.Drawing.Size(135, 25);
            this.dataSave.TabIndex = 5;
            this.dataSave.Text = "Data &Save";
            this.dataSave.UseVisualStyleBackColor = true;
            this.dataSave.Click += new System.EventHandler(this.dataSave_Click);
            // 
            // dataClear
            // 
            this.dataClear.Location = new System.Drawing.Point(10, 21);
            this.dataClear.Name = "dataClear";
            this.dataClear.Size = new System.Drawing.Size(135, 25);
            this.dataClear.TabIndex = 4;
            this.dataClear.Text = "Data Clear";
            this.dataClear.UseVisualStyleBackColor = true;
            this.dataClear.Click += new System.EventHandler(this.dataClear_Click);
            // 
            // textBox_cmd
            // 
            this.textBox_cmd.Location = new System.Drawing.Point(10, 20);
            this.textBox_cmd.Name = "textBox_cmd";
            this.textBox_cmd.Size = new System.Drawing.Size(135, 21);
            this.textBox_cmd.TabIndex = 92;
            this.textBox_cmd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_cmd_KeyDown);
            // 
            // btnBuffClear
            // 
            this.btnBuffClear.Location = new System.Drawing.Point(10, 109);
            this.btnBuffClear.Name = "btnBuffClear";
            this.btnBuffClear.Size = new System.Drawing.Size(135, 25);
            this.btnBuffClear.TabIndex = 95;
            this.btnBuffClear.Text = "Buffer Clear";
            this.btnBuffClear.UseVisualStyleBackColor = true;
            this.btnBuffClear.Click += new System.EventHandler(this.btnComClear_Click);
            // 
            // button_cmd
            // 
            this.button_cmd.Location = new System.Drawing.Point(10, 47);
            this.button_cmd.Name = "button_cmd";
            this.button_cmd.Size = new System.Drawing.Size(135, 25);
            this.button_cmd.TabIndex = 93;
            this.button_cmd.Text = "Enter";
            this.button_cmd.UseVisualStyleBackColor = true;
            this.button_cmd.Click += new System.EventHandler(this.button_cmd_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(10, 78);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(135, 25);
            this.button_clear.TabIndex = 94;
            this.button_clear.Text = "RX Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_cmd);
            this.groupBox1.Controls.Add(this.button_clear);
            this.groupBox1.Controls.Add(this.btnBuffClear);
            this.groupBox1.Controls.Add(this.button_cmd);
            this.groupBox1.Location = new System.Drawing.Point(1557, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 145);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TX";
            // 
            // tabCon
            // 
            this.tabCon.Controls.Add(this.tabPage1);
            this.tabCon.Controls.Add(this.tabPage3);
            this.tabCon.Location = new System.Drawing.Point(9, 12);
            this.tabCon.Name = "tabCon";
            this.tabCon.SelectedIndex = 0;
            this.tabCon.Size = new System.Drawing.Size(1542, 650);
            this.tabCon.TabIndex = 94;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvFirst);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1534, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tool 1.0.1ver";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvFirst
            // 
            this.dgvFirst.AllowDrop = true;
            this.dgvFirst.AllowUserToAddRows = false;
            this.dgvFirst.AllowUserToOrderColumns = true;
            this.dgvFirst.AllowUserToResizeRows = false;
            this.dgvFirst.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFirst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFirst.ColumnHeadersHeight = 30;
            this.dgvFirst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFirst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtCounter,
            this.dgvtTime,
            this.dgvtData,
            this.dgvtTireID,
            this.dgvtLibVer,
            this.dgvtSensorVer,
            this.dgvtReceiverVer,
            this.dgvtPressure,
            this.dgvtZaxis,
            this.dgvtXaxis,
            this.dgvtVolt,
            this.dgvtTemp,
            this.dgvtFrameID,
            this.dgvtCrc,
            this.dgvtRssi,
            this.dgvtPeriod});
            this.dgvFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFirst.Location = new System.Drawing.Point(3, 3);
            this.dgvFirst.Name = "dgvFirst";
            this.dgvFirst.RowHeadersWidth = 25;
            this.dgvFirst.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFirst.RowTemplate.Height = 40;
            this.dgvFirst.Size = new System.Drawing.Size(1528, 618);
            this.dgvFirst.TabIndex = 8;
            this.dgvFirst.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFirst_CellClick);
            this.dgvFirst.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvFirst_Scroll);
            // 
            // dgvtCounter
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtCounter.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtCounter.FillWeight = 200F;
            this.dgvtCounter.Frozen = true;
            this.dgvtCounter.HeaderText = "Counter";
            this.dgvtCounter.Name = "dgvtCounter";
            this.dgvtCounter.Width = 60;
            // 
            // dgvtTime
            // 
            this.dgvtTime.Frozen = true;
            this.dgvtTime.HeaderText = "Time";
            this.dgvtTime.Name = "dgvtTime";
            // 
            // dgvtData
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtData.Frozen = true;
            this.dgvtData.HeaderText = "Data";
            this.dgvtData.Name = "dgvtData";
            this.dgvtData.Width = 410;
            // 
            // dgvtTireID
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtTireID.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtTireID.Frozen = true;
            this.dgvtTireID.HeaderText = "Tire ID";
            this.dgvtTireID.Name = "dgvtTireID";
            this.dgvtTireID.Width = 80;
            // 
            // dgvtLibVer
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtLibVer.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtLibVer.Frozen = true;
            this.dgvtLibVer.HeaderText = "lib ver";
            this.dgvtLibVer.Name = "dgvtLibVer";
            this.dgvtLibVer.Width = 70;
            // 
            // dgvtSensorVer
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtSensorVer.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvtSensorVer.Frozen = true;
            this.dgvtSensorVer.HeaderText = "sensor v";
            this.dgvtSensorVer.Name = "dgvtSensorVer";
            this.dgvtSensorVer.Width = 80;
            // 
            // dgvtReceiverVer
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtReceiverVer.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvtReceiverVer.Frozen = true;
            this.dgvtReceiverVer.HeaderText = "receive v";
            this.dgvtReceiverVer.Name = "dgvtReceiverVer";
            this.dgvtReceiverVer.Width = 80;
            // 
            // dgvtPressure
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtPressure.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvtPressure.Frozen = true;
            this.dgvtPressure.HeaderText = "pressure";
            this.dgvtPressure.Name = "dgvtPressure";
            this.dgvtPressure.Width = 80;
            // 
            // dgvtZaxis
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtZaxis.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvtZaxis.Frozen = true;
            this.dgvtZaxis.HeaderText = "z-axis";
            this.dgvtZaxis.Name = "dgvtZaxis";
            this.dgvtZaxis.Width = 70;
            // 
            // dgvtXaxis
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtXaxis.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvtXaxis.Frozen = true;
            this.dgvtXaxis.HeaderText = "x-axis";
            this.dgvtXaxis.Name = "dgvtXaxis";
            this.dgvtXaxis.Width = 70;
            // 
            // dgvtVolt
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtVolt.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvtVolt.Frozen = true;
            this.dgvtVolt.HeaderText = "volt(V)";
            this.dgvtVolt.Name = "dgvtVolt";
            this.dgvtVolt.Width = 60;
            // 
            // dgvtTemp
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtTemp.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvtTemp.Frozen = true;
            this.dgvtTemp.HeaderText = "temp(℃)";
            this.dgvtTemp.Name = "dgvtTemp";
            this.dgvtTemp.Width = 80;
            // 
            // dgvtFrameID
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtFrameID.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvtFrameID.Frozen = true;
            this.dgvtFrameID.HeaderText = "frame id";
            this.dgvtFrameID.Name = "dgvtFrameID";
            this.dgvtFrameID.Width = 80;
            // 
            // dgvtCrc
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtCrc.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvtCrc.Frozen = true;
            this.dgvtCrc.HeaderText = "crc";
            this.dgvtCrc.Name = "dgvtCrc";
            this.dgvtCrc.Width = 40;
            // 
            // dgvtRssi
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtRssi.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvtRssi.Frozen = true;
            this.dgvtRssi.HeaderText = "rssi";
            this.dgvtRssi.Name = "dgvtRssi";
            this.dgvtRssi.Width = 40;
            // 
            // dgvtPeriod
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtPeriod.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvtPeriod.Frozen = true;
            this.dgvtPeriod.HeaderText = "period(ms)";
            this.dgvtPeriod.Name = "dgvtPeriod";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1534, 624);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "config";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // debuggingLogo
            // 
            this.debuggingLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debuggingLogo.Location = new System.Drawing.Point(1567, 668);
            this.debuggingLogo.Name = "debuggingLogo";
            this.debuggingLogo.Size = new System.Drawing.Size(135, 42);
            this.debuggingLogo.TabIndex = 96;
            this.debuggingLogo.UseVisualStyleBackColor = true;
            this.debuggingLogo.Click += new System.EventHandler(this.debuggingBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "240_320_Cat.png");
            this.imageList1.Images.SetKeyName(1, "240_320_Cat.png");
            // 
            // tpmsTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1715, 724);
            this.Controls.Add(this.debuggingLogo);
            this.Controls.Add(this.tabCon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.textBox_msg);
            this.Controls.Add(this.SerialPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tpmsTester";
            this.Text = "TPMS Tester by CHANHIHI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.SerialPort.ResumeLayout(false);
            this.data.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCon.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox SerialPort;
        public System.Windows.Forms.Button btnUartConnect;
        public System.Windows.Forms.Button btnUartDisconnect;
        public System.Windows.Forms.ComboBox cbComPort;
        public System.Windows.Forms.Button close;
        public System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.GroupBox data;
        private System.Windows.Forms.Button dataSave;
        private System.Windows.Forms.Button dataClear;
        private System.Windows.Forms.TextBox textBox_cmd;
        private System.Windows.Forms.Button btnBuffClear;
        private System.Windows.Forms.Button button_cmd;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabCon;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvFirst;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button debuggingLogo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtTireID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtLibVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtSensorVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtReceiverVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtZaxis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtXaxis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtVolt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtFrameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtCrc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtRssi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtPeriod;
    }
}

