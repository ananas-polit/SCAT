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
    /// Логика взаимодействия для PromotionsWindow.xaml
    /// </summary>
    public partial class PromotionsWindow : Window
    {
        SCATEntities3 context;
        public PromotionsWindow()
        {
            InitializeComponent();
            context = new SCATEntities3();
            dgPromo.ItemsSource = context.Promotions.ToList();
        }
    }
}
