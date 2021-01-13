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
        private string title;
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
            title = txtTitle.Text;
            Description = txtDescription.Text;
            Price = txtPrice.Text;
            Boolean check = false;
            
            if (ISBN == "" || title == "" || Description == "" || Price == "")
            {
                MessageBox.Show("Please enter all information.", "ERROR");
            }
            else 
            {
                foreach (string isbn in Data.GetBook("SELECT ISBN FROM BookTable;")) 
                {
                    if (ISBN == isbn) 
                    {
                        check = true;
                    }
                }
                if (check == true)
                {
                    MessageBox.Show("The data could not be added because the data was duplicated with the existing.", "ERROR");
                } else
                if (check == false) 
                {
                    Data.AddDataBook(ISBN, Title, Description, Price);
                    txtDescription.Text = "";
                    txtISBN.Text = "";
                    txtPrice.Text = "";
                    txtTitle.Text = "";
                }
            
            }
           
        }

        private void ShowAllBook_Click(object sender, RoutedEventArgs e)
        {//ถ้าหากกดปกติแบบไม่มีข้อมูลจะโชว์แค่ชื่อของหนังสือแต่ถ้าใส่ ISBN ลงในช่อง ISBN จะแสดงรายละเอียดของหนังสือเล่มนั้น
            ISBN = txtISBN.Text;
            title = txtTitle.Text;
            Description = txtDescription.Text;
            Price = txtPrice.Text;
            int count = 1;
            string data = "";
            Boolean checkISBN= false;
            
            
            if (Price != ""|| Title != ""|| Description != "") 
                {
                MessageBox.Show("Please delete the information. Title, Description, Price", "ERROR");
                }
            else
            if (ISBN != ""  )
            {
                 foreach (string isbn in Data.GetBook("SELECT ISBN FROM BookTable;")) 
                 {
                        if (ISBN == isbn) checkISBN =true;
                 }
                    
                if (checkISBN == true )
                {
                    foreach (string show in Data.GetBook("SELECT *", "FROM BookTable WHERE ISBN='"+ISBN+"';"))
                    {
                        data = data +count+". "+ show + '\n';
                        count++; 
                    }
                    MessageBox.Show(data, "Show book ID" + ISBN);
                    
                }
                else { MessageBox.Show("Please delete ISBN information.","ERROR"); 
                }
            }
            else
                if (ISBN == "" || title == "" || Description == "" || Price == "")
             {
                    foreach (string showAll in Data.GetBook("SELECT ISBN FROM BookTable;"))
                    {
                        data = data + showAll + '\n';
                    }
                        MessageBox.Show(data,"All Book");
             }
            
                
        }

        private void EditBook_Click(object sender, RoutedEventArgs e)
        {   //แก้ได้แค่ ราคา เท่านั้นโดยใส่ ISBN ลงไปในช่อง ISBN
            ISBN = txtISBN.Text;
            Price = txtPrice.Text;
            Boolean check = false;
            if (ISBN == "" || Price == "")
            {
                MessageBox.Show("Please enter ISBN and Price information.", "ERROR");
            }
            else 
            {
                foreach (string isbn in Data.GetBook("SELECT ISBN FROM BookTable;"))
                {
                    if (ISBN == isbn)
                    {
                        check = true;
                    }
                }

                if (check == true)
                {
                    Data.UpdateBook("UPDATE BookTable SET Price ='"+Price+"' WHERE ISBN ="+ISBN+";");

                    txtDescription.Text = "";
                    txtISBN.Text = "";
                    txtPrice.Text = "";
                    txtTitle.Text = "";

                }
                else
                if (check == false) 
                {
                    MessageBox.Show("Cannot be edited due to lack of information.", "ERROR");
                }

            }
        }

        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {
            ISBN = txtISBN.Text;
            Boolean check = false;
            if (ISBN == "" )
            {
                MessageBox.Show("Please enter ISBN information.", "ERROR");
            }
            else 
            {
                foreach (string isbn in Data.GetBook("SELECT ISBN FROM BookTable;"))
                {
                    if (ISBN == isbn)
                    {
                        check = true;
                    }
                }
                if (check == true )
                {
                    Data.DeleteBook(ISBN);
                    txtDescription.Text = "";
                    txtISBN.Text = "";
                    txtPrice.Text = "";
                    txtTitle.Text = "";

                }
                else
                if (check == false) 
                {
                    MessageBox.Show("The data could not be deleted because there was no data.", "ERROR");
                }
            }
        }
    }
}

