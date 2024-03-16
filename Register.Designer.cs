namespace ElectricReg
{
    partial class Register
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
            this.pictureBoxreg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelfn = new System.Windows.Forms.Label();
            this.labelLID = new System.Windows.Forms.Label();
            this.labelln = new System.Windows.Forms.Label();
            this.textBoxfn = new System.Windows.Forms.TextBox();
            this.textBoxlID = new System.Windows.Forms.TextBox();
            this.textBoxln = new System.Windows.Forms.TextBox();
            this.labelask = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxreg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxreg
            // 
            this.pictureBoxreg.Image = global::ElectricReg.Properties.Resources.Bluetooth_removebg;
            this.pictureBoxreg.Location = new System.Drawing.Point(344, 82);
            this.pictureBoxreg.Name = "pictureBoxreg";
            this.pictureBoxreg.Size = new System.Drawing.Size(209, 136);
            this.pictureBoxreg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxreg.TabIndex = 2;
            this.pictureBoxreg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Register";
            // 
            // labelfn
            // 
            this.labelfn.AutoSize = true;
            this.labelfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfn.Location = new System.Drawing.Point(266, 263);
            this.labelfn.Name = "labelfn";
            this.labelfn.Size = new System.Drawing.Size(76, 17);
            this.labelfn.TabIndex = 4;
            this.labelfn.Text = "First Name";
            // 
            // labelLID
            // 
            this.labelLID.AutoSize = true;
            this.labelLID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLID.Location = new System.Drawing.Point(266, 341);
            this.labelLID.Name = "labelLID";
            this.labelLID.Size = new System.Drawing.Size(82, 17);
            this.labelLID.TabIndex = 5;
            this.labelLID.Text = "Lecturer ID ";
            // 
            // labelln
            // 
            this.labelln.AutoSize = true;
            this.labelln.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelln.Location = new System.Drawing.Point(266, 302);
            this.labelln.Name = "labelln";
            this.labelln.Size = new System.Drawing.Size(76, 17);
            this.labelln.TabIndex = 6;
            this.labelln.Text = "Last Name";
            // 
            // textBoxfn
            // 
            this.textBoxfn.BackColor = System.Drawing.Color.White;
            this.textBoxfn.Location = new System.Drawing.Point(388, 263);
            this.textBoxfn.Name = "textBoxfn";
            this.textBoxfn.Size = new System.Drawing.Size(207, 20);
            this.textBoxfn.TabIndex = 7;
            // 
            // textBoxlID
            // 
            this.textBoxlID.BackColor = System.Drawing.Color.White;
            this.textBoxlID.Location = new System.Drawing.Point(388, 341);
            this.textBoxlID.Name = "textBoxlID";
            this.textBoxlID.Size = new System.Drawing.Size(207, 20);
            this.textBoxlID.TabIndex = 8;
            // 
            // textBoxln
            // 
            this.textBoxln.BackColor = System.Drawing.Color.White;
            this.textBoxln.Location = new System.Drawing.Point(388, 302);
            this.textBoxln.Name = "textBoxln";
            this.textBoxln.Size = new System.Drawing.Size(207, 20);
            this.textBoxln.TabIndex = 9;
            // 
            // labelask
            // 
            this.labelask.AutoSize = true;
            this.labelask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelask.Location = new System.Drawing.Point(325, 403);
            this.labelask.Name = "labelask";
            this.labelask.Size = new System.Drawing.Size(180, 17);
            this.labelask.TabIndex = 10;
            this.labelask.Text = "Not a Registered Lecturer?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(503, 403);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 17);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 469);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelask);
            this.Controls.Add(this.textBoxln);
            this.Controls.Add(this.textBoxlID);
            this.Controls.Add(this.textBoxfn);
            this.Controls.Add(this.labelln);
            this.Controls.Add(this.labelLID);
            this.Controls.Add(this.labelfn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxreg);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxreg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxreg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelfn;
        private System.Windows.Forms.Label labelLID;
        private System.Windows.Forms.Label labelln;
        private System.Windows.Forms.TextBox textBoxfn;
        private System.Windows.Forms.TextBox textBoxlID;
        private System.Windows.Forms.TextBox textBoxln;
        private System.Windows.Forms.Label labelask;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}