using classProperties;


var mical = new Person{
    
    LastName = "Joeshp"
    
};
mical.FirstName = "Mical";
mical.Salary = 60000;

Console.WriteLine($"{mical.FirstName} {mical.LastName} Salary is {mical.Salary}");