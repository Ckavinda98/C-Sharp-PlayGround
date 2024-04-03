

string CheckGrade(int a) => a switch
{
    < 15 => "Your Grade is F",
     >= 15 and < 35  => "Your Grade is S",
     >= 35 and < 55  => "Your Grade is C",
     >= 55 and < 75  => "Your Grade is B",
    _ => "Your Grade is A"
};

Console.WriteLine(CheckGrade(69));