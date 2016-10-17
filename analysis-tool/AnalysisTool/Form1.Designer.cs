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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Chart chartMonth;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelPopularTravels = new System.Windows.Forms.Panel();
            this.popularFlightTable = new System.Windows.Forms.DataGridView();
            this.popularFlightTableColumnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popularFlightTableColumnDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popularFlightTableColumnPassengers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popularFlightTableColumnRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vpopularTravelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dV1454_AirPortDataSet = new AnalysisTool.DV1454_AirPortDataSet();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.v_popularTravelsTableAdapter = new AnalysisTool.DV1454_AirPortDataSetTableAdapters.v_popularTravelsTableAdapter();
            this.panelPopularByDate = new System.Windows.Forms.Panel();
            this.Week_day = new System.Windows.Forms.TabPage();
            this.chartWeekDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Week = new System.Windows.Forms.TabPage();
            this.chartWeek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Month = new System.Windows.Forms.TabPage();
            this.tabControlDates = new System.Windows.Forms.TabControl();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.dV1454_AirPortDataSet1 = new AnalysisTool.DV1454_AirPortDataSet1();
            this.vtravelersEachMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_travelersEachMonthTableAdapter = new AnalysisTool.DV1454_AirPortDataSet1TableAdapters.v_travelersEachMonthTableAdapter();
            this.dV1454_AirPortDataSet2 = new AnalysisTool.DV1454_AirPortDataSet2();
            this.vtravelersEachWeekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_travelersEachWeekTableAdapter = new AnalysisTool.DV1454_AirPortDataSet2TableAdapters.v_travelersEachWeekTableAdapter();
            this.dV1454_AirPortDataSet3 = new AnalysisTool.DV1454_AirPortDataSet3();
            this.vtravelersEachWeekDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_travelersEachWeekDayTableAdapter = new AnalysisTool.DV1454_AirPortDataSet3TableAdapters.v_travelersEachWeekDayTableAdapter();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.radioPopular = new System.Windows.Forms.RadioButton();
            this.radioMonthly = new System.Windows.Forms.RadioButton();
            chartMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sidebar.SuspendLayout();
            this.panelAbout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelPopularTravels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popularFlightTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpopularTravelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dV1454_AirPortDataSet)).BeginInit();
            this.tableLayoutMain.SuspendLayout();
            this.panelPopularByDate.SuspendLayout();
            this.Week_day.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeekDay)).BeginInit();
            this.Week.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeek)).BeginInit();
            this.Month.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(chartMonth)).BeginInit();
            this.tabControlDates.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dV1454_AirPortDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtravelersEachMonthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dV1454_AirPortDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtravelersEachWeekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dV1454_AirPortDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtravelersEachWeekDayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sidebar.Controls.Add(this.panelAbout);
            this.sidebar.Controls.Add(this.tableLayoutPanel1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(100, 138);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.popularFlightTableColumnDeparture,
            this.popularFlightTableColumnDestination,
            this.popularFlightTableColumnPassengers,
            this.popularFlightTableColumnRevenue});
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
            // popularFlightTableColumnDeparture
            // 
            this.popularFlightTableColumnDeparture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.popularFlightTableColumnDeparture.DataPropertyName = "Departure";
            this.popularFlightTableColumnDeparture.HeaderText = "Departure";
            this.popularFlightTableColumnDeparture.Name = "popularFlightTableColumnDeparture";
            this.popularFlightTableColumnDeparture.Width = 98;
            // 
            // popularFlightTableColumnDestination
            // 
            this.popularFlightTableColumnDestination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.popularFlightTableColumnDestination.DataPropertyName = "Destination";
            this.popularFlightTableColumnDestination.HeaderText = "Destination";
            this.popularFlightTableColumnDestination.Name = "popularFlightTableColumnDestination";
            this.popularFlightTableColumnDestination.Width = 104;
            // 
            // popularFlightTableColumnPassengers
            // 
            this.popularFlightTableColumnPassengers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.popularFlightTableColumnPassengers.DataPropertyName = "Passengers";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.popularFlightTableColumnPassengers.DefaultCellStyle = dataGridViewCellStyle2;
            this.popularFlightTableColumnPassengers.HeaderText = "Passengers";
            this.popularFlightTableColumnPassengers.Name = "popularFlightTableColumnPassengers";
            this.popularFlightTableColumnPassengers.Width = 106;
            // 
            // popularFlightTableColumnRevenue
            // 
            this.popularFlightTableColumnRevenue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.popularFlightTableColumnRevenue.DataPropertyName = "Revenue";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.popularFlightTableColumnRevenue.DefaultCellStyle = dataGridViewCellStyle3;
            this.popularFlightTableColumnRevenue.HeaderText = "Revenue";
            this.popularFlightTableColumnRevenue.Name = "popularFlightTableColumnRevenue";
            this.popularFlightTableColumnRevenue.Width = 95;
            // 
            // vpopularTravelsBindingSource
            // 
            this.vpopularTravelsBindingSource.DataMember = "v_popularTravels";
            this.vpopularTravelsBindingSource.DataSource = this.dV1454_AirPortDataSet;
            // 
            // dV1454_AirPortDataSet
            // 
            this.dV1454_AirPortDataSet.DataSetName = "DV1454_AirPortDataSet";
            this.dV1454_AirPortDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.02601F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.97399F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMain.Size = new System.Drawing.Size(784, 462);
            this.tableLayoutMain.TabIndex = 1;
            // 
            // v_popularTravelsTableAdapter
            // 
            this.v_popularTravelsTableAdapter.ClearBeforeFill = true;
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
            chartArea3.Name = "ChartArea1";
            this.chartWeekDay.ChartAreas.Add(chartArea3);
            this.chartWeekDay.DataSource = this.vtravelersEachWeekDayBindingSource;
            this.chartWeekDay.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartWeekDay.Legends.Add(legend3);
            this.chartWeekDay.Location = new System.Drawing.Point(3, 3);
            this.chartWeekDay.Name = "chartWeekDay";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Passengers";
            series3.XValueMember = "Date";
            series3.YValueMembers = "Passengers";
            this.chartWeekDay.Series.Add(series3);
            this.chartWeekDay.Size = new System.Drawing.Size(556, 311);
            this.chartWeekDay.TabIndex = 0;
            this.chartWeekDay.Text = "chart3";
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
            chartArea2.Name = "ChartArea1";
            this.chartWeek.ChartAreas.Add(chartArea2);
            this.chartWeek.DataSource = this.vtravelersEachWeekBindingSource;
            this.chartWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartWeek.Legends.Add(legend2);
            this.chartWeek.Location = new System.Drawing.Point(3, 3);
            this.chartWeek.Name = "chartWeek";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Passengers";
            series2.XValueMember = "Date";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValueMembers = "Passengers";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartWeek.Series.Add(series2);
            this.chartWeek.Size = new System.Drawing.Size(556, 311);
            this.chartWeek.TabIndex = 0;
            this.chartWeek.Text = "chart2";
            title1.Name = "Title1";
            this.chartWeek.Titles.Add(title1);
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
            // chartMonth
            // 
            chartArea1.Name = "ChartArea1";
            chartMonth.ChartAreas.Add(chartArea1);
            chartMonth.DataSource = this.vtravelersEachMonthBindingSource;
            chartMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            chartMonth.Legends.Add(legend1);
            chartMonth.Location = new System.Drawing.Point(3, 3);
            chartMonth.Name = "chartMonth";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Passengers";
            series1.XValueMember = "Date";
            series1.YValueMembers = "Passengers";
            chartMonth.Series.Add(series1);
            chartMonth.Size = new System.Drawing.Size(556, 311);
            chartMonth.TabIndex = 0;
            chartMonth.Text = "chart1";
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
            // dV1454_AirPortDataSet1
            // 
            this.dV1454_AirPortDataSet1.DataSetName = "DV1454_AirPortDataSet1";
            this.dV1454_AirPortDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vtravelersEachMonthBindingSource
            // 
            this.vtravelersEachMonthBindingSource.DataMember = "v_travelersEachMonth";
            this.vtravelersEachMonthBindingSource.DataSource = this.dV1454_AirPortDataSet1;
            // 
            // v_travelersEachMonthTableAdapter
            // 
            this.v_travelersEachMonthTableAdapter.ClearBeforeFill = true;
            // 
            // dV1454_AirPortDataSet2
            // 
            this.dV1454_AirPortDataSet2.DataSetName = "DV1454_AirPortDataSet2";
            this.dV1454_AirPortDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vtravelersEachWeekBindingSource
            // 
            this.vtravelersEachWeekBindingSource.DataMember = "v_travelersEachWeek";
            this.vtravelersEachWeekBindingSource.DataSource = this.dV1454_AirPortDataSet2;
            // 
            // v_travelersEachWeekTableAdapter
            // 
            this.v_travelersEachWeekTableAdapter.ClearBeforeFill = true;
            // 
            // dV1454_AirPortDataSet3
            // 
            this.dV1454_AirPortDataSet3.DataSetName = "DV1454_AirPortDataSet3";
            this.dV1454_AirPortDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vtravelersEachWeekDayBindingSource
            // 
            this.vtravelersEachWeekDayBindingSource.DataMember = "v_travelersEachWeekDay";
            this.vtravelersEachWeekDayBindingSource.DataSource = this.dV1454_AirPortDataSet3;
            // 
            // v_travelersEachWeekDayTableAdapter
            // 
            this.v_travelersEachWeekDayTableAdapter.ClearBeforeFill = true;
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
            this.radioPopular.Size = new System.Drawing.Size(100, 69);
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
            this.radioMonthly.Size = new System.Drawing.Size(100, 69);
            this.radioMonthly.TabIndex = 1;
            this.radioMonthly.UseVisualStyleBackColor = false;
            this.radioMonthly.CheckedChanged += new System.EventHandler(this.radioMonthly_CheckedChanged);
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
            this.sidebar.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelPopularTravels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popularFlightTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpopularTravelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dV1454_AirPortDataSet)).EndInit();
            this.tableLayoutMain.ResumeLayout(false);
            this.panelPopularByDate.ResumeLayout(false);
            this.Week_day.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartWeekDay)).EndInit();
            this.Week.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartWeek)).EndInit();
            this.Month.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(chartMonth)).EndInit();
            this.tabControlDates.ResumeLayout(false);
            this.panelMainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dV1454_AirPortDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtravelersEachMonthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dV1454_AirPortDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtravelersEachWeekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dV1454_AirPortDataSet3)).EndInit();
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
        private DV1454_AirPortDataSet dV1454_AirPortDataSet;
        private BindingSource vpopularTravelsBindingSource;
        private DV1454_AirPortDataSetTableAdapters.v_popularTravelsTableAdapter v_popularTravelsTableAdapter;
        private DataGridViewTextBoxColumn popularFlightTableColumnDeparture;
        private DataGridViewTextBoxColumn popularFlightTableColumnDestination;
        private DataGridViewTextBoxColumn popularFlightTableColumnPassengers;
        private DataGridViewTextBoxColumn popularFlightTableColumnRevenue;
        private Panel panelPopularByDate;
        private Panel panelMainContent;
        private TabControl tabControlDates;
        private TabPage Month;
        private TabPage Week;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeek;
        private TabPage Week_day;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeekDay;
        private DV1454_AirPortDataSet1 dV1454_AirPortDataSet1;
        private BindingSource vtravelersEachMonthBindingSource;
        private DV1454_AirPortDataSet1TableAdapters.v_travelersEachMonthTableAdapter v_travelersEachMonthTableAdapter;
        private DV1454_AirPortDataSet2 dV1454_AirPortDataSet2;
        private BindingSource vtravelersEachWeekBindingSource;
        private DV1454_AirPortDataSet2TableAdapters.v_travelersEachWeekTableAdapter v_travelersEachWeekTableAdapter;
        private DV1454_AirPortDataSet3 dV1454_AirPortDataSet3;
        private BindingSource vtravelersEachWeekDayBindingSource;
        private DV1454_AirPortDataSet3TableAdapters.v_travelersEachWeekDayTableAdapter v_travelersEachWeekDayTableAdapter;
    }
}

