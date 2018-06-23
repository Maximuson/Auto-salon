using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Runtime.CompilerServices;
using System.Windows.Data;

namespace SQLLiteExample
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        ApplicationContext db;
        RelayCommand addCommand;
        RelayCommand editCommand;
        RelayCommand deleteCommand;
        RelayCommand viewCommand;
        IEnumerable<Car> cars;

        public IEnumerable<Car> Cars
        {
            get { return cars; }
            set
            {
                cars = value;
                OnPropertyChanged("Cars");
            }
        }

        public ApplicationViewModel()
        {
            db = new ApplicationContext();
            db.Cars.Load();
            Cars = db.Cars.Local.ToBindingList();
        }

        
        // команда добавления
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand((o) =>
                  {
                      CarWindow carWindow = new CarWindow(new Car());
                      if (carWindow.ShowDialog() == true)
                      {
                          Car car = carWindow.Car;
                          db.Cars.Add(car);
                          db.SaveChanges();
                      }
                  }));
            }
        }
        // команда редактирования
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                  (editCommand = new RelayCommand((selectedItem) =>
                  {
                      if (selectedItem == null) return;
                      // получаем выделенный объект
                      Car car = selectedItem as Car;

                      Car vm = new Car()
                      {
                          Id = car.Id,
                          Company = car.Company,
                          Price = car.Price,
                          Model = car.Model,
                          TypeEngine = car.TypeEngine,
                          TypeKPP = car.TypeKPP,
                          DriveUnit = car.DriveUnit,
                          GlobalInfo = car.GlobalInfo,
                          PathImage = car.PathImage
                      };

                      CarWindow carWindow = new CarWindow(vm);


                      if (carWindow.ShowDialog() == true)
                      {
                          // получаем измененный объект
                          car = db.Cars.Find(carWindow.Car.Id);
                          if (car != null)
                          {
                              car.Company = carWindow.Car.Company;
                              car.Model = carWindow.Car.Model;
                              car.Price = carWindow.Car.Price;
                              car.TypeKPP = carWindow.Car.TypeKPP;
                              car.TypeEngine = carWindow.Car.TypeEngine;
                              car.DriveUnit = carWindow.Car.DriveUnit;
                              car.PathImage = carWindow.Car.PathImage;
                              car.GlobalInfo = carWindow.Car.GlobalInfo;
                              db.Entry(car).State = EntityState.Modified;
                              db.SaveChanges();
                          }
                      }
                  }));
            }
        }

        public RelayCommand ViewCommand
        {
            get
            {
                return viewCommand ??
                  (viewCommand = new RelayCommand((selectedItem) =>
                  {
                      if (selectedItem == null) return;
                      // получаем выделенный объект
                      Car car = selectedItem as Car;

                      Car vm = new Car()
                      {
                          Id = car.Id,
                          Company = car.Company,
                          Price = car.Price,
                          Model = car.Model,
                          TypeEngine = car.TypeEngine,
                          TypeKPP = car.TypeKPP,
                          DriveUnit = car.DriveUnit,
                          GlobalInfo = car.GlobalInfo,
                          PathImage = car.PathImage
                      };

                      //BuyWindow buyWindow = new BuyWindow(vm);
                      ForTest buyWindow = new ForTest(vm);

                      if (buyWindow.ShowDialog() == true)
                      {
                          // получаем измененный объект
                          car = db.Cars.Find(buyWindow.Car.Id);
                          if (car != null)
                          {
                              car.Company = buyWindow.Car.Company;
                              car.Model = buyWindow.Car.Model;
                              car.Price = buyWindow.Car.Price;
                              car.TypeKPP = buyWindow.Car.TypeKPP;
                              car.TypeEngine = buyWindow.Car.TypeEngine;
                              car.DriveUnit = buyWindow.Car.DriveUnit;
                              car.PathImage = buyWindow.Car.PathImage;
                              car.GlobalInfo = buyWindow.Car.GlobalInfo;
                              db.Entry(car).State = EntityState.Modified;
                              db.SaveChanges();
                          }
                      }
                  }));
            }
        }

        // команда удаления
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                  (deleteCommand = new RelayCommand((selectedItem) =>
                  {
                      if (selectedItem == null) return;
                      // получаем выделенный объект
                      Car car = selectedItem as Car;
                      db.Cars.Remove(car);
                      db.SaveChanges();
                  }));
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
