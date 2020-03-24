using BelajarCRUDWPF.Model;
using BelajarCRUDWPF.MyContext;
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
using System.Text.RegularExpressions;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.Configuration;

namespace BelajarCRUDWPF
{
    /// <summary>
    /// Interaction logic for UserControlSupplier.xaml
    /// </summary>
    public partial class UserControlSupplier : UserControl
    {
        myContext con = new myContext();
        public UserControlSupplier()
        {
            InitializeComponent();
            tblSupplier.ItemsSource = con.Suppliers.ToList();
        }

        private void txtIdSupplier_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNameSupplier_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtAddressSupplier_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtEmailSupplier_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private Boolean emailValidation(string email)
        {
            int charPos = email.IndexOf("@");
            Boolean valid = true;
            
            if(charPos == -1)
            {
                valid = false;
            }
            else
            {
                string nameEmail = email.Substring(0, charPos);
                string domainEmail = email.Substring(charPos + 1);
                if (Regex.IsMatch(nameEmail, "[^a-zA-Z0-9.]"))
                {
                    valid = false;
                }

                if (domainEmail != "gmail.com" && domainEmail != "yahoo.com" && domainEmail != "outlook.com")
                {
                    valid = false;
                }
            }
            
            return valid;
        }

        private void sendPasswordToEmail(string email, string password, string name)
        {
            MailMessage mm = new MailMessage("yrsproject15@gmail.com", email);
            mm.Subject = string.Format("New Password To Login - {0}", DateTime.Now);
            mm.Body = string.Format("Hi {0},<br /><br />This is your password to login in System {1}<br /><br />Thank You.", name, password);
            mm.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;

            NetworkCredential NetworkCred = new NetworkCredential();
            NetworkCred.UserName = "yrsproject15@gmail.com";
            NetworkCred.Password = "yarsiproject2015";

            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            try
            {
                smtp.Send(mm);
            }
            catch
            {

            }
        }
        
        private void tblSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var data = tblSupplier.SelectedItem;
                string id = (tblSupplier.SelectedCells[0].Column.GetCellContent(data) as TextBlock).Text;
                txtIdSupplier.Text = id;
                string name = (tblSupplier.SelectedCells[1].Column.GetCellContent(data) as TextBlock).Text;
                txtNameSupplier.Text = name;
                string address = (tblSupplier.SelectedCells[2].Column.GetCellContent(data) as TextBlock).Text;
                txtAddressSupplier.Text = address;
                string email = (tblSupplier.SelectedCells[3].Column.GetCellContent(data) as TextBlock).Text;
                txtEmailSupplier.Text = email;
            }
            catch
            {

            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            emptyFields();
        }

        public void emptyFields()
        {
            txtIdSupplier.Text = "";
            txtNameSupplier.Text = "";
            txtAddressSupplier.Text = "";
            txtEmailSupplier.Text = "";
        }

        private void btnSearchSupplier_Click(object sender, RoutedEventArgs e)
        {
            string search = txtSearchSupplier.Text;
            List<Supplier> result = new List<Supplier>();
            List<Supplier> table = con.Suppliers.ToList();

            if (txtSearchSupplier == null)
            {
                tblSupplier.ItemsSource = con.Suppliers.ToList();
            }
            else
            {
                foreach (Supplier row in table)
                {
                    if (row.Id.ToString().Contains(search.ToLower()) || row.Name.ToLower().Contains(search.ToLower()) 
                        || row.Address.ToLower().Contains(search.ToLower()) || row.Email.ToLower().Contains(search.ToLower()))
                    {
                        result.Add(row);
                    }
                }
                tblSupplier.ItemsSource = result.ToList();
            }  
        }

        private void btnDeleteRow_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult delConf = MessageBox.Show("Are you sure delete this data?", "Delete data", MessageBoxButton.YesNo);
            switch (delConf)
            {
                case MessageBoxResult.Yes:
                    var data = tblSupplier.SelectedItem;
                    emptyFields();
                    int id = Convert.ToInt32((tblSupplier.SelectedCells[0].Column.GetCellContent(data) as TextBlock).Text);
                    var rowSupplier = con.Suppliers.Where(s => s.Id == id).FirstOrDefault();
                    var rowRole = con.Roles.Where(s => s.Supplier.Id == rowSupplier.Id).FirstOrDefault();
                    con.Roles.Remove(rowRole);
                    con.Suppliers.Remove(rowSupplier);
                    var update = con.SaveChanges();
                    MessageBox.Show(update + " Data has been deleted");
                    emptyFields();
                    tblSupplier.ItemsSource = con.Suppliers.ToList();
                    break;
                case MessageBoxResult.No:

                    break;
            }
        }
            

        private void btnSaveSupplier_Click(object sender, RoutedEventArgs e)
        {
            if (txtNameSupplier.Text == "") { MessageBox.Show("Please input field Name Supplier"); txtNameSupplier.Focus(); }
            else if (txtAddressSupplier.Text == "") { MessageBox.Show("Please input field Address Suplier"); txtAddressSupplier.Focus(); }
            else if (txtEmailSupplier.Text == "") { MessageBox.Show("Please input field Email Supplier"); txtEmailSupplier.Focus(); }
            else
            {
                if (txtIdSupplier.Text == "")
                {
                    //input table supplier
                    string password = System.Guid.NewGuid().ToString();
                    var input = new Supplier(txtNameSupplier.Text, txtAddressSupplier.Text, txtEmailSupplier.Text, password);
                    con.Suppliers.Add(input);
                    con.SaveChanges(); //save

                    //input table role
                    var cek_admin_id = con.Suppliers.Where(s => s.Email == txtEmailSupplier.Text).FirstOrDefault();
                    var inputRole = new Role("Member", cek_admin_id);
                    con.Roles.Add(inputRole);
                    var update = con.SaveChanges(); //save

                    sendPasswordToEmail(txtEmailSupplier.Text, password, txtNameSupplier.Text); //send to email
                    MessageBox.Show(update + " Data has been inserted & password has been send to email");
                    emptyFields();
                    tblSupplier.ItemsSource = con.Suppliers.ToList();
                }
                else
                {
                    int supply_id = Convert.ToInt32(txtIdSupplier.Text);
                    var cek_supply_id = con.Suppliers.Where(s => s.Id == supply_id).FirstOrDefault();
                    cek_supply_id.Name = txtNameSupplier.Text;
                    cek_supply_id.Address = txtAddressSupplier.Text;
                    cek_supply_id.Email = txtEmailSupplier.Text;
                    var update = con.SaveChanges();
                    MessageBox.Show(update + " Data has been updated");
                    emptyFields();
                    tblSupplier.ItemsSource = con.Suppliers.ToList();
                }
            }
        }
    }
}
