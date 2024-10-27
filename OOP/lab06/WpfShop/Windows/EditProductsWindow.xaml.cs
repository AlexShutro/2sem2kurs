using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfShop {
    /// <summary>
    /// Логика взаимодействия для EditProductsWindow.xaml
    /// </summary>
    public partial class EditProductsWindow : Window {
        private BindingList<ProductModel> _products;

        public EditProductsWindow(BindingList<ProductModel> data) {
            InitializeComponent();
            LoadProductsImages();
            _products = data;
            ProductsDataGrid.ItemsSource = data;
        }

        private void LoadProductsImages() {
            ProductsDataGridImagePath.ItemsSource = Directory
                .GetFiles(@"..\..\ProductsImages\")
                .OrderBy(filename => filename)
                .Select(filename => Path.GetFullPath(filename))
            ;
        }

        private void Window_Closing(object sender, CancelEventArgs e) {
            StringBuilder sb = new StringBuilder();
            foreach (ProductModel pr in _products) {
                if (pr.Error != string.Empty) {
                    sb.AppendLine(pr.Error);
                }
            }
            if (sb.Length > 0) {
                e.Cancel = true;
                MessageBox.Show($"Нельзя завершить редактирование с ошибками. Некоторые поля имеют ошибки:\n{sb.ToString()}");
            }
            ProductsDataGrid.CancelEdit();
        }

        private void DeleteCommand_Executed(object sender, ExecutedRoutedEventArgs e) {
            ProductsDataGrid.CommitEdit();
            try {
                ProductModel pr = (sender as Button).DataContext as ProductModel;
                _products.Remove(pr);
            }
            catch {
                return;
            }
        }
    }
}
