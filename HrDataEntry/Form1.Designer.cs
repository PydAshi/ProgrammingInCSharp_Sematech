namespace HrDataEntry
{
    partial class frmHrsInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            button1 = new Button();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblMobileNo = new Label();
            lblNationalCode = new Label();
            lblSex = new Label();
            txtMobileNo = new TextBox();
            txtNationalCode = new TextBox();
            rdbMale = new RadioButton();
            rdbFemale = new RadioButton();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.Location = new Point(98, 379);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "ثبت";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(389, 50);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(27, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "نام";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(98, 43);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(190, 27);
            txtFirstName.TabIndex = 2;
            txtFirstName.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(256, 379);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "انصراف";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(357, 99);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(90, 20);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "نام خانوادگی";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(98, 92);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(190, 27);
            txtLastName.TabIndex = 4;
            txtLastName.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMobileNo
            // 
            lblMobileNo.AutoSize = true;
            lblMobileNo.Location = new Point(342, 162);
            lblMobileNo.Name = "lblMobileNo";
            lblMobileNo.Size = new Size(120, 20);
            lblMobileNo.TabIndex = 5;
            lblMobileNo.Text = "شماره تلفن همراه";
            // 
            // lblNationalCode
            // 
            lblNationalCode.AutoSize = true;
            lblNationalCode.Location = new Point(374, 235);
            lblNationalCode.Name = "lblNationalCode";
            lblNationalCode.Size = new Size(56, 20);
            lblNationalCode.TabIndex = 7;
            lblNationalCode.Text = "کد ملی";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Location = new Point(375, 303);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(55, 20);
            lblSex.TabIndex = 9;
            lblSex.Text = "جنسیت";
            // 
            // txtMobileNo
            // 
            txtMobileNo.Location = new Point(98, 155);
            txtMobileNo.Name = "txtMobileNo";
            txtMobileNo.Size = new Size(190, 27);
            txtMobileNo.TabIndex = 6;
            txtMobileNo.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(98, 228);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(190, 27);
            txtNationalCode.TabIndex = 8;
            txtNationalCode.TextAlign = HorizontalAlignment.Right;
            txtNationalCode.KeyPress += txtNationalCode_KeyPress;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(241, 299);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(52, 24);
            rdbMale.TabIndex = 10;
            rdbMale.TabStop = true;
            rdbMale.Text = "مرد";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(163, 299);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(46, 24);
            rdbFemale.TabIndex = 11;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "زن";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // frmHrsInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 451);
            Controls.Add(rdbFemale);
            Controls.Add(rdbMale);
            Controls.Add(txtNationalCode);
            Controls.Add(txtMobileNo);
            Controls.Add(lblSex);
            Controls.Add(lblNationalCode);
            Controls.Add(lblMobileNo);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(button1);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmHrsInfo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hrs Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Button button1;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblMobileNo;
        private Label lblNationalCode;
        private Label lblSex;
        private TextBox txtMobileNo;
        private TextBox txtNationalCode;
        private RadioButton rdbMale;
        private RadioButton rdbFemale;

    }
}