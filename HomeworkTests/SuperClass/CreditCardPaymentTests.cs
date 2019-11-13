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
    public class CreditCardPaymentTests
    {
        // test CreditCardPayment
        [TestMethod()]
        public void TestCreditCardPayment()
        {
            CreditCardPayment creditCardPayment = new CreditCardPayment();
            Assert.AreEqual(creditCardPayment.LastName, string.Empty);
            Assert.AreEqual(creditCardPayment.FirstName, string.Empty);
            Assert.AreEqual(creditCardPayment.CreditCardNumber.Length, 4);
            Assert.AreEqual(creditCardPayment.EffectiveDateYear, Constant.START_YEAR.ToString());
            Assert.AreEqual(creditCardPayment.EffectiveDateMonth, "1");
            Assert.AreEqual(creditCardPayment.SecurityCode, string.Empty);
            Assert.AreEqual(creditCardPayment.Mail, string.Empty);
            Assert.AreEqual(creditCardPayment.Address, string.Empty);
        }
    }
}