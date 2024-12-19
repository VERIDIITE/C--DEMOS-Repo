Random random = new Random();
int daysuntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysuntilExpiration == 0) {
    Console.WriteLine("Your Subscription has expired");
} else if (daysuntilExpiration == 1) {
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 10;
} else if (daysuntilExpiration <= 5) {
    Console.WriteLine($"Your subscription expires within {daysuntilExpiration}");
} else if (daysuntilExpiration <=10) {
    Console.WriteLine("Your subscription expires soon");
}

if (discountPercentage > 0) {
    Console.WriteLine($"Renew now and save {discountPercentage}%.");

}

