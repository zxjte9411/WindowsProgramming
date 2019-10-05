using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Order
    {
        private List<Product> _userSelectedProduct;
        private List<int> _userSelectedProductQuantity;
        private CreditCardPayment _creditCardPayment;
        public Order()
        {
            _userSelectedProduct = new List<Product>();
            _userSelectedProductQuantity = new List<int>();
            _creditCardPayment = new CreditCardPayment();
        }

        public List<Product> UserSelectProduct
        {
            get
            {
                return _userSelectedProduct;
            }
            set
            {
                _userSelectedProduct = value;
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
            for (int i = 0; i < _userSelectedProduct.Count; i++)
            {
                if (_userSelectedProduct[i].Name == selectProduct.Name)
                {
                    _userSelectedProductQuantity[i]++;
                    return;
                }
            }
            _userSelectedProduct.Add(selectProduct);
            _userSelectedProductQuantity.Add(1);
        }

        // 回傳餐點的價格總和
        public int GetTotalPrice()
        {
            int totalPrice = 0;
            foreach (var product in _userSelectedProduct)
                totalPrice += int.Parse(product.Price);
            return totalPrice;
        }
        
        //刪除商品
        public void DeleteMeal(int productIndex)
        {
            _userSelectedProduct.RemoveAt(productIndex);
        }
    }
}
