using System.Windows.Controls;

namespace BankV2
{
    public partial class ContentArea : UserControl
    {
        public ContentArea()
        {
            InitializeComponent();
        }

        public void Navigate(UserControl control)
        {
            Content = control;
        }

    }  
}
