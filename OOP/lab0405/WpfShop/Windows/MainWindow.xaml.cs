using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace WpfShop {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private JsonStorage<BindingList<ProductModel>> _storage = new JsonStorage<BindingList<ProductModel>>(@"..\..\Storage\data.json");
        private BindingList<ProductModel> _productsDataList;

        public MainWindow() {
            InitializeComponent();
            LoadData();

            SetLocalization(LocalizationCode.RU);
            SetWallpapers();

            ProductsDataGrid.ItemsSource = _productsDataList;

            _productsDataList.ListChanged += OnDataListChanged;
        }

        private void SetLocalization(LocalizationCode localizationCode) {
            this.Resources.MergedDictionaries.Add(LocalizationResources.GetResource(localizationCode));
        }

        private void SetWallpapers() {
            this.Resources.Add("WallpapersSrc", new BitmapImage(new Uri(@"..\..\Assets\spaceWallpapers.jpg", UriKind.Relative)));
        }

      

        private void LoadData() {
            try {
                _productsDataList = _storage.Load() ?? new BindingList<ProductModel>();
                ProductsCountLabel.Text = _productsDataList.Count.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show($"Ошибка при загрузке данных {ex}");
                Environment.Exit(0);
            }
        }

        private void SaveData() {
            try {
                _storage.Save(_productsDataList);
            }
            catch (Exception ex) {
                MessageBox.Show($"Ошибка при сохранении данных: {ex}");
                Environment.Exit(0);
            }
        }

        private void OnDataListChanged(object sender, ListChangedEventArgs e) {
            ProductsCountLabel.Text = _productsDataList.Count.ToString();
            SaveData();
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e) {
            AddProductWindow addProductWindow = new AddProductWindow(_productsDataList);
            addProductWindow.Resources.MergedDictionaries.Add(this.Resources);
            addProductWindow.Cursor = this.Cursor;
            addProductWindow.ShowDialog();
        }

        private void EditProductsButton_Click(object sender, RoutedEventArgs e) {
            EditProductsWindow editProductsWindow = new EditProductsWindow(_productsDataList);
            editProductsWindow.Resources.MergedDictionaries.Add(this.Resources);
            editProductsWindow.Cursor = this.Cursor;
            editProductsWindow.ShowDialog();
        }

        private void ShowProductsButton_Click(object sender, RoutedEventArgs e) {
            ShowProductsWindow showProductsWindow = new ShowProductsWindow(_productsDataList);
            showProductsWindow.Resources.MergedDictionaries.Add(this.Resources);
            showProductsWindow.Cursor = this.Cursor;
            showProductsWindow.ShowDialog();
        }

        private void LocalizationRUButton_Click(object sender, RoutedEventArgs e) {
            SetLocalization(LocalizationCode.RU);
        }

        private void LocalizationENButton_Click(object sender, RoutedEventArgs e) {
            SetLocalization(LocalizationCode.EN);
        }
    }
}
