using System.Collections.Generic;

namespace PackerTracker.Models
{
    public class PackItem
    {
        //private string _name;
        //private string _brand;
        private double _price;
        private double _weight;
        private bool _isPurchased;
        private bool _isPacked;
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = noNegative(value);
            }
        }
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = noNegative(value);
            }
        }
        public bool IsPurchased
        {
            get
            {
                return _isPurchased;
            }
            set
            {
                if (value)
                {
                    _isPurchased = true;
                }
                else
                {
                    _isPurchased = false;
                    _isPacked = false;
                }
            }
        }
        public bool IsPacked
        {
            get
            {
                return _isPacked;
            }
            set
            {
                if (value)
                {
                    _isPacked = true;
                    _isPurchased = true;
                }
                else
                {
                    _isPacked = false;
                }

            }
        }
        /*
        public PackItem()
        {
            Name = "";
            Brand = "";
            Price = 0;
            Weight = 0;
            IsPurchased = false;
            IsPacked = false;
        }*/

        public PackItem(string name, string brand, double price, double weight, 
                        bool isPurchased, bool isPacked)
        {
            Name = name;
            Brand = brand;
            Price = price;
            Weight = weight;
            IsPurchased = isPurchased;
            IsPacked = isPacked;
        }

        private double noNegative(double value)
        {
            if (value <= 0)
            {
                return 0;
            }
            return value;
        }
    }
}