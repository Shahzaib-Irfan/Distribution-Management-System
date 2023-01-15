namespace DMSmain.Forms
{
    partial class FrmUpdateProduct
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
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdatePerishible = new BasicUserControls.CustomTextBox();
            this.txtUpdateCategory = new BasicUserControls.CustomTextBox();
            this.txtUpdateID = new BasicUserControls.CustomTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpdateStock = new BasicUserControls.CustomTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdatePrice = new BasicUserControls.CustomTextBox();
            this.txtUpdatename = new BasicUserControls.CustomTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlUpdate.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUpdate.Controls.Add(this.button3);
            this.pnlUpdate.Controls.Add(this.panel3);
            this.pnlUpdate.Controls.Add(this.label15);
            this.pnlUpdate.Controls.Add(this.label16);
            this.pnlUpdate.Controls.Add(this.button4);
            this.pnlUpdate.Location = new System.Drawing.Point(33, 49);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(735, 352);
            this.pnlUpdate.TabIndex = 7;
            this.pnlUpdate.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUpdate_Paint);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(22, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtUpdatePerishible);
            this.panel3.Controls.Add(this.txtUpdateCategory);
            this.panel3.Controls.Add(this.txtUpdateID);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtUpdateStock);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtUpdatePrice);
            this.panel3.Controls.Add(this.txtUpdatename);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(22, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(693, 196);
            this.panel3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Perishable";
            // 
            // txtUpdatePerishible
            // 
            this.txtUpdatePerishible.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdatePerishible.defaultText = null;
            this.txtUpdatePerishible.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtUpdatePerishible.Location = new System.Drawing.Point(436, 102);
            this.txtUpdatePerishible.Name = "txtUpdatePerishible";
            this.txtUpdatePerishible.sideImage = null;
            this.txtUpdatePerishible.Size = new System.Drawing.Size(239, 51);
            this.txtUpdatePerishible.TabIndex = 14;
            this.txtUpdatePerishible.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtUpdatePerishible.textBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtUpdatePerishible.textFont = null;
            this.txtUpdatePerishible.UnderLineColor = System.Drawing.Color.Black;
            this.txtUpdatePerishible.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // txtUpdateCategory
            // 
            this.txtUpdateCategory.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateCategory.defaultText = null;
            this.txtUpdateCategory.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtUpdateCategory.Location = new System.Drawing.Point(436, 56);
            this.txtUpdateCategory.Name = "txtUpdateCategory";
            this.txtUpdateCategory.sideImage = null;
            this.txtUpdateCategory.Size = new System.Drawing.Size(239, 51);
            this.txtUpdateCategory.TabIndex = 13;
            this.txtUpdateCategory.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtUpdateCategory.textBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtUpdateCategory.textFont = null;
            this.txtUpdateCategory.UnderLineColor = System.Drawing.Color.Black;
            this.txtUpdateCategory.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateID.defaultText = null;
            this.txtUpdateID.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtUpdateID.Location = new System.Drawing.Point(436, 13);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.sideImage = null;
            this.txtUpdateID.Size = new System.Drawing.Size(239, 51);
            this.txtUpdateID.TabIndex = 12;
            this.txtUpdateID.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtUpdateID.textBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtUpdateID.textFont = null;
            this.txtUpdateID.UnderLineColor = System.Drawing.Color.Black;
            this.txtUpdateID.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(347, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cateogry";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(348, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "ID";
            // 
            // txtUpdateStock
            // 
            this.txtUpdateStock.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateStock.defaultText = null;
            this.txtUpdateStock.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtUpdateStock.Location = new System.Drawing.Point(80, 109);
            this.txtUpdateStock.Name = "txtUpdateStock";
            this.txtUpdateStock.sideImage = null;
            this.txtUpdateStock.Size = new System.Drawing.Size(239, 51);
            this.txtUpdateStock.TabIndex = 8;
            this.txtUpdateStock.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtUpdateStock.textBoxForeColor = System.Drawing.Color.Empty;
            this.txtUpdateStock.textFont = null;
            this.txtUpdateStock.UnderLineColor = System.Drawing.Color.Black;
            this.txtUpdateStock.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "Stock";
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdatePrice.defaultText = null;
            this.txtUpdatePrice.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtUpdatePrice.Location = new System.Drawing.Point(79, 56);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.sideImage = null;
            this.txtUpdatePrice.Size = new System.Drawing.Size(240, 51);
            this.txtUpdatePrice.TabIndex = 6;
            this.txtUpdatePrice.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtUpdatePrice.textBoxForeColor = System.Drawing.Color.Empty;
            this.txtUpdatePrice.textFont = null;
            this.txtUpdatePrice.UnderLineColor = System.Drawing.Color.Black;
            this.txtUpdatePrice.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // txtUpdatename
            // 
            this.txtUpdatename.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdatename.defaultText = null;
            this.txtUpdatename.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtUpdatename.Location = new System.Drawing.Point(80, 13);
            this.txtUpdatename.Name = "txtUpdatename";
            this.txtUpdatename.sideImage = null;
            this.txtUpdatename.Size = new System.Drawing.Size(239, 51);
            this.txtUpdatename.TabIndex = 5;
            this.txtUpdatename.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtUpdatename.textBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtUpdatename.textFont = null;
            this.txtUpdatename.UnderLineColor = System.Drawing.Color.Black;
            this.txtUpdatename.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 23);
            this.label13.TabIndex = 3;
            this.label13.Text = "Price";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 23);
            this.label14.TabIndex = 2;
            this.label14.Text = "Name";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(243, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 23);
            this.label15.TabIndex = 3;
            this.label15.Text = "Update Product";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(151, 10);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(5);
            this.label16.Size = new System.Drawing.Size(390, 37);
            this.label16.TabIndex = 2;
            this.label16.Text = "Distribution Management System ";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(607, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlUpdate);
            this.Name = "FrmUpdateProduct";
            this.Text = "FrmUpdateProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUpdateProduct_FormClosed);
            this.Load += new System.EventHandler(this.FrmUpdateProduct_Load);
            this.pnlUpdate.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private BasicUserControls.CustomTextBox txtUpdatePerishible;
        private BasicUserControls.CustomTextBox txtUpdateCategory;
        private BasicUserControls.CustomTextBox txtUpdateID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private BasicUserControls.CustomTextBox txtUpdateStock;
        private System.Windows.Forms.Label label10;
        private BasicUserControls.CustomTextBox txtUpdatePrice;
        private BasicUserControls.CustomTextBox txtUpdatename;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button4;
    }
}