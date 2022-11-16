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
using BarberShop.Model;

namespace BarberShop
{
    /// <summary>
    /// Логика взаимодействия для ServicesPage.xaml
    /// </summary>
    public partial class ServicesPage : Page
    {
        public ServicesPage()
        {
            InitializeComponent();
            ConnectClass.barberEnt = new BarberShopMaistrovaEntities2();
            ServicesLV.ItemsSource = ConnectClass.barberEnt.Services.ToList();
        }

        private void AddBt2_Click(object sender, RoutedEventArgs e)
        {
            ColdGrid2.Visibility = Visibility.Collapsed;
            FrameClass.BodyFrame.Navigate(new AddServicesPage());
            AddBt2.Visibility = Visibility.Collapsed;
           
        }

        private void NextButton2_Click(object sender, RoutedEventArgs e)
        {
            ColdGrid2.Visibility = Visibility.Visible;
            
            AddBt2.Visibility = Visibility.Visible;
        }

        private void DeleteBt2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
