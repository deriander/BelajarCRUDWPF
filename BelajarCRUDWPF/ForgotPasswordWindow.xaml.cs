using BelajarCRUDWPF.MyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

namespace BelajarCRUDWPF
{
    /// <summary>
    /// Interaction logic for ForgotPasswordWindow.xaml
    /// </summary>
    public partial class ForgotPasswordWindow : Window
    {
        myContext con = new myContext();
        public ForgotPasswordWindow()
        {
            InitializeComponent();
        }

        private void btnSendPassword_Click(object sender, RoutedEventArgs e)
        {
            var userData = con.Suppliers.Where(s => s.Email == txtEmail.Text).FirstOrDefault();
            if (userData == null)
            {
                MessageBox.Show("Email tidak terdaftar");
            }
            else
            {
                string newPassword = System.Guid.NewGuid().ToString();
                userData.Password = newPassword;
                var update = con.SaveChanges();
                sendPasswordToEmail(userData.Email, newPassword, userData.Name);
                MessageBox.Show("Please check your email");
            }
        }

        private void sendPasswordToEmail(string email, string password, string name)
        {
            MailMessage mm = new MailMessage("yrsproject15@gmail.com", email);
            mm.Subject = string.Format("FORGOT PASSWORD: New Password - {0}", DateTime.Now);
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

        private void btnBackToLoginWindow_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
