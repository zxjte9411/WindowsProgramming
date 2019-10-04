using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class OrderFormPresentationModel
    {
        private OrderFormModel _orderFormModel;
        private int _currentPageNumber;
        private int _pages;
        private bool _isSelectedProduct;
        private bool _isHavePreviousPage;
        private bool _isHaveNextPage;

        public OrderFormPresentationModel(OrderFormModel orderFormModel)
        {
            _orderFormModel = orderFormModel;
            _currentPageNumber = 1;
            _isHavePreviousPage = false;
            _isHaveNextPage = true;
            _isSelectedProduct = false;
            UpdatePages(_orderFormModel.ProductCategory[0].Count);
            UpdateButtonState();
        }

        // 更新頁面數，強大公式
        private void UpdatePages(int productCount)
        {
            _pages = (productCount - 1) / Constant.BUTTON_COUNT + 1;
        }

        // //更新上一頁、下一頁及新增按鈕的狀態
        private void UpdateButtonState()
        {
            if (_currentPageNumber == 1)
                _isHavePreviousPage = false;
            else
                _isHavePreviousPage = true;

            if (_currentPageNumber >= _pages)
                _isHaveNextPage = false;
            else
                _isHaveNextPage = true;
                            
        }

        // 取得當前頁面產品資訊
        public Dictionary<string, string> GetCurrentPageProducts(string categoryName)
        {
            List<Product> allProductOfThisCategory = _orderFormModel.GetProductsOfThisCategory(categoryName);
            Dictionary<string, string> products = new Dictionary<string, string>(); // key 為產品名稱 value 為圖片路徑
            UpdatePages(allProductOfThisCategory.Count);
            UpdateButtonState();
            int index = Constant.BUTTON_COUNT * (_currentPageNumber - 1);
            for (int i = 0; i < Constant.BUTTON_COUNT; i++)
            {
                if (allProductOfThisCategory.Count <= index + i)
                    products.Add(string.Empty + i.ToString(), Constant.IMAGE_PATH);
                else
                    products.Add(allProductOfThisCategory[index + i].Name, allProductOfThisCategory[index + i].ImagePath);
            }
            return products;
        }

        // 取得產品
        public Product GetProduct(string productName)
        {
            _isSelectedProduct = true;
            return _orderFormModel.GetProduct(productName);
        }

        // 取得資料列
        public string[] GetRowData()
        {
            return _orderFormModel.GetRowData();
        }

        // 加入我的商品清單
        public void AddProduct()
        {
            _orderFormModel.AddProduct();
            _isSelectedProduct = false;
            UpdateButtonState();
        }

        // 回傳餐點的價格總和
        public string GetTotalPriceText()
        {
            return Constant.TOTAL + _orderFormModel.Order.GetTotalPrice().ToString();
        }

        // GetCategoryCount
        private int GetCategoryCount(string categoryName)
        {
            return _orderFormModel.GetProductCategoryCount(categoryName);
        }

        // 按鈕是否可顯示
        public bool IsProductButtonVisible(int productButtonIndex, string categoryName)
        {
            if (_orderFormModel.ProductCategory.Count > 0)
                return ((_currentPageNumber - 1) * Constant.BUTTON_COUNT + productButtonIndex) < GetCategoryCount(categoryName);
            return false;
        }

        public int CurrentPageNumber
        {
            get
            {
                return _currentPageNumber;
            }
            set
            {
                _currentPageNumber = value;
            }
        }

        public bool IsHavePreviousPage
        {
            get
            {
                return _isHavePreviousPage;
            }
            set
            {
                _isHavePreviousPage = value;
            }
        }

        public bool IsHaveNextPage
        {
            get
            {
                return _isHaveNextPage;
            }
            set
            {
                _isHaveNextPage = value;
            }
        }

        public string[] ProductCategorysName
        {
            get
            {
                return _orderFormModel.ProductCategorysName;
            }
        }

        // go next page
        public void GoNextPage()
        {
            _currentPageNumber++;
            _isSelectedProduct = false;
            UpdateButtonState();
        }

        // go previous page
        public void GoPreviousPage()
        {
            _currentPageNumber--;
            _isSelectedProduct = false;
            UpdateButtonState();
        }
    }
}
