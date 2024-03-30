// int i = 0;
Random random = new Random();
int roll = 0;
int index = 1;

do
{
    roll = random.Next(1, 11);
    
    if (roll >= 9) break;
    // if (roll != 9) continue;
    
        Console.WriteLine($"Get the value of role - {roll} time that run loop - {index}");
        index++;
    
    
    
} while(roll !=7);