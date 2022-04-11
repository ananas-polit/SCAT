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
    /// Логика взаимодействия для SubscriberWindow.xaml
    /// </summary>
    public partial class SubscriberWindow : Window
    {
        SCATEntities2 context;
        string currentLetter = "";
        public SubscriberWindow()
        {
            InitializeComponent();
            context = new SCATEntities2();
            dgSubscriber.ItemsSource = context.Subscriber.ToList();
            ShowTable(); 
            ShowLetters();
        }

        private void ShowTable()
        {
            if (TxtPassport.Text == null && TxtPhone.Text == null)
                return;
            List<Subscriber> listSubscriber = context.Subscriber.ToList();
            listSubscriber = listSubscriber.Where(x => x.Passport.ToLower().Contains(TxtPassport.Text.ToLower())).ToList();
            listSubscriber = listSubscriber.Where(x => x.Telephone.ToLower().Contains(TxtPhone.Text.ToLower())).ToList();
            if (currentLetter.Count() == 1)
            {
                listSubscriber = listSubscriber.Where(x => x.FirstName.Contains(currentLetter)).ToList();
            }
            dgSubscriber.ItemsSource = listSubscriber.OrderBy(x => x.FirstName).ToList();
        }
        private void ShowLetters()
        {
            for (char i = 'А'; i <= 'Я'; i++)
            {
                TextBlock letter = new TextBlock
                {
                    Text = i.ToString(),
                    FontWeight = FontWeights.Bold,
                    Foreground = Brushes.White,
                    Margin = new Thickness(10, 0, 0, 0)
                };
                letter.MouseLeftButtonDown += TextBlock_MouseLeftButtonDown;
                StackLetters.Children.Add(letter);
            }
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var label = (TextBlock)sender;
            currentLetter = label.Text;
            foreach (TextBlock letter in StackLetters.Children)
            {
                letter.Foreground = Brushes.White;
            }
            label.Foreground = Brushes.Gold;
            ShowTable();
        }

        private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void TxtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShowTable();
        }


        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {
            Button BtnEdit = sender as Button;
            var currentRegistr = BtnEdit.DataContext as Subscriber;
            var EditWindow = new AddSubscriberWindow(context, currentRegistr);
            EditWindow.ShowDialog();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var NewSubscriber = new Subscriber();//определяет новый объект
            context.Subscriber.Add(NewSubscriber);//добавляем 
            var EditWindow = new AddSubscriberWindow(context, NewSubscriber);
            EditWindow.ShowDialog();
        }

        private void CmbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CmbStatus.SelectedIndex == 0)
            {
                ShowTable();
            }
            if (CmbStatus.SelectedIndex == 1)
            {
                dgSubscriber.ItemsSource = context.Subscriber.Where(x => x.IDStatus.Contains("1")).ToList();
            }
            if (CmbStatus.SelectedIndex == 2)
            {
                dgSubscriber.ItemsSource = context.Subscriber.Where(x => x.IDStatus.Contains("2")).ToList();

            }
            if (CmbStatus.SelectedIndex == 3)
            {
                dgSubscriber.ItemsSource = context.Subscriber.Where(x => x.IDStatus.Contains("3")).ToList();

            }
        }

        private void TxtPassport_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShowTable();
        }
    }
}
