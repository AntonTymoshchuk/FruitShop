using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop.Models
{
    public class Fruit : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private double price;
        private string color;
        private int quantity;
        private int maxQuantity;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
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

        public double Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        public string FruitColor
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged("FruitColor");
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        public int MaxQuantity
        {
            get { return maxQuantity; }
            set
            {
                maxQuantity = value;
                OnPropertyChanged("MaxQuantity");
            }
        }

        public Fruit()
        {
            maxQuantity = 1000;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
