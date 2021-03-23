using System.Windows;

namespace BankV2
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            contentArea.Navigate(new Menupage(this));

        }
    }
}
