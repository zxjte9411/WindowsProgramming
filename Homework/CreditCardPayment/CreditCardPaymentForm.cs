using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            _confirmButton.Enabled = _creditCardPaymentPresentationModel.IsConfirmButtonEnable;
            InitializeComboBox();
            RefreshCreditCardInformation();
            _errorProvider = new ErrorProvider();
            _confirmButton.Click += HandleConfirmButton;
            _lastNameTextBox.TextChanged += HandleUserNameTextBoxChange;
            _firstNameTextBox.TextChanged += HandleUserNameTextBoxChange;
            _creditCardNumberTextBox0.TextChanged += HandleTextBox0Change;
            _creditCardNumberTextBox1.TextChanged += HandleTextBox1Change;
            _creditCardNumberTextBox2.TextChanged += HandleTextBox2Change;
            _creditCardNumberTextBoxes = new List<TextBox>();
            for (int i = 0; i < Constant.FOUR; i++)
            {
                _creditCardNumberTextBoxes.Add(_creditCardNumberTableLayoutPanel.Controls.Find(Constant.CREDIT_CARD_TEXT_BOX_NAME + i.ToString(), true).FirstOrDefault() as TextBox);
                _creditCardNumberTextBoxes[i].KeyPress += HandleCreditCardNumberAndSecurityCodeTextBoxKeyPress;
                _creditCardNumberTextBoxes[i].TextChanged += HandleCreditCardNumberTextBoxChange;
            }
            _securityCodeTextBox.TextChanged += HandleSecurityCodeTextBoxChange;
            _mailTextBox.TextChanged += HandleMailFormatTextBoxChange;
            _addressTextBox.TextChanged += HandleAddressTextBoxChange;
            _lastNameTextBox.KeyPress += HandleNameTextBoxKeyPress;
            _firstNameTextBox.KeyPress += HandleNameTextBoxKeyPress;
            _securityCodeTextBox.KeyPress += HandleCreditCardNumberAndSecurityCodeTextBoxKeyPress;
            _mailTextBox.KeyPress += HandleMailTextBoxKeyPress;
        }

        //  處理 NameTextBox 輸入限制
        private void HandleNameTextBoxKeyPress(Object sender, KeyPressEventArgs e)
        {
            e.Handled = !((new Regex(Constant.REGEX_TRADITIONAL_CHINESE).IsMatch(e.KeyChar.ToString())) || (e.KeyChar == (char)Keys.Back));
        }

        // 處理只能輸入純數字的 TextBox 輸入限制
        private void HandleCreditCardNumberAndSecurityCodeTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((new Regex(Constant.REGEX_ONLY_NUMBER).IsMatch(e.KeyChar.ToString())) || (e.KeyChar == (char)Keys.Back));
        }

        // 處理 _mailTextBox 輸入限制
        private void HandleMailTextBoxKeyPress(Object sender, KeyPressEventArgs e)
        {
            e.Handled = !((new Regex(Constant.REGEX_SYMBOLS).IsMatch(e.KeyChar.ToString())) || (e.KeyChar == (char)Keys.Back));
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
            _creditCardPaymentPresentationModel.Model.Order.CreditCardPayment.EffectiveDateYear = _effectiveDateYearComboBox.Text;
            _creditCardPaymentPresentationModel.Model.Order.CreditCardPayment.EffectiveDateMonth = _effectiveDateMonthComboBox.Text;
            CheckAll();
            if (_creditCardPaymentPresentationModel.IsAllCorrect)
            {
                MessageBox.Show(Constant.ORDER_IS_COMPLETE);
                DialogResult = DialogResult.OK;
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

        // 處理名字輸入
        private void HandleUserNameTextBoxChange(Object sender, EventArgs e)
        {
            CheckAll();
            _confirmButton.Enabled = _creditCardPaymentPresentationModel.IsConfirmButtonEnable;
            if (!_creditCardPaymentPresentationModel.IsUserNameCorrect)
                _errorProvider.SetError(_firstNameTextBox, Constant.ERROR);
        }

        // 處理卡號輸入
        private void HandleCreditCardNumberTextBoxChange(Object sender, EventArgs e)
        {
            _errorProvider.Clear();
            CheckCreditCardNumber();
            _confirmButton.Enabled = _creditCardPaymentPresentationModel.IsConfirmButtonEnable;
            if (!_creditCardPaymentPresentationModel.IsCreditCardNumberCorrect)
                _errorProvider.SetError(_creditCardNumberTextBox3, Constant.ERROR);
        }

        // 處理安全碼輸入
        private void HandleSecurityCodeTextBoxChange(Object sender, EventArgs e)
        {
            CheckAll();
            _confirmButton.Enabled = _creditCardPaymentPresentationModel.IsConfirmButtonEnable;
            if (!_creditCardPaymentPresentationModel.IsSecurityCodeCorrect)
                _errorProvider.SetError(_securityCodeTextBox, Constant.ERROR);
        }

        // 處理 mail 輸入
        private void HandleMailFormatTextBoxChange(Object sender, EventArgs e)
        {
            //_errorProvider.Clear();
            //CheckMail();
            CheckAll();
            _confirmButton.Enabled = _creditCardPaymentPresentationModel.IsConfirmButtonEnable;
            if (!_creditCardPaymentPresentationModel.IsMailFormatCorrect)
                _errorProvider.SetError(_mailTextBox, Constant.ERROR);
        }

        // 處理地址輸入
        private void HandleAddressTextBoxChange(Object sender, EventArgs e)
        {
            //_errorProvider.Clear();
            //CheckMail();
            CheckAll();
            _confirmButton.Enabled = _creditCardPaymentPresentationModel.IsConfirmButtonEnable;
            if (!_creditCardPaymentPresentationModel.IsAddressCorrect)
                _errorProvider.SetError(_addressTextBox, Constant.ERROR);
        }

        // 填入資訊
        private void RefreshCreditCardInformation()
        {
            _lastNameTextBox.Text = _creditCardPaymentPresentationModel.Model.Order.CreditCardPayment.LastName;
            _firstNameTextBox.Text = _creditCardPaymentPresentationModel.Model.Order.CreditCardPayment.FirstName;
            try
            {
                for (int i = 0; i < Constant.FOUR; i++)
                    (_creditCardNumberTableLayoutPanel.Controls.Find(Constant.CREDIT_CARD_TEXT_BOX_NAME + i.ToString(), true).FirstOrDefault() as TextBox).Text = _creditCardPaymentPresentationModel.Model.Order.CreditCardPayment.CreditCardNumber[i];
            }
            catch(Exception)
            {
                _creditCardPaymentPresentationModel.Model.Order.CreditCardPayment = new CreditCardPayment();
            }
            _effectiveDateYearComboBox.Text = _creditCardPaymentPresentationModel.Model.Order.CreditCardPayment.EffectiveDateYear;
            _effectiveDateMonthComboBox.Text = _creditCardPaymentPresentationModel.Model.Order.CreditCardPayment.EffectiveDateMonth;
            _mailTextBox.Text = _creditCardPaymentPresentationModel.Model.Order.CreditCardPayment.Mail;
            _addressTextBox.Text = _creditCardPaymentPresentationModel.Model.Order.CreditCardPayment.Address;
        }

        // 檢查持卡人姓名
        private void CheckUserName()
        {
            _creditCardPaymentPresentationModel.CheckAndSetUserName(_lastNameTextBox.Text, _firstNameTextBox.Text);
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
            _creditCardPaymentPresentationModel.CheckAndSetMail(_mailTextBox.Text);
        }

        // 檢查地址
        private void CheckAddress()
        {
            _creditCardPaymentPresentationModel.CheckAndSetAddress(_addressTextBox.Text);
        }

        // 檢查全部
        private void CheckAll()
        {
            _errorProvider.Clear();
            CheckUserName();
            CheckCreditCardNumber();
            CheckSecurityCode();
            CheckMail();
            CheckAddress();
            _creditCardPaymentPresentationModel.CheckAll();
            _confirmButton.Enabled = _creditCardPaymentPresentationModel.IsConfirmButtonEnable;
        }

        // 清空"我的訂單"
        private void ClearOrder()
        {
            _creditCardPaymentPresentationModel.Model.ClearUserSelectProduct();
        }
    }
}
