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
    /// Логика взаимодействия для AddEdit.xaml
    /// </summary>
    public partial class AddEdit : Page
    {
        private Успеваемость _db = new Успеваемость();
        public AddEdit(Успеваемость db)
        {
            InitializeComponent();
            if (db != null)
                _db = db;
            DataContext = _db;

            comboBox.ItemsSource = Singlton.GetContext().Студенты.ToList();
            comboBox1.ItemsSource = Singlton.GetContext().Преподаватели.ToList();
            comboBox2.ItemsSource = Singlton.GetContext().Предметы.ToList();
            
        }

        //сохранить
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _db.Дата_сдачи = Convert.ToDateTime(date.Text.ToString());
            if (_db.ID_Успеваемости == 0)
                Singlton.GetContext().Успеваемость.Add(_db);
            Singlton.GetContext().SaveChanges();
            MessageBox.Show("Сохранено");
            Manager.Main.Navigate(new AcademicPerformance());
        }

        //выйти
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.Main.Navigate(new AcademicPerformance());
        }
    }
}
