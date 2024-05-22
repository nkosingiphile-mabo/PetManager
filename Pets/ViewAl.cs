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
    
    public partial class ViewAl : Form
    {
        OleDbConnection dbConn;
        OleDbCommand cmd = new OleDbCommand();
        //OleDbDataReader dr;
        OleDbDataAdapter da;
        DatabaseConnection db = new DatabaseConnection();
        DataSet ds;
        DataTable scores = new DataTable();
        String id = "";
        String type = "";
        String ownerId = "";
        String petId = "";
        String vicinity = "";
        String dateOfIncident = "";
        String status = "Recovered";
        public ViewAl()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sql = txtSql.Text;
            db.fillTable(sql, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel obj = new AdminPanel();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //petId = row.Cells[0].Value.ToString();
                id = row.Cells[0].Value.ToString();
                petId = row.Cells[1].Value.ToString();
                type = row.Cells[2].Value.ToString();
                ownerId = row.Cells[3].Value.ToString();
                vicinity = row.Cells[4].Value.ToString();
                dateOfIncident = row.Cells[5].Value.ToString();
                //status = row.Cells[6].Value.ToString();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            String sql2 = "update Reports set PetID = '" + petId + "', Type ='" + type + "',OwnerID = '" + ownerId + "',Vicinity ='" + vicinity + "', DateOfIncident ='" + dateOfIncident + "',Status ='" + status + "' where ID = " + id + "";
            db.update(sql2);
        }
    }
}
