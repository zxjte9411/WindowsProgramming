using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Category
    {
        private string _name;
        private int _count;

        public Category(string name, int count)
        {
            Name = name;
            Count = count;
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

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        // 比較兩者的類別是否相同
        public Category CompareCount(Category category)
        {
            if (_name != category.Name)
            {
                _count -= 1;
                category.Count += 1;
                return category;
            }
            return this;
        }
    } 
}
