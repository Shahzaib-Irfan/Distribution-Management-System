namespace DMSmain.Forms
{
    partial class Email
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new BasicUserControls.CustomTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(76, 9);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(5);
            this.label12.Size = new System.Drawing.Size(390, 37);
            this.label12.TabIndex = 3;
            this.label12.Text = "Distribution Management System ";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(190, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Email Platform";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "From Admins:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Afraz,Hamza,Shahzaib";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "To Customer\'s Email:";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerEmail.defaultText = null;
            this.txtCustomerEmail.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtCustomerEmail.Location = new System.Drawing.Point(208, 170);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.sideImage = null;
            this.txtCustomerEmail.Size = new System.Drawing.Size(239, 51);
            this.txtCustomerEmail.TabIndex = 8;
            this.txtCustomerEmail.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtCustomerEmail.textBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCustomerEmail.textFont = null;
            this.txtCustomerEmail.UnderLineColor = System.Drawing.Color.Black;
            this.txtCustomerEmail.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(451, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(571, 306);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Name = "Email";
            this.Text = "Email";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Email_FormClosed);
            this.Load += new System.EventHandler(this.Email_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private BasicUserControls.CustomTextBox txtCustomerEmail;
        private System.Windows.Forms.Button button1;
    }
}