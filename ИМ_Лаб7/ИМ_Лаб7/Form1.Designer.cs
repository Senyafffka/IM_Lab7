namespace ИМ_Лаб7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bt_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.el_1 = new System.Windows.Forms.NumericUpDown();
            this.el_2 = new System.Windows.Forms.NumericUpDown();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_profitM = new System.Windows.Forms.Label();
            this.l_profitG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea7.AxisY.LabelStyle.Format = "0";
            chartArea7.AxisY.ScrollBar.Enabled = false;
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(12, 99);
            this.chart1.Name = "chart1";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.LabelFormat = "f4";
            series7.Legend = "Legend1";
            series7.Name = "Темп продаж";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(753, 373);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(771, 12);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(631, 70);
            this.bt_Start.TabIndex = 1;
            this.bt_Start.Text = "Старт";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Средняя цена автомобиля:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Темп продаж:";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // el_1
            // 
            this.el_1.DecimalPlaces = 2;
            this.el_1.Location = new System.Drawing.Point(245, 21);
            this.el_1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.el_1.Name = "el_1";
            this.el_1.Size = new System.Drawing.Size(120, 26);
            this.el_1.TabIndex = 6;
            this.el_1.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // el_2
            // 
            this.el_2.DecimalPlaces = 2;
            this.el_2.Location = new System.Drawing.Point(245, 56);
            this.el_2.Name = "el_2";
            this.el_2.Size = new System.Drawing.Size(120, 26);
            this.el_2.TabIndex = 7;
            this.el_2.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // chart2
            // 
            chartArea8.AxisX.LabelStyle.Format = "0.0";
            chartArea8.AxisY.LabelStyle.Format = "0";
            chartArea8.AxisY.ScrollBar.Enabled = false;
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(12, 478);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series8.Legend = "Legend1";
            series8.Name = "Выручка салона";
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(1390, 373);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // chart3
            // 
            chartArea9.AxisY.LabelStyle.Format = "0";
            chartArea9.AxisY.ScrollBar.Enabled = false;
            chartArea9.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea9);
            legend9.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend9.Name = "Legend1";
            this.chart3.Legends.Add(legend9);
            this.chart3.Location = new System.Drawing.Point(771, 99);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Legend = "Legend1";
            series9.Name = "Средняя цена автомобиля";
            this.chart3.Series.Add(series9);
            this.chart3.Size = new System.Drawing.Size(631, 373);
            this.chart3.TabIndex = 9;
            this.chart3.Text = "chart3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выручка за месяц:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Общая выручка:";
            // 
            // l_profitM
            // 
            this.l_profitM.AutoSize = true;
            this.l_profitM.Location = new System.Drawing.Point(538, 23);
            this.l_profitM.Name = "l_profitM";
            this.l_profitM.Size = new System.Drawing.Size(18, 20);
            this.l_profitM.TabIndex = 12;
            this.l_profitM.Text = "0";
            // 
            // l_profitG
            // 
            this.l_profitG.AutoSize = true;
            this.l_profitG.Location = new System.Drawing.Point(538, 62);
            this.l_profitG.Name = "l_profitG";
            this.l_profitG.Size = new System.Drawing.Size(18, 20);
            this.l_profitG.TabIndex = 13;
            this.l_profitG.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 856);
            this.Controls.Add(this.l_profitG);
            this.Controls.Add(this.l_profitM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.el_2);
            this.Controls.Add(this.el_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Start);
            this.Controls.Add(this.chart1);
            this.MaximumSize = new System.Drawing.Size(1430, 912);
            this.MinimumSize = new System.Drawing.Size(1430, 912);
            this.Name = "Form1";
            this.Text = "Автомобильный салон";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown el_1;
        private System.Windows.Forms.NumericUpDown el_2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label l_profitG;
        private System.Windows.Forms.Label l_profitM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

