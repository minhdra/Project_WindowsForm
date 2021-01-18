using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_WindowsForm
{
    public partial class Bai1_TH1 : Form
    {
        public Bai1_TH1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtYOB.Text != ""))
                MessageBox.Show("Name : " + txtName.Text + "\nAge : " + (DateTime.Now.Year - int.Parse(txtYOB.Text)));
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if ((int)e.KeyChar == 13)
                    txtYOB.Focus();
        }

        private void txtYOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(txtYOB.Text != "")
                if ((int)e.KeyChar == 13)
            {
                    //btnShow.Focus();
                if ((txtName.Text != "") && (txtYOB.Text != ""))
                    MessageBox.Show("Name : " + txtName.Text + "\nAge : " + (DateTime.Now.Year - int.Parse(txtYOB.Text)));
            }
            //else
            //{
            //        txtYOB.Focus();
            //        txtYOB.Clear();
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Focus();
            txtName.ResetText();
            txtYOB.ResetText();
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

        private void txtYOB_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Control ctr = (Control)sender;
            if(ctr.Text.Trim().Length > 0 
                && !char.IsDigit(ctr.Text,ctr.Text.Length - 1))
            {
                txtYOB.Focus();
                txtYOB.ResetText();
                errorProvider1.SetError(txtYOB, "This is not invalid number");
            }
            if (txtName.Text != "" && txtYOB.Text != "")
                btnShow.Enabled = true;
            else
                btnShow.Enabled = false;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(txtName.Text.Trim() == "")
            {
                txtName.Focus();
                txtName.Clear();
                errorProvider1.SetError(txtName, "Name is not empty");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtYOB_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if ((int.Parse(txtYOB.Text) < 1900) || (int.Parse(txtYOB.Text) > DateTime.Now.Year))
            {
                txtYOB.Focus();
                txtYOB.ResetText();
                errorProvider1.SetError(txtYOB, "This is not invalid number");
            }
        }
    }
}
