using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Antipaso_Activity10_SimpleApp
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           

            if (txtUsername.Text != null && txtPassword.Text != null && txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                try
                {
                    var cons2 = new System.IO.StreamWriter("C:\\" + txtUsername.Text + "\\login.ID");
                    cons2.Write(txtUsername.Text + "\n" + txtPassword.Text);
                    cons2.Close();
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    System.IO.Directory.CreateDirectory("C:\\" + txtUsername.Text);
                    var cons2 = new System.IO.StreamWriter("C:\\" + txtUsername.Text + "\\login.ID");
                    cons2.Write(txtPassword.Text + "\n" + txtPassword.Text);
                    cons2.Close();
                }
                MessageBox.Show("Successfully Register", "Register!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDiraApp frmDira = new frmDiraApp();
                frmDira.Show();

            }
            else
            {
                MessageBox.Show("Please Register your Username & Password", "ERROR!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmDiraApp diraApp = new frmDiraApp();
            diraApp.Show();
            this.Hide();
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
