using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Graphics_Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        

        }

        private void LivingRoomButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Livig Room Info","",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void KitchenRoomButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kitchen info", "", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void KoridorRoomButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Koridor info", "", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void HallRoomButton_Copy_Click(object sender, RoutedEventArgs e)
        {
           MessageBox.Show("Hall info", "", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}