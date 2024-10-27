using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using MySql.Data.MySqlClient;

namespace laba4
{
    public partial class AddWindow : Window
    {
        private Command add;
        private Command back;

        public ICommand Add
        {
            get
            {
                return add ?? (add = new Command(obj =>
                {
                    try
                    {
                        bool flag = false;
                        if (TextBox_name.Text == "")
                        {
                            TextBox_name.Background = new SolidColorBrush(Color.FromArgb(80, 255, 0, 0));
                            flag = true;
                        }
                        else
                            TextBox_name.Background = default;
                        if (TextBox_size.Text == "")
                        {
                            TextBox_size.Background = new SolidColorBrush(Color.FromArgb(80, 255, 0, 0));
                            flag = true;
                        }
                        else
                            TextBox_size.Background = default;
                        if (TextBox_color.Text == "")
                        {
                            TextBox_color.Background = new SolidColorBrush(Color.FromArgb(80, 255, 0, 0));
                            flag = true;
                        }
                        else
                            TextBox_color.Background = default;
                        if (TextBox_price.Text == "")
                        {
                            TextBox_price.Background = new SolidColorBrush(Color.FromArgb(80, 255, 0, 0));
                            flag = true;
                        }
                        else
                            TextBox_price.Background = default;
                        if (TextBox_amount.Text == "")
                        {
                            TextBox_amount.Background = new SolidColorBrush(Color.FromArgb(80, 255, 0, 0));
                            flag = true;
                        }
                        else
                            TextBox_amount.Background = default;
                        if (TextBox_picture.Text == "")
                        {
                            TextBox_picture.Background = new SolidColorBrush(Color.FromArgb(80, 255, 0, 0));
                            flag = true; ;
                        }
                        else
                            TextBox_picture.Background = default;

                        if (flag)
                            return;
                        else
                        {
                            DB db = new DB();
                            MySqlCommand addCommand = new MySqlCommand(
                                "INSERT INTO `products` (`name`, `size`, `color`, `price`, `amount`, `picture`) " +
                                "VALUES (@name, @size, @color, @price, @amount, @picture)", db.GetConnection());

                            addCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = TextBox_name.Text;
                            addCommand.Parameters.Add("@size", MySqlDbType.VarChar).Value = TextBox_size.Text;
                            addCommand.Parameters.Add("@color", MySqlDbType.VarChar).Value = TextBox_color.Text;
                            addCommand.Parameters.Add("@price", MySqlDbType.Int32).Value = Convert.ToInt32(TextBox_price.Text);
                            addCommand.Parameters.Add("@amount", MySqlDbType.Int32).Value = Convert.ToInt32(TextBox_amount.Text);
                            addCommand.Parameters.Add("@picture", MySqlDbType.VarChar).Value = TextBox_picture.Text;

                            db.openConnection();

                            if (addCommand.ExecuteNonQuery() == 1)
                                MessageBox.Show("Товар добавлен");
                            else
                                MessageBox.Show("Товар не добавлен");

                            db.closeConnection();

                            RefreshFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }));
            }
        }

        public ICommand Back
        {
            get
            {
                return back ?? (back = new Command(obj =>
                {
                    try
                    {
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }));
            }
        }

        public AddWindow()
        {
            InitializeComponent();
        }

        private void RefreshFields()
        {
            TextBox_name.Text = "";
            TextBox_size.Text = "";
            TextBox_amount.Text = "";
            TextBox_color.Text = "";
            TextBox_picture.Text = "";
            TextBox_price.Text = "";
        }
    }
}