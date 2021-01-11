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
using System.Windows.Navigation;
using System.Windows.Shapes;




namespace BetaBookStoreApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   private string EmID;
        private string Pw;
        Dashboard dash;
        public MainWindow()
        {
           
            InitializeComponent();
            Data.CreatEmployeeTable();
            dash = new Dashboard();


        }
        
        private void BRegister_Click(object sender, RoutedEventArgs e)
        {   
            
            ForManager Ma = new ForManager();
            Ma.Show();
            this.Close();
        }

        private void BSignIn_Click(object sender, RoutedEventArgs e)
        {
            EmID = txtID.Text;
            Pw = txtPw.Password;
            Boolean checkId= false;
            Boolean checkPw = false;
            foreach (string dataId in Data.GetEmployee("SELECT ID FROM EmployeeTable ")) 
            {
                if (EmID == dataId) {
                    checkId = true;
                }
                
            }
            foreach (string dataPw in Data.GetEmployee("SELECT Password FROM EmployeeTable"))
            {
                if (Pw == dataPw) 
                {
                    checkPw = true;
                }
               
            }
            if (EmID == "" || Pw == "")
            {
                MessageBox.Show("Please enter information.", "ERROR");
            }
            else
            if (checkId == true && checkPw == true)
            {
                dash.Show();
                this.Close();
                EmID = "";
                Pw = "";
            }
            else 
            {
                MessageBox.Show("The ID or Password is incorrect, please try again.", "ERROR");
            
            }

        }

        
    }
}
