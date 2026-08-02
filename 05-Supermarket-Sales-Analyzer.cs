Console.Write("Enter the market name : ");
string marketName = Console.ReadLine();

Console.Write("Enter the daily sales target : ");
double targetSales = Convert.ToDouble(Console.ReadLine());

double[] itemPrices = new double[6];
for (int i = 0; i < itemPrices.Length; i++)
{
    Console.Write($"Enter the price of the item {i + 1} : ");
    itemPrices[i] = double.Parse(Console.ReadLine());
}

itemPrices[0]++;
itemPrices[5]--;
itemPrices[2] += 10;

double totalSales = 0;
foreach (double item in itemPrices)
{
    totalSales += item;
}

double averagePrice = totalSales / 6;

Array.Sort(itemPrices);

string performanceStatus = "";
if (totalSales > targetSales && averagePrice > 50)
{
     performanceStatus = "Exellent Performance";
}
else if ( totalSales >= targetSales && averagePrice <= 50)
{
     performanceStatus = "Good Performance";
}
else
{
     performanceStatus = "Low Performance";
     totalSales -= 20;
}
string targetStatus = totalSales >= targetSales ? "Target Achieved" : "Target Missed";

bool isHighvalueStore = totalSales > 500 && averagePrice > 40;
bool isNeedsMarketing = totalSales < targetSales || averagePrice < 20;

Console.WriteLine($"___________ ({marketName}) __________");
Console.WriteLine($"The daily Target Sales : {targetSales}");
Console.WriteLine($"Performance Status: {performanceStatus}");
Console.WriteLine($"Target Status     : {targetStatus}");
Console.WriteLine("___________________________");
Console.WriteLine($"Sorted Item Prices : ");

foreach (double digit in itemPrices)
{
    Console.WriteLine($"{digit}");
}
Console.WriteLine("___________________________");
Console.WriteLine($"the total sales : {totalSales}");
Console.WriteLine($"the average price : {averagePrice}");
Console.WriteLine($"Is Highvalue Store ? {isHighvalueStore}");
Console.WriteLine($"Is Needs Marketing ? {isNeedsMarketing}");
