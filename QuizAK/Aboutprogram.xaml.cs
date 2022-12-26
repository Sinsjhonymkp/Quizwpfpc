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
using QuizAK;

namespace Интелектуальная_викторина
{
    /// <summary>
    /// Логика взаимодействия для Aboutprogram.xaml
    /// </summary>
    public partial class Aboutprogram : Window
    {
        public Aboutprogram()
        {
            InitializeComponent();
        }

        private void Button_click1(object sender, RoutedEventArgs e)
        {
            this.Close();
            

        }
    }
}
