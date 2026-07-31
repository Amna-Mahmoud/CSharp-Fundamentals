Console.Write("Enter The employee name : ");
string employeeName = Console.ReadLine();

Console.Write("Enter The employee age : ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter The base salary : ");
double baseSalary = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter The overtime hours : ");
int overtimeHours = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter The performanceRating (1 : 5)  : ");
int performanceRating = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter The absence days : ");
int absenceDays = Convert.ToInt32(Console.ReadLine());

overtimeHours++;
if (absenceDays > 0)
{
    absenceDays--;
}

int overtimePay = 50;
double totalOvertimePay = overtimePay * overtimeHours;

int absencePenalty = 200;
double totalAbsencePenalty = absencePenalty * absenceDays;

double initialSalary = baseSalary + totalOvertimePay - totalAbsencePenalty;

double bonus = 0;
string rank = "";

if (performanceRating >= 4)
{
    if (age > 30)
    {
        bonus = 0.2 * initialSalary;
        rank = "Senior Employee";
    }
    else
    {
        bonus = 0.15 * initialSalary;
        rank = "Mid-Level Employee";
    }
}
else if (performanceRating == 3)
{
    bonus = 0.05 * initialSalary;
    rank = "Junior Employee"; 

    if (absenceDays == 0)
    {
        bonus += 500;
    }
}
else
{
    initialSalary -= 300;
    bonus = 0; 
    rank = "Needs Improvement";
}

double netSalary = bonus + initialSalary;

bool isHighPerformance = (performanceRating >= 4 && absenceDays <= 2);
bool isEligibleForTax = (netSalary >= 10000);

Console.WriteLine("---------------------------------------------");
Console.WriteLine($"The Employee name : {employeeName}");
Console.WriteLine($"The Employee age : {age}");
Console.WriteLine($"{employeeName}, you are {rank}");
Console.WriteLine($"The initial salary : {initialSalary}");
Console.WriteLine($"The total overtime pay : {totalOvertimePay}");
Console.WriteLine($"The total absence days : {absenceDays}");
Console.WriteLine($"The bonus : {bonus}");
Console.WriteLine($"The Net Salary : {netSalary}");
Console.WriteLine($"Is the employee High performance ? {isHighPerformance}");
Console.WriteLine($"Is the Employee Eligible For Tax ? {isEligibleForTax}");
