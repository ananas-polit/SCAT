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
    /// Логика взаимодействия для ImageWindow.xaml
    /// </summary>
    public partial class ImageWindow : Window
    {
        private int imageIndex;
        private string[] images = new string[]
        {
            "/Resource/scat.png",
            "/Resource/skat1.png"
        };

        public string ImageName { get; }
        public ImageWindow()
        {
            InitializeComponent();
        }

        private void ShowImage(string image, int i)
        {
            var bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(image, UriKind.Relative);
            bitmap.EndInit();
            image1.Stretch = Stretch.Fill;
            image1.Source = bitmap;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if((imageIndex + 1) > images.Length - 1)
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
    }
}
