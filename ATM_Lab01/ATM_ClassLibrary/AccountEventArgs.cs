using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_ClassLibrary
{
    public class AccountEventArgs : EventArgs
    {
        public string Message { get; }

        public AccountEventArgs(string message)
        {
            Message = message;
        }
    }
}
