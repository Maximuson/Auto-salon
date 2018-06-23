using System;
using System.Collections.Generic;
using System.IO;
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
using SendMessage;

namespace SQLLiteExample
{
    /// <summary>
    /// Логика взаимодействия для ForTest.xaml
    /// </summary>
    public partial class ForTest : Window
    {
        public Car Car { get; private set; }

        public ForTest(Car c)
        {
            InitializeComponent();
            Car = c;
            this.DataContext = Car;
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public void sendMsgOnClick(object sender, RoutedEventArgs e)
        {
            string mailTo;

            if (EmailBox.Text.Length != 0)
                mailTo = EmailBox.Text;
            else mailTo = @"vitallyhalez@gmail.com";


            string TitleMsg = "Ваш заказ";

            Random random = new Random();

            int numberItem = random.Next(100000, 999999);

            //StreamReader objReader = new StreamReader(@"C:\Users\Vitally\Desktop\MesageAudi\index.html");
            //FileStream fileStream = new FileStream(@"C:\Users\Vitally\Desktop\MesageAudi\index.html", FileMode.Open, FileAccess.Read);

            //string Msg = objReader.ReadToEnd();

            string BodyMsg =
               "<h1 align = 'center'>VW GROUP</h1>" +
               "<h2 align = 'center'>Спасибо за выбор нашего автосалона</h2>" +
               "<hr>" +
               "<h3>Ваш заказ:</h3>" +
               "<h5>Цена: </h5>" + "<p>" + Car.Price + "</p>" +
               "<h5>Компания:</h5>" + "<p>" + Car.Company + "</p>" +
               "<h5>Модель: </h5>" + "<p>" + Car.Model + "</p>" +
               "<hr>" +
               "<h3>Комплектация:</h3>" +
               "<h5>Привод: </h5>" + "<p>" + Car.DriveUnit + "</p>" +
               "<h5>Тип двигателя:</h5>" + "<p>" + Car.TypeEngine + "</p>" +
               "<h5>Коробка переключения передач: </h5>" + "<p>" + Car.TypeKPP + "</p>" +
               "<hr>" +
               "<h5>Код заказа: </h5>" + "<p>" + numberItem + "</p>";

            SendMsg.SendMail("vwgroupautosalon@gmail.com", "vwgroup", mailTo, TitleMsg, BodyMsg, Car.PathImage);
        }

    }
}
