// See https://aka.ms/new-console-template for more information
using BankAccount;

Account account = new Account(101001,"ROSALIN");
account.CustDetail();

account.AccBalance = 60000.00;

Console.WriteLine("1. Deposit");
Console.WriteLine("2. Withdraw");
Console.Write("Enter your option: ");
int op = Convert.ToInt32(Console.ReadLine());

switch (op)
{
    case 1:
        account.Deposit();
        break;
    case 2:
        account.Withdraw();
        break;
    default:
        Console.WriteLine("You entered wrong option!");
        break;
}

Console.Read();










