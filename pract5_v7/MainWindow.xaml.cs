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
using Lib_7;

namespace pract5_v7
{
    public partial class MainWindow : Window
    {
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Корняков Д.Д.\n" + // Информация
             "Практическая работа №5\n" +
             "Создать класс Triad (тройка чисел). Создать необходимые методы и свойства." +
             "Определить метод сравнения триад: триада p1 больше триады р2, если (first.pl > first.р2) или (first.pl = first.р2) и (second.pl > second.р2) и (three.pl > three.р2)." +
             "Создать перегруженные методы SetParams, для установки параметров объекта, в том числе увеличения всех чисел на 10.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
          this.Close();
        }

        private void BtSravnenie_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(FirstTr1.Text, out int ft1) && int.TryParse(SecondTr1.Text, out int st1) && int.TryParse(TherdTr1.Text, out int tht1)
                && int.TryParse(FirstTr2.Text, out int ft2) && int.TryParse(SecondTr2.Text, out int st2) && int.TryParse(TherdTr2.Text, out int tht2))
            {
                Triad cislo1 = new Triad(ft1, st1, tht1);
                Triad cislo2 = new Triad(ft2, st2, tht2);

                cislo1.SetParams(ft1, st1, tht1);
                cislo2.SetParams(ft2, st2, tht2);

                FirstTr1.Text = Convert.ToString(cislo1.First);
                SecondTr1.Text = Convert.ToString(cislo1.Second);
                TherdTr1.Text = Convert.ToString(cislo1.Therd);

                FirstTr2.Text = Convert.ToString(cislo2.First);
                SecondTr2.Text = Convert.ToString(cislo2.Second);
                TherdTr2.Text = Convert.ToString(cislo2.Therd);

                bool SravnCislo1 = cislo1.Sravnenie(cislo2);

                if (SravnCislo1 == true)
                {
                    Sravnenie0.Text += Convert.ToString("Первая триада > Вторая триада ");
                }
                else
                {
                    Sravnenie0.Text += Convert.ToString("Вторая триада > Первая триада ");
                }
            }
            else
            {
                MessageBox.Show("Я люблю только цифры, не ломай меня пожалуйста ");

            }
        }

        private void Ochistka_Click(object sender, RoutedEventArgs e)
        {
            FirstTr1.Clear();
            SecondTr1.Clear();
            TherdTr1.Clear();
            FirstTr2.Clear();
            SecondTr2.Clear();
            TherdTr2.Clear();
            Sravnenie0.Clear();
        }

    }
}


