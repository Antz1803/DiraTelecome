using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Antipaso_Activity10_SimpleApp
{
    public partial class frmDiraApp : Form
    {
  
        public frmDiraApp()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != null && txtPassword.Text != null && txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {

                try
                {
                    var cons = new System.IO.StreamReader("C:\\" + txtUsername.Text + "\\login.ID");

                    cons.Close();

                    frmDiraHome dirahome = new frmDiraHome();
                    dirahome.Show();
                    this.Hide();
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    MessageBox.Show("The User doesn't exist!", "Error!");
                }
            }
            else
            {
                MessageBox.Show("The User doesn't exist!", "Error!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            //Show Password
            if (chkshowpassword.Checked == true)
            {
                txtPassword.PasswordChar = char.MinValue;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }

        }
    }
}
