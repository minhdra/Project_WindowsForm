using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_WindowsForm.TH1
{
    public partial class Bai2_TH1 : Form
    {
        public Bai2_TH1()
        {
            InitializeComponent();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (txtA.Text != "" && txtB.Text != "")
                btnResult.Enabled = true;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (txtA.Text != "" && txtB.Text != "")
            { 
                txtResult.Text = (-float.Parse(txtB.Text)/float.Parse(txtA.Text) ).ToString();
                if (txtA.Text == "0")
                    txtResult.Text = "Vo nghiem";
                else if (txtA.Text == "0" && txtB.Text == "0")
                    txtResult.Text = "Vo so nghiem";
                else
                {
                    txtResult.Text = "Phuong trinh co 1 nghiem : " + txtResult.Text;
                }
                btnResult.Enabled = false;
            }
        }

        private void txtA_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0
                && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                txtA.Focus();
                txtA.ResetText();
                errorProvider1.SetError(txtA, "This is not invalid number");
            }
        }

        private void txtB_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0
                && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                txtB.Focus();
                txtB.ResetText();
                errorProvider1.SetError(txtB, "This is not invalid number");
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
                txtB.Focus();
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
                btnResult.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Focus();
            txtA.ResetText();
            txtB.ResetText();
            txtResult.ResetText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want exit?",
                "Yes or No",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
                Environment.Exit(1);
            }
        }
    }
}
