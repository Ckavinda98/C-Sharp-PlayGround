// int i = 0;
Random random = new Random();
int roll = 0;
int index = 1;

do
{
    roll = random.Next(1, 7);
    roll++;
    Console.WriteLine($"Get the value of role - {roll} time that run loop - {index}");
    index++;
    
} while(roll !=2);