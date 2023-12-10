using System;
using System.Windows;

namespace YourNamespace
{
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string city = cityTextBox.Text;
            DateTime birthDate = birthDateDatePicker.SelectedDate ?? DateTime.MinValue;
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;
            string email = emailTextBox.Text;

            // Регистрационная логика - добавьте здесь код для сохранения данных в базу данных или другие операции

            MessageBox.Show("Вы успешно зарегистрированы!");
            ResetFields();

            // Открываем новое окно входа
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            Close();
        }

        private void ResetFields()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            middleNameTextBox.Text = string.Empty;
            cityTextBox.Text = string.Empty;
            birthDateDatePicker.SelectedDate = null;
            usernameTextBox.Text = string.Empty;
            passwordBox.Password = string.Empty;
            emailTextBox.Text = string.Empty;
        }
    }
}