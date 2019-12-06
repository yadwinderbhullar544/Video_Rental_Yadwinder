using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Rental_Yadwinder
{
    public class DALayer
    {
        String appsetting = System.Configuration.ConfigurationManager.ConnectionStrings["RentedVideosConnectionString"].ToString();
        SqlConnection sqlConn = new SqlConnection();

        public SqlConnection DataConnection()
        {
            sqlConn = new SqlConnection(appsetting);
            return sqlConn;
        }
        public void SqlOpen()
        {
            try
            {
                sqlConn.Open();
            }
            catch (Exception)
            {

            }
        }
        public void SqlClose()
        {
            sqlConn.Close();
            sqlConn.Dispose();
        }
    }
}
