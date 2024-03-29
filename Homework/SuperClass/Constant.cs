﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Constant
    {
        public enum Mode
        {
            InitialMode,
            EditMode,
            AddMode
        };
        public const string PRODUCT_INFORMATION_FILE_NAME = "/Resource/ProductInformation.txt";
        public const string PRODUCT_CATEGORY_FILE_NAME = "/Resource/ProductCategory.txt";
        public const string BUTTON_ADD_ICON_IMAGE_PATH = "../../Resource/button_add_icon.png";
        public const string DELETE_BUTTON_ICON_IMAGE_PATH = "../../Resource/delete.png";
        public const string DELIVERY_TRUCK_ICON_IMAGE_PATH = "../../Resource/delivery_truck.bmp";
        public const string RESOURCE_PATH = "../../Resource/";
        public const int BUTTON_COUNT = 6;
        public const int TWO = 2;
        public const int THREE = 3;
        public const int FOUR = 4;
        public const int FIVE = 5;
        public const string PROUD_NAME = "商品名稱";
        public const string PROUD_CATEGORY = "商品類別";
        public const string PRICE = "單價：";
        public const string TOTAL = "總金額：";
        public const char CHAR_SPACE = ',';
        public const string PAGE = "Page ：";
        public const string SLASH = "/";
        public const string DOLLAR = "元";
        public const string CREDIT_CARD_TEXT_BOX_NAME = "_creditCardNumberTextBox";
        public const string REGEX = @"^[a-zA-Z]*[\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
        public const string ERROR = "error!";
        public const int MONTH = 12;
        public const int START_YEAR = 2021;
        public const int END_YEAR = 2028;
        public const string REGEX_TRADITIONAL_CHINESE = "^[\u4E00-\u9FFF]+$";
        public const string REGEX_ONLY_NUMBER = "^[0-9]+$";
        public const string REGEX_SYMBOLS = @"[^\\\+()\^/!#*%&',;=?$\x22]+";
        public const string ORDER_IS_COMPLETE = "訂購完成";
        public const string NO = "N0"; // 千分位轉換參數
        public const string STOCK_QUANTITY = "庫存數量：";
        public const string PRODUCT_MANAGER = "商品管理";
        public const string CATEGORY_MANAGER = "類別管理";
        public const string IMAGE_NOT_EXIST = "請選擇正確的圖片";
        public const string ENABLED = "Enabled";
        public const string TEXT = "Text";
    }
}
