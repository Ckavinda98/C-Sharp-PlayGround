


// var people = new List<Person> 
// {
//     new ("mical", "Mical", 19),
//     new ("Kevin", "Kevin", 21),
//     new ("Sadubn", "Sadubn", 12)
// };


// string checkPerson(Person person)
// {
//     return person switch
//     {

//         {Age: var age} when age < 18 => "Minor Person",

//         _ => "Adult"
//     };
// }

// foreach(var p in people)
// {
//     Console.WriteLine(checkPerson(p));
// }

// Console.ReadLine();

// record Person(string FirstName, string LastName, int Age);



// var people = new List<Person>
// {
//     new ("Mical", 12),
//     new ("Mical", 12),
//     new ("Mical", 12),
//     new ("Mical", 12),
//     new ("Mical", 12)
// };


// foreach(var p in people)
// {
//     Console.WriteLine(p);
// };


// record Person(string name, int Age);


var numbers = new int[4] {1,2,3,4};
// var numbers = new int[] {1, 3, 4, 5, 6, 6};

foreach(int num in numbers)
{
    Console.WriteLine($"Each Number : {num}  and Type Of {num.GetType()}");
};