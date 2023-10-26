using BulatHurmatullin320_PhotoStorage.DB;
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

namespace BulatHurmatullin320_PhotoStorage.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static List<Animal> animals {  get; set; }
        public MainPage()
        {
            InitializeComponent();
            animals = new List<Animal>(DbConnection.Entities.Animal.ToList());
            this.DataContext = this;
        }

       

        private void GenderCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddAnimal());
        }
    }
}
