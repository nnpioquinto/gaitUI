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
        string fName;
        string mName;
        string lName;
        string gender;
        string birthday;
        string address;
        string city;
        string email;
        string contactNo;
        string occu;

        SystemDB sysDB = new SystemDB();
       

        public editRecord(int ptID, viewPtRec view) 
        {
            InitializeComponent();
            this.ptID = ptID;
            this.view = view;

            resetData();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            view.Show();
            this.Dispose();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string fName = fName_box.Text;
            string mName = mName_box.Text;
            string lName = lName_box.Text;
            string gender = gender_cbox.SelectedItem.ToString();
            string birthday = birthday_Box.Value.ToShortDateString();
            string address = streetAdd_box.Text;
            string city = city_box.Text;
            string email = email_box.Text;
            string contactNo = contactNo_box.Text;
            string occu = occu_box.Text;

            newRecord newRec = new newRecord();
            if (fName == "" || mName == "" || lName == "" || gender == "" || birthday == "" || address == "" || city == ""
                || email == "" || contactNo == "" || occu == "")
            {
                errorLbl.Text = "Please fill out all fields.";
            }
            else if (!newRec.IsValidEmail(email))
            {
                errorLbl.Text = "Please enter a valid email address";
                email_box.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to update new record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Boolean success = sysDB.updatePatient(fName, mName, lName, gender, birthday, address, city, email, contactNo, occu, ptID);
                    if (success)
                    {
                        MessageBox.Show("Record Saved!", "Success");
                        result = MessageBox.Show("Create Record again?\n(Clicking No will redirect you to the Main Menu", "Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                            resetData();
                        else
                        {
                            //menu.Show();
                            //this.Dispose();
                        }
                    }

                }
            }
        }

        private void resetData()
        {
            SystemDB sysDB = new SystemDB();
            sysDB.retrieveData(this.ptID, out fName, out mName, out lName, out gender, out birthday, out address, out city, out email, out contactNo, out occu);

            fName_box.Text = fName;
            mName_box.Text = mName;
            lName_box.Text = lName;
            if (gender == "F")
                gender_cbox.SelectedItem = "Female";
            else if (gender == "M")
                gender_cbox.SelectedItem = "Male";
            else
                gender_cbox.SelectedItem = "Others";
            //birthday_Box.Value.ToShortDateString() = 
            streetAdd_box.Text = address;
            city_box.Text = city;
            email_box.Text = email;
            contactNo_box.Text = contactNo;
            occu_box.Text = occu;
        }
    }
}
