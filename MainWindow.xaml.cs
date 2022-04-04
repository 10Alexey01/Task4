using _3_TASK.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LoginCheckLibrary;

namespace _3_TASK
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Message = CheckClass.Check(LoginTextBox.Text, PasswordTextBox.Password);
            if (Message == "Пользователь авторизован")
            {
                MessageBox.Show(Message);
                RootWindow WT = new RootWindow();
                WT.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(Message);
            }
        }
    }
}
