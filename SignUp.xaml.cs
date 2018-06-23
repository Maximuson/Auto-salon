using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;


namespace SQLLiteExample
{
    /// <summary>
    /// Логика взаимодействия для SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();

            //// анимация для ширины
            //DoubleAnimation widthAnimation = new DoubleAnimation();
            //widthAnimation.From = 0;
            //widthAnimation.To = 450;
            //widthAnimation.Duration = TimeSpan.FromSeconds(5);

            //// анимация для высоты
            //DoubleAnimation heightAnimation = new DoubleAnimation();
            //heightAnimation.From = 0;
            //heightAnimation.To = 450;
            //heightAnimation.Completed += DoubleAnimation_Completed;
            //heightAnimation.Duration = TimeSpan.FromSeconds(5);

            //SignWindow.BeginAnimation(WidthProperty, widthAnimation);
            //SignWindow.BeginAnimation(HeightProperty, heightAnimation);
        }

        private void helloButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void bttn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void DoubleAnimation_Completed(object sender, EventArgs e)
        {
            MessageBox.Show("Ok","Ok", MessageBoxButton.OK);
        }
    }
}
