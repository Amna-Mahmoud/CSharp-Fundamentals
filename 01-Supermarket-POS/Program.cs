            Console.Write("Enter the price1 :");
            double price1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the price2 :");
            double price2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the quantity2 :");
            int quantity2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the customer age :");
            int customerAge = Convert.ToInt32(Console.ReadLine());

            double totalBill = (price1 + (price2 * quantity2)) * 1.14;
            Console.WriteLine($"The totalbill before discount = {totalBill}");
            totalBill -= 20;
            Console.WriteLine($"The totalbill after discount = {totalBill}");
            int customerPoints = 5;
            ++customerPoints;
            customerPoints--;
            bool isVIP = totalBill >= 500.0;
            bool isSeniorDiscount = customerAge > 60;
            bool hasFreeshipping = customerPoints != 0;

            Console.WriteLine($"The customer points = {customerPoints}");     
            Console.WriteLine($"is totalbill >= 500.0 ? {isVIP}");     
            Console.WriteLine($"is customer age > 60 ?  {isSeniorDiscount}");     
            Console.WriteLine($"is customer points != 0 ? {hasFreeshipping}"); 
