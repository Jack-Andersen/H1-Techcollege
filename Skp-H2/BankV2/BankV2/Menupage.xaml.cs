using System.Windows.Controls;

namespace BankV2
{
    /// <summary>
    /// Interaction logic for Menupage.xaml
    /// </summary>
    public partial class Menupage : UserControl
    {

        MainWindow window;

        public Menupage(MainWindow window)
        {
            InitializeComponent();

            this.window = window;
        }
    }
}
