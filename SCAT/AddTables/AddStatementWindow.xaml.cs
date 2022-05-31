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
    /// Логика взаимодействия для AddStatementWindow.xaml
    /// </summary>
    public partial class AddStatementWindow : Window
    {
        SCATEntities3 context;
        public AddStatementWindow(SCATEntities3 context1, Statement statement)
        {
            InitializeComponent();
            this.context = context1;
            CmbPromotions.ItemsSource = context.Subscriber.ToList();
            CmbTariffs.ItemsSource = context.Tariffs.ToList();
            //CmbAccountant.ItemsSource = context.Promotions.ToList();
            this.DataContext = statement;
        }

        private void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
