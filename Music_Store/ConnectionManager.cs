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

        public static void addEmployee(string login, string password, string dateHired, string isAdmin)
        {
            using(SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Employee (LoginID, Password, DateHired, isAdmin) VALUES ('" +
                    login + "','" + password + "','" + dateHired + "','" + isAdmin + "')";
                cmd.ExecuteNonQuery();
            }
        }

        //public static int getGenreId(string name)
        //{
        //    using(SQLiteConnection conn = getConnection())
        //    {
        //        SQLiteCommand cmd = conn.CreateCommand();
        //        cmd.CommandText = "SELECT GenreID FROM Genre WHERE Name = '" + name + "'";
        //        return (int)cmd.ExecuteScalar();
        //    }
        //}

        //public static int getArtistId(string name)
        //{
        //    using(SQLiteConnection conn = getConnection())
        //    {
        //        SQLiteCommand cmd = conn.CreateCommand();
        //        cmd.CommandText = "SELECT ArtistID FROM Artist WHERE = '" + name + "'";
        //        return (int)cmd.ExecuteScalar();
        //    }
        //}

        public static DataTable CustomerView()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using(SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Customer";
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
                cmd.CommandText = "SELECT * FROM Artist";
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
                cmd.CommandText = "SELECT * FROM Album";
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
                cmd.CommandText = "SELECT * FROM Genre";
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
                cmd.CommandText = "SELECT * FROM Employee";
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
