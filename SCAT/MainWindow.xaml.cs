using SCAT.Forms;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SCAT
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnVisitor_Click(object sender, RoutedEventArgs e)
        {
            var visitor = new IntelWindow();
            visitor.ShowDialog();
        }

        private void BtnAdmin_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {

        }

        private void BtnInformation_Click(object sender, RoutedEventArgs e)
        {
            var visitor = new MainPageWindow ();
            visitor.ShowDialog();
        }
    }
}
