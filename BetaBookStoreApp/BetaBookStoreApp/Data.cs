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
                    "EXISTS BookTable (ISBN NVARCHAR(10) NOT NULL PRIMARY KEY, " +
                    "Title NVARCHAR(10), " + 
                    "Description NVARCHAR(10)," +
                    "Price NVARCHAR(9)  )";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
        public static void AddDataBook(string ISBN, string Title,string Description,string Price)
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
        public static List<String> GetBook(string Input)
        {
            List<string> data = new List<string>();

            using (SqliteConnection db = new SqliteConnection("Filename=BookTable.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand(Input, db);
                

                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    data.Add(query.GetString(0));
                    


                }
                db.Close();
            }
            return data;
        }
        public static List<String> GetBook(string Input1,string Input2)
        {
            //string mixInput = Input1 + Input2;
            List<string> data = new List<string>();

            using (SqliteConnection db = new SqliteConnection("Filename=BookTable.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand(Input1 + Input2, db);


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
        public static void UpdateBook(string Input)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=BookTable.db"))
            {
                db.Open();
                SqliteCommand AddBookCommand = new SqliteCommand();
                AddBookCommand.Connection = db;
                AddBookCommand.CommandText = Input;


                AddBookCommand.ExecuteReader();
                db.Close();

            }

        }
        public static void DeleteBook(string ISBN)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=BookTable.db"))
            {
                db.Open();
                SqliteCommand BookCommand = new SqliteCommand();
                BookCommand.Connection = db;
                BookCommand.CommandText = "DELETE FROM BookTable WHERE ISBN =@ISBN;";
                BookCommand.Parameters.AddWithValue("@ISBN", ISBN);



                BookCommand.ExecuteReader();
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
                    "EXISTS EmployeeTable (ID NVARCHAR(10) NOT NULL PRIMARY KEY, " +
                    "Password NVARCHAR(10) NOT NULL );";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
        public static void AddDataEmployee(string ID, string Password)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=EmployeeTable.db"))
            {
                db.Open();
                SqliteCommand AddEmployeeCommand = new SqliteCommand();
                AddEmployeeCommand.Connection = db;
                AddEmployeeCommand.CommandText = "INSERT INTO EmployeeTable VALUES(@ID,@Password);";
                AddEmployeeCommand.Parameters.AddWithValue("@ID", ID);
                AddEmployeeCommand.Parameters.AddWithValue("@Password", Password);
                AddEmployeeCommand.ExecuteReader();
                db.Close();

            }

        }
        public static List<String> GetEmployee(string Input)
        {
            List<string> data = new List<string>();

            using (SqliteConnection db = new SqliteConnection("Filename=EmployeeTable.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand(Input, db);
                
               
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    data.Add(query.GetString(0));
                    

                }
                db.Close();
            }
            return data;
        }
        public static void UpdateEmployee(string Input)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=EmployeeTable.db"))
            {
                db.Open();
                SqliteCommand AddEmployeeCommand = new SqliteCommand();
                AddEmployeeCommand.Connection = db;
                AddEmployeeCommand.CommandText = Input;
                

                AddEmployeeCommand.ExecuteReader();
                db.Close();

            }
 
        }
        public static void DeleteEmployee(string ID)
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
        //Customers Data
        public static void CreatCustomerTable()
        {

            using (SqliteConnection db =
               new SqliteConnection("Filename=CustomerTable.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS CustomerTable (CustomerID NVARCHAR(10) NOT NULL PRIMARY KEY, " + 
                    "CustomerName NVARCHAR(100) NOT NULL ," + 
                    "Address NVARCHAR(300) NOT NULL ," +
                    "Email NVARCHAR(100) NOT NULL )";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
        public static void AddDataCustomer(string CustomerID, string CustomerName,string Address,string Email)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=CustomerTable.db"))
            {
                db.Open();
                SqliteCommand AddCustomerCommand = new SqliteCommand();
                AddCustomerCommand.Connection = db;
                AddCustomerCommand.CommandText = "INSERT INTO CustomerTable VALUES(@CustomerID,@CustomerName,@Address,@Email);";
                AddCustomerCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
                AddCustomerCommand.Parameters.AddWithValue("@CustomerName", CustomerName);
                AddCustomerCommand.Parameters.AddWithValue("@Address", Address);
                AddCustomerCommand.Parameters.AddWithValue("@Email", Email);
                AddCustomerCommand.ExecuteReader();
                db.Close();

            }

        }
        public static List<String> GetCustomer(string Input)
        {
            List<string> data = new List<string>();

            using (SqliteConnection db = new SqliteConnection("Filename=CustomerTable.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand(Input, db);


                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    data.Add(query.GetString(0));


                }
                db.Close();
            }
            return data;
        }
        public static List<String> GetCustomer(string Input1,string Input2)
        {
            List<string> data = new List<string>();

            using (SqliteConnection db = new SqliteConnection("Filename=CustomerTable.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand(Input1+Input2, db);


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
        public static void UpdateCustomer(string Input)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=CustomerTable.db"))
            {
                db.Open();
                SqliteCommand AddCustomerCommand = new SqliteCommand();
                AddCustomerCommand.Connection = db;
                AddCustomerCommand.CommandText = Input;


                AddCustomerCommand.ExecuteReader();
                db.Close();

            }

        }
        public static void DeleteCustomer(string CustomerID)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=CustomerTable.db"))
            {
                db.Open();
                SqliteCommand AddCustomerCommand = new SqliteCommand();
                AddCustomerCommand.Connection = db;
                AddCustomerCommand.CommandText = "DELETE FROM CustomerTable WHERE CustomerID = @CustomerID;";
                AddCustomerCommand.Parameters.AddWithValue("@CustomerID", CustomerID);



                AddCustomerCommand.ExecuteReader();
                db.Close();

            }


        }
        //history transaction Data
        public static void CreatTransactionTable()
        {

            using (SqliteConnection db =
               new SqliteConnection("Filename=transactionTable.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS transactionTable (ISBN NVARCHAR(10) NOT NULL , " +
                    "CustomerID NVARCHAR(10) NOT NULL ," +
                    "Price NVARCHAR(9) NOT NULL )";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
        public static void AddDataTransaction(string ISBN, string CustomerID, string Price)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=TransactionTable.db"))
            {
                db.Open();
                SqliteCommand AddTransactionCommand = new SqliteCommand();
                AddTransactionCommand.Connection = db;
                AddTransactionCommand.CommandText = "INSERT INTO TransactionTable VALUES(@ISBN,@CustomerID,@Price);";
                AddTransactionCommand.Parameters.AddWithValue("@ISBN", ISBN);
                AddTransactionCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
                AddTransactionCommand.Parameters.AddWithValue("@Price", Price);
                AddTransactionCommand.ExecuteReader();
                db.Close();

            }

        }
        public static void DeleteTransaction()
        {
            using (SqliteConnection db = new SqliteConnection("Filename=TransactionTable.db"))
            {
                db.Open();
                SqliteCommand AddTransactionCommand = new SqliteCommand();
                AddTransactionCommand.Connection = db;
                AddTransactionCommand.CommandText = "DELETE FROM TransactionTable ;";
               
                AddTransactionCommand.ExecuteReader();
                db.Close();

            }


        }
        public static List<String> GetTransaction(string Input1,string Input2)
        {
            List<string> data = new List<string>();

            using (SqliteConnection db = new SqliteConnection("Filename=TransactionTable.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand(Input1 +Input2, db);


                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    data.Add(query.GetString(0));
                    data.Add(query.GetString(1));
                    data.Add(query.GetString(2));
                    


                }
                db.Close();
            }
            return data;
        }
        public static List<String> GetTransaction(string Input)
        {
            List<string> data = new List<string>();

            using (SqliteConnection db = new SqliteConnection("Filename=TransactionTable.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand(Input , db);


                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    data.Add(query.GetString(0));
                   



                }
                db.Close();
            }
            return data;
        }
    }
}

