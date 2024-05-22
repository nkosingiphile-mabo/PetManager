using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace Pets
{
    class DatabaseConnection
    {
        OleDbConnection dbConn;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        OleDbDataAdapter da;
        DataSet ds;
        OleDbCommandBuilder cb;
        DataRow row;
        //DataTable scores = new DataTable();
        string sConnection;
        String aValue;
        public void connection()
        {
            try
            {
                sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user pc\\Desktop\\Pets\\Pets\\PetsDB.accdb";
                dbConn = new OleDbConnection(sConnection);
                dbConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error tring to connect to database!!!\n"+ex.Message);
            }
        }
        public void insert(String sql)
        {
            try
            {
                connection();
                cmd.CommandText = sql;
                cmd.Connection = dbConn;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Operation successful...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trying to insert to database!!!\n"+ex.Message);
            }
            dbConn.Close();
        }
        public String login(String sql)
        {
            try
            {
                aValue = "";
                connection();
                cmd.CommandText = sql;
                cmd.Connection = dbConn;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    aValue = dr.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trying retrieve database!!!\n" + ex.Message);
            }
            return aValue;
            dbConn.Close();
        }
        public void fillTable(String sql, DataGridView dg)
        {
            try {
                connection();
                cmd.CommandText = sql;
                cmd.Connection = dbConn;

                da = new OleDbDataAdapter();
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds, "Pets");
                dg.DataSource = ds;
                dg.DataMember = "Pets";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trying to retrieve from database...\n" + ex.Message);
            }
        }
        public void delete(String sql)
        {
            try
            {
                connection();
                cmd.CommandText = sql;
                cmd.Connection = dbConn;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Operation successful\nPet deleted...");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trying to delete from database!!!\n" + ex.Message);
            }
        }
        public void update(String sql)
        {
            try
            {
                connection();
                cmd.CommandText = sql;
                cmd.Connection = dbConn;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Operation successful\nPet Transferred...");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trying to update database!!!\n" + ex.Message);
            }
        }
        public void update2(String sql)
        {
            try
            {
                connection();
                


                MessageBox.Show("Operation successful\nPet Transferred...");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trying to delete from database!!!\n" + ex.Message);
            }
        }
    }
}
