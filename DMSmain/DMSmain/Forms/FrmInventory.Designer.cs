namespace DMSmain.Forms
{
    partial class FrmInventory
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
            this.PnlView = new System.Windows.Forms.Panel();
            this.GridViewProduct = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.PnlView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlView
            // 
            this.PnlView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnlView.Controls.Add(this.GridViewProduct);
            this.PnlView.Controls.Add(this.label19);
            this.PnlView.Controls.Add(this.label20);
            this.PnlView.Location = new System.Drawing.Point(45, 26);
            this.PnlView.Name = "PnlView";
            this.PnlView.Size = new System.Drawing.Size(710, 387);
            this.PnlView.TabIndex = 3;
            this.PnlView.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlView_Paint);
            // 
            // GridViewProduct
            // 
            this.GridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.Delete});
            this.GridViewProduct.Location = new System.Drawing.Point(52, 123);
            this.GridViewProduct.Name = "GridViewProduct";
            this.GridViewProduct.Size = new System.Drawing.Size(601, 246);
            this.GridViewProduct.TabIndex = 23;
            this.GridViewProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewProduct_CellContentClick);
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 48;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 510;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(274, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(187, 23);
            this.label19.TabIndex = 21;
            this.label19.Text = "Product Dashboard";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(160, 11);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(5);
            this.label20.Size = new System.Drawing.Size(390, 37);
            this.label20.TabIndex = 20;
            this.label20.Text = "Distribution Management System ";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(45, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 31);
            this.button3.TabIndex = 6;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PnlView);
            this.Name = "FrmInventory";
            this.Text = "FrmInventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInventory_FormClosed);
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            this.PnlView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlView;
        private System.Windows.Forms.DataGridView GridViewProduct;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button button3;
    }
}