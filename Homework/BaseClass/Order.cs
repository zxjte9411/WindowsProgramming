using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Order
    {
        private List<Product> _userSelectedProducts;
        private List<int> _userSelectedProductQuantity;
        private CreditCardPayment _creditCardPayment;
        public Order()
        {
            _userSelectedProducts = new List<Product>();
            _userSelectedProductQuantity = new List<int>();
            _creditCardPayment = new CreditCardPayment();
        }

        public List<Product> UserSelectProduct
        {
            get
            {
                return _userSelectedProducts;
            }
            set
            {
                _userSelectedProducts = value;
            }
        }

        public List<int> UserSelectProductQuantity
        {
            get
            {
                return _userSelectedProductQuantity;
            }
            set
            {
                _userSelectedProductQuantity = value;
            }
        }

        // 把所選的產品加入清單中
        public void AddSelectProductToList(Product selectProduct)
        {
            //for (int i = 0; i < _userSelectedProducts.Count; i++)
            //{
            //    if (_userSelectedProducts[i].Name == selectProduct.Name)
            //    {
            //        _userSelectedProductQuantity[i]++;
            //        return;
            //    }
            //}
            _userSelectedProducts.Add(selectProduct);
            //_userSelectedProductQuantity.Add(1);
        }

        // 回傳餐點的價格總和
        public int GetTotalPrice()
        {
            int totalPrice = 0;
            foreach (var product in _userSelectedProducts)
                totalPrice += int.Parse(product.Price);
            return totalPrice;
        }

        //刪除商品
        public void DeleteMeal(int productIndex)
        {
            _userSelectedProducts.RemoveAt(productIndex);
        }

        public CreditCardPayment CreditCardPayment
        {
            get
            {
                return _creditCardPayment;
            }
            set
            {
                _creditCardPayment = value;
            }
        }

        // 取得訂單中的資料
        public List<string[]> GetUserSelectProductInList()
        {
            List<string[]> userSelectedProductInStringList = new List<string[]>();
            for (int i = 0; i < _userSelectedProducts.Count; i++)
            {
                string[] userSelectedProductInStringArray = new string[Constant.FOUR];
                userSelectedProductInStringArray[0] = string.Empty;
                userSelectedProductInStringArray[1] = _userSelectedProducts[i].Name;
                userSelectedProductInStringArray[Constant.TWO] = _userSelectedProducts[i].Category.Name;
                userSelectedProductInStringArray[Constant.THREE] = _userSelectedProducts[i].Price;
                userSelectedProductInStringList.Add(userSelectedProductInStringArray);
            }
            return userSelectedProductInStringList;
        }
    }
}
