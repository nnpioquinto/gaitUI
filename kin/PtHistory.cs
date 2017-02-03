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
        public PtHistory(int ptID, viewPtRec view)
        {
            InitializeComponent();
            this.ptID = ptID;
            this.view = view;
        }
    }
}
