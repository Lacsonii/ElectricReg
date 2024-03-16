using ElectricReg.Repository;
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
    public partial class SignIn : Form
    {
        AuthRepository authRepository = new AuthRepository();
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                authRepository.SignIn(textBoxEmail.Text, textBoxpass.Text);
                Lectures lectures = new Lectures();
                lectures.Show();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            this.Hide();
            Lecturer lc = new Lecturer();
            lc.ShowDialog();

        }

        private void SignIn_Load(object sender, EventArgs e)
        {


        }
    }
}
