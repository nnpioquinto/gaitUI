namespace kin
{
    partial class gaitResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patientLbl = new System.Windows.Forms.Label();
            this.normalLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patientLbl
            // 
            this.patientLbl.AutoSize = true;
            this.patientLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.patientLbl.Location = new System.Drawing.Point(38, 28);
            this.patientLbl.Name = "patientLbl";
            this.patientLbl.Size = new System.Drawing.Size(109, 20);
            this.patientLbl.TabIndex = 0;
            this.patientLbl.Text = "Patient Name:";
            // 
            // normalLbl
            // 
            this.normalLbl.AutoSize = true;
            this.normalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.normalLbl.Location = new System.Drawing.Point(37, 80);
            this.normalLbl.Name = "normalLbl";
            this.normalLbl.Size = new System.Drawing.Size(70, 26);
            this.normalLbl.TabIndex = 1;
            this.normalLbl.Text = "label1";
            // 
            // gaitResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 510);
            this.Controls.Add(this.normalLbl);
            this.Controls.Add(this.patientLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "gaitResults";
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patientLbl;
        private System.Windows.Forms.Label normalLbl;
    }
}