using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class OrderFormPresentationModel
    {
        public delegate void DataGridViewEventHandler(int rowIndex, string total);
        public event DataGridViewEventHandler _deleteEvent;

        private OrderFormModel _orderFormModel;
        private int _currentPageNumber;
        private int _pages;
        private bool _isSelectedProduct;
        private bool _isHavePreviousPage;
        private bool _isHaveNextPage;
        private bool _isButtonAddEnable;
        private bool _isOrderButtonEnable;
        
        public OrderFormPresentationModel(OrderFormModel orderFormModel)
        {
            _orderFormModel = orderFormModel;
            _currentPageNumber = 1;
            _isHavePreviousPage = false;
            _isHaveNextPage = true;
            _isSelectedProduct = false;
            _isButtonAddEnable = false;
            _isOrderButtonEnable = false;
            UpdatePages(_orderFormModel.ProductCategory[0].Count);
            UpdateButtonState();
        }

        // 刪除商品
        public void RemoveProduct(int rowIndex, int columnIndex)
        {
            if (columnIndex == 0 && rowIndex >= 0)
            {
                _orderFormModel.Order.DeleteMeal(rowIndex);
                _deleteEvent(rowIndex, GetTotalPriceText());
            }
        }

        // 更新頁面數，強大公式
        private void UpdatePages(int productCount)
        {
            _pages = (productCount - 1) / Constant.BUTTON_COUNT + 1;
        }

        // 取得當前頁面產品資訊
        public List<string> GetCurrentPageProductsImagePath(string categoryName)
        {
            List<Product> allProductOfThisCategory = _orderFormModel.GetProductsOfThisCategory(categoryName);
            List<string> productsImagePath = new List<string>();
            UpdatePages(allProductOfThisCategory.Count);
            UpdateButtonState();
            int index = Constant.BUTTON_COUNT * (_currentPageNumber - 1);
            for (int i = 0; i < Constant.BUTTON_COUNT; i++)
            {
                if (allProductOfThisCategory.Count <= index + i)
                    productsImagePath.Add(Constant.BUTTON_ADD_ICON_IMAGE_PATH);
                else
                    productsImagePath.Add(allProductOfThisCategory[index + i].ImagePath);
            }
            return productsImagePath;
        }

        // 取得產品 
        public Product GetProduct(string categoryName, int buttonIndex)
        {
            _isSelectedProduct = true;
            UpdateButtonState();
            return _orderFormModel.GetProduct(categoryName, buttonIndex + Constant.BUTTON_COUNT * (_currentPageNumber - 1));
        }

        // 取得資料列
        public string[] GetRowData()
        {
            return _orderFormModel.GetRowData();
        }

        // 加入到"我的商品"清單 (代表已按下新增按鈕)
        public void AddProduct()
        {
            _orderFormModel.AddProduct();
            _isSelectedProduct = false;
            UpdateButtonState();
        }

        // 取得餐點的價格總和
        public string GetTotalPriceText()
        {
            const string NO = "N0"; // 千分位轉換參數
            return Constant.TOTAL + _orderFormModel.Order.GetTotalPrice().ToString(NO) + Constant.DOLLAR;
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

        public string[] ProductCategorysName
        {
            get
            {
                return _orderFormModel.ProductCategorysName;
            }
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
        }

        public bool IsButtonAddEnable
        {
            get
            {
                return _isButtonAddEnable;
            }
        }

        public bool IsOrderButtonEnable
        {
            get
            {
                if (_orderFormModel.Order.UserSelectProduct.Count == 0)
                    _isOrderButtonEnable = false;
                else
                    _isOrderButtonEnable = true;
                return _isOrderButtonEnable;
            }
        }

        public OrderFormModel OrderFormModel
        {
            get
            {
                return _orderFormModel;
            }
            set
            {
                _orderFormModel = value;
            }
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
            if (_isSelectedProduct)
                _isButtonAddEnable = true;
            else
                _isButtonAddEnable = false;
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

        // 取得頁碼文字
        public string GetPageNumberText()
        {
            return _currentPageNumber + Constant.SLASH + _pages;
        }

        // 取得訂單中的資料
        public List<string[]> GetUserSelectProductInList()
        {
            return _orderFormModel.Order.GetUserSelectProductInList();
        }
    }
}