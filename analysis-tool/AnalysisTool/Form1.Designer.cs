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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioPopular = new System.Windows.Forms.RadioButton();
            this.radioMonthly = new System.Windows.Forms.RadioButton();
            this.panelPopular = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vpopularTravelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dV1454_AirPortDataSet = new AnalysisTool.DV1454_AirPortDataSet();
            this.v_popularTravelsTableAdapter = new AnalysisTool.DV1454_AirPortDataSetTableAdapters.v_popularTravelsTableAdapter();
            this.sidebar.SuspendLayout();
            this.panelAbout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelPopular.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpopularTravelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dV1454_AirPortDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sidebar.Controls.Add(this.panelAbout);
            this.sidebar.Controls.Add(this.tableLayoutPanel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(100, 0);
            this.sidebar.Name = "sidebar";
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
            this.panelPopular.Controls.Add(this.tableLayoutPanel2);
            this.panelPopular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPopular.Location = new System.Drawing.Point(0, 0);
            this.panelPopular.Name = "panelPopular";
            this.panelPopular.Size = new System.Drawing.Size(784, 462);
            this.panelPopular.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.02601F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.97399F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 462);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.vpopularTravelsBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(150, 92);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(576, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Departure";
            this.dataGridViewTextBoxColumn1.HeaderText = "Departure";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 98;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Destination";
            this.dataGridViewTextBoxColumn2.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 104;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Passengers";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn3.HeaderText = "Passengers";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 106;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Revenue";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn4.HeaderText = "Revenue";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 95;
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
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panelPopular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Analysis Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelPopular.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpopularTravelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dV1454_AirPortDataSet)).EndInit();
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
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passengersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn revenueDataGridViewTextBoxColumn;
        private BindingSource vpopularTravelsBindingSource1;
        private DV1454_AirPortDataSet dV1454_AirPortDataSet;
        private BindingSource vpopularTravelsBindingSource;
        private DV1454_AirPortDataSetTableAdapters.v_popularTravelsTableAdapter v_popularTravelsTableAdapter;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

