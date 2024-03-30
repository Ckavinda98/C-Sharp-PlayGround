

Random random = new Random();
int roll = random.Next(1, 11);

Console.WriteLine($"First Number is :  {roll}");
while(roll >= 3)
{
    Console.WriteLine($"Get the Roll Number {roll}");
    roll = random.Next(2, 11);
}

Console.WriteLine($"Last Number is :  {roll}");