string message = "Help (find) the {opening symbols}";

Console.WriteLine($"Searching THIS MESSAGE: {message}");

Char[] symbols = { '[', '{', '(' };

int startPosition = 5;

int openingPosition = message.IndexOfAny(symbols);

Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(symbols, startPosition);

Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");

