
using MySql.Data.MySqlClient;

namespace VideoRentalSystem
{
    using System;
    using System.Configuration;
    using System.Data;

    public class VideoRental
    {
        private string connString;
        public MySqlConnection conn;


        public VideoRental()
        {
            connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            conn = new MySqlConnection(connString);
        }

        private DataTable getDataTable(string Query)
        {
            DataTable TableData = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(Query, conn))
            {
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                TableData.Load(reader);
                conn.Close();
                return TableData;

            }
            
        }
        public DataTable getCustomerData()
        {
            return getDataTable("select * from customer");
        }

        public DataTable getVideoData()
        {
            return getDataTable("select * from movies");
        }
        public DataTable getAllRentalsData()
        {
            return getDataTable("select r.RMID as RMID, c.FirstName as FirstName, c.LastName as LastName, c.Address as Address, m.Title as Title, m.Rental_Cost as RentedCost ,r.DateRented as DateRented, r.DateReturned as DateReturned from customer c, movies m,rentedmovies r where c.CustID = r.CustIDFK  and m.MovieID = r.MovieIDFK");
        }

        public DataTable getOutRentalsData()
        {
            return getDataTable("select r.RMID as RMID, c.FirstName as FirstName, c.LastName as LastName, c.Address as Address, m.Title as Title, m.Rental_Cost as RentedCost ,r.DateRented as DateRented, r.DateReturned as DateReturned from customer c, movies m,rentedmovies r where c.CustID = r.CustIDFK  and m.MovieID = r.MovieIDFK and DateReturned is NULL");
        }

        public int addNewCustomer(string firstName, string lastname, string address, string phonenum)
        {
            string query = "INSERT INTO CUSTOMER(FirstName,LastName,Address,Phone)VALUES(@first_name,@last_name,@address,@phone_number)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@first_name", firstName);
                cmd.Parameters.AddWithValue("@last_name", lastname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone_number", SqlDbType.Int);
                cmd.Parameters["@phone_number"].Value = phonenum;
                conn.Open();
                int res = cmd.ExecuteNonQuery();
                conn.Close();
                return res;
            }
        }
        // add firstname, lastname, address,phone and some other values.
        // result is that this functionn can add this all requirments.
        public int addNewVideo(string title, string year, string genre)
        {
            int date = Convert.ToInt32(year);
            int now = DateTime.Now.Year;
            int cost = 5;
            if ( now - date > 5)
            {
                cost = 2;
            }
            // this button addnew videos title, year, datetime.
            string query = "INSERT INTO MOVIES(Title,Genre,Year,Rental_Cost)VALUES(@title,@genre,@year,@cost)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@title",title );
                cmd.Parameters.AddWithValue("@Genre", genre);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@cost", SqlDbType.Int);
                cmd.Parameters["@cost"].Value = cost;
                conn.Open();
                int res = cmd.ExecuteNonQuery();
                conn.Close();
                return res;
            }
        }

        public int updateCustomer(string id, string firstName, string lastname, string address, string phonenum)
        {
            string query = "UPDATE CUSTOMER SET FirstName=@first_name,LastName=@last_name,Address=@address,Phone=@phone_number WHERE CustID=@custid";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@custid", SqlDbType.Int);
                cmd.Parameters["@custid"].Value = id;
                cmd.Parameters.AddWithValue("@first_name", firstName);
                cmd.Parameters.AddWithValue("@last_name", lastname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone_number", SqlDbType.Int);
                cmd.Parameters["@phone_number"].Value = phonenum;
                conn.Open();
                int res = cmd.ExecuteNonQuery();
                conn.Close();
                return res;
            }

        }
        // function for updatevideo add ID,genre, title, year.
        // result is can add information about customer. 
        public int updateVideo(string id, string genre, string title, string year)
        {
            string query = "UPDATE Movies SET Title= @title,Genre=@genre,Year=@year WHERE MovieID=@movid";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@movid", SqlDbType.Int);
                cmd.Parameters["@movid"].Value = id;
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@year", year);
                conn.Open();
                int res = cmd.ExecuteNonQuery();
                conn.Close();
                return res;
            }

        }
        // Below coading is for deleting customer 
        public int deleteCustomer(string id)
        {
            string query = "DELETE FROM Customer WHERE CustID=@custid";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@custid", SqlDbType.Int);
                cmd.Parameters["@custid"].Value = id;
                conn.Open();
                int res = cmd.ExecuteNonQuery();
                conn.Close();
                return res;
            }
        }
        // this deletevideo button from where the movieID commnd.
        
        public int deleteVideo(string id)
        {
            string query = "DELETE FROM movies WHERE MovieID=@movid";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@movid", SqlDbType.Int);
                cmd.Parameters["@movid"].Value = id;
                conn.Open();
                int res = cmd.ExecuteNonQuery();
                conn.Close();
                return res;
            }
        }
        // put some mysql command and also can insert into rentedmovies.
        //daterented values.
        public int issueVideo(string custid, string movid)
        {
            string query = "Insert into rentedmovies (MovieIDFK, CustIDFK, DateRented)Values(@movid, @custid, @rented)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@custid", SqlDbType.Int);
                cmd.Parameters["@custid"].Value = custid;
                cmd.Parameters.AddWithValue("@movid", SqlDbType.Int);
                cmd.Parameters["@movid"].Value = movid;
                cmd.Parameters.AddWithValue("@rented", DateTime.Now);
               
                conn.Open();
                int res = cmd.ExecuteNonQuery()
                    ;
                conn.Close();
                return res;
                

            }
        }
        //this function update rentelmovies 
        // and added some commands
        public int returnVideo(string rmid)
        {
            string query = "update rentedmovies set DateReturned=@returned where RMID=@rmid";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@rmid", SqlDbType.Int);
                cmd.Parameters["@rmid"].Value = rmid;
                cmd.Parameters.AddWithValue("@returned", DateTime.Now);
                conn.Open();
                int res = cmd.ExecuteNonQuery();
                conn.Close();
                return res;


            }
        }

    }
}
// returnvideo update rentedmoviees set dateReturned where RMID.