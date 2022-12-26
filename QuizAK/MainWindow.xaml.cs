using System.Windows;
using Интелектуальная_викторина;


namespace QuizAK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {

            Aboutprogram aboutprogram = new Aboutprogram();
            aboutprogram.Show();

        }

        private void Click(object sender, RoutedEventArgs e)
        {
          Close();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
           Geo geo = new Geo();
            geo.Show();
        }

        private void History(object sender, RoutedEventArgs e)
        {
            history history = new history();
            history.Show();


        }

        private void Bio(object sender, RoutedEventArgs e)
        {
            bio bio = new bio();
            bio.Show();
        }

        private void math(object sender, RoutedEventArgs e)
        {
            math math = new math();
            math.Show();
        }
    }
}


