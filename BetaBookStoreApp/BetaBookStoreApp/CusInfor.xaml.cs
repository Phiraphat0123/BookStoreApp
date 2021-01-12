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
    /// Interaction logic for CusInfor.xaml
    /// </summary>
    public partial class CusInfor : Window
    {
        private string CusID;
        private string CusName;
        private string Address;
        private string Email;
        public CusInfor()
        {
            InitializeComponent();
            Data.CreatCustomerTable();
        }

        private void AddCus_Click(object sender, RoutedEventArgs e)
        {
            CusID = txtCusID.Text;
            CusName = txtCusName.Text;
            Address = txtAddress.Text;
            Email = txtEmail.Text;
            Boolean check = false;

            if (CusID == "" || CusName== "" || Address == "" || Email == "")
            {
                MessageBox.Show("Please enter all information.", "ERROR");
            }
            else
            {
                foreach (string cusid in Data.GetCustomer("SELECT CustomerID FROM CustomerTable;"))
                {
                    if (CusID == cusid)
                    {
                        check = true;
                    }
                }
                if (check == true)
                {
                    MessageBox.Show("The data could not be added because the data was duplicated with the existing.", "ERROR");
                }
                else
                if (check == false)
                {
                    Data.AddDataCustomer(CusID,CusName,Address,Email);
                    txtCusID.Text = "";
                    txtCusName.Text = "";
                    txtAddress.Text = "";
                    txtEmail.Text = "";
                }

            }

        }

        private void EditCus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowAllCus_Click(object sender, RoutedEventArgs e)
        { //ถ้าหากกดปกติแบบไม่มีข้อมูลจะโชว์แค่ชื่อของหนังสือแต่ถ้าใส่ CustomerID ลงในช่อง CustomerID จะแสดงรายละเอียดของหนังสือเล่มนั้น
            CusID = txtCusID.Text;
            CusName = txtCusName.Text;
            Address = txtAddress.Text;
            Email = txtEmail.Text;
            Boolean check = false;
            string data = "";
            
            if (Email != ""|| Address!=""||CusName !="")
            {
                MessageBox.Show("Please delete the customer's name, email address.", "ERROR");
            }
            else
            if (CusID != "" )
            {
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
                    MessageBox.Show(data, "Show " + CusID);

                }
                else
                {
                    MessageBox.Show("Please delete Customer ID information.", "ERROR");
                }
            }
            else
                if (CusID == "" || CusName == "" || Address == "" || Email == "")
            {
                foreach (string showAll in Data.GetCustomer("SELECT CustomerID FROM CustomerTable;"))
                {
                    data = data + showAll + '\n';
                }
                MessageBox.Show(data);
            }


        }

        private void DeleteCus_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
