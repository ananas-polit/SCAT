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
    /// Логика взаимодействия для MainPageWindow.xaml
    /// </summary>
    public partial class MainPageWindow : Window
    {

        SCATEntities2 Context { get; }

        private int imageIndex;
        //СПИСОК КАРТИНОК
        private string[] images = new string[]
        {
            "/Resource/skat1.png",
            "/Resource/scat1.png",
            "/Resource/scat3.png",
            "/Resource/scat4.png",
            "/Resource/scat5.png"
        };

        public string ImageName { get; }

        private void ShowImage(string image, int i)
        {
            var bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(image, UriKind.Relative);
            bitmap.EndInit();
            image1.Stretch = Stretch.Fill;
            image1.Source = bitmap;
        }

        private string Selected { get; set; }
        public MainPageWindow()
        {
            Context = new SCATEntities2();
            InitializeComponent();
            ShowImage(images[imageIndex], imageIndex);
        }

        private void CmbGender_Selected(object sender, RoutedEventArgs e)
        {
            //берем комбобокс, потом берем текстблок, а оттуда берем текст
            Selected = ((sender as ComboBox).SelectedValue as TextBlock).Text;
            if(Selected == "Тарифы")
            {
                new TariffWindow().Show();
            }
            else
            {
                new PromotionsWindow().Show();
            }
            
        }

        private void Skidka()
        {
            var stoimost = Context.Statement.First().Tariffs.Price;
            var skidka = Context.Statement.First().Promotions.Discount;

            var stoimistSoSkidkoj = (stoimost / 100m) * Convert.ToDecimal(skidka);
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((imageIndex + 1) > images.Length - 1)
            {
                imageIndex = 0;
            }
            else
            {
                imageIndex++;
            }

            ShowImage(images[imageIndex], imageIndex);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((imageIndex - 1) < 0)
            {
                imageIndex = images.Length - 1;
            }
            else
            {
                imageIndex--;
            }

            ShowImage(images[imageIndex], imageIndex);
        }

        private void CmbTariff_Selected(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
