using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookStoreProject
{
    class Data
    {
        //Book Data
        public static void CreatBookTable()
        {

            using (SqliteConnection db =
               new SqliteConnection("Filename=BookTable.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS BookTable (ISBN INTEGER PRIMARY KEY, " +
                    "Title VARCHAR(30) NOT NULL ," +
                    "Description VARCHAR(100) NOT NULL," +
                    "Price FLOAT(2) NOT NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
        public static void AddDataBook(int ISBN, string Title, string Description, float Price)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=BookTable.db"))
            {
                db.Open();
                SqliteCommand AddBookCommand = new SqliteCommand();
                AddBookCommand.Connection = db;
                AddBookCommand.CommandText = "INSERT INTO BookTable VALUES(@ISBN,@Title,@Description,@Price)";
                AddBookCommand.Parameters.AddWithValue("@ISBN", ISBN);
                AddBookCommand.Parameters.AddWithValue("@Title", Title);
                AddBookCommand.Parameters.AddWithValue("@Description", Description);
                AddBookCommand.Parameters.AddWithValue("@Price", Price);
                AddBookCommand.ExecuteReader();
                db.Close();

            }

        }
        public static List<String> GetBook()
        {
            List<string> data = new List<string>();
            using (SqliteConnection db = new SqliteConnection("Filename=BookTable.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand("SELECT * from BookTable", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    data.Add(query.GetString(0));
                    data.Add(query.GetString(1));
                    data.Add(query.GetString(2));
                    data.Add(query.GetString(3));
                }
                db.Close();
            }
            return data;
        }
        public static void UpdateDataBook(int ISBN, string Title, string Description, float Price)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=BookTable.db"))
            {
                db.Open();
                SqliteCommand AddBookCommand = new SqliteCommand();
                AddBookCommand.Connection = db;
                AddBookCommand.CommandText = "UPDATE BookTable SET Title = @Title, Description = @Description ,Price = @Price WHERE ISBN = @ISBN; ";
                AddBookCommand.Parameters.AddWithValue("@ISBN", ISBN);
                AddBookCommand.Parameters.AddWithValue("@Title", Title);
                AddBookCommand.Parameters.AddWithValue("@Description", Description);
                AddBookCommand.Parameters.AddWithValue("@Price", Price);


                AddBookCommand.ExecuteReader();
                db.Close();

            }


        }
        public static void DeleteDataBook(int ISBN)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=BookTable.db"))
            {
                db.Open();
                SqliteCommand AddBookCommand = new SqliteCommand();
                AddBookCommand.Connection = db;
                AddBookCommand.CommandText = "DELETE FROM BookTable WHERE ISBN =@ISBN;";
                AddBookCommand.Parameters.AddWithValue("@ISBN", ISBN);



                AddBookCommand.ExecuteReader();
                db.Close();

            }


        }
        //Employee Data
        public static void CreatEmployeeTable()
        {

            using (SqliteConnection db =
               new SqliteConnection("Filename=EmployeeTable.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS EmployeeTable (ID INTEGER(10) NOT NULL PRIMARY KEY, " +
                    "Password VARCHAR(10) NOT NULL )";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
        public static void AddDataEmployee(int ID, string Password)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=EmployeeTable.db"))
            {
                db.Open();
                SqliteCommand AddEmployeeCommand = new SqliteCommand();
                AddEmployeeCommand.Connection = db;
                AddEmployeeCommand.CommandText = "INSERT INTO EmployeeTable VALUES(@ID,@Password)";
                AddEmployeeCommand.Parameters.AddWithValue("@ID", ID);
                AddEmployeeCommand.Parameters.AddWithValue("@Password", Password);
                AddEmployeeCommand.ExecuteReader();
                db.Close();

            }

        }
        public static List<String> GetEmployee()
        {
            List<string> data = new List<string>();

            using (SqliteConnection db = new SqliteConnection("Filename=EmployeeTable.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand("SELECT * from EmployeeTable", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    data.Add(query.GetString(0));
                    data.Add(query.GetString(1));
                    
                }
                db.Close();
            }
            return data;
        }
        public static void UpdateEmployee(int ID, string Password)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=EmployeeTable.db"))
            {
                db.Open();
                SqliteCommand AddEmployeeCommand = new SqliteCommand();
                AddEmployeeCommand.Connection = db;
                AddEmployeeCommand.CommandText = "UPDATE BookTable SET Password = @Password,  WHERE ID = @ID; ";
                AddEmployeeCommand.Parameters.AddWithValue("@Password", Password);

                AddEmployeeCommand.ExecuteReader();
                db.Close();

            }


        }
        public static void DeleteEmployee(int ID)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=EmployeeTable.db"))
            {
                db.Open();
                SqliteCommand AddEmployeeCommand = new SqliteCommand();
                AddEmployeeCommand.Connection = db;
                AddEmployeeCommand.CommandText = "DELETE FROM EmployeeTable WHERE ID =@ID;";
                AddEmployeeCommand.Parameters.AddWithValue("@ID", ID);



                AddEmployeeCommand.ExecuteReader();
                db.Close();

            }


        }
    }
}

