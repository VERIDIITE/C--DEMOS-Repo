﻿string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };

string[] rsvps = new string[10];
int Count = 0;

RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
{

    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[Count] = $"name: {name}, \tparty Size: {partySize}, \tAllergies: {allergies}";
    Count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVP:");
    for (int i = 0; i < Count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}