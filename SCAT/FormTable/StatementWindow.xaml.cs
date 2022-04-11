using SCAT.AddTables;
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
    /// Логика взаимодействия для StatementWindow.xaml
    /// </summary>
    public partial class StatementWindow : Window
    {
        SCATEntities2 context;
        public StatementWindow()
        {
            InitializeComponent();
            context = new SCATEntities2();
            dgStatement.ItemsSource = context.Statement.ToList();
        }

        

        private void BtnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            var NewStatement = new Statement();//определяет новый объект
            context.Statement.Add(NewStatement);//добавляем 
            var EditWindow = new AddStatementWindow(context, NewStatement);
            EditWindow.ShowDialog();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button BtnEdit = sender as Button;
            var currentRegistr = BtnEdit.DataContext as Statement;
            var EditWindow = new AddStatementWindow(context, currentRegistr);
            EditWindow.ShowDialog();
        }
    }
}
