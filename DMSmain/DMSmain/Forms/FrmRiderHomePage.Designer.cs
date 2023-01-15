namespace DMSmain.Forms
{
    partial class FrmRiderHomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuelLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuelBIllsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlShopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(321, 160);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(142, 23);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Rider Module";
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(212, 97);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(5);
            this.lblHeader.Size = new System.Drawing.Size(390, 37);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Distribution Management System ";
            this.lblHeader.DoubleClick += new System.EventHandler(this.s);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem,
            this.fuelLogsToolStripMenuItem,
            this.navigateRouteToolStripMenuItem,
            this.fuelBIllsToolStripMenuItem,
            this.addShopToolStripMenuItem,
            this.controlShopsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 20, 0, 20);
            this.menuStrip1.Size = new System.Drawing.Size(800, 65);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrderToolStripMenuItem,
            this.ordersGridToolStripMenuItem});
            this.ordersToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // addOrderToolStripMenuItem
            // 
            this.addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
            this.addOrderToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.addOrderToolStripMenuItem.Text = "Add Order";
            this.addOrderToolStripMenuItem.Click += new System.EventHandler(this.addOrderToolStripMenuItem_Click);
            // 
            // ordersGridToolStripMenuItem
            // 
            this.ordersGridToolStripMenuItem.Name = "ordersGridToolStripMenuItem";
            this.ordersGridToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.ordersGridToolStripMenuItem.Text = "Cart";
            this.ordersGridToolStripMenuItem.Click += new System.EventHandler(this.ordersGridToolStripMenuItem_Click);
            // 
            // fuelLogsToolStripMenuItem
            // 
            this.fuelLogsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelLogsToolStripMenuItem.Name = "fuelLogsToolStripMenuItem";
            this.fuelLogsToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.fuelLogsToolStripMenuItem.Text = "Fuel Logs";
            this.fuelLogsToolStripMenuItem.Click += new System.EventHandler(this.fuelLogsToolStripMenuItem_Click);
            this.fuelLogsToolStripMenuItem.DoubleClick += new System.EventHandler(this.fuelLogsToolStripMenuItem_Click);
            // 
            // navigateRouteToolStripMenuItem
            // 
            this.navigateRouteToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigateRouteToolStripMenuItem.Name = "navigateRouteToolStripMenuItem";
            this.navigateRouteToolStripMenuItem.Size = new System.Drawing.Size(137, 25);
            this.navigateRouteToolStripMenuItem.Text = "Navigate Route";
            this.navigateRouteToolStripMenuItem.Click += new System.EventHandler(this.navigateRouteToolStripMenuItem_Click);
            // 
            // fuelBIllsToolStripMenuItem
            // 
            this.fuelBIllsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelBIllsToolStripMenuItem.Name = "fuelBIllsToolStripMenuItem";
            this.fuelBIllsToolStripMenuItem.Size = new System.Drawing.Size(111, 25);
            this.fuelBIllsToolStripMenuItem.Text = "Complaints";
            this.fuelBIllsToolStripMenuItem.Click += new System.EventHandler(this.fuelBIllsToolStripMenuItem_Click);
            // 
            // addShopToolStripMenuItem
            // 
            this.addShopToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addShopToolStripMenuItem.Name = "addShopToolStripMenuItem";
            this.addShopToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.addShopToolStripMenuItem.Text = "Add Shop";
            this.addShopToolStripMenuItem.Click += new System.EventHandler(this.addShopToolStripMenuItem_Click);
            // 
            // controlShopsToolStripMenuItem
            // 
            this.controlShopsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlShopsToolStripMenuItem.Name = "controlShopsToolStripMenuItem";
            this.controlShopsToolStripMenuItem.Size = new System.Drawing.Size(129, 25);
            this.controlShopsToolStripMenuItem.Text = "Control Shops";
            this.controlShopsToolStripMenuItem.Click += new System.EventHandler(this.controlShopsToolStripMenuItem_Click);
            // 
            // FrmRiderHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRiderHomePage";
            this.Text = "FrmRiderHomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRiderHomePage_FormClosed);
            this.Load += new System.EventHandler(this.FrmRiderHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuelLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigateRouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuelBIllsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlShopsToolStripMenuItem;
    }
}