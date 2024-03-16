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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelmodules = new System.Windows.Forms.Label();
            this.comboBoxPrograms = new System.Windows.Forms.ComboBox();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.btnMA = new System.Windows.Forms.Button();
            this.btnNA = new System.Windows.Forms.Button();
            this.btnPA = new System.Windows.Forms.Button();
            this.btnAA = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 31);
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
            this.btnSearch.Location = new System.Drawing.Point(460, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(330, 99);
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
            this.labelmodules.Location = new System.Drawing.Point(636, 99);
            this.labelmodules.Name = "labelmodules";
            this.labelmodules.Size = new System.Drawing.Size(77, 20);
            this.labelmodules.TabIndex = 3;
            this.labelmodules.Text = "Modules ";
            // 
            // comboBoxPrograms
            // 
            this.comboBoxPrograms.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxPrograms.FormattingEnabled = true;
            this.comboBoxPrograms.Location = new System.Drawing.Point(713, 99);
            this.comboBoxPrograms.Name = "comboBoxPrograms";
            this.comboBoxPrograms.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrograms.TabIndex = 4;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(102, 126);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(732, 270);
            this.dataGridViewStudents.TabIndex = 5;
            // 
            // btnMA
            // 
            this.btnMA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMA.ForeColor = System.Drawing.Color.Black;
            this.btnMA.Location = new System.Drawing.Point(102, 406);
            this.btnMA.Name = "btnMA";
            this.btnMA.Size = new System.Drawing.Size(111, 28);
            this.btnMA.TabIndex = 6;
            this.btnMA.Text = "Most Attendant";
            this.btnMA.UseVisualStyleBackColor = false;
            // 
            // btnNA
            // 
            this.btnNA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNA.Location = new System.Drawing.Point(513, 406);
            this.btnNA.Name = "btnNA";
            this.btnNA.Size = new System.Drawing.Size(111, 28);
            this.btnNA.TabIndex = 7;
            this.btnNA.Text = "Never Attended";
            this.btnNA.UseVisualStyleBackColor = true;
            // 
            // btnPA
            // 
            this.btnPA.BackColor = System.Drawing.Color.LightBlue;
            this.btnPA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPA.ForeColor = System.Drawing.Color.Black;
            this.btnPA.Location = new System.Drawing.Point(379, 406);
            this.btnPA.Name = "btnPA";
            this.btnPA.Size = new System.Drawing.Size(111, 28);
            this.btnPA.TabIndex = 8;
            this.btnPA.Text = "Poor Attendant";
            this.btnPA.UseVisualStyleBackColor = false;
            // 
            // btnAA
            // 
            this.btnAA.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAA.ForeColor = System.Drawing.Color.Black;
            this.btnAA.Location = new System.Drawing.Point(236, 406);
            this.btnAA.Name = "btnAA";
            this.btnAA.Size = new System.Drawing.Size(120, 28);
            this.btnAA.TabIndex = 9;
            this.btnAA.Text = "Average attendant";
            this.btnAA.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(38, 33);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(51, 25);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Lectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 475);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAA);
            this.Controls.Add(this.btnPA);
            this.Controls.Add(this.btnNA);
            this.Controls.Add(this.btnMA);
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
        private System.Windows.Forms.Button btnMA;
        private System.Windows.Forms.Button btnNA;
        private System.Windows.Forms.Button btnPA;
        private System.Windows.Forms.Button btnAA;
        private System.Windows.Forms.Button btnHome;
    }
}