using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_ClassLibrary
{
    public class ATM
    {
        private double _balance;
        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        } // Available money in the terminal

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        } // id of the ATM

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        } // Address of the ATM

        public ATM(int balance, int id, string address) // basic constructor for ATM
        {
            Balance = balance;
            Id = id;
            Address = address;
        }

    }
}
