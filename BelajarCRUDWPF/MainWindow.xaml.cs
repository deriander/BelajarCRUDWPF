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
    /// Interaction logic for MaterialDesignMainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(string role)
        {
            InitializeComponent();
            Access(role);
        }

        public void Access(string role)
        {
            if (role == "Member")
            {
                LVISupplier.Visibility = Visibility.Hidden;
                LVIItem.IsSelected = true;
            }
            else if (role == "Admin")
            {
                LVISupplier.IsSelected = true; 
            }
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;

            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControlSupplier());
                    break;

                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControlItem());
                    break;
                case 2:
                    if (MessageBox.Show("Are you sure?", "Log out", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        LoginWindow loginWindow = new LoginWindow();
                        loginWindow.Show();
                        this.Close();
                    }
                    break;
            }
        }
    }
}