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
            newRecord newRec = new newRecord(this);
            this.Hide();
            newRec.ShowDialog();
        }

        private void viewPtRecBtn_Click(object sender, EventArgs e)
        {
            viewPtRec viewRec = new viewPtRec(this);
            this.Hide();
            viewRec.ShowDialog();
        }
    }
}
