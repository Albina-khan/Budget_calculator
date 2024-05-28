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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reBtn_Click(object sender, EventArgs e)
        {
            adduser.Clear();
            addpass.Clear();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {


            string userInput = adduser.Text.ToString();
            string passInput = addpass.Text.ToString();
            string rewritePass = rewritepass.Text.ToString();



            if (userInput == "" || passInput == "")
            {
                MessageBox.Show("Null Values.");
            }
            else
            {
                if (passInput == rewritePass)
                {

                    if (DbContextClass.OpenConnection() == true)
                    {
                        string strQuery = "select * from usersdb2 where uname = '" + userInput + "' AND upass = '" + passInput + "' ";
                        SqlCommand cmd = new SqlCommand(strQuery, DbContextClass.connection);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Account Already Exists.");
                            adduser.Clear();
                            addpass.Clear();
                            rewritepass.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Account Created");

                            string insertQuery = "insert into usersdb2 (uname , upass) values ('" + userInput + "' , '" + passInput + "')";
                            SqlCommand command = new SqlCommand(insertQuery, DbContextClass.connection);
                            SqlDataAdapter sda2 = new SqlDataAdapter(command);
                            DataTable dt2 = new DataTable();
                            sda2.Fill(dt2);

                            adduser.Clear();
                            addpass.Clear();
                            rewritepass.Clear();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Conn Failed");

                }
            }
        }
    }
}
