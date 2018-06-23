using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Runtime.CompilerServices;

namespace SQLLiteExample.Archive
{
    //class AppVM : INotifyPropertyChanged
    //{
    //    ApplicationContext db;
    //    RelayCommand addCommand;
    //    RelayCommand editCommand;
    //    RelayCommand deleteCommand;
    //    IEnumerable<Car> phones;

    //    public IEnumerable<Car> Phones
    //    {
    //        get { return phones; }
    //        set
    //        {
    //            phones = value;
    //            OnPropertyChanged("Phones");
    //        }
    //    }

    //    public AppVM()
    //    {
    //        db = new ApplicationContext();
    //        db.Phones.Load();
    //        Phones = db.Phones.Local.ToBindingList();
    //    }
    //    // команда добавления
    //    public RelayCommand AddCommand
    //    {
    //        get
    //        {
    //            return addCommand ??
    //              (addCommand = new RelayCommand((o) =>
    //              {
    //                  PhoneWindow phoneWindow = new PhoneWindow(new Car());
    //                  if (phoneWindow.ShowDialog() == true)
    //                  {
    //                      Car phone = phoneWindow.Car;
    //                      db.Phones.Add(phone);
    //                      db.SaveChanges();
    //                  }
    //              }));
    //        }
    //    }
    //    // команда редактирования
    //    public RelayCommand EditCommand
    //    {
    //        get
    //        {
    //            return editCommand ??
    //              (editCommand = new RelayCommand((selectedItem) =>
    //              {
    //                  if (selectedItem == null) return;
    //                  // получаем выделенный объект
    //                  Car phone = selectedItem as Car;

    //                  Car vm = new Car()
    //                  {
    //                      Id = phone.Id,
    //                      Company = phone.Company,
    //                      Price = phone.Price,
    //                      Title = phone.Title
    //                  };
    //                  PhoneWindow phoneWindow = new PhoneWindow(vm);


    //                  if (phoneWindow.ShowDialog() == true)
    //                  {
    //                      // получаем измененный объект
    //                      phone = db.Phones.Find(phoneWindow.Car.Id);
    //                      if (phone != null)
    //                      {
    //                          phone.Company = phoneWindow.Car.Company;
    //                          phone.Title = phoneWindow.Car.Title;
    //                          phone.Price = phoneWindow.Car.Price;
    //                          db.Entry(phone).State = EntityState.Modified;
    //                          db.SaveChanges();
    //                      }
    //                  }
    //              }));
    //        }
    //    }
    //    // команда удаления
    //    public RelayCommand DeleteCommand
    //    {
    //        get
    //        {
    //            return deleteCommand ??
    //              (deleteCommand = new RelayCommand((selectedItem) =>
    //              {
    //                  if (selectedItem == null) return;
    //                  // получаем выделенный объект
    //                  Car phone = selectedItem as Car;
    //                  db.Phones.Remove(phone);
    //                  db.SaveChanges();
    //              }));
    //        }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;
    //    public void OnPropertyChanged([CallerMemberName]string prop = "")
    //    {
    //        if (PropertyChanged != null)
    //            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    //    }
    //}
}
