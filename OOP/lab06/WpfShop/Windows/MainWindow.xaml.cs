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
        private Stack<BindingList<ProductModel>> _undoProducts = new Stack<BindingList<ProductModel>>();
        private Stack<BindingList<ProductModel>> _redoProducts = new Stack<BindingList<ProductModel>>();
        private BindingList<ProductModel> _productsDataList;

        public MainWindow() {
            InitializeComponent();
            LoadData();

            SetLocalization(LocalizationCode.RU);
            SetTheme(ThemeCode.White);
        }

        private void SetLocalization(LocalizationCode localizationCode) {
            this.Resources.MergedDictionaries.Add(LocalizationResources.GetResource(localizationCode));
        }

        private void SetTheme(ThemeCode themeCode) {
            this.Resources.MergedDictionaries.Add(ThemeResources.GetResource(themeCode));
        }

        private void LoadData() {
            try {
                SetDataList(_storage.Load() ?? new BindingList<ProductModel>());
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

        private void SetDataList(BindingList<ProductModel> productsDataList) {
            if (_productsDataList != null) _productsDataList.ListChanged -= OnDataListChanged;
            _productsDataList = productsDataList;
            _productsDataList.ListChanged += OnDataListChanged;
            ProductsDataGrid.ItemsSource = _productsDataList;
            ProductsCountLabel.Text = _productsDataList.Count.ToString();
        }

        private void Undo() {
            if (_undoProducts.Count == 0) return;
            _redoProducts.Push(_productsDataList);
            SetDataList(_undoProducts.Pop());
            SaveData();
        }

        private void Redo() {
            if (_redoProducts.Count == 0) return;
            _undoProducts.Push(_productsDataList);
            SetDataList(_redoProducts.Pop());
            SaveData();
        }

        private void OnDataListChanged(object sender, ListChangedEventArgs e) {
            foreach (ProductModel product in _productsDataList) {
                if (product.Error != string.Empty) {
                    return;
                }
            }

            BindingList<ProductModel> oldData = _storage.Load();
            if (oldData != null) {
                _undoProducts.Push(oldData);
            } 

            ProductsCountLabel.Text = _productsDataList.Count.ToString();
            _redoProducts.Clear();
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

        private void WhiteThemeRadioButton_Checked(object sender, RoutedEventArgs e) {
            SetTheme(ThemeCode.White);
        }

        private void BeachThemeRadioButton_Checked(object sender, RoutedEventArgs e) {
            SetTheme(ThemeCode.Beach);
        }

        private void SpaceThemeRadioButton_Checked(object sender, RoutedEventArgs e) {
            SetTheme(ThemeCode.Space);
        }

        private void ColorsThemeRadioButton_Checked(object sender, RoutedEventArgs e) {
            SetTheme(ThemeCode.Colors);
        }

        private void UndoCommand_Executed(object sender, ExecutedRoutedEventArgs e) {
            Undo();
        }

        private void RedoCommand_Executed(object sender, ExecutedRoutedEventArgs e) {
            Redo();
        }

        private void UserTitle_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
