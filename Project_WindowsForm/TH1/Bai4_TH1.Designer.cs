
namespace Project_WindowsForm.TH1
{
    partial class Bai4_TH1
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.rabRed = new System.Windows.Forms.RadioButton();
            this.gbFont = new System.Windows.Forms.GroupBox();
            this.lblBy = new System.Windows.Forms.Label();
            this.txtBy = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.rabGreen = new System.Windows.Forms.RadioButton();
            this.rabBlue = new System.Windows.Forms.RadioButton();
            this.rabBlack = new System.Windows.Forms.RadioButton();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkIlatic = new System.Windows.Forms.CheckBox();
            this.chkU = new System.Windows.Forms.CheckBox();
            this.gbColor.SuspendLayout();
            this.gbFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nhap Ten";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.rabBlack);
            this.gbColor.Controls.Add(this.rabBlue);
            this.gbColor.Controls.Add(this.rabGreen);
            this.gbColor.Controls.Add(this.rabRed);
            this.gbColor.Location = new System.Drawing.Point(16, 62);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(82, 150);
            this.gbColor.TabIndex = 2;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color";
            // 
            // rabRed
            // 
            this.rabRed.Checked = true;
            this.rabRed.ForeColor = System.Drawing.Color.Red;
            this.rabRed.Location = new System.Drawing.Point(6, 19);
            this.rabRed.Name = "rabRed";
            this.rabRed.Size = new System.Drawing.Size(68, 24);
            this.rabRed.TabIndex = 0;
            this.rabRed.TabStop = true;
            this.rabRed.Text = "Red";
            // 
            // gbFont
            // 
            this.gbFont.Controls.Add(this.chkU);
            this.gbFont.Controls.Add(this.chkIlatic);
            this.gbFont.Controls.Add(this.chkBold);
            this.gbFont.Location = new System.Drawing.Point(151, 62);
            this.gbFont.Name = "gbFont";
            this.gbFont.Size = new System.Drawing.Size(116, 103);
            this.gbFont.TabIndex = 3;
            this.gbFont.TabStop = false;
            this.gbFont.Text = "Font";
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Location = new System.Drawing.Point(17, 288);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(65, 13);
            this.lblBy.TabIndex = 4;
            this.lblBy.Text = "Lap trinh boi";
            // 
            // txtBy
            // 
            this.txtBy.Enabled = false;
            this.txtBy.Location = new System.Drawing.Point(88, 285);
            this.txtBy.Name = "txtBy";
            this.txtBy.Size = new System.Drawing.Size(201, 20);
            this.txtBy.TabIndex = 5;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(214, 324);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Thoat";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // rabGreen
            // 
            this.rabGreen.ForeColor = System.Drawing.Color.Red;
            this.rabGreen.Location = new System.Drawing.Point(6, 49);
            this.rabGreen.Name = "rabGreen";
            this.rabGreen.Size = new System.Drawing.Size(68, 24);
            this.rabGreen.TabIndex = 0;
            this.rabGreen.Text = "Green";
            // 
            // rabBlue
            // 
            this.rabBlue.ForeColor = System.Drawing.Color.Red;
            this.rabBlue.Location = new System.Drawing.Point(6, 79);
            this.rabBlue.Name = "rabBlue";
            this.rabBlue.Size = new System.Drawing.Size(68, 24);
            this.rabBlue.TabIndex = 0;
            this.rabBlue.Text = "Blue";
            // 
            // rabBlack
            // 
            this.rabBlack.ForeColor = System.Drawing.Color.Black;
            this.rabBlack.Location = new System.Drawing.Point(6, 109);
            this.rabBlack.Name = "rabBlack";
            this.rabBlack.Size = new System.Drawing.Size(68, 24);
            this.rabBlack.TabIndex = 0;
            this.rabBlack.Text = "Black";
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(7, 20);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(60, 17);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "In Dam";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // chkIlatic
            // 
            this.chkIlatic.AutoSize = true;
            this.chkIlatic.Location = new System.Drawing.Point(7, 44);
            this.chkIlatic.Name = "chkIlatic";
            this.chkIlatic.Size = new System.Drawing.Size(76, 17);
            this.chkIlatic.TabIndex = 1;
            this.chkIlatic.Text = "In nghieng";
            this.chkIlatic.UseVisualStyleBackColor = true;
            // 
            // chkU
            // 
            this.chkU.AutoSize = true;
            this.chkU.Location = new System.Drawing.Point(7, 68);
            this.chkU.Name = "chkU";
            this.chkU.Size = new System.Drawing.Size(79, 17);
            this.chkU.TabIndex = 2;
            this.chkU.Text = "Gach chan";
            this.chkU.UseVisualStyleBackColor = true;
            // 
            // Bai4_TH1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 370);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.txtBy);
            this.Controls.Add(this.lblBy);
            this.Controls.Add(this.gbFont);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Bai4_TH1";
            this.Text = "Bai4_TH1";
            this.gbColor.ResumeLayout(false);
            this.gbFont.ResumeLayout(false);
            this.gbFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.RadioButton rabRed;
        private System.Windows.Forms.GroupBox gbFont;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.TextBox txtBy;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RadioButton rabBlack;
        private System.Windows.Forms.RadioButton rabBlue;
        private System.Windows.Forms.RadioButton rabGreen;
        private System.Windows.Forms.CheckBox chkU;
        private System.Windows.Forms.CheckBox chkIlatic;
        private System.Windows.Forms.CheckBox chkBold;
    }
}