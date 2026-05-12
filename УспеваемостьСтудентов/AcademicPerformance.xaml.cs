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

namespace УспеваемостьСтудентов
{
    /// <summary>
    /// Логика взаимодействия для AcademicPerformance.xaml
    /// </summary>
    public partial class AcademicPerformance : Page
    {
        public AcademicPerformance()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Singlton.GetContext().Успеваемость.ToList();

        }

        //добавить
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.Main.Navigate(new AddEdit(null));
        }

        //удалить
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var del = dataGrid.SelectedItems.Cast<Успеваемость>().ToList();
            Singlton.GetContext().Успеваемость.RemoveRange(del);
            Singlton.GetContext().SaveChanges();
            dataGrid.ItemsSource = Singlton.GetContext().Успеваемость.ToList();
        }

        //изменить
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Manager.Main.Navigate(new AddEdit((sender as Button).DataContext as Успеваемость));
        }
    }
}
