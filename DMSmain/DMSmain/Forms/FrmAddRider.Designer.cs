namespace DMSmain.Forms
{
    partial class FrmAddRider
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.txtUsername = new BasicUserControls.CustomTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtEmail = new BasicUserControls.CustomTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txtCnic = new BasicUserControls.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new BasicUserControls.CustomTextBox();
            this.txtPassword = new BasicUserControls.CustomTextBox();
            this.txtName = new BasicUserControls.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(36, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 352);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Lavender;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.cmbArea);
            this.panel5.Controls.Add(this.txtUsername);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.txtEmail);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.txtCnic);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtPhoneNo);
            this.panel5.Controls.Add(this.txtPassword);
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(22, 89);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(693, 196);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(196, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Area";
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Items.AddRange(new object[] {
            "Chowk Yattemkhana",
            "Model Town",
            "Town Ship",
            "Green Town",
            "Shalimar Bagh Vicinity"});
            this.cmbArea.Location = new System.Drawing.Point(318, 154);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(121, 21);
            this.cmbArea.TabIndex = 16;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.defaultText = null;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtUsername.Location = new System.Drawing.Point(116, 96);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.sideImage = null;
            this.txtUsername.Size = new System.Drawing.Size(239, 51);
            this.txtUsername.TabIndex = 15;
            this.txtUsername.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtUsername.textBoxForeColor = System.Drawing.Color.Empty;
            this.txtUsername.textFont = null;
            this.txtUsername.UnderLineColor = System.Drawing.Color.Black;
            this.txtUsername.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Username";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Phone Number";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(7, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 40);
            this.button5.TabIndex = 5;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.defaultText = null;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtEmail.Location = new System.Drawing.Point(454, 56);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.sideImage = null;
            this.txtEmail.Size = new System.Drawing.Size(239, 51);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtEmail.textBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtEmail.textFont = null;
            this.txtEmail.UnderLineColor = System.Drawing.Color.Black;
            this.txtEmail.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(579, 153);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 40);
            this.button6.TabIndex = 4;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtCnic
            // 
            this.txtCnic.BackColor = System.Drawing.Color.Transparent;
            this.txtCnic.defaultText = null;
            this.txtCnic.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtCnic.Location = new System.Drawing.Point(454, 11);
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.sideImage = null;
            this.txtCnic.Size = new System.Drawing.Size(239, 51);
            this.txtCnic.TabIndex = 12;
            this.txtCnic.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtCnic.textBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCnic.textFont = null;
            this.txtCnic.UnderLineColor = System.Drawing.Color.Black;
            this.txtCnic.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "CNIC";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.txtPhoneNo.defaultText = null;
            this.txtPhoneNo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtPhoneNo.Location = new System.Drawing.Point(116, 50);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.sideImage = null;
            this.txtPhoneNo.Size = new System.Drawing.Size(239, 51);
            this.txtPhoneNo.TabIndex = 8;
            this.txtPhoneNo.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtPhoneNo.textBoxForeColor = System.Drawing.Color.Empty;
            this.txtPhoneNo.textFont = null;
            this.txtPhoneNo.UnderLineColor = System.Drawing.Color.Black;
            this.txtPhoneNo.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.defaultText = null;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtPassword.Location = new System.Drawing.Point(453, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.sideImage = null;
            this.txtPassword.Size = new System.Drawing.Size(240, 51);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtPassword.textBoxForeColor = System.Drawing.Color.Empty;
            this.txtPassword.textFont = null;
            this.txtPassword.UnderLineColor = System.Drawing.Color.Black;
            this.txtPassword.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.defaultText = null;
            this.txtName.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtName.Location = new System.Drawing.Point(116, 11);
            this.txtName.Name = "txtName";
            this.txtName.sideImage = null;
            this.txtName.Size = new System.Drawing.Size(239, 51);
            this.txtName.TabIndex = 5;
            this.txtName.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtName.textBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtName.textFont = null;
            this.txtName.UnderLineColor = System.Drawing.Color.Black;
            this.txtName.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Add Rider";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 10);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(390, 37);
            this.label7.TabIndex = 2;
            this.label7.Text = "Distribution Management System ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // FrmAddRider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.panel2);
            this.Name = "FrmAddRider";
            this.Text = "FrmAddRider";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddRider_FormClosed);
            this.Load += new System.EventHandler(this.FrmAddRider_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private BasicUserControls.CustomTextBox txtEmail;
        private System.Windows.Forms.Button button6;
        private BasicUserControls.CustomTextBox txtCnic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private BasicUserControls.CustomTextBox txtPhoneNo;
        private BasicUserControls.CustomTextBox txtPassword;
        private BasicUserControls.CustomTextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private BasicUserControls.CustomTextBox txtUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbArea;
    }
}