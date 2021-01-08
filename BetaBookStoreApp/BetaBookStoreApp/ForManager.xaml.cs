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
        Register register;
        MainWindow main; 
       
    

        public ForManager()
        {
            InitializeComponent();
            register = new Register();
            main = new MainWindow();
        }

       
        

        private void submit_click(object sender, RoutedEventArgs e)
        {//idmanager = 0123456789 password = Jbil0123
            maID = int.Parse(txtIdMa.Text);
            maPw = txtPassw.Password;
            /* if (maID!=0123456789 || maPw!="jbil0123") {
                 MessageBox.Show("Password or ID is not correct.");
                 this.Close();
             }*/
            if (maID.Equals(null)||maPw==null) { 
                
            }else
            if (maID == 0123456789 && maPw == "0123")
            {
                
                register.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Password or ID is not correct.");
                main.Show();
                this.Close();
            }
        }
    }
}
