// Relation Pattern 


var numbers = new List<int> {1, -3, -4, 6, 7, 9, 8};

foreach(var num in numbers)
{
    var res = num switch
    {
        < 0 => $"{num} is a Negative Number",
        > 0 => $"{num} is a Positive Number"
    };
    Console.WriteLine(res);
};