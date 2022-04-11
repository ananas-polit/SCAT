using Microsoft.Win32;
using SCAT.AddTables;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для TariffWindow.xaml
    /// </summary>
    public partial class TariffWindow : Window
    {
        SCATEntities2 context;
        public TariffWindow()
        {
            InitializeComponent();
            context = new SCATEntities2();
            dgTariff.ItemsSource = context.Tariffs.ToList();
        }

        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {
            Button BtnEdit = sender as Button;
            var currentRegistr = BtnEdit.DataContext as Tariffs;
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Выберите фотографию";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                currentRegistr.Photo = File.ReadAllBytes(op.FileName);
            }
            
            
            var EditWindow = new AddTariffWindow(context, currentRegistr);
            EditWindow.ShowDialog();
        }
    }
}
