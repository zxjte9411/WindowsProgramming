using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class CreditCardPaymentForm : Form
    {
        private ErrorProvider _errorProvider;
        private CreditCardPaymentPresentationModel _creditCardPaymentPresentationModel;
        private List<TextBox> _creditCardNumberTextBoxes;
        public CreditCardPaymentForm(CreditCardPaymentPresentationModel creditCardPaymentPresentationModel)
        {
            InitializeComponent();
            _creditCardPaymentPresentationModel = creditCardPaymentPresentationModel;
            InitializeComboBox();
            if (_creditCardPaymentPresentationModel.IsHaveCreditCard())
                RefreshCreditCardInformation();
            else
                _creditCardPaymentPresentationModel.Order.CreditCardPayment = new CreditCardPayment();
            _errorProvider = new ErrorProvider();
            _confirmButton.Click += HandleConfirmButton;
            _creditCardNumberTextBox0.TextChanged += HandleTextBox0Change;
            _creditCardNumberTextBox1.TextChanged += HandleTextBox1Change;
            _creditCardNumberTextBox2.TextChanged += HandleTextBox2Change;
            _creditCardNumberTextBox0.TextChanged += HandleAllTextBoxChange;
            _creditCardNumberTextBox1.TextChanged += HandleAllTextBoxChange;
            _creditCardNumberTextBox2.TextChanged += HandleAllTextBoxChange;
            _creditCardNumberTextBox3.TextChanged += HandleAllTextBoxChange;
            _lastNameTextBox.TextChanged += HandleAllTextBoxChange;
            _firstNameTextBox.TextChanged += HandleAllTextBoxChange;
            _securityCodeTextBox.TextChanged += HandleAllTextBoxChange;
            _mailTextBox.TextChanged += HandleAllTextBoxChange;
            _addressTextBox.TextChanged += HandleAllTextBoxChange;
            _creditCardNumberTextBoxes = new List<TextBox>();
            for (int i = 0; i < Constant.FOUR; i++)
                _creditCardNumberTextBoxes.Add(_creditCardNumberTableLayoutPanel.Controls.Find(Constant.CREDIT_CARD_TEXT_BOX_NAME + i.ToString(), true).FirstOrDefault() as TextBox);
        }

        // 初始化 ComBox
        private void InitializeComboBox()
        {
            _effectiveDateYearComboBox.Items.AddRange(_creditCardPaymentPresentationModel.GetYears().Cast<string>().ToArray());
            _effectiveDateYearComboBox.SelectedIndex = 0;
            _effectiveDateMonthComboBox.Items.AddRange(_creditCardPaymentPresentationModel.GetMonths().Cast<string>().ToArray());
            _effectiveDateMonthComboBox.SelectedIndex = 0;
        }

        // 處理確認按鈕
        private void HandleConfirmButton(Object sender, EventArgs e)
        {
            _errorProvider.Clear();
            _creditCardPaymentPresentationModel.Order.CreditCardPayment.EffectiveDateYear = _effectiveDateYearComboBox.Text;
            _creditCardPaymentPresentationModel.Order.CreditCardPayment.EffectiveDateMonth = _effectiveDateMonthComboBox.Text;
            CheckUserName();
            CheckCreditCardNumber();
            CheckSecurityCode();
            CheckMail();
            CheckAddress();
            CheckAll();
            if (_creditCardPaymentPresentationModel.IsAllCorrect)
            {
                MessageBox.Show("訂購完成!");
                Close();
                ClearOrder();
            }
        }

        //  處理 creditCardNumberTextBox1 的變更事件
        private void HandleTextBox0Change(Object sender, EventArgs e)
        {
            if (_creditCardNumberTextBox0.TextLength == _creditCardNumberTextBox0.MaxLength)
                _creditCardNumberTextBox1.Focus();
        }

        // 處理 creditCardNumberTextBox2 的變更事件
        private void HandleTextBox1Change(Object sender, EventArgs e)
        {
            if (_creditCardNumberTextBox1.TextLength == _creditCardNumberTextBox1.MaxLength)
                _creditCardNumberTextBox2.Focus();
        }

        // 處理 creditCardNumberTextBox3 的變更事件
        private void HandleTextBox2Change(Object sender, EventArgs e)
        {
            if (_creditCardNumberTextBox2.TextLength == _creditCardNumberTextBox2.MaxLength)
                _creditCardNumberTextBox3.Focus();
        }

        // 處理所有 TextBoxChange 
        private void HandleAllTextBoxChange(Object sender, EventArgs e)
        {
            CheckUserName();
            CheckCreditCardNumber();
            CheckSecurityCode();
            CheckMail();
            CheckAddress();
            CheckAll();
            _confirmButton.Enabled = _creditCardPaymentPresentationModel.IsConfirmButtonEnable;
        }

        // 填入資訊
        private void RefreshCreditCardInformation()
        {
            _lastNameTextBox.Text = _creditCardPaymentPresentationModel.Order.CreditCardPayment.LastName;
            _firstNameTextBox.Text = _creditCardPaymentPresentationModel.Order.CreditCardPayment.FirstName;
            try
            {
                for (int i = 0; i < Constant.FOUR; i++)
                    (_creditCardNumberTableLayoutPanel.Controls.Find(Constant.CREDIT_CARD_TEXT_BOX_NAME + i.ToString(), true).FirstOrDefault() as TextBox).Text = _creditCardPaymentPresentationModel.Order.CreditCardPayment.CreditCardNumber[i];
            }
            catch(Exception)
            {
                _creditCardPaymentPresentationModel.Order.CreditCardPayment = new CreditCardPayment();
            }
            
            _effectiveDateYearComboBox.Text = _creditCardPaymentPresentationModel.Order.CreditCardPayment.EffectiveDateYear;
            _effectiveDateMonthComboBox.Text = _creditCardPaymentPresentationModel.Order.CreditCardPayment.EffectiveDateMonth;
            _mailTextBox.Text = _creditCardPaymentPresentationModel.Order.CreditCardPayment.Mail;
            _addressTextBox.Text = _creditCardPaymentPresentationModel.Order.CreditCardPayment.Address;
        }

        // 檢查持卡人姓名
        private void CheckUserName()
        {
            string lastName = _lastNameTextBox.Text;
            string firstName = _firstNameTextBox.Text;
            _creditCardPaymentPresentationModel.CheckAndSetUserName(lastName, firstName);
        }

        // 檢查信用卡卡號
        private void CheckCreditCardNumber()
        {
            List<string> creditCardNumbers = new List<string>();
            foreach (var textBoxe in _creditCardNumberTextBoxes)
                creditCardNumbers.Add(textBoxe.Text);
            _creditCardPaymentPresentationModel.CheckAndSetCreditCardNumber(creditCardNumbers);
        }

        // 檢查信用卡安全碼
        private void CheckSecurityCode()
        {
            string securityCode = _securityCodeTextBox.Text;
            _creditCardPaymentPresentationModel.CheckAndSetSecurityCode(securityCode);
        }

        // 檢查郵件格式
        private void CheckMail()
        {
            string mail = _mailTextBox.Text;
            _creditCardPaymentPresentationModel.CheckAndSetMail(mail);
        }

        // 檢查地址
        private void CheckAddress()
        {
            string address = _addressTextBox.Text;
            _creditCardPaymentPresentationModel.CheckAndSetAddress(address);
        }

        // 檢查全部
        private void CheckAll()
        {
            _errorProvider.Clear();
            _creditCardPaymentPresentationModel.CheckAll();
            _confirmButton.Enabled = _creditCardPaymentPresentationModel.IsConfirmButtonEnable;
            if (!_creditCardPaymentPresentationModel.IsUserNameCorrect)
                _errorProvider.SetError(_firstNameTextBox, Constant.ERROR);
            if (!_creditCardPaymentPresentationModel.IsCreditCardNumberCorrect)
                _errorProvider.SetError(_creditCardNumberTextBox3, Constant.ERROR);
            if (!_creditCardPaymentPresentationModel.IsSecurityCodeCorrect)
                _errorProvider.SetError(_securityCodeTextBox, Constant.ERROR);
            if (!_creditCardPaymentPresentationModel.IsMailFormatCorrect)
                _errorProvider.SetError(_mailTextBox, Constant.ERROR);
            if (!_creditCardPaymentPresentationModel.IsAddressCorrect)
                _errorProvider.SetError(_addressTextBox, Constant.ERROR);
        }

        // 清空"我的訂單"
        private void ClearOrder()
        {
            _creditCardPaymentPresentationModel.Order.UserSelectProduct.Clear();
        }
    }
}
