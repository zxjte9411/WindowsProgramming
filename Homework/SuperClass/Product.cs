using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Product
    {
        private string _name;
        private string _price;
        private Category _category;
        private string _description;
        private string _imagePath;
        private string _quantity;

        public Product(string name, Category category, string price, string description, string imagePath, string quantity)
        {
            Name = name;
            Category = category;
            Price = price;
            Description = description;
            ImagePath = imagePath;
            Quantity = quantity;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Price
        { 
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        public string ImagePath
        { 
            get
            {
                return _imagePath;
            }
            set
            {
                _imagePath = value;
            }
        }
        public Category Category
        { 
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
        public string Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
    }
}
