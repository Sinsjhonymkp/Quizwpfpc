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
using Интелектуальная_викторина;

namespace Интелектуальная_викторина
{
    /// <summary>
    /// Логика взаимодействия для history.xaml
    /// </summary>
    public partial class history : Window
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        
        int qNum = 0;
        int i;
        int score;
        public history()
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
                new reshist(score).ShowDialog();


            }

      
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";

            }


         

            switch (i)
            {
                case 1:

                    txtQuestion.Text = "Вопрос 1";

                    ans1.Content = "Сталин";
                    ans2.Content = "Ленин";
                    ans3.Content = "Горбачёв";
                    ans4.Content = "Петр 1";

                    ans1.Tag = "1";
                   

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/stalin.jpg")); 

                    break; 
                    

                case 2:

                    txtQuestion.Text = "Вопрос 2";

                    ans1.Content = "Достаевский";
                    ans2.Content = "Гоголь";
                    ans3.Content = "Пушкин";
                    ans4.Content = "Булгаков";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/pushkin.jpg"));

                    break;

                case 3:

                    txtQuestion.Text = "Вопрос 3";

                    ans1.Content = "Петр 1 ";
                    ans2.Content = "Николай 2";
                    ans3.Content = "Александр 3";
                    ans4.Content = "Иван 2";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/petr1.jpg"));

                    break;

                case 4:

                    txtQuestion.Text = "Вопрос 4";

                    ans1.Content = "Ломоносов";
                    ans2.Content = "Циолковский";
                    ans3.Content = "Лобачёвский";
                    ans4.Content = "Менделеев";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/mendeleev.jpeg"));

                    break;

                case 5:

                    txtQuestion.Text = "Вопрос 5";

                    ans1.Content = "Сталин";
                    ans2.Content = "Троцкий";
                    ans3.Content = "Ленин";
                    ans4.Content = "Хрущев";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/lenin.jpg"));

                    break;
                case 6:

                    txtQuestion.Text = "Вопрос 6";

                    ans1.Content = "Андропов";
                    ans2.Content = "Брежнев";
                    ans3.Content = "Сталин";
                    ans4.Content = "Горбачёв";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/brejhnev.jpg"));

                    break;
                case 7:

                    txtQuestion.Text = "Вопрос 7";

                    ans1.Content = "Гоголь";
                    ans2.Content = "Толстой";
                    ans3.Content = "Тургенев";
                    ans4.Content = "Чехов";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/gogol.jpg"));

                    break;
                case 8:

                    txtQuestion.Text = "Вопрос 8";

                    ans1.Content = "Федор 3";
                    ans2.Content = "Николай 2";
                    ans3.Content = "Иван 1";
                    ans4.Content = "Иван Грозный";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/ivangr.jpg"));

                    break;
                case 9:

                    txtQuestion.Text = "Вопрос 9";

                    ans1.Content = "Пушкин";
                    ans2.Content = "Булгаков";
                    ans3.Content = "Есенин";
                    ans4.Content = "Лермонтов";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/esenin.jpg"));

                    break;

                case 10:

                    txtQuestion.Text = "Вопрос 10";

                    ans1.Content = "Николай 2";
                    ans2.Content = "Иван 4";
                    ans3.Content = "Петр 1";
                    ans4.Content = "Александр 1";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/nikolai2.jpg"));

                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}