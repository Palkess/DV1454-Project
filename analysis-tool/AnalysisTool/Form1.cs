using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalysisTool
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dV1454_DataSetAnalysis.v_travelersEachWeekDay' table. You can move, or remove it, as needed.
            this.v_travelersEachWeekDayTableAdapter.Fill(this.dV1454_DataSetAnalysis.v_travelersEachWeekDay);
            // TODO: This line of code loads data into the 'dV1454_DataSetAnalysis.v_travelersEachWeek' table. You can move, or remove it, as needed.
            this.v_travelersEachWeekTableAdapter.Fill(this.dV1454_DataSetAnalysis.v_travelersEachWeek);
            // TODO: This line of code loads data into the 'dV1454_DataSetAnalysis.v_travelersEachMonth' table. You can move, or remove it, as needed.
            this.v_travelersEachMonthTableAdapter.Fill(this.dV1454_DataSetAnalysis.v_travelersEachMonth);
            // TODO: This line of code loads data into the 'dV1454_DataSetAnalysis.v_popularTravels' table. You can move, or remove it, as needed.
            this.v_popularTravelsTableAdapter.Fill(this.dV1454_DataSetAnalysis.v_popularTravels);

            this.panelPopularTravels.Visible = true;
            this.panelPopularByDate.Visible = false;
        }

        private void radioMonthly_CheckedChanged(object sender, EventArgs e)
        {
            this.panelPopularTravels.Visible = false;
            this.panelPopularByDate.Visible = true;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void radioPopular_CheckedChanged(object sender, EventArgs e)
        {
            this.panelPopularTravels.Visible = true;
            this.panelPopularByDate.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
