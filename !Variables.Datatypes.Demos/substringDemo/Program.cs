// string message = "What is the value <span>between the tags</span>?";

// int openPosition = message.IndexOf("<span>");
// int closePosition = message.IndexOf("</span>");

// // Console.WriteLine(openPosition);
// // Console.WriteLine(closePosition);

// openPosition += 6;

// int length = closePosition - openPosition;
// Console.WriteLine(message.Substring(openPosition, length));



// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }

string message = "Hello, world!";

char[] charstoFind = {'a', 'e', 'i', 'o'};

int index = message.IndexOfAny(charstoFind);

Console.WriteLine($"Found '{message [index]}' in '{message}' at index: {index}");



