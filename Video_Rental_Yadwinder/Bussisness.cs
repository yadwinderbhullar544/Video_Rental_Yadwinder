using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Rental_Yadwinder
{
    public class Bussisness//this is bussiness class for writing the login
    {
        DALayer dLayer = new DALayer();
        
        public DataTable executSP_DataTableWithParamter(string SPName, SqlParameter[] SP)//datatable through store procedure
        {
            SqlCommand cmd = new SqlCommand(SPName, dLayer.DataConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SPName;
            cmd.CommandTimeout = 600;
            foreach (SqlParameter sp in SP)
            {
                cmd.Parameters.Add(sp);
            }



            try
            {
                dLayer.SqlOpen();
                da.SelectCommand = cmd;
                da.Fill(dt);
                dLayer.SqlClose();

            }
            catch (Exception)
            {

            }
            finally
            {
                cmd.Dispose();
                dLayer.SqlClose();
            }
            return dt;


        }

        public DataTable executSP_DataTableWithoutParamter(string SPName)// Here passing the store procedure name
        {
            SqlCommand cmd = new SqlCommand(SPName, dLayer.DataConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SPName;
            cmd.CommandTimeout = 600;
            try
            {
                dLayer.SqlOpen();
                da.SelectCommand = cmd;
                da.Fill(dt);
                dLayer.SqlClose();

            }
            catch { }
            finally
            {
                cmd.Dispose();
                dLayer.SqlClose();
            }
            return dt;


        }
    }
}
