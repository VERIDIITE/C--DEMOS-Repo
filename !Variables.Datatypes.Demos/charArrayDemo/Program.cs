// string data = "123abcdef";
// char[] dataArray = data.ToCharArray();
// Array.Reverse(dataArray);
// string result = string.Join(",", dataArray);
// Console.WriteLine(result);

// string[] items = result.Split (',');
// foreach (string item in items) {
//     Console.WriteLine(item);
// }

string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{

    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);

}

string result = string.Join(" ", newMessage);

Console.WriteLine(result);