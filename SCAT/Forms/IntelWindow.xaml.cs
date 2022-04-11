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
    /// Логика взаимодействия для IntelWindow.xaml
    /// </summary>
    public partial class IntelWindow : Window
    {
        public IntelWindow()
        {
            InitializeComponent();
            SCATEntities2 context = new SCATEntities2();
        }

        private void BtnVisior_Click(object sender, RoutedEventArgs e)
        {
            var users = new Dictionary<string, string>()
            {
                {"1", "12" },
                {"11", "112" }
            };

            var user = users.Keys.FirstOrDefault(k => k.Equals(TxtLogin.Text));

            if(user == null)
            {
                MessageBox.Show("Не получилось аутентифицировать пользователя. Введены некорректные e-mail или пароль");
            }
            else
            {
                if(TxtPassword.Text != users[user])
                {
                    
                    MessageBox.Show("Не получилось аутентифицировать пользователя. Введены некорректные e-mail или пароль");
                    return;
                }
                if (users[user] == "12")
                {
                    MessageBox.Show("Добро пожаловать");
                    var menu = new MenuWindow();
                    menu.ShowDialog();
                }
                else if(users[user] == "112")
                {
                    new StatementWindow().ShowDialog();
                }
                
            }

            //string Email = "1";
            //string Password = "12";
            //if (TxtLogin.Text == Email && TxtPassword.Text == Password)
            //{
            //    MessageBox.Show("Добро пожаловать");
            //    var menu = new MenuWindow();
            //    menu.ShowDialog();
            //}
            //else
            //    MessageBox.Show("Не получилось аутентифицировать пользователя. Введены некорректные e-mail или пароль");

            //string log = "222";
            //string pas = "12";
            //if (TxtLogin.Text == log && TxtPassword.Text == pas)
            //{
            //    MessageBox.Show("Добро пожаловать");
            //    var menu = new StatementWindow();
            //    menu.ShowDialog();
            //}
            //else
            //    MessageBox.Show("Не получилось аутентифицировать пользователя. Введены некорректные e-mail или пароль");
        }

        private void BtnExite_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
