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
    /// Логика взаимодействия для Geo.xaml
    /// </summary>
    public partial class Geo : Window
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

       
        int qNum = 0;
        int i;
        int score;
        public Geo()
        {
            InitializeComponent();

            NextQuestion();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
          

            Button senderButton = sender as Button; 

           
            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

         
            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
               
                qNum++;
            }

    
            scoreText.Content = "Верно " + score + "/" + questionNumbers.Count;

          
            NextQuestion();

        }

    

        private void NextQuestion()
        {
           

    

            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
               
                MessageBox.Show("Вы ответили правильно на " + score + " вопроса(ов) ");
                this.Close();
                new result(score).ShowDialog();
                

            }

           
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
               
            }


         

            switch (i)
            {
                case 1:

                    txtQuestion.Text = "Вопрос 1"; 

                    ans1.Content = "Италия"; 
                    ans2.Content = "Испания";
                    ans3.Content = "Франция";
                    ans4.Content = "Перу";

                    ans2.Tag = "1"; 
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/spain.png")); 

                    break; 

                case 2:

                    txtQuestion.Text = "Вопрос 2";

                    ans1.Content = "Словакия";
                    ans2.Content = "Сербия";
                    ans3.Content = "Россия";
                    ans4.Content = "Болгария";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/russia.png"));

                    break;

                case 3:

                    txtQuestion.Text = "Вопрос 3";

                    ans1.Content = "Тунис";
                    ans2.Content = "Марокко";
                    ans3.Content = "Перу";
                    ans4.Content = "Мексика";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/mexico.png"));

                    break;

                case 4:

                    txtQuestion.Text = "Вопрос 4";

                    ans1.Content = "Казахстан";
                    ans2.Content = "Туркменистан";
                    ans3.Content = "Грузия";
                    ans4.Content = "Таджикистан";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/kazakhstan.png"));

                    break;

                case 5:

                    txtQuestion.Text = "Вопрос 5";

                    ans1.Content = "Польша";
                    ans2.Content = "Румыния";
                    ans3.Content = "Англия";
                    ans4.Content = "Германия";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/german.png"));

                    break;
                case 6:

                    txtQuestion.Text = "Вопрос 6";

                    ans1.Content = "Азербайджан";
                    ans2.Content = "Грузия";
                    ans3.Content = "Армения";
                    ans4.Content = "Абхазия";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/georgia.png"));

                    break;
                case 7:

                    txtQuestion.Text = "Вопрос 7";

                    ans1.Content = "Румыния";
                    ans2.Content = "Испания";
                    ans3.Content = "Франция";
                    ans4.Content = "Аргентина";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/france.png"));

                    break;
                case 8:

                    txtQuestion.Text = "Вопрос 8";

                    ans1.Content = "Вьетнам";
                    ans2.Content = "КНДР";
                    ans3.Content = "Япония";
                    ans4.Content = "Китай";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/china.png"));

                    break;
                case 9:

                    txtQuestion.Text = "Вопрос 9";

                    ans1.Content = "Литва";
                    ans2.Content = "Чехия";
                    ans3.Content = "Словения";
                    ans4.Content = "Россия";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/chech.png"));

                    break;

                case 10:

                    txtQuestion.Text = "Вопрос 10";

                    ans1.Content = "Беларусь";
                    ans2.Content = "Эстония";
                    ans3.Content = "Латвия";
                    ans4.Content = "Венгрия";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/belarus.png"));

                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}