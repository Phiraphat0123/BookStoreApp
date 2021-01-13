using BookStoreProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BetaBookStoreApp
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : Window
    {   private  string CusID;
        private string ISBN;
        private string NumberOfBook;
        private float TotalPrice;
        private string[] TopicHistory = {"ISBN: ","CUSTOMER ID: ","Price: "};
        int TopicCount = 0;



        public Order()
        {
            InitializeComponent();
            Data.CreatTransactionTable();
           
        }

        private void checkBook_Click(object sender, RoutedEventArgs e)
        {
            ISBN = txtISBNO.Text;
            string data = "";
            Boolean checkISBN = false;
            foreach (string isbn in Data.GetBook("SELECT ISBN FROM BookTable;"))
            {
                if (ISBN == isbn) checkISBN = true;
            }

            if (checkISBN == true)
            {
                foreach (string show in Data.GetBook("SELECT *", "FROM BookTable WHERE ISBN='" + ISBN + "';"))
                {
                    data = data + show + '\n';

                }
                MessageBox.Show(data, "Show book ID " + ISBN);

            }
            else
            {
                MessageBox.Show("No information required.", "ERROR");
            }
        }

        private void checkCustomerID_Click(object sender, RoutedEventArgs e)
        {
            CusID = txtCusIDO.Text;
            string data = "";
            Boolean check = false;
            foreach (string cusid in Data.GetCustomer("SELECT CustomerID FROM CustomerTable;"))
            {
                if (CusID == cusid) check = true;
            }

            if (check == true)
            {
                foreach (string show in Data.GetCustomer("SELECT *", "FROM CustomerTable WHERE CustomerID='" + CusID + "';"))
                {
                    data = data + show + '\n';
                }
                MessageBox.Show(data, "Show customer ID " + CusID);

            }
            else
            {
                MessageBox.Show("No information required.", "ERROR");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Close();
        }

        private void Orderconfirmation_Click(object sender, RoutedEventArgs e)
        {
            CusID = txtCusIDO.Text;
            ISBN = txtISBNO.Text;
            NumberOfBook = txtNumberOfBook.Text;
            string data = "";
            string Price ="";
            Boolean checkISBN = false;
            Boolean checkCusID = false;

            if (CusID == "" || ISBN == "" || NumberOfBook == "")
            {
                MessageBox.Show("Please enter all information", "ERROR");
            }
            else
            if (CusID != "" || ISBN != "" || NumberOfBook != "")
            {
                
                foreach (string infor in Data.GetCustomer("SELECT CustomerID FROM CustomerTable WHERE CustomerID ='" + CusID + "';"))
                {
                    if (CusID == infor) checkCusID = true;
                }
                foreach (string infor in Data.GetBook("SELECT ISBN FROM BookTable WHERE ISBN ='" + ISBN + "';"))
                {
                    if (ISBN == infor) checkISBN = true;
                }

                if (checkISBN == true && checkCusID == true)
                {
                    foreach (string price in Data.GetBook("SELECT Price FROM BookTable WHERE ISBN ='" + ISBN + "';"))
                    {
                        Price = price;
                    }

                    TotalPrice = float.Parse(Price) * float.Parse(NumberOfBook);
                    Data.AddDataTransaction(ISBN, CusID, TotalPrice.ToString());

                    foreach (string infor in Data.GetTransaction("SELECT * FROM TransactionTable WHERE ", "ISBN ='" + ISBN + "';"))
                    {
                        data = data + TopicHistory[TopicCount] + infor + '\n';
                        TopicCount++;
                        if (TopicCount == 3) TopicCount = 0;
                    }
                    MessageBox.Show(data, "Order list ");
                    txtCusIDO.Text = "";
                    txtISBNO.Text = "";
                    txtNumberOfBook.Text = "";
                }
                else
                if (checkCusID == false)
                {
                    MessageBox.Show("No customer ID information found. Please enter again.", "ERROR");
                }

                else
                if (checkISBN == false)
                {
                    MessageBox.Show("ISBN information not found. Please enter again.", "ERROR");
                }
            }
        }

        private void DeleteAllHistory_Click(object sender, RoutedEventArgs e)
        {
            Data.DeleteTransaction();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        { 
            string data = "";
           
            foreach (string infor in Data.GetTransaction("SELECT *  ", "FROM TransactionTable;"))
            {   
                data = data +TopicHistory[TopicCount]+ infor + '\n';
                TopicCount++;
                if (TopicCount == 3) TopicCount = 0;  
                
            }
            MessageBox.Show(data,"Show all transaction ");
        }
    }
}
