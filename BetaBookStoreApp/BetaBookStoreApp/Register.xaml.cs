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
        private string EmID;
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
         {     
            EmID = txtIdEm.Text;
            Pw = txtPw.Text;
            Boolean Check = false;
            if (EmID == "" || Pw == "")
            {
                MessageBox.Show("Unable to add empty data.","ERROR");
            }
            else { 
            foreach (string EmId in Data.GetEmployee("SELECT ID FROM EmployeeTable;")) {
                if (txtIdEm.Text == EmId || txtPw.Text == EmId)
                {
                    Check = true;
                }
               
            
            }
            if (Check == false)
            {
                Data.AddDataEmployee(EmID, Pw); 
                    txtIdEm.Text = null;
                    txtPw.Text = null;
            }
            else {
                MessageBox.Show("The data could not be added because the data was duplicated with the existing.", "ERROR");
            }
           
            }
        }

        private void BDeleteEm_Click(object sender, RoutedEventArgs e)
        {//จะทำการลบข้อมูลทั้งหมดในตารางจาก ID ที่ใส่ลงไป โดยจะลบจากข้อมูลที่มีเท่านั้น
            EmID = txtIdEm.Text;
            Pw = txtPw.Text;
            Boolean Check = false;
            Boolean checkId = false;
            Boolean checkPw = false;
             foreach (string ID in Data.GetEmployee("SELECT ID FROM EmployeeTable WHERE ID='1234567890';")) {
                if (EmID == ID ) {
                   Check= true;
                }
            }
          if (Check == true ) {
                MessageBox.Show("Manager's data could not be deleted.", "ERROR");
            } else 
            if(Check == false) 
            {
                foreach (string EmId in Data.GetEmployee("SELECT ID FROM EmployeeTable;"))
                {
                    if (EmID == EmId)
                    {
                        checkId = true;
                    }

                }
                foreach (string pw in Data.GetEmployee("SELECT Password FROM EmployeeTable;")) {

                    if (Pw == pw)
                    {
                        checkPw = true;
                    }

                }
                if (checkId == true && checkPw == true)
                {
                    Data.DeleteEmployee(EmID);
                    txtIdEm.Text = null;
                    txtPw.Text = null;
                } else
                { MessageBox.Show("The deletion could not be performed because there is no data.", "ERROR"); }
            }
           
        }
        private void BEditEm_Click(object sender, RoutedEventArgs e)
        {//สำหรับพนักงานที่ลืมรหัสผ่านเท่านั้น
            EmID = txtIdEm.Text;
            Boolean Check = false;
            Pw = txtPw.Text;
            Boolean check = false;
            foreach (string ID in Data.GetEmployee("SELECT ID FROM EmployeeTable WHERE ID='1234567890';"))
            {
                if (EmID == ID)
                {
                    Check = true;
                }
            }
            if (Check == true)
            {
                MessageBox.Show("The manager's information cannot be edited.", "ERROR");
            }
            else
            if (Check == false)
            {
                foreach (string EmId in Data.GetEmployee("SELECT ID FROM EmployeeTable;")) {
                if (EmId ==EmID )
                {
                    check = true;
                }
                
            }
            if (check == true)
            {
                Data.UpdateEmployee("UPDATE EmployeeTable SET Password = '"+Pw+"' WHERE ID = '"+EmID+"';");
                txtIdEm.Text = null;
                txtPw.Text = null;

            }
            else if(check == false) {

                MessageBox.Show("Cannot be edited due to lack of information.","ERROR");
            }

        }


    }

        private void BShowAllEM_Click(object sender, RoutedEventArgs e)
        {
            int count = 1;
            string data = "";
            foreach (string EmData in Data.GetEmployee("SELECT ID FROM EmployeeTable"))
            {
                data = data + count + ". " + EmData + '\n';
                count++;
            }
            MessageBox.Show(  '\n' + data, "Employee ID");

        }
    }
}
