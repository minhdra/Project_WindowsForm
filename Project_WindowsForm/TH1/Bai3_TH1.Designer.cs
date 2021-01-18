
namespace Project_WindowsForm.TH1
{
    partial class Bai3_TH1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.gbPheptinh = new System.Windows.Forms.GroupBox();
            this.rbChia = new System.Windows.Forms.RadioButton();
            this.rbNhan = new System.Windows.Forms.RadioButton();
            this.rbTru = new System.Windows.Forms.RadioButton();
            this.rbCong = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPheptinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(62, 39);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(38, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Num 1";
            this.lblNum1.Click += new System.EventHandler(this.lblNum1_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(106, 36);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(294, 20);
            this.txtNum1.TabIndex = 1;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            this.txtNum1.Leave += new System.EventHandler(this.txtNum1_Leave);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(62, 91);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(38, 13);
            this.lblNum2.TabIndex = 0;
            this.lblNum2.Text = "Num 2";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(106, 88);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(294, 20);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum2_KeyPress);
            this.txtNum2.Leave += new System.EventHandler(this.txtNum2_Leave);
            // 
            // gbPheptinh
            // 
            this.gbPheptinh.Controls.Add(this.rbChia);
            this.gbPheptinh.Controls.Add(this.rbNhan);
            this.gbPheptinh.Controls.Add(this.rbTru);
            this.gbPheptinh.Controls.Add(this.rbCong);
            this.gbPheptinh.Location = new System.Drawing.Point(67, 140);
            this.gbPheptinh.Name = "gbPheptinh";
            this.gbPheptinh.Size = new System.Drawing.Size(333, 55);
            this.gbPheptinh.TabIndex = 2;
            this.gbPheptinh.TabStop = false;
            this.gbPheptinh.Text = "Phep tinh";
            // 
            // rbChia
            // 
            this.rbChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChia.Location = new System.Drawing.Point(251, 19);
            this.rbChia.Name = "rbChia";
            this.rbChia.Size = new System.Drawing.Size(76, 24);
            this.rbChia.TabIndex = 0;
            this.rbChia.Text = "Chia";
            this.rbChia.CheckedChanged += new System.EventHandler(this.rbChia_CheckedChanged);
            // 
            // rbNhan
            // 
            this.rbNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNhan.Location = new System.Drawing.Point(169, 19);
            this.rbNhan.Name = "rbNhan";
            this.rbNhan.Size = new System.Drawing.Size(65, 24);
            this.rbNhan.TabIndex = 0;
            this.rbNhan.Text = "Nhan";
            this.rbNhan.CheckedChanged += new System.EventHandler(this.rbNhan_CheckedChanged);
            // 
            // rbTru
            // 
            this.rbTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTru.Location = new System.Drawing.Point(86, 19);
            this.rbTru.Name = "rbTru";
            this.rbTru.Size = new System.Drawing.Size(53, 24);
            this.rbTru.TabIndex = 0;
            this.rbTru.Text = "Tru";
            this.rbTru.CheckedChanged += new System.EventHandler(this.rbTru_CheckedChanged);
            // 
            // rbCong
            // 
            this.rbCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCong.Location = new System.Drawing.Point(6, 19);
            this.rbCong.Name = "rbCong";
            this.rbCong.Size = new System.Drawing.Size(60, 24);
            this.rbCong.TabIndex = 0;
            this.rbCong.Text = "Cong";
            this.rbCong.CheckedChanged += new System.EventHandler(this.rbCong_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(62, 242);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result";
            this.lblResult.Click += new System.EventHandler(this.lblNum1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(106, 239);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(294, 20);
            this.txtResult.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Bai3_TH1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 323);
            this.Controls.Add(this.gbPheptinh);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum1);
            this.Name = "Bai3_TH1";
            this.Text = "Bai3_TH1";
            this.gbPheptinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.GroupBox gbPheptinh;
        private System.Windows.Forms.RadioButton rbCong;
        private System.Windows.Forms.RadioButton rbChia;
        private System.Windows.Forms.RadioButton rbNhan;
        private System.Windows.Forms.RadioButton rbTru;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}