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
    public partial class VideoShopYadwinder : Form
    {
        Bussisness bl = new Bussisness();
        public VideoShopYadwinder()
        {
            InitializeComponent();
            GetCustomers();
            GetMovies();
            GetRentals();
        }

        private void GetCustomers()//Get customers method. here i call the customer list
        {
            DataTable dt = new DataTable();
            dt = bl.executSP_DataTableWithoutParamter("sp_GetCustomerList");
            dataGridViewCustomers.DataSource = dt;

        }

        private void GetMovies()//Get movies method. here i call the movie list
        {
            DataTable dt = new DataTable();
            dt = bl.executSP_DataTableWithoutParamter("sp_GetMovieList");
            dataGridViewMovies.DataSource = dt;

        }

        private void GetRentals()//Get rental method. here i call the rental list
        {
            DataTable dt = new DataTable();
            dt = bl.executSP_DataTableWithoutParamter("sp_GetRentalList");
            dataGridViewRental.DataSource = dt;

        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)//Add customer functionality
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqls = new SqlParameter[4];
            sqls[0] = new SqlParameter("@FirstName", custFirstNameTxt.Text);
            sqls[1] = new SqlParameter("@LastName", custLastNameTxt.Text);
            sqls[2] = new SqlParameter("@Address", addressTxt.Text);
            sqls[3] = new SqlParameter("@Phone", phoneTxt.Text);
            dt = bl.executSP_DataTableWithParamter("sp_InsertUpdateCustomer", sqls);
            GetCustomers();
            MessageBox.Show("Customer updated successfully");
        }

        private void CustomerUpdateBtn_Click(object sender, EventArgs e)//update customer functionality
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqls = new SqlParameter[5];
            sqls[0] = new SqlParameter("@FirstName", custFirstNameTxt.Text);
            sqls[1] = new SqlParameter("@LastName", custLastNameTxt.Text);
            sqls[2] = new SqlParameter("@Address", addressTxt.Text);
            sqls[3] = new SqlParameter("@Phone", phoneTxt.Text);
            sqls[4] = new SqlParameter("@CustID", custIDTxt.Text);
            bl.executSP_DataTableWithParamter("sp_InsertUpdateCustomer", sqls);
            custFirstNameTxt.Text = "";
            custLastNameTxt.Text = "";
            addressTxt.Text = "";
            phoneTxt.Text = "";
            GetCustomers();
            MessageBox.Show("Customer updated successfully");
        }

        private void CustomerDeleteBtn_Click(object sender, EventArgs e)//Delete customer functionality
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqls = new SqlParameter[1];
            sqls[0] = new SqlParameter("@customerID", custIDTxt.Text);
            bl.executSP_DataTableWithParamter("sp_DeleteCustomers", sqls);
            GetCustomers();
            MessageBox.Show("Customer deleted successfully");
        }

        private void MovieAddBtn_Click(object sender, EventArgs e)//Add movie functionality
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqls = new SqlParameter[4];
            sqls[0] = new SqlParameter("@Title", titleTxt.Text);
            sqls[1] = new SqlParameter("@Rental_Cost", rentalCostTxt.Text);
            sqls[2] = new SqlParameter("@Genre", genreTxt.Text);
            sqls[3] = new SqlParameter("@Plot", plotTxt.Text);
            bl.executSP_DataTableWithParamter("sp_InsertUpdateMovies", sqls);
            GetMovies();
            MessageBox.Show("Movie saved successfully");
        }

        private void MovieDeleteBtn_Click(object sender, EventArgs e)//Delete movie functionality
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqls = new SqlParameter[1];
            sqls[0] = new SqlParameter("@movieID", movieIDTxt.Text);
            bl.executSP_DataTableWithParamter("sp_DeleteMovies", sqls);
            GetMovies();
            MessageBox.Show("Movie deleted successfully");
        }

        private void MovieUpdateBtn_Click(object sender, EventArgs e)//Update movie functionality
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqls = new SqlParameter[5];
            sqls[0] = new SqlParameter("@Title", titleTxt.Text);
            sqls[1] = new SqlParameter("@Rental_Cost", rentalCostTxt.Text);
            sqls[2] = new SqlParameter("@Genre", genreTxt.Text);
            sqls[3] = new SqlParameter("@Plot", plotTxt.Text);
            sqls[4] = new SqlParameter("@MovieID", movieIDTxt.Text);
            bl.executSP_DataTableWithParamter("sp_InsertUpdateMovies", sqls);
            GetMovies();
            MessageBox.Show("Movie updated successfully");
        }

        private void MovieReturnBtn_Click(object sender, EventArgs e)//Return movie functionality
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqls = new SqlParameter[1];
            sqls[0] = new SqlParameter("@rentalID", rentalIDTxt.Text);
            bl.executSP_DataTableWithParamter("sp_UpdateRentalReturnMovie", sqls);
            GetRentals();
            MessageBox.Show("Movie returned by the customer");
        }

        private void MovieIssueBtn_Click(object sender, EventArgs e)//Issue movie functionality
        {
            DataTable dt = new DataTable();
            SqlParameter[] sqls = new SqlParameter[2];
            sqls[0] = new SqlParameter("@customerID", custIDTxt.Text);
            sqls[1] = new SqlParameter("@movieID", movieIDTxt.Text);
            bl.executSP_DataTableWithParamter("sp_InsertRentalIssueMovie", sqls);
            GetRentals();
            MessageBox.Show("Movie rented to the customer");
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)//gridview of customers functionality
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridViewCustomers.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                custIDTxt.Text = row.Cells[0].Value.ToString();
                custFirstNameTxt.Text = row.Cells[1].Value.ToString();
                custLastNameTxt.Text = row.Cells[2].Value.ToString();
                addressTxt.Text = row.Cells[3].Value.ToString();
                phoneTxt.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dataGridViewMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)//gridview of movies functionality
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridViewMovies.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                movieIDTxt.Text = row.Cells[0].Value.ToString();
                titleTxt.Text = row.Cells[1].Value.ToString();
                genreTxt.Text = row.Cells[2].Value.ToString();
                rentalCostTxt.Text = row.Cells[3].Value.ToString();
                plotTxt.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dataGridViewRental_CellContentClick(object sender, DataGridViewCellEventArgs e)//gridview of rental functionality
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridViewRental.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                rentalIDTxt.Text = row.Cells[0].Value.ToString();
                custFirstNameTxt.Text = row.Cells[1].Value.ToString();
                custLastNameTxt.Text = row.Cells[2].Value.ToString();
                addressTxt.Text = row.Cells[3].Value.ToString();
                phoneTxt.Text = row.Cells[4].Value.ToString();
                rentalCostTxt.Text = row.Cells[5].Value.ToString();
            }
        }

        private void allRentedRadioBtn_CheckedChanged(object sender, EventArgs e)//rented radio button functionality
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@rentalType", "A");
            dt = bl.executSP_DataTableWithParamter("GetMoviesRentalList", sp);
            dataGridViewRental.DataSource = dt;
        }

        private void outRentedRadioBtn_CheckedChanged(object sender, EventArgs e)//out rented radio button functionality
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@rentalType", "O");
            dt = bl.executSP_DataTableWithParamter("GetMoviesRentalList", sp);
            dataGridViewRental.DataSource = dt;
        }

        private void rentalCostTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
