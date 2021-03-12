using System.Windows.Controls;

namespace WPF_H2_V02
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
