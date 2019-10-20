using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Homework
{
    public class CreditCardPaymentPresentationModel
    {
        Model _orderFormModel;
        private bool _isUserNameCorrect;
        private bool _isCreditCardNumberCorrect;
        private bool _isSecurityCodeCorrect;
        private bool _isMailFormatCorrect;
        private bool _isAddressCorrect;
        private bool _isAllCorrect;
        private bool _isConfirmButtonEnable;
        public CreditCardPaymentPresentationModel(Model orderFormModel)
        {
            _orderFormModel = orderFormModel;
            _isUserNameCorrect = false;
            _isCreditCardNumberCorrect = false;
            _isSecurityCodeCorrect = false;
            _isMailFormatCorrect = false;
            _isAddressCorrect = false;
            _isAllCorrect = false;
            _isConfirmButtonEnable = false;
        }

        // 設定
        public void SetCreditCard(CreditCardPayment creditCard)
        {
            _orderFormModel.Order.CreditCardPayment = creditCard;
        }

        // 取得 2021 ~ 2028 年
        public List<string> GetYears()
        {
            List<string> years = new List<string>();
            for (int i = Constant.START_YEAR; i < Constant.END_YEAR + 1; i++)
                years.Add(i.ToString());
            return years;
        }

        // 取得 1 ~ 12 月
        public List<string> GetMonths()
        {
            List<string> month = new List<string>();
            for (int i = 1; i < Constant.MONTH + 1; i++)
                month.Add(i.ToString());
            return month;
        }

        // 檢查是否有 CreditCard 資訊
        public bool IsHaveCreditCard()
        {
            if (_orderFormModel.Order.CreditCardPayment != null)
                return true;
            return false;
        }

        public Order Order
        {
            get
            {
                return _orderFormModel.Order;
            }
        }

        public bool IsUserNameCorrect
        {
            get
            {
                return _isUserNameCorrect;
            } 
            set
            {
                _isUserNameCorrect = value;
            }
        }

        public bool IsCreditCardNumberCorrect 
        { 
            get 
            {  
                return _isCreditCardNumberCorrect;
            } 
            set 
            { 
                _isCreditCardNumberCorrect = value; 
            }
        }

        public bool IsSecurityCodeCorrect 
        { 
            get 
            {  
                return _isSecurityCodeCorrect;
            } 
            set 
            { 
                _isSecurityCodeCorrect = value; 
            }
        }

        public bool IsMailFormatCorrect 
        { 
            get 
            {  
                return _isMailFormatCorrect;
            } 
            set 
            { 
                _isMailFormatCorrect = value; 
            }
        }

        public bool IsAddressCorrect 
        { 
            get 
            {  
                return _isAddressCorrect;
            } 
            set 
            { 
                _isAddressCorrect = value; 
            }
        }

        public bool IsConfirmButtonEnable
        {
            get
            {
                return _isConfirmButtonEnable;
            }
        }

        public bool IsAllCorrect
        {
            get
            {
                return _isAllCorrect;
            }
        }

        // 檢查持卡人姓名，正確就存起來
        public void CheckAndSetUserName(string lastName, string firstName)
        {
            if (lastName.Length < 1 || firstName.Length < 1)
                _isUserNameCorrect = false;
            else
            {
                _isUserNameCorrect = true;
                _orderFormModel.Order.CreditCardPayment.LastName = lastName;
                _orderFormModel.Order.CreditCardPayment.FirstName = firstName;
            }
        }

        // 檢查信用卡卡號，正確就存起來
        public void CheckAndSetCreditCardNumber(List<string> creditCardNumbers)
        {
            foreach (var number in creditCardNumbers)
            {
                if (number.Length <= Constant.THREE)
                {
                    _isCreditCardNumberCorrect = false;
                    return;
                }                    
            }
            _isCreditCardNumberCorrect = true;
            _orderFormModel.Order.CreditCardPayment.CreditCardNumber = creditCardNumbers.ToArray();
        }

        // 檢查信用卡安全碼，正確就存起來
        public void CheckAndSetSecurityCode(string securityCode)
        {
            if (securityCode.Length > Constant.TWO)
            {
                _isSecurityCodeCorrect = true;
                _orderFormModel.Order.CreditCardPayment.SecurityCode = securityCode;
            }                
            else
                _isSecurityCodeCorrect = false;
        }

        // 檢查郵件格式，正確就存起來
        public void CheckAndSetMail(string mail)
        {
            Regex regexMail = new Regex(Constant.REGEX);
            if (!regexMail.IsMatch(mail))
                _isMailFormatCorrect = false;
            else
            {
                _isMailFormatCorrect = true;
                _orderFormModel.Order.CreditCardPayment.Mail = mail;
            }
        }

        // 檢查地址，正確就存起來
        public void CheckAndSetAddress(string address)
        {
            if (address.Length < 1)
                _isAddressCorrect = false;
            else
            {
                _isAddressCorrect = true;
                _orderFormModel.Order.CreditCardPayment.Address = address;
            }
        }

        // 檢查全部
        public void CheckAll()
        {
            _isAllCorrect = true;
            _isConfirmButtonEnable = true;
            if (!_isUserNameCorrect)
                _isAllCorrect = false;
            if (!_isCreditCardNumberCorrect)
                _isAllCorrect = false;
            if (!_isSecurityCodeCorrect)
                _isAllCorrect = false;
            if (!_isMailFormatCorrect)
                _isAllCorrect = false;
            if (!_isAddressCorrect)
                _isAllCorrect = false;
            if (!_isAllCorrect)
                _isConfirmButtonEnable = false;
        }
    }
}
