using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kin
{
    public partial class viewPtRec : Form
    {
        Menu menu = new Menu();

        public viewPtRec()
        {
            InitializeComponent();

            SystemDB sysdb = new SystemDB();
            BindingSource bindSource = new BindingSource();
            dataGrid.DataSource = bindSource;
            bindSource.DataSource = sysdb.retrieveData();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.ShowDialog();
            this.Dispose();
        }

        private void viewHist_btn_Click(object sender, EventArgs e)
        {
            int ptID = (int)dataGrid.SelectedRows[0].Cells["patientID"].Value;

            PtHistory ptHist = new PtHistory(ptID);
            this.Hide();
            ptHist.ShowDialog();
            this.Dispose();
        }

        private void editPt_Btn_Click(object sender, EventArgs e)
        {
            int ptID = (int)dataGrid.SelectedRows[0].Cells["patientID"].Value;

            editRecord editRec = new editRecord(ptID);
            this.Hide();
            editRec.ShowDialog();
            this.Dispose();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            int ptID = (int)dataGrid.SelectedRows[0].Cells["patientID"].Value;

            gaitAnalysis gait = new gaitAnalysis(ptID);
            this.Hide();
            gait.ShowDialog();
            this.Dispose();
        }
    }
}
