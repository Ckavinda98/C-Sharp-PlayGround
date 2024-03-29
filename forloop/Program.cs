for(int i=1; i<101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine($"{i} = FizzeBizze");

    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} = Bizze");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} = Fizze");
    }
    else
    {
        Console.WriteLine(i);
    }
    
}
