using BulatHurmatullin320_PhotoStorage.DB;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Common;
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

namespace BulatHurmatullin320_PhotoStorage.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddAnimal.xaml
    /// </summary>
    public partial class AddAnimal : Page
    {
        public static List<Animal> animals { get; set; }
        
        public static List<DB.Type> types { get; set; }

        public Animal animal = new Animal();
        public User Currentuser;
        public AddAnimal(User user)
        {
            Currentuser = user;
            InitializeComponent();
            types = new List<DB.Type>(DB.DbConnection.Entities.Type);
            this.DataContext = this;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            animal.Name = NameTb.Text;
            animal.Description = DescriptonTb.Text;
            DB.DbConnection.Entities.Animal.Add(animal);
            DB.DbConnection.Entities.SaveChanges();
            NavigationService.Navigate(new MainPage(Currentuser));
        }

        private void AddImg_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*jpeg|*jpeg|*jpg|*jpg"
            };
            if (openFile.ShowDialog().GetValueOrDefault())
            {
                animal.Photo = File.ReadAllBytes(openFile.FileName);
                AnimalImg.Source = new BitmapImage(new Uri(openFile.FileName));
            }


        }
    }
}
