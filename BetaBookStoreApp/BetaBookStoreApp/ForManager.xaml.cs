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
    /// Interaction logic for ForManager.xaml
    /// </summary>
   
    public partial class ForManager : Window
    {
        private int maID;
        private string maPw;
      
        
        
       
    

        public ForManager()
        {
            InitializeComponent();
            
            
        }

       
        

        private void submit_click(object sender, RoutedEventArgs e)
        {//idmanager = 0123456789 password = Jbil0123
            maID = int.Parse(txtIdMa.Text);
            maPw = txtPassw.Password;
            /* if (maID!=1234567890 || maPw!="jbil0123") {
                 MessageBox.Show("Password or ID is not correct.");
                 this.Close();
             }*/
            if (maID.Equals(null)||maPw==null) {
                MessageBox.Show("Please enter information", "ERROR");
            }else
            if (maID == 1234567890 && maPw == "jbil0123")
            {
                Register register = new Register();
                register.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Password or ID is not correct.");
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
        }

        private void BHome_click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
