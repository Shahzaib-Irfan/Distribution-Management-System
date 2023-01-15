namespace DMSmain.Forms
{
    partial class AddProduct
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
            this.Productpanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPerishible = new BasicUserControls.CustomTextBox();
            this.txtCategory = new BasicUserControls.CustomTextBox();
            this.txtID = new BasicUserControls.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStock = new BasicUserControls.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new BasicUserControls.CustomTextBox();
            this.txtproductname = new BasicUserControls.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Productpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Productpanel
            // 
            this.Productpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Productpanel.Controls.Add(this.button2);
            this.Productpanel.Controls.Add(this.panel2);
            this.Productpanel.Controls.Add(this.label11);
            this.Productpanel.Controls.Add(this.label12);
            this.Productpanel.Controls.Add(this.button1);
            this.Productpanel.Location = new System.Drawing.Point(39, 43);
            this.Productpanel.Name = "Productpanel";
            this.Productpanel.Size = new System.Drawing.Size(735, 352);
            this.Productpanel.TabIndex = 1;
            this.Productpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Productpanel_Paint);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(22, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.txtPerishible);
            this.panel2.Controls.Add(this.txtCategory);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtStock);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtproductname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(22, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 196);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtPerishible
            // 
            this.txtPerishible.BackColor = System.Drawing.Color.Transparent;
            this.txtPerishible.defaultText = null;
            this.txtPerishible.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtPerishible.Location = new System.Drawing.Point(436, 102);
            this.txtPerishible.Name = "txtPerishible";
            this.txtPerishible.sideImage = null;
            this.txtPerishible.Size = new System.Drawing.Size(239, 51);
            this.txtPerishible.TabIndex = 14;
            this.txtPerishible.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtPerishible.textBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPerishible.textFont = null;
            this.txtPerishible.UnderLineColor = System.Drawing.Color.Black;
            this.txtPerishible.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.Transparent;
            this.txtCategory.defaultText = null;
            this.txtCategory.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtCategory.Location = new System.Drawing.Point(436, 56);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.sideImage = null;
            this.txtCategory.Size = new System.Drawing.Size(239, 51);
            this.txtCategory.TabIndex = 13;
            this.txtCategory.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtCategory.textBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCategory.textFont = null;
            this.txtCategory.UnderLineColor = System.Drawing.Color.Black;
            this.txtCategory.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.defaultText = null;
            this.txtID.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtID.Location = new System.Drawing.Point(436, 13);
            this.txtID.Name = "txtID";
            this.txtID.sideImage = null;
            this.txtID.Size = new System.Drawing.Size(239, 51);
            this.txtID.TabIndex = 12;
            this.txtID.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtID.textBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtID.textFont = null;
            this.txtID.UnderLineColor = System.Drawing.Color.Black;
            this.txtID.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Perishable";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cateogry";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.Transparent;
            this.txtStock.defaultText = null;
            this.txtStock.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtStock.Location = new System.Drawing.Point(80, 109);
            this.txtStock.Name = "txtStock";
            this.txtStock.sideImage = null;
            this.txtStock.Size = new System.Drawing.Size(239, 51);
            this.txtStock.TabIndex = 8;
            this.txtStock.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtStock.textBoxForeColor = System.Drawing.Color.Empty;
            this.txtStock.textFont = null;
            this.txtStock.UnderLineColor = System.Drawing.Color.Black;
            this.txtStock.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.defaultText = null;
            this.txtPrice.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtPrice.Location = new System.Drawing.Point(79, 56);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.sideImage = null;
            this.txtPrice.Size = new System.Drawing.Size(240, 51);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtPrice.textBoxForeColor = System.Drawing.Color.Empty;
            this.txtPrice.textFont = null;
            this.txtPrice.UnderLineColor = System.Drawing.Color.Black;
            this.txtPrice.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // txtproductname
            // 
            this.txtproductname.BackColor = System.Drawing.Color.Transparent;
            this.txtproductname.defaultText = null;
            this.txtproductname.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtproductname.Location = new System.Drawing.Point(80, 13);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.sideImage = null;
            this.txtproductname.Size = new System.Drawing.Size(239, 51);
            this.txtproductname.TabIndex = 5;
            this.txtproductname.textBoxBackColor = System.Drawing.Color.Empty;
            this.txtproductname.textBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtproductname.textFont = null;
            this.txtproductname.UnderLineColor = System.Drawing.Color.Black;
            this.txtproductname.underlineFocusColor = System.Drawing.Color.LightYellow;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(243, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Add Product";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(151, 10);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(5);
            this.label12.Size = new System.Drawing.Size(390, 37);
            this.label12.TabIndex = 2;
            this.label12.Text = "Distribution Management System ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(607, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Productpanel);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddProduct_FormClosed);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.Productpanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Productpanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private BasicUserControls.CustomTextBox txtStock;
        private System.Windows.Forms.Label label3;
        private BasicUserControls.CustomTextBox txtPrice;
        private BasicUserControls.CustomTextBox txtproductname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private BasicUserControls.CustomTextBox txtPerishible;
        private BasicUserControls.CustomTextBox txtCategory;
        private BasicUserControls.CustomTextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}