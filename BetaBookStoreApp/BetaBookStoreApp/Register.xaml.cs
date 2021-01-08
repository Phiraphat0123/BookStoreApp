using BookStoreProject;
using System;
using System.Collections;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private int EmID;
       private string Pw;
        public Register()
        {
            InitializeComponent();
            Data.CreatEmployeeTable();
        }

        private void BHome_click(object sender, RoutedEventArgs e)
        {
            MainWindow M = new MainWindow();
            M.Show();
            this.Close();
        }

        private void BAddEm_click(object sender, RoutedEventArgs e)
        {   EmID =int.Parse( txtIdEm.Text);
            Pw = txtPw.Text;
            Boolean Check = false;
            foreach (string data in Data.GetEmployee()) {
                if (txtIdEm.Text == data || txtPw.Text == data)
                {
                    Check = true;
                }
                else {
                    Check = false;
                }
            
            }
            if (Check == false)
            {
                Data.AddDataEmployee(EmID, Pw);
            }
            else {
                MessageBox.Show("Adding your data is not possible because it is duplicated with existing data.", "Error");
            }
            txtIdEm.Text = "";
            txtPw.Text = "";
        }

        private void BDeleteEm_Click(object sender, RoutedEventArgs e)
        {
            EmID = int.Parse(txtIdEm.Text);
            Pw = txtPw.Text;
            Data.DeleteEmployee(EmID);
        }

        private void BEditEm_Click(object sender, RoutedEventArgs e)
        {
            EmID = int.Parse(txtIdEm.Text);
            Pw = txtPw.Text;
            Data.UpdateEmployee(EmID,Pw);
        }

        private void BSeachEM_Click(object sender, RoutedEventArgs e)
        {
            string data="";
            foreach (string EmData in Data.GetEmployee()) {
                data = data + EmData + '\n';
            }
            MessageBox.Show(data);

        }
    }
}
