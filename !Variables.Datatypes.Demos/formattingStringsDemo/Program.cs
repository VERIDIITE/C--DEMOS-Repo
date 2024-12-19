string paymentID = "796C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmmount = "$5,000.00";

var formattedLine = paymentID.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");

Console.WriteLine(formattedLine);

