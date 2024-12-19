// int first = 2;
// string second = "4";

// string result = first + second;
// Console.WriteLine(result);

// decimal myResult = 1.23456789m;
// float secondResult = (float)myResult;

// Console.WriteLine($"Decimal: {myResult}"); 
// Console.WriteLine($"Float: {secondResult}");

// string num1 = "50";

// string num2 = "100";

// int sum = Convert.ToInt32(num1) * Convert.ToInt32(num2);

// Console.WriteLine($"The sum to Number 1 + Number 2 is: {sum}");

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);