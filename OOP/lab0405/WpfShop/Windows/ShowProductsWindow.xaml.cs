using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace WpfShop {
    /// <summary>
    /// Логика взаимодействия для ShowProductsWindow.xaml
    /// </summary>
    public partial class ShowProductsWindow : Window {
        private BindingList<ProductModel> _productsOriginal;
        private List<ProductModel> _productsCurrent;
        public ShowProductsWindow(BindingList<ProductModel> data) {
            InitializeComponent();

            _productsOriginal = data;

            Reset();
        }

        private void Set(List<ProductModel> data) {
            _productsCurrent = data;
            ProductsDataGrid.ItemsSource = _productsCurrent;
        }

        private void Reset() {
            Set(_productsOriginal.ToList());
        }

        private void OnlyDecimal_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!Regex.IsMatch(e.Text, @"^\d$") && (e.Text != ".")) {
                e.Handled = true;
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e) {
            Reset();
        }

        private void SortingIDAscButton_Click(object sender, RoutedEventArgs e) {
            Set(_productsCurrent.OrderBy(p => p.ID).ToList());
        }

        private void SortingIDDescButton_Click(object sender, RoutedEventArgs e) {
            Set(_productsCurrent.OrderByDescending(p => p.ID).ToList());
        }

        private void SortingRatingAscButton_Click(object sender, RoutedEventArgs e) {
            Set(_productsCurrent.OrderBy(p => p.Rating).ToList());
        }

        private void SortingRatingDescButton_Click(object sender, RoutedEventArgs e) {
            Set(_productsCurrent.OrderByDescending(p => p.Rating).ToList());
        }

        private void SortingPriceAscButton_Click(object sender, RoutedEventArgs e) {
            Set(_productsCurrent.OrderBy(p => p.Price).ToList());
        }

        private void SortingPriceDescButton_Click(object sender, RoutedEventArgs e) {
            Set(_productsCurrent.OrderByDescending(p => p.Price).ToList());
        }

        private void SortingQuantityAscButton_Click(object sender, RoutedEventArgs e) {
            Set(_productsCurrent.OrderBy(p => p.Quantity).ToList());
        }

        private void SortingQuantityDescButton_Click(object sender, RoutedEventArgs e) {
            Set(_productsCurrent.OrderByDescending(p => p.Quantity).ToList());
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            Reset();
            Set(_productsCurrent.Where(p => p.Title.ToLower().Contains(SearchTextBox.Text.ToLower())).ToList());
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e) {
            try {
                decimal from, to;
                if (FilteringPriceFromTextBox.Text == string.Empty) {
                    from = 0;
                }
                else {
                    from = Convert.ToDecimal(FilteringPriceFromTextBox.Text);
                }
                if (FilteringPriceToTextBox.Text == string.Empty) {
                    to = decimal.MaxValue;
                }
                else {
                    to = Convert.ToDecimal(FilteringPriceToTextBox.Text);
                }
                Reset();
                Set(_productsCurrent.Where(p => p.Price >= from && p.Price <= to).ToList());
            }
            catch {
                MessageBox.Show("Неверный диапазон цен");
            }
        }
    }
}
