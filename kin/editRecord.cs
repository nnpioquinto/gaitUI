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
    public partial class editRecord : Form
    {
        int ptID;
        viewPtRec view;
        public editRecord(int ptID, viewPtRec view) 
        {
            InitializeComponent();
            this.ptID = ptID;
            this.view = view;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            view.Show();
            this.Dispose();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            /*
             * DB.getData(patientId, out blaha
             * 
             */
        }
    }
}
