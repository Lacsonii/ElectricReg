namespace ElectricReg
{
    partial class Lectures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lectures));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelmodules = new System.Windows.Forms.Label();
            this.comboBoxPrograms = new System.Windows.Forms.ComboBox();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.btnMostAttendant = new System.Windows.Forms.Button();
            this.btnNeverAttended = new System.Windows.Forms.Button();
            this.btnPoorAttendant = new System.Windows.Forms.Button();
            this.btnAverageAttendant = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAdduser = new System.Windows.Forms.Button();
            this.labelstartdate = new System.Windows.Forms.Label();
            this.labelendDate = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.labelprofile = new System.Windows.Forms.Label();
            this.pictureBoxprofile = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.refreshIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxprofile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Attendance";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Blue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(693, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(564, 139);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(130, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // labelmodules
            // 
            this.labelmodules.AutoSize = true;
            this.labelmodules.BackColor = System.Drawing.Color.Blue;
            this.labelmodules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmodules.ForeColor = System.Drawing.Color.White;
            this.labelmodules.Location = new System.Drawing.Point(804, 139);
            this.labelmodules.Name = "labelmodules";
            this.labelmodules.Size = new System.Drawing.Size(77, 20);
            this.labelmodules.TabIndex = 3;
            this.labelmodules.Text = "Modules ";
            // 
            // comboBoxPrograms
            // 
            this.comboBoxPrograms.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxPrograms.FormattingEnabled = true;
            this.comboBoxPrograms.Location = new System.Drawing.Point(881, 139);
            this.comboBoxPrograms.Name = "comboBoxPrograms";
            this.comboBoxPrograms.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrograms.TabIndex = 4;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(270, 166);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.Size = new System.Drawing.Size(732, 270);
            this.dataGridViewStudents.TabIndex = 5;
            // 
            // btnMostAttendant
            // 
            this.btnMostAttendant.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMostAttendant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostAttendant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostAttendant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostAttendant.ForeColor = System.Drawing.Color.Black;
            this.btnMostAttendant.Location = new System.Drawing.Point(270, 446);
            this.btnMostAttendant.Name = "btnMostAttendant";
            this.btnMostAttendant.Size = new System.Drawing.Size(111, 28);
            this.btnMostAttendant.TabIndex = 6;
            this.btnMostAttendant.Text = "Most Attendant";
            this.btnMostAttendant.UseVisualStyleBackColor = false;
            this.btnMostAttendant.Click += new System.EventHandler(this.btnMostAttendant_Click);
            // 
            // btnNeverAttended
            // 
            this.btnNeverAttended.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNeverAttended.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeverAttended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeverAttended.Location = new System.Drawing.Point(681, 446);
            this.btnNeverAttended.Name = "btnNeverAttended";
            this.btnNeverAttended.Size = new System.Drawing.Size(111, 28);
            this.btnNeverAttended.TabIndex = 7;
            this.btnNeverAttended.Text = "Never Attended";
            this.btnNeverAttended.UseVisualStyleBackColor = true;
            this.btnNeverAttended.Click += new System.EventHandler(this.btnNeverAttended_Click);
            // 
            // btnPoorAttendant
            // 
            this.btnPoorAttendant.BackColor = System.Drawing.Color.LightBlue;
            this.btnPoorAttendant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPoorAttendant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoorAttendant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoorAttendant.ForeColor = System.Drawing.Color.Black;
            this.btnPoorAttendant.Location = new System.Drawing.Point(547, 446);
            this.btnPoorAttendant.Name = "btnPoorAttendant";
            this.btnPoorAttendant.Size = new System.Drawing.Size(111, 28);
            this.btnPoorAttendant.TabIndex = 8;
            this.btnPoorAttendant.Text = "Poor Attendant";
            this.btnPoorAttendant.UseVisualStyleBackColor = false;
            this.btnPoorAttendant.Click += new System.EventHandler(this.btnPoorAttendant_Click);
            // 
            // btnAverageAttendant
            // 
            this.btnAverageAttendant.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAverageAttendant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAverageAttendant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAverageAttendant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverageAttendant.ForeColor = System.Drawing.Color.Black;
            this.btnAverageAttendant.Location = new System.Drawing.Point(404, 446);
            this.btnAverageAttendant.Name = "btnAverageAttendant";
            this.btnAverageAttendant.Size = new System.Drawing.Size(120, 28);
            this.btnAverageAttendant.TabIndex = 9;
            this.btnAverageAttendant.Text = "Average attendant";
            this.btnAverageAttendant.UseVisualStyleBackColor = false;
            this.btnAverageAttendant.Click += new System.EventHandler(this.btnAverageAttendant_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(51, 25);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAdduser
            // 
            this.btnAdduser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdduser.ForeColor = System.Drawing.Color.White;
            this.btnAdduser.Location = new System.Drawing.Point(908, 446);
            this.btnAdduser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.Size = new System.Drawing.Size(94, 28);
            this.btnAdduser.TabIndex = 11;
            this.btnAdduser.Text = "Add User";
            this.btnAdduser.UseVisualStyleBackColor = false;
            this.btnAdduser.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // labelstartdate
            // 
            this.labelstartdate.AutoSize = true;
            this.labelstartdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstartdate.Location = new System.Drawing.Point(267, 111);
            this.labelstartdate.Name = "labelstartdate";
            this.labelstartdate.Size = new System.Drawing.Size(70, 17);
            this.labelstartdate.TabIndex = 12;
            this.labelstartdate.Text = "Start date";
            // 
            // labelendDate
            // 
            this.labelendDate.AutoSize = true;
            this.labelendDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelendDate.Location = new System.Drawing.Point(267, 139);
            this.labelendDate.Name = "labelendDate";
            this.labelendDate.Size = new System.Drawing.Size(65, 17);
            this.labelendDate.TabIndex = 13;
            this.labelendDate.Text = "End date";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(345, 108);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(131, 20);
            this.dateTimeStart.TabIndex = 14;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(345, 139);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(131, 20);
            this.dateTimeEnd.TabIndex = 15;
            // 
            // labelprofile
            // 
            this.labelprofile.AutoSize = true;
            this.labelprofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprofile.Location = new System.Drawing.Point(74, 137);
            this.labelprofile.Name = "labelprofile";
            this.labelprofile.Size = new System.Drawing.Size(131, 24);
            this.labelprofile.TabIndex = 16;
            this.labelprofile.Text = "Student Profile";
            // 
            // pictureBoxprofile
            // 
            this.pictureBoxprofile.Image = global::ElectricReg.Properties.Resources.images_removebg_preview;
            this.pictureBoxprofile.Location = new System.Drawing.Point(68, 185);
            this.pictureBoxprofile.Name = "pictureBoxprofile";
            this.pictureBoxprofile.Size = new System.Drawing.Size(137, 115);
            this.pictureBoxprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxprofile.TabIndex = 17;
            this.pictureBoxprofile.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Student ID";
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.BackColor = System.Drawing.Color.White;
            this.textBoxStudentName.Location = new System.Drawing.Point(112, 323);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.ReadOnly = true;
            this.textBoxStudentName.Size = new System.Drawing.Size(140, 20);
            this.textBoxStudentName.TabIndex = 20;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.BackColor = System.Drawing.Color.White;
            this.textBoxStudentID.Location = new System.Drawing.Point(112, 370);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.ReadOnly = true;
            this.textBoxStudentID.Size = new System.Drawing.Size(140, 20);
            this.textBoxStudentID.TabIndex = 21;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(12, 493);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(65, 28);
            this.btnSignOut.TabIndex = 22;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // refreshIcon
            // 
            this.refreshIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshIcon.Image = ((System.Drawing.Image)(resources.GetObject("refreshIcon.Image")));
            this.refreshIcon.Location = new System.Drawing.Point(69, 12);
            this.refreshIcon.Name = "refreshIcon";
            this.refreshIcon.Size = new System.Drawing.Size(28, 25);
            this.refreshIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshIcon.TabIndex = 23;
            this.refreshIcon.TabStop = false;
            this.refreshIcon.Click += new System.EventHandler(this.refreshIcon_Click);
            // 
            // Lectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 532);
            this.Controls.Add(this.refreshIcon);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxprofile);
            this.Controls.Add(this.labelprofile);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.labelendDate);
            this.Controls.Add(this.labelstartdate);
            this.Controls.Add(this.btnAdduser);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAverageAttendant);
            this.Controls.Add(this.btnPoorAttendant);
            this.Controls.Add(this.btnNeverAttended);
            this.Controls.Add(this.btnMostAttendant);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.comboBoxPrograms);
            this.Controls.Add(this.labelmodules);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Name = "Lectures";
            this.Text = "Lectures";
            this.Load += new System.EventHandler(this.Lectures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxprofile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelmodules;
        private System.Windows.Forms.ComboBox comboBoxPrograms;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button btnMostAttendant;
        private System.Windows.Forms.Button btnNeverAttended;
        private System.Windows.Forms.Button btnPoorAttendant;
        private System.Windows.Forms.Button btnAverageAttendant;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAdduser;
        private System.Windows.Forms.Label labelstartdate;
        private System.Windows.Forms.Label labelendDate;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label labelprofile;
        private System.Windows.Forms.PictureBox pictureBoxprofile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.PictureBox refreshIcon;
    }
}