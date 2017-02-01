using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace kin
{
    class SystemDB
    {
        static MySqlConnection dbconn;
        MySqlCommand cmd;
        MySqlDataReader rdr;
        static string connString, query;
        public double spd_upper = 0.00, spd_lower = 0.00, freq_upper = 0.00, freq_lower = 0.00, len_upper = 0.00, len_lower = 0.00;

        public SystemDB()
        {
            connString = "server=localhost;uid=root;password=;database=gaitsystem;";
            dbconn = new MySqlConnection(connString);
        }


        public string AnalyzeData(string type, int age, char gender, double strideVelocity)
        {
            // string type determines which table to be analyzed. if speed(velocity), steplength(stridelength), or stepfrequency
            dbconn.Open();
            double ci_lower = 0.00, ci_upper = 0.00, pi_lower = 0.00, pi_upper = 0.00;
            string output = "", param, varName;
            switch (type)
            {
                case "spd": param = "1"; varName = "speed"; break;
                case "len": param = "3"; varName = "stride length"; break;
                case "freq": param = "2"; varName = "step frequency"; break;
                default: param = ""; varName = ""; break;
            }
            query = String.Format("SELECT ci_lower, ci_upper, pi_lower, pi_upper FROM parameter_values WHERE parametersID = {0} AND values_gender = '{1}' AND '{2}' BETWEEN age_lower AND age_upper", param, gender, age);
            cmd = new MySqlCommand(query, dbconn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                ci_lower = double.Parse(rdr.GetString(0));
                ci_upper = double.Parse(rdr.GetString(1));
                pi_lower = double.Parse(rdr.GetString(2));
                pi_upper = double.Parse(rdr.GetString(3));
            }

            if (strideVelocity > ci_lower && strideVelocity < ci_upper)
                output = "The " + varName + " within the normal range.";
            else if (strideVelocity < ci_lower)
                output = "The " + varName + " is less than the normal range.";
            else if (strideVelocity > ci_upper)
                output = "The " + varName + " is greater than the normal range.";
            dbconn.Close();
            switch (type)
            {
                case "spd": spd_lower = ci_lower; spd_upper = ci_upper; break;
                case "len": len_lower = ci_lower; len_upper = ci_upper; break;
                case "freq": freq_lower = ci_lower; freq_upper = ci_upper; break;
                default: break;
            }
            return output;
        }

        public int getAge(int id)
        {
            DateTime today = DateTime.Today, dateOfBirth=DateTime.Today;
            dbconn.Open();
            query = String.Format("SELECT patient_DateOfBirth FROM patient WHERE patientID = {0};", id);
            cmd = new MySqlCommand(query, dbconn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dateOfBirth = rdr.GetDateTime(0);
            }
            int age = (today.Year - dateOfBirth.Year);
            dbconn.Close();
            return age;
        }

        public char getGender(int id)
        {
            char gender = ' ';
            dbconn.Open();
            query = String.Format("SELECT patient_Gender FROM patient WHERE patientID = {0};", id);
            cmd = new MySqlCommand(query, dbconn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                gender = rdr.GetChar(0);
            }
            dbconn.Close();
            return gender;
        }

        public bool createPatient(string fName, string mName, string lName, string gender, string birthday, string address, string city, string email, string contactNo, string occu)
        {
            dbconn.Open();
            try
            {
                query = String.Format("INSERT INTO patient VALUES (null, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}') ", fName, mName, lName, gender, address, city, email, contactNo, birthday, occu);
                cmd = new MySqlCommand(query, dbconn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            dbconn.Close();

            return true;
        }

        public Boolean loginCheck(string username, string password)
        {
            dbconn.Open();
            try
            {
                query = String.Format("SELECT username, password FROM user_account WHERE username = '{0}' AND password = '{1}';", username, password);
                cmd = new MySqlCommand(query, dbconn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    return true;
                }
                dbconn.Close();
                Debug.Write("No values found");
                return false;
            }
            catch(MySqlException e)
            {
                    Debug.Write(e);
                return false;
            }
        }

        public DataTable retrieveData()
        {
            dbconn.Open();
            try
            {
                query = String.Format("SELECT patientID, patient_FN AS First_Name, patient_MN AS Middle_Name, patient_LN AS Last_Name, "+
                    "patient_gender AS Gender, patient_StreetAddress as Address, patient_city as City, patient_email as Email,"+
                    "patient_ContactNumber as Contact_Number, patient_DateOfBirth as Birthday, patient_occupation as Occupation FROM patient");
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, dbconn);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                return table;
            }
            catch (MySqlException e)
            {
                Console.Write("\n" + e);
                return null;
            }
        }

        public void retrieveData(int id, out string fName, out string mName, out string lName, out string gender, out string birthday, out string address, out string city, out string email, out string contactNo, out string occu)
        {
            dbconn.Open();
            query = String.Format("SELECT patient_FN, patient_MN, patient_LN, patient_gender, patient_StreetAddress, patient_city, patient_email," +
                    "patient_ContactNumber, patient_DateOfBirth, patient_occupation FROM patient WHERE patientID = {0}", id);
            cmd = new MySqlCommand(query, dbconn);
            rdr = cmd.ExecuteReader();

            fName = "";
            mName = "";
            lName = "";
            gender = "";
            birthday = "";
            address = "";
            city = "";
            email = "";
            contactNo = "";
            occu = "";

            while (rdr.Read())
            {
                    fName = rdr.GetString(0);
                    mName = rdr.GetString(1);
                    lName = rdr.GetString(2);
                    gender = rdr.GetString(3);
                    address = rdr.GetString(4);
                    city = rdr.GetString(5);
                    email = rdr.GetString(6);
                    contactNo = rdr.GetString(7);
                    birthday = rdr.GetString(8);
                    occu = rdr.GetString(9);
            }
           
            dbconn.Close();
            
        }

        public bool updatePatient(string fName, string mName, string lName, string gender, string birthday, string address, string city, string email, string contactNo, string occu, int ptID)
        {
            dbconn.Open();
            try
            {
                query = String.Format("UPDATE patient SET patient_FN = '{0}', patient_MN = '{1}', patient_LN = '{2}', patient_gender = '{3}', patient_StreetAddress = '{4}', patient_City = '{5}', patient_email = '{6}', patient_contactNumber = '{7}', patient_DateOfBirth = '{8}', patient_occupation = '{9}' WHERE patientID = {10} ", fName, mName, lName, gender, address, city, email, contactNo, birthday, occu,ptID);
                cmd = new MySqlCommand(query, dbconn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.Write(e);
                return false;
            }
            dbconn.Close();

            return true;
        }
    }
}
