using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class OrderFormModel
    {
        private Order _order;
        private List<Product> _productList;
        private List<Category> _productCategory;
        private Product _currentUserSelectProduct;

        public OrderFormModel()
        {
            _order = new Order();
            _productList = new List<Product>();
            _productCategory = new List<Category>();
            InitializeCategoryList();
            InitializeProductList();
        }
        // initialize product list
        private void InitializeProductList()
        {
            string productInformationPath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + Constant.PRODUCT_INFORMATION_FILE_NAME;
            System.IO.StreamReader productInformationFile = new System.IO.StreamReader(productInformationPath, System.Text.Encoding.UTF8);
            string line;
            // 讀取所有預設產品清單，並對此類產品計算分類數量
            while ((line = productInformationFile.ReadLine()) != null)
            {
                string[] productInformation = line.Split(Constant.CHAR_SPACE);
                _productList.Add(new Product(productInformation[0], AddProductCategoryAndQuantity(productInformation[1], 1), productInformation[Constant.TWO], productInformation[Constant.THREE], productInformation[Constant.FOUR]));
            }
            productInformationFile.Close();
        }

        // initialize category list
        private void InitializeCategoryList()
        {
            string productCategoryPath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + Constant.PRODUCT_CATEGORY_FILE_NAME;
            System.IO.StreamReader productCategoryFile = new System.IO.StreamReader(productCategoryPath, System.Text.Encoding.UTF8);
            string line;
            // 讀取產品分類項目
            while ((line = productCategoryFile.ReadLine()) != null)
                _productCategory.Add(new Category(line, 0));
            productCategoryFile.Close();
        }

        // 增加產品類別及數量
        public Category AddProductCategoryAndQuantity(string categoryName, int count)
        {
            // 先檢查數量清單中市府已經有加入，有的話數量增加一，沒有就建立新的產品類別
            
            for (int i = 0; i < _productCategory.Count; i++)
            {
                if (_productCategory[i].Name == categoryName)
                {
                    _productCategory[i].Count++;
                    return _productCategory[i];
                }
            }
            return null;
        }

        // 取得所有分類的名稱
        public string[] ProductCategorysName
        {
            get
            {
                string[] productCategoryText = new string[_productCategory.Count];
                for (int i = 0; i < _productCategory.Count; i++)
                    productCategoryText[i] = _productCategory[i].Name;
                return productCategoryText;
            }
        }

        // 取得當前類別的產品 
        public List<Product> GetProductsOfThisCategory(string categoryName)
        {
            List<Product> currentPageProducts = new List<Product>();
            for (int i = 0; i < _productList.Count; i++)
                if (_productList[i].Category.Name == categoryName)
                    currentPageProducts.Add(_productList[i]);
            return currentPageProducts;
        }
        
        // 取得產品描述
        public Product GetProduct(int productIndex)
        {
            return _currentUserSelectProduct = _productList[productIndex];
        }

        // 取得資料列
        public string[] GetRowData()
        {
            string result1 = _currentUserSelectProduct.Name;
            string result2 = _currentUserSelectProduct.Category.Name;
            string result3 = _currentUserSelectProduct.Price;
            string[] rowData = new string[Constant.FOUR];
            rowData[0] = String.Empty;
            rowData[1] = result1;
            rowData[Constant.TWO] = result2;
            rowData[Constant.THREE] = result3;
            return rowData;
        }

        // 訂購商品
        public void AddProduct()
        {
            _order.AddSelectProductToList(_currentUserSelectProduct);
        }

        public Product CurrentUserSelectProduct
        {
            get
            {
                return _currentUserSelectProduct;
            }
            set
            {
                _currentUserSelectProduct = value;
            }
        }

        public Order Order
        {
            get
            {
                return _order;
            }
            set
            {
                _order = value;
            }
        }

        public List<Product> ProductList
        {
            get
            {
                return _productList;
            }
            set
            {
                _productList = value;
            }
        }

        public List<Category> ProductCategory
        {
            get
            {
                return _productCategory;
            }
            set
            {
                _productCategory = value;
            }
        }

        // 取得該產品的數量
        public int GetProductCategoryCount(string categoryName)
        {
            for (int i = 0; i < _productCategory.Count; i++)
                if (_productCategory[i].Name.Equals(categoryName))
                    return _productCategory[i].Count;
            return 0;
        }
    }
}
