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
using System.Data.OleDb;

namespace Pets
{
    public partial class Form1 : Form
    {
        OleDbConnection dbConn;
        OleDbCommand cmd = new OleDbCommand();
        //OleDbDataReader dr;
        OleDbDataAdapter da;
        DatabaseConnection db = new DatabaseConnection();
        DataSet ds;
        DataTable scores = new DataTable();
        public Form1()
        {
            InitializeComponent();
            txtOwnerID.Text = txtOwnerID.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
               String sql = @"select * from Pets where OwnerID = '" + txtOwnerID.Text + "'";
               db.fillTable(sql, dataGridView1);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
