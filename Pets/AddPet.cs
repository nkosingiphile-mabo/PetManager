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
    public partial class AddPet : Form
    {
        OleDbConnection dbConn;
        OleDbCommand cmd = new OleDbCommand();
        string sConnection;
        DatabaseConnection db = new DatabaseConnection();
        public AddPet()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String sql2 = "select * from Owner where IDNo = '" + txtOwnerID.Text + "'";
            if (!(db.login(sql2).Equals(null)))
            {
                if (String.IsNullOrEmpty(txtType.Text) || String.IsNullOrEmpty(txtBreed.Text) || String.IsNullOrEmpty(txtColor.Text) || String.IsNullOrEmpty(txtOwnerID.Text))
                {
                    MessageBox.Show("Please input all the required fields");
                }
                else
                {
                    String gender = "";
                    if (radMale.Checked)
                    {
                        gender = "male";
                    }
                    else if (radFemale.Checked)
                    {
                        gender = "female";
                    }
                    String sql = @"insert into Pets(OwnerID,Type,Breed,Color,Gender,DateOfBirth) values('" + txtOwnerID.Text + "','" + txtType.Text + "','" + txtBreed.Text + "','" + txtColor.Text + "','" + gender + "','" + dateTimePicker1.Text + "')";
                    db.insert(sql); //(IDNo,FirstName,LastName,CellNo,Email,Password,Address)
                                    //txtFirstName.Text = null; txtLastName.Text = null; txtIDNo.Text = null; txtCellNo.Text = null; txtEmail.Text = null; txtPassword.Text = null; txtReEnterPassword.Text = null; txtAddress.Text = null;
                }
            }
            else
            {
                MessageBox.Show("User does not exist");
            }
            
        }

        private void radMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radMale.Checked)
            {
              radFemale.Checked = false;
            }
        }

        private void redFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radFemale.Checked)
            {
                radMale.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnerPanel obj = new OwnerPanel();
            obj.txtOwnerID.Text = this.txtOwnerID.Text;
            obj.Show();
            this.Hide();
        }
    }
}
