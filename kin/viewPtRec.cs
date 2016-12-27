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
        Menu menu;
        public viewPtRec(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            menu.ShowDialog();
            this.Dispose();
        }

        private void viewHist_btn_Click(object sender, EventArgs e)
        {
            int ptID = (int)dataGrid.SelectedRows[0].Cells["patient_ID"].Value;
            //PtHistory ptHist = new PtHistory(ptID, this);
            this.Hide();
            //ptHist.ShowDialog();
        }

        private void editPt_Btn_Click(object sender, EventArgs e)
        {
            int ptID = (int)dataGrid.SelectedRows[0].Cells["patient_ID"].Value;
            editRecord editRec = new editRecord(ptID, this);
            this.Hide();
            editRec.ShowDialog();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            int ptID = (int)dataGrid.SelectedRows[0].Cells["patient_ID"].Value;
          //  gaitAnalysis gait = new gaitAnalysis(ptID, this);
            this.Hide();
            //gait.ShowDialog();
        }
        
    }
}
