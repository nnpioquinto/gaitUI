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
    public partial class gaitResults : Form
    {
        string fName = "";
        string mName = "";
        string lName = "";
        gaitAnalysis analysis;
        int ptID;
        SystemDB sysdb = new SystemDB();

        public gaitResults(int age, char gender, int ptID, gaitAnalysis analysis)
        {
            InitializeComponent();
            
            this.analysis = analysis;
            this.ptID = ptID;
            
            string output;
            patientLbl.Text = "Patient Name: " + sysdb.getName(ptID) + "\nAge: " + age + "\nGender: "+gender;
            output = sysdb.AnalyzeData("spd", age, gender, analysis.strideVelocity);
            output += "\n" + sysdb.AnalyzeData("freq", age, gender, analysis.stepFrequency);
            output += "\n" + sysdb.AnalyzeData("len", age, gender, analysis.stepLength);
            output += "\n" + sysdb.AnalyzeData("wid", age, gender, analysis.stepWidth);
            output += "\n" + sysdb.AnalyzeData("cad", age, gender, analysis.cadence);
            output += "\n" + sysdb.AnalyzeData("srl", age, gender, analysis.strideLength);
            output += "\n" + sysdb.AnalyzeData("swt", age, gender, analysis.swingTime);
            output += "\n" + sysdb.AnalyzeData("stt", age, gender, analysis.stepTime);
            normalLbl.Text = "Normal stride velocity range: " + sysdb.spd_lower + "cm/s - " + sysdb.spd_upper + "cm/s\nActual stride velocity is: " + analysis.strideVelocity + " cm/s\n\n" + 
                "Normal step frequency range: " + sysdb.freq_lower + "steps/second - " + sysdb.freq_upper + "steps/second\nActual step frequency is: " + analysis.stepFrequency + " steps/second\n\n" + 
                "Normal step length range: " + sysdb.len_lower + "cm - " + sysdb.len_upper + "cm\nActual step length is: " + analysis.stepLength + " cm\n\n" + 
                "Normal step width range: " + sysdb.wid_lower + "cm - " + sysdb.wid_upper + "cm\nActual step width is: " + analysis.stepWidth + "cm\n\n" +
                "Normal cadence range: " + sysdb.cad_lower + " - " + sysdb.cad_upper + "\nActual cadence is: " + analysis.cadence + "\n\n" +
                "Normal stride length range: " + sysdb.srl_lower + "cm - " + sysdb.srl_upper + "cm\nActual stride length is: " + analysis.strideLength + "cm\n\n" + 
                "Normal swing time range: " + sysdb.swt_lower + " - " + sysdb.swt_upper + "\nActual swing time is: " + analysis.swingTime + "\n\n" + 
                "Normal step time range: " + sysdb.stt_lower + " - " + sysdb.stt_upper + "\nActual step time is: " + analysis.stepTime + "\n\n" + output;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Go back to analysis without saving?", "Confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                gaitAnalysis analysis = new gaitAnalysis(ptID);
                analysis.ShowDialog();
                this.Dispose();
            }
            else
            {
                result = MessageBox.Show("Go back to menu without saving?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    Menu menu = new Menu();
                    menu.ShowDialog();
                    this.Dispose();
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Save analysis?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (sysdb.saveRecords(analysis.strideVelocity, analysis.stepLength, analysis.stepFrequency, ptID))
                {
                    MessageBox.Show("Records Saved!", "Success");
                    DialogResult result1 = MessageBox.Show("Go back to analysis?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        this.Hide();
                        gaitAnalysis analysis = new gaitAnalysis(ptID);
                        analysis.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                        result1 = MessageBox.Show("Go back to menu?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result1 == DialogResult.Yes)
                        {
                            this.Hide();
                            Menu menu = new Menu();
                            menu.ShowDialog();
                            this.Dispose();
                        }
                    }
                }

            }
        }
    }
}
