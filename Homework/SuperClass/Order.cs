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
        private List<int> _userSelectedProductsQuantity;
        private CreditCardPayment _creditCardPayment;
        public Order()
        {
            UserSelectProduct = new List<Product>();
            CreditCardPayment = new CreditCardPayment();
            UserSelectedProductsQuantity = new List<int>();
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
            _userSelectedProducts.Add(selectProduct);
            _userSelectedProductsQuantity.Add(1);
        }

        // 回傳餐點的價格總和
        public int GetTotalPrice()
        {
            int totalPrice = 0;
            foreach (var product in _userSelectedProducts)
                totalPrice += int.Parse(product.Price) * _userSelectedProductsQuantity[_userSelectedProducts.IndexOf(product)];
            return totalPrice;
        }

        //刪除商品
        public void DeleteProduct(int productIndex)
        {
            _userSelectedProducts.RemoveAt(productIndex);
            _userSelectedProductsQuantity.RemoveAt(productIndex);
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

        public List<int> UserSelectedProductsQuantity
        {
            get
            {
                return _userSelectedProductsQuantity;
            }
            set
            {
                _userSelectedProductsQuantity = value;
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
                userSelectedProductInStringArray[Constant.FOUR] = _userSelectedProductsQuantity[i].ToString();
                userSelectedProductInStringArray[Constant.FIVE] = (int.Parse(_userSelectedProducts[i].Price) * _userSelectedProductsQuantity[i]).ToString(Constant.NO);
                userSelectedProductInStringList.Add(userSelectedProductInStringArray);
            }
            return userSelectedProductInStringList;
        }

        // 取得單個產品的總價
        public int GetCustomerSelectedProductSubtotal(int rowIndex)
        {
            return int.Parse(_userSelectedProducts[rowIndex].Price) * _userSelectedProductsQuantity[rowIndex];
        }

        // 計算庫存數量
        public void CalculateRemainingStockQuantity()
        {
            foreach (var userProduct in UserSelectProduct)
                userProduct.Quantity = (int.Parse(userProduct.Quantity) - UserSelectedProductsQuantity[UserSelectProduct.IndexOf(userProduct)]).ToString();
        }

        // 產品是否已加入到我的清單中
        public bool IsHaveThisProduct(string productName)
        {
            foreach (var userSelect in UserSelectProduct)
                if (productName.Equals(userSelect.Name))
                    return true;
            return false;
        }
    }
}
