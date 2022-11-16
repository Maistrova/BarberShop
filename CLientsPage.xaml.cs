using BarberShop.Model;
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

namespace BarberShop
{
    public partial class CLientsPage : Page
    {
        public CLientsPage()
        {
            InitializeComponent();
            ConnectClass.barberEnt = new BarberShopMaistrovaEntities2();
            ClientsLV.ItemsSource = ConnectClass.barberEnt.Client.ToList();
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.BodyFrame.Navigate(new AddClientsPage());
            ColdGrid.Visibility = Visibility.Collapsed;
            AddBt.Visibility = Visibility.Collapsed;
            
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            
            AddBt.Visibility = Visibility.Visible;
        }

        private void DeleteBt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
