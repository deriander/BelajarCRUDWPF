using BelajarCRUDWPF.Model;
using BelajarCRUDWPF.MyContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace BelajarCRUDWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        myContext con = new myContext();
        public MainWindow()
        {
            InitializeComponent();
            tblSupplier.ItemsSource = con.Suppliers.ToList();
        }

        private void tblSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var data = tblSupplier.SelectedItem;
            string id = (tblSupplier.SelectedCells[0].Column.GetCellContent(data) as TextBlock).Text;
            txtId.Text = id;
            string name = (tblSupplier.SelectedCells[1].Column.GetCellContent(data) as TextBlock).Text;
            txtName.Text = name;
            string address = (tblSupplier.SelectedCells[2].Column.GetCellContent(data) as TextBlock).Text;
            txtAddress.Text = address;
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please fill name field and address field");
            }
            else
            {
                var input = new supplier(txtName.Text, txtAddress.Text);
                con.Suppliers.Add(input);
                var insert = con.SaveChanges();
                MessageBox.Show(insert + "Has been inserted");
                txtName.Text = "";
                txtAddress.Text = "";
                txtId.Text = "";
                tblSupplier.ItemsSource = con.Suppliers.ToList();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtId.Text == "")
            {
                MessageBox.Show("Please fill all field");
            }
            else
            {
                int supply_id = Convert.ToInt32(txtId.Text);
                var cek_supply_id = con.Suppliers.Where(s => s.Id == supply_id).FirstOrDefault();
                cek_supply_id.Name = txtName.Text;
                cek_supply_id.Address = txtAddress.Text;
                var update = con.SaveChanges();
                MessageBox.Show(update + " has been updated");
                txtId.Text = "";
                txtName.Text = "";
                txtAddress.Text = "";
                tblSupplier.ItemsSource = con.Suppliers.ToList();
            }            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int delete_supply = Convert.ToInt32(txtId.Text);
            var cek_supply_id = con.Suppliers.Where(s => s.Id == delete_supply).FirstOrDefault();
            con.Entry(cek_supply_id).State = EntityState.Deleted;
            //con.Suppliers.Remove(cek_supply_id);
            var delete = con.SaveChanges();
            MessageBox.Show(delete + " has been deleted");
            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            tblSupplier.ItemsSource = con.Suppliers.ToList();
        }

        private void txtId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
