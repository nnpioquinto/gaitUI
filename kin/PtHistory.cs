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
    public partial class PtHistory : Form
    {
        private int ptID;
        viewPtRec view;
        public PtHistory(int ptID)
        {
            InitializeComponent();
            this.ptID = ptID;

            SystemDB sysdb = new SystemDB();
            BindingSource bindSource = new BindingSource();
            histDataGrid.DataSource = bindSource;
            bindSource.DataSource = sysdb.getHistory(ptID);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            viewPtRec view = new viewPtRec();
            this.Hide();
            view.ShowDialog();
            this.Dispose();
        }
    }
}
