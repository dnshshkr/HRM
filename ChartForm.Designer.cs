namespace HRM
{
    partial class RealTimeGraphForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.RealTimeGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RealTimeGraphRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.saveChartImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RealTimeGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // RealTimeGraph
            // 
            chartArea1.Name = "Inlet Temperature";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 25.42299F;
            chartArea1.Position.Width = 45.5F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 6.910346F;
            chartArea2.Name = "Inlet Pressure";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 25.42299F;
            chartArea2.Position.Width = 45.5F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 39.24368F;
            chartArea3.Name = "Thrust";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 25.42299F;
            chartArea3.Position.Width = 45.5F;
            chartArea3.Position.X = 29F;
            chartArea3.Position.Y = 71.577F;
            chartArea4.Name = "Chamber Temperature";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 25.42299F;
            chartArea4.Position.Width = 45.5F;
            chartArea4.Position.X = 51.5F;
            chartArea4.Position.Y = 6.910346F;
            chartArea5.Name = "Chamber Pressure";
            chartArea5.Position.Auto = false;
            chartArea5.Position.Height = 25.42299F;
            chartArea5.Position.Width = 45.5F;
            chartArea5.Position.X = 51.5F;
            chartArea5.Position.Y = 39.24368F;
            this.RealTimeGraph.ChartAreas.Add(chartArea1);
            this.RealTimeGraph.ChartAreas.Add(chartArea2);
            this.RealTimeGraph.ChartAreas.Add(chartArea3);
            this.RealTimeGraph.ChartAreas.Add(chartArea4);
            this.RealTimeGraph.ChartAreas.Add(chartArea5);
            this.RealTimeGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RealTimeGraph.Location = new System.Drawing.Point(0, 0);
            this.RealTimeGraph.Margin = new System.Windows.Forms.Padding(4);
            this.RealTimeGraph.Name = "RealTimeGraph";
            series1.BorderWidth = 2;
            series1.ChartArea = "Inlet Pressure";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LegendText = "Inlet";
            series1.Name = "InletPressureSeries";
            series1.ToolTip = "#VAL{G7}";
            series2.BorderWidth = 2;
            series2.ChartArea = "Chamber Pressure";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.LegendText = "Chamber";
            series2.Name = "ChamberPressureSeries";
            series2.ToolTip = "#VAL{G7}";
            series3.BorderWidth = 2;
            series3.ChartArea = "Inlet Temperature";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.LegendText = "Inlet";
            series3.Name = "InletTemperatureSeries";
            series3.ToolTip = "#VAL{G7}";
            series4.BorderWidth = 2;
            series4.ChartArea = "Chamber Temperature";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Purple;
            series4.LegendText = "Chamber";
            series4.Name = "ChamberTemperatureSeries";
            series4.ToolTip = "#VAL{G7}";
            series5.BorderWidth = 2;
            series5.ChartArea = "Thrust";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series5.IsVisibleInLegend = false;
            series5.LegendText = "Thrust";
            series5.Name = "ThrustSeries";
            series5.ToolTip = "#VAL{G7}";
            this.RealTimeGraph.Series.Add(series1);
            this.RealTimeGraph.Series.Add(series2);
            this.RealTimeGraph.Series.Add(series3);
            this.RealTimeGraph.Series.Add(series4);
            this.RealTimeGraph.Series.Add(series5);
            this.RealTimeGraph.Size = new System.Drawing.Size(1067, 554);
            this.RealTimeGraph.TabIndex = 0;
            this.RealTimeGraph.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.DockedToChartArea = "Inlet Temperature";
            title1.IsDockedInsideChartArea = false;
            title1.Name = "Inet Temperature";
            title1.Text = "Inlet Temperature (°C)";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.DockedToChartArea = "Chamber Temperature";
            title2.IsDockedInsideChartArea = false;
            title2.Name = "Chamber Temperature";
            title2.Text = "Chamber Temperature (°C)";
            title3.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title3.DockedToChartArea = "Inlet Pressure";
            title3.IsDockedInsideChartArea = false;
            title3.Name = "Inlet Pressure";
            title3.Text = "Inlet Pressure (Pa)";
            title4.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title4.DockedToChartArea = "Chamber Pressure";
            title4.IsDockedInsideChartArea = false;
            title4.Name = "Chamber Pressure";
            title4.Text = "Chamber Pressure (Pa)";
            title5.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title5.DockedToChartArea = "Thrust";
            title5.IsDockedInsideChartArea = false;
            title5.Name = "Thrust";
            title5.Text = "Thrust (N)";
            this.RealTimeGraph.Titles.Add(title1);
            this.RealTimeGraph.Titles.Add(title2);
            this.RealTimeGraph.Titles.Add(title3);
            this.RealTimeGraph.Titles.Add(title4);
            this.RealTimeGraph.Titles.Add(title5);
            // 
            // RealTimeGraphRefreshTimer
            // 
            this.RealTimeGraphRefreshTimer.Tick += new System.EventHandler(this.RealTimeGraphRefreshTimer_Tick);
            // 
            // saveChartImageButton
            // 
            this.saveChartImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveChartImageButton.BackgroundImage = global::HRM.Properties.Resources.save_icon_256;
            this.saveChartImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveChartImageButton.Location = new System.Drawing.Point(1010, 497);
            this.saveChartImageButton.Name = "saveChartImageButton";
            this.saveChartImageButton.Size = new System.Drawing.Size(45, 45);
            this.saveChartImageButton.TabIndex = 1;
            this.saveChartImageButton.UseVisualStyleBackColor = true;
            this.saveChartImageButton.Click += new System.EventHandler(this.saveChartImageButton_Click);
            // 
            // RealTimeGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.saveChartImageButton);
            this.Controls.Add(this.RealTimeGraph);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RealTimeGraphForm";
            this.Text = "Monitor";
            this.Leave += new System.EventHandler(this.RealTimeGraphForm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.RealTimeGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataVisualization.Charting.Chart RealTimeGraph;
        public System.Windows.Forms.Timer RealTimeGraphRefreshTimer;
        private System.Windows.Forms.Button saveChartImageButton;
    }
}