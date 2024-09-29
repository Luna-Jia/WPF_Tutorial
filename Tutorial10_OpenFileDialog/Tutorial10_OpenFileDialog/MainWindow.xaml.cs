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
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "C# Source Files | *.cs";
            fileDialog.InitialDirectory = "C:\\Users\\lunaj\\source\\repos\\WPF_Tutorial";
            fileDialog.Title = "Please pick CS Source file(s)...";
            fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();
            if (success == true)
            {
                string[] paths = fileDialog.FileNames;
                string[] fileNames = fileDialog.SafeFileNames;

                //tbInfo.Text = paths;

               // string folderName = fileDialog.SafeFileName;
               // tbInfo.Text = folderName;
            }
            else
            {
                tbInfo.Text = "No file selected";
                // MessageBox.Show("No file selected");
            }
        }
    }
}