using System.ComponentModel;
using System.Windows;

namespace TråddeEksempel
{
    public partial class MainWindow : Window
    {
        BackgroundWorker worker = new BackgroundWorker();
        public MainWindow()
        {
            InitializeComponent();
            worker.DoWork += LoadContent;
            worker.RunWorkerAsync();
        }
        private void LoadContent(object sender, DoWorkEventArgs args)
        {
            while (true)
            {
                Dispatcher.Invoke(() =>
                textbox.Text = System.IO.File.ReadAllText(@"C:\Users\Elder\Documents\GitHub\Jack_Andersen\H2-Projects\TråddeEksempel\TråddeEksempel\TextFile1.txt")
                );
                System.Threading.Thread.Sleep(250);
            } 
        }
    }
}
