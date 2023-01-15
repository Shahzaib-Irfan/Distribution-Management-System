namespace DMSmain.Forms
{
    partial class FrmOrders
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
            this.button1 = new System.Windows.Forms.Button();
            this.pnlOrderStatus = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRiderArea = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAdresses = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblBill = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewOrderGV = new System.Windows.Forms.DataGridView();
            this.pnlOrderStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrderGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlOrderStatus
            // 
            this.pnlOrderStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlOrderStatus.Controls.Add(this.label6);
            this.pnlOrderStatus.Controls.Add(this.lblRiderArea);
            this.pnlOrderStatus.Controls.Add(this.label5);
            this.pnlOrderStatus.Controls.Add(this.label4);
            this.pnlOrderStatus.Controls.Add(this.cmbAdresses);
            this.pnlOrderStatus.Controls.Add(this.button2);
            this.pnlOrderStatus.Controls.Add(this.lblBill);
            this.pnlOrderStatus.Controls.Add(this.label3);
            this.pnlOrderStatus.Controls.Add(this.ViewOrderGV);
            this.pnlOrderStatus.Controls.Add(this.label1);
            this.pnlOrderStatus.Controls.Add(this.label2);
            this.pnlOrderStatus.Location = new System.Drawing.Point(12, 12);
            this.pnlOrderStatus.Name = "pnlOrderStatus";
            this.pnlOrderStatus.Size = new System.Drawing.Size(776, 411);
            this.pnlOrderStatus.TabIndex = 5;
            this.pnlOrderStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOrderStatus_Paint);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(603, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rs";
            // 
            // lblRiderArea
            // 
            this.lblRiderArea.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiderArea.Location = new System.Drawing.Point(349, 380);
            this.lblRiderArea.Name = "lblRiderArea";
            this.lblRiderArea.Size = new System.Drawing.Size(336, 23);
            this.lblRiderArea.TabIndex = 10;
            this.lblRiderArea.Text = "XYZ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rider Area: ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbAdresses
            // 
            this.cmbAdresses.FormattingEnabled = true;
            this.cmbAdresses.Location = new System.Drawing.Point(595, 223);
            this.cmbAdresses.Name = "cmbAdresses";
            this.cmbAdresses.Size = new System.Drawing.Size(166, 21);
            this.cmbAdresses.TabIndex = 7;
            this.cmbAdresses.SelectedIndexChanged += new System.EventHandler(this.cmbAdresses_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(632, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Place Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblBill
            // 
            this.lblBill.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(676, 130);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(97, 23);
            this.lblBill.TabIndex = 6;
            this.lblBill.Text = "00";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(603, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bill";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cart";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 10);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(390, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distribution Management System ";
            // 
            // ViewOrderGV
            // 
            this.ViewOrderGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewOrderGV.Location = new System.Drawing.Point(3, 88);
            this.ViewOrderGV.Name = "ViewOrderGV";
            this.ViewOrderGV.Size = new System.Drawing.Size(586, 270);
            this.ViewOrderGV.TabIndex = 4;
            this.ViewOrderGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewOrderGV_CellContentClick);
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlOrderStatus);
            this.Name = "FrmOrders";
            this.Text = "FrmOrders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOrders_FormClosed);
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            this.pnlOrderStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrderGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlOrderStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.ComboBox cmbAdresses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRiderArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ViewOrderGV;
    }
}