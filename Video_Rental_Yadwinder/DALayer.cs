using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Rental_Yadwinder
{
    public class DALayer// This is data connection layer where i created the connection string
    {
        String appsetting = System.Configuration.ConfigurationManager.ConnectionStrings["RentedVideosConnectionString"].ToString();
        SqlConnection sqlConn = new SqlConnection();

        public SqlConnection DataConnection()//sql conection method
        {
            sqlConn = new SqlConnection(appsetting);
            return sqlConn;
        }
        public void SqlOpen()//connection open method for opening the connection
        {
            try
            {
                sqlConn.Open();
            }
            catch (Exception)
            {

            }
        }
        public void SqlClose()//connection close method for closing the connection
        {
            sqlConn.Close();
            sqlConn.Dispose();
        }
    }
}
