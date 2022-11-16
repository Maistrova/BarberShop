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
using System.Windows.Shapes;

namespace BarberShop
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            FrameClass.BodyFrame = MainFrame;
        }

        private void ClientsBt_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CLientsPage());
        }

        private void PersonalBt_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PersonalPage());
        }

        private void ServicesBt_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ServicesPage());
        }
    }
}
