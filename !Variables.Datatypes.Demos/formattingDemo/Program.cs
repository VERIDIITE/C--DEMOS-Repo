// string first = "hello";

// string second = "world";

// Console.WriteLine($"{first} {second}!");

// Console.WriteLine("{0} {1}!", first, second);

// decimal price = 123.4m;

// int discount = 50;

// Console.WriteLine($" price: {price:C} (save {discount:C})");


// decimal price = 67.55m;

// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2}", price, salePrice);

// Console.WriteLine(yourDiscount); 
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Your invoice number: {invoiceNumber}");
Console.WriteLine($"Your Product Share: {productShares:N3}");
Console.WriteLine($"Your Sub Total: {subtotal:C}");
Console.WriteLine($"Your Percentage: {taxPercentage:P2}");
Console.WriteLine($"Your Total: {total:C}");





