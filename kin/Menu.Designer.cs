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
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.createPtBtn = new System.Windows.Forms.Button();
            this.viewPtRecBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.Location = new System.Drawing.Point(96, 320);
            button1.Margin = new System.Windows.Forms.Padding(10);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(227, 38);
            button1.TabIndex = 2;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // createPtBtn
            // 
            this.createPtBtn.BackColor = System.Drawing.Color.White;
            this.createPtBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPtBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.createPtBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.createPtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPtBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPtBtn.ForeColor = System.Drawing.Color.Black;
            this.createPtBtn.Location = new System.Drawing.Point(96, 204);
            this.createPtBtn.Margin = new System.Windows.Forms.Padding(10);
            this.createPtBtn.Name = "createPtBtn";
            this.createPtBtn.Size = new System.Drawing.Size(227, 38);
            this.createPtBtn.TabIndex = 0;
            this.createPtBtn.Text = "Create Record";
            this.createPtBtn.UseVisualStyleBackColor = false;
            this.createPtBtn.Click += new System.EventHandler(this.createPtBtn_Click);
            // 
            // viewPtRecBtn
            // 
            this.viewPtRecBtn.BackColor = System.Drawing.Color.White;
            this.viewPtRecBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.viewPtRecBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.viewPtRecBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.viewPtRecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewPtRecBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPtRecBtn.Location = new System.Drawing.Point(96, 262);
            this.viewPtRecBtn.Margin = new System.Windows.Forms.Padding(10);
            this.viewPtRecBtn.Name = "viewPtRecBtn";
            this.viewPtRecBtn.Size = new System.Drawing.Size(227, 38);
            this.viewPtRecBtn.TabIndex = 1;
            this.viewPtRecBtn.Text = "View Record List";
            this.viewPtRecBtn.UseVisualStyleBackColor = false;
            this.viewPtRecBtn.Click += new System.EventHandler(this.viewPtRecBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(88, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "MAIN MENU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kin.Properties.Resources.bg5;
            this.ClientSize = new System.Drawing.Size(429, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(button1);
            this.Controls.Add(this.viewPtRecBtn);
            this.Controls.Add(this.createPtBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createPtBtn;
        private System.Windows.Forms.Button viewPtRecBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}