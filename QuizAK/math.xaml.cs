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
    /// Логика взаимодействия для math.xaml
    /// </summary>
    public partial class math : Window
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        int qNum = 0;
        int i;
        int score;
        public math()
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
                new resmath(score).ShowDialog();


            }


            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";

            }




            switch (i)
            {
                case 1:

                    txtQuestion.Text = "Вопрос 1";

                    ans1.Content = "1000";
                    ans2.Content = "100";
                    ans3.Content = "1";
                    ans4.Content = "10";

                    ans4.Tag = "1";

                    Quebio.Text = "1% от 1000";


                    break;


                case 2:

                    txtQuestion.Text = "Вопрос 2";

                    ans1.Content = "16кг";
                    ans2.Content = "18кг";
                    ans3.Content = "10кг";
                    ans4.Content = "100кг";

                    ans1.Tag = "1";

                    Quebio.Text = "Чему равен 1 пуд?";

                    break;

                case 3:

                    txtQuestion.Text = "Вопрос 3";

                    ans1.Content = "Биссектриса";
                    ans2.Content = "Угол";
                    ans3.Content = "Аксиома";
                    ans4.Content = "Теорема";

                    ans3.Tag = "1";

                    Quebio.Text = "Утверждение принимаемое без док - ва";


                    break;

                case 4:

                    txtQuestion.Text = "Вопрос 4";

                    ans1.Content = "20";
                    ans2.Content = "15";
                    ans3.Content = "30";
                    ans4.Content = "10";

                    ans1.Tag = "1";

                    Quebio.Text = "Какова 3 часть от 60?";

                    break;

                case 5:

                    txtQuestion.Text = "Вопрос 5";

                    ans1.Content = "8";
                    ans2.Content = "6";
                    ans3.Content = "4";
                    ans4.Content = "10";

                    ans2.Tag = "1";


                    Quebio.Text = "Сколько граней у куба?";

                    break;
                case 6:

                    txtQuestion.Text = "Вопрос 6";

                    ans1.Content = "1";
                    ans2.Content = "2";
                    ans3.Content = "3";
                    ans4.Content = "0";

                    ans4.Tag = "1";

                    Quebio.Text = "Сколько диагоналей можно провести в треугольнике?";

                    break;
                case 7:

                    txtQuestion.Text = "Вопрос 7";

                    ans1.Content = "3";
                    ans2.Content = "2";
                    ans3.Content = "0";
                    ans4.Content = "10";

                    ans3.Tag = "1";

                    Quebio.Text = "Какое число делится на все числа без остатка?";

                    break;
                case 8:

                    txtQuestion.Text = "Вопрос 8";

                    ans1.Content = "11";
                    ans2.Content = "16";
                    ans3.Content = "17";
                    ans4.Content = "15";

                    ans2.Tag = "1";

                    Quebio.Text = "Сколько ступенек улестницы в которой средняя ступенька 8?";

                    break;
                case 9:

                    txtQuestion.Text = "Вопрос 9";

                    ans1.Content = "3";
                    ans2.Content = "2";
                    ans3.Content = "4";
                    ans4.Content = "6";

                    ans2.Tag = "1";

                    Quebio.Text = "Cколько диагоналей можнопровести в четырехугольнике?";

                    break;

                case 10:

                    txtQuestion.Text = "Вопрос 10";

                    ans1.Content = "6";
                    ans2.Content = "10";
                    ans3.Content = "4";
                    ans4.Content = "8";

                    ans2.Tag = "1";

                    Quebio.Text = "Сколько вершин у куба?";

                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}



