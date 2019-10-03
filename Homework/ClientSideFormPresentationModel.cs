using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class ClientSideFormPresentationModel
    {
        private ClientSideFormModel _clientSideFormModel;
        private int _currentPageNumber;
        private int _pages;
        private bool _isHavePreviousPage;
        private bool _isHaveNextPage;

        public ClientSideFormPresentationModel(ClientSideFormModel clientSideViewModel)
        {
            _clientSideFormModel = clientSideViewModel;
            _currentPageNumber = 1;
            _isHavePreviousPage = false;
            _isHaveNextPage = true;
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
                _isHavePreviousPage = false;
            else
                _isHavePreviousPage = true;
        }

        // 取得當前頁面產品資訊
        public Dictionary<string, string> GetCurrentPageProducts(string categoryName)
        {
            List<Product> allProductOfThisCategory = _clientSideFormModel.GetProductsOfThisCategory(categoryName);
            Dictionary<string, string> products = new Dictionary<string, string>(); // key 為產品名稱 value 為圖片路徑
            UpdatePages(allProductOfThisCategory.Count);
            int index = Constant.BUTTON_COUNT * (_currentPageNumber - 1);
            for (int i = 0; i < Constant.BUTTON_COUNT; i++)
            {
                if (allProductOfThisCategory.Count <= index + i)
                    products.Add(string.Empty + i.ToString(), Constant.IMAGE_PATH);
                else
                    products.Add(allProductOfThisCategory[i].Name, allProductOfThisCategory[i].ImagePath);
            }
            return products;
        }

        // 取得產品
        public Product GetProduct(string productName)
        {
            return _clientSideFormModel.GetProduct(productName);
        }

        // 取得資料列
        public string[] GetRowData()
        {
            return _clientSideFormModel.GetRowData();
        }

        // 加入我的商品清單
        public void AddProduct()
        {
            _clientSideFormModel.AddProduct();
        }

        // 回傳餐點的價格總和
        public string GetTotalPriceText()
        {
            return Constant.TOTAL + _clientSideFormModel.Order.GetTotalPrice().ToString();
        }

        // 13
        private int GetCategoryCount(string categoryName)
        {
            return _clientSideFormModel.GetProductCategoryCount(categoryName);
        }

        // 按鈕是否可顯示
        public bool IsMealButtonVisible(int productButtonIndex, string categoryName)
        {
            if (_clientSideFormModel.ProductCategory.Count > 0)
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
                return _clientSideFormModel.ProductCategorysName;
            }
        }

    }
}
