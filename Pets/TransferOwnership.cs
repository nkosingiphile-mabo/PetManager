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
    public partial class TransferOwnership : Form
    {
        OleDbConnection dbConn;
        OleDbCommand cmd = new OleDbCommand();
        //OleDbDataReader dr;
        OleDbDataAdapter da;
        DatabaseConnection db = new DatabaseConnection();
        DataSet ds;
        DataTable scores = new DataTable();
        String petId = "";
        String type = "";
        String breed = "";
        String color = "";
        String gender = "";
        String dateOfBirth = "";
        public TransferOwnership()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Check if new owner exists
            
            String sql1 = "select * from Owner where IDNo = '"+txtNewOwner.Text+"'";
            String  sql2 = "update Pets set OwnerID = '"+txtNewOwner.Text+"', Type ='"+type+"',Breed = '"+breed+"',Color ='"+color+"', Gender ='"+gender+"',DateOfBirth ='"+dateOfBirth+ "' where PetID = " + txtPetID.Text + "";
            String value = db.login(sql1);
            if (value.Length > 0)
            {
                db.update(sql2);
            }
            else {
                MessageBox.Show("The person you are trying to transfer to does not exist...");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //petId = row.Cells[0].Value.ToString();
                txtPetID.Text = row.Cells[0].Value.ToString();
                txtOwnerID.Text = row.Cells[1].Value.ToString();
                type = row.Cells[2].Value.ToString();
                breed = row.Cells[3].Value.ToString();
                color = row.Cells[4].Value.ToString();
                gender = row.Cells[5].Value.ToString();
                dateOfBirth = row.Cells[6].Value.ToString();
            }
        }
    }
}
