


int age = 13;

string name = "Mical";

List<string> City = new List<string> { "colombo", "gampaha", "Kandy"};

var numbers = new int[] {1, 3, 4, 5, 6, 6};


object CheckType(object val) => val switch 
{
        int => "Integer Type",
        string => "String Type",
        List<string> => "List Type",
        Array => "Array Type",
        _ => "Invalid Type"
};

Console.WriteLine(CheckType(age));
Console.WriteLine(CheckType(name));
Console.WriteLine(CheckType(City));
Console.WriteLine(CheckType(numbers));
