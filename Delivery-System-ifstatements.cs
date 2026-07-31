Console.Write("Enter your name : ");
string name = Console.ReadLine();
Console.Write("Enter your age : ");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the total orders : ");
int totalOrders = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the total sales : ");
double totalSales = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("____________________________");

double commission = (totalSales * 0.05) + (totalOrders * 10);
++totalOrders;
commission -= 50;

if (age >= 21 && totalOrders > 50)
{
    Console.WriteLine("status : VIP captain");
    commission += 100;
}
else if (totalSales > 2000)
{
    Console.WriteLine("status : Active captain");
    commission += 50;
}
else
{
    Console.WriteLine("status : Standard captain");
}

bool isHighEarner = commission >= 300;
bool isEligibleForBonus = totalOrders > 20;

Console.WriteLine($"Name : {name} , Age : {age}");
Console.WriteLine($"The total orders = { totalOrders}");
Console.WriteLine($"The commission = {commission}");
Console.WriteLine($"Is The Commision >= 300 ? {isHighEarner}");
Console.WriteLine($"Is The Total Orders > 20 ? {isEligibleForBonus}");
