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
     
        
        
        public Dashboard()
        {
            InitializeComponent();
              
        }

        

        private void BBookIn_Click(object sender, RoutedEventArgs e)
        {
            BInfor Book = new BInfor();
            Book.Show();
            this.Close();
        }

        private void BCustomerIn_Click(object sender, RoutedEventArgs e)
        {
            CusInfor customer = new CusInfor();
            customer.Show();
            this.Close();
        }

        private void BTransactionIn_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order();
            order.Show();
            this.Close();
        }
    }
}
