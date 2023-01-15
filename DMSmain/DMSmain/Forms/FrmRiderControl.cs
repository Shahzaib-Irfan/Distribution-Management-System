using DMSmain.BL;
using DMSmain.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMSmain.Forms
{
    public partial class FrmRiderControl : Form
    {
        public FrmRiderControl()
        {
            InitializeComponent();
        }

        private void panelRiderGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmRiderControl_Load(object sender, EventArgs e)
        {
            RiderDL.LoadFromFile();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = RiderDL.riders;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Rider rider = (Rider)dataGridView1.CurrentRow.DataBoundItem;
            if (dataGridView1.Columns["Delete"].Index == e.ColumnIndex)
            {
                dataGridView1.DataSource = null;
                List<Rider> updatedList = RiderDL.deleteRider(rider);
                ProductDL.writeInFile();
                DataBind();
            }
            if (dataGridView1.Columns["Update"].Index == e.ColumnIndex)
            {
                Form f = new FrmUpdateRider(rider);
                f.ShowDialog();
                RiderDL.writeInFile();
                DataBindUpdate();
                f.Hide();
                //Form form = new FrmAdminHomePage(MUserDL.currentUser);
                //this.Hide();f.Hide(); form.Show();
            }
        }
        private void DataBind()
        {

            dataGridView1.DataSource = RiderDL.riders;
            dataGridView1.Refresh();
        }
        private void DataBindUpdate()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = RiderDL.riders;
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new FrmAdminHomePage(MUserDL.currentUser);
            this.Hide(); f.Show();
        }

        private void FrmRiderControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
