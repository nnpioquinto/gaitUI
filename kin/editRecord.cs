﻿using System;
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
       
        public editRecord(int ptID) 
        {
            InitializeComponent();
            this.ptID = ptID;
            resetData();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewPtRec view = new viewPtRec();
            view.ShowDialog();
            this.Dispose();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to reset data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result ==  DialogResult.Yes)
                resetData();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            checker check = new checker();

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

            if (fName == "" || mName == "" || lName == "" || gender == "" || birthday == "" || address == "" || city == ""
                || email == "" || contactNo == "" || occu == "")
            {
                errorLbl.Text = "Please fill out all fields.";
            }
            else if (!check.IsValidEmail(email))
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
                        result = MessageBox.Show("Are there any more changes?\n(Clicking No will redirect you back to records)", "Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                            resetData();
                        else
                        {
                            this.Hide();
                            viewPtRec view = new viewPtRec();
                            view.ShowDialog();
                            this.Dispose();
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
            else 
                gender_cbox.SelectedItem = "Male";
            
            //birthday_Box.Value.ToShortDateString() = 
            streetAdd_box.Text = address;
            city_box.Text = city;
            email_box.Text = email;
            contactNo_box.Text = contactNo;
            occu_box.Text = occu;
        }
    }
}
