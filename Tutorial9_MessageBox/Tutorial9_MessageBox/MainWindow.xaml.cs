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

namespace Tutorial9_MessageBox
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

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Could not open file.", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Warning);
            
            MessageBoxResult result = MessageBox.Show("Do you agree?", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                // MessageBox.Show("You agreed.", "Agreement", MessageBoxButton.OK, MessageBoxImage.Information);
                tbInfo.Text = "You agreed.";
            }
            else
            {
                // MessageBox.Show("You did not agree.", "Agreement", MessageBoxButton.OK, MessageBoxImage.Information);
                tbInfo.Text = "You did not agree.";
            }


        }
    }
}