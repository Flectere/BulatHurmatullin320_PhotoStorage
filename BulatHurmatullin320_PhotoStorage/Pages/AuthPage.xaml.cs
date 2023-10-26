using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Authentication;
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
using BulatHurmatullin320_PhotoStorage.DB;

namespace BulatHurmatullin320_PhotoStorage.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public List<User> users = new List<User>();
        public AuthPage()
        {
            InitializeComponent();
        }

        private void EnterBt_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTb.Text.Trim();
            string surname = SurnameTb.Text.Trim();
            User CurrentUser = DB.DbConnection.Entities.User.FirstOrDefault(User => User.Name == name && User.Surname == surname);

            MessageBox.Show(surname);
            if (CurrentUser != null)
            {
                MessageBox.Show("Вы вошли");
                NavigationService.Navigate(new MainPage());
            }
            else
            {
                MessageBox.Show("Такого пользователя нет!!!!");
            }
        }
    }
}