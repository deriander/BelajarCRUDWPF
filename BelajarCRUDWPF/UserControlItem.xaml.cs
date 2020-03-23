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
            idSup = Convert.ToInt32(cbSupplier.SelectedValue.ToString());
        }

        public void updateCbSupplier()
        {
            cbSupplier.ItemsSource = con.Suppliers.ToList();
        }

        private void btnInsertItem_Click(object sender, RoutedEventArgs e)
        {
            if (txtNameItem.Text == "" || txtPriceItem.Text == "" || txtStockItem.Text == "" || cbSupplier.Text == "")
            {
                MessageBox.Show("Please fill name field and address field");
            }
            else
            {
                if (Regex.IsMatch(txtNameItem.Text, "[^a-zA-Z0-9]"))
                {
                    MessageBox.Show("Format item name is wrong");
                }
                else
                {
                    var iPrice = Convert.ToInt32(txtPriceItem.Text);
                    var iStock = Convert.ToInt32(txtStockItem.Text);
                    var get_supplier_id = con.Suppliers.Where(si => si.Id == idSup).FirstOrDefault();
                    var input = new Item(txtNameItem.Text, iPrice, iStock, get_supplier_id);
                    con.Items.Add(input);
                    con.SaveChanges();
                    MessageBox.Show("Item has been inserted");
                    txtIdItem.Text = "";
                    txtNameItem.Text = "";
                    txtPriceItem.Text = "";
                    txtStockItem.Text = "";
                    tblItem.ItemsSource = con.Items.ToList();
                }
            }
        }

        private void btnUpdateItem_Click(object sender, RoutedEventArgs e)
        {
            if (txtNameItem.Text == "" || txtPriceItem.Text == "" || txtStockItem.Text == "" || cbSupplier.Text == "")
            {
                MessageBox.Show("Please fill all field");
            }
            else
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
                MessageBox.Show(update + " data has been updated");
                txtIdItem.Text = "";
                txtNameItem.Text = "";
                txtPriceItem.Text = "";
                txtStockItem.Text = "";
                tblItem.ItemsSource = con.Items.ToList();
                cbSupplier.ItemsSource = con.Suppliers.ToList();
            }
        }

        private void btnDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult delConf = MessageBox.Show("Are you sure delete this data?", "Delete data", MessageBoxButton.YesNo);
            switch (delConf)
            {
                case MessageBoxResult.Yes:
                    int delete_item = Convert.ToInt32(txtIdItem.Text);
                    var cek_item_id = con.Items.Where(s => s.Id == delete_item).FirstOrDefault();
                    con.Items.Remove(cek_item_id);
                    var delete = con.SaveChanges();
                    MessageBox.Show(delete + " data has been deleted");
                    txtIdItem.Text = "";
                    txtNameItem.Text = "";
                    txtPriceItem.Text = "";
                    txtStockItem.Text = "";
                    tblItem.ItemsSource = con.Items.ToList();
                    cbSupplier.ItemsSource = con.Suppliers.ToList();
                    break;
                case MessageBoxResult.No:

                    break;
            }
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
    }
}
