using ElectricReg.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricReg
{
    public partial class Lecturer : Form
    {
        public Lecturer()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();  
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
        }
        
        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            if(textBoxemail.Text == "" || textBoxLecturerID.Text == "" || textBoxName.Text == "" || textBoxphone.Text == "")
            {
                MessageBox.Show("Please insert all required details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var model = new LecturerModel
            {
                Email = textBoxemail.Text,
                phoneNo = textBoxphone.Text,
                lecturerId = int.Parse(textBoxLecturerID.Text),
                LecturerName = textBoxName.Text
            };

            DatabaseService db = new DatabaseService();

            try {
                await db.getClient.From<LecturerModel>().Insert(model);
                this.Hide();
                Lectures lec = new Lectures();
                lec.ShowDialog();
            }

            catch (Exception error){
                MessageBox.Show(error.Message);
            }
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {

        }
    }
}
