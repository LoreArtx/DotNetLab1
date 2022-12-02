using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_ClassLibrary
{
    public class Bank
    {
        private string _name;
        public string Name {
            get { return _name; }
            set { _name = value; }
        } // Name of the BANK

        private List<ATM> _ATMs;
        public List<ATM> ATMS
        {
            get { return _ATMs; }
            set { _ATMs = value; }
        } // List of terminal the BANK has
    
        public Bank(string name, List<ATM> atms)
        {
            _name = name;
            _ATMs = atms;
        }
    }
}
