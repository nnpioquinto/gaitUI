namespace kin
{
    partial class Menu
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
            this.createPtBtn = new System.Windows.Forms.Button();
            this.viewPtRecBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPtBtn
            // 
            this.createPtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPtBtn.Location = new System.Drawing.Point(90, 80);
            this.createPtBtn.Name = "createPtBtn";
            this.createPtBtn.Size = new System.Drawing.Size(227, 38);
            this.createPtBtn.TabIndex = 0;
            this.createPtBtn.Text = "Create Record";
            this.createPtBtn.UseVisualStyleBackColor = false;
            this.createPtBtn.Click += new System.EventHandler(this.createPtBtn_Click);
            // 
            // viewPtRecBtn
            // 
            this.viewPtRecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPtRecBtn.Location = new System.Drawing.Point(90, 141);
            this.viewPtRecBtn.Name = "viewPtRecBtn";
            this.viewPtRecBtn.Size = new System.Drawing.Size(227, 38);
            this.viewPtRecBtn.TabIndex = 1;
            this.viewPtRecBtn.Text = "View Record List";
            this.viewPtRecBtn.UseVisualStyleBackColor = false;
            this.viewPtRecBtn.Click += new System.EventHandler(this.viewPtRecBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 451);
            this.Controls.Add(this.viewPtRecBtn);
            this.Controls.Add(this.createPtBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createPtBtn;
        private System.Windows.Forms.Button viewPtRecBtn;
    }
}