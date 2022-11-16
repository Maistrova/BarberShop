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
    /// <summary>
    /// Логика взаимодействия для AddServicesPage.xaml
    /// </summary>
    public partial class AddServicesPage : Page
    {
        public AddServicesPage()
        {
            InitializeComponent();
        }

        private void BackButton3_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.BodyFrame.Navigate(new ServicesPage());
        }
    }
}
