// string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

// DisplayStudents(students);
// DisplayStudents(new string[] { "Robert", "Vanya" });

// void DisplayStudents(string[] students)
// {
//     foreach (string student in students)
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }

printCircleArea(12);



void printCircleArea(int radius)
{
    double pi = 3.13159;
    double circumference = 2 * pi * radius;
    printCircleInfo(12);
    printCircleInfo(24);

    void printCircleArea(int radius)
    {
        double area = pi * (radius * radius);
        Console.WriteLine($"Area = {area}");
    }

    void printCircleCircumference(int radius)
    {
        double circumference = 2 * pi * radius;
        Console.WriteLine($"Circumference = {circumference}");
    }

    void printCircleInfo(int radius)
    {
        Console.WriteLine($"Circle with radius {radius}");
        printCircleArea(radius);
        printCircleCircumference(radius);
    }
}

