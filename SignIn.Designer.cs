namespace ElectricReg
{
    partial class SignIn
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
            this.labellecID = new System.Windows.Forms.Label();
            this.labelpass = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.linkLabelforgot = new System.Windows.Forms.LinkLabel();
            this.pictureBoxlS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlS)).BeginInit();
            this.SuspendLayout();
            // 
            // labellecID
            // 
            this.labellecID.AutoSize = true;
            this.labellecID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellecID.Location = new System.Drawing.Point(237, 158);
            this.labellecID.Name = "labellecID";
            this.labellecID.Size = new System.Drawing.Size(42, 17);
            this.labellecID.TabIndex = 5;
            this.labellecID.Text = "Email";
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpass.Location = new System.Drawing.Point(237, 213);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(69, 17);
            this.labelpass.TabIndex = 6;
            this.labelpass.Text = "Password";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(339, 158);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(176, 20);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBoxpass
            // 
            this.textBoxpass.BackColor = System.Drawing.Color.White;
            this.textBoxpass.Location = new System.Drawing.Point(339, 210);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(176, 20);
            this.textBoxpass.TabIndex = 7;
            this.textBoxpass.UseSystemPasswordChar = true;
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPass.Location = new System.Drawing.Point(413, 236);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(102, 17);
            this.checkBoxShowPass.TabIndex = 31;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxconfirm_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Sign In";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Navy;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(379, 288);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 31);
            this.btnSignIn.TabIndex = 33;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // linkLabelforgot
            // 
            this.linkLabelforgot.AutoSize = true;
            this.linkLabelforgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelforgot.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelforgot.Location = new System.Drawing.Point(429, 349);
            this.linkLabelforgot.Name = "linkLabelforgot";
            this.linkLabelforgot.Size = new System.Drawing.Size(86, 13);
            this.linkLabelforgot.TabIndex = 36;
            this.linkLabelforgot.TabStop = true;
            this.linkLabelforgot.Text = "Forgot Password";
            // 
            // pictureBoxlS
            // 
            this.pictureBoxlS.Image = global::ElectricReg.Properties.Resources.Bluetooth_removebg;
            this.pictureBoxlS.Location = new System.Drawing.Point(32, 119);
            this.pictureBoxlS.Name = "pictureBoxlS";
            this.pictureBoxlS.Size = new System.Drawing.Size(162, 158);
            this.pictureBoxlS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxlS.TabIndex = 4;
            this.pictureBoxlS.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelforgot);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.labellecID);
            this.Controls.Add(this.pictureBoxlS);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxlS;
        private System.Windows.Forms.Label labellecID;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.LinkLabel linkLabelforgot;
    }
}