using SCAT.FormTable;
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

namespace SCAT.Forms
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void BtnStatement_Click(object sender, RoutedEventArgs e)
        {
            var visitor = new StatementWindow();
            visitor.ShowDialog();
        }

        private void BtnSubscriber_Click(object sender, RoutedEventArgs e)
        {
            var visitor = new SubscriberWindow();
            visitor.ShowDialog();
        }

        private void BtnCall_Click(object sender, RoutedEventArgs e)
        {
            var visitor = new CallWindow();
            visitor.ShowDialog();
        }

        private void BtnAddress_Click(object sender, RoutedEventArgs e)
        {
            var visitor = new AddressWindow();
            visitor.ShowDialog();
        }

        private void BtnReport_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
