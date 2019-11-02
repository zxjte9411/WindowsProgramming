using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Model
    {
        public event BackEndChangeEventHandler _backEndChangeEvent;
        public delegate void BackEndChangeEventHandler();
        public event StockQuantityChangeEventHandler _stockQuantityProductChangeEvent;
        public delegate void StockQuantityChangeEventHandler();
        public event OverStockLimitEventHandler _overStockLimitEvent;
        public delegate void OverStockLimitEventHandler();
        private Order _order;
        private List<Product> _productList;//存著庫存的商品
        private List<Category> _productCategory;
        private Product _currentUserSelectProduct;
        public Model()
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
                _productList.Add(new Product(productInformation[0], AddProductCategoryAndQuantity(productInformation[1]), productInformation[Constant.TWO], productInformation[Constant.THREE], productInformation[Constant.FOUR], productInformation[Constant.FIVE]));
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
        public Category AddProductCategoryAndQuantity(string categoryName)
        {
            // 先檢查數量清單中是否已經有加入，有的話數量增加一，沒有就建立新的產品類別

            for (int i = 0; i < _productCategory.Count; i++)
            {
                if (_productCategory[i].Name == categoryName)
                {
                    _productCategory[i].Count++;
                    return _productCategory[i];
                }
            }
            _productCategory.Add(new Category(categoryName, 0));
            return _productCategory.Last();
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

        // 取得當前所選的產品
        public Product GetProduct(string categoryName, int productIndex)
        {
            return _currentUserSelectProduct = GetProductsOfThisCategory(categoryName)[productIndex];
        }

        // 取得資料列
        public string[] GetRowData()
        {
            string[] rowData = new string[Constant.FIVE + 1];
            rowData[0] = String.Empty;
            rowData[1] = _currentUserSelectProduct.Name;
            rowData[Constant.TWO] = _currentUserSelectProduct.Category.Name;
            rowData[Constant.THREE] = int.Parse(_currentUserSelectProduct.Price).ToString(Constant.NO);
            rowData[Constant.FOUR] = (1).ToString(); // Quantity
            rowData[Constant.FIVE] = int.Parse(_currentUserSelectProduct.Price).ToString(Constant.NO);
            return rowData;
        }

        // 加入當前所選商品
        public void AddProduct()
        {
            _order.AddSelectProductToList(_currentUserSelectProduct);
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

        //修改Order的數量及subtotal
        public void UpdateOrderQuantitySubtotal(int index, int value)
        {
            _order.UserSelectedProductsQuantity[index] = value;
        }

        // 找產品
        public Product FindTheProduct(string name)
        {
            foreach (var stockProduct in ProductList)
                if (name.Equals(stockProduct.Name))
                    return stockProduct;
            return null;
        }

        // 檢查庫存上限
        public void CheckStockQuantityLimit(int rowIndex, ref int quantity)
        {
            Product product = FindTheProduct(_order.UserSelectProduct[rowIndex].Name);
            if (product != null)
            {
                if (quantity > int.Parse(product.Quantity))
                {
                    if (_overStockLimitEvent != null)
                        _overStockLimitEvent();
                    quantity = int.Parse(product.Quantity);
                }
                _order.UserSelectedProductsQuantity[rowIndex] = quantity;
            }
        }

        // 清除我的訂單並更新庫存量(減少庫存量)
        public void ClearUserSelectProduct()
        {
            _order.CalculateRemainingStockQuantity();
            _order.UserSelectProduct.Clear();
            _order.UserSelectedProductsQuantity.Clear();
            _stockQuantityProductChangeEvent();
        }

        // 增加產品庫存
        public void IncreaseStockProductQuantity(int index, string value)
        {
            _productList[index].Quantity = (int.Parse(_productList[index].Quantity) + int.Parse(value)).ToString();
            _stockQuantityProductChangeEvent();
        }

        // 看看庫存量夠不夠
        public bool IsStockProductQuantityEnough(string name)
        {
            return int.Parse(FindTheProduct(name).Quantity) > 0;
        }

        // 新增新商品到 Product List
        public void AddNewProductToProductList(string[] stringText)
        {
            Category category = null;
            foreach (var item in _productCategory)
            {
                if (stringText[Constant.TWO].Equals(item.Name))
                {
                    category = item;
                    category.Count += 1;
                    break;
                }
            }
            Product product = new Product(stringText[0], category, stringText[1], stringText[Constant.FOUR], stringText[Constant.THREE], 1.ToString());
            _productList.Add(product);
            Console.WriteLine(category.Name);
            _backEndChangeEvent();
        }

        // 存儲新的產品資訊
        public void SaveChangedProductInformation(int index, string[] stringText)
        {
            Category category = null;
            foreach (var item in _productCategory)
            {
                if (stringText[Constant.TWO].Equals(item.Name))
                {
                    category = item;
                    break;
                }
            }
            _productList[index].Name = stringText[0];
            _productList[index].Price = stringText[1];
            _productList[index].Category = _productList[index].Category.CompareCount(category);
            _productList[index].ImagePath = stringText[Constant.THREE];
            _productList[index].Description = stringText[Constant.FOUR];
            UpdateUserSelectProductList();
            _backEndChangeEvent();
        }

        // 更新我的訂單中的資訊
        private void UpdateUserSelectProductList()
        {
            foreach (var item in _order.UserSelectProduct)
            {
                Product product = FindTheProduct(item.Name);
                item.Name = product.Name;
                item.Price = product.Price;
                item.Category = product.Category;
                item.ImagePath = product.ImagePath;
                item.Description = product.Description;
            }
        }
    }
}