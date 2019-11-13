using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Tests
{
    [TestClass()]
    public class CreditCardPaymentPresentationModelTests
    {
        Model model;
        CreditCardPaymentPresentationModel creditCardPaymentPresentationModel;
        // test Initialize
        [TestInitialize]
        public void TestInitialize()
        {
            model = new Model();
            creditCardPaymentPresentationModel = new CreditCardPaymentPresentationModel(model);
        }

        // test CreditCardPaymentPresentationModel
        [TestMethod()]
        public void TestCreditCardPaymentPresentationModel()
        {
            Assert.AreEqual(creditCardPaymentPresentationModel.Model, model);
        }

        // test GetYears
        [TestMethod()]
        public void TestGetYears()
        {
            List<string> testYearsString = creditCardPaymentPresentationModel.GetYears();
            for (int i = 0; i < testYearsString.Count; i++)
            {
                Assert.AreEqual(testYearsString[i], (i + Constant.START_YEAR).ToString());
            }
        }

        // test GetMonths
        [TestMethod()]
        public void TestGetMonths()
        {
            List<string> testMonthsString = creditCardPaymentPresentationModel.GetMonths();
            for (int i = 0; i < 12; i++)
            {
                Assert.AreEqual(testMonthsString[i], (i + 1).ToString());
            }
        }


        // test CheckAndSetUserName
        [TestMethod()]
        public void TestCheckAndSetUserName()
        {
            creditCardPaymentPresentationModel.CheckAndSetUserName("卓", "旭嘉");
            Assert.AreEqual(creditCardPaymentPresentationModel.IsUserNameCorrect, true);
            creditCardPaymentPresentationModel.CheckAndSetUserName("", "");
            Assert.AreEqual(creditCardPaymentPresentationModel.IsUserNameCorrect, false);
            creditCardPaymentPresentationModel.CheckAndSetUserName("", "旭嘉");
            Assert.AreEqual(creditCardPaymentPresentationModel.IsUserNameCorrect, false);
            creditCardPaymentPresentationModel.CheckAndSetUserName("卓", "");
            Assert.AreEqual(creditCardPaymentPresentationModel.IsUserNameCorrect, false);
        }

        // test CheckAndSetCreditCardNumber
        [TestMethod()]
        public void TestCheckAndSetCreditCardNumber()
        {
            List<string> creditCardNumber = new List<string>();
            creditCardNumber.Add("1234");
            creditCardNumber.Add("1234");
            creditCardNumber.Add("1234");
            creditCardNumber.Add("1234");
            creditCardPaymentPresentationModel.CheckAndSetCreditCardNumber(creditCardNumber);
            Assert.AreEqual(creditCardPaymentPresentationModel.IsCreditCardNumberCorrect, true);
            creditCardNumber.Clear();
            creditCardNumber.Add("");
            creditCardNumber.Add("1234");
            creditCardNumber.Add("1234");
            creditCardNumber.Add("1234");
            creditCardPaymentPresentationModel.CheckAndSetCreditCardNumber(creditCardNumber);
            Assert.AreEqual(creditCardPaymentPresentationModel.IsCreditCardNumberCorrect, false);
            creditCardNumber.Clear();
            creditCardNumber.Add("1234");
            creditCardNumber.Add("");
            creditCardNumber.Add("1234");
            creditCardNumber.Add("1234");
            creditCardPaymentPresentationModel.CheckAndSetCreditCardNumber(creditCardNumber);
            Assert.AreEqual(creditCardPaymentPresentationModel.IsCreditCardNumberCorrect, false);
            creditCardNumber.Clear();
            creditCardNumber.Add("1234");
            creditCardNumber.Add("1234");
            creditCardNumber.Add("");
            creditCardNumber.Add("1234");
            creditCardPaymentPresentationModel.CheckAndSetCreditCardNumber(creditCardNumber);
            Assert.AreEqual(creditCardPaymentPresentationModel.IsCreditCardNumberCorrect, false);
            creditCardNumber.Clear();
            creditCardNumber.Add("1234");
            creditCardNumber.Add("1234");
            creditCardNumber.Add("1234");
            creditCardNumber.Add("");
            creditCardPaymentPresentationModel.CheckAndSetCreditCardNumber(creditCardNumber);
            Assert.AreEqual(creditCardPaymentPresentationModel.IsCreditCardNumberCorrect, false);
        }

        // test CheckAndSetSecurityCode
        [TestMethod()]
        public void TestCheckAndSetSecurityCode()
        {
            creditCardPaymentPresentationModel.CheckAndSetSecurityCode("443");
            Assert.AreEqual(creditCardPaymentPresentationModel.IsSecurityCodeCorrect, true);
            creditCardPaymentPresentationModel.CheckAndSetSecurityCode("43");
            Assert.AreEqual(creditCardPaymentPresentationModel.IsSecurityCodeCorrect, false);
        }

        // test CheckAndSetMail
        [TestMethod()]
        public void TestCheckAndSetMail()
        {
            creditCardPaymentPresentationModel.CheckAndSetMail("a5852241@gmail.com");
            Assert.AreEqual(creditCardPaymentPresentationModel.IsMailFormatCorrect, true);
            creditCardPaymentPresentationModel.CheckAndSetMail("a5852241gmail.com");
            Assert.AreEqual(creditCardPaymentPresentationModel.IsMailFormatCorrect, false);
        }

        // test CheckAndSetAddress
        [TestMethod()]
        public void TestCheckAndSetAddress()
        {
            creditCardPaymentPresentationModel.CheckAndSetAddress("owo");
            Assert.AreEqual(creditCardPaymentPresentationModel.IsAddressCorrect, true);
            creditCardPaymentPresentationModel.CheckAndSetAddress("");
            Assert.AreEqual(creditCardPaymentPresentationModel.IsAddressCorrect, false);
        }

        // test CheckAll
        [TestMethod()]
        public void TestCheckAll()
        {
            creditCardPaymentPresentationModel.CheckAll();
            Assert.AreEqual(creditCardPaymentPresentationModel.IsAllCorrect, false);
            Assert.AreEqual(creditCardPaymentPresentationModel.IsConfirmButtonEnable, false);
            List<string> testYearsString = creditCardPaymentPresentationModel.GetYears();
            for (int i = 0; i < testYearsString.Count; i++)
            {
                Assert.AreEqual(testYearsString[i], (i + Constant.START_YEAR).ToString());
            }
            List<string> testMonthsString = creditCardPaymentPresentationModel.GetMonths();
            for (int i = 0; i < 12; i++)
            {
                Assert.AreEqual(testMonthsString[i], (i + 1).ToString());
            }
            creditCardPaymentPresentationModel.CheckAndSetUserName("卓", "旭嘉");
            List<string> creditCardNumber = new List<string>();
            creditCardNumber.Add("1234");
            creditCardNumber.Add("1234");
            creditCardNumber.Add("1234");
            creditCardNumber.Add("1234");
            creditCardPaymentPresentationModel.CheckAndSetCreditCardNumber(creditCardNumber);
            creditCardPaymentPresentationModel.CheckAndSetSecurityCode("443");
            creditCardPaymentPresentationModel.CheckAndSetMail("a5852241@gmail.com");
            creditCardPaymentPresentationModel.CheckAndSetAddress("owo");
            creditCardPaymentPresentationModel.CheckAll();
            Assert.AreEqual(creditCardPaymentPresentationModel.IsAllCorrect, true);
            Assert.AreEqual(creditCardPaymentPresentationModel.IsConfirmButtonEnable, true);
        }
    }
}