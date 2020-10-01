using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FruitShop.Models
{
    public class ShopViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Fruit> fruits;
        private string name;
        private string phone;
        private string address;
        private ICommand sellItemCommand;

        public ObservableCollection<Fruit> Fruits
        {
            get { return fruits; }
            set
            {
                fruits = value;
                OnPropertyChanged("Fruits");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }

        public ICommand SellItemCommand
        {
            get { return sellItemCommand; }
            set { sellItemCommand = value; }
        }

        public ShopViewModel()
        {
            name = "Jungles Corp.";
            phone = "0666865259";
            address = "Pr. Sobornosti 33";

            fruits = new ObservableCollection<Fruit>()
            {
                new Fruit() { Name = "Apple", Price = 2.99, FruitColor = "Green", Quantity = 400 },
                new Fruit() { Name = "Pineapple", Price = 4.99, FruitColor = "Green", Quantity = 600 },
                new Fruit() { Name = "Banana", Price = 3.99, FruitColor = "Green", Quantity = 900 },
                new Fruit() { Name = "Granate", Price = 5.99, FruitColor = "Green", Quantity = 350 },
                new Fruit() { Name = "Kiwi", Price = 6.99, FruitColor = "Green", Quantity = 51 }
            };
            for (int i = 0; i < fruits.Count; i++)
                fruits[i].Id = i;

            sellItemCommand = new Commands.DelegateCommand(SellItem, CanSellItem);
        }

        public void SellItem(object item)
        {
            fruits.Remove(item as Fruit);
        }

        public bool CanSellItem(object item)
        {
            if (item != null)
                return true;
            return false;
        }

        //public void AddFruit(Fruit fruit)
        //{
        //    fruits.Add(fruit);
        //}

        //public Fruit SellFruit(string name)
        //{
        //    for (int i = 0; i < fruits.Count; i++)
        //    {
        //        if (fruits[i].Name == name)
        //        {
        //            Fruit fruit = new Fruit() { Id = fruits[i].Id, Name = fruits[i].Name, Price = fruits[i].Price };
        //            fruits.Remove(fruit);
        //            return fruit;
        //        }
        //    }
        //    return null;
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
