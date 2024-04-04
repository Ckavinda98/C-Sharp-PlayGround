var mical = new Person("Mical", "Joshep");
var kamindu = new Person("Mical", "Joshep");

// Console.WriteLine(mical);
// Console.WriteLine(kamindu);


var micalclass = new PersonClass()
{
FirstName = "Mical",
LastName = "Joshep"
};



var kamindulclass = new PersonClass()
{
    FirstName = "Mical",
    LastName = "Joshep"
};


Console.WriteLine(kamindulclass == micalclass);
Console.WriteLine(kamindu == mical);

public class PersonClass
{
    public string FirstName {get; set;}
    public string LastName {get; set;}

} 
public record Person(string FirstName, string LastName);
