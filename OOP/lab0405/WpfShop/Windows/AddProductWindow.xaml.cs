using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

namespace WpfShop {
    /// <summary>
    /// Логика взаимодействия для AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window {
        private BindingList<ProductModel> _products;
        private ProductModel _addingProduct;

        public AddProductWindow(BindingList<ProductModel> data) {
            InitializeComponent();
            LoadProductsImages();
            SetAddingProduct();

            _products = data;
        }

        private void LoadProductsImages() {
            ImagePathComboBox.ItemsSource = Directory
                .GetFiles(@"..\..\ProductsImages\")
                .OrderBy(filename => filename)
                .Select(filename => Path.GetFullPath(filename))
            ;
        }

        private void SetAddingProduct() {
            _addingProduct = new ProductModel();
            this.DataContext = _addingProduct;
        }

        private void ClearCommand_Executed(object sender, ExecutedRoutedEventArgs e) {
            SetAddingProduct();
        }

        private void AddCommand_Executed(object sender, ExecutedRoutedEventArgs e) {
            if (_products.Where(p => p.ID == _addingProduct.ID).Count() > 0) {
                MessageBox.Show($"Товар с таким ID уже существует");
                return;
            }
            if (_addingProduct.Error.Length > 0) {
                MessageBox.Show($"Некоторые поля имеют ошибки:\n{_addingProduct.Error}");
                return;
            }
            _products.Add(_addingProduct);
            this.Close();
        }

        private void OnlyInt_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!Regex.IsMatch(e.Text, @"^\d$")) {
                e.Handled = true;
            }
        }

        private void OnlyDecimal_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!Regex.IsMatch(e.Text, @"^\d$") && (e.Text != ".")) {
                e.Handled = true;
            }
        }
    }
}
