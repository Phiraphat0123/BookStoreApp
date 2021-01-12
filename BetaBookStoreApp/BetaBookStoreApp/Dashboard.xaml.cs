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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        private BInfor Book;
        private CusInfor customer;
        
        public Dashboard()
        {
            InitializeComponent();
            Book = new BInfor();
            customer = new CusInfor();

        }

        

        private void BBookIn_Click(object sender, RoutedEventArgs e)
        {
            Book.Show();
            this.Close();
        }

        private void BCustomerIn_Click(object sender, RoutedEventArgs e)
        {
            customer.Show();
            this.Close();
        }
    }
}
