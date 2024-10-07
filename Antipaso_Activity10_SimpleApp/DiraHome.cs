using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antipaso_Activity10_SimpleApp
{
    public partial class frmDiraHome : Form
    {
        public frmDiraHome()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Button have an animation Information,Buy Load,Free Game,Promo List
        private void btnInformation_Click(object sender, EventArgs e)
        {
            pnlinformation1.Visible = true; 
            pnlbuyload2.Visible = !true;
            pnlPromoLoad.Visible = !true; //


            pnlbackgdes1.BackColor = Color.Green;
            pnlbackgdes2.BackColor = Color.DimGray;
            pnlbackgdes3.BackColor = Color.DimGray;
            pnlbackgdes4.BackColor = Color.DimGray;

        }

        private void btnBuyload_Click(object sender, EventArgs e)
        {
            pnlPromoLoad.Visible = true; //
            pnlbuyload2.Visible = !true;
            pnlinformation1.Visible = !true;


            pnlbackgdes1.BackColor = Color.DimGray;
            pnlbackgdes2.BackColor = Color.Green;
            pnlbackgdes3.BackColor = Color.DimGray;
            pnlbackgdes4.BackColor = Color.DimGray;
        }

        private void btnFreeGame_Click(object sender, EventArgs e)
        {
            //pnlinformation1.Visible = !true;
            //pnlbuyload2.Visible = !true;
            //pnlPromoLoad.Visible = !true; //

            FreeGame freeGame = new FreeGame();
            freeGame.Show();
            this.Hide();
            pnlbackgdes1.BackColor = Color.DimGray;
            pnlbackgdes2.BackColor = Color.DimGray;
            pnlbackgdes3.BackColor = Color.DimGray;
            pnlbackgdes4.BackColor = Color.Green;
        }
        private void btnPromoList_Click(object sender, EventArgs e)
        {
            pnlbuyload2.Visible = true; //
            pnlPromoLoad.Visible = !true; //
            pnlinformation1.Visible = !true; //
            

            pnlbackgdes1.BackColor = Color.DimGray;
            pnlbackgdes2.BackColor = Color.DimGray;
            pnlbackgdes3.BackColor = Color.Green;
            pnlbackgdes4.BackColor = Color.DimGray;
        }

        private void frmDiraHome_Load(object sender, EventArgs e)
        {
            pnlinformation1.Visible = !true;
            pnlbuyload2.Visible = !true;
            pnlPromoLoad.Visible = !true; //



            pnlbackgdes1.BackColor = Color.DimGray;
            pnlbackgdes2.BackColor = Color.DimGray;
            pnlbackgdes3.BackColor = Color.DimGray;
            pnlbackgdes4.BackColor = Color.DimGray;

            pnlbuy1.BackColor = Color.DimGray;
            pnlbuy2.BackColor = Color.DimGray;
            pnlbuy3.BackColor = Color.DimGray;
            pnlbuy4.BackColor = Color.DimGray;
            pnlbuy5.BackColor = Color.DimGray;

        }
        #endregion

        #region Radio button have an animation on my Buy Load
        private void rbtnLoad1_CheckedChanged(object sender, EventArgs e)
        {
            pnlbuy1.BackColor = Color.Orange;
            pnlbuy2.BackColor = Color.DimGray;
            pnlbuy3.BackColor = Color.DimGray;
            pnlbuy4.BackColor = Color.DimGray;
            pnlbuy5.BackColor = Color.DimGray;
        }

        private void rbtnLoad2_CheckedChanged(object sender, EventArgs e)
        {
            pnlbuy1.BackColor = Color.DimGray;
            pnlbuy2.BackColor = Color.Orange;
            pnlbuy3.BackColor = Color.DimGray;
            pnlbuy4.BackColor = Color.DimGray;
            pnlbuy5.BackColor = Color.DimGray;
        }

        private void rbtnLoad3_CheckedChanged(object sender, EventArgs e)
        {
            pnlbuy1.BackColor = Color.DimGray;
            pnlbuy2.BackColor = Color.DimGray;
            pnlbuy3.BackColor = Color.Orange;
            pnlbuy4.BackColor = Color.DimGray;
            pnlbuy5.BackColor = Color.DimGray;
        }

        private void rbtnLoad4_CheckedChanged(object sender, EventArgs e)
        {
            pnlbuy1.BackColor = Color.DimGray;
            pnlbuy2.BackColor = Color.DimGray;
            pnlbuy3.BackColor = Color.DimGray;
            pnlbuy4.BackColor = Color.Orange; 
            pnlbuy5.BackColor = Color.DimGray;
        }
        #endregion

        private void btnRegisterLoad_Click(object sender, EventArgs e)
        {
            pnlbuy1.BackColor = Color.DimGray;
            pnlbuy2.BackColor = Color.DimGray;
            pnlbuy3.BackColor = Color.DimGray;
            pnlbuy4.BackColor = Color.DimGray;
            pnlbuy5.BackColor = Color.Green;

            if (rbtnLoad1.Checked)
            {
                MessageBox.Show(txtNumber.Text +"\n\r" + "You have Successfully Loaded on DIRA LEVEL-UP99","Successfully Loaded",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (rbtnLoad2.Checked)
            {
                MessageBox.Show(txtNumber.Text + "\n\r" + "You have Successfully Loaded on DIRA LEVEL-UP199", "Successfully Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rbtnLoad3.Checked)
            {
                MessageBox.Show(txtNumber.Text + "\n\r" + "You have Successfully Loaded on DIRA LEVEL-UP50", "Successfully Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rbtnLoad4.Checked)
            {
                MessageBox.Show(txtNumber.Text + "\n\r" + "You have Successfully Loaded on DIRA LEVEL-UP20", "Successfully Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            if(txtAddList.Text == string.Empty)
            {
                MessageBox.Show("Input cannot be empty","ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (Convert.ToInt32(txtAddList.Text) > 1000)
            {
                MessageBox.Show("Input cannot exceed 1000", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txtAddList.Text) < 5)
            {
                MessageBox.Show("Input must exceed 5", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clxListResult.Items.Add(txtAddList.Text);
                txtAddList.Text = string.Empty;
            }
        }
        private void btnclearlist_Click(object sender, EventArgs e)
        {
            clxListResult.Items.Remove(clxListResult.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int cons1, cons2, total;
            cons1 = int.Parse(txtamount.Text);
            cons2 = int.Parse(clxListResult.Text);

            total = cons1 - cons2; 

            MessageBox.Show(txtYourNumber.Text + "\n\r" + "You have Successfully Loaded on DIRA Load" + clxListResult.Text + "\n" +"Your Change " + total, "Successfully Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String info1,info2, info3, info4, info5;
            info1 = "Name: " + txtFirstName.Text + " " + txtMiddleInitial.Text + " " +
                txtLastName.Text;
            info2 = "\n" + "Gender: " + cbxGender.Text;
            if (chkSingle.Checked)
            {
                info3 = "\n" + "Civil Status: Single";
            }
            else if (chkmarried.Checked)
            {
                info3 = "\n" + "Civil Status: Married";
            }
            else 
            {
                info3 = "\n" + "Civil Status: Divorce";
            }

            info4 = "\n" + "Date of birth: " + txtdateofbirth.Text;
            info5 = "\n" + "Email address: " + txtemailaddress.Text;

            lblresultinfo.Text = info1 + info2 + info3 + info4 +info5;

        }


    }
}
