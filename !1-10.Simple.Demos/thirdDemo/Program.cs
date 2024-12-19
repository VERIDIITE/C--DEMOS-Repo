Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"You rolled: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled Tripples, and will gain +6");
        total += 6;
    }
    
    else 
    {
        Console.WriteLine("You rolled twice, and will gain +2");
        total += 2;
    }

    Console.WriteLine($"Your Total inclding the bonus: {total}");
    
}

if (total >= 16) {
    Console.WriteLine("You win a car");
} else if (total >= 10) {
    Console.WriteLine("You win a laptop");
} else if (total == 7) {
    Console.WriteLine("You win a trip for two");
} else 
{
    Console.WriteLine("You win a kitten");
}

