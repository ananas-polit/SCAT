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
    /// Логика взаимодействия для CallWindow.xaml
    /// </summary>
    public partial class CallWindow : Window
    {
        SCATEntities3 context;
        public CallWindow()
        {
            InitializeComponent();
            context = new SCATEntities3();
            dgCall.ItemsSource = context.Call.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
