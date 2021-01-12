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
        private string CUSName;
        private string Address;
        private string Email;
        public CusInfor()
        {
            InitializeComponent();
            Data.CreatCustomerTable();
        }

        private void AddCus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditCus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowAllCus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteCus_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
