using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Music_Store
{
    class ConnectionManager
    {
        public static SQLiteConnection getConnection()
        {

            string connectionString = @"Data Source=music_store_v3.sqlite;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();

            return connection;
        }

        public static void addArtist(string name)
        {
            using(SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Artist (name) VALUES ('" + name + "')";
                cmd.ExecuteNonQuery();
             }
        }

        public static void addAlbum(string artistID, string genreID, string title, string price, string quantity)
        {
            using(SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Album (ArtistId, GenreId, Title, Price, Quantity) VALUES ('" +
                    artistID + "','" + genreID + "','" + title + "','" + price + "','" + quantity + "')";
                cmd.ExecuteNonQuery();
            }
        }

        public static void addGenre(string name, string desc)
        {
            using(SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Genre (Name, Desc) VALUES ('" +
                    name + "','" + desc + "')";
                cmd.ExecuteNonQuery();
            }
           
        }

        public static void addCustomer(string firstName, string lastName, string email, string phone)
        {
            using(SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Customer (Firstname, Lastname, EmailAddress, PhoneNumber) VALUES ('" +
                    firstName + "','" + lastName + "','" + email + "','" + phone + "')";
                cmd.ExecuteNonQuery();
            }
        }

        public static void addEmployee(string login, string sqID, string password, string dateHired, 
            string isAdmin, string answer, string firstname, string lastname)
        {
            using(SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into employee (loginID, SecuerityQuestionId, Password, DateHired, isAdmin, " +
                    "SecurityQuestionAns, FirstName, LastName) Vvalues ('" + login + "','" + sqID + "','" + password + "','" +
                    "','" + dateHired + "','" + isAdmin + "','" + answer + "','" + firstname + "','" + lastname + "')";
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable ArtistComboBox()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Artist";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }

            return dt;
        }

        public static DataTable GenreComboBox()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Genre";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }

            return dt;
        }

        public static DataTable SecurityQuestionComboBox()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Security_Questions";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }

            return dt;
        }

        public static DataTable CustomerView()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using(SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select customer.firstName as 'First Name', customer.lastName as 'Last Name', " + 
                    "customer.emailAddress as 'Email Address', customer.phoneNumber as 'Phone #'from customer order by customer.firstName";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }

            return dt;
        }

        public static DataTable ArtistView()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select Artist.name as 'Artist', count(Album.albumID) as '# Albums' from Artist " + 
                    "join Album on Artist.artistID = Album.artistId group by Artist.name";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }

            return dt;
        }

        public static DataTable AlbumView()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select Album.title as 'Album', Artist.name as 'Artist', Genre.name as 'Genre',  Album.price, Album.quantity " +
                    "from Artist join Album on Artist.artistID = Album.artistId join Genre on Album.genreId = Genre.genreID order by Artist.name";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }

            return dt;
        }

        public static DataTable GenreView()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select Genre.name as 'Genre', Genre.desc as 'Description' from Genre order by Genre.name";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }

            return dt;
        }

        public static DataTable EmployeeView()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select employee.lastName as 'Last Name', employee.firstName as 'First Name', " +
                    "employee.LoginID as 'Login ID', employee.dateHired as 'Date Hired', employee.IsAdmin as 'Admin', " +
                    "count(musicOrder.employeeId) as '# Sales' from employee left join musicOrder " +
                    " on employee.employeeID = musicOrder.employeeId group by employee.lastName";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }

            return dt;
        }

        public static DataTable CustomerSearch(string number)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select customer.LastName, customer.firstName, customer.emailAddress, " +
                    "customer.customerID from customer where customer.phoneNumber = '" + number + "'";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }

            return dt;
        }

        public bool checkCredentials(string username, string password)
        {
            return true;
        }

        public static bool checkEmployeeUsername(string username)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Employee WHERE LoginID='"+username+"'";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

    }
}
