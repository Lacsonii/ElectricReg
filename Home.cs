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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn sign = new SignIn();
            sign.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lecturer lecSignUp = new Lecturer();
            lecSignUp.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Server Name or IP Address was not found. Please contact your system Administrator", "Electric Register", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            this.Hide();
            connection addconn = new connection();
            addconn.ShowDialog();
        }
    }
}
