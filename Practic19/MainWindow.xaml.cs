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

namespace Practic10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> _massive = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void helpMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая Работа№10. ИСП-31. Назаров Д.А. Задание: \n Составьте программу вычисления в массиве суммы всех чисел, кратных 7");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(addNumber.Text, out int number))
            {
                _massive.Add(number);
                list.Text += number.ToString() + "\n" ;
                addNumber.Clear();
            }
            else MessageBox.Show("Введите правильные значения", "О! Шишка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void clearAll_Click(object sender, RoutedEventArgs e)
        {
            _massive.Clear();
            summOfNumber.Clear();
            list.Clear();
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            int sumOfNumbers = 0;
            for(int i = 0; i < _massive.Count; i++)
            {
                if (_massive[i] % 7 == 0) 
                {
                    sumOfNumbers += _massive[i];
                }
            }
            summOfNumber.Text = sumOfNumbers.ToString();
        }
    }
}
