using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class CreditCardPayment
    {
        private string _lastName;
        private string _firstName;
        private string[] _creditCardNumber;
        private string _effectiveDateYear;
        private string _effectiveDateMonth;
        private string _securityCode;
        private string _mail;
        private string _address;

        public CreditCardPayment()
        {
            LastName = string.Empty;
            FirstName = string.Empty;
            CreditCardNumber = new string[Constant.FOUR];
            EffectiveDateYear = Constant.START_YEAR.ToString();
            EffectiveDateMonth = (1).ToString();
            SecurityCode = string.Empty;
            Mail = string.Empty;
            Address = string.Empty;
        }

        /*public CreditCardPayment(string lastName, string firstName, string[] creditCardNumber, string effectiveDateYear, string effectiveDateMonth, string securityCode, string mail, string address)
        {
            _lastName = lastName;
            _firstName = firstName;
            _creditCardNumber = creditCardNumber;
            _effectiveDateYear = effectiveDateYear;
            _effectiveDateMonth = effectiveDateMonth;
            _securityCode = securityCode;
            _mail = mail;
            _address = address;
        }*/

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FirstName
        { 
            get 
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string[] CreditCardNumber
        { 
            get 
            {
                return _creditCardNumber;
            }
            set
            {
                _creditCardNumber = value;
            }
        }

        public string EffectiveDateYear
        { 
            get 
            {
                return _effectiveDateYear;
            }
            set
            {
                _effectiveDateYear = value;
            }
        }

        public string EffectiveDateMonth
        {
            get
            {
                return _effectiveDateMonth;
            }
            set
            {
                _effectiveDateMonth = value;
            }
        }

        public string SecurityCode
        { 
            get 
            {
                return _securityCode;
            }
            set
            {
                _securityCode = value;
            }
        }

        public string Mail 
        { 
            get 
            {
                return _mail;
            } 
            set
            {
                _mail = value;
            }
        }

        public string Address 
        { 
            get 
            {
                return _address;
            } 
            set
            {
                _address = value;
            }
        }
    }
}
