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
    /// Логика взаимодействия для AddTariffWindow.xaml
    /// </summary>
    public partial class AddTariffWindow : Window
    {
        SCATEntities2 context;
        public AddTariffWindow(SCATEntities2 context1, Tariffs tariffs)
        {
            InitializeComponent();
            this.context = context1;
            this.DataContext = tariffs;
        }

        private void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }
    }
}
