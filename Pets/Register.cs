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
    public partial class Register : Form
    {
        OleDbConnection dbConn;
        OleDbCommand cmd = new OleDbCommand();
        string sConnection;
        DatabaseConnection db = new DatabaseConnection();
        public Register()
        {
            InitializeComponent();
        }
        public bool containLetter()
        {
            bool valid = false;
            for (int i = 0; i < txtCellNo.Text.Length; i++)
            {
                char aChar = txtCellNo.Text[i];
                if (Char.IsLetter(aChar) || Char.IsSymbol(aChar) || Char.IsWhiteSpace(aChar))
                {
                    valid = true;
                }
            }
            return valid;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtLastName.Text) || String.IsNullOrEmpty(txtCellNo.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtReEnterPassword.Text))
            {
                MessageBox.Show("Please input all the required(*) fields");
            }
            else if (!txtPassword.Text.Equals(txtReEnterPassword.Text))
            {
                MessageBox.Show("Password does not match!");
            }
            else if (txtIDNo.Text.Length != 13)
            {
                MessageBox.Show("Invalid ID Number");
            }
            else if (txtCellNo.Text.Length != 10 || containLetter() || !txtCellNo.Text[0].Equals('0'))
            {
                if (containLetter())
                {
                    MessageBox.Show("Cell Phone nummber must contain digits only");
                }

                else if (!txtCellNo.Text[0].Equals('0'))
                {
                    MessageBox.Show("SA Number contains a zero(0) at the beginning");
                }
                else
                {
                    MessageBox.Show("Invalid cellphone number length!");
                }
            }
            else
            {
                String sql = @"insert into Owner values('" + txtIDNo.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtCellNo.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "','" + txtAddress.Text + "')";
                db.insert(sql); //(IDNo,FirstName,LastName,CellNo,Email,Password,Address)
                txtFirstName.Text = null; txtLastName.Text = null; txtIDNo.Text = null; txtCellNo.Text = null; txtEmail.Text = null; txtPassword.Text = null; txtReEnterPassword.Text = null; txtAddress.Text = null;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
