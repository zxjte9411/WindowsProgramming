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
        private CreditCardPayment _creditCardPayment;
        public Order()
        {
            _userSelectedProducts = new List<Product>();
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

        // 把所選的產品加入清單中
        public void AddSelectProductToList(Product selectProduct)
        {
            _userSelectedProducts.Add(new Product(selectProduct.Name, selectProduct.Category, selectProduct.Price, selectProduct.Description, selectProduct.ImagePath, (1).ToString()));
        }

        // 回傳餐點的價格總和
        public int GetTotalPrice()
        {
            int totalPrice = 0;
            foreach (var product in _userSelectedProducts)
                totalPrice += int.Parse(product.Price) * int.Parse(product.Quantity);
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
                string[] userSelectedProductInStringArray = new string[Constant.FIVE + 1];
                userSelectedProductInStringArray[0] = string.Empty;
                userSelectedProductInStringArray[1] = _userSelectedProducts[i].Name;
                userSelectedProductInStringArray[Constant.TWO] = _userSelectedProducts[i].Category.Name;
                userSelectedProductInStringArray[Constant.THREE] = int.Parse(_userSelectedProducts[i].Price).ToString(Constant.NO);
                userSelectedProductInStringArray[Constant.FOUR] = _userSelectedProducts[i].Quantity;
                userSelectedProductInStringArray[Constant.FIVE] = (int.Parse(_userSelectedProducts[i].Price) * int.Parse(_userSelectedProducts[i].Quantity)).ToString(Constant.NO);
                userSelectedProductInStringList.Add(userSelectedProductInStringArray);
            }
            return userSelectedProductInStringList;
        }

        // 取得單個產品的總價
        public int GetCustomerSelectedProductSubtotal(int rowIndex)
        {
            return int.Parse(_userSelectedProducts[rowIndex].Price) * int.Parse(_userSelectedProducts[rowIndex].Quantity);
        }
    }
}
