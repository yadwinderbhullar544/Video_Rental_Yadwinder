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

namespace Video_Rental_Yadwinder
{
    public partial class Form1 : Form
    {
        Bussisness bl = new Bussisness();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@userid", txtUsr.Text);

            sp[1] = new SqlParameter("@pwd", txtPss.Text);
            dt = bl.executSP_DataTableWithParamter("userLogin", sp);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                {

                    this.Hide();
                    VideoShopYadwinder _VideoRent = new VideoShopYadwinder();
                    _VideoRent.ShowDialog();

                }

            }
            else
            {
                txtUsr.Text = "";
                txtPss.Text = "";
                MessageBox.Show("Login ID and Password is invalid.");
            }
        }

        private void txtPss_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
