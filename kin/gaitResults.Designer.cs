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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gaitResults));
            this.patientLbl = new System.Windows.Forms.Label();
            this.normalLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientLbl
            // 
            this.patientLbl.AutoSize = true;
            this.patientLbl.BackColor = System.Drawing.Color.White;
            this.patientLbl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLbl.Location = new System.Drawing.Point(38, 28);
            this.patientLbl.Name = "patientLbl";
            this.patientLbl.Size = new System.Drawing.Size(127, 66);
            this.patientLbl.TabIndex = 0;
            this.patientLbl.Text = "Patient Name: \nAge: \nGender:";
            // 
            // normalLbl
            // 
            this.normalLbl.AutoSize = true;
            this.normalLbl.BackColor = System.Drawing.Color.White;
            this.normalLbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalLbl.Location = new System.Drawing.Point(37, 121);
            this.normalLbl.Name = "normalLbl";
            this.normalLbl.Size = new System.Drawing.Size(68, 25);
            this.normalLbl.TabIndex = 1;
            this.normalLbl.Text = "label1";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.White;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(599, 446);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(129, 43);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(42, 446);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(129, 43);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // gaitResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kin.Properties.Resources.bg5;
            this.ClientSize = new System.Drawing.Size(760, 510);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.normalLbl);
            this.Controls.Add(this.patientLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gaitResults";
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patientLbl;
        private System.Windows.Forms.Label normalLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button backBtn;
    }
}