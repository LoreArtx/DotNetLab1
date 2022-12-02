using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ATM_ClassLibrary;

namespace ATM_WindowsFormsApp
{
    public partial class ATM_window : Form
    {
        public ATM_window()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        public static Account Credit_Account;

        public List<ATM> ATMs = new List<ATM>();
        public List<Bank> Banks = new List<Bank>();

        private void Account_window_Load(object sender, EventArgs e)
        {
            ATMs = new List<ATM>();
            ATMs.Add(new ATM(25000, 1, "Вулиця Чуднівська"));
            ATMs.Add(new ATM(100000, 2, "Вулиця Бердичівська"));
            ATMs.Add(new ATM(150000, 3, "Вулиця Київська"));
            Banks.Add(new Bank("ПриватБанк", ATMs));

            ATMs = new List<ATM>();
            ATMs.Add(new ATM(5000, 1, "Вулиця Перемоги"));
            ATMs.Add(new ATM(0, 2, "Вулиця України"));
            Banks.Add(new Bank("Альфа-Банк", ATMs));

            Credit_Account = Login.Credit_account;
            Credit_Account.Message += ShowMessage;

            ComboBox select_bank = this.Select_Bank;
            foreach (Bank item in Banks)
            {
                select_bank.Items.Add($"{item.Name}");
            }
            this.Select_Bank.Text = Banks[0].Name;
            Refresh_content();

        }

        private void Refresh_content()
        {
            user.Text = $"Вас вітає '{Banks[this.Select_Bank.SelectedIndex].Name}'";
            id_atm.Text = $"Термінал #{Banks[this.Select_Bank.SelectedIndex].ATMS[this.Select_ATM.SelectedIndex].Id}";
            address.Text = $"{Banks[this.Select_Bank.SelectedIndex].ATMS[this.Select_ATM.SelectedIndex].Address}";
        }

        private void Balance_btn_Click(object sender, EventArgs e)
        {
            Credit_Account.Show_Balance();
        }

        public void ShowMessage(object sender, AccountEventArgs e)
        {
            MessageBox.Show($"{e.Message}");
        }

        private void Deposit_btn_Click(object sender, EventArgs e)
        {
            Credit_Account.Deposit(amount.Text, Banks[this.Select_Bank.SelectedIndex].ATMS[this.Select_ATM.SelectedIndex]);
        }

        private void Withdraw_btn_Click(object sender, EventArgs e)
        {
            Credit_Account.Withdraw(amount.Text, Banks[this.Select_Bank.SelectedIndex].ATMS[this.Select_ATM.SelectedIndex]);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login_window = new Login();
            login_window.Show();
        }

        private void Select_Bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Select_ATM.Items.Clear();
            foreach (ATM atm in Banks[this.Select_Bank.SelectedIndex].ATMS)
            {
                this.Select_ATM.Items.Add(atm.Id);
            }
            this.Select_ATM.Text = Convert.ToString(Banks[this.Select_Bank.SelectedIndex].ATMS[0].Id);

            Refresh_content();
        }

        private void Select_ATM_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh_content();
                
        }
    }
}
