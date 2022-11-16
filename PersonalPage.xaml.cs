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
    /// Логика взаимодействия для PersonalPage.xaml
    /// </summary>
    public partial class PersonalPage : Page
    {
        public PersonalPage()
        {
            InitializeComponent();
            ConnectClass.barberEnt = new BarberShopMaistrovaEntities2();
            PersonallllLV.ItemsSource = ConnectClass.barberEnt.Staff.ToList();
        }

        private void NextButton3_Click(object sender, RoutedEventArgs e)
        {
            
            
            AddBt3.Visibility = Visibility.Visible;
        }

        private void AddBt3_Click(object sender, RoutedEventArgs e)
        {


            FrameClass.BodyFrame.Navigate(new AddPersonalPage());
            AddBt3.Visibility = Visibility.Collapsed;
            
        }

        private void DeleteBt1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            AddBt3.Visibility = Visibility.Visible;
        }
    }
}
