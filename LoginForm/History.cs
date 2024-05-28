using LoginForm.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            showRecord();
        }

        private void showRecord()
        {
            if (DbContextClass.OpenConnection() == true)
            {
                string strQuery = "select * from Budget";
                SqlCommand cmd = new SqlCommand(strQuery, DbContextClass.connection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);



                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i]["name"].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i]["amount"].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["shipment"].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i]["area_rent"].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i]["transport_rent"].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i]["total"].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i]["quantity"].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = dt.Rows[i]["duty"].ToString();
                    dataGridView1.Rows[i].Cells[8].Value = dt.Rows[i]["date"].ToString();
                }
            }
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

            

        //    if (e.ColumnIndex == 3)
        //    {
        //        string getUSerId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        //        string getUname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        //        string getpas = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        //        if (DbContextClass.OpenConnection() == true)
        //        {
        //            string strQuery = "update usersdb2 set uname = '" + getUname + "' , upass = '" + getpas + "' where uID = '" + getUSerId + "' ";
        //            SqlCommand cmd = new SqlCommand(strQuery, DbContextClass.connection);
        //            SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //            DataTable dt = new DataTable();
        //            sda.Fill(dt);
        //            MessageBox.Show("Edit Sucessfully");
        //        }

        //    }

        //    if (e.ColumnIndex == 4)
        //    {
        //        string getUSerId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

        //        if (DbContextClass.OpenConnection() == true)
        //        {

        //            var cap = "Are you sure you wants to delete this item";
        //            const string caption = "Form Closing";
        //            var result = MessageBox.Show(cap, caption,
        //                                         MessageBoxButtons.YesNo,
        //                                         MessageBoxIcon.Question);

        //            if (result == DialogResult.Yes)
        //            {

        //                string strQuery = "delete from usersdb2 where uID = '" + getUSerId + "' ";
        //                SqlCommand cmd = new SqlCommand(strQuery, DbContextClass.connection);
        //                SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //                DataTable dt = new DataTable();
        //                sda.Fill(dt);
        //                dataGridView1.Rows.RemoveAt(e.RowIndex);
        //                MessageBox.Show("Row deleted");

        //            }
        //            else
        //            {

        //            }


        //        }

        //    }


        //}


    }
}
