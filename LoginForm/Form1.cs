using LoginForm.database;
using System.Data;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        //public object DbContextClass { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reBtn_Click(object sender, EventArgs e)
        {
            username.Clear();
            password.Clear();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string unameInput = username.Text.ToString();
            string passInput = password.Text.ToString();



            if (unameInput == "" || passInput == "")
            {
                MessageBox.Show("Null Values.");
            }
            else
            {
                if (DbContextClass.OpenConnection() == true)
                {
                    string strQuery = "select * from usersdb2 where uname = '" + unameInput + "' AND upass = '" + passInput + "' and uID = '11'";
                    SqlCommand cmd = new SqlCommand(strQuery, DbContextClass.connection);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);


                    string strQuery2 = "select * from usersdb2 where uname = '" + unameInput + "' AND upass = '" + passInput + "' ";
                    SqlCommand cmd2 = new SqlCommand(strQuery2, DbContextClass.connection);
                    SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);

                    if (dt.Rows.Count > 0)
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                   
                    else if(dt2.Rows.Count > 0)
                    {
                        calculationapp calculationapp = new calculationapp();
                        calculationapp.Show();
                        username.Clear();
                        password.Clear();
                    }
                    else
                    {
                        MessageBox.Show("inValid Field");
                        username.Clear();
                        password.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Conn Failed");

                }
            }

        }

        private void backTosignup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

    }
}
