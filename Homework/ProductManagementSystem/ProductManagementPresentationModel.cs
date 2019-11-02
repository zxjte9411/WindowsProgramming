using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Homework
{
    public class ProductManagementPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event CleanAllDataEventHandler _clearAllDataEvent;
        public delegate void CleanAllDataEventHandler(); 
        private Model _model;
        private Constant.Mode _mode;
        private bool _isButtonSaveAddEnable;
        private bool _isButtonAddEnable;
        private string _buttonSaveAddText;
        private string _groupBoxProductText;
        private const string IS_BUTTON_SAVE_ADD_ENABLE = "IsButtonSaveAddEnable";
        private const string IS_BUTTON_ADD_ENABLE = "IsButtonAddEnable";
        private const string BUTTON_SAVE_ADD_TEXT = "ButtonSaveAddText";// 按鈕的文字顯示編輯或新增
        private const string GROUP_BOX_MEAL_TEXT = "GroupBoxProductText";// group box 左上的文字
        public ProductManagementPresentationModel(Model model)
        {
            _model = model;
            Mode = Constant.Mode.InitialMode;
            UpdateModeChangedState();
        }

        public Model Model
        {
            get
            {
                return _model;
            }
        }

        public Constant.Mode Mode
        {
            get
            {
                return _mode;
            }
            set
            {
                _mode = value;
            }
        }

        public bool IsButtonSaveAddEnable
        {
            get
            {
                return _isButtonSaveAddEnable;
            }
        }

        public bool IsButtonAddEnable
        {
            get
            {
                return _isButtonAddEnable;
            }
        }

        public string ButtonSaveAddText
        {
            get
            {
                return _buttonSaveAddText;
            }
        }

        public string GroupBoxProductText
        {
            get
            {
                return _groupBoxProductText;
            }
        }

        // 更新編輯或新增 product 時的狀態
        public void UpdateModeChangedState()
        {
            switch (_mode)
            {
                case Constant.Mode.InitialMode:
                    EditModeText();
                    ChangeButtonEnableState(false, true);
                    break;
                case Constant.Mode.EditMode:
                    EditModeText();
                    ChangeButtonEnableState(false, true);
                    break;
                case Constant.Mode.AddMode:
                    AddModeText();
                    ChangeButtonEnableState(false, false);
                    break;
            }
            NotifyPropertyChanged();
        }

        // 依照模式處理 button 按下事件
        internal void HandleButtonClickEvent(int index, string[] stringText)
        {
            switch (_mode)
            {
                case Constant.Mode.EditMode:
                    SaveEditedProductInformationChange(index, stringText);
                    ChangeButtonEnableState(false, true);
                    break;
                case Constant.Mode.AddMode:
                    AddNewProduct(stringText);
                    ChangeButtonEnableState(false, false);
                    _clearAllDataEvent();
                    break;
            }
            //Mode = Constant.Mode.InitialMode;
            UpdateModeChangedState();
        }

        // 加入新產品
        private void AddNewProduct(string[] stringText)
        {
            _model.AddNewProductToProductList(stringText);
        }

        // 儲存新的產品資訊
        private void SaveEditedProductInformationChange(int index, string[] stringText)
        {
            _model.SaveChangedProductInformation(index, stringText);
        }
        // 初始化狀態
        //public void InitialAllState()
        //{
        //    Mode = Constant.Mode.InitialMode;
        //    UpdateModeChangedState();
        //}
        // 更改按鈕致能狀態

        private void ChangeButtonEnableState(bool saveState, bool addState)
        {
            _isButtonSaveAddEnable = saveState;
            _isButtonAddEnable = addState;
        }

        // 編輯狀態
        private void EditModeText()
        {
            const string BUTTON_SAVE_TEXT = "儲存";
            const string GROUP_BOX_EDIT_PRODUCT_TEXT = "編輯商品";
            _buttonSaveAddText = BUTTON_SAVE_TEXT;
            _groupBoxProductText = GROUP_BOX_EDIT_PRODUCT_TEXT;
        }

        //新增狀態
        private void AddModeText()
        {
            const string BUTTON_ADD_TEXT = "新增";
            const string GROUP_BOX_ADD_MEAL_TEXT = "新增商品";
            _buttonSaveAddText = BUTTON_ADD_TEXT;
            _groupBoxProductText = GROUP_BOX_ADD_MEAL_TEXT;
        }

        // 處理 "新增商品" 模式事件(新增模式)
        public void HandleNewProductAddButtonClickEvent()
        {
            Mode = Constant.Mode.AddMode;
            UpdateModeChangedState();
        }

        // 處理 product list box 選擇事件(編輯模式)
        public void HandleProductListBoxSelected()
        {
            Mode = Constant.Mode.EditMode;
            UpdateModeChangedState();
        }

        // 檢查按鈕是否可使用
        public void CheckButtonIsCanEnable(string[] stringText)
        {
            foreach (var item in stringText)
            {
                _isButtonSaveAddEnable = true;
                if (item.Equals(string.Empty))
                {
                    _isButtonSaveAddEnable = false;
                    break;
                }
            }
            NotifyPropertyChanged();
        }

        // 處理只能輸入純數字的 TextBox 輸入限制
        public bool HandleTextBoxKeyPress(char keyChar, char keysBack)
        {
            return ((new Regex(Constant.REGEX_ONLY_NUMBER).IsMatch(keyChar.ToString())) || (keyChar == keysBack));
        }

        //Notify
        private void NotifyPropertyChanged()
        {
            NotifyPropertyChanged(IS_BUTTON_SAVE_ADD_ENABLE);
            NotifyPropertyChanged(BUTTON_SAVE_ADD_TEXT);
            NotifyPropertyChanged(GROUP_BOX_MEAL_TEXT);
        }

        //PropertyChanged
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
