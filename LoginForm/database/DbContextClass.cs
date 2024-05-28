using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace LoginForm.database
{
    public static class DbContextClass
    {
        public static SqlConnection connection;

        public static bool OpenConnection()
        {
            try
            {
                connection = new SqlConnection("Data Source=ALIENWARE\\SQLEXPRESS;Initial Catalog=showusers;Integrated Security=True;Encrypt=False");
                connection.Open();


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}

    

