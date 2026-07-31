 Console.Write("Enter your age : ");
 int age = Convert.ToInt32(Console.ReadLine());
 Console.Write("Do you have a coupon ? (true / false) : ");
 bool hasCoupon = Convert.ToBoolean(Console.ReadLine());
 int priceTicket = 100;
 if (age < 12 || age > 60)
 {
     if (hasCoupon)
     {
         priceTicket -= 80;
         Console.WriteLine("you are lucky! You have a special discount (80%)");
     }
     else 
     { 
         priceTicket -= 50;
         Console.WriteLine("You got an Age discount (50%)");
     }
 }
 else 
 {
     if (hasCoupon)
     {
         priceTicket -= 20;
         Console.WriteLine("you are lucky! You got a Coupon discount (20%)");
     }
     else
     {
         Console.WriteLine("Welcome! Standard ticket");
     }
 }
 Console.WriteLine($"the price of the ticket = {priceTicket}");
