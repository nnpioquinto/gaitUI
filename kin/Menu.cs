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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void createPtBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            newRecord newRec = new newRecord();
            newRec.ShowDialog();
            this.Close();
        }

        private void viewPtRecBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewPtRec viewRec = new viewPtRec();
            viewRec.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure to exit", "Confirmation", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
