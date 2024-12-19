// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");
// string pang = "The quick brown fox jumps over the lazy dog.";

// Console.WriteLine(!pang.Contains("fox"));
// Console.WriteLine(!pang.Contains("cow"));

// int a = 7;

// int b = 8;

// Console.WriteLine(a != b);
// string s1 = "Hello";
// string s2 = "Hello";

// Console.WriteLine(s1 != s2);

// int saleAmount  = 1001;
// // int discountAmount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");


string permission = ("Admin|Manager");
int level = 53;

if (permission.Contains("Admin"))
{

    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}

else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }


}