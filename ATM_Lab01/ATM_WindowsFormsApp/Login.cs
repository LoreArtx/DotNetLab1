using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ATM_ClassLibrary;

namespace ATM_WindowsFormsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        public static Account Credit_account = new Account();

        private void login_button_Click(object sender, EventArgs e)
        {
            List<Account> Accounts = new List<Account>();
            Accounts.Add(new Account("45327728185273954", "Name#1", "Surname#1", "1234", 0));
            Accounts.Add(new Account("45327728945243252", "Name#2", "Surname#2", "1234", 1000));
            Accounts.Add(new Account("45327747488849451", "Name#3", "Surname#3", "1234", 250));
            Accounts.Add(new Account("45327728489482742", "Name#4", "Surname#4", "1234", 25.67));
            Accounts.Add(new Account("45327728189814415", "Name#5", "Surname#5", "1235", 525.55));
            Accounts.Add(new Account("12345678901234567", "Name#6", "Surname#6", "1234", 40000000));

            Credit_account.Message += ShowMessage;
            string number = Number.Text;
            string pin = Pin.Text;
            if (Credit_account.Regex_for_CardNumber(number))
            {
                int index= Accounts.FindIndex(acc => acc.Number == number);
                if (index > 0)
                {
                    if (Accounts[index].Check_Pin(pin))
                    {
                        Credit_account = Accounts[index];
                        this.Hide();
                        ATM_window window = new ATM_window();
                        window.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неправильно введено пін-код :");
                    }
                }
                else
                {
                    MessageBox.Show("Невірно введено номер картки: ");
                }
            }
        }

        public void ShowMessage(object sender, AccountEventArgs e)
        {
            MessageBox.Show($"{e.Message}");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
