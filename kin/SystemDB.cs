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
        public double
            spd_upper = 0.00,   spd_lower = 0.00,
            freq_upper = 0.00,  freq_lower = 0.00,
            len_upper = 0.00,   len_lower = 0.00,
            wid_upper = 0.00,   wid_lower = 0.00,
            cad_upper = 0.00,   cad_lower = 0.00,
            srl_upper = 0.00,   srl_lower = 0.00,
            swt_upper = 0.00,   swt_lower = 0.00,
            stt_upper = 0.00,   stt_lower = 0.00;

        public SystemDB()
        {
            connString = "server=localhost;uid=root;password=;database=gaitsystem;";
            dbconn = new MySqlConnection(connString);
        }


        public string AnalyzeData(string type, int age, char gender, double param_val)
        {
            // string type determines which table to be analyzed. if speed(velocity), steplength(stridelength), or stepfrequency
            dbconn.Open();
            double var_lower = 0.00, var_upper = 0.00;
            string output = "", param, varName;
            switch (type)
            {
                case "spd": param = "1"; varName = "speed"; break;
                case "len": param = "3"; varName = "step length"; break;
                case "freq": param = "2"; varName = "step frequency"; break;
                case "wid": param = "4"; varName = "step width"; break;
                case "cad": param = "5"; varName = "cadence"; break;
                case "srl": param = "6"; varName = "stride length"; break;
                case "swt": param = "7"; varName = "swing time"; break;
                case "stt": param = "8"; varName = "step time"; break;
                default: param = ""; varName = ""; break;
            }
            query = String.Format("SELECT var_lower, var_upper FROM parameter_values WHERE parametersID = {0} AND values_gender = '{1}' AND '{2}' BETWEEN age_lower AND age_upper", param, gender, age);
            cmd = new MySqlCommand(query, dbconn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                var_lower = double.Parse(rdr.GetString(0));
                var_upper = double.Parse(rdr.GetString(1));
                            }

            if (param_val > var_lower && param_val < var_upper)
                output = "The " + varName + " within the normal range.";
            else if (param_val < var_lower)
                output = "The " + varName + " is less than the normal range.";
            else if (param_val > var_upper)
                output = "The " + varName + " is greater than the normal range.";
            dbconn.Close();
            switch (type)
            {
                case "spd": spd_lower = var_lower; spd_upper = var_upper; break;
                case "len": len_lower = var_lower; len_upper = var_upper; break;
                case "freq": freq_lower = var_lower; freq_upper = var_upper; break;
                case "wid": wid_lower = var_lower; wid_upper = var_upper; break;
                case "cad": cad_lower = var_lower; cad_upper = var_upper; break;
                case "srl": srl_lower = var_lower; srl_upper = var_upper; break;
                case "swt": swt_lower = var_lower; swt_upper = var_upper; break;
                case "stt": stt_lower = var_lower; stt_upper = var_upper; break;
                default: break;
            }
            return output;
        }

        public int getAge(int id)
        {
            DateTime today = DateTime.Today;
            string dateOfBirth = "";
            dbconn.Open();
            query = String.Format("SELECT patient_DateOfBirth FROM patient WHERE patientID = {0};", id);
            cmd = new MySqlCommand(query, dbconn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dateOfBirth = rdr.GetString(0);
            }
            int year = Int32.Parse(dateOfBirth.Substring(6));

            int age = 0;
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
        public string getName(int id)
        {
            string name = "";
            dbconn.Open();
            query = String.Format("SELECT patient_FN, patient_MN, patient_LN FROM patient WHERE patientID = {0};", id);
            cmd = new MySqlCommand(query, dbconn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                name = rdr.GetString(0);
                name += " " + rdr.GetString(1);
                name += " " + rdr.GetString(2);
            }
            dbconn.Close();
            return name;
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
                dbconn.Close(); //DITO MO LAGAY TRY MO
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
                dbconn.Close(); 
            }
            catch (Exception e)
            {
                Debug.Write(e);
                return false;
            }
            
            return true;
        }

        public DataTable getNormalValues(int age, char gender)
        {
            dbconn.Open();
            try
            {
                query = String.Format("SELECT parametersID, val_lower, val_upper FROM `parameter_values` WHERE {0} BETWEEN age_lower AND age_upper AND values_gender = '{1}';", age, gender);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, dbconn);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                return table;
            }
            catch (MySqlException e)
            {
                Debug.Write("\n" + e);
                return null;
            }
        }
    }
}
