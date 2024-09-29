using Microsoft.Win32;
using System.Windows;

namespace Tutorial10_OpenFileDialog
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
            OpenFolderDialog fileDiolog = new OpenFolderDialog();
            fileDiolog.ShowDialog();

        }
    }
}