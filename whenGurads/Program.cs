


var people = new List<Person> 
{
    new ("mical", "Mical", 19),
    new ("Kevin", "Kevin", 21),
    new ("Sadubn", "Sadubn", 12)
};


string checkPerson(Person person)
{
    return person switch
    {

        {Age: var age} when age < 18 => "Minor Person",

        _ => "Adult"
    };
}

foreach(var p in people)
{
    Console.WriteLine(checkPerson(p));
}

Console.ReadLine();

record Person(string FirstName, string LastName, int Age);