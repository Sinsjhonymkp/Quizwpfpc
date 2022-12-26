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
    /// Логика взаимодействия для bio.xaml
    /// </summary>
    public partial class bio : Window
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        int qNum = 0;
        int i;
        int score;
        public bio()
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
                new reshbio(score).ShowDialog();


            }


            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";

            }




            switch (i)
            {
                case 1:

                    txtQuestion.Text = "Вопрос 1";

                    ans1.Content = "Р-Рнк";
                    ans2.Content = "Л-рнк";
                    ans3.Content = "М-рнк";
                    ans4.Content = "Т-рнк";

                    ans2.Tag = "1";

                    Quebio.Text = "Какой рнк нет в природе";
                  

                    break;


                case 2:

                    txtQuestion.Text = "Вопрос 2";

                    ans1.Content = "Курицы";
                    ans2.Content = "Акулы";
                    ans3.Content = "Утконос";
                    ans4.Content = "Хорёк";

                    ans1.Tag = "1";

                    Quebio.Text = "У какого животного есть киль?";

                    break;

                case 3:

                    txtQuestion.Text = "Вопрос 3";

                    ans1.Content = "Клеточная форма";
                    ans2.Content = "Бактерия";
                    ans3.Content = "Гриб";
                    ans4.Content = "Неклеточная форма";

                    ans4.Tag = "1";

                    Quebio.Text = "Вирус это -";


                    break;

                case 4:

                    txtQuestion.Text = "Вопрос 4";

                    ans1.Content = "Мха и гриба";
                    ans2.Content = "Мха и водоросли";
                    ans3.Content = "Гриба и водоросли";
                    ans4.Content = "Мха и голосеменного";

                    ans3.Tag = "1";

                    Quebio.Text = "Лишайник это симбиоз";

                    break;

                case 5:

                    txtQuestion.Text = "Вопрос 5";

                    ans1.Content = "Артерии";
                    ans2.Content = "Вены";
                    ans3.Content = "Капилляры";
                    ans4.Content = "Венулы";

                    ans1.Tag = "1";


                    Quebio.Text = "Сосуды, по которым кровь течет от сердца, называются:";

                    break;
                case 6:

                    txtQuestion.Text = "Вопрос 6";

                    ans1.Content = "АТФ";
                    ans2.Content = "кДж";
                    ans3.Content = "АНФ";
                    ans4.Content = "НТФ";

                    ans1.Tag = "1";

                    Quebio.Text = "Энергия в клетке запасается в виде";

                    break;
                case 7:

                    txtQuestion.Text = "Вопрос 7";

                    ans1.Content = "Птицах";
                    ans2.Content = "Рыбах";
                    ans3.Content = "Грибах";
                    ans4.Content = "Водрослях";

                    ans3.Tag = "1";

                    Quebio.Text = "Микология-это наука о";

                    break;
                case 8:

                    txtQuestion.Text = "Вопрос 8";

                    ans1.Content = "Пауки";
                    ans2.Content = "Бабочки";
                    ans3.Content = "Гусеницы";
                    ans4.Content = "Стрекозы";

                    ans2.Tag = "1";

                    Quebio.Text = "Бражники - это?";

                    break;
                case 9:

                    txtQuestion.Text = "Вопрос 9";

                    ans1.Content = "Малый прудовик";
                    ans2.Content = "Корова";
                    ans3.Content = "Человек";
                    ans4.Content = "Кошка";

                    ans1.Tag = "1";

                    Quebio.Text = "Промежуточный хозяин печёночного сосальщика";

                    break;

                case 10:

                    txtQuestion.Text = "Вопрос 10";

                    ans1.Content = "Легочная артерия";
                    ans2.Content = "Аорта";
                    ans3.Content = "Сонная артерия";
                    ans4.Content = "Базилярная";

                    ans2.Tag = "1";

                    Quebio.Text = "Самая крупная артерия называется:";

                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
        
    

