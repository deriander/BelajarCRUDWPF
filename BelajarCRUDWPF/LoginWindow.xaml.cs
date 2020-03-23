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
using System.Windows.Shapes;

namespace BelajarCRUDWPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        myContext con = new myContext();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            ForgotPasswordWindow forgotPassWindow = new ForgotPasswordWindow();
            forgotPassWindow.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var dataLogin = con.Suppliers.Where(s => s.Email == txtEmailLogin.Text).FirstOrDefault();
            if (dataLogin == null)
            {
                MessageBox.Show("Email not registered");
            }
            else
            {
                if (dataLogin.Email == txtEmailLogin.Text && dataLogin.Password == txtPasswordLogin.Text)
                {
                    var dataRole = con.Roles.Where(s => s.Supplier.Id == dataLogin.Id).FirstOrDefault();
                    MainWindow mainWindow = new MainWindow(dataRole.Name);
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
        }
    }
}
