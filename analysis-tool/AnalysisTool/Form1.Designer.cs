using System;
using System.Windows.Forms;

namespace AnalysisTool
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.Chart chartMonth;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioPopular = new System.Windows.Forms.RadioButton();
            this.radioMonthly = new System.Windows.Forms.RadioButton();
            this.panelPopularTravels = new System.Windows.Forms.Panel();
            this.popularFlightTable = new System.Windows.Forms.DataGridView();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.panelPopularByDate = new System.Windows.Forms.Panel();
            this.tabControlDates = new System.Windows.Forms.TabControl();
            this.Month = new System.Windows.Forms.TabPage();
            this.Week = new System.Windows.Forms.TabPage();
            this.chartWeek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Week_day = new System.Windows.Forms.TabPage();
            this.chartWeekDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dV1454_DataSetAnalysis = new AnalysisTool.DV1454_DataSetAnalysis();
            this.vpopularTravelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_popularTravelsTableAdapter = new AnalysisTool.DV1454_DataSetAnalysisTableAdapters.v_popularTravelsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vtravelersEachMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_travelersEachMonthTableAdapter = new AnalysisTool.DV1454_DataSetAnalysisTableAdapters.v_travelersEachMonthTableAdapter();
            this.vtravelersEachWeekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_travelersEachWeekTableAdapter = new AnalysisTool.DV1454_DataSetAnalysisTableAdapters.v_travelersEachWeekTableAdapter();
            this.vtravelersEachWeekDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_travelersEachWeekDayTableAdapter = new AnalysisTool.DV1454_DataSetAnalysisTableAdapters.v_travelersEachWeekDayTableAdapter();
            chartMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(chartMonth)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panelAbout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelPopularTravels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popularFlightTable)).BeginInit();
            this.tableLayoutMain.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.panelPopularByDate.SuspendLayout();
            this.tabControlDates.SuspendLayout();
            this.Month.SuspendLayout();
            this.Week.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeek)).BeginInit();
            this.Week_day.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeekDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dV1454_DataSetAnalysis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpopularTravelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtravelersEachMonthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtravelersEachWeekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtravelersEachWeekDayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMonth
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            chartMonth.ChartAreas.Add(chartArea1);
            chartMonth.ChartAreas.Add(chartArea2);
            chartMonth.DataSource = this.vtravelersEachMonthBindingSource;
            chartMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            chartMonth.Legends.Add(legend1);
            chartMonth.Location = new System.Drawing.Point(3, 3);
            chartMonth.Name = "chartMonth";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.Name = "Passengers";
            series1.XValueMember = "Date";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValueMembers = "Passengers";
            series2.ChartArea = "ChartArea2";
            series2.Legend = "Legend1";
            series2.Name = "Income";
            series2.XValueMember = "Date";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YValueMembers = "Income";
            chartMonth.Series.Add(series1);
            chartMonth.Series.Add(series2);
            chartMonth.Size = new System.Drawing.Size(556, 311);
            chartMonth.TabIndex = 0;
            chartMonth.Text = "chart1";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sidebar.Controls.Add(this.tableLayoutPanel1);
            this.sidebar.Controls.Add(this.panelAbout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.MaximumSize = new System.Drawing.Size(100, 0);
            this.sidebar.Name = "sidebar";
            this.tableLayoutMain.SetRowSpan(this.sidebar, 2);
            this.sidebar.Size = new System.Drawing.Size(100, 462);
            this.sidebar.TabIndex = 0;
            // 
            // panelAbout
            // 
            this.panelAbout.Controls.Add(this.buttonAbout);
            this.panelAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAbout.Location = new System.Drawing.Point(0, 322);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(100, 140);
            this.panelAbout.TabIndex = 2;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.BackgroundImage = global::AnalysisTool.Resource1.icon;
            this.buttonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.Location = new System.Drawing.Point(0, 0);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(100, 140);
            this.buttonAbout.TabIndex = 1;
            this.buttonAbout.Text = "About";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Visible = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.radioPopular, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioMonthly, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(100, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // radioPopular
            // 
            this.radioPopular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioPopular.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioPopular.AutoSize = true;
            this.radioPopular.BackColor = System.Drawing.SystemColors.HotTrack;
            this.radioPopular.BackgroundImage = global::AnalysisTool.Properties.Resources.popular;
            this.radioPopular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioPopular.Checked = true;
            this.radioPopular.FlatAppearance.BorderSize = 0;
            this.radioPopular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioPopular.Location = new System.Drawing.Point(0, 0);
            this.radioPopular.Margin = new System.Windows.Forms.Padding(0);
            this.radioPopular.Name = "radioPopular";
            this.radioPopular.Size = new System.Drawing.Size(100, 70);
            this.radioPopular.TabIndex = 0;
            this.radioPopular.TabStop = true;
            this.radioPopular.UseVisualStyleBackColor = false;
            this.radioPopular.CheckedChanged += new System.EventHandler(this.radioPopular_CheckedChanged);
            // 
            // radioMonthly
            // 
            this.radioMonthly.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioMonthly.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMonthly.AutoSize = true;
            this.radioMonthly.BackColor = System.Drawing.SystemColors.HotTrack;
            this.radioMonthly.BackgroundImage = global::AnalysisTool.Properties.Resources.calendar;
            this.radioMonthly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioMonthly.FlatAppearance.BorderSize = 0;
            this.radioMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioMonthly.Location = new System.Drawing.Point(0, 69);
            this.radioMonthly.Margin = new System.Windows.Forms.Padding(0);
            this.radioMonthly.Name = "radioMonthly";
            this.radioMonthly.Size = new System.Drawing.Size(100, 70);
            this.radioMonthly.TabIndex = 1;
            this.radioMonthly.UseVisualStyleBackColor = false;
            this.radioMonthly.CheckedChanged += new System.EventHandler(this.radioMonthly_CheckedChanged);
            // 
            // panelPopularTravels
            // 
            this.panelPopularTravels.Controls.Add(this.popularFlightTable);
            this.panelPopularTravels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPopularTravels.Location = new System.Drawing.Point(0, 0);
            this.panelPopularTravels.Margin = new System.Windows.Forms.Padding(0);
            this.panelPopularTravels.Name = "panelPopularTravels";
            this.panelPopularTravels.Size = new System.Drawing.Size(570, 364);
            this.panelPopularTravels.TabIndex = 1;
            // 
            // popularFlightTable
            // 
            this.popularFlightTable.AllowUserToAddRows = false;
            this.popularFlightTable.AllowUserToDeleteRows = false;
            this.popularFlightTable.AllowUserToResizeColumns = false;
            this.popularFlightTable.AllowUserToResizeRows = false;
            this.popularFlightTable.AutoGenerateColumns = false;
            this.popularFlightTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.popularFlightTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.popularFlightTable.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.popularFlightTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.popularFlightTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.popularFlightTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.popularFlightTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popularFlightTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.popularFlightTable.DataSource = this.vpopularTravelsBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.popularFlightTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.popularFlightTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popularFlightTable.EnableHeadersVisualStyles = false;
            this.popularFlightTable.Location = new System.Drawing.Point(0, 0);
            this.popularFlightTable.Margin = new System.Windows.Forms.Padding(0);
            this.popularFlightTable.Name = "popularFlightTable";
            this.popularFlightTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.popularFlightTable.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.popularFlightTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.popularFlightTable.RowTemplate.ReadOnly = true;
            this.popularFlightTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.popularFlightTable.Size = new System.Drawing.Size(570, 364);
            this.popularFlightTable.TabIndex = 0;
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 4;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutMain.Controls.Add(this.sidebar, 0, 0);
            this.tableLayoutMain.Controls.Add(this.panelMainContent, 2, 1);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 2;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Size = new System.Drawing.Size(784, 462);
            this.tableLayoutMain.TabIndex = 1;
            // 
            // panelMainContent
            // 
            this.panelMainContent.Controls.Add(this.panelPopularByDate);
            this.panelMainContent.Controls.Add(this.panelPopularTravels);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(153, 95);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(570, 364);
            this.panelMainContent.TabIndex = 2;
            // 
            // panelPopularByDate
            // 
            this.panelPopularByDate.Controls.Add(this.tabControlDates);
            this.panelPopularByDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPopularByDate.Location = new System.Drawing.Point(0, 0);
            this.panelPopularByDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelPopularByDate.Name = "panelPopularByDate";
            this.panelPopularByDate.Size = new System.Drawing.Size(570, 350);
            this.panelPopularByDate.TabIndex = 1;
            // 
            // tabControlDates
            // 
            this.tabControlDates.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlDates.Controls.Add(this.Month);
            this.tabControlDates.Controls.Add(this.Week);
            this.tabControlDates.Controls.Add(this.Week_day);
            this.tabControlDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDates.Location = new System.Drawing.Point(0, 0);
            this.tabControlDates.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlDates.Name = "tabControlDates";
            this.tabControlDates.Padding = new System.Drawing.Point(10, 5);
            this.tabControlDates.SelectedIndex = 0;
            this.tabControlDates.Size = new System.Drawing.Size(570, 350);
            this.tabControlDates.TabIndex = 0;
            // 
            // Month
            // 
            this.Month.Controls.Add(chartMonth);
            this.Month.Location = new System.Drawing.Point(4, 29);
            this.Month.Name = "Month";
            this.Month.Padding = new System.Windows.Forms.Padding(3);
            this.Month.Size = new System.Drawing.Size(562, 317);
            this.Month.TabIndex = 0;
            this.Month.Text = "Month";
            this.Month.UseVisualStyleBackColor = true;
            // 
            // Week
            // 
            this.Week.Controls.Add(this.chartWeek);
            this.Week.Location = new System.Drawing.Point(4, 29);
            this.Week.Name = "Week";
            this.Week.Padding = new System.Windows.Forms.Padding(3);
            this.Week.Size = new System.Drawing.Size(562, 317);
            this.Week.TabIndex = 1;
            this.Week.Text = "Week";
            this.Week.UseVisualStyleBackColor = true;
            // 
            // chartWeek
            // 
            chartArea3.Name = "ChartArea1";
            chartArea4.Name = "ChartArea2";
            this.chartWeek.ChartAreas.Add(chartArea3);
            this.chartWeek.ChartAreas.Add(chartArea4);
            this.chartWeek.DataSource = this.vtravelersEachWeekBindingSource;
            this.chartWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartWeek.Legends.Add(legend2);
            this.chartWeek.Location = new System.Drawing.Point(3, 3);
            this.chartWeek.Name = "chartWeek";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Passengers";
            series3.XValueMember = "Date";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.YValueMembers = "Passengers";
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series4.ChartArea = "ChartArea2";
            series4.Legend = "Legend1";
            series4.Name = "Income";
            series4.XValueMember = "Date";
            series4.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series4.YValueMembers = "Income";
            this.chartWeek.Series.Add(series3);
            this.chartWeek.Series.Add(series4);
            this.chartWeek.Size = new System.Drawing.Size(556, 311);
            this.chartWeek.TabIndex = 0;
            this.chartWeek.Text = "chart2";
            title1.Name = "Title1";
            this.chartWeek.Titles.Add(title1);
            // 
            // Week_day
            // 
            this.Week_day.Controls.Add(this.chartWeekDay);
            this.Week_day.Location = new System.Drawing.Point(4, 29);
            this.Week_day.Name = "Week_day";
            this.Week_day.Padding = new System.Windows.Forms.Padding(3);
            this.Week_day.Size = new System.Drawing.Size(562, 317);
            this.Week_day.TabIndex = 2;
            this.Week_day.Text = "Week day";
            this.Week_day.UseVisualStyleBackColor = true;
            // 
            // chartWeekDay
            // 
            chartArea5.Name = "ChartArea1";
            chartArea6.Name = "ChartArea2";
            this.chartWeekDay.ChartAreas.Add(chartArea5);
            this.chartWeekDay.ChartAreas.Add(chartArea6);
            this.chartWeekDay.DataSource = this.vtravelersEachWeekDayBindingSource;
            this.chartWeekDay.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartWeekDay.Legends.Add(legend3);
            this.chartWeekDay.Location = new System.Drawing.Point(3, 3);
            this.chartWeekDay.Name = "chartWeekDay";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Passengers";
            series5.XValueMember = "Date";
            series5.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series5.YValueMembers = "Passengers";
            series6.ChartArea = "ChartArea2";
            series6.Legend = "Legend1";
            series6.Name = "Income";
            series6.XValueMember = "Date";
            series6.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series6.YValueMembers = "Income";
            this.chartWeekDay.Series.Add(series5);
            this.chartWeekDay.Series.Add(series6);
            this.chartWeekDay.Size = new System.Drawing.Size(556, 311);
            this.chartWeekDay.TabIndex = 0;
            this.chartWeekDay.Text = "chart3";
            // 
            // dV1454_DataSetAnalysis
            // 
            this.dV1454_DataSetAnalysis.DataSetName = "DV1454_DataSetAnalysis";
            this.dV1454_DataSetAnalysis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vpopularTravelsBindingSource
            // 
            this.vpopularTravelsBindingSource.DataMember = "v_popularTravels";
            this.vpopularTravelsBindingSource.DataSource = this.dV1454_DataSetAnalysis;
            // 
            // v_popularTravelsTableAdapter
            // 
            this.v_popularTravelsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Departure";
            this.dataGridViewTextBoxColumn1.HeaderText = "Departure";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 98;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Destination";
            this.dataGridViewTextBoxColumn2.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 104;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Passengers";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Passengers";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 106;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Revenue";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Revenue";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 95;
            // 
            // vtravelersEachMonthBindingSource
            // 
            this.vtravelersEachMonthBindingSource.DataMember = "v_travelersEachMonth";
            this.vtravelersEachMonthBindingSource.DataSource = this.dV1454_DataSetAnalysis;
            // 
            // v_travelersEachMonthTableAdapter
            // 
            this.v_travelersEachMonthTableAdapter.ClearBeforeFill = true;
            // 
            // vtravelersEachWeekBindingSource
            // 
            this.vtravelersEachWeekBindingSource.DataMember = "v_travelersEachWeek";
            this.vtravelersEachWeekBindingSource.DataSource = this.dV1454_DataSetAnalysis;
            // 
            // v_travelersEachWeekTableAdapter
            // 
            this.v_travelersEachWeekTableAdapter.ClearBeforeFill = true;
            // 
            // vtravelersEachWeekDayBindingSource
            // 
            this.vtravelersEachWeekDayBindingSource.DataMember = "v_travelersEachWeekDay";
            this.vtravelersEachWeekDayBindingSource.DataSource = this.dV1454_DataSetAnalysis;
            // 
            // v_travelersEachWeekDayTableAdapter
            // 
            this.v_travelersEachWeekDayTableAdapter.ClearBeforeFill = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.tableLayoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Analysis Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(chartMonth)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelPopularTravels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popularFlightTable)).EndInit();
            this.tableLayoutMain.ResumeLayout(false);
            this.panelMainContent.ResumeLayout(false);
            this.panelPopularByDate.ResumeLayout(false);
            this.tabControlDates.ResumeLayout(false);
            this.Month.ResumeLayout(false);
            this.Week.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartWeek)).EndInit();
            this.Week_day.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartWeekDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dV1454_DataSetAnalysis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpopularTravelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtravelersEachMonthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtravelersEachWeekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtravelersEachWeekDayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
        

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioPopular;
        private System.Windows.Forms.RadioButton radioMonthly;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Panel panelAbout;
        private Panel panelPopularTravels;
        private DataGridView popularFlightTable;
        private TableLayoutPanel tableLayoutMain;
        private DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passengersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn revenueDataGridViewTextBoxColumn;
        private BindingSource vpopularTravelsBindingSource1;
        private Panel panelPopularByDate;
        private Panel panelMainContent;
        private TabControl tabControlDates;
        private TabPage Month;
        private TabPage Week;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeek;
        private TabPage Week_day;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeekDay;
        private DV1454_DataSetAnalysis dV1454_DataSetAnalysis;
        private BindingSource vpopularTravelsBindingSource;
        private DV1454_DataSetAnalysisTableAdapters.v_popularTravelsTableAdapter v_popularTravelsTableAdapter;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private BindingSource vtravelersEachMonthBindingSource;
        private DV1454_DataSetAnalysisTableAdapters.v_travelersEachMonthTableAdapter v_travelersEachMonthTableAdapter;
        private BindingSource vtravelersEachWeekBindingSource;
        private DV1454_DataSetAnalysisTableAdapters.v_travelersEachWeekTableAdapter v_travelersEachWeekTableAdapter;
        private BindingSource vtravelersEachWeekDayBindingSource;
        private DV1454_DataSetAnalysisTableAdapters.v_travelersEachWeekDayTableAdapter v_travelersEachWeekDayTableAdapter;
    }
}

