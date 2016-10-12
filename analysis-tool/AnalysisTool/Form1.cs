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
            // TODO: This line of code loads data into the 'dV1454_AirPortDataSet.v_popularTravels' table. You can move, or remove it, as needed.
            this.v_popularTravelsTableAdapter.Fill(this.dV1454_AirPortDataSet.v_popularTravels);
        }

        private void radioMonthly_CheckedChanged(object sender, EventArgs e)
        {
            this.panelPopular.Visible = false;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void radioPopular_CheckedChanged(object sender, EventArgs e)
        {
            this.panelPopular.Visible = true;
        }
    }
}
