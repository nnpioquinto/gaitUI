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
        Menu menu;
        Boolean invalid = false;

        public newRecord(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }
        public newRecord()
        {
            InitializeComponent();
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
            
            if(fName == "" || mName == "" || lName == "" || gender == "" || birthday =="" ||address =="" || city == ""
                || email == "" || contactNo == "" || occu == "")
            {
                errorLbl.Text= "Please fill out all fields.";
            }
            else if (!IsValidEmail(email))
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
                            result = MessageBox.Show("Create Record again?\n(Clicking No will redirect you to the Main Menu", "Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if(result == DialogResult.Yes)
                                resetBoxes();
                            else{
                                menu.Show();
                                this.Dispose();
                            }
                        }
                    
                }
            }


        }
        public bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
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
            menu.Show();
            this.Close();
        }
    }
}
