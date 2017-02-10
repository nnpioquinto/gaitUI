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
        
        public gaitResults(int age, char gender, int ptID, gaitAnalysis analysis)
        {
            InitializeComponent();
            
            SystemDB sysdb = new SystemDB();
            this.analysis = analysis;

            /*BindingSource bindSource = new BindingSource();
            resultsView.DataSource = bindSource;
            bindSource.DataSource = sysdb.getNormalValues(age,gender);
            */
            string output;
            patientLbl.Text = "Patient Name: " + sysdb.getName(ptID) + "\nAge: " + age + "\nGender: "+gender;
            output = sysdb.AnalyzeData("spd", age, gender, analysis.strideVelocity);
            output += "\n" + sysdb.AnalyzeData("freq", age, gender, analysis.stepFrequency);
            output += "\n" + sysdb.AnalyzeData("len", age, gender, analysis.stepLength);
            normalLbl.Text = "Normal stride velocity range: " + sysdb.spd_lower + "cm/s - " + sysdb.spd_upper + "cm/s\nActual stride velocity is: " + analysis.strideVelocity + " cm/s\n\n" + 
                "Normal step frequency range: " + sysdb.freq_lower + "steps/second - " + sysdb.freq_upper + "steps/second\nActual step frequency is: " + analysis.stepFrequency + " steps/second\n\n" + 
                "Normal step length range: " + sysdb.len_lower + "cm - " + sysdb.len_upper + "cm\nActual step length is: " + analysis.stepLength + " cm\n\n" +output;

        }
        
    }
}
