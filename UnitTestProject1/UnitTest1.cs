using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;

namespace VideoRentalSystem
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        // test function of add customer button and add new customer button.
        // add address from customer option.
        public void testaddCustomer()
        {
            VideoRental rent = new VideoRental();
            int expectedflag = 0;
            rent.addNewCustomer("Roger", "Federer", "1455 bleecher street, NY", "344564");
            int flag = 1;
            using (MySqlCommand cmd = new MySqlCommand("select * from customer", rent.conn))
            {
                rent.conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr.GetString("FirstName") == "Roger")
                    {
                        flag = 0;
                    }

                }

            }
            Assert.AreEqual(expectedflag, flag, "customer roger not addded");
        }


    }
}
