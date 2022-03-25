namespace Lesson3
{
    public class BankAccount
    {
        public BankAccount()
        {
            AddAccountNumber();

        }

        public BankAccount(int accountBalanceUser)
        {
            AddAccountNumber();
            _accountBalance = accountBalanceUser;


        }

        public BankAccount(AccountType clientAccountTypeUser)
        {
            AddAccountNumber();
            _clientAccountType = clientAccountTypeUser;

        }

        public BankAccount(AccountType clientAccountTypeUser, int accountBalanceUser)
        {
            AddAccountNumber();
            _accountBalance = accountBalanceUser;
            _clientAccountType = clientAccountTypeUser;
        }

        public enum AccountType
        {
            MainAccount = 1,
            DollarAccount = 2,
            EuroAccount = 3,
            AccountInYuan = 4,
            SavingsAccount = 5,
            InvestmentAccount = 6,
            CreditAccount = 7,
            MortgageAccount = 8
        }

        private static uint _accountNumber = 10000000;
        public uint AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
            }

        }

        private int _accountBalance = 100000;
        public int AccountBalance
        {
            get
            {
                return _accountBalance;
            }
            set
            {
                _accountBalance = value;
            }

        }

        private AccountType _clientAccountType = AccountType.MainAccount;
        public AccountType ClientAccountType
        {
            get
            {
                return _clientAccountType;
            }
            set
            {
                _clientAccountType = value;
            }

        }


        public void AddAccountNumber()
        {
            _accountNumber += 1;

        }


        public int PutBalance(AccountType clientAccountTypeUser, int accountBalanceUser)
        {

            switch (clientAccountTypeUser)
            {
                case AccountType.DollarAccount:
                    _clientAccountType = AccountType.DollarAccount;
                    _accountBalance += (accountBalanceUser / 105);
                    break;

                case AccountType.EuroAccount:
                    _clientAccountType = AccountType.EuroAccount;
                    _accountBalance += (accountBalanceUser / 115);
                    break;

                case AccountType.AccountInYuan:
                    _clientAccountType = AccountType.AccountInYuan;
                    _accountBalance += (accountBalanceUser / 16);
                    break;

                case AccountType.SavingsAccount:
                    _clientAccountType = AccountType.SavingsAccount;
                    _accountBalance += accountBalanceUser;
                    break;

                case AccountType.MortgageAccount:
                    _clientAccountType = AccountType.MortgageAccount;
                    _accountBalance += accountBalanceUser;
                    break;

                case AccountType.CreditAccount:
                    _clientAccountType = AccountType.CreditAccount;
                    _accountBalance += accountBalanceUser;
                    break;

                case AccountType.MainAccount:
                    _clientAccountType = AccountType.MainAccount;
                    _accountBalance += accountBalanceUser;
                    break;
            }


            return _accountBalance;


        }


        public int TransferFromAccount(AccountType clientAccountTypeUser, int accountBalanceUser)
        {

            _clientAccountType = clientAccountTypeUser;
            if (_accountBalance >= accountBalanceUser)
            {
                _accountBalance -= accountBalanceUser;
                return _accountBalance;
            }
            else
            {
                Console.WriteLine($"Уменьшите сумму перевода!!!");
                return _accountBalance;
            }

        }

    }

    public class Program
    {
        static void Main(string[] args)
        {

            var clientDollarAccount = new BankAccount(BankAccount.AccountType.DollarAccount, 50000);
            Console.WriteLine($"Банковский счет в долларах:  { clientDollarAccount.AccountNumber} {clientDollarAccount.AccountBalance} {clientDollarAccount.ClientAccountType}");

            clientDollarAccount.TransferFromAccount(BankAccount.AccountType.DollarAccount, 105000);
            Console.WriteLine($"Баланс в долларах:{clientDollarAccount.AccountBalance}");

            var clientEuroAccount = new BankAccount(BankAccount.AccountType.InvestmentAccount, 1200);
            Console.WriteLine($"Банковский счет в евро:  {clientEuroAccount.AccountNumber} {clientEuroAccount.AccountBalance} {clientEuroAccount.ClientAccountType}");

            clientEuroAccount.TransferFromAccount(BankAccount.AccountType.EuroAccount, 1150);
            Console.WriteLine($"Баланс в евро:{clientEuroAccount.AccountBalance}");


            Console.ReadLine();
        }
    }

}








