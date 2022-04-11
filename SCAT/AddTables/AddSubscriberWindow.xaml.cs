using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SCAT.AddTables
{
    /// <summary>
    /// Логика взаимодействия для AddSubscriberWindow.xaml
    /// </summary>
    public partial class AddSubscriberWindow : Window
    {
        SCATEntities2 context;

        public List<Shutdown> Shutdowns { get; }
        public AddSubscriberWindow(SCATEntities2 context1, Subscriber subscriber)
        {
            InitializeComponent();

            this.context = context1;

            CmbCategories.ItemsSource = context.Categories.ToList();
            CmbAddress.ItemsSource = context.Address.ToList();
            CmbShutdown.ItemsSource = context.Shutdown.ToList();
            this.DataContext = subscriber;

            //if (subscriber.Shutdown == null)
            //{
            //    var shutdowns = new List<Shutdown>
            //    {
            //        null
            //    };

            //    shutdowns.AddRange(Shutdowns);

            //    CmbShutdown.ItemsSource = shutdowns;
            

            //}


            //CmbShutdown.Text = null;
        }

        private void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }
    }
}
