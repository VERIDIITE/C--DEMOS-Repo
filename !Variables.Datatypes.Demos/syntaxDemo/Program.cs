// int[] a = { 1, 2, 3, 4, 5 };

// Console.WriteLine("CONTENS OF ARRAY:");

// printArray();

// void printArray() {
//     foreach (int x in a) {

//         Console.WriteLine($"{x} ");

//     }

//     Console.WriteLine();
// }


Console.WriteLine("Generating Random numbers...");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
}

