int[] values = {20, 5, 79, 59, 89, 12, 30};

// int max  = values[0];

// Using Max Methosd --> First Approach
// int max  = values.Max();

// Using For Loop Methosd --> Second Approach
// for(int i = 1; i < values.Length; i++)
// {
//     if (values[i] > max)
//     {
//         max = values[i];
//     }
// }



// Using Foreach Loop Methosd --> Third Approach

int max = int.MinValue;

foreach(int num in values)
{
    if (num > max)
    {
        max = num;
    }
}

Console.WriteLine($"Max Value of the Array is : {max}");