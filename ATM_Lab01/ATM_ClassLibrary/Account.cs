using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ATM_ClassLibrary
{

    public class Account
    {
        public delegate void AccountHandlerEvents(object sender, AccountEventArgs e);
        public event AccountHandlerEvents Message;

        private string _pin;
        public string Pin
        {
            set { _pin = value; }
        } // pin for card

        private string _number;
        public string Number 
        { 
            get { return _number; }
            set { _number = value; }
        } // a card number

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } // name of the card owner

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        } // surname of the card owner

        private double _balance;
        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        } // balance of the card

        public Account(string number, string name, string surname,string pin, double balance) // basic contructor for account
        {
            Number = number;
            Name = name;
            Surname = surname;
            Pin = pin;
            Balance = balance;
        }

        public Account() // empty contructor for a new account
        {
        }

        public void Deposit(string amount, ATM atm)
        {
            double money;
            if (Double.TryParse(amount, out money))
            {
                Message(this, new AccountEventArgs($"Рахунок поповнено на {money} грн."));
                Balance += money;
                atm.Balance += money;
            }
            else Message(this, new AccountEventArgs($"Невірно введено суму!"));

        }

        public void Show_Balance()
        {
            Message(this, new AccountEventArgs($"На рахунку : {Balance} грн."));
        }

        public void Withdraw(string amount,ATM atm)
        {
            double money;
            if (Double.TryParse(amount, out money))
            {
                if (Balance >= money)
                {
                    if (atm.Balance >= money)
                    {
                        Message(this, new AccountEventArgs($"{money} грн. знято з рахунку"));
                        Balance -= money;
                        atm.Balance -= money;
                    }
                    else
                    {
                        Message(this, new AccountEventArgs($"Терміналу не вистачає коштів!"));
                    }

                }
                else
                {
                    Message(this, new AccountEventArgs($"На рахунку недостатньо коштів!"));
                }
            }
            else Message(this, new AccountEventArgs($"Невірно введено суму"));

        }

        public bool Regex_for_CardNumber(string number)
        {
            Regex regex = new Regex(@"\d{16}");
            if (regex.IsMatch(number))
            {
                return true;
            }
            else
            {
                Message(this, new AccountEventArgs($"Невірно введено номер картки"));
                return false;
            }
        }

        public bool Regex_for_Pin(string pin)
        {
            Regex regex = new Regex(@"\d{4}");
            if (regex.IsMatch(pin))
            {
                return true;
            }
            else
            {
                Message(this, new AccountEventArgs($"Невірно введено пін-код картки"));
                return false;
            }
        }

        public bool Check_Pin(string pin)
        {
            if(pin == _pin)
            {
                return true;
            }else return false;
        }

    }
}
