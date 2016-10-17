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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioPopular = new System.Windows.Forms.RadioButton();
            this.radioMonthly = new System.Windows.Forms.RadioButton();
            this.panelPopular = new System.Windows.Forms.Panel();
            this.popularFlightTable = new System.Windows.Forms.DataGridView();
            this.popularFlightTableColumnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popularFlightTableColumnDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popularFlightTableColumnPassengers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popularFlightTableColumnRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vpopularTravelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dV1454_AirPortDataSet = new AnalysisTool.DV1454_AirPortDataSet();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.v_popularTravelsTableAdapter = new AnalysisTool.DV1454_AirPortDataSetTableAdapters.v_popularTravelsTableAdapter();
            this.sidebar.SuspendLayout();
            this.panelAbout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelPopular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popularFlightTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpopularTravelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dV1454_AirPortDataSet)).BeginInit();
            this.tableLayoutMain.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(100, 138);
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
            // panelPopular
            // 
            this.panelPopular.Controls.Add(this.popularFlightTable);
            this.panelPopular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPopular.Location = new System.Drawing.Point(150, 92);
            this.panelPopular.Margin = new System.Windows.Forms.Padding(0);
            this.panelPopular.Name = "panelPopular";
            this.panelPopular.Size = new System.Drawing.Size(576, 370);
            this.panelPopular.TabIndex = 1;
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
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.popularFlightTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.popularFlightTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popularFlightTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.popularFlightTableColumnDeparture,
            this.popularFlightTableColumnDestination,
            this.popularFlightTableColumnPassengers,
            this.popularFlightTableColumnRevenue});
            this.popularFlightTable.DataSource = this.vpopularTravelsBindingSource;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.popularFlightTable.DefaultCellStyle = dataGridViewCellStyle24;
            this.popularFlightTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popularFlightTable.EnableHeadersVisualStyles = false;
            this.popularFlightTable.Location = new System.Drawing.Point(0, 0);
            this.popularFlightTable.Margin = new System.Windows.Forms.Padding(0);
            this.popularFlightTable.Name = "popularFlightTable";
            this.popularFlightTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.popularFlightTable.RowHeadersVisible = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.popularFlightTable.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.popularFlightTable.RowTemplate.ReadOnly = true;
            this.popularFlightTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.popularFlightTable.Size = new System.Drawing.Size(576, 370);
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.popularFlightTableColumnPassengers.DefaultCellStyle = dataGridViewCellStyle22;
            this.popularFlightTableColumnPassengers.HeaderText = "Passengers";
            this.popularFlightTableColumnPassengers.Name = "popularFlightTableColumnPassengers";
            this.popularFlightTableColumnPassengers.Width = 106;
            // 
            // popularFlightTableColumnRevenue
            // 
            this.popularFlightTableColumnRevenue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.popularFlightTableColumnRevenue.DataPropertyName = "Revenue";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.popularFlightTableColumnRevenue.DefaultCellStyle = dataGridViewCellStyle23;
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
            this.tableLayoutMain.Controls.Add(this.panelPopular, 2, 1);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "MainWindow";
            this.Text = "Analysis Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelPopular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popularFlightTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpopularTravelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dV1454_AirPortDataSet)).EndInit();
            this.tableLayoutMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioPopular;
        private System.Windows.Forms.RadioButton radioMonthly;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Panel panelAbout;
        private Panel panelPopular;
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
    }
}

