using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text.RegularExpressions;

namespace LAB8_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectStr; 
        SqlConnection connect;
        SqlDataAdapter adapter;
        DataTable datTable;

        Book acc = new Book();  

        public MainWindow()
        {
            InitializeComponent();

            connectStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            if (CheckDatabaseExists())
            {
                connect = new SqlConnection(connectStr);
            }
            else
            {
                CreateDatabase();
                connect = new SqlConnection(connectStr);
            }

            phonesGrid.RowEditEnding += PhonesGrid_RowEditEnding;

            publisher_box.SelectedItem = publisher_box.Items[1];
        }


        private bool CheckDatabaseExists()
        {
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        //------------ Создание базы данных, если она не существует-----------
        private void CreateDatabase()
        {
            string databaseName = "lab8oop";
            bool databaseExists = CheckDatabaseExists(databaseName);

            if (!databaseExists)
            {
                SqlConnectionStringBuilder masterConnectionStringBuilder = new SqlConnectionStringBuilder(connectStr);
                masterConnectionStringBuilder.InitialCatalog = "master";

                using (SqlConnection masterConnection = new SqlConnection(masterConnectionStringBuilder.ConnectionString))
                {
                    masterConnection.Open();

                    string createDatabaseScript = $"CREATE DATABASE {databaseName}";
                    SqlCommand createDatabaseCommand = new SqlCommand(createDatabaseScript, masterConnection);
                    createDatabaseCommand.ExecuteNonQuery();
                }
            }

            SqlConnectionStringBuilder databaseConnectionStringBuilder = new SqlConnectionStringBuilder(connectStr);
            databaseConnectionStringBuilder.InitialCatalog = databaseName;
            connectStr = databaseConnectionStringBuilder.ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectStr))
            { 
                connection.Open();

                string createTitleTableScript =
                    @"CREATE TABLE [dbo].[Title] (
                [id] INT IDENTITY (1, 1) NOT NULL,
                [BookName] NVARCHAR (50) NOT NULL,
                [PublDate] DATETIME NOT NULL,
                [UDC] NCHAR (15) NOT NULL,
                [ImageData] NVARCHAR(255) NULL,
                CONSTRAINT [PK__Title__3214EC071237FB30] PRIMARY KEY CLUSTERED ([Id] ASC)
            )";
                SqlCommand createTitleTableCommand = new SqlCommand(createTitleTableScript, connection);
                createTitleTableCommand.ExecuteNonQuery();
                
                string createBookTableScript = @"CREATE TABLE [dbo].[Book] (
            [id] INT IDENTITY (1, 1) NOT NULL,
            [TitleId] INT NOT NULL,
            [BookName] NVARCHAR (50) NOT NULL,
            [Publisher] NVARCHAR (50) NOT NULL,
            [sendDate] DATETIME NULL,
            [startSize] INT NULL,
            [Formate] NVARCHAR (10) NULL,
            CONSTRAINT [PK__Book__3214EC071237FB30] PRIMARY KEY CLUSTERED ([Id] ASC),
            CONSTRAINT [FK__Book__TitleId__267ABA7A] FOREIGN KEY ([TitleId]) REFERENCES [dbo].[Title] ([Id])
        )";
                SqlCommand createBookTableCommand = new SqlCommand(createBookTableScript, connection);
                createBookTableCommand.ExecuteNonQuery();
            }
        }

        private bool CheckDatabaseExists(string databaseName)
        {
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();

                string checkDatabaseScript = $"SELECT COUNT(*) FROM sys.databases WHERE name = '{databaseName}'";
                SqlCommand checkDatabaseCommand = new SqlCommand(checkDatabaseScript, connection);
                int databaseCount = (int)checkDatabaseCommand.ExecuteScalar();

                return databaseCount > 0;
            }
        }


        private void PhonesGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            UpdateDB();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DateOfG.Text = $"Дата создания записи: {DateTime.Now.ToShortDateString()}";
            Load();
           
        }
        //====================== ЗАГРУЗКА ДАННЫХ ИЗ БД ========================
        public void Load()
        {
           string sql = "SELECT * FROM Book JOIN Title ON Book.TitleId = Title.id;";

            datTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectStr);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(datTable);
                phonesGrid.ItemsSource = datTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        // ============================== обновление данных в базе данных =======================
        private void UpdateDB()
        {
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Book JOIN Title ON Book.TitleId = Title.id", connection))
                        {
                            adapter.RowUpdating += Adapter_RowUpdating;

                            SqlCommand updateCommand = new SqlCommand(
                                "UPDATE Book " +
                                "SET Publisher = @Publisher, sendDate = @sendDate, startSize = @startSize, Formate = @Formate " +
                                "FROM Book JOIN Title ON Book.TitleId = Title.id " +
                                "WHERE Book.BookName = @BookName; " +
                                "UPDATE Title " +
                                "SET PublDate = @PublDate, UDC = @UDC " +
                                "WHERE BookName = @BookName", connection, transaction);

                            updateCommand.Parameters.Add("@Publisher", SqlDbType.NVarChar, 50, "Publisher");
                            updateCommand.Parameters.Add("@sendDate", SqlDbType.DateTime, 0, "sendDate");
                            updateCommand.Parameters.Add("@startSize", SqlDbType.Int, 0, "startSize");
                            updateCommand.Parameters.Add("@BookName", SqlDbType.NVarChar, 50, "BookName");
                            updateCommand.Parameters.Add("@Formate", SqlDbType.NVarChar, 10, "Formate");
                            updateCommand.Parameters.Add("@PublDate", SqlDbType.DateTime, 0, "PublDate");
                            updateCommand.Parameters.Add("@UDC", SqlDbType.NChar, 15, "UDC");

                            adapter.UpdateCommand = updateCommand;

                            adapter.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;
                            adapter.Update(datTable);
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Произошел Rollback.Ошибка при обновлении данных: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        private void Adapter_RowUpdating(object sender, SqlRowUpdatingEventArgs e)
        {
            if (e.StatementType == StatementType.Update)
            {
                int startSize = Convert.ToInt32(e.Row["startSize"]);
                if (startSize < 0) 
                {
                    e.Status = UpdateStatus.SkipCurrentRow;
                    throw new Exception("Страниц не может быть меньше нуля.");
                }
            }
        }
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
            Load();
            //MessageBox.Show("Данные обновлены");
        }

        //===================================== удаление =========================================
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (phonesGrid.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)phonesGrid.SelectedItem;

                int id = Convert.ToInt32(selectedRow["id"]);

                DeleteFromDB(new List<int> { id });
 
            }
            Load();
        }

        //--------- удаление данных из базы данных ----------
        private void DeleteFromDB(List<int> recordIds)
        {
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (int recordId in recordIds)
                        {
                            DataRowView selectedRow = (DataRowView)phonesGrid.SelectedItem;
                            int FormateValue = Convert.ToInt32(selectedRow["id"]); 
                            if (FormateValue > 0 )
                            {
                                SqlCommand deleteCommand = new SqlCommand(
                                    "DELETE FROM Book WHERE id = @id", connection, transaction);
                                deleteCommand.Parameters.AddWithValue("@id", recordId);
                                deleteCommand.ExecuteNonQuery();
                            }
                            else
                            {
                                SqlCommand deleteCommand = new SqlCommand(
                                    "DELETE FROM Title WHERE id = @id", connection, transaction);
                                deleteCommand.Parameters.AddWithValue("@id", recordId);
                                deleteCommand.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Ошибка при удалении данных: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }

        }

        // =============================== создание новой записи =====================================
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            this.acc.Title.BookName = BookName_Container.Text;
            this.acc.Title.UDC = udk_Container.Text;
            int sliderVal = Convert.ToInt32(StartB_Slider.Value);
            this.acc.Size = sliderVal;

            if (publisher_box.SelectedItem != null)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)publisher_box.SelectedItem;
                string selectedValue = selectedItem.Content.ToString();
                this.acc.Publisher = selectedValue;
            }

            try
            {
                if (ValidateValue())
                {
                    using (SqlConnection connection = new SqlConnection(connectStr))
                    {
                        connection.Open();
                        SqlTransaction transaction = connection.BeginTransaction();

                        try
                        {
                            SqlCommand c = new SqlCommand();
                            c.Connection = connection;
                            c.Transaction = transaction;

                            c.CommandText = "INSERT Title values (@BookName, @PublDate, @UDC, @ImageData);";
                            c.Parameters.AddWithValue("@BookName", this.acc.Title.BookName);
                            c.Parameters.AddWithValue("@PublDate", this.acc.Title.PublDate);
                            c.Parameters.AddWithValue("@UDC", this.acc.Title.UDC);
                            c.Parameters.AddWithValue("@imageData", imageUri);
                            c.ExecuteNonQuery();

                            c.CommandText = "SELECT TOP 1 id\r\nFROM Title\r\nORDER BY id DESC;";
                            int TitleId = Convert.ToInt32(c.ExecuteScalar());

                            c.CommandText = "INSERT INTO Book (TitleId, BookName, Publisher, sendDate, startSize, Formate) VALUES ( @TitleId, @BookNameO, @Publisher, @sendDate, @startSize, @Formate);";
                            c.Parameters.AddWithValue("@TitleId", TitleId);
                            c.Parameters.AddWithValue("@BookNameO", this.acc.Title.BookName);
                            c.Parameters.AddWithValue("@Publisher", this.acc.Publisher);
                            c.Parameters.AddWithValue("@sendDate", this.acc.OpenDate);
                            c.Parameters.AddWithValue("@startSize", this.acc.Size);
                            c.Parameters.AddWithValue("@Formate", this.acc.Format);
                            c.ExecuteNonQuery();

                            transaction.Commit();

                            MessageBox.Show("Запись создана!", "Поздравляем", MessageBoxButton.OK, MessageBoxImage.Information);
                            acc = new Book();

                            BookName_Container.Clear();
                            udk_Container.Clear();
                            PublD_Picker.SelectedDate = null;
                            ProductImage.Source = null;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Ошибка при создании записи: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось добавить данные, проверьте правильность вводимых данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (SqlException ex)
            {
                string errormsg = "";
                foreach (SqlError err in ex.Errors)
                {
                    errormsg += err.Message + ",";
                }
                MessageBox.Show(errormsg, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        ///--------- выбор издателя ----------
        private void publisher_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            this.acc.Publisher = comboBox.Text;
        }

        //--------- выбор формата ----------
        private void form_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.IsChecked == true)
            {
                switch (radioButton.Name)
                {
                    case "epub":
                        this.acc.Format = "epub";
                        break;
                    case "pdf":
                        this.acc.Format = "pdf";
                        break;
                    case "txt":
                        this.acc.Format = "txt";
                        break;
                }
            }
        }
      
        //--------- выбор даты ----------
        private void PublD_Picker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = PublD_Picker.SelectedDate;
            if (selectedDate != null)
            {
                this.acc.Title.PublDate = selectedDate.Value;
                this.acc.OpenDate = DateTime.Today;
            }
        }
        
        //-------------- страницы --------------
        private void StartB_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
            int sliderVal = Convert.ToInt32(StartB_Slider.Value);
            this.valueSlider.Text = sliderVal.ToString();                        
            this.acc.Size = sliderVal;
        }

        private int currentIndex = -1;

        // --------- вперед назад ----------
        private void Up_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                phonesGrid.SelectedIndex = currentIndex;
                phonesGrid.ScrollIntoView(phonesGrid.SelectedItem);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex < phonesGrid.Items.Count - 1)
            {
                currentIndex++;
                phonesGrid.SelectedIndex = currentIndex;
                phonesGrid.ScrollIntoView(phonesGrid.SelectedItem);
            }
        }

        // ----------- поиск ----------
        private DataTable GetDataFromDatabase(string _query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectStr))
                {
                    SqlCommand command = new SqlCommand(_query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    connection.Open();
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении данных из базы данных: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return dataTable;
        }


        //=============================== ЗАПРОСЫ К БД =================================
        private void form_Search_Click(object sender, RoutedEventArgs e)
        {
            DataTable dataTable = GetDataFromDatabase($"exec Find_publisher @formate = \'{form_Search_tb.Text}\'");
            phonesGrid.ItemsSource = dataTable.DefaultView;
        }

        private void BookName_Search_Click(object sender, RoutedEventArgs e)
        {
            DataTable dataTable = GetDataFromDatabase($"exec Find_name @nm = \'{BookName_SEARCH_TB.Text}\'");
            phonesGrid.ItemsSource = dataTable.DefaultView;
        }


        private void printAcc_Click(object sender, RoutedEventArgs e)
        {
            Load();
        }
        //=============================================================================

        //----------------- валидация -----------------
        private bool ValidateValue()
        {
          
            string date = PublD_Picker.Text;
            string UDC = udk_Container.Text;
          

            if (!validateDate())
            {
                MessageBox.Show("Недопустимое значение даты");
                return false;
            }
            if (!validateUDC(UDC))
            {
                MessageBox.Show("Недопустимое значение УДК (Пример: 123.456)");
                return false;
            }
            
            if (string.IsNullOrEmpty(imageUri))
            {
                MessageBox.Show("Нет изображения");
                return false;
            }


            return true;
        }
        
        private bool validateUDC(string UDC)
        {
            Regex regex = new Regex(@"^\d{1,3}\.\d{3}$");
            if (!regex.IsMatch(UDC))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(UDC))
            {
                return false;
            }
            return true;
        }   

      
        public bool validateDate()
        {
            DateTime? selectedDate = PublD_Picker.SelectedDate;
            if (selectedDate != null)
            {
                if (selectedDate.Value > DateTime.Now)
                {
                    MessageBox.Show( "Книга не могла быть написана в это время");
                    return false;
                }
                return true;
            }

            return false;
        }

        private string imageUri;


        //----------------- добавить изображение -----------------
        private void addImg_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Microsoft.Win32.OpenFileDialog open = new Microsoft.Win32.OpenFileDialog();
                bool? response = open.ShowDialog();
                if (response.HasValue)
                {
                    if (response.Value == true)
                    {
                        string path = open.FileName;
                        BitmapImage bi3 = new BitmapImage();
                        bi3.BeginInit();
                        bi3.UriSource = new Uri(path);
                        bi3.EndInit();
                        ProductImage.Stretch = Stretch.Fill;
                        ProductImage.Source = bi3;
                        imageUri = path;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка: загрузка изображения");
            }
        }

        // --------- закрытие приложения ----------
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connect.Close();
        }

        private void phonesGrid_SelectionChanged()
        {

        }
    }
}