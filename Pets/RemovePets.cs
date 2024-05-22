using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pets
{
    public partial class RemovePets : Form
    {
        OleDbConnection dbConn;
        OleDbCommand cmd = new OleDbCommand();
        //OleDbDataReader dr;
        OleDbDataAdapter da;
        DatabaseConnection db = new DatabaseConnection();
        DataSet ds;
        DataTable scores = new DataTable();
        
        public RemovePets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnerPanel obj = new OwnerPanel();
            obj.txtOwnerID.Text = this.txtOwnerID.Text;
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sql = @"select * from Pets where OwnerID = '" + txtOwnerID.Text + "'";
            db.fillTable(sql, dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int petId = Int32.Parse(txtPetID.Text);
            String sql = "delete from Pets where  PetID ="+ petId + "";
            db.delete(sql);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //petId = row.Cells[0].Value.ToString();
                txtPetID.Text = row.Cells[0].Value.ToString();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtOwnerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPetID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
