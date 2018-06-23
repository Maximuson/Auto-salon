using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SQLLiteExample 
{
    public class Car : INotifyPropertyChanged
    {
        private string model; // m5,q7,c63C:\Users\Vitally\source\repos\AudiSalon\SQLLiteExample\Model\Car.cs
        private string driveUnit; //Привод автомобиля(передний, задний или полный)
        private string typeEngine; //Тип двигателя(дизель, бензин, электро, гибрид)
        private string typeKPP; //Тип КПП(Механика или автомат)
        private string company; // audi bmw mbz
        private string pathImage;
        private string globalInfo;
        private int price;

        public int Id { get; set; }

        public string Model
        {
            get { return model; }
            set
            {
                model = value;
                OnPropertyChanged("Model");
            }
        }

        public string DriveUnit
        {
            get { return driveUnit; }
            set
            {
                driveUnit = value;
                OnPropertyChanged("DriveUnit");
            }
        }

        public string TypeEngine
        {
            get { return typeEngine; }
            set
            {
                typeEngine = value;
                OnPropertyChanged("TypeEngine");
            }
        }

        public string TypeKPP
        {
            get { return typeKPP; }
            set
            {
                typeKPP = value;
                OnPropertyChanged("TypeKPP");
            }
        }

        public string Company
        {
            get { return company; }
            set
            {
                company = value;
                OnPropertyChanged("Company");
            }
        }

        public string PathImage
        {
            get { return pathImage; }
            set
            {
                pathImage = value;
                OnPropertyChanged("PathImage");
            }
        }

        public string GlobalInfo
        {
            get { return globalInfo; }
            set
            {
                globalInfo = value;
                OnPropertyChanged("GlobalInfo");
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
