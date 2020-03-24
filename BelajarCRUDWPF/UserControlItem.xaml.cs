using BelajarCRUDWPF.Model;
using BelajarCRUDWPF.MyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for UserControlItem.xaml
    /// </summary>
    public partial class UserControlItem : UserControl
    {
        int idSup;
        myContext con = new myContext();
        public UserControlItem()
        {
            InitializeComponent();
            tblItem.ItemsSource = con.Items.ToList();
            cbSupplier.ItemsSource = con.Suppliers.ToList();
        }

        private void txtIdItem_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtStockItem_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPriceItem_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNameItem_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                idSup = Convert.ToInt32(cbSupplier.SelectedValue.ToString());
            }
            catch
            {

            }
            
        }

        public void updateCbSupplier()
        {
            cbSupplier.ItemsSource = con.Suppliers.ToList();
        }

        

        private void tblItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var data = tblItem.SelectedItem;
                string id = (tblItem.SelectedCells[0].Column.GetCellContent(data) as TextBlock).Text;
                txtIdItem.Text = id;
                string name = (tblItem.SelectedCells[1].Column.GetCellContent(data) as TextBlock).Text;
                txtNameItem.Text = name;
                string price = (tblItem.SelectedCells[2].Column.GetCellContent(data) as TextBlock).Text;
                txtPriceItem.Text = price;
                string stock = (tblItem.SelectedCells[3].Column.GetCellContent(data) as TextBlock).Text;
                txtStockItem.Text = stock;
                string supplierName = (tblItem.SelectedCells[4].Column.GetCellContent(data) as TextBlock).Text;
                cbSupplier.Text = supplierName;
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
            txtIdItem.Text = "";
            txtNameItem.Text = "";
            txtPriceItem.Text = "";
            txtStockItem.Text = "";
            cbSupplier.SelectedIndex = -1;
        }

        private void btnDeleteRow_Click(object sender, RoutedEventArgs e)
        {
            var data = tblItem.SelectedItem;
            emptyFields();
            int id = Convert.ToInt32((tblItem.SelectedCells[0].Column.GetCellContent(data) as TextBlock).Text);
            var rowItems = con.Items.Where(s => s.Id == id).FirstOrDefault();
            con.Items.Remove(rowItems);
            var update = con.SaveChanges();
            MessageBox.Show(update + " Data has been deleted");
            tblItem.ItemsSource = con.Items.ToList();
        }

        private void btnSearchItem_Click(object sender, RoutedEventArgs e)
        {
            string search = txtSearchItem.Text;
            List<Item> result = new List<Item>();
            List<Item> table = con.Items.ToList();

            if (txtSearchItem == null)
            {
                tblItem.ItemsSource = con.Suppliers.ToList();
            }
            else
            {
                foreach (Item row in table)
                {
                    if (row.Id.ToString().Contains(search.ToLower()) || row.Name.ToLower().Contains(search.ToLower()) 
                        || row.Price.ToString().ToLower().Contains(search.ToLower())
                        || row.Stock.ToString().ToLower().Contains(search.ToLower()) 
                        || row.Supplier.Name.ToLower().Contains(search.ToLower()))
                    {
                        result.Add(row);
                    }
                }
                tblItem.ItemsSource = result.ToList();
            }
        }

        private void btnSaveItem_Click(object sender, RoutedEventArgs e)
        {
            if (txtNameItem.Text == "") { MessageBox.Show("Please input field Name Item"); txtNameItem.Focus(); }
            else if (txtPriceItem.Text == "") { MessageBox.Show("Please input field Price Item"); txtPriceItem.Focus(); }
            else if (txtStockItem.Text == "") { MessageBox.Show("Please input field Stock Item"); txtStockItem.Focus(); }
            else if (cbSupplier.SelectedIndex == -1) { MessageBox.Show("Please input Supplier"); cbSupplier.Focus(); }
            else
            {
                if (Regex.IsMatch(txtNameItem.Text, "[^a-zA-Z0-9 ]")) //cek name item
                {
                    MessageBox.Show("Format Item Name is wrong");
                    txtNameItem.Focus();
                }
                else
                {
                    if (txtIdItem.Text == "") //insert data
                    {
                        var iPrice = Convert.ToInt32(txtPriceItem.Text);
                        var iStock = Convert.ToInt32(txtStockItem.Text);
                        var get_supplier_id = con.Suppliers.Where(si => si.Id == idSup).FirstOrDefault();
                        var input = new Item(txtNameItem.Text, iPrice, iStock, get_supplier_id);
                        con.Items.Add(input);
                        var update = con.SaveChanges();
                        MessageBox.Show(update + " Data has been inserted");
                        emptyFields();
                        tblItem.ItemsSource = con.Items.ToList();
                    }
                    else //update data
                    {
                        int item_id = Convert.ToInt32(txtIdItem.Text);
                        var cek_item_id = con.Items.Where(s => s.Id == item_id).FirstOrDefault();
                        cek_item_id.Name = txtNameItem.Text;
                        cek_item_id.Price = Convert.ToInt32(txtPriceItem.Text);
                        cek_item_id.Stock = Convert.ToInt32(txtStockItem.Text);
                        idSup = Convert.ToInt32(cbSupplier.SelectedValue.ToString());
                        var get_supplier_id = con.Suppliers.Where(si => si.Id == idSup).FirstOrDefault();
                        cek_item_id.Supplier = get_supplier_id;
                        var update = con.SaveChanges();
                        MessageBox.Show(update + " Data has been updated");
                        emptyFields();
                        tblItem.ItemsSource = con.Items.ToList();
                        cbSupplier.ItemsSource = con.Suppliers.ToList();
                    }
                }
            }         
        }
    }
}
