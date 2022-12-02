using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ATM_ClassLibrary;

namespace ATM_ConsoleApp
{
    internal class Program
    {


        static void ShowMessage(object sender, AccountEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
       

        static bool IsValidPin(string number)
        {
            Console.WriteLine("Введіть пін-код: ");
            if (Regex.Match(Console.ReadLine(), @"^\d{4}$").Success)
            {
                return true;
            }
            else
            {
                Console.WriteLine("\nПомилка!\n");
                return IsValidPin(number);
            }
        }

        public static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.Unicode;

            List<Account> Accounts = new List<Account>();
            Accounts.Add(new Account("45327728185273954", "Name#1", "Surname#1","1234", 0));
            Accounts.Add(new Account("45327728945243252", "Name#2", "Surname#2", "1234", 1000));
            Accounts.Add(new Account("45327747488849451", "Name#3", "Surname#3", "1234", 250));
            Accounts.Add(new Account("45327728489482742", "Name#4", "Surname#4", "1234", 25.67));
            Accounts.Add(new Account("45327728189814415", "Name#5", "Surname#5", "1235", 525.55));
            Accounts.Add(new Account("12345678901234567", "Name#6", "Surname#6", "1234", 40000000));


            List<ATM> ATMs = new List<ATM>();
            List<Bank> Banks = new List<Bank>();

            ATMs = new List<ATM>();
            ATMs.Add(new ATM(25000, 1, "Вулиця Чуднівська"));
            ATMs.Add(new ATM(100000, 2, "Вулиця Бердичівська"));
            ATMs.Add(new ATM(150000, 3, "Вулиця Київська"));
            Banks.Add(new Bank("ПриватБанк", ATMs));

            ATMs = new List<ATM>();
            ATMs.Add(new ATM(5000, 1, "Вулиця Перемоги"));
            ATMs.Add(new ATM(0, 2, "Вулиця України"));
            Banks.Add(new Bank("Альфа-Банк", ATMs));

            // Creating a new Account -->
            Account account = new Account();
            account.Message += ShowMessage;
            Account Authentification()
            {
                string cardNumber;
                do
                {
                    Console.WriteLine("Введіть номер картки: ");
                    cardNumber = Console.ReadLine();
                    if (account.Regex_for_CardNumber(cardNumber))
                    {
                        break;
                    }
                } while (true);
                int index = Accounts.FindIndex(acc => acc.Number == cardNumber);
                if  (index != 0)
                {
                    do
                    {
                        string pin;
                        do
                        {
                            Console.WriteLine("Введіть пін-код картки: ");
                            pin = Console.ReadLine();
                            if (account.Regex_for_Pin(cardNumber))
                            {
                                break;
                            }
                        } while (true);

                        if (Accounts[index].Check_Pin(pin))
                        {
                            return Accounts[index];
                        }

                    } while (true);
                }
                else
                {
                    return Authentification();
                }
            }

            account = Authentification();
            account.Message += ShowMessage;
            Bank bank = Select_Bank();
            ATM atm = Select_ATM(bank);


            Bank Select_Bank()
            {
                Console.WriteLine("Оберіть Банк :\n");
                Console.WriteLine($"| {"Name",13} | {"Count of ATM's",16}|\n-----------------------------------");
                foreach (Bank item in Banks)
                {
                    Console.WriteLine($"| {item.Name,13} | {item.ATMS.Count,16}|");
                }
                int id;
                while (!Int32.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Невірно введено число! Спробуйте ще раз!");
                }
                if (id <= Banks.Count && id >= 1)
                {
                    return Banks[id - 1];
                }
                else
                {
                    return Select_Bank();
                }
            }

            ATM Select_ATM(Bank Bank)
            {
                Console.WriteLine("Оберіть термінал :\n");
                Console.WriteLine($"| {"Id",10} | {"Adress",20}|\n------------------------------------");

                foreach(ATM item in Bank.ATMS)
                {
                    Console.WriteLine($"| {item.Id,10} | {item.Address,20}|");
                }
                int id;
                while(!Int32.TryParse(Console.ReadLine(),out id))
                {
                    Console.WriteLine("Невірно введено число! Спробуйте ще раз!");
                }

                if (id <= Bank.ATMS.Count && id >= 1)
                {
                    return Bank.ATMS[id-1];
                }
                else
                {
                    Console.WriteLine("Неіснує такого терміналу!");
                    return Select_ATM(Bank);
                }
            }
            void Menu()
            {
                Console.WriteLine($"\n{account.Name} {account.Surname}, Вас вітає '{bank.Name}'\nТермінал №{atm.Id}\nАдреса: {atm.Address}");
                Console.WriteLine($"\nОберіть потрібну вам дію: ");
                Console.WriteLine("1 - Показати рахунок");
                Console.WriteLine("2 - Поповнити рахунок");
                Console.WriteLine("3 - Зняти гроші");
                Console.WriteLine("4 - Перейти в інший термінал");
                Console.WriteLine("5 - Використати термінал іншого банку");
                Console.WriteLine("6 - Переказати кошти на інший рахунок");
                Console.WriteLine("0 - Вихід");
                int a;
                string amount;
                if (!Int32.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Помилка! Введіть цифру!");
                    Menu();
                }
                switch (a)
                {
                    case 1:
                        Console.Clear();
                        account.Show_Balance();
                        Menu();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введіть суму, що хочете внести у рахунок:");
                        amount = Console.ReadLine();
                        account.Deposit(amount, atm);
                        account.Show_Balance();
                        Menu();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Введіть суму, що хочете вивести:");
                        amount = Console.ReadLine();
                        account.Withdraw(amount, atm);
                        account.Show_Balance();
                        Menu();
                        break;
                    case 4:
                        Console.Clear();
                        atm = Select_ATM(bank);
                        Console.Clear();
                        Menu();
                        break;

                    case 5:
                        Console.Clear();
                        bank = Select_Bank();
                        atm = Select_ATM(bank);
                        Console.Clear();
                        Menu();
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("Введіть картку на яку хочете внести кошти :");
                        string number = Console.ReadLine();
                        foreach (Account acc in Accounts)
                        {
                            if (acc.Number == number)
                            {
                                Console.WriteLine("Введіть суму, що хочете внести у рахунок:");
                                amount = Console.ReadLine();
                                double money;
                                if (Double.TryParse(amount,out money))
                                {
                                    acc.Balance += money;
                                    account.Balance -= money;
                                    Console.WriteLine($"Рахунок поповнено на {money} грн.");
                                }
                                break;
                            }
                            else if (acc.Number != number && Accounts[Accounts.Count - 1] == acc)
                            {
                                Console.WriteLine("Невірно введено номер картки");
                            }
                        }
                        Menu();
                        break;
                    case 0:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Помилка! Введіть число зі списку можливих!");
                        Menu();
                        break;
                }
            }
            Console.Clear();
            Menu();
        }
    }
}
