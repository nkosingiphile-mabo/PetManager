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
    public partial class AdminPanel : Form
    {
        String sql = "";
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "select * from Pets";
            ViewAl obj = new ViewAl();
            obj.Show();
            obj.txtSql.Text = sql;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = "select * from Owner";
            ViewAl obj = new ViewAl();
            obj.Show();
            obj.txtSql.Text = sql;
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sql = "select * from Reports";
            ViewAl obj = new ViewAl();
            obj.Show();
            obj.txtSql.Text = sql;
            obj.btnRecover.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
