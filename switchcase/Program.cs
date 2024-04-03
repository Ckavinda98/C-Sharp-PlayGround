ValueMesurement(14);
ValueMesurement(-5);
ValueMesurement(28);

void ValueMesurement(double value)
{
    switch (value)
    {
        case < 0.0:
        Console.WriteLine("Your Value is Below Zero");
        break;

        case > 15.00:
        Console.WriteLine("Your Value to High");
        break;

        case < 15.00:
        Console.WriteLine("Your Value to TO Low");
        break;

        default:
        Console.WriteLine("Unvalid Value");
        break;
    }
}


case guard

void ValueMesurement(double value)
{
    switch (value)
    {
        case < 0.0:
        case < 100.0:
        Console.WriteLine("Your Value is Out of Range");
        break;

        default:
        Console.WriteLine("Unvalid Value");
        break;
    }
}
TwoInputValue(20, 59);
TwoInputValue(-4, -9);
TwoInputValue(40, 40);

void TwoInputValue(int a, int b)
{
    switch ((a, b))
    {
        case (>0, >0) when a==b:
        Console.WriteLine("Both Input Value are Valid  and Equal");
        break;

        case (>0, >0):
        Console.WriteLine("Both Input arw Valid");
        break;

        default:
        Console.WriteLine("Your Input is Not Valid");
        break;
    }
}