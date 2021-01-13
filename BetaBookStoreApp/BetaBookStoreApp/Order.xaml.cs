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
        public Order()
        {
            InitializeComponent();
            Data.CreatTransactionTable();
        }

        public string CusID1 { get => CusID; set => CusID = txtCusIDO.Text; }
        public string ISBN1 { get => ISBN; set => ISBN = txtISBNO.Text; }
        public string NumberOfBook1 { get => NumberOfBook; set => NumberOfBook = txtNumberOfBook.Text; }

        private void checkBook_Click(object sender, RoutedEventArgs e)
        {
            ISBN1 = txtISBNO.Text;
            string data = "";
            Boolean checkISBN = false;
            foreach (string isbn in Data.GetBook("SELECT ISBN FROM BookTable;"))
            {
                if (ISBN1 == isbn) checkISBN = true;
            }

            if (checkISBN == true)
            {
                foreach (string show in Data.GetBook("SELECT *", "FROM BookTable WHERE ISBN='" + ISBN1 + "';"))
                {
                    data = data + show + '\n';

                }
                MessageBox.Show(data, "Show book ID " + ISBN1);

            }
            else
            {
                MessageBox.Show("No information required.", "ERROR");
            }
        }

        private void checkCustomerID_Click(object sender, RoutedEventArgs e)
        {
            CusID1 = txtCusIDO.Text;
            string data = "";
            Boolean check = false;
            foreach (string cusid in Data.GetCustomer("SELECT CustomerID FROM CustomerTable;"))
            {
                if (CusID1 == cusid) check = true;
            }

            if (check == true)
            {
                foreach (string show in Data.GetCustomer("SELECT *", "FROM CustomerTable WHERE CustomerID='" + CusID1 + "';"))
                {
                    data = data + show + '\n';
                }
                MessageBox.Show(data, "Show customer ID " + CusID1);

            }
            else
            {
                MessageBox.Show("Please delete Customer ID information.", "ERROR");
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
            CusID1 = txtCusIDO.Text;
            ISBN1 = txtISBNO.Text;
            NumberOfBook1 = txtNumberOfBook.Text;
            if (CusID1 =""||) 
            { 
                
            }
        }
    }
}
