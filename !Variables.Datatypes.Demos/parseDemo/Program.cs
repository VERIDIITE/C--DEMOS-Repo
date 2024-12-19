
// string value = "110";

// int result = 0;

// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report measurement");
// }

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

List<decimal> numbers = new List<decimal>();

decimal total = 0m;

string message = "";

foreach (string value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        numbers.Add(number);

    }
    else
    {

        message += value;

    }
}

Console.WriteLine("Numbers:");
foreach (decimal num in numbers)
{
    Console.WriteLine(num);
}

Console.WriteLine($"Message: {message}");

Console.WriteLine($"Total: {total}");