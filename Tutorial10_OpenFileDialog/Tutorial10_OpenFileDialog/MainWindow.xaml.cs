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
            OpenFolderDialog folderDialog = new OpenFolderDialog();

            bool? success = folderDialog.ShowDialog();
            if (success == true)
            {
               // string path = folderDialog.FolderName;
               // tbInfo.Text = path;

                string folderName = folderDialog.SafeFolderName;
                tbInfo.Text = folderName;
            }
            else
            {
                MessageBox.Show("No folder selected");
            }
        }
    }
}