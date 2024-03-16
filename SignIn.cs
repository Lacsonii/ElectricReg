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
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                AuthRepository authRepository = new AuthRepository();
                authRepository.SignIn(textBoxEmail.Text, textBoxpass.Text);
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
