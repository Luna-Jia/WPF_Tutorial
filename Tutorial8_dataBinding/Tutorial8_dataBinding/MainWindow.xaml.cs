using System.ComponentModel;
using System.Windows;

namespace Tutorial8_dataBinding
{

    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this; 
            InitializeComponent();
        }

        private string boundText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundText; }
            set 
            { 
                boundText = value; 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
                // OnPropertyChanged();
            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "Hello World";
        }
    }
}