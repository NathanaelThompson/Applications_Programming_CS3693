﻿using System;
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

//Inserts
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
                cmd.CommandText = "insert into Employee (loginID, Password, FirstName, LastName, DateHired, SecurityQuestionId, SecurityQuestionAns, IsAdmin)" +
                    " Values ('" + login + "','" + password + "','" + firstname +
                    "','" + lastname + "','" + dateHired + "','" + sqID + "','" + answer + "','" + isAdmin + "')";
                cmd.ExecuteNonQuery();
            }
        }

        public static void AddToCart(string cartID, string albumID)
        {
            using(SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Cart (CartID, AlbumId) VALUES ('" + cartID + "','" + albumID + "')";
                cmd.ExecuteNonQuery();
            }
        }

        public static void AddNewOrder(string customerID, string cartID, string employeeID, string total, string orderDate)
        {
            using(SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO MusicOrder (CustomerId, CartId, EmployeeId, Total, OrderDate) VALUES ('" + 
                    customerID + "','" + cartID + "','" + employeeID + "','" + total + "','" + orderDate + "')";
                cmd.ExecuteNonQuery();
            }
        }
        
//Combobox datasources
        public static DataTable ArtistComboBox()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT * FROM Artist ORDER BY Name";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }

            return dt;
        }

        public static DataTable AlbumComboBox(string artistID)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT * FROM Album WHERE ArtistId = '" + artistID + "' ORDER BY Title";
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
                cmd.CommandText = "SELECT DISTINCT * FROM Genre ORDER BY Name";
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
                cmd.CommandText = "SELECT DISTINCT * FROM Security_Questions";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }

            return dt;
        }

        //Gridview/Listview datasources
        public static DataTable CustomerView()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using(SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT customer.firstName AS 'First Name', customer.lastName AS 'Last Name', " + 
                    "customer.emailAddress AS 'Email Address', customer.phoneNumber AS 'Phone #'FROM customer ORDER BY customer.firstName";
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
                cmd.CommandText = "SELECT DISTINCT Artist.name AS 'Artist', COUNT(Album.albumID) AS '# Albums' FROM Artist " + 
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
                cmd.CommandText = "SELECT DISTINCT Album.title AS 'Album', Artist.name AS 'Artist', Genre.name AS 'Genre',  Album.price, Album.quantity " +
                    "FROM Artist JOIN Album ON Artist.artistID = Album.artistId JOIN Genre ON Album.genreId = Genre.genreID ORDER BY Artist.name";
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
                cmd.CommandText = "SELECT DISTINCT Genre.name AS 'Genre', Genre.desc AS 'Description' FROM Genre ORDER BY Genre.name";
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
                    " on employee.employeeID = musicOrder.employeeId group by employee.EmployeeID";
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

//Other queries
        public static string GetCustomerIDFromCreatedCustomer(string firstname, string lastname)
        {
            using(SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select CustomerID from Customer where FirstName = '" + firstname + "' and LastName = '" + lastname + "'";
                return cmd.ExecuteScalar().ToString();
            }
        }

        public static bool CheckAdminStatus(string employee)
        {
            using(SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select IsAdmin from Employee where LoginID = '" + employee + "'";
                 int result = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (result == 1)
                    return true;
                else
                    return false;
            }
        }

        public static int EmployeeCheck(string login)
        {
            using(SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select count(*) from employee where employee.loginID like '" + login + "%'";
                return Int32.Parse(cmd.ExecuteScalar().ToString());
            }
        }

        public static void UpdateQuantity(string albumID)
        {
            using(SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Quantity FROM Album WHERE AlbumID = '" + albumID + "'";
                int Qty = Int32.Parse(cmd.ExecuteScalar().ToString()) - 1;

                cmd.CommandText = "UPDATE Album SET Quantity = '" + Qty + "' WHERE AlbumID = '" + albumID + "'";
                cmd.ExecuteNonQuery();
            }
        }

        public static string GetEmployeeID(string login)
        {
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT EmployeeID FROM Employee WHERE LoginID = '" + login + "'";
                return cmd.ExecuteScalar().ToString();
            }
        }

       
        public static string AlbumPrice(string albumID)
        {
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Price FROM Album where AlbumID = '" + albumID + "'";
                return (string)cmd.ExecuteScalar();
            }
        }

        public static string AlbumArtwork(string albumID)
        {
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ImgPath FROM Album where AlbumID = '" + albumID + "'";
                return (string)cmd.ExecuteScalar();
            }
        }

        public static int CartCount()
        {
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(DISTINCT CartID) FROM Cart";
                return Int32.Parse(cmd.ExecuteScalar().ToString());
            }
        }

        public static bool checkCredentials(string username, string password)
        {
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM Employee WHERE LoginID = '" + username + "'AND Password = '" + password + "'";
                if(Int32.Parse(cmd.ExecuteScalar().ToString()) == 1)
                    return true;
                else
                    return false;
            }
        }
        public static bool checkCredentials(string username)
        {
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM Employee WHERE LoginID = '" + username + "'";
                if (Int32.Parse(cmd.ExecuteScalar().ToString()) == 1)
                    return true;
                else
                    return false;
            }
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

        public static DataTable GrossSales()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select musicOrder.employeeId from musicOrder " +
                    "group by musicOrder.employeeId order by sum(musicOrder.total) " +
                    "desc limit 1";
                int topEmployee = Int32.Parse(cmd.ExecuteScalar().ToString());
                cmd.CommandText = "select sum(musicOrder.total) as 'Gross Sales', count(musicOrder.OrderID) " + 
                    "as 'Number of Sales', (select count(Cart.AlbumId) from Cart) as 'Number of Albums', " + 
                    "(select employee.loginID from employee where employee.EmployeeID == " + topEmployee + ") " +
                    "as 'Top Employee To Date' from musicOrder";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            dt.Columns[0].ColumnName = "Gross Sales ($)";
            return dt;
        }

        public static DataTable MonthlySales(string month)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT MusicOrder.EmployeeId, SUM(MusicOrder.Total) FROM MusicOrder " +
                    "WHERE MusicOrder.OrderDate LIKE '%" + month + "%' GROUP BY MusicOrder.EmployeeId " +
                    "ORDER BY SUM(MusicOrder.Total) DESC LIMIT 1";
                int topEmployee = Int32.Parse(cmd.ExecuteScalar().ToString());
                cmd.CommandText = "select sum(musicOrder.total) as 'Gross Sales', count(musicOrder.OrderID) " + 
                    "as 'Number of Sales', (select count(cart.cartID) from Cart join musicOrder on cart.cartID = " +
                    "musicOrder.cartId where musicOrder.orderdate like '" + month + "%') as 'Number of Albums', " + 
                    "(select employee.loginID from employee where employee.EmployeeID == " + topEmployee + ") as " + 
                    "'Top Employee To Date' from musicOrder where musicOrder.orderdate like '" + month + "%'";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            dt.Columns[0].ColumnName = "Gross Sales ($)";
            return dt;
        }

        public static DataTable PopularGenres()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select genre.name as 'Genre', count(genre.name) as 'Albums Sold'  from Cart " + 
                    "join Album on cart.albumId = album.albumID join Genre on album.genreId " + 
                    "= genre.genreID group by Genre.name order by count(genre.name) desc";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }

            return dt;
        }

        public static DataTable PopularArtists()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select artist.name as 'Artist', count(artist.name) as 'Albums Sold'  from Cart " +
                    "join Album on cart.albumId = album.albumID join Artist on Album.artistId = artist.artistID " +
                    "group by artist.name order by count(artist.name) desc";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }

            return dt;
        }

        public static DataTable PopularAlbums()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select Album.title as 'Album', count(album.title) as 'Albums Sold' " +
                    "from album join cart on album.albumID = cart.albumId group by album.title " + 
                    "order by count(album.title) desc";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }

            return dt;
        }

        public static DataTable EmployeeSales()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select Employee.loginID as 'Employee', sum(musicOrder.total) as " + 
                    "'Gross Sales', count(musicOrder.OrderID) as 'Number of Sales' from Employee " +
                    "join musicOrder on employee.employeeID = musicOrder.employeeId group by " + 
                    "musicOrder.employeeId order by sum(musicOrder.total) desc";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            dt.Columns[1].ColumnName = "Gross Sales ($)";
            return dt;
        }

        public static DataTable CustomerSales()
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = getConnection())
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select customer.lastName as 'Last Name', customer.firstName as 'First Name', " + 
                    "sum(musicorder.total) as 'Total Spent', count(musicorder.orderid) as 'Total Purchases' " + 
                    "from customer join musicOrder on customer.customerID = musicOrder.customerId group by " + 
                    "musicOrder.customerId order by sum(musicOrder.total) desc";
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            dt.Columns[2].ColumnName = "Total Spent ($)";
            return dt;
        }
    }
    
}
