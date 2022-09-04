namespace HRM
{
    partial class HRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRM));
            this.globalRefreshRateTimer = new System.Windows.Forms.Timer(this.components);
            this.portListLabel = new System.Windows.Forms.Label();
            this.portNameList = new System.Windows.Forms.ComboBox();
            this.ConsoleBox = new System.Windows.Forms.RichTextBox();
            this.consoleInputTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.baudRateList = new System.Windows.Forms.ComboBox();
            this.autoScrollCheckBox = new System.Windows.Forms.CheckBox();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.loadCellLabel = new System.Windows.Forms.Label();
            this.loadCellTareButton = new System.Windows.Forms.Button();
            this.startStopButton = new System.Windows.Forms.Button();
            this.startStopButtonPanel = new System.Windows.Forms.Panel();
            this.serialGroup = new System.Windows.Forms.GroupBox();
            this.openCloseSerialButton = new System.Windows.Forms.Button();
            this.LANGroup = new System.Windows.Forms.GroupBox();
            this.LANTestButton = new System.Windows.Forms.Button();
            this.LANStatusLabel = new System.Windows.Forms.Label();
            this.IPAddressApplyButton = new System.Windows.Forms.Button();
            this.IPAddressTextBox = new System.Windows.Forms.TextBox();
            this.IPAddressLabel = new System.Windows.Forms.Label();
            this.getDataRefreshRateTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGroup = new System.Windows.Forms.GroupBox();
            this.displayChartButton = new System.Windows.Forms.Button();
            this.pressureGroup = new System.Windows.Forms.GroupBox();
            this.inletPressureLabel = new System.Windows.Forms.Label();
            this.P_inTextBox = new System.Windows.Forms.TextBox();
            this.chamberPressureLabel = new System.Windows.Forms.Label();
            this.P_cTextBox = new System.Windows.Forms.TextBox();
            this.temperatureGroup = new System.Windows.Forms.GroupBox();
            this.inletTemperatureLabel = new System.Windows.Forms.Label();
            this.T_inTextBox = new System.Windows.Forms.TextBox();
            this.chamberTemperatureLabel = new System.Windows.Forms.Label();
            this.T_cTextBox = new System.Windows.Forms.TextBox();
            this.FTextBox = new System.Windows.Forms.TextBox();
            this.thrustLabel = new System.Windows.Forms.Label();
            this.refreshRateLabel = new System.Windows.Forms.Label();
            this.refreshRateTextBox = new System.Windows.Forms.TextBox();
            this.refreshRateApplyButton = new System.Windows.Forms.Button();
            this.exportCsvButton = new System.Windows.Forms.Button();
            this.serialChannelRadioButton = new System.Windows.Forms.RadioButton();
            this.LANChannelRadioButton = new System.Windows.Forms.RadioButton();
            this.channelGroup = new System.Windows.Forms.GroupBox();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.valveOverrideControlGroup = new System.Windows.Forms.GroupBox();
            this.closeValveButton = new System.Windows.Forms.Button();
            this.openValveButton = new System.Windows.Forms.Button();
            this.startStopButtonPanel.SuspendLayout();
            this.serialGroup.SuspendLayout();
            this.LANGroup.SuspendLayout();
            this.dataGroup.SuspendLayout();
            this.pressureGroup.SuspendLayout();
            this.temperatureGroup.SuspendLayout();
            this.channelGroup.SuspendLayout();
            this.valveOverrideControlGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // globalRefreshRateTimer
            // 
            this.globalRefreshRateTimer.Tick += new System.EventHandler(this.globalRefreshRateTimer_Tick);
            // 
            // portListLabel
            // 
            this.portListLabel.AutoSize = true;
            this.portListLabel.Location = new System.Drawing.Point(4, 24);
            this.portListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portListLabel.Name = "portListLabel";
            this.portListLabel.Size = new System.Drawing.Size(45, 13);
            this.portListLabel.TabIndex = 1;
            this.portListLabel.Text = "Port List";
            // 
            // portNameList
            // 
            this.portNameList.FormattingEnabled = true;
            this.portNameList.Location = new System.Drawing.Point(4, 39);
            this.portNameList.Margin = new System.Windows.Forms.Padding(2);
            this.portNameList.Name = "portNameList";
            this.portNameList.Size = new System.Drawing.Size(64, 21);
            this.portNameList.TabIndex = 3;
            this.portNameList.SelectedValueChanged += new System.EventHandler(this.portList_SelectedValueChanged);
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsoleBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConsoleBox.Location = new System.Drawing.Point(9, 201);
            this.ConsoleBox.Margin = new System.Windows.Forms.Padding(2);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.ReadOnly = true;
            this.ConsoleBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.ConsoleBox.Size = new System.Drawing.Size(584, 158);
            this.ConsoleBox.TabIndex = 4;
            this.ConsoleBox.Text = "";
            this.ConsoleBox.WordWrap = false;
            // 
            // consoleInputTextBox
            // 
            this.consoleInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleInputTextBox.Location = new System.Drawing.Point(9, 178);
            this.consoleInputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.consoleInputTextBox.Name = "consoleInputTextBox";
            this.consoleInputTextBox.Size = new System.Drawing.Size(523, 20);
            this.consoleInputTextBox.TabIndex = 5;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(536, 177);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(56, 22);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(70, 24);
            this.baudRateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(58, 13);
            this.baudRateLabel.TabIndex = 7;
            this.baudRateLabel.Text = "Baud Rate";
            // 
            // baudRateList
            // 
            this.baudRateList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.baudRateList.FormattingEnabled = true;
            this.baudRateList.Location = new System.Drawing.Point(72, 39);
            this.baudRateList.Margin = new System.Windows.Forms.Padding(2);
            this.baudRateList.Name = "baudRateList";
            this.baudRateList.Size = new System.Drawing.Size(74, 21);
            this.baudRateList.TabIndex = 8;
            this.baudRateList.SelectedValueChanged += new System.EventHandler(this.baudRateList_SelectedValueChanged);
            // 
            // autoScrollCheckBox
            // 
            this.autoScrollCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autoScrollCheckBox.AutoSize = true;
            this.autoScrollCheckBox.Location = new System.Drawing.Point(9, 368);
            this.autoScrollCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.autoScrollCheckBox.Name = "autoScrollCheckBox";
            this.autoScrollCheckBox.Size = new System.Drawing.Size(77, 17);
            this.autoScrollCheckBox.TabIndex = 9;
            this.autoScrollCheckBox.Text = "Auto Scroll";
            this.autoScrollCheckBox.UseVisualStyleBackColor = true;
            this.autoScrollCheckBox.CheckedChanged += new System.EventHandler(this.autoScrollCheckBox_CheckedChanged);
            // 
            // clearDataButton
            // 
            this.clearDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearDataButton.Location = new System.Drawing.Point(520, 363);
            this.clearDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearDataButton.Name = "clearDataButton";
            this.clearDataButton.Size = new System.Drawing.Size(72, 22);
            this.clearDataButton.TabIndex = 10;
            this.clearDataButton.Text = "Clear Data";
            this.clearDataButton.UseVisualStyleBackColor = true;
            this.clearDataButton.Click += new System.EventHandler(this.clearDataButton_Click);
            // 
            // loadCellLabel
            // 
            this.loadCellLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadCellLabel.AutoSize = true;
            this.loadCellLabel.Location = new System.Drawing.Point(596, 84);
            this.loadCellLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loadCellLabel.Name = "loadCellLabel";
            this.loadCellLabel.Size = new System.Drawing.Size(51, 13);
            this.loadCellLabel.TabIndex = 13;
            this.loadCellLabel.Text = "Load Cell";
            // 
            // loadCellTareButton
            // 
            this.loadCellTareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadCellTareButton.Location = new System.Drawing.Point(596, 99);
            this.loadCellTareButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadCellTareButton.Name = "loadCellTareButton";
            this.loadCellTareButton.Size = new System.Drawing.Size(56, 22);
            this.loadCellTareButton.TabIndex = 14;
            this.loadCellTareButton.Text = "Tare";
            this.loadCellTareButton.UseVisualStyleBackColor = true;
            this.loadCellTareButton.Click += new System.EventHandler(this.loadCellTareButton_Click);
            // 
            // startStopButton
            // 
            this.startStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startStopButton.Location = new System.Drawing.Point(17, 94);
            this.startStopButton.Margin = new System.Windows.Forms.Padding(2);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(132, 50);
            this.startStopButton.TabIndex = 15;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // startStopButtonPanel
            // 
            this.startStopButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startStopButtonPanel.Controls.Add(this.startStopButton);
            this.startStopButtonPanel.Location = new System.Drawing.Point(596, 146);
            this.startStopButtonPanel.Margin = new System.Windows.Forms.Padding(2);
            this.startStopButtonPanel.Name = "startStopButtonPanel";
            this.startStopButtonPanel.Size = new System.Drawing.Size(166, 239);
            this.startStopButtonPanel.TabIndex = 16;
            // 
            // serialGroup
            // 
            this.serialGroup.Controls.Add(this.openCloseSerialButton);
            this.serialGroup.Controls.Add(this.baudRateList);
            this.serialGroup.Controls.Add(this.portListLabel);
            this.serialGroup.Controls.Add(this.portNameList);
            this.serialGroup.Controls.Add(this.baudRateLabel);
            this.serialGroup.Location = new System.Drawing.Point(9, 7);
            this.serialGroup.Margin = new System.Windows.Forms.Padding(2);
            this.serialGroup.Name = "serialGroup";
            this.serialGroup.Padding = new System.Windows.Forms.Padding(2);
            this.serialGroup.Size = new System.Drawing.Size(220, 65);
            this.serialGroup.TabIndex = 19;
            this.serialGroup.TabStop = false;
            this.serialGroup.Text = "USB";
            // 
            // openCloseSerialButton
            // 
            this.openCloseSerialButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openCloseSerialButton.Location = new System.Drawing.Point(150, 38);
            this.openCloseSerialButton.Margin = new System.Windows.Forms.Padding(2);
            this.openCloseSerialButton.Name = "openCloseSerialButton";
            this.openCloseSerialButton.Size = new System.Drawing.Size(64, 22);
            this.openCloseSerialButton.TabIndex = 24;
            this.openCloseSerialButton.Text = "Open";
            this.openCloseSerialButton.UseVisualStyleBackColor = true;
            this.openCloseSerialButton.Click += new System.EventHandler(this.openCloseSerialButton_Click);
            // 
            // LANGroup
            // 
            this.LANGroup.Controls.Add(this.LANTestButton);
            this.LANGroup.Controls.Add(this.LANStatusLabel);
            this.LANGroup.Controls.Add(this.IPAddressApplyButton);
            this.LANGroup.Controls.Add(this.IPAddressTextBox);
            this.LANGroup.Controls.Add(this.IPAddressLabel);
            this.LANGroup.Location = new System.Drawing.Point(234, 7);
            this.LANGroup.Margin = new System.Windows.Forms.Padding(2);
            this.LANGroup.Name = "LANGroup";
            this.LANGroup.Padding = new System.Windows.Forms.Padding(2);
            this.LANGroup.Size = new System.Drawing.Size(207, 65);
            this.LANGroup.TabIndex = 20;
            this.LANGroup.TabStop = false;
            this.LANGroup.Text = "LAN";
            // 
            // LANTestButton
            // 
            this.LANTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LANTestButton.Location = new System.Drawing.Point(70, 11);
            this.LANTestButton.Margin = new System.Windows.Forms.Padding(2);
            this.LANTestButton.Name = "LANTestButton";
            this.LANTestButton.Size = new System.Drawing.Size(44, 22);
            this.LANTestButton.TabIndex = 23;
            this.LANTestButton.Text = "Test";
            this.LANTestButton.UseVisualStyleBackColor = true;
            this.LANTestButton.Click += new System.EventHandler(this.LANTestButton_Click);
            // 
            // LANStatusLabel
            // 
            this.LANStatusLabel.AutoSize = true;
            this.LANStatusLabel.Location = new System.Drawing.Point(120, 15);
            this.LANStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LANStatusLabel.Name = "LANStatusLabel";
            this.LANStatusLabel.Size = new System.Drawing.Size(10, 13);
            this.LANStatusLabel.TabIndex = 22;
            this.LANStatusLabel.Text = " ";
            // 
            // IPAddressApplyButton
            // 
            this.IPAddressApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IPAddressApplyButton.Location = new System.Drawing.Point(133, 41);
            this.IPAddressApplyButton.Margin = new System.Windows.Forms.Padding(2);
            this.IPAddressApplyButton.Name = "IPAddressApplyButton";
            this.IPAddressApplyButton.Size = new System.Drawing.Size(70, 22);
            this.IPAddressApplyButton.TabIndex = 21;
            this.IPAddressApplyButton.Text = "Apply";
            this.IPAddressApplyButton.UseVisualStyleBackColor = true;
            this.IPAddressApplyButton.Click += new System.EventHandler(this.IPAddressApplyButton_Click);
            // 
            // IPAddressTextBox
            // 
            this.IPAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPAddressTextBox.Location = new System.Drawing.Point(4, 42);
            this.IPAddressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IPAddressTextBox.Name = "IPAddressTextBox";
            this.IPAddressTextBox.Size = new System.Drawing.Size(125, 20);
            this.IPAddressTextBox.TabIndex = 21;
            this.IPAddressTextBox.TextChanged += new System.EventHandler(this.IPAddressTextBox_TextChanged);
            this.IPAddressTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IPAddressTextBox_KeyDown);
            this.IPAddressTextBox.MouseHover += new System.EventHandler(this.IPAddressTextBox_MouseHover);
            // 
            // IPAddressLabel
            // 
            this.IPAddressLabel.AutoSize = true;
            this.IPAddressLabel.Location = new System.Drawing.Point(4, 25);
            this.IPAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IPAddressLabel.Name = "IPAddressLabel";
            this.IPAddressLabel.Size = new System.Drawing.Size(58, 13);
            this.IPAddressLabel.TabIndex = 9;
            this.IPAddressLabel.Text = "IP Address";
            // 
            // getDataRefreshRateTimer
            // 
            this.getDataRefreshRateTimer.Interval = 1000;
            this.getDataRefreshRateTimer.Tick += new System.EventHandler(this.getDataRefreshRateTimer_Tick);
            // 
            // dataGroup
            // 
            this.dataGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGroup.Controls.Add(this.displayChartButton);
            this.dataGroup.Controls.Add(this.pressureGroup);
            this.dataGroup.Controls.Add(this.temperatureGroup);
            this.dataGroup.Controls.Add(this.FTextBox);
            this.dataGroup.Controls.Add(this.thrustLabel);
            this.dataGroup.Location = new System.Drawing.Point(10, 77);
            this.dataGroup.Margin = new System.Windows.Forms.Padding(2);
            this.dataGroup.Name = "dataGroup";
            this.dataGroup.Padding = new System.Windows.Forms.Padding(2);
            this.dataGroup.Size = new System.Drawing.Size(582, 81);
            this.dataGroup.TabIndex = 21;
            this.dataGroup.TabStop = false;
            this.dataGroup.Text = "Data";
            // 
            // displayChartButton
            // 
            this.displayChartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.displayChartButton.Location = new System.Drawing.Point(491, 13);
            this.displayChartButton.Margin = new System.Windows.Forms.Padding(2);
            this.displayChartButton.Name = "displayChartButton";
            this.displayChartButton.Size = new System.Drawing.Size(84, 22);
            this.displayChartButton.TabIndex = 26;
            this.displayChartButton.Text = "Display Chart";
            this.displayChartButton.UseVisualStyleBackColor = true;
            this.displayChartButton.Click += new System.EventHandler(this.displayChartButton_Click);
            // 
            // pressureGroup
            // 
            this.pressureGroup.Controls.Add(this.inletPressureLabel);
            this.pressureGroup.Controls.Add(this.P_inTextBox);
            this.pressureGroup.Controls.Add(this.chamberPressureLabel);
            this.pressureGroup.Controls.Add(this.P_cTextBox);
            this.pressureGroup.Location = new System.Drawing.Point(221, 17);
            this.pressureGroup.Margin = new System.Windows.Forms.Padding(2);
            this.pressureGroup.Name = "pressureGroup";
            this.pressureGroup.Padding = new System.Windows.Forms.Padding(2);
            this.pressureGroup.Size = new System.Drawing.Size(211, 59);
            this.pressureGroup.TabIndex = 34;
            this.pressureGroup.TabStop = false;
            this.pressureGroup.Text = "Pressure (Pa)";
            // 
            // inletPressureLabel
            // 
            this.inletPressureLabel.AutoSize = true;
            this.inletPressureLabel.Location = new System.Drawing.Point(4, 20);
            this.inletPressureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inletPressureLabel.Name = "inletPressureLabel";
            this.inletPressureLabel.Size = new System.Drawing.Size(27, 13);
            this.inletPressureLabel.TabIndex = 27;
            this.inletPressureLabel.Text = "Inlet";
            // 
            // P_inTextBox
            // 
            this.P_inTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.P_inTextBox.Location = new System.Drawing.Point(7, 35);
            this.P_inTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.P_inTextBox.Name = "P_inTextBox";
            this.P_inTextBox.ReadOnly = true;
            this.P_inTextBox.Size = new System.Drawing.Size(97, 20);
            this.P_inTextBox.TabIndex = 28;
            // 
            // chamberPressureLabel
            // 
            this.chamberPressureLabel.AutoSize = true;
            this.chamberPressureLabel.Location = new System.Drawing.Point(106, 20);
            this.chamberPressureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chamberPressureLabel.Name = "chamberPressureLabel";
            this.chamberPressureLabel.Size = new System.Drawing.Size(49, 13);
            this.chamberPressureLabel.TabIndex = 29;
            this.chamberPressureLabel.Text = "Chamber";
            // 
            // P_cTextBox
            // 
            this.P_cTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.P_cTextBox.Location = new System.Drawing.Point(107, 35);
            this.P_cTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.P_cTextBox.Name = "P_cTextBox";
            this.P_cTextBox.ReadOnly = true;
            this.P_cTextBox.Size = new System.Drawing.Size(97, 20);
            this.P_cTextBox.TabIndex = 30;
            // 
            // temperatureGroup
            // 
            this.temperatureGroup.Controls.Add(this.inletTemperatureLabel);
            this.temperatureGroup.Controls.Add(this.T_inTextBox);
            this.temperatureGroup.Controls.Add(this.chamberTemperatureLabel);
            this.temperatureGroup.Controls.Add(this.T_cTextBox);
            this.temperatureGroup.Location = new System.Drawing.Point(6, 17);
            this.temperatureGroup.Margin = new System.Windows.Forms.Padding(2);
            this.temperatureGroup.Name = "temperatureGroup";
            this.temperatureGroup.Padding = new System.Windows.Forms.Padding(2);
            this.temperatureGroup.Size = new System.Drawing.Size(211, 59);
            this.temperatureGroup.TabIndex = 33;
            this.temperatureGroup.TabStop = false;
            this.temperatureGroup.Text = "Temperature (°C)";
            // 
            // inletTemperatureLabel
            // 
            this.inletTemperatureLabel.AutoSize = true;
            this.inletTemperatureLabel.Location = new System.Drawing.Point(4, 20);
            this.inletTemperatureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inletTemperatureLabel.Name = "inletTemperatureLabel";
            this.inletTemperatureLabel.Size = new System.Drawing.Size(27, 13);
            this.inletTemperatureLabel.TabIndex = 23;
            this.inletTemperatureLabel.Text = "Inlet";
            // 
            // T_inTextBox
            // 
            this.T_inTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.T_inTextBox.Location = new System.Drawing.Point(7, 35);
            this.T_inTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.T_inTextBox.Name = "T_inTextBox";
            this.T_inTextBox.ReadOnly = true;
            this.T_inTextBox.Size = new System.Drawing.Size(97, 20);
            this.T_inTextBox.TabIndex = 24;
            // 
            // chamberTemperatureLabel
            // 
            this.chamberTemperatureLabel.AutoSize = true;
            this.chamberTemperatureLabel.Location = new System.Drawing.Point(106, 20);
            this.chamberTemperatureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chamberTemperatureLabel.Name = "chamberTemperatureLabel";
            this.chamberTemperatureLabel.Size = new System.Drawing.Size(49, 13);
            this.chamberTemperatureLabel.TabIndex = 25;
            this.chamberTemperatureLabel.Text = "Chamber";
            // 
            // T_cTextBox
            // 
            this.T_cTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.T_cTextBox.Location = new System.Drawing.Point(107, 35);
            this.T_cTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.T_cTextBox.Name = "T_cTextBox";
            this.T_cTextBox.ReadOnly = true;
            this.T_cTextBox.Size = new System.Drawing.Size(97, 20);
            this.T_cTextBox.TabIndex = 26;
            // 
            // FTextBox
            // 
            this.FTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FTextBox.Location = new System.Drawing.Point(436, 52);
            this.FTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FTextBox.Name = "FTextBox";
            this.FTextBox.ReadOnly = true;
            this.FTextBox.Size = new System.Drawing.Size(106, 20);
            this.FTextBox.TabIndex = 32;
            // 
            // thrustLabel
            // 
            this.thrustLabel.AutoSize = true;
            this.thrustLabel.Location = new System.Drawing.Point(436, 37);
            this.thrustLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thrustLabel.Name = "thrustLabel";
            this.thrustLabel.Size = new System.Drawing.Size(54, 13);
            this.thrustLabel.TabIndex = 31;
            this.thrustLabel.Text = "Thrust (N)";
            // 
            // refreshRateLabel
            // 
            this.refreshRateLabel.AutoSize = true;
            this.refreshRateLabel.Location = new System.Drawing.Point(446, 7);
            this.refreshRateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.refreshRateLabel.Name = "refreshRateLabel";
            this.refreshRateLabel.Size = new System.Drawing.Size(92, 13);
            this.refreshRateLabel.TabIndex = 22;
            this.refreshRateLabel.Text = "Refresh Rate (ms)";
            // 
            // refreshRateTextBox
            // 
            this.refreshRateTextBox.Location = new System.Drawing.Point(448, 25);
            this.refreshRateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.refreshRateTextBox.Name = "refreshRateTextBox";
            this.refreshRateTextBox.Size = new System.Drawing.Size(85, 20);
            this.refreshRateTextBox.TabIndex = 23;
            this.refreshRateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.refreshRateBox_KeyDown);
            // 
            // refreshRateApplyButton
            // 
            this.refreshRateApplyButton.Location = new System.Drawing.Point(536, 24);
            this.refreshRateApplyButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshRateApplyButton.Name = "refreshRateApplyButton";
            this.refreshRateApplyButton.Size = new System.Drawing.Size(56, 22);
            this.refreshRateApplyButton.TabIndex = 23;
            this.refreshRateApplyButton.Text = "Apply";
            this.refreshRateApplyButton.UseVisualStyleBackColor = true;
            this.refreshRateApplyButton.Click += new System.EventHandler(this.refreshRateApplyButton_Click);
            // 
            // exportCsvButton
            // 
            this.exportCsvButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportCsvButton.Location = new System.Drawing.Point(445, 363);
            this.exportCsvButton.Margin = new System.Windows.Forms.Padding(2);
            this.exportCsvButton.Name = "exportCsvButton";
            this.exportCsvButton.Size = new System.Drawing.Size(71, 22);
            this.exportCsvButton.TabIndex = 24;
            this.exportCsvButton.Text = "Export .csv";
            this.exportCsvButton.UseVisualStyleBackColor = true;
            this.exportCsvButton.Click += new System.EventHandler(this.exportCsvButton_Click);
            // 
            // serialChannelRadioButton
            // 
            this.serialChannelRadioButton.AutoSize = true;
            this.serialChannelRadioButton.Location = new System.Drawing.Point(4, 17);
            this.serialChannelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.serialChannelRadioButton.Name = "serialChannelRadioButton";
            this.serialChannelRadioButton.Size = new System.Drawing.Size(47, 17);
            this.serialChannelRadioButton.TabIndex = 16;
            this.serialChannelRadioButton.TabStop = true;
            this.serialChannelRadioButton.Text = "USB";
            this.serialChannelRadioButton.UseVisualStyleBackColor = true;
            this.serialChannelRadioButton.CheckedChanged += new System.EventHandler(this.serialChannel_CheckedChanged);
            // 
            // LANChannelRadioButton
            // 
            this.LANChannelRadioButton.AutoSize = true;
            this.LANChannelRadioButton.Location = new System.Drawing.Point(4, 38);
            this.LANChannelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.LANChannelRadioButton.Name = "LANChannelRadioButton";
            this.LANChannelRadioButton.Size = new System.Drawing.Size(46, 17);
            this.LANChannelRadioButton.TabIndex = 17;
            this.LANChannelRadioButton.TabStop = true;
            this.LANChannelRadioButton.Text = "LAN";
            this.LANChannelRadioButton.UseVisualStyleBackColor = true;
            this.LANChannelRadioButton.CheckedChanged += new System.EventHandler(this.LANChannel_CheckedChanged);
            // 
            // channelGroup
            // 
            this.channelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.channelGroup.Controls.Add(this.serialChannelRadioButton);
            this.channelGroup.Controls.Add(this.LANChannelRadioButton);
            this.channelGroup.Location = new System.Drawing.Point(657, 84);
            this.channelGroup.Margin = new System.Windows.Forms.Padding(2);
            this.channelGroup.Name = "channelGroup";
            this.channelGroup.Padding = new System.Windows.Forms.Padding(2);
            this.channelGroup.Size = new System.Drawing.Size(105, 58);
            this.channelGroup.TabIndex = 25;
            this.channelGroup.TabStop = false;
            this.channelGroup.Text = "Channel";
            // 
            // serial
            // 
            this.serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_DataReceived);
            // 
            // valveOverrideControlGroup
            // 
            this.valveOverrideControlGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.valveOverrideControlGroup.Controls.Add(this.closeValveButton);
            this.valveOverrideControlGroup.Controls.Add(this.openValveButton);
            this.valveOverrideControlGroup.Location = new System.Drawing.Point(597, 7);
            this.valveOverrideControlGroup.Margin = new System.Windows.Forms.Padding(2);
            this.valveOverrideControlGroup.Name = "valveOverrideControlGroup";
            this.valveOverrideControlGroup.Padding = new System.Windows.Forms.Padding(2);
            this.valveOverrideControlGroup.Size = new System.Drawing.Size(165, 73);
            this.valveOverrideControlGroup.TabIndex = 26;
            this.valveOverrideControlGroup.TabStop = false;
            this.valveOverrideControlGroup.Text = "Valve Override Control";
            // 
            // closeValveButton
            // 
            this.closeValveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeValveButton.Location = new System.Drawing.Point(54, 44);
            this.closeValveButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeValveButton.Name = "closeValveButton";
            this.closeValveButton.Size = new System.Drawing.Size(56, 22);
            this.closeValveButton.TabIndex = 28;
            this.closeValveButton.Text = "Close";
            this.closeValveButton.UseVisualStyleBackColor = true;
            this.closeValveButton.Click += new System.EventHandler(this.closeValveButton_Click);
            // 
            // openValveButton
            // 
            this.openValveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openValveButton.Location = new System.Drawing.Point(54, 18);
            this.openValveButton.Margin = new System.Windows.Forms.Padding(2);
            this.openValveButton.Name = "openValveButton";
            this.openValveButton.Size = new System.Drawing.Size(56, 22);
            this.openValveButton.TabIndex = 27;
            this.openValveButton.Text = "Open";
            this.openValveButton.UseVisualStyleBackColor = true;
            this.openValveButton.Click += new System.EventHandler(this.openValveButton_Click);
            // 
            // HRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 395);
            this.Controls.Add(this.valveOverrideControlGroup);
            this.Controls.Add(this.channelGroup);
            this.Controls.Add(this.exportCsvButton);
            this.Controls.Add(this.refreshRateApplyButton);
            this.Controls.Add(this.refreshRateTextBox);
            this.Controls.Add(this.refreshRateLabel);
            this.Controls.Add(this.dataGroup);
            this.Controls.Add(this.LANGroup);
            this.Controls.Add(this.serialGroup);
            this.Controls.Add(this.startStopButtonPanel);
            this.Controls.Add(this.loadCellTareButton);
            this.Controls.Add(this.loadCellLabel);
            this.Controls.Add(this.clearDataButton);
            this.Controls.Add(this.autoScrollCheckBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.consoleInputTextBox);
            this.Controls.Add(this.ConsoleBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(758, 331);
            this.Name = "HRM";
            this.Text = "HRM";
            this.Leave += new System.EventHandler(this.HRM_Leave);
            this.Resize += new System.EventHandler(this.HRM_Resize);
            this.startStopButtonPanel.ResumeLayout(false);
            this.serialGroup.ResumeLayout(false);
            this.serialGroup.PerformLayout();
            this.LANGroup.ResumeLayout(false);
            this.LANGroup.PerformLayout();
            this.dataGroup.ResumeLayout(false);
            this.dataGroup.PerformLayout();
            this.pressureGroup.ResumeLayout(false);
            this.pressureGroup.PerformLayout();
            this.temperatureGroup.ResumeLayout(false);
            this.temperatureGroup.PerformLayout();
            this.channelGroup.ResumeLayout(false);
            this.channelGroup.PerformLayout();
            this.valveOverrideControlGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label portListLabel;
        private System.Windows.Forms.ComboBox portNameList;
        private System.Windows.Forms.RichTextBox ConsoleBox;
        private System.Windows.Forms.TextBox consoleInputTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.ComboBox baudRateList;
        private System.Windows.Forms.CheckBox autoScrollCheckBox;
        private System.Windows.Forms.Label loadCellLabel;
        private System.Windows.Forms.Button loadCellTareButton;
        private System.Windows.Forms.Panel startStopButtonPanel;
        private System.Windows.Forms.GroupBox serialGroup;
        private System.Windows.Forms.GroupBox LANGroup;
        private System.Windows.Forms.Button IPAddressApplyButton;
        private System.Windows.Forms.TextBox IPAddressTextBox;
        private System.Windows.Forms.Label IPAddressLabel;
        private System.Windows.Forms.Label LANStatusLabel;
        private System.Windows.Forms.GroupBox dataGroup;
        private System.Windows.Forms.TextBox FTextBox;
        private System.Windows.Forms.Label thrustLabel;
        private System.Windows.Forms.TextBox P_cTextBox;
        private System.Windows.Forms.Label chamberPressureLabel;
        private System.Windows.Forms.TextBox P_inTextBox;
        private System.Windows.Forms.Label inletPressureLabel;
        private System.Windows.Forms.TextBox T_cTextBox;
        private System.Windows.Forms.Label chamberTemperatureLabel;
        private System.Windows.Forms.TextBox T_inTextBox;
        private System.Windows.Forms.Label inletTemperatureLabel;
        private System.Windows.Forms.Label refreshRateLabel;
        private System.Windows.Forms.TextBox refreshRateTextBox;
        private System.Windows.Forms.Button refreshRateApplyButton;
        private System.Windows.Forms.GroupBox temperatureGroup;
        private System.Windows.Forms.GroupBox pressureGroup;
        private System.Windows.Forms.Button exportCsvButton;
        private System.Windows.Forms.RadioButton LANChannelRadioButton;
        private System.Windows.Forms.RadioButton serialChannelRadioButton;
        private System.Windows.Forms.GroupBox channelGroup;
        private System.Windows.Forms.Button displayChartButton;
        public System.Windows.Forms.Timer getDataRefreshRateTimer;
        public System.Windows.Forms.Button startStopButton;
        public System.Windows.Forms.Button clearDataButton;
        private System.Windows.Forms.Button LANTestButton;
        private System.Windows.Forms.Button openCloseSerialButton;
        public System.Windows.Forms.Timer globalRefreshRateTimer;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.GroupBox valveOverrideControlGroup;
        private System.Windows.Forms.Button closeValveButton;
        private System.Windows.Forms.Button openValveButton;
    }
}

