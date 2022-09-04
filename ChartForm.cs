using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HRM
{
    public partial class RealTimeGraphForm : Form
    {
        Random random = new Random();
        /*public RealTimeGraphForm()
        {
            InitializeComponent();
            List<double> T_in = form.T_inToChart();
            List<double> T_c = form.T_cToChart();
            List<double> P_in = form.P_inToChart();
            List<double> P_c = form.P_cToChart();
            List<double> F = form.FToChart();
            for (int i = 0; i <= 10; i++)
            {
                RealTimeGraph.Series["Inlet"].Points.AddY(random.NextDouble());
                RealTimeGraph.Series["Chamber"].Points.AddY(random.NextDouble());
            }
            //timer = Program.MainForm.getDataRefreshRate; //uncomment this
            //timer.Tick += timer1_Tick; //and this
            if (Program.MainForm.sensors.PressureTransmitter1List.Count > 0)
            {
                Parallel.ForEach(Program.MainForm.sensors.PressureTransmitter1List, data => RealTimeGraph.Series["InletPressureSeries"].Points.AddY(data));
                Parallel.ForEach(Program.MainForm.sensors.PressureTransmitter2List, data => RealTimeGraph.Series["ChamberPressureSeries"].Points.AddY(data));
                Parallel.ForEach(Program.MainForm.sensors.Thermocouple1List, data => RealTimeGraph.Series["InletTemperatureSeries"].Points.AddY(data));
                Parallel.ForEach(Program.MainForm.sensors.Thermocouple2List, data => RealTimeGraph.Series["ChamberTemperatureSeries"].Points.AddY(data));
                Parallel.ForEach(Program.MainForm.sensors.LoadCellList, data => RealTimeGraph.Series["ThrustSeries"].Points.AddY(data));
            }
        }*/

        public RealTimeGraphForm()
        {
            //form = callingForm as HRM;
            InitializeComponent();
            //timer = Program.MainForm;
            //timer.Interval = Program.MainForm.getDataRefreshRate.Interval / 2;
            //timer.Tick+=timer1_Tick;
            //timer.Start();
            //this.RealTimeGraphRefreshTimer = timer;

            Program.MainForm.startStopButton.Click += StartStopButton_Click;
            if (Program.MainForm.sensors.PressureTransmitter1List.Count > 0)
            {
                /*Parallel.ForEach(Program.MainForm.sensors.PressureTransmitter1List, data => RealTimeGraph.Series["InletPressureSeries"].Points.AddY(data));
                Parallel.ForEach(Program.MainForm.sensors.PressureTransmitter2List, data => RealTimeGraph.Series["ChamberPressureSeries"].Points.AddY(data));
                Parallel.ForEach(Program.MainForm.sensors.Thermocouple1List, data => RealTimeGraph.Series["InletTemperatureSeries"].Points.AddY(data));
                Parallel.ForEach(Program.MainForm.sensors.Thermocouple2List, data => RealTimeGraph.Series["ChamberTemperatureSeries"].Points.AddY(data));
                Parallel.ForEach(Program.MainForm.sensors.LoadCellList, data => RealTimeGraph.Series["ThrustSeries"].Points.AddY(data));*/
                foreach (double data in Program.MainForm.sensors.PressureTransmitter1List)
                    RealTimeGraph.Series["InletPressureSeries"].Points.AddY(data);
                foreach (double data in Program.MainForm.sensors.PressureTransmitter2List)
                    RealTimeGraph.Series["ChamberPressureSeries"].Points.AddY(data);
                foreach (double data in Program.MainForm.sensors.Thermocouple1List)
                    RealTimeGraph.Series["InletTemperatureSeries"].Points.AddY(data);
                foreach (double data in Program.MainForm.sensors.Thermocouple2List)
                    RealTimeGraph.Series["ChamberTemperatureSeries"].Points.AddY(data);
                foreach (double data in Program.MainForm.sensors.LoadCellList)
                    RealTimeGraph.Series["ThrustSeries"].Points.AddY(data);
            }
            Program.MainForm.getDataRefreshRateTimer.Tick += RealTimeGraphRefreshTimer_Tick;
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (!Program.MainForm.startStopButtonState)
            {
                if (!this.IsDisposed)
                {
                    RealTimeGraph.Series["InletTemperatureSeries"].Points.AddY(Program.MainForm.sensorVals.T_in);
                    RealTimeGraph.Series["ChamberTemperatureSeries"].Points.AddY(Program.MainForm.sensorVals.T_c);
                    RealTimeGraph.Series["InletPressureSeries"].Points.AddY(Program.MainForm.sensorVals.P_in);
                    RealTimeGraph.Series["ChamberPressureSeries"].Points.AddY(Program.MainForm.sensorVals.P_c);
                    RealTimeGraph.Series["ThrustSeries"].Points.AddY(Program.MainForm.sensorVals.F);
                }
            }
            //throw new NotImplementedException();
        }

        private void RealTimeGraphForm_Leave(object sender, EventArgs e)
        {
            RealTimeGraph.Dispose();
        }

        private void RealTimeGraphRefreshTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsDisposed)
                {
                    RealTimeGraph.Series["InletTemperatureSeries"].Points.AddY(Program.MainForm.sensorVals.T_in);
                    RealTimeGraph.Series["ChamberTemperatureSeries"].Points.AddY(Program.MainForm.sensorVals.T_c);
                    RealTimeGraph.Series["InletPressureSeries"].Points.AddY(Program.MainForm.sensorVals.P_in);
                    RealTimeGraph.Series["ChamberPressureSeries"].Points.AddY(Program.MainForm.sensorVals.P_c);
                    RealTimeGraph.Series["ThrustSeries"].Points.AddY(Program.MainForm.sensorVals.F);
                }
            }
            catch { }
        }

        private void saveChartImageButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =  "Bitmap (*.bmp) | *.bmp | Joint Photographic Experts Group (*.jpeg) | *.jpeg | Portable Network Graphics (*.png) | *.png | Tag Image File Format (*.tiff) | *.tiff";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                switch(saveFileDialog.FilterIndex)
                {
                    case 1:
                    {
                        RealTimeGraph.SaveImage(filePath, ChartImageFormat.Bmp);
                        break;
                    }
                    case 2:
                    {
                        RealTimeGraph.SaveImage(filePath, ChartImageFormat.Jpeg);
                        break;
                    }
                    case 3:
                    {
                        RealTimeGraph.SaveImage(filePath, ChartImageFormat.Png);
                        break;
                    }
                    case 4:
                    {
                        RealTimeGraph.SaveImage(filePath, ChartImageFormat.Tiff);
                        break;
                    }
                }
            }
        }
    }
}
