using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Pets
{
    public partial class Login : Form
    {
        OleDbConnection dbConn;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        string sConnection;
        String myID = "";
        DatabaseConnection db = new DatabaseConnection();

        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String sql = "select * from Owner where Email='" + txtEmail.Text + "' and Password='" + txtPassword.Text + "'";
            int aValue = db.login(sql).Length;

            if (aValue > 0)
            {
                MessageBox.Show("Login successful");
                OwnerPanel obj = new OwnerPanel();
                obj.txtOwnerID.Text = db.login(sql);
                obj.Show();
                this.Hide();
            }
            else if (txtEmail.Text.Equals("Admin") && txtPassword.Text.Equals("12345"))
            {
                MessageBox.Show("Admin Logged in successfully");
                AdminPanel obj = new AdminPanel();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register obj = new Register();
            obj.Show();
            this.Hide();
        }
    }
}
