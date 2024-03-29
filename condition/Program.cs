var dice = new Random();

var roll1 = dice.Next(1, 7);
var roll2 = dice.Next(1, 7);
var roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"This is Your Points:  {roll1} + {roll2} + {roll3} and THis is Your Total Right Now {total}");


if((roll1 == roll2) || (roll3 == roll2) || (roll1 == roll3))
{
    Console.WriteLine("You Have double, for that you get 2 points");
    total += 2;
}

if(total > 14)
{
    Console.WriteLine($"You Win and  This is Your Total: {total} ");
}

else
{
    Console.WriteLine($"You Loose and  This is Your Total: {total}");
}