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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diplom.View
{
    /// <summary>
    /// Логика взаимодействия для Test1.xaml
    /// </summary>
    public partial class Test1 : Page
    {
        private int currentQuestionIndex = 0;
        private string[] questions = { "1. Агрегация — это", 
            "2. Анализ требований — это", 
            "3. Архитектура программной системы — это", 
            "4. Ассоциация — это",
            "5. В каком документе, фиксирующем результаты определения стратегии внедрения ИС, \nдолжны быть четко определены результаты выполнения проекта для заказчика, а также указаны графики выполнения работ и график финансирования на разных этапах выполнения проекта?",
            "6. В качестве каких элементов системы централизованного управления сетью относятся\n порты или конкретные выходы в управляемом узле, \nкоторые агент предоставляет администратору?",
            "7. Валидация — это" ,
            "8. Верификация —это",
            "9. Для каких задач, в общем случае, должны проводиться \nработы по сопровождению ПО?",
            "10. Для какой из этих категорий качество в процессе эксплуатации \nпрограммного средства определяется, прежде всего, мобильностью?",};
        private string[][] answers = {
            new string[] { "отношения, утверждает наличие связи между понятиями, \nне уточняя зависимости их содержания и объемов",
                "возможность для некоторого класса находиться одновременно \nв связи с одним элементом из определенного множества классов",
                "объединение нескольких понятий в новое понятие, существенные признаки нового понятия \nпри этом могут быть либо суммой компонент или существенно новыми (отношение «доля — целое»)"},
            new string[] { "отображение функций системы и ее ограничений в модели проблемы",
                "показатель супроводжуваности, который определяет \nнеобходимые усилия для диагностики случаев отказов",
                "отображение частей программ, которые будут модифицироваться"},
            new string[] { "декомпозиция решения для выделенного спектра\n задач домена на подсистемы или иерархию подсистем",
                "определение системы в терминах вычислительных составляющих (подсистем) и \nинтерфейсов между ними, которое отражает \nправила декомпозиции проблемы на составляющие",
                "соответствующие вариации состава выделенных компонент"}, 
            new string[] {"возможность для некоторого класса находиться одновременно\n в связи с одним элементом из определенного множества классов",
                "объединение нескольких понятий в новее понятия, существенные признаки нового \nпонятия о этом могут быть либо суммой компонент или \nсущественно новыми (отношение «доля — целое»)",
                "самое общее отношение, утверждает наличие связи между понятиями,\n не уточняя зависимости их содержания и объемов"},
            new string[] {"Техническое задание",
                "Технико-экономическое обоснование",
                "Технические предложения"},
            new string[] {"Управляющая база данных",
                "Протокол управления взаимодействием администратора с агентом",
                "Объекты"},
            new string[] {"обеспечение соответствия разработки требованиям ее заказчиков",
                "проверка правильности трансформации проекта в код реализации",
                "выявление всех ошибок"},
            new string[] {"обеспечение соответствия разработки требованиям ее заказчиков",
                "проверка правильности трансформации проекта в программу",
                "действия на каждой стадии жизненного цикла с \nпроверки и подтверждения соответствия стандартам"},
            new string[] { "устранение сбоев",
                "улучшение дизайна",
                "реализация базовых функциональных возможностей"},
            new string[] {"Для разработчиков",
                "Для конечного пользователя",
                "Для персонала сопровождения"}
        };
        private string[] correctAnswers = { "объединение нескольких понятий в новое понятие, существенные признаки нового понятия при этом могут быть либо суммой компонент или существенно новыми (отношение «доля — целое»)",
            "отображение функций системы и ее ограничений в модели проблемы",
            "определение системы в терминах вычислительных составляющих (подсистем) и интерфейсов между ними, которое отражает правила декомпозиции проблемы на составляющие",
            "возможность для некоторого класса находиться одновременно в связи с одним элементом из определенного множества классов",
            "Технико-экономическое обоснование",
            "Объекты",
            "обеспечение соответствия разработки требованиям ее заказчиков",
            "проверка правильности трансформации проекта в программу",
            "улучшение дизайна",
            "Для конечного пользователя"
        };
        private int score = 0;
        public Test1()
        {
            InitializeComponent();
            DisplayQuestion();
        }
        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Length)
            {
                questionLabel.Content = "Вопрос: " + questions[currentQuestionIndex];
                option1.Content = answers[currentQuestionIndex][0];
                option2.Content = answers[currentQuestionIndex][1];
                option3.Content = answers[currentQuestionIndex][2];
                option1.IsChecked = option2.IsChecked = option3.IsChecked = option3.IsChecked = false;
            }
            else
            {
                CalculateScore();
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (option1.IsChecked == true || option2.IsChecked == true || option3.IsChecked == true)
            {
                if (currentQuestionIndex < questions.Length)
                {
                    if (option1.IsChecked == true && option1.Content.ToString() == correctAnswers[currentQuestionIndex])
                    {
                        score++;
                    }
                    else if (option2.IsChecked == true && option2.Content.ToString() == correctAnswers[currentQuestionIndex])
                    {
                        score++;
                    }
                    else if (option3.IsChecked == true && option3.Content.ToString() == correctAnswers[currentQuestionIndex])
                    {
                        score++;
                    }
                    

                    currentQuestionIndex++;
                    DisplayQuestion();
                }
            }
            else
            {
                MessageBox.Show("Выберите вариант ответа!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CalculateScore()
        {
            double percentage = ((double)score / questions.Length) * 100;
            string grade;

            if (percentage >= 90)
                grade = "Отлично";
            else if (percentage >= 70)
                grade = "Хорошо";
            else if (percentage >= 50)
                grade = "Удовлетворительно";
            else
                grade = "Неудовлетворительно";

            resultTextBlock.Text = $"Ваш результат: {score} из {questions.Length} правильных ответов.\nОценка: {grade}";
        }
    }
}
