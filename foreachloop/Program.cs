

int[] ids = new int[3];

ids[0] = 20;
ids[1] = 30;
ids[2] = 40;

Console.WriteLine(ids[0]);
Console.WriteLine(ids[1]);
Console.WriteLine(ids[2]);


foreach(var id in ids)
{
    Console.WriteLine($"Id Value is {id}");
}

int[] inventory = {20, 39, 49, 59, 69};

int sum = 0;
int lesSum = 0;

foreach(var item in inventory)
{
    if(item < 40)
    {
        sum = sum + item;
    }
    else
     {
        lesSum = lesSum + item;
     }
}

Console.WriteLine($"This sum of the array {sum}");
Console.WriteLine($"This lesSum of the array {lesSum}");