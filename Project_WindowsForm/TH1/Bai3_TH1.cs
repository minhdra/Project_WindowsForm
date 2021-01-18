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
    public partial class Bai3_TH1 : Form
    {
        public Bai3_TH1()
        {
            InitializeComponent();
        }

        private void lblNum1_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_Leave(object sender, EventArgs e)
        {
            //errorProvider1.Clear();
            //Control ctr = (Control)sender;
            //if (ctr.Text.Trim().Length > 0
            //    && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            //{
            //    txtNum1.Focus();
            //    txtNum1.ResetText();
            //    errorProvider1.SetError(txtNum1, "This is not invalid number");
            //}
        }

        private void txtNum2_Leave(object sender, EventArgs e)
        {
            //errorProvider1.Clear();
            //Control ctr = (Control)sender;
            //if (ctr.Text.Trim().Length > 0
            //    && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            //{
            //    txtNum2.Focus();
            //    txtNum2.ResetText();
            //    errorProvider1.SetError(txtNum2, "This is not invalid number");
            //}
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
                txtNum2.Focus();
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //rbCong.Checked = true;
        }

        private void rbCong_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Text = (float.Parse(txtNum1.Text) + float.Parse(txtNum2.Text)).ToString();
        }

        private void rbTru_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Text = (float.Parse(txtNum1.Text) - float.Parse(txtNum2.Text)).ToString();
        }

        private void rbNhan_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Text = (float.Parse(txtNum1.Text) * float.Parse(txtNum2.Text)).ToString();
        }

        private void rbChia_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Text = (float.Parse(txtNum1.Text) / float.Parse(txtNum2.Text)).ToString();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0
                && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                txtNum1.Focus();
                txtNum1.ResetText();
                errorProvider1.SetError(txtNum1, "This is not invalid number");
            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0
                && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                txtNum2.Focus();
                txtNum2.ResetText();
                errorProvider1.SetError(txtNum2, "This is not invalid number");
            }
        }
    }
}
