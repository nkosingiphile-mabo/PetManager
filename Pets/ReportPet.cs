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
    public partial class ReportPet : Form
    {
        OleDbConnection dbConn;
        OleDbCommand cmd = new OleDbCommand();
        //OleDbDataReader dr;
        OleDbDataAdapter da;
        DatabaseConnection db = new DatabaseConnection();
        DataSet ds;
        DataTable scores = new DataTable();
        public ReportPet()
        {
            InitializeComponent();
            //txtOwnerID.Text = "9811284322088";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String status = "Stolen";
            String sql = "insert into Reports(PetID,Type,OwnerID,Vicinity,DateOfIncident,Status) values('"+ txtPetID.Text + "','" + txtType.Text + "','" + txtOwnerID.Text + "','" + txtVicinity.Text + "','" + dateTimePicker2.Text + "','" +status+ "')";
            db.insert(sql);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtPetID.Text = row.Cells[0].Value.ToString();
                txtOwnerID.Text = row.Cells[1].Value.ToString();
                txtType.Text = row.Cells[2].Value.ToString();
            }
        }

        private void ReportPet_Load(object sender, EventArgs e)
        {
            String sql = @"select * from Pets where OwnerID = '" + txtOwnerID.Text + "'";
            db.fillTable(sql, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnerPanel obj = new OwnerPanel();
            obj.txtOwnerID.Text = this.txtOwnerID.Text;
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String sql = @"select * from Pets where OwnerID = '" + txtOwnerID.Text + "'";
            db.fillTable(sql, dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String status = "Lost";
            String sql = "insert into Reports(PetID,Type,OwnerID,Vicinity,DateOfIncident,Status) values('" + txtPetID.Text + "','" + txtType.Text + "','" + txtOwnerID.Text + "','" + txtVicinity.Text + "','" + dateTimePicker2.Text + "','" + status + "')";
            db.insert(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtVicinity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
