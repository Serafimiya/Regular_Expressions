using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Regular_Expressions
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
        private void btnProgrammer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнила студентка группы ИСП-31 Лосева Анастасия", "О разработчике:");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        ///  Выполнение первого задания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRez1_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear(); // Очищаем элементы в listBox1 перед выводом новых данных
            string line = outLine1.Text;

            // Регулярное выражение для поиска "aa", "aba", "abba", "abbba"
            Regex regex = new Regex("\\ba(b{0,3})a\\b");
            MatchCollection matches = regex.Matches(line); // Находим все совпадения

            foreach (Match match in matches) // Перебираем найденные совпадения
            {
                listBox1.Items.Add(match.Value); // Добавляем строковые значения совпадений в listBox1
            }
        }

        /// <summary>
        /// Выполнение второго задания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRez_Click(object sender, RoutedEventArgs e)
        {
            listBox2.Items.Clear(); // Очищаем элементы в listBox2 перед выводом новых данных
            string line = outLine2.Text;

            // Регулярное выражение для поиска строк вида "aXa", где X — одна цифра
            Regex regex = new Regex("\\ba\\d{1}a\\b");
            MatchCollection matches = regex.Matches(line); // Находим все совпадения

            foreach (Match match in matches) // Перебираем найденные совпадения
            {
                listBox2.Items.Add(match.Value); // Добавляем строковые значения совпадений в listBox2
            }
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1) Дана строка 'aa aba abba abbba abca abea'.\r\nНапишите регулярное выражение, которое найдет строки aa, aba, abba, abbba.");
            MessageBox.Show("2) Дана строка 'a1a a2a a3a a4a a5a aba aca'.\r\nНапишите регулярное выражение, которое найдет строки,\r\nв которых по краям стоят буквы 'a', а между ними одна цифра. ", "О программе:");
        }
    }
}