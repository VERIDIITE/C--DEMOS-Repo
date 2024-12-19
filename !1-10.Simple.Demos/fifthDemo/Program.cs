// string [] fradulentorderIDs = new string[3];

// fradulentorderIDs[0] = "A123";
// fradulentorderIDs[1] = "B456";
// fradulentorderIDs[2] = "C789";

// string [] fradulentorderIDs = [ "A123", "B456", "C789"];
// Console.WriteLine($"First: {fradulentorderIDs[0]}");
// Console.WriteLine($"Second: {fradulentorderIDs[1]}");
// Console.WriteLine($"Third: {fradulentorderIDs[2]}");

// fradulentorderIDs[0] = "F000";

// Console.WriteLine($"Ressign First: {fradulentorderIDs[0]}");

// Console.WriteLine($"There are {fradulentorderIDs.Length} fradulent order to pro");

// string [] names = {"James", "Asad", "Natalie", "Dave"};
// foreach (string name in names) {
//     Console.WriteLine(name);
// }

// int [] inventory = {200, 450, 700, 175, 250};

// int sum = 0;
// int bin = 0;

// foreach (int items in inventory) {
//     sum += items;
//     bin ++;
//     Console.WriteLine($"Bin {bin} = {sum} items (Running Total: {sum})");

// }

// Console.WriteLine($" we have {sum} items in inventory");

string [] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string orderID in orderIDs) 
{
    if (orderID.StartsWith("B")) 
    {
        Console.WriteLine(orderID);
    }
}