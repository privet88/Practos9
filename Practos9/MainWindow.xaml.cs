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
using System.Data;

namespace Practos9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { DataRow row = res.NewRow();
        Studies discipline1 = new Studies("Математика" , "5");
        Studies discipline2 = new Studies("Физика", "4");
        Studies discipline3 = new Studies("Химия", "5");
        Studies discipline4 = new Studies("Астрономия","3");
        Studies discipline5 = new Studies("Экономика","4");
        public static DataTable res = new DataTable();
        public MainWindow()
        {
            InitializeComponent();
            res.Columns.Add("Дисциплина");
            res.Columns.Add("Успеваемость за месяц");
            disceplineTable.ItemsSource = res.DefaultView;
            row[0] = discipline1.DisciplineName;
            row[1] = discipline1.Perfomance;
            res.Rows.Add(row);
            row = res.NewRow();
            row[0] = discipline2.DisciplineName;
            row[1] = discipline2.Perfomance;
            res.Rows.Add(row);
            row = res.NewRow();
            row[0] = discipline3.DisciplineName;
            row[1] = discipline3.Perfomance;
            res.Rows.Add(row);
            row = res.NewRow();
            row[0] = discipline4.DisciplineName;
            row[1] = discipline4.Perfomance;
            res.Rows.Add(row);
            row = res.NewRow();
            row[0] = discipline5.DisciplineName;
            row[1] = discipline5.Perfomance;
            res.Rows.Add(row);
            row = res.NewRow();
            disceplineTable.ItemsSource = res.DefaultView;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            averagePerfomance.Text = Convert.ToString((Convert.ToDouble(discipline1.Perfomance) + Convert.ToDouble(discipline2.Perfomance) + Convert.ToDouble(discipline3.Perfomance) + Convert.ToDouble(discipline4.Perfomance) + Convert.ToDouble(discipline5.Perfomance))/5);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Потапкин. \n Задание:Заполнить таблицу успеваемости студента по 5 дисциплинам с полями:дисциплина,\n успеваемость за месяц.Вывести результат на экран.Вывести среднюю успеваемость по всем дисциплинам.");
        }
    }
}
