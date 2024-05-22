using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pets
{
    public partial class OwnerPanel : Form
    {
        public OwnerPanel()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            obj.txtOwnerID.Text = this.txtOwnerID.Text;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPet obj = new AddPet();
            obj.Show();
            obj.txtOwnerID.Text = this.txtOwnerID.Text;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportPet obj = new ReportPet();
            obj.Show();
            obj.txtOwnerID.Text = this.txtOwnerID.Text;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemovePets obj = new RemovePets();
            obj.Show();
            obj.txtOwnerID.Text = this.txtOwnerID.Text;
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TransferOwnership obj = new TransferOwnership();
            obj.Show();
            obj.txtOwnerID.Text = this.txtOwnerID.Text;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewMyReports obj = new ViewMyReports();
            obj.Show();
            obj.txtOwnerID.Text = this.txtOwnerID.Text;
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtOwnerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
