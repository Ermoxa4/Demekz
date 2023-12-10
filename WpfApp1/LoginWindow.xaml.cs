using System;
using System.Windows;

namespace YourNamespace
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;

            // Логика проверки введенных учетных данных - добавьте здесь свою собственную логику

            if (IsValidLogin(username, password))
            {
                MessageBox.Show("Вход выполнен успешно!");
                Close(); // Закрывает текущее окно (LoginWindow)
            }
            else
            {
                MessageBox.Show("Неверные учетные данные. Попробуйте снова.");
            }
        }

        private bool IsValidLogin(string username, string password)
        {
            // Добавьте свою логику проверки соответствия введенных учетных данных вашим требованиям
            // Здесь возвращается фиктивное значение true для демонстрационных целей
            return true;
        }
    }
}