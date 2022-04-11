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

namespace SCAT.FormTable
{
    /// <summary>
    /// Логика взаимодействия для AddressWindow.xaml
    /// </summary>
    public partial class AddressWindow : Window
    {
        SCATEntities2 context;
        public AddressWindow()
        {
            InitializeComponent();
            context = new SCATEntities2();
            dgAddress.ItemsSource = context.Address.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var currentRegistr = dgAddress.SelectedItem as Address;
            if (currentRegistr == null)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно ходите удалить эту строку?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                context.Address.Remove(currentRegistr);
                context.SaveChanges();

            }
        }
    }
}
