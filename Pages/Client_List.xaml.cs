using System;
using System.Collections.Generic;
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

namespace _3_TASK.Pages
{
    /// <summary>
    /// Логика взаимодействия для Client_List.xaml
    /// </summary>
    public partial class Client_List : Page
    {
        public Client_List()
        {
            InitializeComponent();
        }

        private void Reg_Button_Click(object sender, RoutedEventArgs e)
        {
            string Name = nameTextBox.Text.Trim();
            string LastName = lastNameTextBox.Text.Trim();
            string MiddleName = middleNameTextBox.Text.Trim();
            string PhoneNumber = phoneNumberTextBox.Text.Trim();
        }
    }
}
