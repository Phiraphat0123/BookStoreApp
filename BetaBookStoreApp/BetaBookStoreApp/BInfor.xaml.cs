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
    /// Interaction logic for BInfor.xaml
    /// </summary>
    public partial class BInfor : Window
    {
        private string ISBN;
        private string Title;
        private string Description;
        private string Price;

        public BInfor()
        {
            InitializeComponent();
            Data.CreatBookTable();
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            ISBN = txtISBN.Text;
            Title = txtTitle.Text;
            Description = txtDescription.Text;
            Price = txtPrice.Text;
            Data.AddDataBook(ISBN,Title,Description,Price);
            txtDescription.Text = "";
            txtISBN.Text = "";
            txtPrice.Text = "";
            txtTitle.Text = "";
        }

        private void ShowAllBook_Click(object sender, RoutedEventArgs e)
        {
            ISBN = txtISBN.Text;
            Title = txtTitle.Text;
            Description = txtDescription.Text;
            Price = txtPrice.Text;
            string data = "";
            Boolean checkISBN= false;
            Boolean checkTitle = false;
            Boolean checkDescription = false;
            
            if (Price != "") 
                {
                MessageBox.Show("Please delete price information.", "ERROR");
                }
            else
                if (ISBN != "" || Title != "" || Description != ""  )
                 {
                    foreach (string isbn in Data.GetBook("SELECT ISBN FROM BookTable")) 
                    {
                        if (ISBN == isbn) checkISBN =true;
                    }
                    

                if (checkISBN == true )
                {
                    foreach (string show in Data.GetBook("SELECT *", "FROM BookTable WHERE ISBN='"+ISBN+"'"))
                    {
                        data = data + show + '\n';
                    }
                    MessageBox.Show(data, "Show " + ISBN);
                    
                }
                else { MessageBox.Show("Please delete the information.","ERROR"); }
                }
            else
                if (ISBN == "" || Title == "" || Description == "" || Price == "")
                {
                    foreach (string showAll in Data.GetBook("SELECT ISBN FROM BookTable"))
                    {
                        data = data + showAll + '\n';
                    }
                        MessageBox.Show(data);
                }
            
                
            }
            
           
        }
    }

