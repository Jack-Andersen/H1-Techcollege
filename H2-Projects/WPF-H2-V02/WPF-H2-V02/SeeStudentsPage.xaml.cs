using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;

namespace WPF_H2_V02
{
    public partial class SeeStudentsPage : UserControl
    {

        BackgroundWorker w = new BackgroundWorker();

        public SeeStudentsPage()
        {
            InitializeComponent();

            w.DoWork += ListStudents;
            w.RunWorkerAsync();
        }

        private void ListStudents(object sender, DoWorkEventArgs args)
        {
            while (true)
            {
                List<Student> listStudents = Database.FillDataGridStudents();
                Dispatcher.Invoke(() =>
                StudentGrid.ItemsSource = listStudents
                );
                System.Threading.Thread.Sleep(250);
            }
        }
    }
}
