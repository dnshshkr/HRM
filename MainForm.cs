using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM
{
    public partial class HRM : Form
    {
        [Serializable]
        public class SensorValues
        {
            public double T_in { get; set; }
            public double T_c { get; set; }
            public double P_in { get; set; }
            public double P_c { get; set; }
            public double F { get; set; }
        }
        public class Sensors
        {
            public List<double> PressureTransmitter1List { get; set; }
            public List<double> PressureTransmitter2List { get; set; }
            public List<double> Thermocouple1List { get; set; }
            public List<double> Thermocouple2List { get; set; }
            public List<double> LoadCellList { get; set; }
            public bool PressureTransmitter1_Enabled { get; set; }
            public bool PressureTransmitter2_Enabled { get; set; }
            public bool Thermocouple1_Enabled { get; set; }
            public bool Thermocouple2_Enabled { get; set; }
            public bool LoadCell_Enabled { get; set; }
            public void UpdateSensorList(double T_in, double T_c, double P_in, double P_c, double F)
            {
                PressureTransmitter1List.Add(P_in);
                PressureTransmitter2List.Add(P_c);
                Thermocouple1List.Add(T_in);
                Thermocouple2List.Add(T_c);
                LoadCellList.Add(F);
            }
            public Sensors(bool pressureTransmitter1_Enabled = false, bool pressureTransmitter2_Enabled = false, bool thermocouple1_Enabled = false, bool thermocouple2_Enabled = false, bool loadCell_Enabled = false)
            {
                PressureTransmitter1_Enabled = pressureTransmitter1_Enabled;
                PressureTransmitter2_Enabled = pressureTransmitter2_Enabled;
                Thermocouple1_Enabled = thermocouple1_Enabled;
                Thermocouple2_Enabled = thermocouple2_Enabled;
                LoadCell_Enabled = loadCell_Enabled;
                PressureTransmitter1List = new List<double>();
                PressureTransmitter2List = new List<double>();
                Thermocouple1List = new List<double>();
                Thermocouple2List = new List<double>();
                LoadCellList = new List<double>();
            }
            public void GetSensorState()
            {
                Console.WriteLine(PressureTransmitter1_Enabled);
                Console.WriteLine(PressureTransmitter2_Enabled);
                Console.WriteLine(Thermocouple1_Enabled);
                Console.WriteLine(Thermocouple2_Enabled);
                Console.WriteLine(LoadCell_Enabled);
            }
            public void UpdateSensorState(ref SerialPort serial, ref CheckedListBox SensorControl, ref string PreviousJsonContent)
            {
                PressureTransmitter1_Enabled = SensorControl.GetItemChecked(0);
                PressureTransmitter2_Enabled = SensorControl.GetItemChecked(1);
                Thermocouple1_Enabled = SensorControl.GetItemChecked(2);
                Thermocouple2_Enabled = SensorControl.GetItemChecked(3);
                LoadCell_Enabled = SensorControl.GetItemChecked(4);
                //this.GetSensorState();
                string SensorStates = JsonSerializer.Serialize(this);
                //File.WriteAllText("sensorsState.json", SensorStates);
                //Console.WriteLine($"Previous Json: {previousSensorStates}");
                //Console.WriteLine($"Current Json: {SensorStates}");
                if (SensorStates != PreviousJsonContent)
                {
                    serial.Write(SensorStates);
                    PreviousJsonContent = SensorStates;
                    Console.WriteLine(SensorStates);
                }
            }
        }
        
        //SerialPort serial = new SerialPort();
        public static RealTimeGraphForm realTimeGraph;
        public Sensors sensors = new Sensors();
        public SensorValues sensorVals = null;
        List<string> data = new List<string>();
        IPAddress localAddress = null;
        string[] currentPortNames = null, previousPortNames = null;
        string previousSensorStates, defaultIPAddress = "192.168.4.1", defaultBaudRate = "115200";
        public bool startStopButtonState = false, LANConnected = false, toggleApplyButton = false;
        static readonly HttpClient httpClient = new HttpClient();
        //[ThreadStatic]
        public static bool testConnection, valveStatusSerial;
        public HRM()
        {
            InitializeComponent();
            globalRefreshRateTimer.Start();
            previousPortNames = SerialPort.GetPortNames();
            Array.Sort(previousPortNames);
            UpdatePortList(previousPortNames);
            baudRateList.Items.AddRange(new[] { "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200", "128000", "256000" });
            //serial.DataReceived += new SerialDataReceivedEventHandler(UpdateConsole);
            ConsoleBox.WordWrap = false;
            ConsoleBox.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            //SensorControl.Items.AddRange(new[] { "Pressure transmitter (inlet)", "Pressure transmitter (chamber)", "Thermocouple (inlet)", "Thermocouple (chamber)", "Load cell" });
            previousSensorStates = JsonSerializer.Serialize(sensors);
            //SensorControl.Enabled = false;
            startStopButton.Enabled = false;
            loadCellTareButton.Enabled = false;
            //enableAllButton.Enabled = false;
            //disableAllButton.Enabled = false;
            serialChannelRadioButton.Checked = true;
            consoleInputTextBox.Enabled = false;
            sendButton.Enabled = false;
            LANTestButton.Enabled = false;
            exportCsvButton.Enabled = false;
            valveOverrideControlGroup.Enabled = false;
            //AutoScrollCheckBox.Checked = true;
        }
        private void globalRefreshRateTimer_Tick(object sender, EventArgs e)
        {
            currentPortNames = SerialPort.GetPortNames();
            Array.Sort(currentPortNames);
            if (!currentPortNames.SequenceEqual(previousPortNames))
                UpdatePortList(currentPortNames);
            /*if (ConsoleBox.Focused)
                autoScrollCheckBox.Checked = true;
            else
                autoScrollCheckBox.Checked = false;*/
            /*if ((LANChannelRadioButton.Checked && toggleApplyButton) || (serialChannelRadioButton.Checked && serial.IsOpen))
            {
                startStopButton.Enabled = true;
                loadCellTareButton.Enabled = true;
            }
            else
            {
                startStopButton.Enabled = false;
                loadCellTareButton.Enabled = false;
            }*/
            if (portNameList.Text.Length > 0 && baudRateList.Text.Length > 0 && serialChannelRadioButton.Checked)
                openCloseSerialButton.Enabled = true;
            else
                openCloseSerialButton.Enabled = false;
            if (sensors.LoadCellList.Count >= 1 && startStopButton.Text == "Start")
                exportCsvButton.Enabled = true;
            else
                exportCsvButton.Enabled = false;
            if (sensors.LoadCellList.Count >= 1 && startStopButton.Text == "Start")
                exportCsvButton.Enabled = true;
            else
                exportCsvButton.Enabled = false;
            if (sensors.PressureTransmitter1List.Count > 0)
                displayChartButton.Enabled = true;
            else
                displayChartButton.Enabled = false;
            if (ConsoleBox.Focused)
                autoScrollCheckBox.Checked = true;
            //Console.WriteLine(valveState);
            /*if (AutoScrollCheckBox.Checked)
                ConsoleBox.Focus();*/
        }

        private void UpdatePortList(string[] PortNames)
        {
            portNameList.Items.Clear();
            foreach (string PortName in PortNames)
                portNameList.Items.Add(PortName);
            previousPortNames = PortNames;
            portNameList.Update();
        }

        private void portList_SelectedValueChanged(object sender, EventArgs e)
        {
            baudRateList.Text = defaultBaudRate;
            //Console.WriteLine(PortList.SelectedText);
            if (serial.IsOpen)
                serial.Close();
            try
            {
                serial.PortName = portNameList.Text;
                Console.WriteLine(serial.PortName);
            }
            catch { }
            //PortAndBaudCheck();
        }

        private void baudRateList_SelectedValueChanged(object sender, EventArgs e)
        {
            serial.BaudRate = Int32.Parse(baudRateList.Text);
            //PortAndBaudCheck();
            Console.WriteLine(serial.BaudRate.ToString());
        }

        private void UpdateConsole(object sender, SerialDataReceivedEventArgs e)
        {
            //SerialPort serial = (SerialPort)sender;
            ConsoleBox.BeginInvoke(new Action(() => ConsoleBox.AppendText(serial.ReadLine())));
        }

        private void autoScrollCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void HRM_Resize(object sender, EventArgs e)
        {
            //Console.WriteLine(this.Bounds);
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            startStopButtonState = !startStopButtonState;
            if (startStopButtonState)
            {
                /*if (LANChannelRadioButton.Checked)
                    LANConnected = true;*/
                if (LANConnected)
                {
                    OpenValve();
                    /*Task openValveTask = Task.Run(() => OpenValve());
                    openValveTask.Wait();*/
                }
                else if (serial.IsOpen)
                    serial.Write("open valve\r\n");
                //Thread.Sleep(1000);
                if (serial.IsOpen || LANConnected)
                    getDataRefreshRateTimer.Start();
                startStopButton.Text = "Stop";
                refreshRateTextBox.Text = getDataRefreshRateTimer.Interval.ToString();
            }
            else
            {
                getDataRefreshRateTimer.Stop();
                if (LANConnected)
                {
                    CloseValve();
                    /*Task closeValveTask = Task.Run(() => CloseValve());
                    closeValveTask.Wait();*/
                }
                else if (serial.IsOpen)
                    serial.Write("close valve\r\n");
                /*if (LANChannelRadioButton.Checked && LANConnected)
                    LANConnected = false;*/
                startStopButton.Text = "Start";
                refreshRateTextBox.Text = string.Empty;
            }
        }

        private void sensorControl_SelectedValueChanged(object sender, EventArgs e)
        {
            //sensors.UpdateSensorState(ref serial, ref SensorControl, ref previousSensorStates);
            /*sensors.PressureTransmitter1_Enabled = SensorControl.GetItemChecked(0);
            sensors.PressureTransmitter2_Enabled = SensorControl.GetItemChecked(1);
            sensors.Thermocouple1_Enabled = SensorControl.GetItemChecked(2);
            sensors.Thermocouple2_Enabled = SensorControl.GetItemChecked(3);
            sensors.LoadCell_Enabled = SensorControl.GetItemChecked(4);
            //sensors.GetSensorState();
            string SensorStates = JsonSerializer.Serialize(sensors);
            //File.WriteAllText("sensorsState.json", SensorStates);
            if (SensorStates != previousSensorStates)
            {
                serial.Write(SensorStates);
                previousSensorStates = SensorStates;
                Console.WriteLine(SensorStates);
            }*/
        }

        private void loadCellTareButton_Click(object sender, EventArgs e)
        {
            if (serial.IsOpen)
                serial.Write("tare\r\n");
            else if (LANConnected)
                TareLoadCell();
        }
        private void AutoScrollCheck()
        {
            if (autoScrollCheckBox.Checked)
            {
                ConsoleBox.BeginInvoke(new Action(() =>
                {
                    ConsoleBox.SelectionStart = ConsoleBox.Text.Length;
                    ConsoleBox.SelectionLength = 0;
                    ConsoleBox.ScrollToCaret();
                }));
            }
        }

        private void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //SerialPort serial = (SerialPort)sender;
            string text = serial.ReadLine();
            ConsoleBox.BeginInvoke(new Action(() => ConsoleBox.AppendText(text)));
            AutoScrollCheck();
            if (text[0] == '{')
            {
                try
                {
                    sensorVals = JsonSerializer.Deserialize<SensorValues>(text);
                    sensors.UpdateSensorList(sensorVals.T_in, sensorVals.T_c, sensorVals.P_in, sensorVals.P_c, sensorVals.F);
                    T_inTextBox.BeginInvoke(new Action(() => T_inTextBox.Text = sensorVals.T_in.ToString()));
                    T_cTextBox.BeginInvoke(new Action(() => T_cTextBox.Text = sensorVals.T_c.ToString()));
                    P_inTextBox.BeginInvoke(new Action(() => P_inTextBox.Text = sensorVals.P_in.ToString()));
                    P_cTextBox.BeginInvoke(new Action(() => P_cTextBox.Text = sensorVals.P_c.ToString()));
                    FTextBox.BeginInvoke(new Action(() => FTextBox.Text = sensorVals.F.ToString()));
                }
                catch
                {
                    return;
                }
            }
            //ConsoleBox.AppendText(serial.ReadExisting());
            //Console.WriteLine(text.TrimEnd());
        }

        /*private void enableAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SensorControl.Items.Count; i++)
                SensorControl.SetItemChecked(i, true);
            sensors.UpdateSensorState(ref serial, ref SensorControl, ref previousSensorStates);
        }*/

        /*private void disableAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SensorControl.Items.Count; i++)
                SensorControl.SetItemChecked(i, false);
            sensors.UpdateSensorState(ref serial, ref SensorControl, ref previousSensorStates);
        }*/

        private void IPAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            IPAddress tempIP;
            if (IPAddress.TryParse(IPAddressTextBox.Text, out tempIP))
                IPAddressApplyButton.Enabled = true;
            else
                IPAddressApplyButton.Enabled = false;
        }

        private void refreshRateApplyButton_Click(object sender, EventArgs e)
        {
            getDataRefreshRateTimer.Interval = Int32.Parse(refreshRateTextBox.Text);
        }

        private void exportCsvButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Comma-separated values (*.csv) | *.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string header = "T_in,T_c,P_in,P_c,F", filePath = saveFileDialog.FileName;
                //Console.WriteLine(filePath);
                using (StreamWriter file = new StreamWriter(filePath, true))
                {
                    file.WriteLine(header);
                    for (int i = 0; i < sensors.LoadCellList.Count; i++)
                        file.WriteLine(sensors.Thermocouple1List[i] + "," + sensors.Thermocouple2List[i] + "," + sensors.PressureTransmitter1List[i] + "," + sensors.PressureTransmitter2List[i] + "," + sensors.LoadCellList[i]);
                }
            }
            /*csvExport csv = new csvExport();
            csv.ShowDialog();*/
        }

        private void serialChannel_CheckedChanged(object sender, EventArgs e)
        {
            portNameList.Enabled = true;
            baudRateList.Enabled = true;
            IPAddressTextBox.Enabled = false;
            openCloseSerialButton.Enabled = true;
            if (serialChannelRadioButton.Checked && IPAddressApplyButton.Text == "Disconnect")
            {
                IPAddressApplyButton.Enabled = true;
                IPAddressApplyButton.PerformClick();
                IPAddressApplyButton.Enabled = false;
            }
            else
                IPAddressApplyButton.Enabled = false;
        }

        private void LANChannel_CheckedChanged(object sender, EventArgs e)
        {
            IPAddressTextBox.Enabled = true;
            IPAddressApplyButton.Enabled = true;
            portNameList.Enabled = false;
            baudRateList.Enabled = false;
            openCloseSerialButton.Enabled = false;
            if (LANChannelRadioButton.Checked)
                IPAddressTextBox.Text = defaultIPAddress;
            else
                IPAddressTextBox.Text = string.Empty;
        }

        public void getDataRefreshRateTimer_Tick(object sender, EventArgs e)
        {
            if (LANConnected)
                GetReadings();
            else if (serial.IsOpen)
                serial.Write("read sensors\r\n");
        }

        private void displayChartButton_Click(object sender, EventArgs e)
        {
            realTimeGraph = new RealTimeGraphForm();
            realTimeGraph.Show();
        }

        private void IPAddressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                IPAddressApplyButton.PerformClick();
        }

        private void refreshRateBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                refreshRateApplyButton.PerformClick();
        }

        private void LANTestButton_Click(object sender, EventArgs e)
        {
            TestConnection();
        }

        private void openCloseSerialButton_Click(object sender, EventArgs e)
        {
            if (serialChannelRadioButton.Checked && openCloseSerialButton.Text == "Open")
            {
                try
                {
                    serial.Open();
                    Console.WriteLine("Port opened");
                }
                catch
                {
                    Console.WriteLine("Error communicating with port");
                    return;
                }
                finally
                {
                    openCloseSerialButton.Text = "Close";
                    portNameList.Enabled = false;
                    baudRateList.Enabled = false;
                    channelGroup.Enabled = false;
                    /*startStopButton.Enabled = true;
                    loadCellTareButton.Enabled = true;*/
                    new Thread(() =>
                    {
                        Thread.Sleep(1000);
                        startStopButton.BeginInvoke(new Action(() => startStopButton.Enabled = true));
                        valveOverrideControlGroup.BeginInvoke(new Action(() => valveOverrideControlGroup.Enabled = true));
                        loadCellTareButton.BeginInvoke(new Action(() => loadCellTareButton.Enabled = true));
                    }).Start();
                }
            }
            else if (serialChannelRadioButton.Checked && openCloseSerialButton.Text == "Close")
            {
                getDataRefreshRateTimer.Stop();
                /*if (LANConnected)
                    CloseValve();
                else if (serial.IsOpen)
                    serial.Write("close valve\r\n");
                getDataRefreshRateTimer.Stop();*/
                //startStopButton.PerformClick();
                serial.Write("close valve\r\n");
                startStopButton.Enabled = false;
                valveOverrideControlGroup.Enabled = false;
                loadCellTareButton.Enabled = false;
                serial.Close();
                openCloseSerialButton.Text = "Open";
                portNameList.Enabled = true;
                baudRateList.Enabled = true;
                channelGroup.Enabled = true;
                startStopButton.Text = "Start";
                refreshRateTextBox.Text = string.Empty;
            }
        }

        private void HRM_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clearDataButton_Click(object sender, EventArgs e)
        {
            ConsoleBox.Clear();
            sensors.PressureTransmitter1List.Clear();
            sensors.PressureTransmitter2List.Clear();
            sensors.Thermocouple1List.Clear();
            sensors.Thermocouple2List.Clear();
            sensors.LoadCellList.Clear();
            if (realTimeGraph != null)
                realTimeGraph.Dispose();
        }

        private async void IPAddressApplyButton_Click(object sender, EventArgs e)
        {
            toggleApplyButton = !toggleApplyButton;
            if (toggleApplyButton)
            {
                try
                {
                    localAddress = IPAddress.Parse(IPAddressTextBox.Text);
                    Task task = Task.Run(() =>
                    {
                        TestConnection();
                    });
                    Thread.Sleep(500);
                    /*TimeSpan timeSpan = TimeSpan.FromSeconds(5);
                    if (!task.Wait(timeSpan))
                    {
                        new Thread(() =>
                        {
                            LANStatusLabel.BeginInvoke(new Action(() => LANStatusLabel.Text = "Error"));
                            Thread.Sleep(1000);
                            LANStatusLabel.BeginInvoke(new Action(() => LANStatusLabel.Text = string.Empty));
                        }).Start();
                    }*/
                    //task.Wait();
                    /*IPAddressApplyButton.Enabled = false;
                    refreshRateApplyButton.Enabled = false;
                    channelGroup.Enabled = false;*/
                    //TestConnection();
                    Console.WriteLine(testConnection);
                    if (testConnection)
                    {
                        startStopButton.Enabled = false;
                        loadCellTareButton.Enabled = false;
                        LANConnected = true;
                        IPAddressApplyButton.Text = "Disconnect";
                        LANTestButton.Enabled = true;
                        IPAddressTextBox.ReadOnly = true;
                        channelGroup.Enabled = false;
                        valveOverrideControlGroup.Enabled = true;
                        new Thread(() =>
                        {
                            //Thread.Sleep(2000);
                            startStopButton.BeginInvoke(new Action(() => startStopButton.Enabled = true));
                            loadCellTareButton.BeginInvoke(new Action(() => loadCellTareButton.Enabled = true));
                        }).Start();
                    }
                    else
                        throw new Exception();
                }
                catch
                {
                    new Thread(() =>
                    {
                        LANStatusLabel.BeginInvoke(new Action(() => LANStatusLabel.Text = "Error"));
                        Thread.Sleep(1000);
                        LANStatusLabel.BeginInvoke(new Action(() => LANStatusLabel.Text = ""));
                    }).Start();
                    IPAddressApplyButton.PerformClick();
                }
            }
            else
            {
                //bool valveStatus = await CheckValveStatus();
                CloseValve();
                //startStopButton.PerformClick();
                getDataRefreshRateTimer.Stop();
                LANConnected = false;
                IPAddressApplyButton.Text = "Apply";
                startStopButton.Enabled = false;
                loadCellTareButton.Enabled = false;
                LANTestButton.Enabled = false;
                IPAddressTextBox.ReadOnly = false;
                channelGroup.Enabled = true;
                valveOverrideControlGroup.Enabled = false;
                if (startStopButtonState)
                {
                    globalRefreshRateTimer.Stop();
                    startStopButton.Enabled = true;
                    startStopButton.PerformClick();
                    startStopButton.Enabled = false;
                }
                startStopButton.Text = "Start";
                refreshRateTextBox.Text = string.Empty;
            }
        }
        private async Task TestConnection()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("http://" + localAddress.ToString());
                //response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
                new Thread(() =>
                {
                    LANStatusLabel.BeginInvoke(new Action(() => LANStatusLabel.Text = responseBody));
                    Thread.Sleep(1000);
                    LANStatusLabel.BeginInvoke(new Action(() => LANStatusLabel.Text = ""));
                }).Start();
                testConnection = true;
                Console.WriteLine(testConnection);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                testConnection = false;
            }
        }

        private void openValveButton_Click(object sender, EventArgs e)
        {
            if (LANConnected)
                OpenValve();
            else if (serial.IsOpen)
                serial.Write("open valve\r\n");
        }

        private void closeValveButton_Click(object sender, EventArgs e)
        {
            if (LANConnected)
                CloseValve();
            else if (serial.IsOpen)
                serial.Write("close valve\r\n");
        }

        private void IPAddressTextBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(IPAddressTextBox, "Default is 192.168.4.1");
        }

        private async Task OpenValve()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("http://" + localAddress.ToString() + "/openValve");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                ConsoleBox.AppendText(responseBody + "\n");
                AutoScrollCheck();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
        private async Task CloseValve()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("http://" + localAddress.ToString() + "/closeValve");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                ConsoleBox.AppendText(responseBody + "\n");
                AutoScrollCheck();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
        private async Task<bool> CheckValveStatus()
        {
            string responseBody = string.Empty;
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("http://" + localAddress.ToString() + "/valveStatus");
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
                ConsoleBox.AppendText(responseBody + "\n");
                AutoScrollCheck();
                
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            if (responseBody == "open")
                return true;
            else if (responseBody == "close")
                return false;
            return false;
        }
        private async Task TareLoadCell()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("http://" + localAddress.ToString() + "/tare");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                ConsoleBox.AppendText(responseBody + "\n");
                AutoScrollCheck();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
        private async Task GetReadings()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("http://" + localAddress.ToString() + "/getReadings");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                ConsoleBox.BeginInvoke(new Action(() => ConsoleBox.AppendText(responseBody + "\n")));
                AutoScrollCheck();
                sensorVals = JsonSerializer.Deserialize<SensorValues>(responseBody);
                sensors.UpdateSensorList(sensorVals.T_in, sensorVals.T_c, sensorVals.P_in, sensorVals.P_c, sensorVals.F);
                T_inTextBox.BeginInvoke(new Action(() => T_inTextBox.Text = sensorVals.T_in.ToString()));
                T_cTextBox.BeginInvoke(new Action(() => T_cTextBox.Text = sensorVals.T_c.ToString()));
                P_inTextBox.BeginInvoke(new Action(() => P_inTextBox.Text = sensorVals.P_in.ToString()));
                P_cTextBox.BeginInvoke(new Action(() => P_cTextBox.Text = sensorVals.P_c.ToString()));
                FTextBox.BeginInvoke(new Action(() => FTextBox.Text = sensorVals.F.ToString()));
                //Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
        /*private void PortAndBaudCheck()
        {
            if (portNameList.Text.Length != 0 && baudRateList.Text.Length != 0)
            {
                if (!serial.IsOpen)
                {
                    try
                    {
                        serial.Open();
                        if (serial.IsOpen)
                        {
                            SensorControl.Enabled = true;
                            enableAllButton.Enabled = true;
                            disableAllButton.Enabled = true;
                        }
                        else
                        {
                            SensorControl.Enabled = false;
                            enableAllButton.Enabled = false;
                            disableAllButton.Enabled = false;
                        }
                    }
                    catch { }
                }
            }
            else
                serial.Close();
        }*/
    }
}
