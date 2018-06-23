using System;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Animation;

namespace SQLLiteExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ApplicationViewModel();
        }
        //    CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(db.Cars.Local);
        //    view.Filter = UserFilter;
        //}

        //private bool UserFilter(object item)
        //{
        //    if (String.IsNullOrEmpty(Filter.Text))
        //        return true;
        //    else
        //        return ((item as Car).Model.IndexOf(Filter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        //}

        //private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        //{
        //    CollectionViewSource.GetDefaultView(phonesList.ItemsSource).Refresh();
        //}

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Window1 a = new Window1();
            //a.Show();
            //ForTest signUp = new ForTest();
            //signUp.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //ForTest forTest = new ForTest();
            //forTest.Show();
        }
    }
}
