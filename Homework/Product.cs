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

        public Product(string name, Category category, string price, string description, string imagePath)
        {
            Name = name;
            Category = category;
            Price = price;
            Description = description;
            ImagePath = imagePath;
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
        internal Category Category
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
    }
}
