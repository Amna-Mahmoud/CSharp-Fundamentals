Console.Write("Enter the PIN : ");
int password = Convert.ToInt32(Console.ReadLine());
while (password != 1234)
{
    Console.WriteLine("  Incorrect PIN , try again");
    Console.Write("Enter the PIN : ");
    password = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("  Access Granted! Welcome! ");

double balance = 1000.0;
int choice;
do
{
    Console.WriteLine("--------------------------------");
    Console.WriteLine("1.check Balance");
    Console.WriteLine("2.Deposit Money");
    Console.WriteLine("3.Exit");
    Console.Write("Enter your choice : ");
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("--------------------------------");

    if (choice == 1)
    {
        Console.WriteLine($"Your Current Balance: {balance} EGP");
    }
    else if (choice == 2)
    {
        Console.Write("Enter the deposit amount: ");
        double deposit = Convert.ToDouble(Console.ReadLine());
        balance += deposit;
        Console.WriteLine($"Deposit Successful! New Balance: {balance} EGP");
    }
    else if (choice == 3)
    {
        Console.WriteLine("Thank you for using our ATM ! ");
    }
    else
    {
        Console.WriteLine("Invalid option , please choose 1 , 2 or 3 ");
    }

} while (choice != 3);
