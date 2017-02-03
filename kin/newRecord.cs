using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kin
{
    public partial class newRecord : Form
    {

        Boolean invalid = false;
        Menu menu;

        public newRecord(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
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

            SystemDB sysDB = new SystemDB();
            checker check = new checker();

            if (fName == "" || mName == "" || lName == "" || gender == "" || birthday =="" ||address =="" || city == ""
                || email == "" || contactNo == "" || occu == "")
            {
                errorLbl.Text= "Please fill out all fields.";
            }
            else if (!check.IsValidEmail(email))
            {
                errorLbl.Text = "Please enter a valid email address";
                email_box.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to create new record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    Boolean success = sysDB.createPatient(fName, mName, lName, gender, birthday, address, city, email, contactNo, occu);    
                    if (success) 
                        { 
                            MessageBox.Show("Record Saved!", "Success");
                            result = MessageBox.Show("Create record again?\n(Clicking No will redirect you to the Main Menu)", "Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if(result == DialogResult.Yes)
                                resetBoxes();
                            else{
                                this.menu.Show();
                                this.Dispose();
                            }
                        }
                    
                }
            }


        }
       

        private void resetBtn_Click(object sender, EventArgs e)
        {
            resetBoxes();
        }

        public void resetBoxes()
        {
            fName_box.Text = "";
            mName_box.Text = "";
            lName_box.Text = "";
            gender_cbox.SelectedIndex = 0;
            birthday_Box.Value = DateTime.Now;
            streetAdd_box.Text = "";
            city_box.Text = "";
            email_box.Text = "";
            contactNo_box.Text = "";
            occu_box.Text = "";

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.menu.Show();
            this.Close();
        }
    }
}
