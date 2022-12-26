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

namespace Интелектуальная_викторина
{
    /// <summary>
    /// Логика взаимодействия для reshist.xaml
    /// </summary>
    public partial class reshist : Window
    {
        public reshist(int score)
        {

            InitializeComponent();
            string lab = ("Ваш результат в разделе История " + score + "/10 ");
            label.Content = lab;
            if (score <= 3)
            {
                mark.Source = new BitmapImage(new Uri("pack://application:,,,/bad1.png"));
            }
            if (score > 3 && score <= 7)
            {
                mark.Source = new BitmapImage(new Uri("pack://application:,,,/norm.png"));
            }
            if (score > 7 && score <= 10)
            {
                mark.Source = new BitmapImage(new Uri("pack://application:,,,/great.png"));
            }



        }

        private void GoMain(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Restart(object sender, RoutedEventArgs e)
        {
            this.Close();
            history history = new history();
            history.Show();

        }
    }
}
