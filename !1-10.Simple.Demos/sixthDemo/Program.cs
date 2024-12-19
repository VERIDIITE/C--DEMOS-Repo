// Random random = new Random(); 
// string[] orderID = new string[5];
// for (int i = 0; i < orderID.Length; i++) {
    
//     int prefixValue = random.Next(55, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");

//     orderID[i] = prefix + suffix;

// }

// foreach (var orderIDs in orderID) 
// {
//     Console.WriteLine(orderIDs);

// }


// Random random = new Random();
//  int roll = random.Next(1, 10);
//  int roll2 = random.Next(2,20);
//  int roll3 = random.Next(3,30);

// int total = roll + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll} + {roll2} + {roll3} = {total}");

// if ((roll == roll2 || roll2 == roll3 || roll == roll3)) {

// } if ((roll == roll2) && (roll2 == roll3)) {
//     Console.WriteLine("You rollled triples! 6+ added");
//     total += 6;
// } else {
//     Console.WriteLine("You rolled Doubles! 2+ added");
//     total += 2;
// }


/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */
 
String originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message) 
{
    if (letter == 'o') 
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(message);
Console.WriteLine($"'o' appear {letterCount} times.");

