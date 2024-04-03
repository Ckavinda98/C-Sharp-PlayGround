
ColorMatching("r");
ColorMatching("g");
ColorMatching("b");
ColorMatching("o");
ColorMatching("y");

// value pattern

string color = "7";

var result = color switch
{
    "r" => "Color Is Red",
    "g" => "Color Is Green",
    "b" => "Color Is Blue",
    "o" => "Color Is Orange",
    _ => "Unkown Color"
};

Console.WriteLine(result);

// normal switch case

void ColorMatching(string color)
{
    switch(color)
    {
        case "r":
        Console.WriteLine("Color is Red");
        break;

        case "o":
        Console.WriteLine("Color is Orange");
        break;

        case "b":
        Console.WriteLine("Color is Blue");
        break;

        case "g":
        Console.WriteLine("Color is Green");
        break;

        default:
        Console.WriteLine("Color is Unvalid");
        break;
    }
}