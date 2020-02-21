using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Video_Rental_Yadwinder.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_LoginWithCorrectCredentails()//unit testing
        {
            Bussisness bs = new Bussisness();
            var loginID = "admin";
            var password = "Admin@123";

            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@userid", loginID);

            sp[1] = new SqlParameter("@pwd", password);
            dt = bs.executSP_DataTableWithParamter("userLogin", sp);
            if (dt != null && dt.Rows.Count > 0)
                Assert.IsTrue(true);
            else
                Assert.IsFalse(false);
        }

    }
}
