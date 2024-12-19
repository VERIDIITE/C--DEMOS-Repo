string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

// Display internal email addresses
for (int i = 0; i < corporate.GetLength(0); i++)
{
    // Use corporate array for internal emails
    displayEmail(first: corporate[i, 0], last: corporate[i, 1]);
}

// Display external email addresses
for (int i = 0; i < external.GetLength(0); i++)
{
    // Use external array for external emails
    displayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
}

void displayEmail(string first, string last, string domain = "contoso.com")
{
    string email = first.Substring(0, 2) + last;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}